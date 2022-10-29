-- ===========================================================================
-- Author:      Gerardo Tordoya
-- Create date: 2022-10-23
-- Description: Script (definitivo) generado por el modelo lógico de Vertabelo
-- ===========================================================================


-- ─── CREACIÓN DE TABLAS ──────────────────────────────────────────────────────

-- Table: CampeonatoParticipantes
CREATE TABLE CampeonatoParticipantes (
    CampeonatoParticipanteID int  NOT NULL,
    CampeonatoID int  NOT NULL,
    EquipoID int  NOT NULL,
    CONSTRAINT CampeonatoParticipantes_pk PRIMARY KEY  (CampeonatoParticipanteID)
);

-- Table: CampeonatoPremios
CREATE TABLE CampeonatoPremios (
    CampeonatoPremioID int  NOT NULL,
    CampeonatoID int  NOT NULL,
    PremioID int  NOT NULL,
    CONSTRAINT CampeonatoPremios_pk PRIMARY KEY  (CampeonatoPremioID)
);

-- Table: Campeonatos
CREATE TABLE Campeonatos (
    CampeonatoID int  NOT NULL,
    Nombre nvarchar(200)  NOT NULL,
    Tarifa money  NOT NULL,
    Activo bit  NOT NULL,
    CONSTRAINT Campeonatos_pk PRIMARY KEY  (CampeonatoID)
);

-- Table: EquipoMiembros
CREATE TABLE EquipoMiembros (
    EquipoMiembroID int  NOT NULL,
    PersonaID int  NOT NULL,
    EquipoID int  NOT NULL,
    CONSTRAINT EquipoMiembros_pk PRIMARY KEY  (EquipoMiembroID)
);

-- Table: Equipos
CREATE TABLE Equipos (
    Nombre nvarchar(100)  NOT NULL,
    EquipoID int  NOT NULL,
    CONSTRAINT Equipos_pk PRIMARY KEY  (EquipoID)
);

-- Table: PartidoJugadores
CREATE TABLE PartidoJugadores (
    PartidoJugadorID int  NOT NULL,
    PartidoActualID int  NOT NULL,
    PartidoAnteriorID int  NULL,
    EquipoID int  NULL,
    Puntaje float  NULL,
    CONSTRAINT PartidoJugadores_pk PRIMARY KEY  (PartidoJugadorID)
);

-- Table: Partidos
CREATE TABLE Partidos (
    PartidoID int  NOT NULL,
    Ronda int  NOT NULL,
    CampeonatoID int  NOT NULL,
    GanadorID int  NULL,
    CONSTRAINT Partidos_pk PRIMARY KEY  (PartidoID)
);

-- Table: Personas
CREATE TABLE Personas (
    PersonaID int  NOT NULL,
    Nombre nvarchar(100)  NOT NULL,
    Apellido nvarchar(100)  NOT NULL,
    Email nvarchar(100)  NOT NULL,
    Celular varchar(20)  NULL,
    CONSTRAINT Personas_pk PRIMARY KEY  (PersonaID)
);

-- Table: Premios
CREATE TABLE Premios (
    PremioID int  NOT NULL,
    PuestoNumero int  NOT NULL,
    PuestoNombre nvarchar(50)  NOT NULL,
    PremioMonto money  NOT NULL,
    PremioPorcentaje float  NOT NULL,
    CONSTRAINT Premios_pk PRIMARY KEY  (PremioID)
);


-- ─── CREACIÓN DE RELACIONES ──────────────────────────────────────────────────

-- Reference: FK_0 (table: Partidos)
ALTER TABLE Partidos ADD CONSTRAINT FK_0
    FOREIGN KEY (CampeonatoID)
    REFERENCES Campeonatos (CampeonatoID);

-- Reference: FK_1 (table: Partidos)
ALTER TABLE Partidos ADD CONSTRAINT FK_1
    FOREIGN KEY (GanadorID)
    REFERENCES Equipos (EquipoID);

-- Reference: FK_10 (table: EquipoMiembros)
ALTER TABLE EquipoMiembros ADD CONSTRAINT FK_10
    FOREIGN KEY (EquipoID)
    REFERENCES Equipos (EquipoID);

-- Reference: FK_2 (table: CampeonatoPremios)
ALTER TABLE CampeonatoPremios ADD CONSTRAINT FK_2
    FOREIGN KEY (CampeonatoID)
    REFERENCES Campeonatos (CampeonatoID);

-- Reference: FK_3 (table: CampeonatoPremios)
ALTER TABLE CampeonatoPremios ADD CONSTRAINT FK_3
    FOREIGN KEY (PremioID)
    REFERENCES Premios (PremioID);

-- Reference: FK_4 (table: CampeonatoParticipantes)
ALTER TABLE CampeonatoParticipantes ADD CONSTRAINT FK_4
    FOREIGN KEY (CampeonatoID)
    REFERENCES Campeonatos (CampeonatoID);

-- Reference: FK_5 (table: CampeonatoParticipantes)
ALTER TABLE CampeonatoParticipantes ADD CONSTRAINT FK_5
    FOREIGN KEY (EquipoID)
    REFERENCES Equipos (EquipoID);

-- Reference: FK_6 (table: PartidoJugadores)
ALTER TABLE PartidoJugadores ADD CONSTRAINT FK_6
    FOREIGN KEY (PartidoActualID)
    REFERENCES Partidos (PartidoID);

-- Reference: FK_7 (table: PartidoJugadores)
ALTER TABLE PartidoJugadores ADD CONSTRAINT FK_7
    FOREIGN KEY (PartidoAnteriorID)
    REFERENCES Partidos (PartidoID);

-- Reference: FK_8 (table: PartidoJugadores)
ALTER TABLE PartidoJugadores ADD CONSTRAINT FK_8
    FOREIGN KEY (EquipoID)
    REFERENCES Equipos (EquipoID);

-- Reference: FK_9 (table: EquipoMiembros)
ALTER TABLE EquipoMiembros ADD CONSTRAINT FK_9
    FOREIGN KEY (PersonaID)
    REFERENCES Personas (PersonaID);

-- End of file.
