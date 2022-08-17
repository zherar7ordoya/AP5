USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Categorias
(
    @CategoriaID CHAR(4),
    @Nombre      VARCHAR(50),
    @Descripcion VARCHAR(MAX),
    @Instruccion NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Categorias
        (
            CategoriaID,
            Nombre,
            Descripcion
        )
        VALUES
        (
		    @CategoriaID,
			@Nombre,
			@Descripcion
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Categorias
        WHERE CategoriaID = @CategoriaID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Categorias
        SET   Nombre      = @Nombre,
              Descripcion = @Descripcion
        WHERE CategoriaID = @CategoriaID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Categorias
    END

END