using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ReproductorMusicaComponentes
{
    public class BotonCerrar : UserControl
    {
        private Label closeIcon;

        [Category("Appearance")]
        public Color ButtonColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; Invalidate(); }
        }

        public BotonCerrar()
        {
            this.Size = new Size(45, 45); // Ajuste de tamaño para visibilidad
            this.BackColor = Color.FromArgb(150, 0, 0); // Rojo más visible
            this.Visible = true; // Asegurar que el botón se renderiza

            closeIcon = new Label
            {
                Text = "✖", // Icono de cerrar
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(closeIcon);
            SetCircularRegion();

            // Evento para cerrar la aplicación al hacer clic
            this.Click += (s, e) => Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetCircularRegion(); // Mantener forma circular al redimensionar
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
