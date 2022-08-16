-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2022-05-09 03:48:10.092

USE Cuestionarios

GO

-- tables
-- Table: BLOQUES
CREATE TABLE BLOQUES (
    id_bloque int  NOT NULL IDENTITY,
    id_cuestionario int  NOT NULL,
    numero int  NOT NULL,
    titulo text  NOT NULL,
    CONSTRAINT BLOQUES_ak UNIQUE (numero, id_cuestionario),
    CONSTRAINT BLOQUES_pk PRIMARY KEY  (id_bloque)
);

CREATE INDEX BLOQUES_idx on BLOQUES (id_cuestionario ASC)
;

-- Table: COLECTIVOS
CREATE TABLE COLECTIVOS (
    id_colectivo int  NOT NULL IDENTITY,
    colectivo varchar(50)  NOT NULL,
    CONSTRAINT COLECTIVOS_pk PRIMARY KEY  (id_colectivo)
);

-- Table: CUESTIONARIOS
CREATE TABLE CUESTIONARIOS (
    id_cuestionario int  NOT NULL IDENTITY,
    titulo text  NOT NULL,
    descripcion text  NOT NULL,
    fecha_fin timestamp  NOT NULL,
    colectivo varchar(50)  NOT NULL,
    CONSTRAINT CUESTIONARIOS_pk PRIMARY KEY  (id_cuestionario)
);

-- Table: PREGUNTAS
CREATE TABLE PREGUNTAS (
    id_pregunta int  NOT NULL IDENTITY,
    id_bloque int  NOT NULL,
    numero int  NOT NULL,
    texto text  NOT NULL,
    CONSTRAINT PREGUNTAS_ak UNIQUE (numero, id_bloque),
    CONSTRAINT PREGUNTAS_pk PRIMARY KEY  (id_pregunta)
);

CREATE INDEX PREGUNTAS_idx on PREGUNTAS (id_bloque ASC)
;

-- Table: RELLENADOS
CREATE TABLE RELLENADOS (
    id_usuario int  NOT NULL,
    id_cuestionario int  NOT NULL,
    CONSTRAINT RELLENADOS_pk PRIMARY KEY  (id_cuestionario,id_usuario)
);

CREATE INDEX RELLENADOS_idx_1 on RELLENADOS (id_usuario ASC)
;

CREATE INDEX RELLENADOS_idx_2 on RELLENADOS (id_cuestionario ASC)
;

-- Table: RESPUESTAS
CREATE TABLE RESPUESTAS (
    id_respuesta int  NOT NULL IDENTITY,
    id_pregunta int  NOT NULL,
    respuesta int  NOT NULL,
    CONSTRAINT RESPUESTAS_pk PRIMARY KEY  (id_respuesta)
);

CREATE INDEX RESPUESTAS_idx on RESPUESTAS (id_pregunta ASC)
;

-- Table: USUARIOS
CREATE TABLE USUARIOS (
    id_usuario int  NOT NULL IDENTITY,
    login varchar(50)  NOT NULL,
    colectivo varchar(50)  NOT NULL,
    CONSTRAINT USUARIOS_ak UNIQUE (login),
    CONSTRAINT login PRIMARY KEY  (id_usuario)
);

-- foreign keys
-- Reference: BLOQUES_CUESTIONARIOS (table: BLOQUES)
ALTER TABLE BLOQUES ADD CONSTRAINT BLOQUES_CUESTIONARIOS
    FOREIGN KEY (id_cuestionario)
    REFERENCES CUESTIONARIOS (id_cuestionario)
    ON DELETE  CASCADE 
    ON UPDATE  CASCADE;

-- Reference: PREGUNTAS_BLOQUES (table: PREGUNTAS)
ALTER TABLE PREGUNTAS ADD CONSTRAINT PREGUNTAS_BLOQUES
    FOREIGN KEY (id_bloque)
    REFERENCES BLOQUES (id_bloque)
    ON DELETE  CASCADE 
    ON UPDATE  CASCADE;

-- Reference: RELLENADOS_CUESTIONARIOS (table: RELLENADOS)
ALTER TABLE RELLENADOS ADD CONSTRAINT RELLENADOS_CUESTIONARIOS
    FOREIGN KEY (id_cuestionario)
    REFERENCES CUESTIONARIOS (id_cuestionario)
    ON DELETE  CASCADE 
    ON UPDATE  CASCADE;

-- Reference: RELLENADOS_USUARIOS (table: RELLENADOS)
ALTER TABLE RELLENADOS ADD CONSTRAINT RELLENADOS_USUARIOS
    FOREIGN KEY (id_usuario)
    REFERENCES USUARIOS (id_usuario)
    ON DELETE  CASCADE 
    ON UPDATE  CASCADE;

-- Reference: RESPUESTAS_PREGUNTAS (table: RESPUESTAS)
ALTER TABLE RESPUESTAS ADD CONSTRAINT RESPUESTAS_PREGUNTAS
    FOREIGN KEY (id_pregunta)
    REFERENCES PREGUNTAS (id_pregunta)
    ON UPDATE  CASCADE;

-- End of file.

