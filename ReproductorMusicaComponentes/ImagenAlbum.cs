using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class ImagenAlbum : PictureBox
    {
        public ImagenAlbum()
        {
            this.Size = new Size(100, 100);
            this.BackColor = Color.FromArgb(120, 0, 0); 
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            
            string imagePath = Path.Combine(Application.StartupPath, "images", "");


            if (File.Exists(imagePath))
            {
                this.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("No se encontró la imagen: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
