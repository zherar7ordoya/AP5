USE TPN2b

GO

SELECT Cod_Juego, COUNT(Cod_Jugador) AS 'Jugadores por Juego'
FROM Juego
GROUP BY Cod_Juego
ORDER BY Cod_Juego ASC

