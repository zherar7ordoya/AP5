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
-- ================================================
-- Author:		Gerardo Tordoya
-- Create date: 2022-10-23
-- Description:	Obtiene los partidos por campeonato
-- ================================================
CREATE PROCEDURE dbo.Partidos_GetByCampeonato
	-- Add the parameters for the stored procedure here
	@campeonato_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM dbo.Partidos p
	WHERE p.CampeonatoID = @campeonato_id
	ORDER BY p.Ronda;
END
GO
