USE [GiftCards]
GO
/****** Object:  Table [dbo].[ClientesGiftcards]    Script Date: 25/5/2022 14:41:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientesGiftcards](
	[CodTarjeta] [int] NULL,
	[CodCliente] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 25/5/2022 14:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[DNI] [int] NULL,
	[FechaNacimiento] [varchar](50) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DescuentoOtorgado]    Script Date: 25/5/2022 14:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DescuentoOtorgado](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[NumeroTarjeta] [int] NULL,
	[Tipo] [varchar](50) NULL,
	[MontoDescuento] [decimal](8, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 25/5/2022 14:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[Codigo] [int] NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 25/5/2022 14:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Codigo] [int] NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 25/5/2022 14:41:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarjetas](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NULL,
	[Vencimiento] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[Rubro] [varchar](50) NULL,
	[TipoNacProv] [varchar](50) NULL,
	[Provincia] [varchar](50) NULL,
	[Saldo] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1, 4)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (5, 3008)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1005, 1006)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1013, 2008)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1014, 2010)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1011, 2011)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (4, 2010)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1007, 2013)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1009, 2018)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (7, 3006)
GO
INSERT [dbo].[ClientesGiftcards] ([CodTarjeta], [CodCliente]) VALUES (1008, 3007)
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (1006, N'Zack', N'Hemsey', 20134679, N'4/9/2021 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2007, N'Jim', N'Morrison', 36542854, N'5/10/1980 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2008, N'Monica', N'Belluci', 19020210, N'15/10/1975 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2010, N'Rosalinda', N'Celentano', 12987654, N'23/1/1931 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2011, N'Elena', N'Valdez', 23654987, N'24/2/1942 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2013, N'Ricardo', N'Darín', 45321987, N'16/4/1964 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2015, N'Guillermo', N'Francella', 56987321, N'7/5/1975 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2016, N'Carla', N'Quevedo', 67123456, N'18/6/1986 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (2018, N'Pablo', N'Rago', 78321654, N'29/7/1997 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (3006, N'Mike', N'Wazowski', 35355688, N'5/3/2013 00:00:00')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (3007, N'Patricio', N'Estrella', 25255255, N'30/10/2002 01:30:21')
GO
INSERT [dbo].[Clientes] ([Codigo], [Nombre], [Apellido], [DNI], [FechaNacimiento]) VALUES (3008, N'Viviana', N'Canosa', 22854652, N'9/11/1972 22:45:45')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[DescuentoOtorgado] ON 
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (1, 1001, N'Nacional', CAST(3375.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (2, 1003, N'Nacional', CAST(2625.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (3, 2500, N'Nacional', CAST(1125.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (4, 1001, N'Nacional', CAST(1625.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (5, 2010, N'Internacional', CAST(3500.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (6, 963, N'Nacional', CAST(3750.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (7, 258, N'Nacional', CAST(3750.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (8, 369, N'Internacional', CAST(3500.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (13, 369, N'Internacional', CAST(1400.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (14, 369, N'Internacional', CAST(2100.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (16, 369, N'Internacional', CAST(1750.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (17, 1105, N'Internacional', CAST(56000.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (9, 369, N'Internacional', CAST(1750.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (10, 369, N'Internacional', CAST(350.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (15, 369, N'Internacional', CAST(1750.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (11, 369, N'Internacional', CAST(1400.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[DescuentoOtorgado] ([Codigo], [NumeroTarjeta], [Tipo], [MontoDescuento]) VALUES (12, 0, N'Nacional', CAST(1500.00 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[DescuentoOtorgado] OFF
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (1, N'Afganistán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (2, N'Islas Gland')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (3, N'Albania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (4, N'Alemania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (5, N'Andorra')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (6, N'Angola')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (7, N'Anguilla')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (8, N'Antártida')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (9, N'Antigua y Barbuda')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (10, N'Antillas Holandesas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (11, N'Arabia Saudí')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (12, N'Argelia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (13, N'Argentina')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (14, N'Armenia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (15, N'Aruba')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (16, N'Australia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (17, N'Austria')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (18, N'Azerbaiyán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (19, N'Bahamas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (20, N'Bahréin')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (21, N'Bangladesh')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (22, N'Barbados')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (23, N'Bielorrusia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (24, N'Bélgica')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (25, N'Belice')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (26, N'Benin')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (27, N'Bermudas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (28, N'Bhután')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (29, N'Bolivia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (30, N'Bosnia y Herzegovina')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (31, N'Botsuana')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (32, N'Isla Bouvet')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (33, N'Brasil')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (34, N'Brunéi')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (35, N'Bulgaria')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (36, N'Burkina Faso')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (37, N'Burundi')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (38, N'Cabo Verde')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (39, N'Islas Caimán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (40, N'Camboya')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (41, N'Camerún')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (42, N'Canadá')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (43, N'República Centroafricana')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (44, N'Chad')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (45, N'República Checa')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (46, N'Chile')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (47, N'China')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (48, N'Chipre')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (49, N'Isla de Navidad')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (50, N'Ciudad del Vaticano')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (51, N'Islas Cocos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (52, N'Colombia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (53, N'Comoras')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (54, N'República Democrática del Congo')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (55, N'Congo')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (56, N'Islas Cook')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (57, N'Corea del Norte')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (58, N'Corea del Sur')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (59, N'Costa de Marfil')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (60, N'Costa Rica')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (61, N'Croacia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (62, N'Cuba')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (63, N'Dinamarca')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (64, N'Dominica')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (65, N'República Dominicana')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (66, N'Ecuador')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (67, N'Egipto')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (68, N'El Salvador')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (69, N'Emiratos Árabes Unidos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (70, N'Eritrea')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (71, N'Eslovaquia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (72, N'Eslovenia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (73, N'España')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (74, N'Islas ultramarinas de Estados Unidos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (75, N'Estados Unidos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (76, N'Estonia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (77, N'Etiopía')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (78, N'Islas Feroe')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (79, N'Filipinas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (80, N'Finlandia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (81, N'Fiyi')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (82, N'Francia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (83, N'Gabón')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (84, N'Gambia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (85, N'Georgia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (86, N'Islas Georgias del Sur y Sandwich del Sur')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (87, N'Ghana')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (88, N'Gibraltar')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (89, N'Granada')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (90, N'Grecia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (91, N'Groenlandia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (92, N'Guadalupe')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (93, N'Guam')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (94, N'Guatemala')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (95, N'Guayana Francesa')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (96, N'Guinea')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (97, N'Guinea Ecuatorial')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (98, N'Guinea-Bissau')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (99, N'Guyana')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (100, N'Haití')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (101, N'Islas Heard y McDonald')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (102, N'Honduras')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (103, N'Hong Kong')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (104, N'Hungría')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (105, N'India')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (106, N'Indonesia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (107, N'Irán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (108, N'Iraq')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (109, N'Irlanda')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (110, N'Islandia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (111, N'Israel')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (112, N'Italia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (113, N'Jamaica')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (114, N'Japón')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (115, N'Jordania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (116, N'Kazajstán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (117, N'Kenia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (118, N'Kirguistán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (119, N'Kiribati')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (120, N'Kuwait')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (121, N'Laos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (122, N'Lesotho')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (123, N'Letonia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (124, N'Líbano')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (125, N'Liberia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (126, N'Libia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (127, N'Liechtenstein')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (128, N'Lituania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (129, N'Luxemburgo')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (130, N'Macao')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (131, N'ARY Macedonia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (132, N'Madagascar')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (133, N'Malasia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (134, N'Malawi')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (135, N'Maldivas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (136, N'Malí')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (137, N'Malta')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (138, N'Islas Malvinas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (139, N'Islas Marianas del Norte')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (140, N'Marruecos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (141, N'Islas Marshall')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (142, N'Martinica')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (143, N'Mauricio')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (144, N'Mauritania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (145, N'Mayotte')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (146, N'México')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (147, N'Micronesia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (148, N'Moldavia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (149, N'Mónaco')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (150, N'Mongolia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (151, N'Montserrat')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (152, N'Mozambique')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (153, N'Myanmar')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (154, N'Namibia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (155, N'Nauru')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (156, N'Nepal')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (157, N'Nicaragua')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (158, N'Níger')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (159, N'Nigeria')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (160, N'Niue')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (161, N'Isla Norfolk')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (162, N'Noruega')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (163, N'Nueva Caledonia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (164, N'Nueva Zelanda')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (165, N'Omán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (166, N'Países Bajos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (167, N'Pakistán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (168, N'Palau')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (169, N'Palestina')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (170, N'Panamá')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (171, N'Papúa Nueva Guinea')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (172, N'Paraguay')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (173, N'Perú')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (174, N'Islas Pitcairn')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (175, N'Polinesia Francesa')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (176, N'Polonia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (177, N'Portugal')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (178, N'Puerto Rico')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (179, N'Qatar')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (180, N'Reino Unido')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (181, N'Reunión')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (182, N'Ruanda')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (183, N'Rumania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (184, N'Rusia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (185, N'Sahara Occidental')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (186, N'Islas Salomón')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (187, N'Samoa')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (188, N'Samoa Americana')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (189, N'San Cristóbal y Nevis')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (190, N'San Marino')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (191, N'San Pedro y Miquelón')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (192, N'San Vicente y las Granadinas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (193, N'Santa Helena')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (194, N'Santa Lucía')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (195, N'Santo Tomé y Príncipe')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (196, N'Senegal')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (197, N'Serbia y Montenegro')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (198, N'Seychelles')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (199, N'Sierra Leona')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (200, N'Singapur')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (201, N'Siria')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (202, N'Somalia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (203, N'Sri Lanka')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (204, N'Suazilandia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (205, N'Sudáfrica')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (206, N'Sudán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (207, N'Suecia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (208, N'Suiza')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (209, N'Surinam')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (210, N'Svalbard y Jan Mayen')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (211, N'Tailandia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (212, N'Taiwán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (213, N'Tanzania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (214, N'Tayikistán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (215, N'Territorio Británico del Océano Índico')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (216, N'Territorios Australes Franceses')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (217, N'Timor Oriental')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (218, N'Togo')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (219, N'Tokelau')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (220, N'Tonga')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (221, N'Trinidad y Tobago')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (222, N'Túnez')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (223, N'Islas Turcas y Caicos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (224, N'Turkmenistán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (225, N'Turquía')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (226, N'Tuvalu')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (227, N'Ucrania')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (228, N'Uganda')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (229, N'Uruguay')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (230, N'Uzbekistán')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (231, N'Vanuatu')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (232, N'Venezuela')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (233, N'Vietnam')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (234, N'Islas Vírgenes Británicas')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (235, N'Islas Vírgenes de los Estados Unidos')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (236, N'Wallis y Futuna')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (237, N'Yemen')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (238, N'Yibuti')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (239, N'Zambia')
GO
INSERT [dbo].[Paises] ([Codigo], [Nombre]) VALUES (240, N'Zimbabue')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (1, N'Buenos Aires')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (3, N'Capital Federal')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (4, N'Catamarca')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (5, N'Chaco')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (6, N'Chubut')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (7, N'Córdoba')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (8, N'Corrientes')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (9, N'Entre Ríos')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (10, N'Formosa')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (11, N'Jujuy')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (12, N'La Pampa')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (13, N'La Rioja')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (14, N'Mendoza')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (15, N'Misiones')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (16, N'Neuquén')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (17, N'Río Negro')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (18, N'Salta')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (19, N'San Juan')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (20, N'San Luis')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (21, N'Santa Cruz')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (22, N'Santa Fe')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (23, N'Santiago del Estero')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (24, N'Tierra del Fuego')
GO
INSERT [dbo].[Provincias] ([Codigo], [Nombre]) VALUES (25, N'Tucumán')
GO
SET IDENTITY_INSERT [dbo].[Tarjetas] ON 
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1, 1001, N'1/1/2024 16:07:35', N'Activa', N'Libre', N'Argentina', N'San Luis', CAST(25000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (2, 1002, N'21/12/2023 16:07:35', N'Baja', N'Calzado', N'Australia', NULL, CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (3, 1003, N'10/2/2023 17:22:16', N'Baja', N'Electrodomesticos', N'Argentina', N'Río Negro', CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (4, 1100, N'12/12/2024 16:07:35', N'Libre', N'Libre', N'Grecia', NULL, CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (5, 2010, N'18/5/2024 16:07:35', N'Activa', N'Calzado', N'Alemania', NULL, CAST(35000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1005, 1101, N'12/5/2025 17:49:26', N'Activa', N'Electrodomesticos', N'Argentina', N'Salta', CAST(18000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (7, 2150, N'18/5/2024 16:07:35', N'Activa', N'Libre', N'Argentina', N'Chubut', CAST(25000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1006, 1102, N'1/1/2024 17:49:26', N'Baja', N'Calzado', N'Argentina', N'Salta', CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1007, 1103, N'1/1/2023 17:49:26', N'Activa', N'Electrodomesticos', N'Argentina', N'Santa Fe', CAST(25000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1008, 1104, N'9/11/2026 17:49:26', N'Alta', N'Libre', N'Brasil', NULL, CAST(90000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1009, 1105, N'8/10/2025 17:49:26', N'Sin Saldo', N'Calzado', N'Italia', NULL, CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1010, 1106, N'7/9/2024 17:49:26', N'Baja', N'Electrodomesticos', N'Italia', NULL, CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1011, 963, N'18/5/2024 16:07:35', N'Alta', N'Libre', N'Argentina', N'Chubut', CAST(55000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1012, 852, N'1/1/2024 17:49:26', N'Baja', N'Electrodomesticos', N'Grecia', NULL, CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1013, 741, N'1/1/2023 17:49:26', N'Alta', N'Electrodomesticos', N'Argentina', N'Salta', CAST(40000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1014, 369, N'9/11/2026 17:49:26', N'Alta', N'Libre', N'Grecia', NULL, CAST(10000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1015, 258, N'8/10/2025 17:49:26', N'Baja', N'Electrodomesticos', N'Argentina', N'Santa Fe', CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1016, 147, N'7/9/2024 17:49:26', N'Baja', N'Electrodomesticos', N'Grecia', NULL, CAST(0 AS Decimal(18, 0)))
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1017, 2525, N'25/5/2021 01:41:24', N'Libre', N'Electrodomesticos', N'Argentina', N'Córdoba', NULL)
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1018, 1105, N'8/10/2025 17:49:26', N'Baja', N'Calzado', N'Italia', NULL, NULL)
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1023, 2001, N'25/5/2022 14:34:24', N'Vencida', N'Calzado', N'Afganistán', NULL, NULL)
GO
INSERT [dbo].[Tarjetas] ([Codigo], [Numero], [Vencimiento], [Estado], [Rubro], [TipoNacProv], [Provincia], [Saldo]) VALUES (1024, 2002, N'25/5/2022 14:34:41', N'Vencida', N'Calzado', N'Argentina', N'Buenos Aires', NULL)
GO
SET IDENTITY_INSERT [dbo].[Tarjetas] OFF
GO
