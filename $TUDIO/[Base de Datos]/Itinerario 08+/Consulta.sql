-- tables
-- Table: CATEGORIAS
CREATE TABLE CATEGORIAS (
    cod_cat int  NOT NULL,
    nombre varchar(25)  NOT NULL,
    CONSTRAINT CATEGORIAS_pk PRIMARY KEY  (cod_cat)
);

-- Table: CUOTAS
CREATE TABLE CUOTAS (
    num_cuota int  NOT NULL,
    valor_cuota int  NOT NULL,
    fecha date  NOT NULL,
    cod_socio int  NOT NULL,
    CONSTRAINT CUOTAS_pk PRIMARY KEY  (num_cuota,cod_socio)
);

-- Table: DEPORTES
CREATE TABLE DEPORTES (
    cod_deporte int  NOT NULL,
    nombre varchar(25)  NOT NULL,
    arancel int  NOT NULL,
    CONSTRAINT DEPORTES_pk PRIMARY KEY  (cod_deporte)
);

-- Table: PRACTICAS
CREATE TABLE PRACTICAS (
    dia int  NOT NULL,
    hora int  NOT NULL,
    cod_socio int  NOT NULL,
    cod_deporte int  NOT NULL,
    CONSTRAINT PRACTICAS_pk PRIMARY KEY  (cod_socio,cod_deporte)
);

-- Table: PROFESORES
CREATE TABLE PROFESORES (
    cod_profesor int  NOT NULL,
    nombre varchar(25)  NOT NULL,
    apellido varchar(25)  NOT NULL,
    cod_deporte int  NOT NULL,
    CONSTRAINT PROFESORES_pk PRIMARY KEY  (cod_profesor)
);

-- Table: SOCIOS
CREATE TABLE SOCIOS (
    cod_socio int  NOT NULL,
    apellido varchar(25)  NOT NULL,
    nombre varchar(25)  NOT NULL,
    cod_cat int  NOT NULL,
    CONSTRAINT SOCIOS_pk PRIMARY KEY  (cod_socio)
);

-- foreign keys
-- Reference: FK_0 (table: SOCIOS)
ALTER TABLE SOCIOS ADD CONSTRAINT FK_0
    FOREIGN KEY (cod_cat)
    REFERENCES CATEGORIAS (cod_cat);

-- Reference: FK_1 (table: PROFESORES)
ALTER TABLE PROFESORES ADD CONSTRAINT FK_1
    FOREIGN KEY (cod_deporte)
    REFERENCES DEPORTES (cod_deporte);

-- Reference: FK_2 (table: CUOTAS)
ALTER TABLE CUOTAS ADD CONSTRAINT FK_2
    FOREIGN KEY (cod_socio)
    REFERENCES SOCIOS (cod_socio);

-- Reference: FK_3 (table: PRACTICAS)
ALTER TABLE PRACTICAS ADD CONSTRAINT FK_3
    FOREIGN KEY (cod_socio)
    REFERENCES SOCIOS (cod_socio);

-- Reference: FK_4 (table: PRACTICAS)
ALTER TABLE PRACTICAS ADD CONSTRAINT FK_4
    FOREIGN KEY (cod_deporte)
    REFERENCES DEPORTES (cod_deporte);

-- End of file.

