USE PIO

GO

ALTER TABLE Ordenes
ADD CONSTRAINT CHK_OrdenEstado
CHECK (OrdenEstado IN ('Aprobado','Completado','Enviado', 'Pendiente'));