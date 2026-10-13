using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Tarjeta de resumen de la pestaña Consultar: cuadro de color con ícono, título y un valor grande.
    /// Opcionalmente muestra una insignia junto al título (por ejemplo, el número de alertas).
    /// BackColor puede ser semitransparente (vidrio). Uso: tarjTotal.Valor = "1,240";
    /// </summary>
    [ToolboxItem(true)]
    public class TarjetaResumen : Control
    {
        private static readonly Font FuenteTitulo = new Font("Segoe UI", 9.75F, FontStyle.Regular);
        private static readonly Font FuenteValor = new Font("Segoe UI", 15F, FontStyle.Bold);
        private static readonly Font FuenteInsignia = new Font("Segoe UI", 8F, FontStyle.Bold);

        private string titulo = "Título:";
        private string valor = "0";
        private string insignia = string.Empty;
        private IconChar icono = IconChar.LayerGroup;
        private Color colorIcono = Tema.Lila;
        private int radio = 18;

        public TarjetaResumen()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Tema.Vidrio;
            ForeColor = Tema.Texto;
            Size = new Size(300, 76);
        }

        [Category("Diseño Dark"), Description("Texto pequeño de la tarjeta."), DefaultValue("Título:")]
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value ?? string.Empty; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Valor grande que se muestra debajo del título."), DefaultValue("0")]
        public string Valor
        {
            get { return valor; }
            set { valor = value ?? string.Empty; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Número o texto corto junto al título. Vacío = no se muestra."), DefaultValue("")]
        public string Insignia
        {
            get { return insignia; }
            set { insignia = value ?? string.Empty; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(IconChar.LayerGroup)]
        public IconChar Icono
        {
            get { return icono; }
            set { icono = value; Invalidate(); }
        }

        [Category("Diseño Dark"), Description("Color del cuadro del ícono (se dibuja con degradado).")]
        public Color ColorIcono
        {
            get { return colorIcono; }
            set { colorIcono = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(18)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        // El fondo completo se dibuja en OnPaint.
        protected override void OnPaintBackground(PaintEventArgs e) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            Tema.PintarFondo(this, g);

            // Tarjeta de vidrio
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(new RectangleF(0, 0, Width - 1f, Height - 1f), radio))
            using (SolidBrush relleno = new SolidBrush(BackColor))
            using (Pen borde = new Pen(Tema.BordeVidrio, 1f))
            {
                g.FillPath(relleno, ruta);
                g.DrawPath(borde, ruta);
            }

            // Cuadro del ícono con degradado (color claro arriba a la izquierda, más oscuro abajo)
            Rectangle cuadro = new Rectangle(16, (Height - 42) / 2, 42, 42);
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(cuadro, 12))
            {
                Tema.RellenarRuta(g, ruta, Tema.Aclarar(colorIcono, 0.10f), Tema.Oscurecer(colorIcono, 0.30f));
            }
            Bitmap imagen = Tema.Icono(icono, Color.White, 22);
            g.DrawImage(imagen, cuadro.X + (cuadro.Width - imagen.Width) / 2, cuadro.Y + (cuadro.Height - imagen.Height) / 2);

            // Título (y su insignia) arriba, valor abajo
            int x = cuadro.Right + 14;
            int centro = Height / 2;
            Size tamTitulo = TextRenderer.MeasureText(g, titulo, FuenteTitulo, Size.Empty, TextFormatFlags.NoPadding);
            TextRenderer.DrawText(g, titulo, FuenteTitulo, new Point(x, centro - tamTitulo.Height - 1), Tema.TextoSecundario, TextFormatFlags.NoPadding);

            if (insignia.Length > 0)
            {
                Size tamInsignia = TextRenderer.MeasureText(g, insignia, FuenteInsignia, Size.Empty, TextFormatFlags.NoPadding);
                Rectangle rectInsignia = new Rectangle(x + tamTitulo.Width + 6, centro - tamTitulo.Height - 1, tamInsignia.Width + 12, tamTitulo.Height);
                using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rectInsignia, rectInsignia.Height / 2))
                {
                    Tema.RellenarRuta(g, ruta, Tema.Acento, Tema.AcentoFin);
                }
                TextRenderer.DrawText(g, insignia, FuenteInsignia, rectInsignia, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }

            Rectangle rectValor = new Rectangle(x, centro, Width - x - 10, Height - centro - 4);
            TextRenderer.DrawText(g, valor, FuenteValor, rectValor, Color.White,
                TextFormatFlags.Top | TextFormatFlags.Left | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
        }

        protected override void OnParentBackColorChanged(System.EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }
}
