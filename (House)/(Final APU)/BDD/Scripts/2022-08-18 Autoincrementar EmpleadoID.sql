DECLARE @EmpleadoID INT 
SET @EmpleadoID = 0 
UPDATE Ordenes 
SET @EmpleadoID = EmpleadoID = @EmpleadoID + 1 
GO 

SELECT * FROM Ordenes
GO 