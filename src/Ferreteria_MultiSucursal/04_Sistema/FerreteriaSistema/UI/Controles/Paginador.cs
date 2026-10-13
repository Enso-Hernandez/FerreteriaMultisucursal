using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FerreteriaSistema.UI.Controles
{
    /// <summary>
    /// Paginación de la pestaña Consultar: "‹ anterior  1 2 3  siguiente ›".
    /// Al hacer clic cambia PaginaActual y avisa con el evento PaginaCambiada.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultEvent("PaginaCambiada")]
    public class Paginador : Control
    {
        private static readonly Font FuenteTexto = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        private const int MaximoBotones = 5;

        private int paginaActual = 1;
        private int totalPaginas = 1;

        /// <summary>Zonas donde se puede hacer clic y la página a la que llevan.</summary>
        private readonly List<KeyValuePair<Rectangle, int>> zonas = new List<KeyValuePair<Rectangle, int>>();

        public event EventHandler PaginaCambiada;

        public Paginador()
        {
            SetStyle(ControlStyles.UserPaint
                   | ControlStyles.AllPaintingInWmPaint
                   | ControlStyles.OptimizedDoubleBuffer
                   | ControlStyles.ResizeRedraw
                   | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            ForeColor = Tema.TextoSecundario;
            Size = new Size(300, 30);
        }

        [Category("Diseño Dark"), DefaultValue(1)]
        public int PaginaActual
        {
            get { return paginaActual; }
            set { paginaActual = Math.Max(1, Math.Min(value, totalPaginas)); Invalidate(); }
        }

        [Category("Diseño Dark"), DefaultValue(1)]
        public int TotalPaginas
        {
            get { return totalPaginas; }
            set { totalPaginas = Math.Max(1, value); PaginaActual = paginaActual; Invalidate(); }
        }

        /// <summary>Calcula, de derecha a izquierda, dónde va cada texto del paginador.</summary>
        private List<Tuple<Rectangle, string, int>> CalcularElementos()
        {
            List<Tuple<string, int>> textos = new List<Tuple<string, int>>();
            textos.Add(Tuple.Create("‹ anterior", paginaActual - 1));

            int primera = Math.Max(1, paginaActual - MaximoBotones / 2);
            int ultima = Math.Min(totalPaginas, primera + MaximoBotones - 1);
            primera = Math.Max(1, ultima - MaximoBotones + 1);
            for (int pagina = primera; pagina <= ultima; pagina++) textos.Add(Tuple.Create(pagina.ToString(), pagina));

            textos.Add(Tuple.Create("siguiente ›", paginaActual + 1));

            List<Tuple<Rectangle, string, int>> elementos = new List<Tuple<Rectangle, string, int>>();
            int x = Width - 4;
            for (int i = textos.Count - 1; i >= 0; i--)
            {
                int ancho = TextRenderer.MeasureText(textos[i].Item1, FuenteTexto).Width + (i == 0 || i == textos.Count - 1 ? 4 : 10);
                ancho = Math.Max(ancho, 26);
                x -= ancho;
                elementos.Insert(0, Tuple.Create(new Rectangle(x, (Height - 26) / 2, ancho, 26), textos[i].Item1, textos[i].Item2));
                x -= 4;
            }
            return elementos;
        }

        // El fondo completo se dibuja en OnPaint.
        protected override void OnPaintBackground(PaintEventArgs e) { }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Tema.ConfigurarCalidad(g);
            Tema.PintarFondo(this, g);

            zonas.Clear();
            foreach (Tuple<Rectangle, string, int> elemento in CalcularElementos())
            {
                Rectangle rect = elemento.Item1;
                int destino = elemento.Item3;
                bool esActual = destino == paginaActual && elemento.Item2 == destino.ToString();
                bool habilitado = destino >= 1 && destino <= totalPaginas && !esActual;

                if (esActual)
                {
                    using (GraphicsPath ruta = Tema.CrearRutaRedondeada(rect, 8))
                    using (SolidBrush relleno = new SolidBrush(Tema.VidrioClaro))
                    using (Pen borde = new Pen(Tema.BordeVidrio, 1f))
                    {
                        g.FillPath(relleno, ruta);
                        g.DrawPath(borde, ruta);
                    }
                }

                Color color = esActual ? Color.White : (habilitado ? Tema.TextoSecundario : Tema.TextoDeshabilitado);
                TextRenderer.DrawText(g, elemento.Item2, FuenteTexto, rect, color,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

                if (habilitado) zonas.Add(new KeyValuePair<Rectangle, int>(rect, destino));
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Cursor = BuscarZona(e.Location) > 0 ? Cursors.Hand : Cursors.Default;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int destino = BuscarZona(e.Location);
            if (destino <= 0) return;

            PaginaActual = destino;
            PaginaCambiada?.Invoke(this, EventArgs.Empty);
        }

        private int BuscarZona(Point punto)
        {
            foreach (KeyValuePair<Rectangle, int> zona in zonas)
                if (zona.Key.Contains(punto)) return zona.Value;
            return 0;
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }
}
