﻿using System;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WEUtils
{
    public class FileUtils
    {
        enum Punteros : uint
        {
            p_0C80 = 0x8000,
            p_0D80 = 0x8000,
            p_0E80 = 0x18000,
            p_0F80 = 0,
            P_1080 = 0x010000,
            P_1180 = 0x020000,
            P_1280 = 0x030000
        }
        enum TipoPuntero : uint
        {
            puntero_0C = 2148270080, /*800C0000*/
            puntero_0D = 2148335616, /*800D0000*/
            puntero_0E = 2148401152, /*800E0000*/
            puntero_0F = 2148466688, /*800F0000*/
            puntero_10 = 2148532224, /*80100000*/
            puntero_11 = 2148597760, /*80110000*/
            puntero_12 = 2148663296  /*80120000*/
        }
        // Obtenemos el tamaño del header del BIN
        public int HeaderSize(string filePath)
        {
            int result = 0;
            int offsetIndice = 0;
            int offsetDatos = 0;
            byte[] datos = new byte[4];
            byte[] offset = new byte[16];
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // Leemos los datos de la cabecera
                    fs.Seek(0, SeekOrigin.Begin);
                    fs.Read(datos, 0, datos.Length);
                    // Vamos al offset del índice
                    offsetIndice = Puntero(datos);
                    fs.Position = offsetIndice;
                    fs.Read(offset, 0, offset.Length);
                    datos[0] = offset[12];
                    datos[1] = offset[13];
                    datos[2] = offset[14];
                    datos[3] = offset[15];

                }

                result = Puntero(datos);
            }
            catch (Exception ex)
            {
                throw new IOException(ex.Message);
            }
            return result;
        }
        // Obtenemos el offset del array de bytes
        public int Puntero(byte[] datos)
        {
            int result = 0;
            byte[] bytes = new byte[4];
            bytes[0] = 0;
            bytes[1] = 0;
            bytes[2] = datos[2];
            bytes[3] = datos[3];
            TipoPuntero tipoPuntero = (TipoPuntero)BitConverter.ToInt32(bytes, 0);
            int pt = BitConverter.ToInt32(bytes, 0);
            Array.Clear(bytes, 0, bytes.Length - 1);
            try
            {
                bytes[0] = datos[0];
                bytes[1] = datos[1];
                bytes[2] = 0;
                bytes[3] = 0;
                switch (tipoPuntero)
                {
                    case TipoPuntero.puntero_0C:
                        result = BitConverter.ToInt32(bytes) - (int)Punteros.p_0C80;
                        break;
                    case TipoPuntero.puntero_0D:
                        result = BitConverter.ToInt32(bytes) + (int)Punteros.p_0D80;
                        break;
                    case TipoPuntero.puntero_0E:
                        result = BitConverter.ToInt32(bytes) + (int)Punteros.p_0E80;
                        break;
                    case TipoPuntero.puntero_0F:
                        result = BitConverter.ToInt32(bytes) + (int)Punteros.p_0F80;
                        break;
                    case TipoPuntero.puntero_10:
                        result = BitConverter.ToInt32(bytes) + (int)Punteros.P_1080;
                        break;
                    case TipoPuntero.puntero_11:
                        result = BitConverter.ToInt32(bytes) + (int)Punteros.P_1180;
                        break;
                    case TipoPuntero.puntero_12:
                        result = BitConverter.ToInt32(bytes) + (int)Punteros.P_1280;
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

                throw new IOException(ex.Message);
            }

            return result;
        }
        // Retorna el listado de offsets que apuntan al índice del archivo BIN
        public List<int> ObtenerListadoOffset(string pathArchivo, int HeaderSize)
        {
            List<int> result = new List<int>();
            int offset = 0;
            int contador = 0;
            byte[] buffer = new byte[4];
            try
            {
                using (FileStream fs = new FileStream(pathArchivo, FileMode.Open, FileAccess.Read))
                {
                    while (contador <= HeaderSize)
                    {
                        fs.Position = contador;
                        fs.Read(buffer, 0, buffer.Length);
                        offset = Puntero(buffer);
                        if (offset > 0)
                        {
                            result.Add(offset);
                        }
                        contador = contador + 4;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new IOException(ex.Message);
            }

            return result;
        }
        // Retorna el listado de gráficos y paletas del BIN
        //public List<byte[]> ListadoDeDatos(string pathArchivo)
        //{
        //    List<byte[]> result = new List<byte[]>();
        //    List<byte[]> r = new List<byte[]>();
        //    // Tamaño del header
        //    int header = 0;
        //    // Listado de offsets de los índices
        //    List<int> listOffsetsIndices = new List<int>();
        //    // buffer de punteros
        //    byte[] buffer = new byte[16];
        //    byte[] arrayCorte = new byte[4];
        //    byte[] arrayCorte2 = { 0xFF, 0x00, 0x00, 0x00 };
        //    int offsetTemp = 0;
        //    try
        //    {
        //        header = HeaderSize(pathArchivo);
        //        listOffsetsIndices = ObtenerListadoOffset(pathArchivo, header);

        //        foreach (int offset in listOffsetsIndices)
        //        {
        //            offsetTemp = offset;
        //            using (FileStream fs = new FileStream(pathArchivo, FileMode.Open, FileAccess.Read))
        //            {
        //                fs.Position = offsetTemp;
        //                fs.Read(buffer, 0, buffer.Length);
        //                arrayCorte[0] = buffer[0];
        //                arrayCorte[1] = buffer[1];
        //                arrayCorte[2] = buffer[2];
        //                arrayCorte[3] = buffer[3];


        //                while (!arrayCorte.SequenceEqual(arrayCorte2)) 
        //                {
        //                    r.Add(buffer);
        //                    offsetTemp += 16;
        //                    fs.Position = offsetTemp;
        //                    fs.Read(buffer, 0, buffer.Length);
        //                    arrayCorte[0] = buffer[0];
        //                    arrayCorte[1] = buffer[1];
        //                    arrayCorte[2] = buffer[2];
        //                    arrayCorte[3] = buffer[3];
        //                }
        //            }
        //        }
        //        result = r;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new IOException(ex.Message);
        //    }

        //    return result;
        //}
        public List<byte[]> ListadoDeDatos(string pathArchivo)
        {
            List<byte[]> result = new List<byte[]>();
            // Tamaño del header
            int header = 0;
            // Listado de offsets de los índices
            List<int> listOffsetsIndices = new List<int>();
            byte[] arrayCorte = new byte[4];
            byte[] arrayCorte2 = { 0xFF, 0x00, 0x00, 0x00 };
            byte[] finalLinea = { 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00,0x00,0x00,0x00,0x00};
            int offsetTemp = 0;
            try
            {
                header = HeaderSize(pathArchivo);
                listOffsetsIndices = ObtenerListadoOffset(pathArchivo, header);

                foreach (int offset in listOffsetsIndices)
                {
                    offsetTemp = offset;
                    using (FileStream fs = new FileStream(pathArchivo, FileMode.Open, FileAccess.Read))
                    {
                        fs.Position = offsetTemp;
                        int bytesRead = fs.Read(arrayCorte, 0, arrayCorte.Length);

                        while (bytesRead == arrayCorte.Length && !arrayCorte.SequenceEqual(arrayCorte2))
                        {
                            byte[] buffer = new byte[16];
                            Buffer.BlockCopy(arrayCorte, 0, buffer, 0, arrayCorte.Length);
                            fs.Position = offsetTemp + arrayCorte.Length;
                            bytesRead = fs.Read(buffer, arrayCorte.Length, buffer.Length - arrayCorte.Length);

                            result.Add(buffer);
                            offsetTemp += buffer.Length;
                            fs.Position = offsetTemp;
                            bytesRead = fs.Read(arrayCorte, 0, arrayCorte.Length);
                        }
                        result.Add(finalLinea);
                    }
                }
                result = result;
            }
            catch (Exception ex)
            {
                throw new IOException(ex.Message);
            }

            return result;
        }
        public long FindCompressedLength(byte[] bufSrc)
        {
            long counter = 0;
            ulong i = 0;
            byte k, k2;

            int index = 0;

            while (true)
            {
                if ((i & 0x100) == 0)
                {
                    k = bufSrc[index];
                    index++; // add pointer
                    counter++; // counter
                    i = (ulong)(k | 0xFF00);
                }

                if (bufSrc[index] == 0 && bufSrc[index + 1] == 0 && bufSrc[index + 2] == 0 && bufSrc[index + 3] == 0)
                    return 0; // exit invalid compressed block

                k2 = bufSrc[index];

                if (((byte)i & 1) == 0)
                {
                    index++;
                    counter++; // counter
                }
                else
                {
                    if ((k2 & 0x80) != 0)
                    {
                        index++; // add pointer
                        counter++; // counter

                        if ((k2 & 0x40) != 0)
                        {
                            k = k2;
                            long k3 = k - 0xB9;
                            if (k == 0xFF)
                                break; // exit

                            while (k3-- >= 0)
                            {
                                k2 = bufSrc[index];
                                index++; // add pointer
                                counter++; // counter
                            }

                            i >>= 1; // i SHR 1
                            continue;
                        }
                    }
                    else
                    {
                        byte j = bufSrc[index + 1];
                        index += 2; // add pointer by 2
                        counter += 2; // counter
                    }
                }

                i >>= 1;
            }

            return counter;
        }
        public byte[] Palette(string path, int offset, int length)
        {
            byte[] palette = null;
            if (length == 4)
            {
                palette = new byte[32];
            }
            else
            {
                palette = new byte[512];
            }
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    fs.Position = offset;
                    fs.Read(palette, 0, palette.Length);
                }
            }
            catch (Exception ex)
            {

                throw new IOException(ex.Message);
            }

            return palette;
        }
        public Color[] ConvertTIMBytesToColors(byte[] timPaletteData)
        {
            // Calcular el número de colores en la paleta TIM
            int numColors = timPaletteData.Length / 2;

            // Crear un array de Color para almacenar los colores
            Color[] colors = new Color[numColors];

            // Convertir cada color de la paleta TIM a Color
            for (int i = 0; i < numColors; i++)
            {
                // Extraer los componentes R, G, B del ushort de la paleta TIM
                ushort colorData = BitConverter.ToUInt16(timPaletteData, i * 2);

                // Convertir de 16 bits (TIM) a 24 bits (Color)
                int r = (colorData & 0x1F) << 3;   // 5 bits de rojo
                int g = (colorData >> 5 & 0x1F) << 3; // 5 bits de verde
                int b = (colorData >> 10 & 0x1F) << 3; // 5 bits de azul

                // Crear el color y agregarlo al array de colors
                colors[i] = Color.FromArgb(r, g, b);
            }

            return colors;
        }
        public byte[] ConvertPalette_TIMtoBMP(byte[] timPalette, int bitDepth)
        {
            int colorsCount = bitDepth == 4 ? 16 : 256;
            byte[] bmpPalette = new byte[colorsCount * 4];

            for (int i = 0; i < colorsCount; i++)
            {
                int timIndex = i * 2;
                int bmpIndex = i * 4;

                ushort color = BitConverter.ToUInt16(timPalette, timIndex);

                byte r = (byte)((color & 0x1F) << 3);
                byte g = (byte)(((color >> 5) & 0x1F) << 3);
                byte b = (byte)(((color >> 10) & 0x1F) << 3);

                bmpPalette[bmpIndex] = b;
                bmpPalette[bmpIndex + 1] = g;
                bmpPalette[bmpIndex + 2] = r;
                bmpPalette[bmpIndex + 3] = 0; // Alpha
            }

            return bmpPalette;
        }
        public int ConvertStringToHex(string s, bool esVRAMx)
        {
            int result = 0;
            string numero = string.Empty;
            try
            {
                // Paso 1: Invertir el string
                string stringByte = s.Substring(0, 2);
                char[] charArray = stringByte.ToCharArray();
                //Array.Reverse(charArray);
                string hexCorrecto = new string(charArray);

                // Paso 2: Convertir el string HEX a decimal
                int valor = Convert.ToInt32(hexCorrecto, 16);
                result = esVRAMx == true ? valor * 2 : valor;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return result;
        }
        public void ExtractCompressedImages(string inputFilePath, string outputFilePath, int offset, int length)
        {
            byte[] data = new byte[length];
            try
            {
                using (FileStream fs = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                {
                    fs.Position = offset;
                    fs.Read(data, 0, data.Length);
                }
                File.WriteAllBytes(outputFilePath, data);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public byte[] ConvertStringToArrayOfByte(string hex)
        {
            // Crear un array de bytes con la mitad del tamaño del string hexadecimal
            int numBytes = hex.Length / 2;
            byte[] bytes = new byte[numBytes];

            for (int i = 0; i < numBytes; i++)
            {
                // Tomar cada par de caracteres hexadecimales y convertirlo a byte
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }

            return bytes;
        }
        public bool ComprimirBMP(string bmp, string bin)
        {
            string temp = Path.GetTempFileName();
            bool result = false;
            try
            {
                result = Simsala_BIN.CompressBMPImage(bmp, temp, bin);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool CrearBIN(string outputFilePath, byte[] header, List<byte[]> data)
        {
            bool result = false;

            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
        public List<byte[]> ConvertStringToByteArray(List<string> str)
        {
            List<byte[]> result = new List<byte[]>();
            try
            {
                foreach (string str2 in str)
                {
                    result.Add(BitConverter.GetBytes(str2[0]));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public void RecalcularOffsetIndice(string offset, int oldFile, int newfile)
        {
            string tipoPuntero = string.Empty;
            int valorPuntero = 0;
            byte[] bytes = new byte[4];
            int offsetPuntero = 0;
            try
            {
                tipoPuntero = offset.Substring(28, 2);
                byte indicePuntero = Convert.ToByte(tipoPuntero);
                bytes = ConvertStringToArrayOfByte(offset);
                // Valor puntero
                offsetPuntero = Puntero(bytes);
                switch (indicePuntero)
                {
                    case 0x0C:
                        valorPuntero = -0x8000;
                        break;
                    case 0x0D:
                        valorPuntero = 0x8000;
                        break;
                    case 0x0E:
                        valorPuntero = 0x18000;
                        break;
                    case 0x0F:
                        valorPuntero = 0x00;
                        break;
                    case 0x10:
                        valorPuntero = 0x1000;
                        break;
                    case 0x11:
                        valorPuntero = 0x2000;
                        break;
                    case 0x12:
                        valorPuntero = 0x3000;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Color[] PaletaToColor(string file)
        {
            Color[] result = null;
            try
            {
                Bitmap bmp = new Bitmap(file);
                int size = bmp.Palette.Entries.Length;
                result = new Color[size];
                for (int i = 0; i < size; i++)
                {
                    result[i] = bmp.Palette.Entries[i];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
        public bool GetColorPaletteFromBitmap(string bmpFile, out byte[] paletaColores)
        {
            bool result = false;
            //   ClsGraphics clsGraphics = new ClsGraphics();
            Bitmap bmp = new Bitmap(bmpFile);
            paletaColores = null;
            //int cantidadColores = bpp == 16 ? 1 : 256;
            int clutColors = bmp.PixelFormat == PixelFormat.Format4bppIndexed ? 16 : 256;

            Color[] palette = new Color[clutColors];
            palette = PaletaToColor(bmpFile);

            paletaColores = new byte[clutColors * 2];
            for (int i = 0; i < clutColors; i++)
            {
                Color color = palette[i];
                int timColor = (color.R >> 3) | ((color.G >> 3) << 5) | ((color.B >> 3) << 10);
                paletaColores[i * 2] = (byte)timColor;
                paletaColores[i * 2 + 1] = (byte)(timColor >> 8);
            }
            if (paletaColores != null)
            {
                result = true;
            }
            return result;
        }
        /// <summary>
        /// Setea los BIN comprimidos al largo de Konami
        /// </summary>
        /// <param name="binFile"></param>
        /// <returns></returns>
        public int SetKonamiFileSize(string binFile)
        {
            int result = 0;
            double largoArchivo = 0;
            double resto = 0;
            byte[] bytesToAdd = null;

            using (FileStream fs = new FileStream(binFile, FileMode.Append, FileAccess.Write))
            {
                long length = fs.Length;

                largoArchivo = ((double)length) / 16;
                resto = largoArchivo - Math.Floor(largoArchivo);
                if (resto == 0)
                { 
                    return (int)length;
                }


                // Seteamos el largo correcto de los BIN
                // Largo + 00
                largoArchivo = ((double)length + 1) / 16;
                resto = largoArchivo - Math.Floor(largoArchivo);
                if ((resto == 0) || (resto == 0.25) ||
                    (resto == 0.50) || (resto == 0.75))
                    bytesToAdd = new byte[1];


                //Largo + 0000
                largoArchivo = ((double)length + 2) / 16;
                resto = largoArchivo - Math.Floor(largoArchivo);
                if ((resto == 0) || (resto == 0.25) ||
                    (resto == 0.50) || (resto == 0.75))
                    bytesToAdd = new byte[2];

                //Largo + 000000
                largoArchivo = ((double)length + 3) / 16;
                resto = largoArchivo - Math.Floor(largoArchivo);
                if ((resto == 0) || (resto == 0.25) ||
                    (resto == 0.50) || (resto == 0.75))
                    bytesToAdd = new byte[3];

                //Largo + 00000000
                largoArchivo = ((double)length + 4) / 16;
                resto = largoArchivo - Math.Floor(largoArchivo);
                if ((resto == 0) || (resto == 0.25) ||
                    (resto == 0.50) || (resto == 0.75))
                    bytesToAdd = new byte[4];
                result = (int)fs.Length + bytesToAdd.Length;

                fs.Write(bytesToAdd, 0, bytesToAdd.Length);
            }
            return result;
        }
    }
}