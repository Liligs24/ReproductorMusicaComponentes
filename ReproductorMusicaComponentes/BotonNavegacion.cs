using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class BotonNavegacion : Button
    {
        private Label icon;

        [Category("Appearance")]
        public Color ButtonColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; Invalidate(); }
        }

        [Category("Appearance")]
        public bool RotateLeft { get; set; } = false;

        public BotonNavegacion()
        {
            this.Size = new Size(50, 50);
            this.BackColor = Color.Blue;
            this.Paint += PlayNextOrRewindButton_Paint;

            icon = new Label
            {
                Text = RotateLeft ? "⏪" : "⏩", // Icono según la dirección
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(icon);
            this.Resize += (s, e) => SetCircularRegion();
            SetCircularRegion();
        }

        private void SetCircularRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, Width - 1, Height - 1);
                this.Region = new Region(path);
            }
            this.Invalidate();
        }

        private void PlayNextOrRewindButton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen pen = new Pen(this.BackColor, 2))
            {
                e.Graphics.DrawEllipse(pen, 1, 1, Width - 3, Height - 3);
            }
        }
    }
}
