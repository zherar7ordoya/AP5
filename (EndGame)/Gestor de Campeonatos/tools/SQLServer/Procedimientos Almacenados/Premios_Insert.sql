-- ================================================
-- Proyecto:	Gestor de Campeonatos
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Gerardo Tordoya
-- Create date: 2022-10-30
-- Description:	Graba el premio ingresado
-- =============================================
CREATE PROCEDURE dbo.Premios_Insert
	-- Add the parameters for the stored procedure here
	@premio_id INT = 0 OUTPUT,
	@puesto INT,
	@nombre NVARCHAR(50),
	@monto MONEY,
	@porcentaje FLOAT
AS
BEGIN
	-- Lo que hace SET NOCOUNT ON es no informar cuántos registros se modificaron.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO dbo.Premios (Puesto, Nombre, Monto, Porcentaje)
	VALUES (@puesto, @nombre, @monto, @porcentaje);

	-- Recuperar la última identidad creada en este scope (alcance).
	SELECT @premio_id = SCOPE_IDENTITY();
END
GO
