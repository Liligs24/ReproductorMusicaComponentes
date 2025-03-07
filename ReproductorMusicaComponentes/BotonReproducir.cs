using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class BotonReproducir : UserControl
    {
        private Label playIcon;

        [Category("Appearance")]
        public Color ButtonColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; Invalidate(); }
        }

        public BotonReproducir()
        {
            this.Size = new Size(50, 50);
            this.BackColor = Color.Green;

            playIcon = new Label
            {
                Text = "▶",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(playIcon);
            SetCircularRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetCircularRegion(); 
        }

        private void SetCircularRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width - 1, Height - 1);
            this.Region = new Region(path);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}