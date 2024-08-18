using Microsoft.VisualBasic.Devices;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using WEUtils;
namespace SinSala_BIN_2k24___by_CARP
{
    public partial class Form1 : Form
    {
        byte[] header = null;
        private string temporalPath = Application.StartupPath + "Temp\\";
        public string TemporalPath { get { return temporalPath; } }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            dgvBIN.Rows.Clear();
            CargarGrilla();
            FindRawLengths();
            ExtractFile(txtArchivo.Text);
        }
        private void CargarGrilla()
        {
            FileUtils fileUtils = new FileUtils();
            List<byte[]> archivos = new List<byte[]>();
            byte[] info = new byte[2];
            byte[] puntero = new byte[4];
            int indice = 0;
            byte[] archivo;
            int headerSize = 0;
            try
            {

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos BIN | *.bin";
                    ofd.DefaultExt = ".bin";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        txtArchivo.Text = ofd.FileName;
                        archivos = fileUtils.ListadoDeDatos(ofd.FileName);
                    }
                    headerSize = fileUtils.HeaderSize(ofd.FileName);
                }

                using (FileStream fs = new FileStream(txtArchivo.Text, FileMode.Open, FileAccess.Read))
                {
                    header = new byte[headerSize];
                    fs.Position = 0;
                    fs.Read(header, 0, header.Length);
                    fs.Close();
                }

                foreach (byte[] dato in archivos)
                {
                    // Contador
                    indice = dgvBIN.Rows.Add();
                    if ((indice + 1).ToString().Length == 1)
                    {
                        dgvBIN.Rows[indice].Cells["colIndice"].Value = "000" + (indice + 1).ToString();
                    }
                    if ((indice + 1).ToString().Length == 2)
                    {
                        dgvBIN.Rows[indice].Cells["colIndice"].Value = "00" + (indice + 1).ToString();
                    }
                    if ((indice + 1).ToString().Length == 3)
                    {
                        dgvBIN.Rows[indice].Cells["colIndice"].Value = "0" + (indice + 1).ToString();
                    }

                    // Id 0x0A o 0x09
                    info[0] = dato[0];
                    info[1] = dato[1];
                    dgvBIN.Rows[indice].Cells["colID"].Value = BitConverter.ToString(info, 0).Replace("-", "");

                    // VRAMx
                    info = new byte[2];
                    info[0] = dato[2];
                    info[1] = dato[3];
                    dgvBIN.Rows[indice].Cells["colVRAMx"].Value = BitConverter.ToString(info, 0).Replace("-", "");

                    // VRAMy
                    info = new byte[2];
                    info[0] = dato[4];
                    info[1] = dato[5];
                    dgvBIN.Rows[indice].Cells["colVRAMy"].Value = BitConverter.ToString(info, 0).Replace("-", "");

                    // Ancho 
                    info = new byte[2];
                    info[0] = dato[6];
                    info[1] = dato[7];
                    dgvBIN.Rows[indice].Cells["colAncho"].Value = BitConverter.ToString(info, 0).Replace("-", "");

                    // Alto
                    info = new byte[2];
                    info[0] = dato[8];
                    info[1] = dato[9];
                    dgvBIN.Rows[indice].Cells["colAlto"].Value = BitConverter.ToString(info, 0).Replace("-", "");

                    // Tamaño
                    info = new byte[2];
                    info[0] = dato[10];
                    info[1] = dato[11];
                    info = new byte[2];
                    dgvBIN.Rows[indice].Cells["colSize"].Value = BitConverter.ToString(info, 0).Replace("-", "");

                    // Puntero
                    puntero[0] = dato[12];
                    puntero[1] = dato[13];
                    puntero[2] = dato[14];
                    puntero[3] = dato[15];
                    dgvBIN.Rows[indice].Cells["colOffset"].Value = BitConverter.ToString(puntero, 0).Replace("-", "");


                    if (dato[06] == 00 && dato[0] == 0x09)
                    {
                        dgvBIN.Rows[indice].Cells["colTam"].Value = "256";
                    }
                    else
                    {
                        dgvBIN.Rows[indice].Cells["colTam"].Value = "16";
                    }

                    if (dato[0] == 0x0A)
                    {
                        int offset = fileUtils.Puntero(puntero);
                        using (FileStream fs = new FileStream(txtArchivo.Text, FileMode.Open, FileAccess.Read))
                        {
                            fs.Position = offset;
                            archivo = new byte[fs.Length - offset];
                            fs.Read(archivo);
                        }
                        int length = Simsala_BIN.CallFindCompressedLength(archivo);
                        dgvBIN.Rows[indice].Cells["colTam"].Value = length.ToString();
                    }

                    switch (dato[0])
                    {
                        case 0:
                            dgvBIN.Rows[indice].Cells["colTipoDato"].Value = "RAW";
                            break;
                        case 0x0A:
                            dgvBIN.Rows[indice].Cells["colTipoDato"].Value = "GRAFICO";
                            break;
                        case 0x09:
                            dgvBIN.Rows[indice].Cells["colTipoDato"].Value = "PALETA";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void FindRawLengths()
        {
            FileUtils fileUtils = new FileUtils();
            for (int i = 0; i < dgvBIN.Rows.Count; i++)
            {
                if (dgvBIN.Rows[i].Cells["colTipoDato"].Value != DBNull.Value)
                {
                    string dato = Convert.ToString(dgvBIN.Rows[i].Cells["colTipoDato"].Value);
                    if (dato == "RAW")
                    {

                        int alto = fileUtils.ConvertStringToHex(Convert.ToString(dgvBIN.Rows[i].Cells["colAlto"].Value), false);
                        int ancho = fileUtils.ConvertStringToHex(Convert.ToString(dgvBIN.Rows[i].Cells["colAncho"].Value), true);

                        dgvBIN.Rows[i].Cells["colTam"].Value = alto * ancho;
                    }
                }


            }
        }
        private void ExtractFile(string inputFile)
        {
            FileUtils fileUtils = new FileUtils();
            int offset = 0;
            int length = 0;

            if (!Directory.Exists(this.TemporalPath))
                Directory.CreateDirectory(this.TemporalPath);

            foreach (DataGridViewRow row in dgvBIN.Rows)
            {
                if (row.Cells["colTipoDato"].Value == "RAW")
                    length = Convert.ToInt32(row.Cells["colTam"].Value);

                if (row.Cells["colTipoDato"].Value == "PALETA")
                    length = Convert.ToInt32(row.Cells["colTam"].Value) * 2;

                if (row.Cells["colTipoDato"].Value == "GRAFICO")
                    length = Convert.ToInt32(row.Cells["colTam"].Value);

                byte[] puntero = fileUtils.ConvertStringToArrayOfByte(Convert.ToString(row.Cells["colOffset"].Value));
                offset = fileUtils.Puntero(puntero);

                string data = Convert.ToString(row.Cells["colIndice"].Value) + ".bin";
                fileUtils.ExtractCompressedImages(inputFile, this.TemporalPath + data, offset, length);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea cerrar el programa?", "Cerrar programa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Directory.Exists(this.TemporalPath))
                    Directory.Delete(this.TemporalPath, true);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private bool InsertarBMP(string bmpFile)
        {
            bool result = false;
            FileUtils fileUtils = new FileUtils();
            string newBinFile = string.Empty;
            string tempBinFile = Path.GetTempFileName();
            int rowIndex = dgvBIN.CurrentRow.Index;
            try
            {
                newBinFile = this.TemporalPath + Convert.ToString(dgvBIN.Rows[rowIndex].Cells["colIndice"].Value) + ".bin";

                if (fileUtils.ComprimirBMP(bmpFile, tempBinFile))
                {
                    if (File.Exists(tempBinFile))
                    {
                        File.Delete(newBinFile);
                        File.Copy(tempBinFile, newBinFile, true);
                        int length = fileUtils.SetKonamiFileSize(newBinFile);
                        if (length > 0) 
                        dgvBIN.Rows[rowIndex].Cells["colTam"].Value = length;

                    }
                }
                result = File.Exists(newBinFile);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return result;
        }
        private bool InsertarPaletaDesdeBMP(string bmpFile)
        {
            bool result = false;
            FileUtils fileUtils = new FileUtils();
            string newBinFile = string.Empty;
            string tempBinFile = Path.GetTempFileName();
            int rowIndex = dgvBIN.CurrentRow.Index;
            byte[] paletteData = null;
            try
            {
                newBinFile = this.TemporalPath + Convert.ToString(dgvBIN.Rows[rowIndex].Cells["colIndice"].Value) + ".bin";

                if (fileUtils.GetColorPaletteFromBitmap(bmpFile, out paletteData))
                {
                    if (File.Exists(tempBinFile))
                    {
                        File.Delete(newBinFile);
                        File.WriteAllBytes(tempBinFile, paletteData);
                        File.Copy(tempBinFile, newBinFile, true);
                        long length = new FileInfo(newBinFile).Length;
                        dgvBIN.Rows[rowIndex].Cells["colTam"].Value = length;
                    }
                }
                result = File.Exists(newBinFile);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Muestra en el menú solo los ítems que correspondan estar habilitados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBIN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string tipo = string.Empty;
            tipo = Convert.ToString(dgvBIN.Rows[e.RowIndex].Cells["colTipoDato"].Value);
            string ancho = Convert.ToString(dgvBIN.Rows[e.RowIndex].Cells["colAncho"].Value);
            string alto = Convert.ToString(dgvBIN.Rows[e.RowIndex].Cells["colAlto"].Value);
            if (string.IsNullOrEmpty(tipo))
                return;

            if (tipo.ToUpper() == "GRAFICO")
            {
                // RAW
                tsInsertarRAW.Enabled = false;
                tsInsertarRAW.Text = "Insertar gráfico RAW";
                // GRAFICO
                tsInsertarGrafico.Enabled = true;
                tsInsertarBIN.Enabled = true;
                // PALETA
                tsInsertarPaletaBIN.Enabled = false;
                tsInsertarPaleta.Enabled = false;
            }
            if (tipo.ToUpper() == "PALETA")
            {
                // RAW
                tsInsertarRAW.Enabled = false;
                tsInsertarRAW.Text = "Insertar gráfico RAW";
                // GRAFICO
                tsInsertarGrafico.Enabled = false;
                tsInsertarBIN.Enabled = false;
                // PALETA
                tsInsertarPaletaBIN.Enabled = true;
                tsInsertarPaleta.Enabled = true;
            }
            if (tipo.ToUpper() == "RAW")
            {
                // RAW
                tsInsertarRAW.Enabled = true;
                tsInsertarRAW.Text = string.Empty;
                tsInsertarRAW.Text = $"Insertar gráfico RAW  ({ancho} x {alto})";
                // GRAFICO
                tsInsertarGrafico.Enabled = false;
                tsInsertarBIN.Enabled = false;
                // PALETA
                tsInsertarPaletaBIN.Enabled = false;
                tsInsertarPaleta.Enabled = false;
            }
            Point point = new Point(MousePosition.X, MousePosition.Y);
            popUp.Show(point);
        }
        private void tsInsertarGrafico_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvBIN.CurrentRow.Index;
            tsInsertarRAW.Text = "Insertar gráfico RAW ";
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos BMP | *.BMP";
                    ofd.DefaultExt = ".bmp";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        if (InsertarBMP(ofd.FileName))
                        {
                            MessageBox.Show("Se insertó con éxito.");
                        }
                        else
                            MessageBox.Show("Error al insertar el archivo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tsInsertarBIN_Click(object sender, EventArgs e)
        {
            InsertarBinInFile();
            tsInsertarRAW.Text = "Insertar gráfico RAW ";
        }
        private bool InsertarBinInFile()
        {
            FileUtils fileUtils = new FileUtils();
            bool result = false;
            int rowIndex = 0;
            string bin = string.Empty;
            string grafico = string.Empty;
            try
            {
                if (dgvBIN.CurrentRow.Index >= 0)
                {
                    rowIndex = dgvBIN.CurrentRow.Index;
                    bin = this.TemporalPath + Convert.ToString(dgvBIN.Rows[rowIndex].Cells["colIndice"].Value) + ".bin";
                    grafico = Convert.ToString(dgvBIN.Rows[rowIndex].Cells["colTipoDato"].Value);
                }
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos BIN | *.BIN";
                    ofd.DefaultExt = ".bin";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(bin))
                        {
                            File.Copy(ofd.FileName, bin, true);
                            // SI ES GRAFICO AGREGAMOS LOS CEROS SI HACEN FALTA
                            if (grafico.ToUpper() == "GRAFICO")
                            {
                                long length = fileUtils.SetKonamiFileSize(bin);
                                dgvBIN.Rows[rowIndex].Cells["colTam"].Value = length;
                            }
                            // SI ES PALETA, SE PONEN LOS BYTES COMO ESTÁN
                            else
                            {
                                long length = new FileInfo(bin).Length;
                                dgvBIN.Rows[rowIndex].Cells["colTam"].Value = length;
                            }
                            result = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        private bool InsertarRAW()
        {
            FileUtils fileUtils = new FileUtils();
            int rowIndex = 0;
            int ancho = 0;
            int alto = 0;
            int resolucion = 0;
            bool result = false;
            string bloqueBIN = string.Empty;
            try
            {
                rowIndex = dgvBIN.CurrentRow.Index;
                if (rowIndex < 0)
                    return result;

                rowIndex = dgvBIN.CurrentRow.Index;
                ancho = fileUtils.ConvertStringToHex(dgvBIN.Rows[rowIndex].Cells["colAncho"].Value.ToString(), true);
                alto = fileUtils.ConvertStringToHex(dgvBIN.Rows[rowIndex].Cells["colAlto"].Value.ToString(), true);
                bloqueBIN = dgvBIN.Rows[rowIndex].Cells["colID"].Value.ToString();
                resolucion = ancho * alto;

                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        long length = new FileInfo(ofd.FileName).Length;
                        if (length != resolucion)
                        {
                            MessageBox.Show("El archivo RAW tiene un tamaño diferente al esperado");
                            return result;
                        }

                        if (File.Exists(ofd.FileName))
                        {
                            File.Copy(ofd.FileName, bloqueBIN, true);
                            dgvBIN.Rows[rowIndex].Cells["colTam"].Value = length;
                            result = true;

                        }
                    }
                }
                if (result)
                    MessageBox.Show("Archivo insertado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        private void btnCrearBIN_Click(object sender, EventArgs e)
        {
            FileUtils fileUtils = new FileUtils();
            List<string> lineas = new List<string>();
            string linea = string.Empty;
            try
            {
                if (dgvBIN.Rows.Count < 0)
                    return;

                foreach (DataGridViewRow row in dgvBIN.Rows)
                {
                    for (int i = 1; i < 8; i++)
                    {
                        linea += Convert.ToString(row.Cells[i].Value);
                    }
                    lineas.Add(linea);
                    linea = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tsInsertarPaleta_Click(object sender, EventArgs e)
        {
            FileUtils fileUtils = new FileUtils();
            string mensaje = string.Empty;
            tsInsertarRAW.Text = "Insertar gráfico RAW ";
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Archivos BMP | *.bmp";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        if (InsertarPaletaDesdeBMP(ofd.FileName))
                        {
                            mensaje = "Se insertó correctamente";
                        }
                        else
                        {
                            mensaje = "Error al insertar el archivo";
                        }
                    }
                    if (File.Exists(ofd.FileName))
                    {
                        MessageBox.Show(mensaje);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tsInsertarPaletaBIN_Click(object sender, EventArgs e)
        {
            InsertarBinInFile();
            tsInsertarRAW.Text = "Insertar gráfico RAW ";
        }
        private void tsInsertarRAW_Click(object sender, EventArgs e)
        {
            InsertarRAW();
            tsInsertarRAW.Text = "Insertar gráfico RAW ";

        }
        private void tsCandelar_Click(object sender, EventArgs e)
        {
            tsInsertarRAW.Text = "Insertar gráfico RAW ";
        }
    }
}
