USE PedidosDeInsumosDeOficina

GO

CREATE PROCEDURE ConsultaParaReporte
	@Desde DATE,
	@Hasta DATE

AS

SELECT o.OrdenID,
       o.Fecha,
       c.Nombre + ', ' + c.Apellido AS Empleado,
       Producto = Stuff(
                  (
                      SELECT ' - ' + 'x' + CONVERT(VARCHAR(10), oi2.Cantidad) + ' ' + Items.Nombre
                      FROM Ordenes_Items oi2
                          INNER JOIN Items
                              ON Items.ItemID = oi2.ItemID
                      WHERE oi2.OrdenID = oi1.OrdenID
                      FOR xml path('')
                  ),
                  1,
                  2,
                  ''
                       ),
       Sum(Cantidad * PrecioUnitario) AS Total
FROM Ordenes o
    INNER JOIN Empleados c
        ON c.Legajo = o.Legajo
    INNER JOIN Ordenes_Items oi1
        ON oi1.OrdenID = o.OrdenID
WHERE o.Fecha
BETWEEN @Desde AND @Hasta
GROUP BY o.OrdenID,
         oi1.OrdenID,
         o.Fecha,
         c.Nombre,
         c.Apellido
ORDER BY o.OrdenID ASC

GO