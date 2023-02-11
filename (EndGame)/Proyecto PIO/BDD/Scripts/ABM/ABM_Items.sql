USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Items
(
    @ItemID         INTEGER,
    @CategoriaID    CHAR(4),
	@Nombre         VARCHAR(MAX),
	@Descripcion    VARCHAR(MAX),
	@PrecioUnitario DECIMAL(9, 2),
	@ProveedorID    CHAR(4),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Items
        (
            CategoriaID,
	        Nombre,
	        Descripcion,
	        PrecioUnitario,
	        ProveedorID
        )
        VALUES
        (
            @CategoriaID,
	        @Nombre,
	        @Descripcion,
	        @PrecioUnitario,
	        @ProveedorID
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Items
        WHERE ItemID = @ItemID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Items
        SET    CategoriaID    = @CategoriaID,
	           Nombre         = @Nombre,
	           Descripcion    = @Descripcion,
	           PrecioUnitario = @PrecioUnitario,
	           ProveedorID    = @ProveedorID
        WHERE  ItemID         = @ItemID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Items
    END

END