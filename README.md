# 🎵 Componentes Personalizados DLL - Music App Windows Forms  

Este repositorio contiene una **biblioteca de componentes personalizados** para construir una interfaz moderna en una aplicación de música con **Windows Forms**.  

## 📌 **Componentes Incluidos**  

| Componente             | Descripción |
|------------------------|-------------|
| **BotonCerrar**        | Botón de cierre de la aplicación. |
| **BotonGuardar**       | Botón para guardar archivos o configuraciones. |
| **BotonNavegacion**    | Botón para siguiente/anterior canción. |
| **BotonReproducir**    | Botón de reproducción/pausa. |
| **ControlDeslizador**  | Control para manejar el volumen o progreso de la canción. |
| **ControlProgreso**    | Barra de progreso de la reproducción. |
| **EtiquetaTiempo**     | Muestra el tiempo actual de la canción. |
| **ImagenAlbum**        | Muestra la carátula del álbum o icono de la canción. |
| **ListaCanciones**     | Lista de canciones disponibles. |
| **PanelReproductor**   | Contenedor para organizar los controles del reproductor. |
| **SliderProgreso**     | Slider personalizado para el progreso de la música. |
| **TextoCancion**       | Muestra el nombre y subtítulo de la canción. |

---

## ℹ **Características de los Componentes**  

✔ **Personalizables**: Todos los componentes pueden cambiar de color y tamaño desde las propiedades de Visual Studio.  
✔ **Botones Funcionales**: `BotonReproducir`, `BotonNavegacion` y `BotonCerrar` están listos para usarse.  
✔ **Interfaz Moderna**: `SliderProgreso` y `ControlProgreso` tienen diseño mejorado.  
✔ **Imagen Configurable**: `ImagenAlbum` permite cambiar la imagen de la carátula.  
✔ **Fácil de Usar**: Se agregan como cualquier otro control en Windows Forms.  

---

## 📂 **Instalación y Uso**  

### 🔹 **1. Agregar la DLL a un Proyecto de Windows Forms**  
1. **Compila la solución** para generar `ReproductorMusicaComponentes.dll`.  
2. En **Visual Studio**, ve a **Referencias** → **Agregar Referencia**.  
3. Selecciona el archivo **`ReproductorMusicaComponentes.dll`** ubicado en `bin\Debug`.  
4. ¡Listo! Ahora puedes usar los componentes en tu proyecto.  

### 🔹 **2. Ejemplo de Uso en `Form1.cs`**  
Después de agregar la DLL, puedes utilizar los componentes en tu formulario:

```csharp
using System;
using System.Drawing;
using System.Windows.Forms;
using ReproductorMusicaComponentes; // Importar la DLL

namespace MusicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Agregar un botón de reproducción
            BotonReproducir playButton = new BotonReproducir();
            playButton.Location = new Point(100, 200);
            this.Controls.Add(playButton);

            // Agregar una barra de progreso
            SliderProgreso slider = new SliderProgreso();
            slider.Location = new Point(50, 250);
            this.Controls.Add(slider);

            // Agregar el nombre de la canción
            TextoCancion songName = new TextoCancion();
            songName.Location = new Point(80, 100);
            this.Controls.Add(songName);
        }
    }
}
