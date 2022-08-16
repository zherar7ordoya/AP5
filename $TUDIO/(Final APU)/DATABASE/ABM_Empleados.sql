USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE Login
(
    @Legajo         INTEGER,
    @Nombre         VARCHAR(50),
	@Apellido       VARCHAR(50),
	@Usuario        VARCHAR(50),
	@Contraseña     VARCHAR(50),
	@DepartamentoID CHAR(4),
	@RolID          CHAR(4),
    @Instruccion    NVARCHAR(6)
)
AS
BEGIN
    
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS

	IF @Instruccion = 'Insert'
    BEGIN
        INSERT INTO Empleados
        (
            Legajo,
            Nombre,
	        Apellido,
	        Usuario,
	        Contraseña,
	        DepartamentoID,
	        RolID
        )
        VALUES
        (
		    @Legajo,
            @Nombre,
	        @Apellido,
	        @Usuario,
	        @Contraseña,
	        @DepartamentoID,
	        @RolID
		)
    END
	
	--||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Empleados
        WHERE Legajo = @Legajo
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES

    IF @Instruccion = 'Update'
    BEGIN
        UPDATE Empleados
        SET    Nombre         = @Nombre,
	           Apellido       = @Apellido,
	           Usuario        = @Usuario,
	           Contraseña     = @Contraseña,
	           DepartamentoID = @DepartamentoID,
	           RolID          = @RolID
        WHERE Legajo          = @Legajo
    END
	
	--|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS

    IF @Instruccion = 'Select'
    BEGIN
        SELECT *
        FROM Empleados
    END

END