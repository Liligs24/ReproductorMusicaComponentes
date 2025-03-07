using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class EtiquetaTiempo : Label
    {
        public EtiquetaTiempo(string tiempo)
        {
            this.Text = tiempo;
            this.Font = new Font("Arial", 9, FontStyle.Regular);
            this.ForeColor = Color.White;
            this.AutoSize = true;
        }

        public void ActualizarTiempo(double tiempo)
        {
            this.Text = tiempo.ToString("0.00");
        }
    }
}
