using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class SliderProgreso : TrackBar
    {
        public event EventHandler ValorCambiado; // Evento personalizado

        public SliderProgreso()
        {
            this.Minimum = 0;
            this.Maximum = 100;
            this.Value = 0;
            this.TickStyle = TickStyle.None; // Oculta marcas
            this.BackColor = Color.Transparent;
            this.Size = new Size(200, 30);

            // Color del "thumb" y barra
            this.SetStyle(ControlStyles.UserPaint, true);

            this.Scroll += (s, e) => ValorCambiado?.Invoke(this, EventArgs.Empty);
        }
    }
}
