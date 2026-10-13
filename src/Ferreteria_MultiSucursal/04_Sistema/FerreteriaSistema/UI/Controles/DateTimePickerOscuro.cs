using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Selector de fecha con apariencia Dark (pastilla oscura, borde redondeado e ícono de calendario).
    /// El calendario desplegable es el estándar de Windows.
    /// </summary>
    [ToolboxItem(true)]
    public class DateTimePickerOscuro : DateTimePicker
    {
        private Color colorFondo = Tema.FondoSecundario;
        private Color colorTexto = Tema.Texto;
        private Color colorBorde = Tema.Borde;
        private Color colorBordeFoco = Tema.Acento;
        private int radio = 10;
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

        [Category("Diseño Dark"), DefaultValue(10)]
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

        // El fondo completo se dibuja en OnPaint.
        protected override void OnPaintBackground(PaintEventArgs pevent) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            Color fondoPadre = Tema.ObtenerColorFondo(Parent);
            Tema.PintarFondo(this, g);

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
            TextRenderer.DrawText(g, texto, Font, rectTexto, Enabled ? colorTexto : Tema.TextoSecundario,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine);

            if (iconoCalendario == null)
                iconoCalendario = IconChar.CalendarDays.ToBitmap(IconFont.Auto, 18, Tema.TextoSecundario);
            g.DrawImage(iconoCalendario, Width - 32, (Height - iconoCalendario.Height) / 2);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && iconoCalendario != null) iconoCalendario.Dispose();
            base.Dispose(disposing);
        }
    }
}
