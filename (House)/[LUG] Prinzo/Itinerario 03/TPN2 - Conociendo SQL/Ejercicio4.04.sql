USE TPN2b

GO

SELECT COUNT(*) AS 'Cuenta de Jugadores'
FROM Juego
INNER JOIN Jugadores
ON Juego.Cod_Jugador = Jugadores.Cod_Jugador
INNER JOIN Bando
ON Jugadores.Cod_Bando = Bando.Cod_Bando
WHERE Juego.Nombre = 'Jenga'

GO

SELECT COUNT(*) AS 'Cuenta de Bando'
FROM Juego
INNER JOIN Jugadores
ON Juego.Cod_Jugador = Jugadores.Cod_Jugador
INNER JOIN Bando
ON Jugadores.Cod_Bando = Bando.Cod_Bando
WHERE Bando.Nombre = 'Rojo'