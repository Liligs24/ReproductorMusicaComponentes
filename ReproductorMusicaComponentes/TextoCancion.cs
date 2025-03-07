using System.Drawing;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class TextoCancion : Label
    {
        public TextoCancion()
        {
            this.Text = "Canción en Reproducción";
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.AutoSize = true;
            this.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
