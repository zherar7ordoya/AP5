USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE Login
(
	@Usuario        VARCHAR(50),
	@Contraseña     VARCHAR(50)
)

AS
BEGIN
	SELECT COUNT(*) FROM Empleados WHERE Usuario = @Usuario AND Contraseña = @Contraseña
END