USE PIO

GO

ALTER TABLE Ordenes
ADD CONSTRAINT CHK_OrdenEstado
CHECK (Estado IN ('Aprobado','Completado','Enviado', 'Pendiente'));