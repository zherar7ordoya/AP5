USE TPN2a

GO

SELECT * FROM Socio INNER JOIN Pais ON Socio.Id_Pais = Pais.Id_Pais

GO

UPDATE Socio
SET Id_Pais = 1
WHERE Socio.Id_Pais = 2

GO

SELECT * FROM Socio INNER JOIN Pais ON Socio.Id_Pais = Pais.Id_Pais