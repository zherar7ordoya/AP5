USE TPN2b

GO

SELECT Jugadores.Nombre 
AS 'Jugadores de Ajedrez'
FROM Jugadores 
INNER JOIN Juego
ON Jugadores.Cod_Jugador = Juego.Cod_Jugador
WHERE Juego.Cod_Juego = 1

GO

SELECT Jugadores.Nombre
AS 'Jugadores de Truco'
FROM Jugadores 
INNER JOIN Juego
ON Jugadores.Cod_Jugador = Juego.Cod_Jugador
WHERE Juego.Cod_Juego = 2

GO

SELECT Jugadores.Nombre
AS 'Jugadores de Jenga'
FROM Jugadores 
INNER JOIN Juego
ON Jugadores.Cod_Jugador = Juego.Cod_Jugador
WHERE Juego.Cod_Juego = 3