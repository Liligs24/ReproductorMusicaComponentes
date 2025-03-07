using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class ControlDeslizador : TrackBar
    {
        public ControlDeslizador()
        {
            this.Minimum = 0;
            this.Maximum = 100;
            this.Value = 50; // Volumen inicial en 50%
            this.TickStyle = TickStyle.None;
            this.BackColor = Color.Transparent;
            this.Width = 150;
        }
    }
}
