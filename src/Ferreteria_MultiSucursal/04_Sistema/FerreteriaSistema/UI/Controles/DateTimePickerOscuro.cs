using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Selector de fecha con apariencia Dark (fondo #2D2D30, borde redondeado e ícono de calendario).
    /// El calendario desplegable es el estándar de Windows.
    /// </summary>
    [ToolboxItem(true)]
    public class DateTimePickerOscuro : DateTimePicker
    {
        private Color colorFondo = ColorTranslator.FromHtml("#2D2D30");
        private Color colorTexto = ColorTranslator.FromHtml("#E0E0E0");
        private Color colorBorde = ColorTranslator.FromHtml("#3F3F46");
        private Color colorBordeFoco = ColorTranslator.FromHtml("#3498DB");
        private int radio = 8;
        private bool desplegado;
        private Bitmap iconoCalendario;

        public DateTimePickerOscuro()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Font = new Font("Segoe UI", 10.5F);
            Format = DateTimePickerFormat.Short;
            MinimumSize = new Size(0, 40);
            Size = new Size(260, 40);
            Cursor = Cursors.Hand;
        }

        [Category("Diseño Dark")]
        public Color ColorFondo
        {
            get { return colorFondo; }
            set { colorFondo = value; Invalidate(); }
        }

        [Category("Diseño Dark")]
        public Color ColorTexto
        {
            get { return colorTexto; }
            set { colorTexto = value; Invalidate(); }
        }

        [Category("Diseño Dark")]
        public Color ColorBorde
        {
            get { return colorBorde; }
            set { colorBorde = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(8)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        protected override void OnDropDown(EventArgs e) { desplegado = true; Invalidate(); base.OnDropDown(e); }
        protected override void OnCloseUp(EventArgs e) { desplegado = false; Invalidate(); base.OnCloseUp(e); }
        protected override void OnValueChanged(EventArgs eventargs) { base.OnValueChanged(eventargs); Invalidate(); }
        protected override void OnEnabledChanged(EventArgs e) { base.OnEnabledChanged(e); Invalidate(); }
        protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
        protected override void OnLostFocus(EventArgs e) { base.OnLostFocus(e); Invalidate(); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            Color fondoPadre = Tema.ObtenerColorFondo(Parent);
            g.Clear(fondoPadre);

            Color relleno = Enabled ? colorFondo : Tema.Mezclar(colorFondo, fondoPadre, 0.5f);
            Color borde = !Enabled ? Tema.Mezclar(colorBorde, relleno, 0.5f) : (Focused || desplegado ? colorBordeFoco : colorBorde);

            RectangleF rect = new RectangleF(0.5f, 0.5f, Width - 2f, Height - 2f);
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rect, radio))
            using (SolidBrush pincel = new SolidBrush(relleno))
            using (Pen pluma = new Pen(borde, 1f))
            {
                g.FillPath(pincel, ruta);
                g.DrawPath(pluma, ruta);
            }

            string texto;
            if (Format == DateTimePickerFormat.Custom && !string.IsNullOrEmpty(CustomFormat)) texto = Value.ToString(CustomFormat);
            else if (Format == DateTimePickerFormat.Long) texto = Value.ToLongDateString();
            else if (Format == DateTimePickerFormat.Time) texto = Value.ToLongTimeString();
            else texto = Value.ToShortDateString();

            Rectangle rectTexto = new Rectangle(12, 0, Width - 48, Height);
            TextRenderer.DrawText(g, texto, Font, rectTexto, Enabled ? colorTexto : ColorTranslator.FromHtml("#8A8A8A"),
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);

            if (iconoCalendario == null)
                iconoCalendario = IconChar.CalendarDays.ToBitmap(IconFont.Auto, 18, ColorTranslator.FromHtml("#9E9E9E"));
            g.DrawImage(iconoCalendario, Width - 32, (Height - iconoCalendario.Height) / 2);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && iconoCalendario != null) iconoCalendario.Dispose();
            base.Dispose(disposing);
        }
    }
}
