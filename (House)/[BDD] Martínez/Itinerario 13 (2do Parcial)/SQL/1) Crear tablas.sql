USE Parcial2_BBDD

GO

-- Tabla: Autores
CREATE TABLE Autores (
    cod_autor int  NOT NULL,
    nombre varchar(15)  NOT NULL,
    apellido varchar(15)  NOT NULL,
    CONSTRAINT Autores_pk PRIMARY KEY  (cod_autor)
);

-- Tabla: Categorias
CREATE TABLE Categorias (
    cod_categoria int  NOT NULL,
    nombre varchar(50)  NOT NULL,
    CONSTRAINT Categorias_pk PRIMARY KEY  (cod_categoria)
);

-- Tabla: Editoriales
CREATE TABLE Editoriales (
    cod_editorial int  NOT NULL,
    nombre varchar(50)  NOT NULL,
    CONSTRAINT Editoriales_pk PRIMARY KEY  (cod_editorial)
);

-- Tabla: Lectores
CREATE TABLE Lectores (
    dni_lector bigint  NOT NULL,
    nombre varchar(15)  NOT NULL,
    apellido varchar(15)  NOT NULL,
    CONSTRAINT Lectores_pk PRIMARY KEY  (dni_lector)
);

-- Tabla: Libros
CREATE TABLE Libros (
    cod_libro int  NOT NULL,
    titulo varchar(50)  NOT NULL,
    cod_categoria int  NOT NULL,
    cod_autor int  NOT NULL,
    cod_editorial int  NOT NULL,
    CONSTRAINT Libros_ak_1 UNIQUE (cod_categoria),
    CONSTRAINT Libros_ak_2 UNIQUE (cod_autor),
    CONSTRAINT Libros_ak_3 UNIQUE (cod_editorial),
    CONSTRAINT Libros_pk PRIMARY KEY  (cod_libro)
);

-- Tabla: Libros_Devoluciones
CREATE TABLE Libros_Devoluciones (
    cod_libro int  NOT NULL,
    fecha_devolucion date  NOT NULL,
    dni_lector bigint  NOT NULL,
    CONSTRAINT Libros_Devoluciones_pk PRIMARY KEY  (cod_libro,fecha_devolucion)
);

-- Fin.
