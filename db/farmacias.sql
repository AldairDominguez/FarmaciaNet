USE [farmacias]
GO
/****** Object:  User [Topicos]    Script Date: 4/02/2025 02:05:55 ******/
CREATE USER [Topicos] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Topicos]
GO
/****** Object:  Table [dbo].[almacen]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[almacen](
	[idalmacen] [int] NOT NULL,
	[idsucursal] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idalmacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detallefactura]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detallefactura](
	[idfactura] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleados]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[idempleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
	[apellidos] [nvarchar](30) NULL,
	[idpuesto] [int] NOT NULL,
	[idsucursal] [int] NOT NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idempleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[idfactura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [nvarchar](10) NOT NULL,
	[total] [int] NOT NULL,
	[idempleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idfactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[inventario]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventario](
	[existencias] [int] NOT NULL,
	[idalmacen] [int] NOT NULL,
	[idproducto] [int] NOT NULL,
	[fecha] [nvarchar](10) NULL,
	[comentarios] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productos]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productos](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[producto] [nvarchar](30) NOT NULL,
	[Activo] [nvarchar](50) NOT NULL,
	[idvia] [int] NOT NULL,
	[reqReceta] [bit] NOT NULL,
	[Precio] [int] NOT NULL,
	[idproveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Responsable] [nvarchar](30) NULL,
	[Direccion] [nvarchar](150) NULL,
	[RFC] [nvarchar](20) NULL,
	[Telefono] [nvarchar](10) NULL,
	[Correo] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puestos](
	[idpuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idpuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receta]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receta](
	[idreceta] [int] NOT NULL,
	[idfactura] [int] NULL,
	[nombreDoctor] [nvarchar](30) NOT NULL,
	[Apellido] [nvarchar](30) NOT NULL,
	[Cedula] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idreceta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sucursal]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sucursal](
	[idsucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[direccion] [nvarchar](30) NOT NULL,
	[telefono] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[idsucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](20) NOT NULL,
	[contraseña] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[viaAdministracion]    Script Date: 4/02/2025 02:05:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viaAdministracion](
	[idvia] [int] NOT NULL,
	[descripcion] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idvia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[almacen] ([idalmacen], [idsucursal]) VALUES (101, 1)
GO
SET IDENTITY_INSERT [dbo].[empleados] ON 

INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (1, N'David', N'Vega Estrada', 1, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (2, N'Rambo', N'Jhon ', 2, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (3, N'Juan', N'Checa', 2, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (4, N'Jose', N'Urrutia', 1, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (1003, N'kevin', N'flores', 2, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (1004, N'Aldair', N'Dominguez', 1, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (1005, N'Aime', N'Gavidia', 1, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (1006, N'Sebastiam', N'Carrasco', 2, 1, 1)
INSERT [dbo].[empleados] ([idempleado], [nombre], [apellidos], [idpuesto], [idsucursal], [estado]) VALUES (2004, N'Juan', N'Robles', 2, 1, 1)
SET IDENTITY_INSERT [dbo].[empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[factura] ON 

INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1, N'21/06/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (2, N'21/06/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (3, N'21/06/2023', 285, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (4, N'21/06/2023', 650, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (5, N'2/07/2023', 0, 3)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1005, N'3/07/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1006, N'3/07/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1007, N'3/07/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1008, N'3/07/2023', 440, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1009, N'3/07/2023', 440, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1010, N'3/07/2023', 630, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1011, N'3/07/2023', 630, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1012, N'3/07/2023', 630, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1013, N'3/07/2023', 630, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1014, N'3/07/2023', 630, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1015, N'3/07/2023', 630, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1016, N'3/07/2023', 190, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1017, N'3/07/2023', 190, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1018, N'3/07/2023', 190, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1019, N'3/07/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1020, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1021, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1022, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1023, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1024, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1025, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1026, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1027, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1028, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1029, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1030, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1031, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1032, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1033, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1034, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1035, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1036, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1037, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1038, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1039, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1040, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1041, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1042, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1043, N'3/07/2023', 520, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1044, N'3/07/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1045, N'3/07/2023', 415, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1046, N'3/07/2023', 190, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1047, N'3/07/2023', 325, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1048, N'3/07/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1049, N'3/07/2023', 19, 3)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1050, N'3/07/2023', 12, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1051, N'7/07/2023', 0, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1052, N'9/07/2023', 2, 2)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1053, N'13/07/2023', 8, 3)
INSERT [dbo].[factura] ([idfactura], [fecha], [total], [idempleado]) VALUES (1054, N'23/10/2024', 4, 1006)
SET IDENTITY_INSERT [dbo].[factura] OFF
GO
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (98, 101, 1004, N'Jul  3 202', N'Paracetamol')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (158, 101, 1006, N'Jul  3 202', N'Panadol')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (68, 101, 1007, N'Jul  3 202', N'Apronax ')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (32, 101, 1008, N'Jul  3 202', N'Desinprox')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (105, 101, 1009, N'Jul  3 202', N'Gripamec')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (63, 101, 1010, N'Jul  3 202', N'Azitromicina')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (97, 101, 1011, N'Jul  3 202', N'Aspirina')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (52, 101, 1012, N'Jul  3 202', N'Dibrolax')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (74, 101, 1013, N'Jul  3 202', N'Ceterizina')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (63, 101, 1014, N'Jul  3 202', N'Soluna')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (94, 101, 1015, N'Jul  3 202', N'Amoxil')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (57, 101, 1016, N'Jul  3 202', N'Anaflex')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (85, 101, 1017, N'Jul  3 202', N'Bonacoxib')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (78, 101, 1018, N'Jul  3 202', N' Buscapina')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (61, 101, 1019, N'Jul  3 202', N'Captopril')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (120, 101, 1020, N'Jul  3 202', N'Enalapril')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (68, 101, 1021, N'Jul  3 202', N'Equalax')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (58, 101, 1022, N'Jul  3 202', N'Lactulosa')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (90, 101, 1023, N'Jul  3 202', N'Losartan')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (103, 101, 1024, N'Jul  3 202', N'Mejoral')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (74, 101, 1025, N'Jul  3 202', N'Metamizol Sodico')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (83, 101, 1026, N'Jul  3 202', N'Miodel Relax')
INSERT [dbo].[inventario] ([existencias], [idalmacen], [idproducto], [fecha], [comentarios]) VALUES (69, 101, 1027, N'Jul  3 202', N'Nastizol Forte')
GO
SET IDENTITY_INSERT [dbo].[productos] ON 

INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1004, N'Paracetamol', N'Paracetamol', 1, 0, 1, 1006)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1006, N'Panadol', N'Paracetamol', 1, 0, 1, 1006)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1007, N'Apronax ', N'Naproxeno', 1, 0, 2, 1006)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1008, N'Desinprox', N'Naproxeno', 1, 0, 1, 1006)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1009, N'Gripamec', N'Gripamec', 1, 0, 2, 1006)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1010, N'Azitromicina', N'Azitromicina Dihidrato', 1, 1, 3, 1006)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1011, N'Aspirina', N'Ácido Acetilsalicílico', 1, 0, 1, 1007)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1012, N'Dibrolax', N'Picosulfato Sódico', 1, 0, 2, 1007)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1013, N'Ceterizina', N'Dihidrocloruro de Cetirizina', 1, 0, 1, 1007)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1014, N'Soluna', N'Estradiol', 3, 0, 15, 1007)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1015, N'Amoxil', N'amoxicilina', 1, 1, 2, 1007)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1016, N'Anaflex', N'Paracetamol Diclofenaco Cafeína', 1, 0, 2, 1007)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1017, N'Bonacoxib', N'Etoricoxib', 1, 1, 3, 1008)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1018, N' Buscapina', N'Butilescopolamina Bromuro', 1, 0, 2, 1008)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1019, N'Captopril', N'Captopril', 1, 1, 1, 1008)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1020, N'Enalapril', N'Maleato de enalapril', 1, 1, 2, 1008)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1021, N'Equalax', N'Bisacodilo', 1, 0, 2, 1008)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1022, N'Lactulosa', N'Lactosa, Galactosa y Fructosa', 1, 0, 15, 1008)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1023, N'Losartan', N'Losartán Potásico e Hidroclorotiazida', 1, 1, 1, 1008)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1024, N'Mejoral', N'Paracetamol', 1, 0, 1, 1009)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1025, N'Metamizol Sodico', N'Metamizol Sodico', 3, 1, 3, 1009)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1026, N'Miodel Relax', N'Paracetamol (Analgesico) + Orfenadrina', 1, 0, 2, 1009)
INSERT [dbo].[productos] ([idproducto], [producto], [Activo], [idvia], [reqReceta], [Precio], [idproveedor]) VALUES (1027, N'Nastizol Forte', N'Paracetamol Fenilefrina Clorfenamina', 1, 1, 3, 1009)
SET IDENTITY_INSERT [dbo].[productos] OFF
GO
SET IDENTITY_INSERT [dbo].[proveedor] ON 

INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1006, N'FarmaLeon', N'Homero', N'Av.Rimac', N'8887779922585252', N'0125849898', N'homero@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1007, N'Lusa', N'Camila', N'Av.Lima', N'889986516133333322', N'0125582458', N'Lusa@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1008, N'Genfar', N'Sofia', N'Av.MiraFlores', N'879516316988822877', N'0126644789', N'Sofia@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1009, N'Pharmed', N'Luis', N'Av.Huascar', N'87984565423165498', N'012354478', N'Luis@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1010, N'Apropo', N'Pedro', N'Av.Centro', N'7879788898798879', N'0153267895', N'Pedro@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1011, N'Perulab', N'Dennis', N'Av.Proceres', N'877978846654131123', N'01455622', N'Dennis@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1012, N'Belvs', N'Stefany', N'Av.JuanLima', N'66256487441588887', N'0163226975', N'Stefany@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1013, N'Bonachparm', N'Elvis', N'Av.Brasil', N'33265489451651654', N'0125779862', N'Elvis@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1014, N'Portugal', N'Ruben ', N'Av.SanMartin', N'895494522231649978', N'0158796324', N'Ruben@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1016, N'Elifarma', N'Vania', N'Av.SanJorge', N'98794646522165498', N'0123549489', N'Vania@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1017, N'Eurofarma', N'Maria', N'Av.Venezuela', N'787897784649879955', N'0169987898', N'Maria@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1018, N'IntiFarma', N'Jaime', N'Av.SimpreViva', N'879844156116654995', N'0178999652', N'Jaime@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1019, N'Bayer', N'Daniela', N'Av.SanIsidro', N'878946513213168499', N'0196322598', N'Daniela@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1020, N'Tva', N'Raul', N'Av.Alcazar', N'87984646513215877', N'0136997742', N'Raul@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1021, N'Iqfarma', N'Natividad', N'Av.ElSol', N'8797845465132136587', N'0136987452', N'Natividad@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1022, N'BdFarma', N'Dionisio', N'Av.Rambla', N'9879456132165849888', N'0123658974', N'Dionisio@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1023, N'DioFarma', N'Fernanda', N'Av.MoeyeDeSur', N'879845132697898465', N'0174526698', N'Fernanda@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1024, N'JPS', N'Fernando', N'Av.Felicia', N'7798415131698416517', N'0198662574', N'Fernando@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1025, N'Farmi', N'Fernan', N'Av.Delgado', N'987984649844659987', N'0123658974', N'Fernan@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1026, N'Multilab', N'Fer', N'Av.Calderia', N'984456113216498784', N'017894265', N'Fer@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1027, N'Suiza', N'Tereza', N'Av.Lola', N'2131649845611321654', N'0125469988', N'Tereza@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1028, N'Unilab', N'Reyhack', N'Av.Enrique', N'98977465123101987', N'0123654789', N'Reyhack@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1029, N'ESK', N'Luisio', N'Av.España', N'984456123654984778', N'0136589647', N'Luisio@hotmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1030, N'Rube', N'Zaria', N'Av.Brasil', N'5618122523156497489', N'0198674523', N'Zaria@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1031, N'Zalofi', N'Gabriela', N'Av.LosAngeles', N'849845612316479846', N'0187956523', N'Gabriela@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1032, N'1', N'', N'', N'', N'', N'')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (1033, N'Inkafarma', N'Juan Perez', N'Av.Lima', N'5144561564564', N'01994856', N'inka@gmail.com')
INSERT [dbo].[proveedor] ([idproveedor], [Nombre], [Responsable], [Direccion], [RFC], [Telefono], [Correo]) VALUES (2033, N'', N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[puestos] ON 

INSERT [dbo].[puestos] ([idpuesto], [nombre]) VALUES (1, N'Gerente')
INSERT [dbo].[puestos] ([idpuesto], [nombre]) VALUES (2, N'Vendedor')
SET IDENTITY_INSERT [dbo].[puestos] OFF
GO
INSERT [dbo].[receta] ([idreceta], [idfactura], [nombreDoctor], [Apellido], [Cedula]) VALUES (1462532465, 1, N'juan', N'perez', 1)
GO
SET IDENTITY_INSERT [dbo].[sucursal] ON 

INSERT [dbo].[sucursal] ([idsucursal], [nombre], [direccion], [telefono]) VALUES (1, N'Farmacias Internacional', N'Otay', N'6643286895')
INSERT [dbo].[sucursal] ([idsucursal], [nombre], [direccion], [telefono]) VALUES (2, N'Farmacias Del Ahorro', N'Otay', N'6643286895')
SET IDENTITY_INSERT [dbo].[sucursal] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (1, N'David', N'admin123')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (2, N'Rambo', N'ventas123')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (3, N'Juan', N'ventas123')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (4, N'Jose', N'admin123')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (1003, N'Kevin', N'vendedor123')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (1004, N'Aldair', N'admin123')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (1005, N'Aime', N'       ')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (1006, N'Sebastiam', N'   ')
INSERT [dbo].[usuarios] ([idusuario], [usuario], [contraseña]) VALUES (2004, N'JuanR', N'vende123')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
INSERT [dbo].[viaAdministracion] ([idvia], [descripcion]) VALUES (1, N'oral')
INSERT [dbo].[viaAdministracion] ([idvia], [descripcion]) VALUES (2, N'intravenosa')
INSERT [dbo].[viaAdministracion] ([idvia], [descripcion]) VALUES (3, N'intramuscular')
GO
ALTER TABLE [dbo].[almacen]  WITH CHECK ADD FOREIGN KEY([idsucursal])
REFERENCES [dbo].[sucursal] ([idsucursal])
GO
ALTER TABLE [dbo].[detallefactura]  WITH CHECK ADD FOREIGN KEY([idfactura])
REFERENCES [dbo].[factura] ([idfactura])
GO
ALTER TABLE [dbo].[detallefactura]  WITH CHECK ADD FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([idproducto])
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD FOREIGN KEY([idpuesto])
REFERENCES [dbo].[puestos] ([idpuesto])
GO
ALTER TABLE [dbo].[empleados]  WITH CHECK ADD FOREIGN KEY([idsucursal])
REFERENCES [dbo].[sucursal] ([idsucursal])
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD FOREIGN KEY([idempleado])
REFERENCES [dbo].[empleados] ([idempleado])
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD FOREIGN KEY([idalmacen])
REFERENCES [dbo].[almacen] ([idalmacen])
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD FOREIGN KEY([idproducto])
REFERENCES [dbo].[productos] ([idproducto])
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD FOREIGN KEY([idproveedor])
REFERENCES [dbo].[proveedor] ([idproveedor])
GO
ALTER TABLE [dbo].[productos]  WITH CHECK ADD FOREIGN KEY([idvia])
REFERENCES [dbo].[viaAdministracion] ([idvia])
GO
ALTER TABLE [dbo].[receta]  WITH CHECK ADD FOREIGN KEY([idfactura])
REFERENCES [dbo].[factura] ([idfactura])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([idusuario])
REFERENCES [dbo].[empleados] ([idempleado])
GO
