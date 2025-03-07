using System.Drawing;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class PanelReproductor : Panel
    {
        public PanelReproductor()
        {
            this.Size = new Size(250, 400);
            this.BackColor = Color.FromArgb(20, 20, 20); // Negro oscuro
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
