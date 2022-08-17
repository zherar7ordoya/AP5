USE [master]
GO
/****** Object:  Database [PedidosDeInsumosDeOficina]    Script Date: 4/7/2022 17:44:58 ******/
CREATE DATABASE [PedidosDeInsumosDeOficina]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PIO', FILENAME = N'C:\Documents\AP4\[Lenguajes de Ultima Generacion]\TPN2_LUG_Tordoya_Gerardo\DATABASE\PIO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PIO_log', FILENAME = N'C:\Documents\AP4\[Lenguajes de Ultima Generacion]\TPN2_LUG_Tordoya_Gerardo\DATABASE\PIO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PedidosDeInsumosDeOficina].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET ARITHABORT OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET  MULTI_USER 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET QUERY_STORE = OFF
GO
USE [PedidosDeInsumosDeOficina]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[CategoriaID] [char](4) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[DepartamentoID] [char](4) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[DepartamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Legajo] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[DepartamentoID] [char](4) NOT NULL,
	[RolID] [char](4) NOT NULL,
 CONSTRAINT [PK_Employee_1] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaID] [char](4) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Descripcion] [varchar](max) NULL,
	[PrecioUnitario] [decimal](9, 2) NOT NULL,
	[ProveedorID] [char](4) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[OrdenID] [int] IDENTITY(1,1) NOT NULL,
	[Legajo] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Estado] [char](10) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrdenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes_Items]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes_Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrdenID] [int] NOT NULL,
	[ItemID] [int] NOT NULL,
	[PrecioUnitario] [decimal](9, 2) NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ProveedorID] [char](4) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ProveedorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolID] [char](4) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-01', N'Archivar documentos', N'Archivar se define como ''guardar papeles en un archivo''. La elaboración de documentos y su custodia todavía es la principal tarea de muchas oficinas. Para ello existen dos posibilidades: archivar documentos perforando el papel, o bien sin taladrarlos. Para conservar papeles perforados se usan los archivadores y las carpetas de anillas. El archivador, a diferencia de la carpeta, incluye una palanca para abrir las anillas: es una solución de archivo más eficaz y por eso se usa mucho en las oficinas. En cambio, la carpeta de anillas se prefiere, por ejemplo, como organizador escolar. Si no se quiere perforar el documento, los materiales de oficina que nos van a permitir hacerlo son aún más variados. Las carpetas con fundas de plástico protegen los documentos y nos permiten hojearlos con facilidad. Las carpetas de proyectos son idóneas para guardar planos y presentar proyectos profesionales. Los dosieres con pinza son útiles para presentar unos pocos papeles de manera directa y sencilla. En las carpetas colgantes se pueden organizar todo tipo de expedientes, estas cuelgan de las guías de un fichero metálico. Los sobres de plástico y los maletines portafolios son una buena solución para proteger y transportar los papeles del día a día.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-02', N'Borrar trazos de lápiz', N'Como se verá más adelante en el verbo «Escribir», los trazos de los lápices de grafito se pueden borrar. El material que se usa para ello es la goma de borrar, que puede ser de caucho o plástica. Las gomas de borrar Milan 430 son de caucho. Son muy blandas, útiles y económicas para borrar trazos de grafito y portaminas. Los borradores de vinilo de marcas como Staedtler (Mars Plastic), Faber-Castell o Rotring no producen apenas residuos al borrar y son idóneos para dibujo técnico. Este producto también se encuentra en versión lápiz: el portagomas. Este borrador mecánico es similar a un portaminas y contiene en su interior un cilindro de goma de borrar que se puede sustituir cuando se gasta.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-03', N'Corregir textos escritos con bolígrafo', N'A diferencia de los lápices, y a menos que sean borrables, los bolígrafos tienen tinta que no se puede eliminar del papel. Para corregir los errores en los textos escritos con estos instrumentos de escritura se usan los correctores típex. Estos pueden ser líquidos o de cinta. Hoy se usa, sobre todo, el típex de cinta porque no requiere esperar a que seque y permite corregir de manera inmediata los errores. Los correctores de oficina evolucionaron a partir de los usados en máquinas de escribir. La marca Tipp-Ex, castellanizada como típex, fue la primera en introducir un producto que permitía rectificar los errores cometidos con máquinas de escribir. Para ello se superponía una hoja de Tipp-Ex sobre el papel y se pulsaba la tecla de la máquina que corresponde con la letra que se quiere suprimir. Con el impacto de esta, el dorso del Tipp-Ex se transfería al papel dejando sobre la tinta una capa blanca que eliminaba el error.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-04', N'Cortar papel, cartulina y plástico', N'Cortar es ''dividir en dos o más partes un objeto usando un útil afilado''. Los materiales de oficina se pueden separar con tijeras, cúter, guillotinas y cizallas de rodillo. La tijera es el útil formado por dos hojas afiladas cruzadas que se articulan sobre un eje. Dichas cuchillas disponen de dos anillos en sus extremos en los que se meten los dedos. Con las tijeras de oficina se puede cortar papel, cartulina, cartón y plástico flexible. El cúter es un instrumento con forma de cuchillo que sirve para hacer incisiones en materiales blandos de oficina o productos de manualidades. Cuando se requiere, por ejemplo, eliminar un fragmento en el interior de un folio de papel respetando el perímetro no se usan las tijeras, sino el cúter. Los escalpelos de precisión son una variante de este cortador que incluyen una cuchilla ultrafilada con la que se logran cortes muy finos en papel, cartulina, corcho, goma EVA y otros materiales. Dejando de lado los materiales de mano, encontramos la guillotina, una pequeña máquina de oficina que sirve para cortar papel y fotografías en línea recta. Una variante de esta herramienta es la cizalla de cuchilla circular. Con las mejores cizallas, además de cortes rectos, también se pueden obtener efectos especiales como los bordes ondulados o en zig-zag.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-05', N'Destruir archivos', N'Toda oficina requiere deshacerse de aquellos papeles que ya no son útiles periódicamente. Puesto que estos contienen información sensible de sus clientes y proveedores, la destrucción de los documentos debe hacerse de manera que se preserve la confidencialidad de las personas. Y para ello se usan las destructoras de papel. Según el volumen de papeles que en ellas se vayan a procesar diaria o semanalmente, se pueden comprar trituradoras de archivos más o menos potentes. Estas máquinas se clasifican según el número simultáneo de hojas que pueden triturar y según el tiempo durante el que pueden operar antes de reposar para permitir que sus cuchillas se enfríen (ciclo de trabajo).')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-06', N'Encuadernar documentos', N'La encuadernación de documentos sirve para presentar de manera eficaz la información a los clientes, proveedores, alumnos, etc. Para esta tarea se requiere la máquina de encuadernar y el consumible que esta use. Con las encuadernadoras térmicas y las de presión se consigue que los cuadernillos tengan el aspecto de un libro. Más económicas son las de espiral metálica o canutillo de plástico, las cuales perforan los documentos y los agrupan usando un gusanillo con anillas.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-07', N'Escribir', N'En las oficinas de antes se escribía, sobre todo, con máquina de escribir. Hoy se golpean los teclados del ordenador para transcribir la información. Sin embargo, en ambos casos se siguen usando bolígrafos, plumas estilográficas, rotuladores, marcadores, lápices y portaminas cuando se trata de escribir a mano. La estilográfica fue uno de los primeros instrumentos modernos para escribir con tinta, antes de su invención se usaban plumas de aves. Con las primeras plumas no se podía escribir más que unas pocas palabras y para ello se sumergían una y otra vez en el tintero. Después, aparecieron las plumas con depósito recargable y, más tarde, las de cartucho desechable. La llegada del bolígrafo hizo que dejásemos de escribir con estilográfica. La conveniencia de un depósito que almacenaba suficiente tinta para poder escribir durante meses, el secado rápido del trazo y el hecho de que no perdiese tinta del depósito fueron algunos de los aspectos clave por los que el uso de este instrumento de escritura terminó por imponerse. Sin embargo, no fue un proceso sencillo, los primeros prototipos de bolígrafos no funcionaban bien y perdían tinta. Hasta que no se inventó el modelo que combinaba la acción de la gravedad y la capilaridad en el mecanismo de flujo no fue realmente eficaz. Las tintas de los primeros bolígrafos (basadas en aceite) eran más espesas y pesadas. Todavía se usan. Las encontramos, por ejemplo, en el Bic Cristal. Se disfruta de una escritura más fluida si se opta por comprar un bolígrafo con tinta líquida o de gel. Cuando la punta del bolígrafo no es metálica, sino de fibra, lo llamamos rotulador. La tinta de los rotuladores puede ser permanente o no serlo y se fabrica en una gran gama de colores. En manualidades infantiles, los rotuladores escolares sirven para dibujar y colorear. También existen rotuladores con tinta pigmentada para trazar las líneas en dibujo técnico. El marcador fluorescente es una variante con punta biselada del rotulador que sirve para subrayar textos. Hasta que no se inventó una tinta fluorescente y transparente no se pudo disfrutar de estos materiales y era necesario usar bolígrafos para subrayar los renglones, o bien lápices de grafito. Entre los materiales de oficina para escribir no pueden faltar los lápices de grafito. Estos son muy diferentes a los bolígrafos: no contienen tinta y su mina es afilable. Tiene algunas ventajas frente al bolígrafo: (1) el lápiz se puede borrar, (2) no hay riesgo de derrame de tinta, (3) al no contenerla nunca se secan, (4) se pueden afilar para reducir el grosor de trazo, (5) con ellos se puede escribir en cualquier posición, al no depender de la gravedad. Según una conocida leyenda urbana, durante la carrera espacial, los americanos invirtieron una gran suma de dinero para fabricar un bolígrafo que permitiera a sus astronautas escribir en el espacio. Los rusos, enfrentados al mismo problema, decidieron usar un lápiz.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-08', N'Explicar una idea en público', N'Cuando se trata de explicar una idea a los compañeros de trabajo o de anotar un esquema que resuma las ideas que va a tratar el profesor en clase, no sirve el papel. ¿Qué usamos entonces? Las pizarras blancas para marcadores, o las verdes para tizas. Por su tamaño, la pizarra es uno de los sistemas más efectivos para la comunicación visual. Es idónea para exponer ideas en público. Y es económica: las mejores pizarras ofrecen más de 20 años de garantía y el precio de los rotuladores (o el de las tizas) es muy asequible. ¿Qué pizarra comprar? Las blancas no magnéticas son las más baratas, pero también las menos duraderas. Los modelos de chapa de acero pintada, o mejor, vitrificada, son mucho más resistentes y le brindan al ponente la posibilidad de usar imanes para que sus explicaciones sean más fructíferas. En cuanto al útil de escritura, si la pizarra es para rotulador, este ha de ser especial, hablamos del marcador de borrado en seco. En cambio, si es para tiza, habrá que tener en cuenta que hay personas que son alérgicas al polvo de tiza; las mejores tizas incorporan un aditivo antipolvo eficaz que puede reducir las molestias asociadas al polvo de tiza que se genera al borrar la pizarra.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-09', N'Grapar papeles', N'Grapar es ''unir dos o más piezas de papel usando una pieza metálica doblada por sus extremos''. Los materiales de oficina necesarios para esta tarea son las grapas y grapadoras. Las grapadoras pueden ser de bolsillo, sobremesa o tenaza. Se clasifican según la capacidad de grapado (cuántas hojas son capaces de unir) y la profundidad de entrada del papel (distancia a la que pueden situar las grapas desde el borde del documento). Para grapar grandes cantidades de folios, las grapadoras de alta capacidad son las más efectivas. También existen grapadoras eléctricas, que no requieren esfuerzo por parte del usuario y mejoran el rendimiento de la oficina.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-10', N'Imprimir información', N'En la oficina moderna ya no se escribe a máquina, en su lugar, se imprimen los documentos en impresoras. El papel más usado en estos equipos es el de formato A4 con gramaje de 80 g. El gramaje es la medida que nos indica el peso del papel en relación a su área. El papel es más grueso y consistente cuanto más pesado sea.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-11', N'Organizar ideas en paredes', N'Los cuadernos, las agendas y las notas post-it son materiales de oficina eficaces para no olvidarse de nada y organizar las tareas de la semana. Pero hay ideas que necesitan más visibilidad. Hablamos de las tareas que se han de coordinar con los compañeros de trabajo, los horarios y calendarios o la información expuesta la público. Para lo anterior, una de las soluciones más efectivas es el tablero de anuncios. Si se cuelga de la pared una pizarra de corcho y disponemos de las agujas y chinchetas adecuadas para ello, podremos tener a la vista todas aquellas ideas a las que recurrimos con frecuencia o las tareas planificadas que no debemos olvidar. Las pizarras de corcho pueden estar enmarcadas con listones de madera de pino o con aluminio. Estos últimos son más resistentes. En el precio de ella influye, además, la rigidez del tablero y el espesor del corcho. En cuanto a las chinchetas y agujas, las primeras son más cortas y con cabeza plana o redondeada; las agujas son mucho más largas pero la mayor parte de su longitud se debe a su cabeza de plástico, la cual aumenta la visibilidad de la chincheta y facilita su manipulación.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-12', N'Perforar folios', N'Como ya vimos, para archivar papeles una de las soluciones posibles consistía en perforar estos para su conservación en archivadores o carpetas de anillas. Pues bien, los folios se taladran con perforadoras de papel. Los taladros de papel contienen dos o más punzones metálicos afilados y una palanca que los empuja a través de los archivos. Como las grapadoras, se clasifican según su capacidad de perforación.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-13', N'Pegar material de oficina', N'Para pegar papel y otros materiales de oficina se usan los adhesivos y pegamentos. Estos pueden ser líquidos, sólidos o con forma de cinta. Entre los pegamentos líquidos encontramos el universal, que sirve para pegar casi todos los materiales; la cola blanca escolar se usa para pegar cartulina y papel; el adhesivo de cianoacrilato es instantáneo y pega en segundos; el adhesivo de contacto es algo diferente: se aplica a las superficies por separado y se deja secar, al juntar las piezas, estas se adhieren por contacto. El pegamento sólido de oficina más usado es el de barra. El adhesivo de barra también es imprescindible para uso escolar. Sirve para pegar papel, cartulina y cartón. Una manera más limpia y rápida de pegar ciertos materiales en la oficina es con cintas adhesivas. El celo es una película transparente con la que se pueden pegar papeles. Para usar el celo de manera eficaz se ha de ubicar en un dispensador de cinta adhesiva. Parecida al celo, pero con adhesivo por ambas caras, la cinta de doble cara es útil para montar y fijar diferentes materiales.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-14', N'Plastificar hojas', N'Cuando se necesita proteger un documento contra los líquidos y las manchas de grasa, se plastifica. Se usa para ello la plastificadora, una máquina de oficina que derrite los bordes de plástico de una funda en la que se inserta el papel. Una vez plastificado, el documento es impermeable y se puede exponer en exteriores.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-15', N'Plegar papel o cartas', N'En Europa se usa el formato de papel A4 para imprimir los documentos de oficina tales como albaranes, facturas, presupuestos y cartas a clientes. En EE.UU, por el contrario, se sigue usando el formato imperial US Letter. Se puede enviar un documento A4 por correo sin plegar usando los sobres de la serie C de la norma DIN que define los formatos de papel. Por ejemplo, el sobre que permite enviar un folio A4 sin plegarlo es el sobre DIN C4. Lo anterior es útil para enviar un fajo de documentos A4 grapados, sin embargo, cuando se trata de enviar solo una hoja, se puede reducir el tamaño del sobre plegando el A4 en tres partes, en forma de Z. En tal caso, la carta plegada se envía con un sobre de formato americano. Aquellas oficinas que semanalmente envíen cientos de cartas querrán comprar una plegadora de papel automática para simplificar esta tarea. Las plegadoras poseen una bandeja de alimentación, un dispositivo que dobla el papel y una cesta de salida en la que se almacenan las cartas plegadas.')
GO
INSERT [dbo].[Categorias] ([CategoriaID], [Nombre], [Descripcion]) VALUES (N'C-16', N'Recordar ideas', N'En los laboratorios de la compañía americana 3M, Spencer Silver descubrió por accidente un adhesivo de baja pegajosidad. Aunque en un primer momento no supo que hacer con él, otro hecho accidental le ayudo a sacar partido comercial a este adhesivo. Un amigo suyo que perdía continuamente los papeles que guardaba en su libro de salmos le sirvió de inspiración para fabricar las famosas notas Post-it. Que sean amarillas también fue accidental: era el papel que tenían a mano por aquel entonces. En las notas Post-it se pueden anotar todo tipo de información para evitar olvidarla: avisos telefónicos, recordatorios, números de referencia, listas de la compra...')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-01', N'Recepción')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-02', N'Atención al Público')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-03', N'Publicidad')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-04', N'Editorial')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-05', N'Clasificados')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-06', N'Diseño')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-07', N'Infomerciales')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-08', N'Sistemas')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-09', N'Correctores')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-10', N'Paginación')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-11', N'Fotografía')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-12', N'Página Web')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-13', N'Policiales')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-14', N'Periodistas')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-15', N'Directorio')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-16', N'Administración')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-17', N'Contabilidad')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-18', N'Cuentas Corrientes')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-19', N'Personal')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-20', N'Facturación')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-21', N'Productores')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-22', N'Ventas')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-23', N'Radio')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-24', N'Streaming')
GO
INSERT [dbo].[Departamentos] ([DepartamentoID], [Nombre]) VALUES (N'D-25', N'Compras')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10006, N'Mauricio', N'Prinzo', N'mprinzo', N'mprinzo', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10007, N'Azucena', N'Barcelo', N'abarcelo', N'abarcelo', N'D-10', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10008, N'Maria', N'Balzarini', N'mbalzarini', N'mbalzarini', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10009, N'Edgar', N'Caballero', N'ecaballero', N'ecaballero', N'D-04', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10011, N'Mario', N'Sagredo', N'msagredo', N'msagredo', N'D-12', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10015, N'German', N'Fernandez', N'gfernandez', N'gfernandez', N'D-06', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10016, N'Laura', N'Ballatore', N'lballatore', N'lballatore', N'D-15', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10017, N'Alfredo', N'Franco', N'afranco', N'afranco', N'D-22', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10018, N'Hugo', N'Fernandez', N'hfernandez', N'hfernandez', N'D-12', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10023, N'Rene', N'Salas', N'rsalas', N'rsalas', N'D-01', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10027, N'Gustavo', N'Toconas', N'gtoconas', N'gtoconas', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10028, N'Liliana', N'Madrid', N'lmadrid', N'lmadrid', N'D-10', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10032, N'Sonia', N'Huanuco', N'shuanuco', N'shuanuco', N'D-21', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10040, N'Daniel', N'Echazu', N'dechazu', N'dechazu', N'D-06', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10041, N'Marcela', N'Navas', N'mnavas', N'mnavas', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10045, N'Juan', N'Fernandez', N'jfernandez', N'jfernandez', N'D-09', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10046, N'Patricia', N'Genovese', N'pgenovese', N'pgenovese', N'D-03', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10054, N'Sergio', N'Velazquez', N'svelazquez', N'svelazquez', N'D-09', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10058, N'Carlos', N'Catacata', N'ccatacata', N'ccatacata', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10062, N'Dionicio', N'Alvarez', N'dalvarez', N'dalvarez', N'D-19', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10064, N'Maria', N'Mariscal', N'mmariscal', N'mmariscal', N'D-21', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10066, N'Elizabeth', N'Alfaro', N'ealfaro', N'ealfaro', N'D-15', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10068, N'Maria', N'Montero', N'mmontero', N'mmontero', N'D-17', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10075, N'Jacqueline', N'Mendez', N'jmendez', N'jmendez', N'D-08', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10079, N'Mariana', N'Mamani', N'mmamani', N'mmamani', N'D-10', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10086, N'Augusto', N'Scheurer', N'ascheurer', N'ascheurer', N'D-10', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10087, N'Claudio', N'Igarzabal', N'cigarzabal', N'cigarzabal', N'D-20', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10091, N'Diego', N'Reimundin', N'dreimundin', N'dreimundin', N'D-19', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10092, N'Roberto', N'Amador', N'ramador', N'ramador', N'D-03', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10095, N'Lidia', N'Sueldo', N'lsueldo', N'lsueldo', N'D-07', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10099, N'Rosana', N'Herrera', N'rherrera', N'rherrera', N'D-12', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10100, N'Jorge', N'Albarracin', N'jalbarracin', N'jalbarracin', N'D-04', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10101, N'Dante', N'Dominguez', N'ddominguez', N'ddominguez', N'D-07', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10102, N'Dario', N'Bonutto', N'dbonutto', N'dbonutto', N'D-13', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10108, N'Franco', N'Girotti', N'fgirotti', N'fgirotti', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10109, N'Fernando', N'Chavez', N'fchavez', N'fchavez', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10110, N'Manuel', N'Caballero', N'mcaballero', N'mcaballero', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10113, N'Maria', N'Cid', N'mcid', N'mcid', N'D-04', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10115, N'Carmen', N'Amador', N'camador', N'camador', N'D-04', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10118, N'Ignacio', N'Igarzabal', N'iigarzabal', N'iigarzabal', N'D-20', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10121, N'Edith', N'Cruz', N'ecruz', N'ecruz', N'D-13', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10124, N'Luis', N'Herrera', N'lherrera', N'lherrera', N'D-24', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10125, N'Rodrigo', N'Alvarez', N'ralvarez', N'ralvarez', N'D-06', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10127, N'Carlos', N'Ferraro', N'cferraro', N'cferraro', N'D-14', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10128, N'Francisco', N'Palacios', N'fpalacios', N'fpalacios', N'D-21', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10129, N'Pablo', N'Claros', N'pclaros', N'pclaros', N'D-12', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10130, N'Ana', N'Aramayo', N'aaramayo', N'aaramayo', N'D-18', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10134, N'Napoleon', N'Diaz', N'ndiaz', N'ndiaz', N'D-03', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10135, N'Luis', N'Manzara', N'lmanzara', N'lmanzara', N'D-14', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10136, N'Gerardo', N'Tordoya', N'gtordoya', N'gtordoya', N'D-08', N'R-01')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10138, N'Carolina', N'Alderete', N'calderete', N'calderete', N'D-01', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10139, N'Alfredo', N'Mamani', N'amamani', N'amamani', N'D-02', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10140, N'María', N'Garzon', N'mgarzon', N'mgarzon', N'D-03', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10143, N'Valeria', N'Alfaro', N'valfaro', N'valfaro', N'D-04', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10144, N'Sebastian', N'Castro', N'scastro', N'scastro', N'D-05', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10145, N'Sergio', N'Mendez', N'smendez', N'smendez', N'D-06', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10146, N'Anahí', N'Fadell', N'afadell', N'afadell', N'D-07', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10148, N'Pamela', N'Tolaba', N'ptolaba', N'ptolaba', N'D-08', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10149, N'Patricia', N'Subiaurre', N'psubiaurre', N'psubiaurre', N'D-09', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10152, N'Norma', N'Batallanos', N'nbatallanos', N'nbatallanos', N'D-10', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10153, N'Silvia', N'Asurduy', N'sasurduy', N'sasurduy', N'D-11', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10155, N'Gustavo', N'Vedia', N'gvedia', N'gvedia', N'D-12', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10157, N'Luis', N'Sanchez', N'lsanchez', N'lsanchez', N'D-13', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10158, N'Enrique', N'Calisaya', N'ecalisaya', N'ecalisaya', N'D-14', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10159, N'Alvaro', N'Tejeda', N'atejeda', N'atejeda', N'D-15', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10161, N'Silvana', N'Copas', N'scopas', N'scopas', N'D-16', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10162, N'Miguel', N'Salazar', N'msalazar', N'msalazar', N'D-17', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10163, N'Cecilia', N'Reque', N'creque', N'creque', N'D-18', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10165, N'Francisco', N'Corbacho', N'fcorbacho', N'fcorbacho', N'D-19', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10173, N'Abigail', N'Teran', N'ateran', N'ateran', N'D-20', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10174, N'Diego', N'Suarez', N'dsuarez', N'dsuarez', N'D-21', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10175, N'Julio', N'Richa', N'jricha', N'jricha', N'D-22', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10176, N'Marcelo', N'Betinotti', N'mbetinotti', N'mbetinotti', N'D-23', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10177, N'Julio', N'Achaval', N'jachaval', N'jachaval', N'D-24', N'R-03')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10178, N'Carlos', N'Franco', N'cfranco', N'cfranco', N'D-21', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10179, N'Ricardo', N'Balceda', N'rbalceda', N'rbalceda', N'D-24', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10181, N'Jorge', N'Mir', N'jmir', N'jmir', N'D-17', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10182, N'Victor', N'Azize', N'vazize', N'vazize', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10183, N'Valeria', N'Gaya', N'vgaya', N'vgaya', N'D-24', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10184, N'Miguel', N'Montenegro', N'mmontenegro', N'mmontenegro', N'D-21', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10186, N'Mayra', N'Cardozo', N'mcardozo', N'mcardozo', N'D-04', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10187, N'Silvia', N'Herrera', N'sherrera', N'sherrera', N'D-19', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10188, N'Luis', N'Lamas', N'llamas', N'llamas', N'D-02', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10189, N'Maria', N'Haquim', N'mhaquim', N'mhaquim', N'D-20', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10190, N'Silvio', N'Guanuco', N'sguanuco', N'sguanuco', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10191, N'Nestor', N'Paredes', N'nparedes', N'nparedes', N'D-11', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10192, N'Luis', N'Tolaba', N'ltolaba', N'ltolaba', N'D-04', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10193, N'Maria', N'Halle', N'mhalle', N'mhalle', N'D-18', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10194, N'Juan', N'Saenz', N'jsaenz', N'jsaenz', N'D-15', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10195, N'Maria', N'Galian', N'mgalian', N'mgalian', N'D-24', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10197, N'Oscar', N'Aisama', N'oaisama', N'oaisama', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10198, N'Carolina', N'Segovia', N'csegovia', N'csegovia', N'D-12', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10199, N'Juliana', N'Juarez', N'jjuarez', N'jjuarez', N'D-07', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10200, N'Carmen', N'Quispe', N'cquispe', N'cquispe', N'D-15', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10201, N'Silvia', N'Quispe', N'squispe', N'squispe', N'D-10', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10202, N'Cesar', N'Martinez', N'cmartinez', N'cmartinez', N'D-01', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10203, N'Maria', N'Alvarez', N'malvarez', N'malvarez', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10204, N'Jorge', N'Ale', N'jale', N'jale', N'D-24', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10205, N'Ricardo', N'Tezanos', N'rtezanos', N'rtezanos', N'D-20', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10206, N'Sandra', N'Torrico', N'storrico', N'storrico', N'D-13', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10207, N'Daiana', N'Tejerina', N'dtejerina', N'dtejerina', N'D-05', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10208, N'Laura', N'Perea', N'lperea', N'lperea', N'D-10', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10209, N'Fabian', N'Alvarez', N'falvarez', N'falvarez', N'D-05', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10210, N'Enrique', N'Alzogaray', N'ealzogaray', N'ealzogaray', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10211, N'Blanca', N'Marconiz', N'bmarconiz', N'bmarconiz', N'D-09', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10212, N'Erica', N'Cari', N'ecari', N'ecari', N'D-18', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10213, N'Paula', N'Alanoca', N'palanoca', N'palanoca', N'D-10', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10214, N'Cristian', N'Aisama', N'caisama', N'caisama', N'D-09', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10215, N'Cecilia', N'Bianco', N'cbianco', N'cbianco', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10216, N'Virginia', N'Quinteros', N'vquinteros', N'vquinteros', N'D-08', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10217, N'Oscar', N'Dominguez', N'odominguez', N'odominguez', N'D-03', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10218, N'Ivana', N'Juarez', N'ijuarez', N'ijuarez', N'D-18', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10219, N'Alfredo', N'Severich', N'aseverich', N'aseverich', N'D-19', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10220, N'Paola', N'Krogulec', N'pkrogulec', N'pkrogulec', N'D-18', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10221, N'Hugo', N'Krasnobroda', N'hkrasnobroda', N'hkrasnobroda', N'D-22', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10222, N'Andrea', N'Aparicio', N'aaparicio', N'aaparicio', N'D-25', N'R-04')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10223, N'Luis', N'Caraballo', N'lcaraballo', N'lcaraballo', N'D-11', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10224, N'Eduardo', N'Ochoa', N'eochoa', N'eochoa', N'D-19', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10225, N'Lucas', N'Delgado', N'ldelgado', N'ldelgado', N'D-04', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10226, N'Amelia', N'Gutierrez', N'agutierrez', N'agutierrez', N'D-15', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10227, N'Mauro', N'Rodriguez', N'mrodriguez', N'mrodriguez', N'D-11', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10228, N'Gustavo', N'Cajal', N'gcajal', N'gcajal', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10229, N'Silvana', N'Franco', N'sfranco', N'sfranco', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10230, N'Maria', N'Duran', N'mduran', N'mduran', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10231, N'Guillermo', N'Saavedra', N'gsaavedra', N'gsaavedra', N'D-14', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10232, N'Carlos', N'Ramirez', N'cramirez', N'cramirez', N'D-16', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10233, N'Juan', N'Rojas', N'jrojas', N'jrojas', N'D-14', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (10234, N'Natalia', N'Taborda', N'ntaborda', N'ntaborda', N'D-20', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (11036, N'Ruben', N'Rivarola', N'rrivarola', N'rrivarola', N'D-23', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (11092, N'Ricardo', N'Dubin', N'rdubin', N'rdubin', N'D-03', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (13054, N'Nora', N'Ruiz', N'nruiz', N'nruiz', N'D-24', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (25825, N'Diego', N'Salas', N'dsalas', N'dsalas', N'D-06', N'R-02')
GO
INSERT [dbo].[Empleados] ([Legajo], [Nombre], [Apellido], [Usuario], [Contraseña], [DepartamentoID], [RolID]) VALUES (25826, N'Rodolfo', N'Tordoya', N'rtordoya', N'rtordoya', N'D-11', N'R-02')
GO
SET IDENTITY_INSERT [dbo].[Items] ON 
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (1, N'C-01', N'Archivadores de cartón', N'Archivadores de cartón', CAST(181.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (2, N'C-01', N'Archivadores de plástico', N'Archivadores de plástico', CAST(157.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (3, N'C-01', N'Archivadores ecológicos', N'Archivadores ecológicos', CAST(170.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (4, N'C-01', N'Cajetines para archivadores', N'Cajetines para archivadores', CAST(105.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (5, N'C-01', N'Complementos para archivadores', N'Complementos para archivadores', CAST(103.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (6, N'C-01', N'Separadores de pestañas', N'Separadores de pestañas', CAST(156.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (7, N'C-01', N'Carpetas de cartón marrón de dos anillas', N'Carpetas de cartón marrón de dos anillas', CAST(150.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (8, N'C-01', N'Carpetas de cartón marrón cuero de cuatro anillas', N'Carpetas de cartón marrón cuero de cuatro anillas', CAST(113.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (9, N'C-01', N'Carpetas de colores Exacompta con 2 anillas', N'Carpetas de colores Exacompta con 2 anillas', CAST(143.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (10, N'C-01', N'Carpetas Exacompta polipropileno 4 anillas', N'Carpetas Exacompta polipropileno 4 anillas', CAST(133.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (11, N'C-01', N'Carpeta de 4 anillas redondas de 25 mm en tamaño cuarto de colores surtidos', N'Carpeta de 4 anillas redondas de 25 mm en tamaño cuarto de colores surtidos', CAST(146.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (12, N'C-01', N'Carpetas de dos anillas formato Din A4', N'Carpetas de dos anillas formato Din A4', CAST(165.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (13, N'C-01', N'Carpetas folio 2 anillas con lomo liso', N'Carpetas folio 2 anillas con lomo liso', CAST(94.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (14, N'C-01', N'Carpetas folio 2 anillas con lomo liso', N'Carpetas folio 2 anillas con lomo liso', CAST(175.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (15, N'C-01', N'Carpetas con 2 anillas pequeñas de 15 mm', N'Carpetas con 2 anillas pequeñas de 15 mm', CAST(180.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (16, N'C-01', N'Carpetas de dos anillas folio con ollao y compresor', N'Carpetas de dos anillas folio con ollao y compresor', CAST(179.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (17, N'C-01', N'Carpetas de cuatro anillas formato Folio', N'Carpetas de cuatro anillas formato Folio', CAST(171.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (18, N'C-01', N'Carpeta de dos anillas mixtas de 25 mm Din A4 transparente', N'Carpeta de dos anillas mixtas de 25 mm Din A4 transparente', CAST(100.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (19, N'C-01', N'Carpetas con tarjetero de 4 anillas', N'Carpetas con tarjetero de 4 anillas', CAST(151.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (20, N'C-01', N'Carpetas A4 PVC, cuatro anillas mixtas', N'Carpetas A4 PVC, cuatro anillas mixtas', CAST(92.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (21, N'C-01', N'Carpeta roja A4 de dos anillas de 25 mm con bolsa, tarjetero y ribete negro', N'Carpeta roja A4 de dos anillas de 25 mm con bolsa, tarjetero y ribete negro', CAST(114.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (22, N'C-01', N'Carpetas A5, dos o cuatro anillas', N'Carpetas A5, dos o cuatro anillas', CAST(111.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (23, N'C-01', N'Carpetas Folio, cuatro anillas redondas', N'Carpetas Folio, cuatro anillas redondas', CAST(134.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (24, N'C-01', N'Carpeta para papel continuo Elba de 10 pulgadas (250 mm)', N'Carpeta para papel continuo Elba de 10 pulgadas (250 mm)', CAST(131.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (25, N'C-01', N'Carpetas con fundas de plástico fijas o móviles', N'Carpetas con fundas de plástico fijas o móviles', CAST(150.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (26, N'C-01', N'Carpetas de proyectos', N'Carpetas de proyectos', CAST(117.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (27, N'C-01', N'Carpetas colgantes', N'Carpetas colgantes', CAST(169.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (28, N'C-01', N'Sobres de plástico con cierre de cremallera, velcro o broche', N'Sobres de plástico con cierre de cremallera, velcro o broche', CAST(175.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (29, N'C-01', N'Maletines clasificadores portadocumentos', N'Maletines clasificadores portadocumentos', CAST(91.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (30, N'C-02', N'Milan 445, goma de borrar blanda', N'Tipo miga de pan', CAST(13.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (31, N'C-02', N'Milan 430, goma de borrar suave, miga de pan', N'Muy blanda. Verde, blanca o rosa', CAST(12.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (32, N'C-02', N'Milan Nata 624, goma de borrar compacta', N'Con celofán protector de color rosa', CAST(21.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (33, N'C-02', N'Milan 420, goma de borrar', N'Milan 420, goma de borrar', CAST(21.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (34, N'C-02', N'Gomas de borrar escolares para lápiz', N'Gomas de borrar escolares para lápiz', CAST(21.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (35, N'C-02', N'Goma para borrar lápiz Liderpapel 40x20x12 mm', N'Goma para borrar lápiz Liderpapel 40x20x12 mm', CAST(12.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (36, N'C-02', N'Faber-Castell, goma de borrar sin PVC', N'Faber-Castell, goma de borrar sin PVC', CAST(17.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (37, N'C-02', N'Milan Nata 612, goma de borrar con bisel', N'Milan Nata 612, goma de borrar con bisel', CAST(11.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (38, N'C-02', N'Staedtler Noris 526 B30, goma de borrar rasoplast', N'Staedtler Noris 526 B30, goma de borrar rasoplast', CAST(9.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (39, N'C-02', N'Staedtler Rasoplast, borrador compacto para dibujo', N'La versión dura de Mars Plastic', CAST(25.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (40, N'C-02', N'Staedtler Mars Plastic 526 50, goma de borrar técnica', N'Para uso escolar y dibujo técnico', CAST(20.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (41, N'C-02', N'Faber-Castell Perfection 7058, lápiz borrador', N'Para borrar tinta china. Con pincel integrado', CAST(13.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (42, N'C-02', N'Goma Maped Duo para grafito y bolígrafo borrable', N'Goma Maped Duo para grafito y bolígrafo borrable', CAST(18.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (43, N'C-02', N'Milan 403, goma de borrar gigante', N'Milan 403, goma de borrar gigante', CAST(16.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (44, N'C-02', N'Portagomas Staedtler Mars plastic', N'Portagomas retráctil para dibujo técnico', CAST(14.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (45, N'C-02', N'Portagomas Tombow para goma rectangular 2.5 × 5 mm', N'Portagomas Tombow para goma rectangular 2.5 × 5 mm', CAST(9.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (46, N'C-02', N'Portagomas Tombow para goma cilíndrica de 2.3 mm', N'Portagomas Tombow para goma cilíndrica de 2.3 mm', CAST(24.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (47, N'C-02', N'Recambio portagomas Staedtler Mars', N'Bolsa de 10 gomas de repuesto', CAST(19.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (48, N'C-02', N'Maped, caja 18 gomas de borrar para carboncillo', N'Maped, caja 18 gomas de borrar para carboncillo', CAST(9.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (49, N'C-03', N'Correctores', N'Correctores', CAST(80.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (50, N'C-03', N'Gomas de borrar', N'Gomas de borrar', CAST(76.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (51, N'C-04', N'Tijeras de oficina', N'Tijeras de oficina', CAST(876.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (52, N'C-04', N'Cúter y bisturí de precisión', N'Cúter y bisturí de precisión', CAST(328.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (53, N'C-04', N'Guillotinas para cortar fotos, papel y cartulina', N'Guillotinas para cortar fotos, papel y cartulina', CAST(732.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (54, N'C-04', N'Cizallas de papel', N'Cizallas de papel', CAST(450.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (55, N'C-05', N'Corte en tiras 6 mm. Seguridad P1', N'Corte en tiras 6 mm. Seguridad P1', CAST(1694.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (56, N'C-05', N'Rexel Alpha, destructora 5 h., 10 l', N'Para uso personal. 5 hojas. 10 litros', CAST(1728.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (57, N'C-05', N'Q6CC2, destructora corte en partículas', N'Destructora personal 6 hojas / 11 litros', CAST(3952.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (58, N'C-05', N'Fellowes 36C, destructora de papel', N'Ciclo de trabajo de 2 minutos', CAST(3573.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (59, N'C-05', N'HSM Shredstar x5, destructora compacta, 18 l', N'Silenciosa, ideal para el hogar y pequeñas oficinas', CAST(2473.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (60, N'C-05', N'KF17972, destructora 8 h. y 15 l', N'Destructora económica para uso personal', CAST(1495.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (61, N'C-05', N'Rexel Prostyle+5, destructora 5 h. y 7.5 l', N'Tritura hasta 5 folios. Papelera de 7.5 litros', CAST(1518.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (62, N'C-05', N'KF17974, destructora hasta 10 h.', N'Papelera con ventana de nivel', CAST(3092.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (63, N'C-05', N'Rexel Duo, destructora grafito 10 h.', N'Trituradora silenciosa perfecta para casa', CAST(2189.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (64, N'C-05', N'HSM Shredstar x10, trituradora de 20 l', N'Destruye hasta 10 hojas. 20 litros de capacidad', CAST(2133.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (65, N'C-05', N'HSM Shredstar x8, destructora 8 h.', N'8 hojas, partículas 4.5x30 mm, 18 litros', CAST(2090.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (66, N'C-05', N'Fellowes 53C, destructora de papel 10 h.', N'La trituradora ideal para particulares', CAST(1609.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (67, N'C-05', N'Destructora Q-Connect KF15551, 12 hojas', N'Con ranura independiente para CD', CAST(1585.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (68, N'C-05', N'Trituradora de papel KF15547 hasta 8h', N'Trituradora de papel KF15547 hasta 8h', CAST(3899.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (69, N'C-05', N'Destructora Rexel Prostyle+ 12', N'Destrucción simultánea de 12 hojas', CAST(3906.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (70, N'C-05', N'Destructora antiatascos de 12 h', N'Papelera de 14 litros, con ruedas', CAST(2822.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (71, N'C-05', N'HSM Shredstar x13, trituradora 13 h.', N'Hasta 13 hojas y 23 litros de papelera. Din P-4', CAST(3654.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (72, N'C-05', N'HSM Shredstar X15, destructora 15 h.', N'Alto rendimiento. 15 hojas. Partícula 4x37 mm', CAST(3648.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (73, N'C-05', N'Fellowes PS-79CI, destructora 14 h.', N'Fellowes PS-79CI, destructora 14 h.', CAST(2112.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (74, N'C-05', N'Fellowes 92CS, destructora 18 h.', N'18 Hojas. Partículas de 4x38 mm', CAST(2401.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (75, N'C-05', N'Destructora potente para uso intensivo, hasta 20 h, 26 litros', N'Destructora potente para uso intensivo, hasta 20 h, 26 litros', CAST(2248.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (76, N'C-05', N'Fellowes 99ci', N'Con tecnología antiatascos 100% efectiva', CAST(2482.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (77, N'C-05', N'Fellowes 1050HS, destructora alta seguridad, 4 h.', N'Destruye un A4 en 15.000 micropartículas', CAST(2313.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (78, N'C-05', N'Fellowes 3250mc', N'Fellowes 3250mc', CAST(2345.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (79, N'C-05', N'Fellowes 425ci', N'Fellowes 425ci', CAST(4525.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (80, N'C-05', N'Aceite lubricante para destructoras 350 ml', N'Para el mantenimiento de las cuchillas de corte', CAST(3206.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (81, N'C-05', N'Hojas lubricantes para destructoras', N'Hojas lubricantes para destructoras', CAST(3123.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (82, N'C-05', N'50 Bolsas para destructoras 94 litros', N'Para destructoras Fellowes', CAST(4530.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (83, N'C-06', N'Encuadernadora multifunción Fellowes Lyra', N'Grapa, perfora y encuaderna', CAST(1701.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (84, N'C-06', N'Alicate para encuadernar con espiral', N'Para cortar y doblar el extremo de la espiral', CAST(1263.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (85, N'C-06', N'Fellowes Star+ 150', N'Encuaderna hasta 150 hojas con canutillo plástico', CAST(1771.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (86, N'C-06', N'Fellowes Metal 25 — Encuadernadora espiral', N'Fellowes Metal 25 — Encuadernadora espiral', CAST(1093.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (87, N'C-06', N'Encuadernadora espiral Q-Connect 450 hojas', N'Capacidad perforación de 10 hojas', CAST(1677.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (88, N'C-06', N'Fellowes Metal 50, encuadernadora espiral metálica', N'Regulación margen. 12 hojas. Cuadernos hasta 450h', CAST(1213.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (89, N'C-06', N'Fellowes Pulsar+ 300, encuadernadora de canutillo', N'Encuaderna hasta 300 hojas A4 de 80 gr.', CAST(1764.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (90, N'C-06', N'Yosan, Encuadernadora de espiral, 450 hojas', N'Máquina de encuadernar de alta capacidad', CAST(999.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (91, N'C-06', N'Fellowes metal 50R — Encuadernadora espiral con insertador', N'Fellowes metal 50R — Encuadernadora espiral con insertador', CAST(947.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (92, N'C-06', N'Encuadernadora Wire Fellowes Quasar', N'Para canutillos Wire y 130 hojas A4', CAST(1081.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (93, N'C-06', N'GBC C200E, encuadernadora eléctrica', N'GBC C200E, encuadernadora eléctrica', CAST(1060.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (94, N'C-06', N'Fellowes Metal 100 para espiral metálica', N'Perfora hasta 20 hojas y encuaderna 450', CAST(1419.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (95, N'C-06', N'GBC Coilbind P59 — Encuadernadora de espiral', N'GBC Coilbind P59 — Encuadernadora de espiral', CAST(952.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (96, N'C-06', N'Leitz Impressbind 280, encuadernadora de presión', N'Encuadernadora presión channel', CAST(1359.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (97, N'C-06', N'Yosan P164, encuadernadora eléctrica', N'Con pedal. Alto rendimiento. Manos libres', CAST(1196.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (98, N'C-06', N'Fellowes E200R, encuadernadora eléctrica', N'Máquina de encuadernar con pedal automático', CAST(1495.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (99, N'C-07', N'Plumas estilográficas', N'Plumas estilográficas', CAST(23.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (100, N'C-07', N'Bolígrafos baratos', N'Bolígrafos baratos', CAST(44.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (101, N'C-07', N'Bolígrafos Bic', N'Bolígrafos Bic', CAST(32.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (102, N'C-07', N'Bolígrafos borrables', N'Bolígrafos borrables', CAST(12.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (103, N'C-07', N'Bolígrafos con base', N'Bolígrafos con base', CAST(39.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (104, N'C-07', N'Bolígrafos Paper Mate', N'Bolígrafos Paper Mate', CAST(27.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (105, N'C-07', N'Bolígrafos Pentel', N'Bolígrafos Pentel', CAST(16.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (106, N'C-07', N'Bolígrafos Pilot', N'Bolígrafos Pilot', CAST(30.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (107, N'C-07', N'Bolígrafos Stabilo', N'Bolígrafos Stabilo', CAST(42.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (108, N'C-07', N'Bolígrafos uni-ball', N'Bolígrafos uni-ball', CAST(30.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (109, N'C-07', N'Recambios para bolígrafos', N'Recambios para bolígrafos', CAST(33.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (110, N'C-07', N'Bolígrafo BIC Cristal', N'Bolígrafo BIC Cristal', CAST(24.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (111, N'C-07', N'Marcadores fluorescentes', N'Marcadores fluorescentes', CAST(44.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (112, N'C-07', N'Rotuladores calibrados', N'Rotuladores calibrados', CAST(10.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (113, N'C-07', N'Rotuladores de billetes', N'Rotuladores de billetes', CAST(35.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (114, N'C-07', N'Rotuladores Edding', N'Rotuladores Edding', CAST(41.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (115, N'C-07', N'Rotuladores especiales', N'Rotuladores especiales', CAST(28.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (116, N'C-07', N'Rotuladores flipchart', N'Rotuladores flipchart', CAST(14.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (117, N'C-07', N'Rotuladores para pizarras', N'Rotuladores para pizarras', CAST(35.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (118, N'C-07', N'Rotuladores permanentes', N'Rotuladores permanentes', CAST(13.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (119, N'C-07', N'Rotuladores pizarra vidrio', N'Rotuladores pizarra vidrio', CAST(44.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (120, N'C-07', N'Rotuladores punta dura', N'Rotuladores punta dura', CAST(22.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (121, N'C-07', N'Rotuladores Q-Connect', N'Rotuladores Q-Connect', CAST(36.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (122, N'C-07', N'Rotuladores Stabilo', N'Rotuladores Stabilo', CAST(40.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (123, N'C-07', N'Rotuladores Staedtler', N'Rotuladores Staedtler', CAST(26.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (124, N'C-07', N'Marcadores fluorescentes', N'Marcadores fluorescentes', CAST(42.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (125, N'C-07', N'Lápices de grafito', N'Lápices de grafito', CAST(24.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (126, N'C-08', N'Pizarras blancas', N'Pizarras blancas', CAST(2009.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (127, N'C-08', N'Pizarras para tiza', N'Pizarras para tiza', CAST(1865.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (128, N'C-08', N'Rotuladores borrables en seco para pizarras', N'Rotuladores borrables en seco para pizarras', CAST(1212.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (129, N'C-09', N'Clavadoras', N'Clavadoras', CAST(537.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (130, N'C-09', N'Grapadoras de bolsillo', N'Grapadoras de bolsillo', CAST(460.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (131, N'C-09', N'Grapadoras de brazo largo', N'Grapadoras de brazo largo', CAST(557.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (132, N'C-09', N'Grapadoras de escritorio', N'Grapadoras de escritorio', CAST(590.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (133, N'C-09', N'Grapadoras de gruesos', N'Grapadoras de gruesos', CAST(237.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (134, N'C-09', N'Grapadoras de tenaza', N'Grapadoras de tenaza', CAST(601.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (135, N'C-09', N'Grapadoras El Casco', N'Grapadoras El Casco', CAST(190.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (136, N'C-09', N'Grapadoras eléctricas', N'Grapadoras eléctricas', CAST(439.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (137, N'C-09', N'Grapadoras de bolsillo', N'Grapadoras de bolsillo', CAST(352.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (138, N'C-10', N'Impresora térmica Safescan TP-230', N'Competente impresora térmica de alta velocidad (60 mm/s) conectable a las contadoras de dinero Safescan para imprimir completos reportes que detallan la suma total de dinero contado y un balance individual de cada denominación.', CAST(1683.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (139, N'C-11', N'Pizarras y tableros de anuncios de corcho', N'Pizarras y tableros de anuncios de corcho', CAST(13.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (140, N'C-11', N'Chinchetas cortas de latón o acero', N'Chinchetas cortas de latón o acero', CAST(13.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (141, N'C-11', N'Agujas de señalización para mapas y planos', N'Agujas de señalización para mapas y planos', CAST(31.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (142, N'C-12', N'Perforadora de papel para 10 hojas', N'La más barata', CAST(1503.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (143, N'C-12', N'Perforador de papel barato 20 hojas', N'Colores: azul, rojo o negro', CAST(1385.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (144, N'C-12', N'Taladro con regleta deslizante para 27 hojas', N'Perforadora negra con abertura de 2.7 mm', CAST(298.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (145, N'C-12', N'Perforadora con base y empuñadura antideslizantes', N'Taladra 20 o 30 hojas (según modelo)', CAST(1320.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (146, N'C-12', N'Taladradora Petrus 52 Retro', N'Para dar un toque vintage a la oficina', CAST(1471.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (147, N'C-12', N'Taladrado de papel Petrus 52', N'La Petrus 52 en su versión clásica', CAST(591.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (148, N'C-12', N'Perforadora metalizada Petrus 52 WoW', N'El taladro original de Petrus, metalizado', CAST(407.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (149, N'C-12', N'Perforadora de papel Maped Essentials Metal E4001', N'Una de las 4-taladros más baratas', CAST(543.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (150, N'C-12', N'Perforadora económica de papel de 4 taladros', N'Taladro económico de 4 agujeros', CAST(461.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (151, N'C-12', N'Taladro Maped Essentials para 45 hojas', N'Con base antideslizante', CAST(1657.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (152, N'C-12', N'Petrus 62 Wow en cuatro colores metalizados', N'Grapa 10 hojas más que la Petrus 52', CAST(359.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (153, N'C-12', N'Taladradora de papel Petrus 65', N'La versión actual de la mítica Petrus', CAST(795.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (154, N'C-12', N'Taladradora Petrus 95 Negro', N'Punzones ultrafilados, para 40 hojas', CAST(1050.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (155, N'C-12', N'Perforadora de papel Maped Easy 65 h', N'Ergonómica, perfora sin apenas esfuerzo', CAST(667.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (156, N'C-12', N'Taladradora de oficina Q-Connect KF01237', N'Perfora hasta 65 hojas', CAST(1513.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (157, N'C-12', N'Taladro Novus B270 para 70 h', N'Taladro profesional de oficina de magnesio', CAST(349.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (158, N'C-12', N'Taladradora Rapid HDC65', N'Gris y naranja. Perfora hasta 65 hojas', CAST(805.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (159, N'C-12', N'Perforadora de gran capacidad KF18766', N'Capacidad de perforación de hasta 100 hojas', CAST(105.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (160, N'C-12', N'Perforadora 4 punzones Petrus 505', N'Perforador de 4 agujeros de alta eficacia', CAST(1068.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (161, N'C-12', N'Taladradora Novus B2200 para 200 h', N'Una de las mejores en su categoría', CAST(190.09 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (162, N'C-12', N'Taladro con punzones móviles Petrus 514', N'Con distancia regulable entre sus punzones', CAST(587.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (163, N'C-12', N'Perforadora Maped Expert 150 alta capacidad', N'Perfora sin esfuerzo hasta 15 mm de grosor (~150 h)', CAST(739.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (164, N'C-13', N'Pegamento de barra', N'Pegamento de barra', CAST(118.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (165, N'C-13', N'Rollos de celo', N'Rollos de celo', CAST(97.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (166, N'C-13', N'Dispensadores de celo', N'Dispensadores de celo', CAST(194.27 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (167, N'C-14', N'Plastificadora A4 de 2 rodillos', N'Ideal para uso doméstico. Muy barata', CAST(4249.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (168, N'C-14', N'Rollo para plastificadora Foton de 125 µ', N'Rollo para plastificadora Foton de 125 µ', CAST(2683.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (169, N'C-14', N'Rollo para plastificadora Foton de 75 µ', N'Rollo para plastificadora Foton de 75 µ', CAST(4387.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (170, N'C-14', N'Plastificadora de 75-125 micras A3', N'Plastificadora muy económica para Din A3', CAST(6027.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (171, N'C-14', N'Plastificadora Fellowes Pixel A4', N'Para fundas de 80 y 125 micras', CAST(3258.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (172, N'C-14', N'Plastificadora frío y caliente de 4 rodillos', N'Plastificadora frío y caliente de 4 rodillos', CAST(6620.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (173, N'C-14', N'Plastificadora A3 Fellowes Pixel', N'Tiempo de calentamiento 3 minutos', CAST(1741.45 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (174, N'C-14', N'GBC Fusion 3000L A3', N'Para documentos de hasta 297x420 mm', CAST(5997.64 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (175, N'C-14', N'Plastificadora Fellowes Neptune A3', N'Plastificadora Fellowes Neptune A3', CAST(959.73 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (176, N'C-14', N'Plastificadora Fellowes Venus 2 A3', N'Plastificadora Fellowes Venus 2 A3', CAST(5086.91 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (177, N'C-14', N'Plastificadora automática GBC Foton 30', N'Plastificadora automática GBC Foton 30', CAST(3738.00 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (178, N'C-15', N'Plegadora de papel eléctrica Martin Yale 7200', N'Plegadora de papel para formatos A4 y A5.', CAST(6400.82 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (179, N'C-16', N'Marcapáginas adhesivos', N'Marcapáginas adhesivos', CAST(37.36 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (180, N'C-16', N'Notas adhesivas baratas', N'Notas adhesivas baratas', CAST(44.18 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (181, N'C-16', N'Notas Post-It', N'Notas Post-It', CAST(19.55 AS Decimal(9, 2)), N'P-01')
GO
INSERT [dbo].[Items] ([ItemID], [CategoriaID], [Nombre], [Descripcion], [PrecioUnitario], [ProveedorID]) VALUES (183, N'C-16', N'TEST', N'Prueba', CAST(0.09 AS Decimal(9, 2)), N'P-01')
GO
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Ordenes] ON 
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (1, 10018, CAST(N'2022-07-01' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (2, 10230, CAST(N'2022-01-25' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (3, 10203, CAST(N'2020-12-07' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (4, 10134, CAST(N'2021-03-10' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (5, 11036, CAST(N'2021-08-05' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (6, 10121, CAST(N'2022-05-15' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (7, 10124, CAST(N'2021-05-18' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (8, 10173, CAST(N'2020-07-21' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (9, 10211, CAST(N'2021-02-21' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (10, 10128, CAST(N'2021-03-23' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (11, 10233, CAST(N'2021-06-05' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (12, 10066, CAST(N'2020-07-04' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (13, 10095, CAST(N'2020-02-15' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (14, 10230, CAST(N'2020-07-28' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (15, 10203, CAST(N'2020-03-26' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (16, 10146, CAST(N'2020-01-02' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (17, 10177, CAST(N'2021-01-04' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (18, 10173, CAST(N'2020-04-13' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (19, 10155, CAST(N'2021-12-25' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (20, 11092, CAST(N'2021-07-03' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (21, 10009, CAST(N'2021-07-15' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (22, 10134, CAST(N'2020-11-26' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (23, 10208, CAST(N'2021-06-07' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (24, 10153, CAST(N'2020-10-01' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (25, 10095, CAST(N'2021-09-22' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (26, 10101, CAST(N'2021-07-22' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (27, 10175, CAST(N'2020-03-18' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (28, 10205, CAST(N'2020-11-02' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (29, 10008, CAST(N'2020-06-26' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (30, 10124, CAST(N'2022-01-13' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (31, 10223, CAST(N'2021-07-04' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (32, 10079, CAST(N'2021-10-17' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (33, 10181, CAST(N'2020-09-22' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (34, 10209, CAST(N'2020-02-11' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (35, 10139, CAST(N'2021-03-19' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (36, 10146, CAST(N'2021-07-18' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (37, 10212, CAST(N'2021-08-02' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (38, 10210, CAST(N'2020-08-21' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (39, 10197, CAST(N'2020-02-26' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (40, 10032, CAST(N'2022-03-19' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (41, 10223, CAST(N'2021-05-09' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (42, 10041, CAST(N'2020-08-29' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (43, 10018, CAST(N'2021-11-16' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (44, 10232, CAST(N'2020-05-22' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (45, 10008, CAST(N'2022-01-08' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (46, 10207, CAST(N'2021-08-01' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (47, 10162, CAST(N'2020-09-09' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (48, 10145, CAST(N'2020-10-02' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (49, 13054, CAST(N'2021-12-05' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (50, 10205, CAST(N'2021-04-08' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (51, 10152, CAST(N'2021-03-07' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (52, 10153, CAST(N'2020-03-09' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (53, 10095, CAST(N'2020-09-27' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (54, 10138, CAST(N'2021-08-22' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (55, 10068, CAST(N'2020-08-04' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (56, 10016, CAST(N'2021-08-12' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (57, 10204, CAST(N'2021-03-07' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (58, 10201, CAST(N'2021-10-05' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (59, 10222, CAST(N'2021-06-12' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (60, 10174, CAST(N'2020-07-17' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (61, 10199, CAST(N'2020-12-30' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (62, 10110, CAST(N'2022-01-19' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (63, 10197, CAST(N'2021-11-23' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (64, 10087, CAST(N'2021-06-29' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (65, 10109, CAST(N'2020-07-03' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (66, 10186, CAST(N'2022-05-27' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (67, 10203, CAST(N'2020-08-03' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (68, 10198, CAST(N'2021-08-31' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (69, 10079, CAST(N'2020-03-11' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (70, 10231, CAST(N'2022-03-06' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (71, 10054, CAST(N'2022-06-18' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (72, 10174, CAST(N'2020-05-10' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (73, 10027, CAST(N'2021-08-17' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (74, 10153, CAST(N'2022-05-29' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (75, 10009, CAST(N'2020-11-09' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (76, 10143, CAST(N'2021-07-14' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (77, 10128, CAST(N'2020-01-20' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (78, 10233, CAST(N'2022-01-21' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (79, 10217, CAST(N'2022-06-14' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (80, 10201, CAST(N'2021-11-07' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (81, 10187, CAST(N'2020-10-18' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (82, 10153, CAST(N'2020-06-03' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (83, 10115, CAST(N'2020-06-02' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (84, 10209, CAST(N'2021-03-15' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (85, 10066, CAST(N'2021-05-25' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (86, 10205, CAST(N'2021-05-18' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (87, 10183, CAST(N'2021-12-07' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (88, 10233, CAST(N'2022-05-23' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (89, 10079, CAST(N'2021-10-20' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (90, 10064, CAST(N'2021-10-22' AS Date), N'Aprobado  ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (91, 10140, CAST(N'2020-01-24' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (92, 10178, CAST(N'2020-09-16' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (93, 10230, CAST(N'2021-09-16' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (94, 10218, CAST(N'2020-11-25' AS Date), N'Completado')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (95, 10015, CAST(N'2020-04-11' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (96, 10229, CAST(N'2021-10-14' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (97, 10054, CAST(N'2020-07-18' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (98, 10144, CAST(N'2020-06-23' AS Date), N'Pendiente ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (99, 10028, CAST(N'2022-03-29' AS Date), N'Enviado   ')
GO
INSERT [dbo].[Ordenes] ([OrdenID], [Legajo], [Fecha], [Estado]) VALUES (100, 10032, CAST(N'2021-09-13' AS Date), N'Aprobado  ')
GO
SET IDENTITY_INSERT [dbo].[Ordenes] OFF
GO
SET IDENTITY_INSERT [dbo].[Ordenes_Items] ON 
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5002, 83, 177, CAST(90.91 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5003, 95, 81, CAST(598.27 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5004, 2, 145, CAST(880.82 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5005, 90, 101, CAST(201.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5006, 64, 25, CAST(190.64 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5007, 92, 117, CAST(174.45 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5008, 28, 137, CAST(511.64 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5009, 23, 26, CAST(238.82 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5010, 9, 147, CAST(837.64 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5011, 54, 69, CAST(93.36 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5012, 7, 166, CAST(607.18 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5013, 93, 96, CAST(524.82 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5014, 37, 127, CAST(284.00 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5015, 93, 29, CAST(783.55 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5016, 5, 25, CAST(95.64 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5017, 37, 120, CAST(307.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5018, 77, 35, CAST(663.82 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5019, 76, 166, CAST(828.18 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5020, 12, 70, CAST(197.45 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5021, 66, 59, CAST(454.73 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5022, 42, 141, CAST(529.18 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5023, 40, 13, CAST(253.18 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5024, 29, 166, CAST(209.55 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5025, 2, 151, CAST(590.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5026, 16, 116, CAST(575.91 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5027, 6, 43, CAST(876.91 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5028, 21, 94, CAST(300.55 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5029, 2, 22, CAST(95.09 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5030, 2, 21, CAST(659.82 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5031, 16, 64, CAST(607.00 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5032, 61, 160, CAST(865.36 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5033, 52, 157, CAST(135.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5034, 70, 39, CAST(511.18 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5035, 52, 161, CAST(63.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5036, 3, 109, CAST(798.27 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5037, 66, 163, CAST(439.09 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5038, 97, 129, CAST(150.73 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5039, 79, 154, CAST(801.09 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5040, 37, 27, CAST(130.73 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5041, 100, 99, CAST(354.45 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5042, 6, 81, CAST(259.45 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5043, 65, 30, CAST(348.00 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5044, 98, 18, CAST(751.45 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5045, 93, 18, CAST(217.91 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5046, 51, 59, CAST(783.64 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5047, 52, 99, CAST(670.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5048, 65, 59, CAST(714.82 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5049, 90, 20, CAST(592.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5050, 3, 95, CAST(213.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5051, 30, 52, CAST(571.18 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5052, 56, 114, CAST(390.09 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5053, 64, 21, CAST(253.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5054, 36, 154, CAST(590.18 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5055, 42, 104, CAST(305.00 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5056, 20, 113, CAST(506.55 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5057, 30, 4, CAST(393.55 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5058, 15, 49, CAST(302.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5059, 55, 8, CAST(490.09 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5060, 90, 25, CAST(208.82 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5061, 82, 115, CAST(233.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5062, 49, 102, CAST(630.36 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5063, 48, 78, CAST(851.27 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5064, 97, 79, CAST(209.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5065, 62, 23, CAST(520.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5066, 78, 61, CAST(216.27 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5067, 20, 93, CAST(75.00 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5068, 21, 162, CAST(814.27 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5069, 91, 10, CAST(28.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5070, 94, 10, CAST(80.27 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5071, 22, 40, CAST(648.45 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5072, 58, 2, CAST(480.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5073, 72, 138, CAST(552.36 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5074, 58, 39, CAST(395.27 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5075, 65, 145, CAST(402.45 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5076, 2, 82, CAST(292.09 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5077, 8, 163, CAST(599.91 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5078, 37, 32, CAST(258.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5079, 1, 100, CAST(228.73 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5080, 40, 158, CAST(42.36 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5081, 3, 96, CAST(768.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5082, 2, 168, CAST(540.55 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5083, 84, 14, CAST(903.27 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5084, 68, 149, CAST(293.36 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5085, 19, 143, CAST(768.64 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5086, 43, 80, CAST(114.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5087, 51, 33, CAST(170.64 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5088, 86, 168, CAST(738.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5089, 97, 7, CAST(678.45 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5090, 6, 136, CAST(584.55 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5091, 82, 55, CAST(334.27 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5092, 21, 174, CAST(696.27 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5093, 63, 109, CAST(482.45 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5094, 13, 113, CAST(113.55 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5095, 43, 23, CAST(276.82 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5096, 39, 151, CAST(307.00 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5097, 68, 43, CAST(30.45 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5098, 47, 166, CAST(56.64 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5099, 74, 15, CAST(441.27 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5100, 77, 70, CAST(650.91 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5101, 24, 103, CAST(770.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5102, 60, 160, CAST(890.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5103, 41, 171, CAST(192.91 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5104, 2, 116, CAST(732.73 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5105, 49, 56, CAST(610.27 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5106, 30, 113, CAST(122.45 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5107, 57, 161, CAST(834.45 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5108, 74, 127, CAST(272.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5109, 92, 176, CAST(717.55 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5110, 95, 48, CAST(399.00 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5111, 98, 111, CAST(174.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5112, 36, 34, CAST(340.91 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5113, 19, 165, CAST(738.18 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5114, 66, 55, CAST(556.91 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5115, 38, 83, CAST(840.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5116, 78, 109, CAST(734.27 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5117, 82, 116, CAST(468.73 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5118, 94, 25, CAST(781.36 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5119, 87, 167, CAST(309.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5120, 9, 74, CAST(433.64 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5121, 72, 28, CAST(649.18 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5122, 76, 118, CAST(419.82 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5123, 88, 80, CAST(88.45 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5124, 12, 88, CAST(832.55 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5125, 2, 146, CAST(807.64 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5126, 65, 117, CAST(594.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5127, 48, 54, CAST(531.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5128, 51, 109, CAST(602.73 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5129, 7, 133, CAST(32.73 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5130, 57, 136, CAST(223.27 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5131, 81, 69, CAST(715.45 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5132, 21, 39, CAST(9.27 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5133, 92, 124, CAST(729.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5134, 55, 43, CAST(138.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5135, 78, 159, CAST(58.45 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5136, 62, 106, CAST(239.09 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5137, 85, 46, CAST(121.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5138, 55, 116, CAST(154.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5139, 88, 100, CAST(134.00 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5140, 3, 159, CAST(874.00 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5141, 63, 133, CAST(289.73 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5142, 2, 99, CAST(367.73 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5143, 76, 47, CAST(328.27 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5144, 40, 179, CAST(91.73 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5145, 74, 167, CAST(99.09 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5146, 77, 11, CAST(731.64 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5147, 6, 61, CAST(97.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5148, 72, 63, CAST(599.36 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5149, 26, 181, CAST(776.27 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5150, 63, 80, CAST(775.82 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5151, 17, 105, CAST(800.09 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5152, 39, 37, CAST(34.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5153, 8, 89, CAST(286.55 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5154, 39, 66, CAST(28.45 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5155, 74, 114, CAST(655.00 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5156, 6, 70, CAST(147.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5157, 81, 71, CAST(49.64 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5158, 34, 10, CAST(326.73 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5159, 39, 113, CAST(392.36 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5160, 6, 120, CAST(570.82 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5161, 70, 145, CAST(202.64 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5162, 32, 87, CAST(482.82 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5163, 41, 134, CAST(723.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5164, 54, 125, CAST(710.82 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5165, 27, 143, CAST(831.00 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5166, 26, 61, CAST(887.55 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5167, 42, 107, CAST(557.82 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5168, 57, 67, CAST(731.27 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5169, 58, 13, CAST(104.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5170, 59, 135, CAST(565.82 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5171, 45, 66, CAST(888.73 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5172, 18, 96, CAST(739.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5173, 25, 22, CAST(778.82 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5174, 16, 67, CAST(688.82 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5175, 39, 12, CAST(636.55 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5176, 62, 24, CAST(17.91 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5177, 84, 130, CAST(385.73 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5178, 100, 66, CAST(197.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5179, 97, 150, CAST(171.36 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5180, 42, 4, CAST(874.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5181, 48, 178, CAST(227.00 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5182, 62, 116, CAST(14.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5183, 18, 2, CAST(853.73 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5184, 36, 114, CAST(297.91 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5185, 7, 71, CAST(392.45 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5186, 69, 73, CAST(124.00 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5187, 68, 173, CAST(739.18 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5188, 62, 143, CAST(280.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5189, 96, 15, CAST(900.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5190, 11, 51, CAST(500.45 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5191, 91, 138, CAST(668.55 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5192, 32, 156, CAST(26.36 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5193, 59, 180, CAST(476.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5194, 42, 146, CAST(76.27 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5195, 76, 138, CAST(886.82 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5196, 47, 149, CAST(472.55 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5197, 71, 44, CAST(113.36 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5198, 28, 38, CAST(19.73 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5199, 5, 110, CAST(148.73 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5200, 15, 154, CAST(676.00 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5201, 88, 157, CAST(458.09 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5202, 38, 169, CAST(384.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5203, 48, 45, CAST(361.36 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5204, 62, 116, CAST(719.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5205, 83, 86, CAST(310.82 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5206, 96, 9, CAST(329.91 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5207, 57, 3, CAST(30.73 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5208, 61, 120, CAST(158.27 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5209, 100, 31, CAST(344.91 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5210, 21, 181, CAST(653.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5211, 25, 28, CAST(136.55 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5212, 4, 134, CAST(859.27 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5213, 5, 66, CAST(457.45 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5214, 42, 96, CAST(825.45 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5215, 10, 96, CAST(247.91 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5216, 36, 118, CAST(616.82 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5217, 21, 74, CAST(465.91 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5218, 91, 86, CAST(844.09 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5219, 92, 26, CAST(532.36 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5220, 25, 154, CAST(77.09 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5221, 12, 21, CAST(681.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5222, 61, 137, CAST(10.09 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5223, 83, 40, CAST(132.36 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5224, 16, 72, CAST(318.55 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5225, 89, 56, CAST(640.36 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5226, 92, 168, CAST(513.00 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5227, 10, 167, CAST(225.91 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5228, 41, 108, CAST(747.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5229, 25, 25, CAST(284.18 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5230, 15, 98, CAST(786.64 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5231, 42, 162, CAST(602.45 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5232, 70, 72, CAST(820.73 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5233, 7, 124, CAST(795.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5234, 30, 69, CAST(173.82 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5235, 24, 147, CAST(499.18 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5236, 86, 30, CAST(852.55 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5237, 17, 101, CAST(192.64 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5238, 98, 49, CAST(392.09 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5239, 68, 49, CAST(373.36 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5240, 27, 110, CAST(549.82 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5241, 59, 71, CAST(833.64 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5242, 92, 118, CAST(644.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5243, 57, 146, CAST(73.18 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5244, 35, 76, CAST(556.27 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5245, 16, 69, CAST(504.45 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5246, 65, 180, CAST(95.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5247, 65, 166, CAST(264.64 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5248, 1, 102, CAST(112.64 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5249, 35, 41, CAST(34.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5250, 33, 43, CAST(648.36 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5251, 91, 124, CAST(455.82 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5252, 50, 51, CAST(281.36 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5253, 87, 179, CAST(445.82 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5254, 50, 22, CAST(840.73 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5255, 9, 134, CAST(368.73 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5256, 52, 162, CAST(544.82 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5257, 80, 111, CAST(369.91 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5258, 51, 1, CAST(497.00 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5259, 1, 34, CAST(175.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5260, 21, 35, CAST(282.45 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5261, 84, 88, CAST(74.00 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5262, 2, 7, CAST(643.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5263, 32, 50, CAST(557.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5264, 27, 122, CAST(74.27 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5265, 59, 32, CAST(22.45 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5266, 58, 30, CAST(74.73 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5267, 69, 174, CAST(556.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5268, 10, 29, CAST(653.64 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5269, 100, 102, CAST(230.27 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5270, 26, 72, CAST(601.45 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5271, 5, 70, CAST(377.55 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5272, 76, 79, CAST(589.82 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5273, 65, 5, CAST(646.09 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5274, 27, 154, CAST(43.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5275, 25, 90, CAST(869.82 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5276, 1, 112, CAST(178.36 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5277, 88, 47, CAST(163.18 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5278, 31, 89, CAST(545.82 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5279, 36, 31, CAST(57.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5280, 72, 92, CAST(227.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5281, 63, 73, CAST(693.82 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5282, 87, 148, CAST(75.27 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5283, 51, 158, CAST(803.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5284, 39, 91, CAST(537.73 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5285, 53, 127, CAST(855.45 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5286, 32, 40, CAST(433.73 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5287, 17, 57, CAST(655.55 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5288, 100, 46, CAST(401.91 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5289, 1, 31, CAST(352.09 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5290, 98, 70, CAST(552.00 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5291, 12, 153, CAST(322.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5292, 39, 160, CAST(723.36 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5293, 62, 77, CAST(171.91 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5294, 53, 139, CAST(721.27 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5295, 71, 34, CAST(227.27 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5296, 45, 43, CAST(182.36 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5297, 67, 28, CAST(392.64 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5298, 72, 100, CAST(117.82 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5299, 74, 13, CAST(284.09 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5300, 51, 152, CAST(547.73 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5301, 7, 92, CAST(397.00 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5302, 44, 99, CAST(794.55 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5303, 10, 84, CAST(487.00 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5304, 80, 154, CAST(616.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5305, 54, 119, CAST(855.18 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5306, 54, 92, CAST(77.09 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5307, 82, 99, CAST(839.82 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5308, 52, 155, CAST(719.91 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5309, 63, 162, CAST(535.64 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5310, 67, 3, CAST(596.09 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5311, 21, 71, CAST(629.36 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5312, 55, 9, CAST(12.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5313, 75, 99, CAST(272.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5314, 25, 151, CAST(222.18 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5315, 89, 21, CAST(559.82 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5316, 70, 30, CAST(695.00 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5317, 45, 133, CAST(787.09 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5318, 3, 42, CAST(440.45 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5319, 28, 156, CAST(481.45 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5320, 85, 107, CAST(698.91 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5321, 17, 157, CAST(666.27 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5322, 28, 133, CAST(817.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5323, 42, 153, CAST(805.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5324, 61, 178, CAST(397.09 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5325, 53, 133, CAST(734.64 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5326, 85, 132, CAST(249.18 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5327, 10, 124, CAST(679.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5328, 99, 151, CAST(664.00 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5329, 91, 25, CAST(277.36 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5330, 54, 63, CAST(655.73 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5331, 70, 15, CAST(82.55 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5332, 63, 67, CAST(728.18 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5333, 54, 147, CAST(793.55 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5334, 83, 128, CAST(403.00 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5335, 88, 92, CAST(11.27 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5336, 75, 127, CAST(351.82 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5337, 33, 87, CAST(870.55 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5338, 41, 125, CAST(490.64 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5339, 5, 135, CAST(358.73 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5340, 50, 36, CAST(384.91 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5341, 19, 99, CAST(573.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5342, 96, 1, CAST(16.09 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5343, 20, 95, CAST(343.73 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5344, 25, 117, CAST(295.91 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5345, 17, 61, CAST(707.45 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5346, 78, 124, CAST(610.55 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5347, 70, 47, CAST(385.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5348, 14, 24, CAST(813.73 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5349, 21, 144, CAST(58.09 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5350, 1, 73, CAST(387.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5351, 30, 136, CAST(811.91 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5352, 58, 115, CAST(84.18 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5353, 48, 57, CAST(316.73 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5354, 59, 138, CAST(131.82 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5355, 52, 53, CAST(387.36 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5356, 54, 45, CAST(717.91 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5357, 13, 119, CAST(802.18 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5358, 88, 177, CAST(212.00 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5359, 97, 31, CAST(308.55 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5360, 61, 31, CAST(770.55 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5361, 62, 104, CAST(588.64 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5362, 41, 89, CAST(610.18 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5363, 38, 103, CAST(73.55 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5364, 72, 90, CAST(608.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5365, 24, 157, CAST(55.82 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5366, 60, 53, CAST(268.55 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5367, 62, 67, CAST(415.91 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5368, 58, 119, CAST(503.55 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5369, 96, 165, CAST(377.55 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5370, 85, 17, CAST(264.73 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5371, 18, 70, CAST(95.55 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5372, 2, 9, CAST(93.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5373, 30, 73, CAST(884.09 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5374, 10, 4, CAST(851.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5375, 72, 6, CAST(27.91 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5376, 25, 128, CAST(53.18 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5377, 30, 102, CAST(750.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5378, 42, 104, CAST(182.64 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5379, 5, 43, CAST(477.64 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5380, 35, 144, CAST(599.55 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5381, 13, 92, CAST(290.45 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5382, 66, 159, CAST(470.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5383, 58, 19, CAST(313.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5384, 9, 116, CAST(563.73 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5385, 71, 45, CAST(125.82 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5386, 4, 14, CAST(244.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5387, 98, 32, CAST(714.82 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5388, 38, 87, CAST(203.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5389, 37, 167, CAST(450.00 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5390, 26, 125, CAST(842.45 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5391, 58, 50, CAST(543.00 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5392, 65, 48, CAST(471.45 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5393, 73, 118, CAST(100.64 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5394, 95, 87, CAST(228.55 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5395, 94, 27, CAST(618.09 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5396, 63, 80, CAST(839.73 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5397, 74, 169, CAST(495.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5398, 10, 36, CAST(69.73 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5399, 55, 117, CAST(82.45 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5400, 46, 24, CAST(77.82 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5401, 100, 104, CAST(29.91 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5402, 42, 59, CAST(775.00 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5403, 52, 30, CAST(586.27 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5404, 45, 47, CAST(376.82 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5405, 37, 91, CAST(550.73 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5406, 2, 160, CAST(568.27 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5407, 31, 77, CAST(294.09 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5408, 47, 70, CAST(681.91 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5409, 99, 142, CAST(737.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5410, 25, 32, CAST(173.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5411, 78, 174, CAST(605.09 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5412, 50, 179, CAST(856.64 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5413, 81, 165, CAST(425.64 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5414, 4, 154, CAST(268.45 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5415, 47, 118, CAST(30.82 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5416, 62, 92, CAST(562.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5417, 63, 47, CAST(619.73 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5418, 77, 181, CAST(235.18 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5419, 85, 35, CAST(489.36 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5420, 28, 23, CAST(527.45 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5421, 76, 167, CAST(626.09 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5422, 82, 4, CAST(338.18 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5423, 59, 99, CAST(105.82 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5424, 92, 11, CAST(558.55 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5425, 38, 33, CAST(218.09 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5426, 26, 152, CAST(547.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5427, 19, 40, CAST(132.64 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5428, 68, 13, CAST(329.36 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5429, 83, 8, CAST(347.55 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5430, 21, 55, CAST(240.55 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5431, 77, 3, CAST(743.27 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5432, 78, 173, CAST(217.27 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5433, 97, 104, CAST(149.64 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5434, 52, 56, CAST(867.91 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5435, 51, 11, CAST(675.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5436, 54, 178, CAST(146.27 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5437, 74, 95, CAST(493.18 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5438, 97, 28, CAST(514.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5439, 24, 171, CAST(366.27 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5440, 94, 29, CAST(783.09 AS Decimal(9, 2)), 10)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5441, 5, 6, CAST(15.82 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5442, 37, 7, CAST(219.55 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5443, 95, 81, CAST(858.09 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5444, 9, 19, CAST(574.55 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5445, 11, 138, CAST(839.55 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5446, 15, 46, CAST(68.73 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5447, 51, 72, CAST(541.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5448, 1, 156, CAST(120.73 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5449, 38, 92, CAST(535.91 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5450, 29, 50, CAST(223.00 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5451, 77, 33, CAST(561.91 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5452, 72, 123, CAST(217.18 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5453, 62, 25, CAST(732.00 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5454, 42, 130, CAST(383.36 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5455, 42, 11, CAST(155.45 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5456, 48, 30, CAST(413.45 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5457, 31, 25, CAST(124.64 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5458, 85, 81, CAST(463.36 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5459, 51, 43, CAST(721.91 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5460, 31, 44, CAST(708.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5461, 37, 18, CAST(616.91 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5462, 31, 46, CAST(66.09 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5463, 11, 181, CAST(147.82 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5464, 23, 133, CAST(289.64 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5465, 31, 97, CAST(763.64 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5466, 91, 70, CAST(98.36 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5467, 1, 12, CAST(274.18 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5468, 7, 100, CAST(157.09 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5469, 42, 5, CAST(681.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5470, 96, 146, CAST(738.00 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5471, 58, 156, CAST(603.36 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5472, 35, 109, CAST(668.91 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5473, 95, 149, CAST(852.36 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5474, 75, 172, CAST(569.64 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5475, 96, 65, CAST(600.55 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5476, 87, 57, CAST(477.55 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5477, 99, 170, CAST(648.73 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5478, 71, 100, CAST(844.00 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5479, 61, 55, CAST(85.36 AS Decimal(9, 2)), 1)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5480, 56, 78, CAST(434.00 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5481, 52, 65, CAST(568.18 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5482, 98, 59, CAST(533.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5483, 50, 92, CAST(152.73 AS Decimal(9, 2)), 5)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5484, 59, 89, CAST(270.73 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5485, 62, 177, CAST(634.45 AS Decimal(9, 2)), 4)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5486, 39, 140, CAST(97.36 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5487, 96, 143, CAST(297.36 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5488, 85, 164, CAST(49.91 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5489, 44, 135, CAST(830.91 AS Decimal(9, 2)), 2)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5490, 33, 147, CAST(545.18 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5491, 83, 114, CAST(305.91 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5492, 85, 26, CAST(504.36 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5493, 13, 62, CAST(875.18 AS Decimal(9, 2)), 8)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5494, 59, 41, CAST(295.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5495, 84, 116, CAST(657.18 AS Decimal(9, 2)), 7)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5496, 93, 161, CAST(59.64 AS Decimal(9, 2)), 9)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5497, 35, 78, CAST(666.00 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5498, 82, 122, CAST(855.64 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5499, 62, 69, CAST(690.91 AS Decimal(9, 2)), 6)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5500, 90, 114, CAST(569.27 AS Decimal(9, 2)), 3)
GO
INSERT [dbo].[Ordenes_Items] ([Id], [OrdenID], [ItemID], [PrecioUnitario], [Cantidad]) VALUES (5501, 83, 23, CAST(570.00 AS Decimal(9, 2)), 6)
GO
SET IDENTITY_INSERT [dbo].[Ordenes_Items] OFF
GO
INSERT [dbo].[Proveedores] ([ProveedorID], [Nombre]) VALUES (N'P-01', N'Boreal Suministros S.L.')
GO
INSERT [dbo].[Roles] ([RolID], [Nombre]) VALUES (N'R-01', N'Administrador de Sistemas')
GO
INSERT [dbo].[Roles] ([RolID], [Nombre]) VALUES (N'R-02', N'Empleado de Departamento')
GO
INSERT [dbo].[Roles] ([RolID], [Nombre]) VALUES (N'R-03', N'Jefe de Departamento')
GO
INSERT [dbo].[Roles] ([RolID], [Nombre]) VALUES (N'R-04', N'Encargado de Compras')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Empleados]    Script Date: 4/7/2022 17:44:59 ******/
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [IX_Empleados] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Departamentos] FOREIGN KEY([DepartamentoID])
REFERENCES [dbo].[Departamentos] ([DepartamentoID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Departamentos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Roles] FOREIGN KEY([RolID])
REFERENCES [dbo].[Roles] ([RolID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Roles]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categorias] FOREIGN KEY([CategoriaID])
REFERENCES [dbo].[Categorias] ([CategoriaID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categorias]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Proveedores] FOREIGN KEY([ProveedorID])
REFERENCES [dbo].[Proveedores] ([ProveedorID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Proveedores]
GO
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Empleados] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Empleados] ([Legajo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Empleados]
GO
ALTER TABLE [dbo].[Ordenes_Items]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Items_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ordenes_Items] CHECK CONSTRAINT [FK_Ordenes_Items_Items]
GO
ALTER TABLE [dbo].[Ordenes_Items]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Items_Ordenes] FOREIGN KEY([OrdenID])
REFERENCES [dbo].[Ordenes] ([OrdenID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ordenes_Items] CHECK CONSTRAINT [FK_Ordenes_Items_Ordenes]
GO
/****** Object:  StoredProcedure [dbo].[ABM_Categorias]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Categorias]
(
    @CategoriaID CHAR(4),
    @Nombre      VARCHAR(50),
    @Descripcion VARCHAR(MAX),
    @Instruccion NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Categorias
        (
            CategoriaID,
            Nombre,
            Descripcion
        )
        VALUES
        (
		    @CategoriaID,
			@Nombre,
			@Descripcion
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Categorias
        WHERE CategoriaID = @CategoriaID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Categorias
        SET   Nombre      = @Nombre,
              Descripcion = @Descripcion
        WHERE CategoriaID = @CategoriaID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Categorias
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Departamentos]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Departamentos]
(
    @DepartamentoID CHAR(4),
    @Nombre         VARCHAR(50),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Departamentos
        (
            DepartamentoID,
            Nombre
        )
        VALUES
        (
		    @DepartamentoID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Departamentos
        WHERE DepartamentoID = @DepartamentoID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Departamentos
        SET   Nombre      = @Nombre
        WHERE DepartamentoID = @DepartamentoID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Departamentos
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Empleados]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Empleados]
(
    @Legajo         INTEGER,
    @Nombre         VARCHAR(50),
	@Apellido       VARCHAR(50),
	@Usuario        VARCHAR(50),
	@Contraseña     VARCHAR(50),
	@DepartamentoID CHAR(4),
	@RolID          CHAR(4),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Empleados
        (
            Legajo,
            Nombre,
	        Apellido,
	        Usuario,
	        Contraseña,
	        DepartamentoID,
	        RolID
        )
        VALUES
        (
		    @Legajo,
            @Nombre,
	        @Apellido,
	        @Usuario,
	        @Contraseña,
	        @DepartamentoID,
	        @RolID
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Empleados
        WHERE Legajo = @Legajo
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Empleados
        SET    Nombre         = @Nombre,
	           Apellido       = @Apellido,
	           Usuario        = @Usuario,
	           Contraseña     = @Contraseña,
	           DepartamentoID = @DepartamentoID,
	           RolID          = @RolID
        WHERE Legajo          = @Legajo
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Empleados
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Items]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Items]
(
    @ItemID         INTEGER,
    @CategoriaID    CHAR(4),
	@Nombre         VARCHAR(MAX),
	@Descripcion    VARCHAR(MAX),
	@PrecioUnitario DECIMAL(9, 2),
	@ProveedorID    CHAR(4),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Items
        (
            CategoriaID,
	        Nombre,
	        Descripcion,
	        PrecioUnitario,
	        ProveedorID
        )
        VALUES
        (
            @CategoriaID,
	        @Nombre,
	        @Descripcion,
	        @PrecioUnitario,
	        @ProveedorID
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Items
        WHERE ItemID = @ItemID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Items
        SET    CategoriaID    = @CategoriaID,
	           Nombre         = @Nombre,
	           Descripcion    = @Descripcion,
	           PrecioUnitario = @PrecioUnitario,
	           ProveedorID    = @ProveedorID
        WHERE  ItemID         = @ItemID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Items
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Ordenes]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Ordenes]
(
    @OrdenID     INTEGER,
    @Legajo      INTEGER,
	@Fecha       DATE,
	@Estado      CHAR(10),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Ordenes
        (
            Legajo,
	        Fecha,
	        Estado
        )
        VALUES
        (
            @Legajo,
	        @Fecha,
	        @Estado
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Ordenes
        SET    Legajo  = @Legajo,
	           Fecha   = @Fecha,
	           Estado  = @Estado
        WHERE  OrdenID = @OrdenID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Ordenes
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Ordenes_Items]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Ordenes_Items]
    --Ordenes
	@Legajo         INTEGER,
	@Fecha          DATE,
	@Estado         CHAR(10),
	--Items
	@CategoriaID    CHAR(4),
	@Nombre         VARCHAR(MAX),
	@PrecioUnitario DECIMAL(9, 2),
	@ProveedorID    CHAR(4),
	--Ordenes_Items
	@Id             INTEGER,
    @OrdenID        INTEGER,
    @ItemID         INTEGER,
    @Cantidad       INTEGER,
	--Procedimiento Almacenado
    @Instruccion    CHAR(6)
AS
BEGIN

    DECLARE @ID_ORDEN int
    DECLARE @ID_ITEM int

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS
	--NOTA:
	--Sin calibrar. El uso pensado es dar de alta una orden y agregar ítems
	--a una orden. No se han hecho más pruebas.
	--Parámetros necesarios: creo que todos.

    IF @Instruccion = 'Insert'
    BEGIN

	    --Busco por empleado que pide (por el momento, hasta mejorar el diseño).
        SELECT @ID_ORDEN = OrdenID
	    FROM Ordenes
	    WHERE Legajo = @Legajo

	    --Busco por nombre del producto (por el momento, hasta mejorar el diseño).
	    SELECT @ID_ITEM = ItemID
	    FROM Items
	    WHERE Nombre = @Nombre

        IF (@ID_ORDEN IS NULL)
        BEGIN
            INSERT INTO Ordenes
			(
			    Legajo,
				Fecha,
				Estado
			)
		    VALUES
			(
			    @Legajo,
				@Fecha,
				@Estado
			)
            SELECT @ID_ORDEN = SCOPE_IDENTITY()
        END

        IF (@ID_ITEM IS NULL)
        BEGIN
            INSERT INTO Items
			(
			    CategoriaID,
				Nombre,
				PrecioUnitario,
				ProveedorID
			)
		    VALUES
			(
			    @CategoriaID,
				@Nombre,
				@PrecioUnitario,
				@ProveedorID
			)
            SELECT @ID_ITEM = SCOPE_IDENTITY()
        END

	    INSERT INTO Ordenes_Items
        VALUES (@ID_ORDEN, @ID_ITEM, @Cantidad)

    END

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS
	--USO: 
	--Las tablas son de órdenes y sus ítems.
	--Si deseo borrar la órden completa, proveo su ID.
	--POR EL MOMENTO, ES TODA LA OPERACIÓN QUE SE HARÁ.
	--EN UN FUTURO, SE PODRÍA AJUSTAR PARA QUE:
	--Si no deseo borrar la órden, Id = 0
	--Si deseo borrar un ítem de la orden, proveo su ID.
	--Si no deseo borrar un ítem, Id = 0
	--Parámetros necesarios: ID de la órden.

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES
    --NOTA:
	--Update, por el momento, pienso que solo puede ser utilizado
	--para cambiar, por ejemplo, la cantidad de artículos pedida.
	--Parámetros necesarios: ID del ítem.

	IF @Instruccion = 'Update'
    BEGIN
        UPDATE Ordenes_Items
        SET Cantidad = @Cantidad
        WHERE OrdenID = @OrdenID AND ItemID = @ItemID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS
	--Por el momento (incluso creo que esta sección es un "huevo de pascua")
	--la operación de listado implica a los ítems de una órden.
	--Parámetros necesarios: ID de la órden.
	
	IF @Instruccion = 'Select'
    BEGIN
        SELECT Legajo,
               Fecha,
			   Estado,
			   Nombre,
			   Descripcion,
			   PrecioUnitario
        FROM Items
            JOIN Ordenes_Items 
			ON Ordenes_Items.ItemID  = Items.ItemID
            JOIN Ordenes
			ON Ordenes_Items.OrdenID = Ordenes.OrdenID
        WHERE Ordenes.OrdenID = @OrdenID
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Proveedores]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Proveedores]
(
    @ProveedorID CHAR(4),
	@Nombre      VARCHAR(50),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Proveedores
        (
	        ProveedorID,
			Nombre
        )
        VALUES
        (
	        @ProveedorID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Proveedores
        WHERE ProveedorID = @ProveedorID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Proveedores
        SET    Nombre      = @Nombre
        WHERE  ProveedorID = @ProveedorID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Proveedores
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_Roles]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_Roles]
(
    @RolID       CHAR(4),
	@Nombre      VARCHAR(50),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Roles
        (
	        RolID,
			Nombre
        )
        VALUES
        (
	        @RolID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Roles
        WHERE RolID = @RolID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Roles
        SET    Nombre = @Nombre
        WHERE  RolID  = @RolID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Roles
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ABM_StudentCourses]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ABM_StudentCourses]
    @StudentId INTEGER,
    @StudentName VARCHAR(50),
    @CourseId INTEGER,
    @CourseName VARCHAR(50),
    @StatementType NVARCHAR(20)
AS
BEGIN

    DECLARE @Student_Id int
    DECLARE @Course_Id int

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    IF @StatementType = 'Insert'
    BEGIN
        INSERT Students
        (
            StudentName
        )
        SELECT DISTINCT
            @StudentName
        FROM Students
        WHERE NOT EXISTS
        (
            SELECT * FROM Students WHERE StudentId = @StudentId
        )

        IF @StudentId = 0
        BEGIN
            SELECT @Student_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Student_Id = @StudentId
        END

        INSERT Courses
        (
            CourseName
        )
        SELECT DISTINCT
            @CourseName
        FROM Courses
        WHERE NOT EXISTS
        (
            SELECT * FROM Courses WHERE CourseId = @CourseId
        )

        IF @CourseId = 0
        BEGIN
            SELECT @Course_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Course_Id = @CourseId
        END

        INSERT INTO StudentCourses
        VALUES
        (@Student_Id, @Course_Id)
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    IF @StatementType = 'Select'
    BEGIN
        SELECT StudentName,
               CourseName
        FROM Courses
            JOIN StudentCourses
                ON Courses.CourseId = StudentCourses.CourseId
            JOIN Students
                ON Students.StudentId = StudentCourses.StudentId
        WHERE Students.StudentId = @StudentId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    IF @StatementType = 'Update'
    BEGIN
        UPDATE Students
        SET StudentName = @StudentName
        WHERE StudentId = @StudentId

        UPDATE Courses
        SET CourseName = @CourseName
        WHERE CourseId = @CourseId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
	--Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)
    
	IF @StatementType = 'Delete'
    BEGIN
        IF @StudentId <> 0
		BEGIN
		    DELETE FROM Students
            WHERE StudentId = @StudentId
		END

		IF @CourseId <> 0
		BEGIN
            DELETE FROM Courses
            WHERE CourseId = @CourseId
		END
    END

END
GO
/****** Object:  StoredProcedure [dbo].[ConsultaParaReporte]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ConsultaParaReporte]
	@Desde DATE,
	@Hasta DATE

AS

SELECT o.OrdenID,
       o.Fecha,
       c.Nombre + ', ' + c.Apellido AS Empleado,
       Producto = Stuff(
                  (
                      SELECT ' - ' + 'x' + CONVERT(VARCHAR(10), oi2.Cantidad) + ' ' + Items.Nombre
                      FROM Ordenes_Items oi2
                          INNER JOIN Items
                              ON Items.ItemID = oi2.ItemID
                      WHERE oi2.OrdenID = oi1.OrdenID
                      FOR xml path('')
                  ),
                  1,
                  2,
                  ''
                       ),
       Sum(Cantidad * PrecioUnitario) AS Total
FROM Ordenes o
    INNER JOIN Empleados c
        ON c.Legajo = o.Legajo
    INNER JOIN Ordenes_Items oi1
        ON oi1.OrdenID = o.OrdenID
WHERE o.Fecha
BETWEEN @Desde AND @Hasta
GROUP BY o.OrdenID,
         oi1.OrdenID,
         o.Fecha,
         c.Nombre,
         c.Apellido
ORDER BY o.OrdenID ASC

GO
/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 4/7/2022 17:44:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Login]
(
	@Usuario        VARCHAR(50),
	@Contraseña     VARCHAR(50)
)

AS
BEGIN
	SELECT COUNT(*) FROM Empleados WHERE Usuario = @Usuario AND Contraseña = @Contraseña
END
GO
USE [master]
GO
ALTER DATABASE [PedidosDeInsumosDeOficina] SET  READ_WRITE 
GO
