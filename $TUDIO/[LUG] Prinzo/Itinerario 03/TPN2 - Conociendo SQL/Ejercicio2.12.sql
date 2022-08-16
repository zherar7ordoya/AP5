USE TPN2a

GO

SELECT Id_Pais, COUNT(Id_Socio) AS CantidadSocios
FROM Socio
GROUP BY Id_Pais
ORDER BY Id_Pais ASC

