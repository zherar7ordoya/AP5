USE PIO;

GO

SELECT *
FROM [Orden Detalles]
WHERE OrdenID = 95
ORDER BY ProductoID;

GO

DELETE FROM [Orden Detalles]
WHERE Id = 5003;