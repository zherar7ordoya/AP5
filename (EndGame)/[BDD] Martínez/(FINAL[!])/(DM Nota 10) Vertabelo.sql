CREATE TABLE Persona
(
  DNI INT NOT NULL,
  Nombre INT NOT NULL,
  Apellido INT NOT NULL,
  Calle INT NOT NULL,
  Nro INT NOT NULL,
  PRIMARY KEY (DNI)
);

CREATE TABLE Cliente
(
  Código INT NOT NULL,
  DNI INT NOT NULL,
  PRIMARY KEY (DNI),
  FOREIGN KEY (DNI) REFERENCES Persona(DNI),
  UNIQUE (Código)
);

CREATE TABLE Invitado
(
  Número INT NOT NULL,
  DNI INT NOT NULL,
  PRIMARY KEY (DNI),
  FOREIGN KEY (DNI) REFERENCES Persona(DNI),
  UNIQUE (Número)
);

CREATE TABLE Oferta
(
  Código INT NOT NULL,
  Detalle INT NOT NULL,
  Vigencia INT NOT NULL,
  PRIMARY KEY (Código)
);

CREATE TABLE Ticket
(
  Código INT NOT NULL,
  Importe INT NOT NULL,
  Factura INT NOT NULL,
  PRIMARY KEY (Código)
);

CREATE TABLE Punto
(
  Código INT NOT NULL,
  PRIMARY KEY (Código)
);

CREATE TABLE Reserva
(
  Código INT NOT NULL,
  PRIMARY KEY (Código)
);

CREATE TABLE Historial
(
  Código INT NOT NULL,
  PRIMARY KEY (Código)
);

CREATE TABLE Vuelo
(
  NroVuelo INT NOT NULL,
  Origen INT NOT NULL,
  Destino INT NOT NULL,
  Matrícula INT NOT NULL,
  Fecha INT NOT NULL,
  Aerolínea INT NOT NULL,
  Hora INT NOT NULL,
  Cupo INT NOT NULL,
  PRIMARY KEY (NroVuelo)
);

CREATE TABLE Nacional
(
  CódProvincia INT NOT NULL,
  Provincia INT NOT NULL,
  NroVuelo INT NOT NULL,
  PRIMARY KEY (NroVuelo),
  FOREIGN KEY (NroVuelo) REFERENCES Vuelo(NroVuelo),
  UNIQUE (CódProvincia)
);

CREATE TABLE Internacional
(
  CódPaís INT NOT NULL,
  País INT NOT NULL,
  NroVuelo INT NOT NULL,
  PRIMARY KEY (NroVuelo),
  FOREIGN KEY (NroVuelo) REFERENCES Vuelo(NroVuelo),
  UNIQUE (CódPaís)
);

CREATE TABLE Persona_Teléfono
(
  Teléfono INT NOT NULL,
  DNI INT NOT NULL,
  PRIMARY KEY (Teléfono, DNI),
  FOREIGN KEY (DNI) REFERENCES Persona(DNI)
);

CREATE TABLE Persona_Correo
(
  Correo INT NOT NULL,
  DNI INT NOT NULL,
  PRIMARY KEY (Correo, DNI),
  FOREIGN KEY (DNI) REFERENCES Persona(DNI)
);