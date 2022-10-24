-- =========================================================================
-- Author:      Gerardo Tordoya
-- Create date: 2022-10-23
-- Description: Script (preliminar) generado por el modelo lógico de ERDPlus
-- =========================================================================

CREATE TABLE Premios
(
    PremioID INT NOT NULL,
    PuestoNumero INT NOT NULL,
    PuestoNombre VARCHAR(50) NOT NULL,
    PremioMonto NUMERIC NOT NULL,
    PremioPorcentaje NUMERIC NOT NULL,
    PRIMARY KEY (PremioID)
);

CREATE TABLE Campeonatos
(
    CampeonatoID INT NOT NULL,
    Nombre VARCHAR(200) NOT NULL,
    Tarifa NUMERIC NOT NULL,
    Activo INT NOT NULL,
    PRIMARY KEY (CampeonatoID)
);

CREATE TABLE Equipos
(
    Nombre VARCHAR(100) NOT NULL,
    EquipoID INT NOT NULL,
    PRIMARY KEY (EquipoID)
);

CREATE TABLE Partidos
(
    PartidoID INT NOT NULL,
    Ronda INT NOT NULL,
    CampeonatoID INT NOT NULL,
    GanadorID INT,
    PRIMARY KEY (PartidoID),
    FOREIGN KEY (CampeonatoID) REFERENCES Campeonatos(CampeonatoID),
    FOREIGN KEY (GanadorID) REFERENCES Equipos(EquipoID)
);

CREATE TABLE Personas
(
    PersonaID INT NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Celular VARCHAR(20),
    PRIMARY KEY (PersonaID)
);

CREATE TABLE CampeonatoPremios
(
    CampeonatoPremioID INT NOT NULL,
    CampeonatoID INT NOT NULL,
    PremioID INT NOT NULL,
    PRIMARY KEY (CampeonatoPremioID),
    FOREIGN KEY (CampeonatoID) REFERENCES Campeonatos(CampeonatoID),
    FOREIGN KEY (PremioID) REFERENCES Premios(PremioID),
);

CREATE TABLE CampeonatoParticipantes
(
    CampeonatoParticipanteID INT NOT NULL,
    CampeonatoID INT NOT NULL,
    EquipoID INT NOT NULL,
    PRIMARY KEY (CampeonatoParticipanteID),
    FOREIGN KEY (CampeonatoID) REFERENCES Campeonatos(CampeonatoID),
    FOREIGN KEY (EquipoID) REFERENCES Equipos(EquipoID),
);

CREATE TABLE PartidoJugadores
(
    PartidoJugadorID INT NOT NULL,
    Puntaje INT,
    PartidoActualID INT NOT NULL,
    PartidoAnteriorID INT,
    EquipoID INT,
    PRIMARY KEY (PartidoJugadorID),
    FOREIGN KEY (PartidoActualID) REFERENCES Partidos(PartidoID),
    FOREIGN KEY (PartidoAnteriorID) REFERENCES Partidos(PartidoID),
    FOREIGN KEY (EquipoID) REFERENCES Equipos(EquipoID),
);

CREATE TABLE EquipoMiembros
(
    EquipoMiembroID INT NOT NULL,
    PersonaID INT NOT NULL,
    EquipoID INT NOT NULL,
    PRIMARY KEY (EquipoMiembroID),
    FOREIGN KEY (PersonaID) REFERENCES Personas(PersonaID),
    FOREIGN KEY (EquipoID) REFERENCES Equipos(EquipoID),
);
