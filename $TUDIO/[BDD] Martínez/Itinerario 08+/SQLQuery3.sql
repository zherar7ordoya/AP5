USE DB_Temporal

GO

--Listado de socios con los deportes que practican, días y horarios

SELECT socios.apellido, socios.nombre, deportes.nombre,  practicas.dia, practicas.hora
FROM socios, deportes, practicas
WHERE socios.cod_socio = practicas.cod_socio AND deportes.cod_deporte = practicas.cod_deporte
ORDER BY socios.apellido;