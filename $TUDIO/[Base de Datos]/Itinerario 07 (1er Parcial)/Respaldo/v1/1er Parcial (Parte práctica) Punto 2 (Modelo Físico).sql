CREATE TABLE Socios
(
  SocioID INT NOT NULL,
  Nombre VARCHAR(25) NOT NULL,
  Apellido VARCHAR(25) NOT NULL,
  DNI INT NOT NULL,
  Calle VARCHAR(25) NOT NULL,
  Numero INT NOT NULL,
  PRIMARY KEY (SocioID)
);

CREATE TABLE Libros
(
  AñoEdicion INT NOT NULL,
  ISBN VARCHAR(17) NOT NULL,
  Titulo VARCHAR(50) NOT NULL,
  Editorial VARCHAR(50) NOT NULL,
  AñoEscritura INT NOT NULL,
  PRIMARY KEY (ISBN)
);

CREATE TABLE Volumenes
(
  EjemplarNumero INT NOT NULL,
  Deteriorado INT NOT NULL,
  ISBN VARCHAR(17) NOT NULL,
  PRIMARY KEY (ISBN),
  FOREIGN KEY (ISBN) REFERENCES Libros(ISBN)
);

CREATE TABLE Prestamos
(
  FechaPrestamo DATE NOT NULL,
  FechaTope DATE NOT NULL,
  FechaDevolucion DATE NOT NULL,
  SocioID INT NOT NULL,
  ISBN VARCHAR(17) NOT NULL,
  PRIMARY KEY (SocioID, ISBN),
  FOREIGN KEY (SocioID) REFERENCES Socios(SocioID),
  FOREIGN KEY (ISBN) REFERENCES Libros(ISBN)
);

CREATE TABLE Socio_Telefono
(
  Telefono VARCHAR(15) NOT NULL,
  SocioID INT NOT NULL,
  PRIMARY KEY (Telefono, SocioID),
  FOREIGN KEY (SocioID) REFERENCES Socios(SocioID)
);

CREATE TABLE Libro_Autor
(
  Autor VARCHAR(50) NOT NULL,
  ISBN VARCHAR(17) NOT NULL,
  PRIMARY KEY (Autor, ISBN),
  FOREIGN KEY (ISBN) REFERENCES Libros(ISBN)
);