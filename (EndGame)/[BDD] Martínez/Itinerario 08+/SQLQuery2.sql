USE DB_Temporal

GO

--Listado de socios y sus cuotas pagas

SELECT socios.cod_socio, socios.apellido, cuotas.num_cuota,  cuotas.fecha
FROM socios, cuotas
WHERE socios.cod_socio = cuotas.cod_socio
ORDER BY socios.cod_socio, cuotas.num_cuota;