USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Roles
(
    @RolID       CHAR(4),
	@Nombre      VARCHAR(50),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Roles
        (
	        RolID,
			Nombre
        )
        VALUES
        (
	        @RolID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Roles
        WHERE RolID = @RolID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Roles
        SET    Nombre = @Nombre
        WHERE  RolID  = @RolID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Roles
    END

END