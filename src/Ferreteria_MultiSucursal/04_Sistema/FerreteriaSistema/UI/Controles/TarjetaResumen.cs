using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Tarjeta de resumen de la pestaña Consultar: ícono, título y un valor grande.
    /// Opcionalmente muestra una insignia azul junto al título (por ejemplo, el número de alertas).
    /// Uso: tarjTotal.Valor = "1,240";
    /// </summary>
    [ToolboxItem(true)]
    public class TarjetaResumen : Control
    {
        private static readonly Font FuenteTitulo = new Font("Segoe UI", 9.75F, FontStyle.Regular);
        private static readonly Font FuenteValor = new Font("Segoe UI", 14F, FontStyle.Bold);
        private static readonly Font FuenteInsignia = new Font("Segoe UI", 8F, FontStyle.Bold);

        private string titulo = "Título:";
        private string valor = "0";
        private string insignia = string.Empty;
        private IconChar icono = IconChar.LayerGroup;
        private Color colorIcono = ColorTranslator.FromHtml("#9E9E9E");
        private int radio = 12;

        public TarjetaResumen()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw, true);
            BackColor = ColorTranslator.FromHtml("#252526");
            ForeColor = ColorTranslator.FromHtml("#E0E0E0");
            Size = new Size(300, 72);
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

        [Category("Diseño Dark"), Description("Color del ícono.")]
        public Color ColorIcono
        {
            get { return colorIcono; }
            set { colorIcono = value; Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(12)]
        public int Radio
        {
            get { return radio; }
            set { radio = value < 0 ? 0 : value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            g.Clear(Tema.ObtenerColorFondo(Parent));

            // Fondo de la tarjeta
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(new RectangleF(0, 0, Width - 1f, Height - 1f), radio))
            using (SolidBrush relleno = new SolidBrush(BackColor))
            {
                g.FillPath(relleno, ruta);
            }

            // Cuadro del ícono
            Rectangle cuadro = new Rectangle(14, (Height - 40) / 2, 40, 40);
            using (GraphicsPath ruta = Tema.CrearRutaRedondeada(cuadro, 10))
            using (SolidBrush relleno = new SolidBrush(Tema.Mezclar(Tema.FondoSecundario, colorIcono, 0.15f)))
            {
                g.FillPath(relleno, ruta);
            }
            Bitmap imagen = Tema.Icono(icono, colorIcono, 26);
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
                using (SolidBrush relleno = new SolidBrush(Tema.Acento))
                {
                    g.FillPath(relleno, ruta);
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
