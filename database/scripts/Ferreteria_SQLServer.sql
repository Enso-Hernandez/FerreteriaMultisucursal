-- =====================================================================
-- Base de datos: Ferreteria  |  Motor: SQL Server (T-SQL)
-- Generado a partir del diagrama "Diagrama Workbench.mwb"
--
-- Uso: ejecutar este script completo en SQL Server Management Studio.
-- Crea la base de datos Ferreteria, las tablas y los datos de prueba.
--
-- Las tablas estan ordenadas segun sus dependencias (primero las tablas
-- padre y luego las que tienen llaves foraneas hacia ellas).
-- Las fechas se escriben como YYYYMMDD para que no dependan del idioma
-- configurado en el servidor.
-- =====================================================================

IF DB_ID('Ferreteria') IS NULL
	CREATE DATABASE Ferreteria;
GO

USE Ferreteria;
GO

-- =====================================================================
-- PARTE 1: CREACION DE TABLAS
-- =====================================================================

-- Tbl_Sucursales: sucursales y bodegas de la ferreteria.
CREATE TABLE dbo.Tbl_Sucursales
(
	CodigoSucursal    INT IDENTITY(1,1),
	NombreSucursal    VARCHAR(45)  NOT NULL,
	DireccionSucursal VARCHAR(100) NOT NULL,
	TipoSucursal      VARCHAR(45)  NOT NULL,
	EstadoSucursal    BIT      NOT NULL,   -- 1 = activa, 0 = inactiva
	Observaciones     VARCHAR(150),
	CONSTRAINT PK_Sucursales PRIMARY KEY (CodigoSucursal)
);

-- Tbl_Usuarios: usuarios del sistema, cada uno asignado a una sucursal.
CREATE TABLE dbo.Tbl_Usuarios
(
	CodigoUsuario    INT IDENTITY(1,1),
	CodigoSucursal   INT      NOT NULL,
	NombreUsuario    VARCHAR(45)  NOT NULL,
	TelefonoUsuario  INT      NOT NULL,
	DireccionUsuario VARCHAR(100) NOT NULL,
	DPIUsuario       BIGINT       NOT NULL,    -- el DPI tiene 13 digitos, no cabe en INT
	Estado           BIT      NOT NULL,
	CONSTRAINT PK_Usuarios PRIMARY KEY (CodigoUsuario),
	CONSTRAINT FK_Usuarios_Sucursales FOREIGN KEY (CodigoSucursal)
		REFERENCES dbo.Tbl_Sucursales (CodigoSucursal)
);

-- Tbl_TipoEmpleado: rol y datos laborales de cada usuario.
CREATE TABLE dbo.Tbl_TipoEmpleado
(
	CodigoTipoEmpleado INT IDENTITY(1,1),
	CodigoUsuario      INT      NOT NULL,
	Nombre             VARCHAR(45)  NOT NULL,
	Apellido           VARCHAR(45)  NOT NULL,
	RolEmpleado        VARCHAR(45)  NOT NULL,
	Descripcion        VARCHAR(100) NOT NULL,
	Estado             BIT      NOT NULL,
	CONSTRAINT PK_TipoEmpleado PRIMARY KEY (CodigoTipoEmpleado),
	CONSTRAINT FK_TipoEmpleado_Usuarios FOREIGN KEY (CodigoUsuario)
		REFERENCES dbo.Tbl_Usuarios (CodigoUsuario)
);

-- Tbl_Inventario: inventario general de cada sucursal.
CREATE TABLE dbo.Tbl_Inventario
(
	CodigoInventario         INT IDENTITY(1,1),
	CodigoSucursal           INT     NOT NULL,
	NombreInventario         VARCHAR(45) NOT NULL,
	CantidadInventario       INT     NOT NULL,
	CantidadMinimaInventario INT     NOT NULL,
	Ubicacion                VARCHAR(20) NOT NULL,
	Observaciones            VARCHAR(45),
	CONSTRAINT PK_Inventario PRIMARY KEY (CodigoInventario),
	CONSTRAINT FK_Inventario_Sucursales FOREIGN KEY (CodigoSucursal)
		REFERENCES dbo.Tbl_Sucursales (CodigoSucursal)
);

-- Tbl_DetallesInventario: movimientos (entradas y salidas) del inventario.
CREATE TABLE dbo.Tbl_DetallesInventario
(
	CodigoDetalleInventario INT IDENTITY(1,1),
	CodigoInventario        INT      NOT NULL,
	Descripcion             VARCHAR(100) NOT NULL,
	Ingreso                 INT      NOT NULL,
	Egreso                  INT      NOT NULL,
	TipoMovimiento          VARCHAR(45)  NOT NULL,
	FechaMovimiento         DATE         NOT NULL,
	CONSTRAINT PK_DetallesInventario PRIMARY KEY (CodigoDetalleInventario),
	CONSTRAINT FK_DetallesInventario_Inventario FOREIGN KEY (CodigoInventario)
		REFERENCES dbo.Tbl_Inventario (CodigoInventario)
);

-- Tbl_Productos: productos que forman parte de un inventario.
CREATE TABLE dbo.Tbl_Productos
(
	CodigoProducto         INT IDENTITY(1,1),
	CodigoInventario       INT     NOT NULL,
	NombreCategoria        VARCHAR(45) NOT NULL,
	TipoMedicionProducto   VARCHAR(45) NOT NULL,
	CantidadMinimaProducto INT     NOT NULL,
	CantidadProducto       INT     NOT NULL,
	FechaVencimiento       DATETIME,                -- opcional: no todo producto vence
	FechaIngreso           DATETIME   NOT NULL,
	CONSTRAINT PK_Productos PRIMARY KEY (CodigoProducto),
	CONSTRAINT FK_Productos_Inventario FOREIGN KEY (CodigoInventario)
		REFERENCES dbo.Tbl_Inventario (CodigoInventario)
);

-- Tbl_Categorias: categorias a las que pertenecen los productos.
CREATE TABLE dbo.Tbl_Categorias
(
	CodigoCategoria    INT IDENTITY(1,1),
	CodigoProducto     INT      NOT NULL,
	TipoCategoria      VARCHAR(45)  NOT NULL,
	Descripcion        VARCHAR(100) NOT NULL,
	Estado             BIT      NOT NULL,
	FechaCreacion      DATETIME    NOT NULL,
	FechaActualizacion DATETIME    NOT NULL,
	CONSTRAINT PK_Categorias PRIMARY KEY (CodigoCategoria),
	CONSTRAINT FK_Categorias_Productos FOREIGN KEY (CodigoProducto)
		REFERENCES dbo.Tbl_Productos (CodigoProducto)
);

-- Tbl_Proveedores: proveedores que abastecen cada categoria.
CREATE TABLE dbo.Tbl_Proveedores
(
	CodigoProveedor    INT IDENTITY(1,1),
	CodigoCategoria    INT      NOT NULL,
	NombreProveedor    VARCHAR(45)  NOT NULL,
	DireccionProveedor VARCHAR(100) NOT NULL,
	TelefonoProveedor  INT      NOT NULL,
	NitProveedor       INT      NOT NULL,
	Observaciones      VARCHAR(100),
	CONSTRAINT PK_Proveedores PRIMARY KEY (CodigoProveedor),
	CONSTRAINT FK_Proveedores_Categorias FOREIGN KEY (CodigoCategoria)
		REFERENCES dbo.Tbl_Categorias (CodigoCategoria)
);

-- Tbl_Compras: encabezado de las compras de mercaderia, ligadas a un movimiento de inventario.
CREATE TABLE dbo.Tbl_Compras
(
	CodigoCompra            INT IDENTITY(1,1),
	CodigoDetalleInventario INT      NOT NULL,
	NumeroCompra            INT      NOT NULL,
	NombreCompra            VARCHAR(45)  NOT NULL,
	FechaCompra             DATETIME    NOT NULL,
	DescripcionCompra       VARCHAR(100) NOT NULL,
	Observaciones           VARCHAR(100),
	CONSTRAINT PK_Compras PRIMARY KEY (CodigoCompra),
	CONSTRAINT FK_Compras_DetallesInventario FOREIGN KEY (CodigoDetalleInventario)
		REFERENCES dbo.Tbl_DetallesInventario (CodigoDetalleInventario)
);

-- Tbl_DetalleCompras: detalle (cantidad, precio y forma de pago) de cada compra.
CREATE TABLE dbo.Tbl_DetalleCompras
(
	CodigoDetalleCompra INT IDENTITY(1,1),
	CodigoCompra        INT       NOT NULL,
	CantidadCompra      INT       NOT NULL,
	PrecioUnitario      DECIMAL(10,2) NOT NULL,   -- en el diagrama es VARCHAR(45); se usa numerico para poder calcular
	Total               DECIMAL(10,2) NOT NULL,
	FormaPago           VARCHAR(45)   NOT NULL,
	CONSTRAINT PK_DetalleCompras PRIMARY KEY (CodigoDetalleCompra),
	CONSTRAINT FK_DetalleCompras_Compras FOREIGN KEY (CodigoCompra)
		REFERENCES dbo.Tbl_Compras (CodigoCompra)
);

-- Tbl_Ventas: encabezado de las ventas, ligadas a un movimiento de inventario.
CREATE TABLE dbo.Tbl_Ventas
(
	CodigoVenta             INT IDENTITY(1,1),
	CodigoDetalleInventario INT       NOT NULL,
	FechaVenta              DATETIME     NOT NULL,
	Total                   DECIMAL(10,2) NOT NULL,
	CantidadProductos       INT       NOT NULL,
	FacturaVenta            INT       NOT NULL,
	Observaciones           VARCHAR(100),
	CONSTRAINT PK_Ventas PRIMARY KEY (CodigoVenta),
	CONSTRAINT FK_Ventas_DetallesInventario FOREIGN KEY (CodigoDetalleInventario)
		REFERENCES dbo.Tbl_DetallesInventario (CodigoDetalleInventario)
);

-- Tbl_Clientes: clientes asociados a una venta.
CREATE TABLE dbo.Tbl_Clientes
(
	CodigoCliente   INT IDENTITY(1,1),
	CodigoVenta     INT     NOT NULL,
	NombreCliente   VARCHAR(45) NOT NULL,
	ApellidoCliente VARCHAR(45) NOT NULL,
	DPICliente      BIGINT      NOT NULL,       -- el DPI tiene 13 digitos, no cabe en INT
	TelefonoCliente INT     NOT NULL,
	EstadoCliente   BIT     NOT NULL,
	FechaNacimiento DATETIME   NOT NULL,
	CONSTRAINT PK_Clientes PRIMARY KEY (CodigoCliente),
	CONSTRAINT FK_Clientes_Ventas FOREIGN KEY (CodigoVenta)
		REFERENCES dbo.Tbl_Ventas (CodigoVenta)
);

-- Tbl_DetalleVenta: detalle (precio, forma de pago y subtotal) de cada venta.
CREATE TABLE dbo.Tbl_DetalleVenta
(
	CodigoDetalleVenta INT IDENTITY(1,1),
	CodigoVenta        INT       NOT NULL,
	PrecioUnitario     DECIMAL(10,2) NOT NULL,
	FormaPago          VARCHAR(45)   NOT NULL,
	Descripcion        VARCHAR(100)  NOT NULL,
	Observaciones      VARCHAR(100)  NOT NULL,
	Subtotal           DECIMAL(10,2) NOT NULL,
	CONSTRAINT PK_DetalleVenta PRIMARY KEY (CodigoDetalleVenta),
	CONSTRAINT FK_DetalleVenta_Ventas FOREIGN KEY (CodigoVenta)
		REFERENCES dbo.Tbl_Ventas (CodigoVenta)
);

-- Tbl_Traslados: solicitudes de traslado de mercaderia entre sucursales.
CREATE TABLE dbo.Tbl_Traslados
(
	CodigoTraslado          INT IDENTITY(1,1),
	CodigoDetalleInventario INT      NOT NULL,
	NombreSucursalSolicitud VARCHAR(45)  NOT NULL,
	FechaSolicitada         DATETIME    NOT NULL,
	FechaEnviada            DATETIME    NOT NULL,
	Observaciones           VARCHAR(100),
	CONSTRAINT PK_Traslados PRIMARY KEY (CodigoTraslado),
	CONSTRAINT FK_Traslados_DetallesInventario FOREIGN KEY (CodigoDetalleInventario)
		REFERENCES dbo.Tbl_DetallesInventario (CodigoDetalleInventario)
);

-- Tbl_DetalleTraslado: detalle (cantidad, transporte y recepcion) de cada traslado.
CREATE TABLE dbo.Tbl_DetalleTraslado
(
	CodigoDetalleTraslado INT IDENTITY(1,1),
	CodigoTraslado        INT      NOT NULL,
	CantidadProducto      INT      NOT NULL,
	MedioTransporte       VARCHAR(45)  NOT NULL,
	FechaRecepcion        DATE         NOT NULL,
	Observaciones         VARCHAR(100),
	CONSTRAINT PK_DetalleTraslado PRIMARY KEY (CodigoDetalleTraslado),
	CONSTRAINT FK_DetalleTraslado_Traslados FOREIGN KEY (CodigoTraslado)
		REFERENCES dbo.Tbl_Traslados (CodigoTraslado)
);


-- =====================================================================
-- PARTE 2: DATOS DE PRUEBA (5 registros por tabla)
-- Los codigos son autogenerados (1 a 5), por eso las llaves foraneas
-- de abajo hacen referencia a esos valores.
-- =====================================================================

-- Datos de prueba de la tabla: Tbl_Sucursales
INSERT INTO dbo.Tbl_Sucursales (NombreSucursal, DireccionSucursal, TipoSucursal, EstadoSucursal, Observaciones) VALUES
('Ferreteria Central Zona 1', '5a Avenida 10-25 Zona 1, Guatemala',       'Matriz',   1,  'Sucursal principal'),
('Sucursal Mixco',            'Calzada Roosevelt 12-40 Zona 3, Mixco',    'Sucursal', 1,  NULL),
('Sucursal Villa Nova',       'Boulevard Principal 4-18, Villa Nova',     'Sucursal', 1,  'Atiende pedidos al por mayor'),
('Bodega Escuintla',          'Km 58 Carretera al Pacifico, Escuintla',   'Bodega',   1,  'Almacen de materiales pesados'),
('Sucursal Antigua',          '3a Calle Poniente 15, Antigua Guatemala',  'Sucursal', 0, 'Cerrada temporalmente por remodelacion');

-- Datos de prueba de la tabla: Tbl_Usuarios
INSERT INTO dbo.Tbl_Usuarios (CodigoSucursal, NombreUsuario, TelefonoUsuario, DireccionUsuario, DPIUsuario, Estado) VALUES
(1, 'Carlos Mendez', 55501234, 'Zona 5, Guatemala',  2456789010101, 1),
(1, 'Ana Lopez',     55505678, 'Zona 7, Guatemala',  2456789020101, 1),
(2, 'Luis Perez',    55509012, 'Centro de Mixco',    2456789030101, 1),
(3, 'Maria Garcia',  55503456, 'Villa Nova',         2456789040101, 1),
(4, 'Jose Ramirez',  55507890, 'Centro de Escuintla',2456789050101, 0);

-- Datos de prueba de la tabla: Tbl_TipoEmpleado
INSERT INTO dbo.Tbl_TipoEmpleado (CodigoUsuario, Nombre, Apellido, RolEmpleado, Descripcion, Estado) VALUES
(1, 'Carlos', 'Mendez',  'Gerente',   'Administra la sucursal central',              1),
(2, 'Ana',    'Lopez',   'Cajera',    'Atencion en caja y facturacion',              1),
(3, 'Luis',   'Perez',   'Vendedor',  'Atencion de mostrador y ventas',              1),
(4, 'Maria',  'Garcia',  'Bodeguera', 'Control de entradas y salidas de bodega',     1),
(5, 'Jose',   'Ramirez', 'Piloto',    'Transporte de traslados entre sucursales',    0);

-- Datos de prueba de la tabla: Tbl_Inventario
INSERT INTO dbo.Tbl_Inventario (CodigoSucursal, NombreInventario, CantidadInventario, CantidadMinimaInventario, Ubicacion, Observaciones) VALUES
(1, 'Inventario Herramientas Manuales', 250,  50, 'Pasillo A', NULL),
(1, 'Inventario Materiales Electricos', 400,  80, 'Pasillo B', 'Revisar cada mes'),
(2, 'Inventario Pinturas',              150,  30, 'Estante C', NULL),
(3, 'Inventario Plomeria',              320,  60, 'Pasillo D', 'Rotacion alta'),
(4, 'Inventario Construccion',          900, 200, 'Bodega 1',  'Cemento y varilla');

-- Datos de prueba de la tabla: Tbl_DetallesInventario
INSERT INTO dbo.Tbl_DetallesInventario (CodigoInventario, Descripcion, Ingreso, Egreso, TipoMovimiento, FechaMovimiento) VALUES
(1, 'Ingreso de martillos y destornilladores', 100,   0, 'Entrada', '20260110'),
(2, 'Ingreso de cable e interruptores',        200,   0, 'Entrada', '20260115'),
(3, 'Venta de galones de pintura',               0,  20, 'Salida',  '20260203'),
(4, 'Ingreso de tuberia PVC',                  150,   0, 'Entrada', '20260212'),
(5, 'Traslado de cemento a Villa Nova',          0, 100, 'Salida',  '20260301');

-- Datos de prueba de la tabla: Tbl_Productos
INSERT INTO dbo.Tbl_Productos (CodigoInventario, NombreCategoria, TipoMedicionProducto, CantidadMinimaProducto, CantidadProducto, FechaVencimiento, FechaIngreso) VALUES
(1, 'Herramientas manuales', 'Unidad', 10, 120, NULL,         '20260110'),
(2, 'Material electrico',    'Metro',  50, 300, NULL,         '20260115'),
(3, 'Pintura y acabados',    'Galon',  10,  60, '20280201', '20260120'),
(4, 'Plomeria',              'Unidad', 20, 200, NULL,         '20260212'),
(5, 'Construccion',          'Quintal',50, 500, '20270630', '20260220');

-- Datos de prueba de la tabla: Tbl_Categorias
INSERT INTO dbo.Tbl_Categorias (CodigoProducto, TipoCategoria, Descripcion, Estado, FechaCreacion, FechaActualizacion) VALUES
(1, 'Herramientas', 'Martillos, destornilladores y llaves',  1,  '20260105', '20260105'),
(2, 'Electricidad', 'Cables, interruptores y tomacorrientes', 1,  '20260105', '20260201'),
(3, 'Pintura',      'Pinturas, brochas y rodillos',           1,  '20260106', '20260106'),
(4, 'Plomeria',     'Tuberias, codos y accesorios PVC',       1,  '20260106', '20260210'),
(5, 'Construccion', 'Cemento, varilla y block',               0, '20260107', '20260301');

-- Datos de prueba de la tabla: Tbl_Proveedores
INSERT INTO dbo.Tbl_Proveedores (CodigoCategoria, NombreProveedor, DireccionProveedor, TelefonoProveedor, NitProveedor, Observaciones) VALUES
(1, 'Distribuidora Truper GT',    'Zona 12, Guatemala', 22201111, 1234567, NULL),
(2, 'Electricos del Centro',      'Zona 4, Guatemala',  22202222, 2345678, 'Entrega en 48 horas'),
(3, 'Pinturas Industriales S.A.', 'Zona 9, Guatemala',  22203333, 3456789, NULL),
(4, 'Tuberias y Accesorios',      'Mixco, Guatemala',   22204444, 4567890, 'Descuento por volumen'),
(5, 'Cementos del Pacifico',      'Escuintla',          22205555, 5678901, 'Pago a 30 dias');

-- Datos de prueba de la tabla: Tbl_Compras
INSERT INTO dbo.Tbl_Compras (CodigoDetalleInventario, NumeroCompra, NombreCompra, FechaCompra, DescripcionCompra, Observaciones) VALUES
(1, 1001, 'Compra de herramientas',      '20260110', 'Martillos y destornilladores', NULL),
(2, 1002, 'Compra de material electrico','20260115', 'Cable THHN e interruptores',   NULL),
(3, 1003, 'Compra de pintura',           '20260120', 'Pintura latex blanca',         NULL),
(4, 1004, 'Compra de plomeria',          '20260212', 'Tuberia PVC de 1/2 y 3/4',     'Factura pendiente'),
(5, 1005, 'Compra de cemento',           '20260220', 'Cemento y varilla',            'Pago a credito');

-- Datos de prueba de la tabla: Tbl_DetalleCompras
INSERT INTO dbo.Tbl_DetalleCompras (CodigoCompra, CantidadCompra, PrecioUnitario, Total, FormaPago) VALUES
(1, 100,  45.00,  4500.00, 'Efectivo'),
(2, 200,  12.50,  2500.00, 'Transferencia'),
(3,  60, 150.00,  9000.00, 'Tarjeta'),
(4, 150,  18.00,  2700.00, 'Credito'),
(5, 500,  85.00, 42500.00, 'Cheque');

-- Datos de prueba de la tabla: Tbl_Ventas
INSERT INTO dbo.Tbl_Ventas (CodigoDetalleInventario, FechaVenta, Total, CantidadProductos, FacturaVenta, Observaciones) VALUES
(1, '20260302',  225.00,  5, 50001, NULL),
(2, '20260303',   87.50,  7, 50002, NULL),
(3, '20260305',  600.00,  4, 50003, 'Cliente frecuente'),
(4, '20260307',  180.00, 10, 50004, NULL),
(5, '20260310', 1700.00, 20, 50005, 'Entrega a domicilio');

-- Datos de prueba de la tabla: Tbl_Clientes
INSERT INTO dbo.Tbl_Clientes (CodigoVenta, NombreCliente, ApellidoCliente, DPICliente, TelefonoCliente, EstadoCliente, FechaNacimiento) VALUES
(1, 'Pedro',   'Hernandez', 2987654010101, 55511111, 1,  '19850412'),
(2, 'Sofia',   'Morales',   2987654020101, 55522222, 1,  '19900825'),
(3, 'Roberto', 'Castillo',  2987654030101, 55533333, 1,  '19781103'),
(4, 'Lucia',   'Ortiz',     2987654040101, 55544444, 1,  '19950130'),
(5, 'Miguel',  'Santos',    2987654050101, 55555555, 0, '19820719');

-- Datos de prueba de la tabla: Tbl_DetalleVenta
INSERT INTO dbo.Tbl_DetalleVenta (CodigoVenta, PrecioUnitario, FormaPago, Descripcion, Observaciones, Subtotal) VALUES
(1,  45.00, 'Efectivo',      '5 martillos',             'Sin observaciones',     225.00),
(2,  12.50, 'Tarjeta',       '7 metros de cable',       'Sin observaciones',      87.50),
(3, 150.00, 'Efectivo',      '4 galones de pintura',    'Descuento por volumen', 600.00),
(4,  18.00, 'Transferencia', '10 tubos PVC',            'Sin observaciones',     180.00),
(5,  85.00, 'Credito',       '20 quintales de cemento', 'Entrega a domicilio',  1700.00);

-- Datos de prueba de la tabla: Tbl_Traslados
INSERT INTO dbo.Tbl_Traslados (CodigoDetalleInventario, NombreSucursalSolicitud, FechaSolicitada, FechaEnviada, Observaciones) VALUES
(5, 'Sucursal Villa Nova',        '20260301', '20260302', NULL),
(1, 'Sucursal Mixco',             '20260304', '20260305', NULL),
(2, 'Sucursal Mixco',             '20260306', '20260308', 'Urgente'),
(3, 'Ferreteria Central Zona 1',  '20260309', '20260310', NULL),
(4, 'Bodega Escuintla',           '20260311', '20260313', 'Material fragil');

-- Datos de prueba de la tabla: Tbl_DetalleTraslado
INSERT INTO dbo.Tbl_DetalleTraslado (CodigoTraslado, CantidadProducto, MedioTransporte, FechaRecepcion, Observaciones) VALUES
(1, 100, 'Camion',    '20260303', NULL),
(2,  20, 'Camioneta', '20260306', NULL),
(3,  50, 'Camioneta', '20260309', 'Recibido completo'),
(4,  15, 'Pickup',    '20260311', NULL),
(5,  40, 'Camion',    '20260314', 'Recibido con retraso');
