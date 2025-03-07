using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class TextoCanciones : Panel
    {
        private Label titulo;
        private Label subtitulo;

        public TextoCanciones()
        {
            this.Size = new Size(250, 50);
            this.BackColor = Color.Transparent; // Fondo transparente

            // Texto principal: "Canción en Reproducción"
            titulo = new Label
            {
                Text = "Canción en Reproducción",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top
            };

            // Subtítulo: "C# WPF Mp3 Music Player"
            subtitulo = new Label
            {
                Text = "C# WPF Mp3 Music Player",
                Font = new Font("Arial", 9, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Bottom
            };

            // Alinear textos en el centro del panel
            titulo.TextAlign = ContentAlignment.MiddleCenter;
            subtitulo.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(subtitulo);
            this.Controls.Add(titulo);
        }
    }
}
