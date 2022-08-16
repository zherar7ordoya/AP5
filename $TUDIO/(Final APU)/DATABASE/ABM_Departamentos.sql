USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Departamentos
(
    @DepartamentoID CHAR(4),
    @Nombre         VARCHAR(50),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Departamentos
        (
            DepartamentoID,
            Nombre
        )
        VALUES
        (
		    @DepartamentoID,
			@Nombre
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Departamentos
        WHERE DepartamentoID = @DepartamentoID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Departamentos
        SET   Nombre      = @Nombre
        WHERE DepartamentoID = @DepartamentoID
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Departamentos
    END

END