USE Parcial2_BBDD

GO

SELECT Libros.titulo								AS Libro,
       Autores.nombre + ' ' + Autores.apellido		AS Autor,
       Lectores.nombre + ' ' + Lectores.apellido	AS Lector,
       Libros_Devoluciones.fecha_devolucion			AS Devuelto
FROM Libros
    INNER JOIN Autores
        ON Libros.cod_autor = Autores.cod_autor
    INNER JOIN Libros_Devoluciones
        ON Libros.cod_libro = Libros_Devoluciones.cod_libro
    INNER JOIN Lectores
        ON Lectores.dni_lector = Libros_Devoluciones.dni_lector
