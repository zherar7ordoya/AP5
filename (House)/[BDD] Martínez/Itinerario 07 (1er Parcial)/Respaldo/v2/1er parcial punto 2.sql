CREATE TABLE Socios
(
  socioID INT NOT NULL,
  apellidos VARCHAR(25) NOT NULL,
  nombres VARCHAR(25) NOT NULL,
  dni INT NOT NULL,
  calle VARCHAR(25) NOT NULL,
  numero INT NOT NULL,
  PRIMARY KEY (socioID)
);

CREATE TABLE Libros
(
  titulo VARCHAR(50) NOT NULL,
  year_escritura INT NOT NULL,
  libroID INT NOT NULL,
  PRIMARY KEY (libroID)
);

CREATE TABLE Ediciones
(
  year_edicion INT NOT NULL,
  isbn VARCHAR(17) NOT NULL,
  editorial VARCHAR(50) NOT NULL,
  libroID INT NOT NULL,
  PRIMARY KEY (isbn),
  FOREIGN KEY (libroID) REFERENCES Libros(libroID)
);

CREATE TABLE Socio_Telefono
(
  telefono VARCHAR(17) NOT NULL,
  socioID INT NOT NULL,
  PRIMARY KEY (telefono, socioID),
  FOREIGN KEY (socioID) REFERENCES Socios(socioID)
);

CREATE TABLE Libro_Autor
(
  autor VARCHAR(50) NOT NULL,
  libroID INT NOT NULL,
  PRIMARY KEY (autor, libroID),
  FOREIGN KEY (libroID) REFERENCES Libros(libroID)
);

CREATE TABLE Volumenes
(
  numero INT NOT NULL,
  deteriorado INT NOT NULL,
  volumenID INT NOT NULL,
  isbn VARCHAR(17) NOT NULL,
  PRIMARY KEY (volumenID),
  FOREIGN KEY (isbn) REFERENCES Ediciones(isbn)
);

CREATE TABLE Prestamos
(
  fecha_prestamo DATE NOT NULL,
  fecha_tope DATE NOT NULL,
  fecha_devolucion DATE NOT NULL,
  prestamoID INT NOT NULL,
  socioID INT NOT NULL,
  volumenID INT NOT NULL,
  PRIMARY KEY (prestamoID),
  FOREIGN KEY (socioID) REFERENCES Socios(socioID),
  FOREIGN KEY (volumenID) REFERENCES Volumenes(volumenID),
  UNIQUE (socioID, volumenID)
);