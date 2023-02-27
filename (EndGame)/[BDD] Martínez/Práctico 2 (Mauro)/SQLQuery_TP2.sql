CREATE DATABASE pacientes;
use pacientes;

create table paciente(
	codpac int identity(1,1) not null,
	nombre varchar(50) not null,
	calle varchar(50) null,
	altura int null,
	piso int null,
	dpto varchar(10),
	primary key(codpac)
);

create table paciente_telefono(
	codpac int not null,
	telefono bigint not null,
	foreign key(codpac) references paciente(codpac)
);

create table paciente_diagnostico(
	coddiag int identity(1,1) not null,
	codpac int not null,
	observacion varchar(100) not null,
	primary key(coddiag),
	foreign key(codpac) references paciente(codpac)
);

create table especialidad(
	cod_especialidad int not null,
	descrip varchar(100),
	primary key(cod_especialidad)
);

create table centro_salud(
	codcentro int not null,
	nombre varchar(50) null,
	primary key(codcentro)
);
create table medico(
	codmed int identity(1,1) not null,
	nombre varchar(20) unique null,
	cod_especialidad int not null,
	codcentro int null,
	primary key(codmed),
	foreign key(cod_especialidad) references especialidad(cod_especialidad),
	foreign key(codcentro) references centro_salud(codcentro)
);
create table paciente_medico(
	codmed int not null,
	codpac int not null,
	fecha date check(fecha<CURRENT_TIMESTAMP) not null,
	foreign key(codmed) references medico(codmed),
	foreign key(codpac) references paciente(codpac)
);


--DATOS PACIENTES
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Mauro', 'Iriondo', 310, 1, 'A');
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Carlos', 'Castellanos', 580, 2, '2do');
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Camila', 'Tucuman', 30, 1, 'A');
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Romina', 'Salta', 574, 2, '2do');
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Federico', 'Bv. Oroño', 3710, 1, 'A');
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Ana', 'Cordóba', 80, 2, '2do');
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Zoe', 'Santa Fe', 3710, 1, 'A');
insert into paciente([nombre], [calle], [altura], [piso], [dpto]) values ('Hector', 'Pje. Loustoj', 1280, 2, '2do');
insert into paciente([nombre], [calle], [altura], [piso]) values ('Camila', 'Catamarca', 281, 2);

select *
from paciente;

--DATOS PACIENTE TELEFONO
insert into paciente_telefono([codpac], [telefono]) values (1, 341574536);
insert into paciente_telefono([codpac], [telefono]) values (2, 34157457469);
insert into paciente_telefono([codpac], [telefono]) values (3, 3412714726);
insert into paciente_telefono([codpac], [telefono]) values (4, 3411125120);
insert into paciente_telefono([codpac], [telefono]) values (5, 3411125636);
insert into paciente_telefono([codpac], [telefono]) values (6, 3412452369);
insert into paciente_telefono([codpac], [telefono]) values (7, 3411125120);
insert into paciente_telefono([codpac], [telefono]) values (8, 3411125636);
insert into paciente_telefono([codpac], [telefono]) values (9, 3412451268);

select *
from paciente_telefono;

--PACIENTE DIAGNOSTICO
insert into paciente_diagnostico([codpac],[observacion] ) values (1,'Se realizan estudios en el corazón');
insert into paciente_diagnostico([codpac],[observacion] ) values (2,'Se receta análisis de sangre');
insert into paciente_diagnostico([codpac],[observacion] ) values (3,'Paciente con dolor músculares');
insert into paciente_diagnostico([codpac],[observacion] ) values (4,'Paciente con ansiedad');
insert into paciente_diagnostico([codpac],[observacion] ) values (5,'Paciente con sobre peso');
insert into paciente_diagnostico([codpac],[observacion] ) values (6,'Paciente con problemas renales');
insert into paciente_diagnostico([codpac],[observacion] ) values (7,'No se detectan síntomas. Paciente con hipocondría');
insert into paciente_diagnostico([codpac],[observacion] ) values (8,'Posible caso de covid, paciente se hisopa');
insert into paciente_diagnostico([codpac],[observacion] ) values (9,'Paciente con perdida de sentido, se deriva a traumatología');

select *
from paciente_diagnostico;

--DATOS ESPECIALIDAD
insert into especialidad([cod_especialidad],[descrip]) values (21,'Análisis Clínicos');
insert into especialidad([cod_especialidad],[descrip]) values (32,'Neurología');
insert into especialidad([cod_especialidad],[descrip]) values (40,'Odontología');
insert into especialidad([cod_especialidad],[descrip]) values (50,'Oftalmotología');
insert into especialidad([cod_especialidad],[descrip]) values (60,'Pediatría');
insert into especialidad([cod_especialidad],[descrip]) values (5,'Traumotología');
insert into especialidad([cod_especialidad],[descrip]) values (10,'Cardiología');

select *
from especialidad;

--DATOS CENTRO SALUD
insert into centro_salud([codcentro],[nombre]) values (1, 'Centro');
insert into centro_salud([codcentro],[nombre]) values (3, 'Recoleta');
insert into centro_salud([codcentro],[nombre]) values (5, 'Quilmes');
insert into centro_salud([codcentro],[nombre]) values (4, 'Palermo');
insert into centro_salud([codcentro],[nombre]) values (10, 'Almargo');
insert into centro_salud([codcentro],[nombre]) values (14, 'Flores');

select *
from centro_salud;

--DATOS MEDICO
insert into medico([nombre], [cod_especialidad], [codcentro]) values ('Marcela', 21, 1);
insert into medico([nombre], [cod_especialidad], [codcentro]) values ('Ricardo', 40, 5);
insert into medico([nombre], [cod_especialidad], [codcentro]) values ('Mauro', 32, 3);
insert into medico([nombre], [cod_especialidad], [codcentro]) values ('Ana Laura', 10, 1);
insert into medico([nombre], [cod_especialidad], [codcentro]) values ('Juan', 5, 10);
insert into medico([nombre], [cod_especialidad], [codcentro]) values ('Roberto', 10, 14);
insert into medico([nombre], [cod_especialidad], [codcentro]) values ('Micaela', 50, 4);

select *
from medico;

--DATOS PACIENTE_MEDICO
insert into paciente_medico([codmed], [codpac], [fecha]) values (5, 3, '2021-06-23');
insert into paciente_medico([codmed], [codpac], [fecha]) values (7, 4, '2021-11-03');
insert into paciente_medico([codmed], [codpac], [fecha]) values (6,4,'2021-04-27');
insert into paciente_medico([codmed], [codpac], [fecha]) values (5,2,'2021-02-20');
insert into paciente_medico([codmed], [codpac], [fecha]) values (2,1,'2021-03-15');
insert into paciente_medico([codmed], [codpac], [fecha]) values (3,5,'2021-05-05');
insert into paciente_medico([codmed], [codpac], [fecha]) values (1,7,'2021-07-23');
insert into paciente_medico([codmed], [codpac], [fecha]) values (3,6,'2021-10-17');
insert into paciente_medico([codmed], [codpac], [fecha]) values (1,8,'2021-01-06');
insert into paciente_medico([codmed], [codpac], [fecha]) values (4,9,'2021-01-06');
insert into paciente_medico([codmed], [codpac], [fecha]) values (2,4,'2021-11-10'); /*NO CARGA, respetando la validación*/

select *
from paciente_medico;

Select p.nombre as Paciente, m.nombre as Doc, e.descrip as Especialidad, pd.observacion as Diagnostico
from paciente p
inner join paciente_medico pm on p.codpac = pm.codpac
inner join medico m on m.codmed = pm.codmed
inner join especialidad e on m.cod_especialidad = e.cod_especialidad
inner join paciente_diagnostico pd on p.codpac = pd.codpac;

select m.nombre as Doc, e.descrip
from medico m
inner join especialidad e on m.cod_especialidad = e.cod_especialidad
where m.cod_especialidad = 10;