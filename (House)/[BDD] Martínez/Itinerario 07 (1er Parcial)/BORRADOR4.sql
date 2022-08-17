CREATE TABLE SOCIOS
(
  CodigoSocio INT NOT NULL,
  Apellido VARCHAR(15) NOT NULL,
  Nombre VARCHAR(15) NOT NULL,
  DNI INT NOT NULL,
  Calle VARCHAR(15) NOT NULL,
  Numero INT NOT NULL,
  PRIMARY KEY (CodigoSocio)
);

CREATE TABLE PROVEEDORES
(
  CodigoProveedor INT NOT NULL,
  RazonSocial VARCHAR(25) NOT NULL,
  Calle VARCHAR(15) NOT NULL,
  Numero INT NOT NULL,
  CUIT VARCHAR(15) NOT NULL,
  PRIMARY KEY (CodigoProveedor)
);

CREATE TABLE EDITORIALES
(
  CodigoEditorial INT NOT NULL,
  RazonSocial VARCHAR(25) NOT NULL,
  Calle VARCHAR(15) NOT NULL,
  Numero INT NOT NULL,
  CUIT VARCHAR(15) NOT NULL,
  PRIMARY KEY (CodigoEditorial)
);

CREATE TABLE PRESTAMOS
(
  CodigoPrestamo INT NOT NULL,
  CodigoSocio INT NOT NULL,
  PRIMARY KEY (CodigoPrestamo),
  FOREIGN KEY (CodigoSocio) REFERENCES SOCIOS(CodigoSocio)
);

CREATE TABLE AUTORES
(
  CodigoAutor INT NOT NULL,
  Nombre VARCHAR(15) NOT NULL,
  Apellido VARCHAR(15) NOT NULL,
  FechaNacimiento DATE NOT NULL,
  FechaDeceso DATE NOT NULL,
  PRIMARY KEY (CodigoAutor)
);

CREATE TABLE TelefonosDeSocios
(
  Telefono VARCHAR(15) NOT NULL,
  CodigoSocio INT NOT NULL,
  PRIMARY KEY (Telefono, CodigoSocio),
  FOREIGN KEY (CodigoSocio) REFERENCES SOCIOS(CodigoSocio)
);

CREATE TABLE TelefonosDeProveedores
(
  Teléfono INT NOT NULL,
  CódigoProveedor INT NOT NULL,
  PRIMARY KEY (Teléfono, CódigoProveedor),
  FOREIGN KEY (CódigoProveedor) REFERENCES PROVEEDORES(CodigoProveedor)
);

CREATE TABLE TelefonosDeEditoriales
(
  Telefono VARCHAR(15) NOT NULL,
  CodigoEditorial INT NOT NULL,
  PRIMARY KEY (Telefono, CodigoEditorial),
  FOREIGN KEY (CodigoEditorial) REFERENCES EDITORIALES(CodigoEditorial)
);

CREATE TABLE LIBROS
(
  AnioEdicion INT NOT NULL,
  Titulo VARCHAR(25) NOT NULL,
  ISBN VARCHAR(15) NOT NULL,
  Edicion INT NOT NULL,
  CodigoProveedor INT NOT NULL,
  CodigoEditorial INT NOT NULL,
  PRIMARY KEY (ISBN),
  FOREIGN KEY (CodigoProveedor) REFERENCES PROVEEDORES(CodigoProveedor),
  FOREIGN KEY (CodigoEditorial) REFERENCES EDITORIALES(CodigoEditorial),
  UNIQUE (Edicion)
);

CREATE TABLE EJEMPLARES
(
  NumeroEjemplar INT NOT NULL,
  Deteriorado INT NOT NULL,
  ISBN VARCHAR(15) NOT NULL,
  PRIMARY KEY (NumeroEjemplar),
  FOREIGN KEY (ISBN) REFERENCES LIBROS(ISBN)
);

CREATE TABLE PRESTAMOS_EJEMPLARES
(
  FechaPrestamo DATE NOT NULL,
  FechaTope DATE NOT NULL,
  FechaDevolucion DATE NOT NULL,
  CodigoPrestamo INT NOT NULL,
  NumeroEjemplar INT NOT NULL,
  PRIMARY KEY (CodigoPrestamo, NumeroEjemplar),
  FOREIGN KEY (CodigoPrestamo) REFERENCES PRESTAMOS(CodigoPrestamo),
  FOREIGN KEY (NumeroEjemplar) REFERENCES EJEMPLARES(NumeroEjemplar)
);

CREATE TABLE LIBROS_AUTORES
(
  AnioEscritura INT NOT NULL,
  ISBN VARCHAR(15) NOT NULL,
  CodigoAutor INT NOT NULL,
  PRIMARY KEY (ISBN, CodigoAutor),
  FOREIGN KEY (ISBN) REFERENCES LIBROS(ISBN),
  FOREIGN KEY (CodigoAutor) REFERENCES AUTORES(CodigoAutor)
);