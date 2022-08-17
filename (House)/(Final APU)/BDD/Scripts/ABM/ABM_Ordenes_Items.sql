--AYUDA-MEMORIA:
--Students => Ordenes (Pedidos)
--Courses  => Items   (Productos)

USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_Ordenes_Items
    --Ordenes
	@Legajo         INTEGER,
	@Fecha          DATE,
	@Estado         CHAR(10),
	--Items
	@CategoriaID    CHAR(4),
	@Nombre         VARCHAR(MAX),
	@PrecioUnitario DECIMAL(9, 2),
	@ProveedorID    CHAR(4),
	--Ordenes_Items
	@Id             INTEGER,
    @OrdenID        INTEGER,
    @ItemID         INTEGER,
    @Cantidad       INTEGER,
	--Procedimiento Almacenado
    @Instruccion    CHAR(6)
AS
BEGIN

    DECLARE @ID_ORDEN int
    DECLARE @ID_ITEM int

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ALTAS
	--NOTA:
	--Sin calibrar. El uso pensado es dar de alta una orden y agregar ítems
	--a una orden. No se han hecho más pruebas.
	--Parámetros necesarios: creo que todos.

    IF @Instruccion = 'Insert'
    BEGIN

	    --Busco por empleado que pide (por el momento, hasta mejorar el diseño).
        SELECT @ID_ORDEN = OrdenID
	    FROM Ordenes
	    WHERE Legajo = @Legajo

	    --Busco por nombre del producto (por el momento, hasta mejorar el diseño).
	    SELECT @ID_ITEM = ItemID
	    FROM Items
	    WHERE Nombre = @Nombre

        IF (@ID_ORDEN IS NULL)
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
            SELECT @ID_ORDEN = SCOPE_IDENTITY()
        END

        IF (@ID_ITEM IS NULL)
        BEGIN
            INSERT INTO Items
			(
			    CategoriaID,
				Nombre,
				PrecioUnitario,
				ProveedorID
			)
		    VALUES
			(
			    @CategoriaID,
				@Nombre,
				@PrecioUnitario,
				@ProveedorID
			)
            SELECT @ID_ITEM = SCOPE_IDENTITY()
        END

	    INSERT INTO Ordenes_Items
        VALUES (@ID_ORDEN, @ID_ITEM, @Cantidad)

    END

    --||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BAJAS
	--USO: 
	--Las tablas son de órdenes y sus ítems.
	--Si deseo borrar la órden completa, proveo su ID.
	--POR EL MOMENTO, ES TODA LA OPERACIÓN QUE SE HARÁ.
	--EN UN FUTURO, SE PODRÍA AJUSTAR PARA QUE:
	--Si no deseo borrar la órden, Id = 0
	--Si deseo borrar un ítem de la orden, proveo su ID.
	--Si no deseo borrar un ítem, Id = 0
	--Parámetros necesarios: ID de la órden.

    IF @Instruccion = 'Delete'
    BEGIN
        DELETE FROM Ordenes
        WHERE OrdenID = @OrdenID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MODIFICACIONES
    --NOTA:
	--Update, por el momento, pienso que solo puede ser utilizado
	--para cambiar, por ejemplo, la cantidad de artículos pedida.
	--Parámetros necesarios: ID del ítem.

	IF @Instruccion = 'Update'
    BEGIN
        UPDATE Ordenes_Items
        SET Cantidad = @Cantidad
        WHERE OrdenID = @OrdenID AND ItemID = @ItemID
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LISTADOS
	--Por el momento (incluso creo que esta sección es un "huevo de pascua")
	--la operación de listado implica a los ítems de una órden.
	--Parámetros necesarios: ID de la órden.
	
	IF @Instruccion = 'Select'
    BEGIN
        SELECT Legajo,
               Fecha,
			   Estado,
			   Nombre,
			   Descripcion,
			   PrecioUnitario
        FROM Items
            JOIN Ordenes_Items 
			ON Ordenes_Items.ItemID  = Items.ItemID
            JOIN Ordenes
			ON Ordenes_Items.OrdenID = Ordenes.OrdenID
        WHERE Ordenes.OrdenID = @OrdenID
    END

END