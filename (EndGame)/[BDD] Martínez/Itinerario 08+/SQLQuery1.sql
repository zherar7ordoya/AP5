USE DB_Temporal

GO

--Listado de socios por categoría

SELECT socios.nombre, socios.apellido, categorias.nombre
FROM socios, categorias
WHERE socios.cod_cat = categorias.cod_cat
ORDER BY categorias.nombre;