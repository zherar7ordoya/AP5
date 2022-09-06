CREATE TABLE Socios
(
  SocioID INT NOT NULL,
  Apellidos VARCHAR(50) NOT NULL,
  Nombres VARCHAR(50) NOT NULL,
  DNI INT NOT NULL,
  Calle VARCHAR(50) NOT NULL,
  Numero INT NOT NULL,
  PRIMARY KEY (SocioID)
);

CREATE TABLE Libros
(
  Titulo VARCHAR(50) NOT NULL,
  YearEscritura INT NOT NULL,
  LibroID INT NOT NULL,
  PRIMARY KEY (LibroID)
);

CREATE TABLE Bibliotecarios
(
  Legajo INT NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Apellido VARCHAR(50) NOT NULL,
  PRIMARY KEY (Legajo)
);

CREATE TABLE Proveedores
(
  ProveedorID INT NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Calle VARCHAR(50) NOT NULL,
  Numero INT NOT NULL,
  PRIMARY KEY (ProveedorID)
);

CREATE TABLE Editoriales
(
  EditorialID INT NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Calle VARCHAR(50) NOT NULL,
  Numero INT NOT NULL,
  PRIMARY KEY (EditorialID)
);

CREATE TABLE Editorial_Libro
(
  EditorialID INT NOT NULL,
  LibroID INT NOT NULL,
  PRIMARY KEY (EditorialID, LibroID),
  FOREIGN KEY (EditorialID) REFERENCES Editoriales(EditorialID),
  FOREIGN KEY (LibroID) REFERENCES Libros(LibroID)
);

CREATE TABLE Socio_Telefono
(
  Telefono INT NOT NULL,
  SocioID INT NOT NULL,
  PRIMARY KEY (Telefono, SocioID),
  FOREIGN KEY (SocioID) REFERENCES Socios(SocioID)
);

CREATE TABLE Autor_Libro
(
  Autor VARCHAR(50) NOT NULL,
  LibroID INT NOT NULL,
  PRIMARY KEY (Autor, LibroID),
  FOREIGN KEY (LibroID) REFERENCES Libros(LibroID)
);

CREATE TABLE Ediciones
(
  YearEdicion INT NOT NULL,
  ISBN VARCHAR(17) NOT NULL,
  LibroID INT NOT NULL,
  ProveedorID INT NOT NULL,
  PRIMARY KEY (ISBN),
  FOREIGN KEY (LibroID) REFERENCES Libros(LibroID),
  FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
);

CREATE TABLE Volumenes
(
  Ejemplar INT NOT NULL,
  Deteriorado INT NOT NULL,
  VolumenID INT NOT NULL,
  ISBN VARCHAR(17) NOT NULL,
  Legajo INT NOT NULL,
  PRIMARY KEY (VolumenID),
  FOREIGN KEY (ISBN) REFERENCES Ediciones(ISBN),
  FOREIGN KEY (Legajo) REFERENCES Bibliotecarios(Legajo)
);

CREATE TABLE Prestamos
(
  FechaPrestamo DATE NOT NULL,
  FechaTope DATE NOT NULL,
  FechaDevolucion DATE NOT NULL,
  PrestamoID INT NOT NULL,
  SocioID INT NOT NULL,
  VolumenID INT NOT NULL,
  PRIMARY KEY (PrestamoID),
  FOREIGN KEY (SocioID) REFERENCES Socios(SocioID),
  FOREIGN KEY (VolumenID) REFERENCES Volumenes(VolumenID),
  UNIQUE (SocioID, VolumenID)
);