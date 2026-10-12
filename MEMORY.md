# MEMORY.md — Estado del Proyecto

## Completado
- Estructura inicial del repositorio creada.
- Git inicializado.
- Repositorio GitHub creado.
- SqlServer preparado con Docker: contenedor `mi_sql_server` (SQL Server 2022, puerto 1433).
- Acceso al repositorio compartido con el equipo.
- Proyecto completo en GitHub: `Enso-Hernandez/FerreteriaMultisucursal` (público, rama `main`).
  Un solo repositorio en la raíz con un `.gitignore` único. Un clon limpio compila sin
  errores ni advertencias. No se versionan `Conexion.config`, `bin/`, `obj/`, `.vs/`,
  `*.user`, `Respaldo_DisenoAnterior/` ni `src/backup/`. El Git antiguo de `04_Programa`
  (remoto `ProyectoFinalPrograII`) quedó respaldado en `src/backup/04_Programa.git`.
- Solución por capas (`04_Programa/FerreteriaSistema.slnx`): Entidad, Datos y Negocio
  en .NET Framework 4.8; Presentación migrada de net8.0-windows a net48.
  Compila sin errores ni advertencias (MSBuild de Visual Studio 18).
- Base de datos `Ferreteria` creada con `database/scripts/Ferreteria_SQLServer.sql`
  en el contenedor Docker `mi_sql_server` (15 tablas, 5 registros de prueba por tabla).
  Ahí se borró la base antigua `Db_FerreteriaMultisucursal` (13 tablas); antes se sacó
  un respaldo en el contenedor: `/var/opt/mssql/backup/Db_FerreteriaMultisucursal_antigua.bak`.
  La copia en `.\SQLEXPRESS` local ya no la usa el programa.
- El programa usa la base del contenedor: con el contenedor encendido las cinco
  operaciones de Sucursales funcionan (probado desde Negocio y desde el formulario);
  apagado, Sucursales muestra "No se pudieron cargar las sucursales" (tarda 15 s) y no se cierra.
- CRUD patrón Sucursales (`Formularios/SucursalesForm`) conectado a las capas:
  Consultar, Buscar, Agregar, Editar y Eliminar probados contra SQL Server,
  tanto desde Negocio como simulando al usuario en el formulario.
- Diseño visual (sin conexión a capas) de 10 pantallas con el estilo de las de ejemplo,
  en `Formularios/`: TipoEmpleadoForm, ClientesForm, ProveedoresForm, InventarioForm,
  DetallesInventarioForm, DetalleComprasForm, VentasForm, DetalleVentaForm, TrasladosForm
  y DetalleTrasladoForm. Campos = columnas de cada tabla del script. El Dashboard ya las
  abre. Compilan sin advertencias; revisadas con capturas (Consultar, Editar por doble
  clic, validación de obligatorios y cálculo del Total en Detalle compras).
- Nuevo diseño de la pestaña Consultar en las 15 pantallas (según la imagen de referencia):
  buscador con lupa y resplandor, chips de filtro con conteo, 3 tarjetas de resumen,
  filas tipo tarjeta con código #XXX-001, insignias, barra de stock (Inventario), columna
  Acciones (ver detalle, Editar, Ver notas), orden por encabezado y paginación.
  Componentes compartidos: `UI/EstiloConsulta.cs`, `UI/Controles/TarjetaResumen.cs`,
  `UI/Controles/Paginador.cs`; `TextBoxOscuro` ganó `Icono` y `Resplandor` (opcionales).
  Probado: Sucursales con datos reales (filtros, orden, paginación, acciones y CRUD
  completo) y las otras 14 con filas de ejemplo. Gestionar no cambió.

## En desarrollo
- Preparación del entorno de IA.

## Pendiente
- Desarrollar módulos individuales.
- Implementar maestro-detalle.
- Implementar Login.
- Implementar Panel de Navegación.
- Implementar Dashboard.
- Publicar la base de datos.
- Integrar y revisar el proyecto final.
- Consulta guardada (verificada en la base `Ferreteria`): las 15 tablas tienen PK.
  - Única tabla sin llave foránea: Tbl_Sucursales.
  - Tienen llave foránea pero ninguna otra tabla depende de ellas: Tbl_TipoEmpleado,
    Tbl_Proveedores, Tbl_DetalleCompras, Tbl_Clientes, Tbl_DetalleVenta y Tbl_DetalleTraslado.

## Decisiones
- Se utilizará arquitectura Entidad, Datos, Negocio y Presentación.
- Sucursales será el módulo patrón del proyecto.
- Los Skills se crearán por patrón de desarrollo y no por tabla.
- Eliminar es borrado lógico (`EstadoSucursal = 0`): Tbl_Usuarios y Tbl_Inventario
  tienen llaves foráneas hacia Tbl_Sucursales. Consultar muestra activas e inactivas.
- La cadena de conexión "Ferreteria" está en `FerreteriaSistema/Conexion.config`
  (usuario `sa` del contenedor, `localhost,1433`). `App.config` la lee con
  `configSource`. `Conexion.config` tiene la contraseña: está en el `.gitignore` de la raíz y
  no se versiona. Cada integrante copia `Conexion.ejemplo.config` como `Conexion.config`
  y escribe su contraseña.
- SucursalesForm se adaptó a Tbl_Sucursales (Tipo y Observaciones; se quitaron
  Teléfono, Horario, Municipio y Departamento).
- Patrón por capas para los demás módulos: Entidad (`Sucursal`), Datos
  (`Conexion`, `SucursalDatos`), Negocio (`SucursalNegocio`, devuelve "" o un mensaje).
- Las 10 pantallas nuevas son CRUD simple (no maestro-detalle). Las llaves foráneas son
  ComboBox vacíos que se llenarán desde Negocio. Las listas fijas usan los valores
  exactos de los datos de prueba (por ejemplo "Credito" y "Camion", sin tilde).
- Los 16 `FrmXxx` del diseño antiguo (verde/celeste) y `FrmPrincipal` se movieron sin
  modificar a `04_Sistema/Respaldo_DisenoAnterior/`, fuera del proyecto, para que el
  Explorador de soluciones muestre solo las pantallas de `Formularios/`. Ningún código
  los usaba. Presentación compila sin ellos (15 módulos + Login + Dashboard).
- Consultar: los filtros, el orden y la paginación trabajan sobre los registros ya
  cargados en la tabla (no consultan la base). Inventario: Crítico = Cantidad ≤ Mínimo;
  Stock bajo = Mínimo < Cantidad ≤ 1.5 × Mínimo. Al conectar un módulo a las capas solo
  hay que llenar dgvDatos y llamar MtdActualizarContador() (como en Sucursales).
- Pendiente revisar: UsuariosForm, CategoriasForm, ProductosForm y ComprasForm tienen
  campos que no coinciden con sus tablas (por ejemplo Precio en Productos).
