--¿Hace falta?

USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Ordenes
(
    @OrdenID     INTEGER,
    @Legajo      INTEGER,
	@Fecha       DATE,
	@Estado      CHAR(10),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Ordenes
        (
            Legajo,
	        Fecha,
	        Estado
        )
        VALUES
        (
            @Legajo,
	        @Fecha,
	        @Estado
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Ordenes
        SET    Legajo  = @Legajo,
	           Fecha   = @Fecha,
	           Estado  = @Estado
        WHERE  OrdenID = @OrdenID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Ordenes
    END

END