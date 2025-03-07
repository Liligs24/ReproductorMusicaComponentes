using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class BotonGuardar : UserControl
    {
        private Label fileIcon;

        [Category("Appearance")]
        public Color ButtonColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; Invalidate(); }
        }
        public BotonGuardar()
        {
            this.Size = new Size(50, 50);
            this.BackColor = Color.FromArgb(98, 0, 238); // Color corregido

            fileIcon = new Label
            {
                Text = "\U0001F4C1", // Código Unicode para 📁
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            Controls.Add(fileIcon);
            SetCircularRegion();
        }

        private void SetCircularRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}