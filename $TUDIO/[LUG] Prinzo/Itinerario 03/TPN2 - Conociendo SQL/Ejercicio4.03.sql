USE TPN2b

GO

-- Consulta que trae solo los registros de un determinado juego.

SELECT Juego.Nombre AS Juego, Bando.Nombre AS Bando
FROM Juego
INNER JOIN Jugadores
ON Juego.Cod_Jugador = Jugadores.Cod_Jugador
INNER JOIN Bando
ON Jugadores.Cod_Bando = Bando.Cod_Bando
WHERE Juego.Cod_Juego = 1; --COD. DE JUEGO