using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FerreteriaSistema.UI
{
    /// <summary>
    /// Tema visual "Dark Minimalista" del sistema.
    /// Centraliza la paleta de colores, las fuentes y los métodos de dibujo
    /// (GraphicsPath) que usan todos los formularios de la Capa Presentación.
    /// </summary>
    public static class Tema
    {
        #region Paleta de colores

        public static readonly Color FondoPrincipal = ColorTranslator.FromHtml("#1E1E1E");
        public static readonly Color FondoSecundario = ColorTranslator.FromHtml("#2D2D30");
        public static readonly Color FondoMenu = ColorTranslator.FromHtml("#252526");
        public static readonly Color FondoTarjeta = ColorTranslator.FromHtml("#252526");
        public static readonly Color FilaAlterna = ColorTranslator.FromHtml("#252526");
        public static readonly Color Borde = ColorTranslator.FromHtml("#3F3F46");
        public static readonly Color BordeSuave = ColorTranslator.FromHtml("#333337");
        public static readonly Color Seleccion = ColorTranslator.FromHtml("#264F78");

        public static readonly Color Texto = ColorTranslator.FromHtml("#E0E0E0");
        public static readonly Color TextoSecundario = ColorTranslator.FromHtml("#9E9E9E");
        public static readonly Color TextoDeshabilitado = ColorTranslator.FromHtml("#6E6E6E");

        public static readonly Color Acento = ColorTranslator.FromHtml("#3498DB");
        public static readonly Color Exito = ColorTranslator.FromHtml("#27AE60");
        public static readonly Color Peligro = ColorTranslator.FromHtml("#E74C3C");
        public static readonly Color Advertencia = ColorTranslator.FromHtml("#F39C12");
        public static readonly Color Neutro = ColorTranslator.FromHtml("#3F3F46");

        #endregion

        #region Tipografía (Segoe UI)

        public static readonly Font FuenteNormal = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font FuenteLectura = new Font("Segoe UI", 11F, FontStyle.Regular);
        public static readonly Font FuenteNegrita = new Font("Segoe UI", 10F, FontStyle.Bold);
        public static readonly Font FuenteSubtitulo = new Font("Segoe UI", 14F, FontStyle.Bold);
        public static readonly Font FuenteTitulo = new Font("Segoe UI", 18F, FontStyle.Bold);

        #endregion

        #region Íconos (FontAwesome)

        private static readonly Dictionary<string, Bitmap> iconosGuardados = new Dictionary<string, Bitmap>();

        /// <summary>
        /// Devuelve un ícono de FontAwesome como imagen para dibujarlo con Graphics.DrawImage.
        /// Las imágenes se guardan para no volver a crearlas en cada repintado.
        /// </summary>
        public static Bitmap Icono(IconChar icono, Color color, int tamano)
        {
            string clave = icono + "|" + color.ToArgb() + "|" + tamano;
            Bitmap imagen;
            if (!iconosGuardados.TryGetValue(clave, out imagen))
            {
                imagen = icono.ToBitmap(IconFont.Auto, tamano, color, 0, FlipOrientation.Normal);
                iconosGuardados[clave] = imagen;
            }
            return imagen;
        }

        #endregion

        #region GraphicsPath: bordes redondeados

        /// <summary>Crea una ruta con esquinas redondeadas (base de todo el diseño "smooth").</summary>
        public static GraphicsPath CrearRutaRedondeada(RectangleF rect, float radio)
        {
            GraphicsPath ruta = new GraphicsPath();
            if (radio <= 0.5f || rect.Width <= 1 || rect.Height <= 1)
            {
                ruta.AddRectangle(rect);
                return ruta;
            }

            float diametro = Math.Min(radio * 2f, Math.Min(rect.Width, rect.Height));
            RectangleF arco = new RectangleF(rect.Location, new SizeF(diametro, diametro));

            ruta.AddArc(arco, 180, 90);                       // superior izquierda
            arco.X = rect.Right - diametro;
            ruta.AddArc(arco, 270, 90);                       // superior derecha
            arco.Y = rect.Bottom - diametro;
            ruta.AddArc(arco, 0, 90);                         // inferior derecha
            arco.X = rect.Left;
            ruta.AddArc(arco, 90, 90);                        // inferior izquierda
            ruta.CloseFigure();
            return ruta;
        }

        public static GraphicsPath CrearRutaRedondeada(Rectangle rect, int radio)
        {
            return CrearRutaRedondeada((RectangleF)rect, (float)radio);
        }

        /// <summary>Configura el Graphics para dibujar con suavizado (antialias).</summary>
        public static void ConfigurarCalidad(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
        }

        /// <summary>
        /// Devuelve el primer color de fondo opaco subiendo por los contenedores.
        /// Se usa para pintar las "esquinas" fuera del borde redondeado.
        /// </summary>
        public static Color ObtenerColorFondo(Control control)
        {
            Control actual = control;
            while (actual != null)
            {
                if (actual.BackColor.A == 255) return actual.BackColor;
                actual = actual.Parent;
            }
            return FondoPrincipal;
        }

        /// <summary>Aclara un color (factor 0..1).</summary>
        public static Color Aclarar(Color color, float factor)
        {
            return Color.FromArgb(color.A,
                (int)(color.R + (255 - color.R) * factor),
                (int)(color.G + (255 - color.G) * factor),
                (int)(color.B + (255 - color.B) * factor));
        }

        /// <summary>Oscurece un color (factor 0..1).</summary>
        public static Color Oscurecer(Color color, float factor)
        {
            return Color.FromArgb(color.A,
                (int)(color.R * (1 - factor)),
                (int)(color.G * (1 - factor)),
                (int)(color.B * (1 - factor)));
        }

        /// <summary>Mezcla dos colores (0 = color1, 1 = color2).</summary>
        public static Color Mezclar(Color color1, Color color2, float cantidad)
        {
            return Color.FromArgb(
                (int)(color1.R + (color2.R - color1.R) * cantidad),
                (int)(color1.G + (color2.G - color1.G) * cantidad),
                (int)(color1.B + (color2.B - color1.B) * cantidad));
        }

        #endregion

        #region Formularios sin borde

        /// <summary>
        /// Redondea las esquinas de un formulario sin borde.
        /// En Windows 11 usa las esquinas nativas (suaves); en Windows 10 usa una Region con GraphicsPath.
        /// </summary>
        public static void RedondearFormulario(Form formulario, int radio)
        {
            if (formulario == null) return;

            bool esquinasNativas = false;
            try
            {
                int preferencia = NativeMethods.DWMWCP_ROUND;
                int resultado = NativeMethods.DwmSetWindowAttribute(formulario.Handle,
                    NativeMethods.DWMWA_WINDOW_CORNER_PREFERENCE, ref preferencia, sizeof(int));
                esquinasNativas = resultado == 0 && Environment.OSVersion.Version.Build >= 22000;
            }
            catch (DllNotFoundException) { }
            catch (EntryPointNotFoundException) { }

            if (esquinasNativas) return;

            AplicarRegionRedondeada(formulario, radio);
            formulario.Resize += (s, e) =>
            {
                if (formulario.WindowState == FormWindowState.Maximized)
                    formulario.Region = null;
                else
                    AplicarRegionRedondeada(formulario, radio);
            };
        }

        private static void AplicarRegionRedondeada(Control control, int radio)
        {
            using (GraphicsPath ruta = CrearRutaRedondeada(new Rectangle(0, 0, control.Width, control.Height), radio))
            {
                control.Region = new Region(ruta);
            }
        }

        /// <summary>Permite mover un formulario sin borde arrastrando cualquier control (encabezado, logo, etc.).</summary>
        public static void HabilitarArrastre(Form formulario, params Control[] controles)
        {
            foreach (Control control in controles)
            {
                control.MouseDown += (s, e) =>
                {
                    if (e.Button != MouseButtons.Left || e.Clicks > 1) return;   // doble clic = maximizar
                    NativeMethods.ReleaseCapture();
                    NativeMethods.SendMessage(formulario.Handle, NativeMethods.WM_NCLBUTTONDOWN, NativeMethods.HT_CAPTION, 0);
                };
            }
        }

        #endregion

        #region DataGridView y barras de desplazamiento

        /// <summary>
        /// Aplica el estilo Dark a un DataGridView (sin bordes, cabecera #2D2D30, filas alternas #1E1E1E / #252526).
        /// Los formularios nuevos ya lo traen en el Designer; este método sirve para formularios antiguos.
        /// </summary>
        public static void EstilizarDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = FondoTarjeta;
            dgv.GridColor = FondoSecundario;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 44;
            dgv.RowTemplate.Height = 38;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = FondoSecundario;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Texto;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = FondoSecundario;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Texto;
            dgv.ColumnHeadersDefaultCellStyle.Font = FuenteNegrita;
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 0, 0, 0);

            dgv.DefaultCellStyle.BackColor = FondoPrincipal;
            dgv.DefaultCellStyle.ForeColor = Texto;
            dgv.DefaultCellStyle.SelectionBackColor = Seleccion;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = FuenteNormal;
            dgv.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = FilaAlterna;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = Texto;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Seleccion;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            AplicarScrollOscuro(dgv);
        }

        /// <summary>
        /// Barras de desplazamiento oscuras (Windows 10 1809+ / Windows 11).
        /// Funciona con DataGridView, paneles con AutoScroll y TextBox multilínea.
        /// </summary>
        public static void AplicarScrollOscuro(Control control)
        {
            if (control == null) return;
            if (!control.IsHandleCreated)
            {
                control.HandleCreated += (s, e) => AplicarScrollOscuro((Control)s);
                return;
            }
            try
            {
                NativeMethods.SetWindowTheme(control.Handle, "DarkMode_Explorer", null);
                foreach (Control hijo in control.Controls)
                {
                    if (hijo is ScrollBar) NativeMethods.SetWindowTheme(hijo.Handle, "DarkMode_Explorer", null);
                }
            }
            catch (DllNotFoundException) { }
            catch (EntryPointNotFoundException) { }
        }

        #endregion

        #region Tema para formularios antiguos (FrmXxx)

        /// <summary>
        /// Recorre todos los controles de un formulario "clásico" y le aplica la paleta Dark.
        /// Útil para los formularios que todavía no han sido rediseñados.
        /// </summary>
        public static void AplicarTemaOscuro(Control raiz)
        {
            if (raiz == null) return;

            if (raiz is Form)
            {
                raiz.BackColor = FondoPrincipal;
                raiz.ForeColor = Texto;
                raiz.Font = FuenteNormal;
            }

            foreach (Control control in raiz.Controls)
            {
                // Los controles personalizados ya traen su propio estilo.
                if (control.GetType().Namespace == typeof(Tema).Namespace + ".Controles") continue;

                if (control is DataGridView)
                {
                    EstilizarDataGridView((DataGridView)control);
                }
                else if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.BackColor = ColorBotonPorNombre(boton.Name);
                    boton.ForeColor = Color.White;
                    boton.Cursor = Cursors.Hand;
                }
                else if (control is TextBox)
                {
                    TextBox texto = (TextBox)control;
                    texto.BorderStyle = BorderStyle.FixedSingle;
                    texto.BackColor = FondoSecundario;
                    texto.ForeColor = Texto;
                }
                else if (control is ComboBox)
                {
                    ComboBox combo = (ComboBox)control;
                    combo.FlatStyle = FlatStyle.Flat;
                    combo.BackColor = FondoSecundario;
                    combo.ForeColor = Texto;
                }
                else if (control is NumericUpDown)
                {
                    control.BackColor = FondoSecundario;
                    control.ForeColor = Texto;
                    ((NumericUpDown)control).BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is TabPage)
                {
                    ((TabPage)control).UseVisualStyleBackColor = false;
                    control.BackColor = FondoPrincipal;
                    control.ForeColor = Texto;
                }
                else if (control is GroupBox || control is Label || control is CheckBox || control is RadioButton)
                {
                    control.ForeColor = Texto;
                    if (control is GroupBox) control.BackColor = FondoPrincipal;
                }
                else if (control is Panel || control is TableLayoutPanel || control is FlowLayoutPanel)
                {
                    control.BackColor = control.Dock == DockStyle.Top || control.Dock == DockStyle.Bottom
                        ? FondoSecundario
                        : FondoPrincipal;
                    control.ForeColor = Texto;
                }

                if (control.HasChildren) AplicarTemaOscuro(control);
            }
        }

        private static Color ColorBotonPorNombre(string nombre)
        {
            string n = (nombre ?? string.Empty).ToLowerInvariant();
            if (n.Contains("guardar") || n.Contains("agregar")) return Exito;
            if (n.Contains("eliminar") || n.Contains("cerrar") || n.Contains("quitar")) return Peligro;
            if (n.Contains("cancelar") || n.Contains("limpiar")) return Neutro;
            return Acento;
        }

        #endregion
    }

    /// <summary>Llamadas a la API de Windows usadas por la capa visual.</summary>
    internal static class NativeMethods
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int DWMWA_WINDOW_CORNER_PREFERENCE = 33;
        public const int DWMWCP_ROUND = 2;
        public const int CS_DROPSHADOW = 0x00020000;
        public const int WS_MINIMIZEBOX = 0x00020000;
        public const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attribute, ref int pvAttribute, int cbAttribute);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);
    }
}
