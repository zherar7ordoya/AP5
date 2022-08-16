USE DB_Temporal

GO

SELECT socios.cod_socio, socios.apellido, 
SUM(valor_cuota) 
AS  [pago 2005]
FROM socios, cuotas
WHERE socios.cod_socio = cuotas.cod_socio
GROUP BY socios.cod_socio, socios.apellido;