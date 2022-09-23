-- DECLARE @Descuento REAL 
--SET @Descuento = 0 
UPDATE [Orden Detalles]
SET Descuento = ROUND(Descuento - 0.7, 2);
GO 

SELECT * FROM [Orden Detalles]
GO 