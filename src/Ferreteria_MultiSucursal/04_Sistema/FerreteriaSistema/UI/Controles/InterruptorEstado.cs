using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Interruptor tipo "toggle" para el campo Estado (Activo / Inactivo).
    /// Hereda de CheckBox, por lo que se usa con .Checked como siempre.
    /// </summary>
    [ToolboxItem(true)]
    public class InterruptorEstado : CheckBox
    {
        private Color colorActivo = ColorTranslator.FromHtml("#27AE60");
        private Color colorInactivo = ColorTranslator.FromHtml("#3F3F46");
        private string textoActivo = "Activo";
        private string textoInactivo = "Inactivo";

        public InterruptorEstado()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);
            AutoSize = false;
            ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            Font = new Font("Segoe UI", 10.5F);
            Size = new Size(140, 32);
            Cursor = Cursors.Hand;
            Checked = true;
        }

        [Category("Diseño Dark")]
        public Color ColorActivo
        {
            get { return colorActivo; }
            set { colorActivo = value; Invalidate(); }
        }

        [Category("Diseño Dark")]
        public Color ColorInactivo
        {
            get { return colorInactivo; }
            set { colorInactivo = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue("Activo")]
        public string TextoActivo
        {
            get { return textoActivo; }
            set { textoActivo = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue("Inactivo")]
        public string TextoInactivo
        {
            get { return textoInactivo; }
            set { textoInactivo = value; Invalidate(); }
        }

        protected override bool ShowFocusCues { get { return false; } }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            Color fondoPadre = Tema.ObtenerColorFondo(Parent);
            g.Clear(fondoPadre);

            int altoPista = 22;
            int anchoPista = 44;
            int y = (Height - altoPista) / 2;
            RectangleF pista = new RectangleF(1, y, anchoPista, altoPista);

            Color colorPista = Checked ? colorActivo : colorInactivo;
            if (!Enabled) colorPista = Tema.Mezclar(colorPista, fondoPadre, 0.55f);

            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(pista, altoPista / 2f))
            using (SolidBrush pincel = new SolidBrush(colorPista))
            {
                g.FillPath(pincel, ruta);
            }

            // Perilla circular
            float diametro = altoPista - 6;
            float x = Checked ? pista.Right - diametro - 3 : pista.Left + 3;
            Color colorPerilla = Enabled ? Color.White : ColorTranslator.FromHtml("#9E9E9E");
            using (SolidBrush pincel = new SolidBrush(colorPerilla))
            {
                g.FillEllipse(pincel, x, y + 3, diametro, diametro);
            }

            // Texto de estado
            string texto = Checked ? textoActivo : textoInactivo;
            Rectangle rectTexto = new Rectangle(anchoPista + 12, 0, Width - anchoPista - 12, Height);
            Color colorTexto = Enabled ? ForeColor : ColorTranslator.FromHtml("#8A8A8A");
            TextRenderer.DrawText(g, texto, Font, rectTexto, colorTexto,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);
        }
    }
}
