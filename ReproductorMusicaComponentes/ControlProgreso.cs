using System.Drawing;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class ControlProgreso : TrackBar
    {
        public ControlProgreso()
        {
            this.Minimum = 0;
            this.Maximum = 100;
            this.Value = 0;
            this.TickStyle = TickStyle.None;
            this.Width = 200;
            this.BackColor = Color.Black; 
        }
    }
}
