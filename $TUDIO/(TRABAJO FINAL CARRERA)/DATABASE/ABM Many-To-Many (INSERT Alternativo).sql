--INICIA TIJERA. **********************************************************

        INSERT Ordenes (StudentName)
        SELECT DISTINCT @StudentName
        FROM Ordenes
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Ordenes 
			WHERE OrdenID = @OrdenID
        )

        IF @OrdenID = 0
        BEGIN
            SELECT @ID_ORDEN = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @ID_ORDEN = @OrdenID
        END

        INSERT Items (CourseName)
        SELECT DISTINCT @CourseName
        FROM Items
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Items 
			WHERE ItemID = @ItemID
        )

        IF @ItemID = 0
        BEGIN
            SELECT @ID_ITEM = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @ID_ITEM = @ItemID
        END
    --FINALIZA TIJERA. ********************************************************