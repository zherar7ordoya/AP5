USE Parcial2_BBDD

GO

SELECT Libros.titulo						 AS Libro,
       COUNT(Libros_Devoluciones.dni_lector) AS Devoluciones
FROM Libros
    INNER JOIN Autores
        ON Libros.cod_autor = Autores.cod_autor
    INNER JOIN Libros_Devoluciones
        ON Libros.cod_libro = Libros_Devoluciones.cod_libro
GROUP BY titulo
ORDER BY Devoluciones DESC
