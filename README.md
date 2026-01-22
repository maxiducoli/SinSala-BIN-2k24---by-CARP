# SinSala-BIN-2k24 — by CARP

🎨 *Herramienta para crear y modificar archivos `.BIN` que contienen gráficos y paletas de color para Winning Eleven 2002 y sus variantes.*

Este proyecto permite gestionar archivos **`.BIN`** utilizados por *Winning Eleven 2002* (versión PC) para almacenar **recursos visuales**: sprites de menús, íconos, banderas, escudos, fondos, y otros elementos de interfaz. Cada archivo BIN contiene **imágenes indexadas** junto con sus **paletas de color (CLUT)**, separadas pero vinculadas internamente.

Desarrollado bajo el pseudónimo **CARP**, este utilitario nace de la necesidad de personalizar la estética del juego más allá de los límites del editor oficial: reemplazar escudos, traducir menús, o incluso crear interfaces completamente nuevas.

---

## 🖼️ ¿Qué contiene un archivo `.BIN` en este contexto?

- **Gráficos indexados**: Imágenes en formato similar a 8bpp (256 colores máximo).
- **Paletas de color (.PAL o CLUT)**: Tablas que definen qué color representa cada índice.
- **Estructura fija**: El juego espera cierto número de imágenes y una organización específica según el archivo (ej. `MENU.BIN`, `FLAG.BIN`, etc.).

> 🔧 Esta herramienta te permite **inyectar tus propios gráficos y paletas** manteniendo la estructura esperada por el motor del juego.

---

## 🛠️ Funcionalidad principal

- Leer archivos `.BIN` existentes y extraer sus gráficos y paletas.
- Reemplazar imágenes individuales o toda la colección.
- Asociar nuevas paletas a los gráficos importados.
- Guardar un nuevo archivo `.BIN` compatible con *Winning Eleven 2002*.
- Previsualización básica de los gráficos (según implementación).

> ⚠️ **Requisito**: Los gráficos deben estar en formato indexado (8bpp) y coincidir con las dimensiones originales del recurso que reemplazan.

---

## 💻 Tecnología

- **Lenguaje**: C#  
- **Framework**: .NET (Windows Forms o consola)  
- **Tipo**: Utilidad de escritorio para modding gráfico retro

---

## 🧠 Inspiración

> *"No quería solo cambiar jugadores... quería que hasta el menú dijera 'Bienvenido, CARP'."*

Este proyecto es parte de mi obsesión por controlar **cada píxel** del juego. Si el RA Maker le dio voz a *Winning Eleven*, **SinSala-BIN le da rostro**.

El nombre "**SinSala**" rinde homenaje a esos años de jugar sin sala de estar, en la computadora del cuarto, desensamblando archivos BIN con un editor hexadecimal… hasta que decidí automatizarlo.

---

## 📜 Licencia

Uso permitido con fines **no comerciales**. Si reutilizás el código o la idea, citá a **Maximiliano Ducoli (CARP)** como autor original.

---

🕹️ ¡Dale tu estilo visual al juego que tanto amaste!
