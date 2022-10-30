-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ====================================================
-- Author:		Gerardo Tordoya
-- Create date: 2022-10-23
-- Description:	Obtiene todos los miembros de un equipo
-- ====================================================
CREATE PROCEDURE dbo.EquipoMiembros_GetByEquipo
	-- Add the parameters for the stored procedure here
	@equipo_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.EquipoMiembros em
	INNER JOIN dbo.Personas p ON em.PersonaID = p.PersonaID
	WHERE em.EquipoID = @equipo_id;
END
GO
