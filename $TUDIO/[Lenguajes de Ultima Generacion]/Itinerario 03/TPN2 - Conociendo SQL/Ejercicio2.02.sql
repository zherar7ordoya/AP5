USE TPN2a

GO

SELECT Id_socio, Nombre, Email  FROM Socio
WHERE Socio.Id_Provincia = 1;