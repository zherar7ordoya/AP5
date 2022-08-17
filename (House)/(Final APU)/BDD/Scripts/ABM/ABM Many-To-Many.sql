--AYUDA-MEMORIA:
--Students => Ordenes (Pedidos)
--Courses  => Items   (Productos)

USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ABM_StudentCourses
    @StudentId INTEGER,
    @StudentName VARCHAR(50),
    @CourseId INTEGER,
    @CourseName VARCHAR(50),
    @StatementType NVARCHAR(20)
AS
BEGIN

    DECLARE @Student_Id int
    DECLARE @Course_Id int

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

	--NOTA:
	--Sin calibrar. El uso pensado es dar de alta una orden y agregar ítems
	--a una orden. No se han hecho más pruebas.

	--Parámetros necesarios: creo que todos.

    IF @StatementType = 'Insert'
    BEGIN
        INSERT Students (StudentName)
        SELECT DISTINCT @StudentName
        FROM Students
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Students 
			WHERE StudentId = @StudentId
        )

        IF @StudentId = 0
        BEGIN
            SELECT @Student_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Student_Id = @StudentId
        END

        INSERT Courses (CourseName)
        SELECT DISTINCT @CourseName
        FROM Courses
        WHERE NOT EXISTS
        (
            SELECT * 
			FROM Courses 
			WHERE CourseId = @CourseId
        )

        IF @CourseId = 0
        BEGIN
            SELECT @Course_Id = SCOPE_IDENTITY()
        END
        ELSE
        BEGIN
            SELECT @Course_Id = @CourseId
        END

        INSERT INTO StudentCourses
        VALUES
        (@Student_Id, @Course_Id)
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    --NOTA:
	--Por el momento (incluso creo que esta sección es un "huevo de pascua")
	--la operación de listado implica a los ítems de una órden.

	--Parámetros necesarios: ID de la órden.
	
	IF @StatementType = 'Select'
    BEGIN
        SELECT StudentName,
               CourseName
        FROM Courses
            JOIN StudentCourses ON Courses.CourseId = StudentCourses.CourseId
            JOIN Students ON Students.StudentId = StudentCourses.StudentId
        WHERE Students.StudentId = @StudentId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

    --NOTA:
	--Update, por el momento, pienso que solo puede ser utilizado
	--para cambiar, por ejemplo, la cantidad de artículos pedida.

	--Parámetros necesarios: ID del ítem.

	IF @StatementType = 'Update'
    BEGIN
        UPDATE Courses
        SET CourseName = @CourseName
        WHERE CourseId = @CourseId
    END

    --|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    --Students => Ordenes (Pedidos)
    --Courses  => Items   (Productos)

	--USO: 
	--Las tablas son de órdenes y sus ítems.
	--Si deseo borrar la órden completa, proveo su ID.
	--POR EL MOMENTO, ES TODA LA OPERACIÓN QUE SE HARÁ.

	--EN UN FUTURO, SE PODRÍA AJUSTAR PARA QUE:
	--Si no deseo borrar la órden, Id = 0
	--Si deseo borrar un ítem de la orden, proveo su ID.
	--Si no deseo borrar un ítem, Id = 0

	--Parámetros necesarios: ID de la órden.

    IF @StatementType = 'Delete'
    BEGIN
        DELETE FROM Students
        WHERE StudentId = @StudentId
    END

END