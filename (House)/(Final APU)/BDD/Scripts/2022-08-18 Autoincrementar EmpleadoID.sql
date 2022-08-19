DECLARE @Descuento REAL 
SET @Descuento = 0 
UPDATE [Orden Detalles]
SET @Descuento = Descuento = @Descuento + 0.1 ;
GO 

SELECT * FROM [Orden Detalles]
GO 