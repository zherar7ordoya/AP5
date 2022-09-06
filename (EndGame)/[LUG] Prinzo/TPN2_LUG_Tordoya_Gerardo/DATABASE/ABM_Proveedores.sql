USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Proveedores
(
    @ProveedorID CHAR(4),
	@Nombre      VARCHAR(50),
    @Instruccion CHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Proveedores
        (
	        ProveedorID,
			Nombre
        )
        VALUES
        (
	        @ProveedorID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Proveedores
        WHERE ProveedorID = @ProveedorID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Proveedores
        SET    Nombre      = @Nombre
        WHERE  ProveedorID = @ProveedorID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Proveedores
    END

END