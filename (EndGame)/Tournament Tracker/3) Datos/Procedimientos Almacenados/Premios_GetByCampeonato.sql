-- =================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- =================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =================================================
-- Author:      Gerardo Tordoya
-- Create date: 2022-10-13
-- Description: Obtiene los premios de un campeonato
-- @remark:     Usar DBO (que es: DataBase Owner)    -->                     ...
--              (No usar "spanish": acentos, etc.)
-- =================================================
CREATE PROCEDURE dbo.Premios_GetByCampeonato         -->                 Aqui...
    -- Add the parameters for the stored procedure here
    @campeonato_id INT
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT *
    FROM dbo.Premios p                               -->            ...y aqui...
    INNER JOIN dbo.Campeonato_Premios cp             -->   ...y finalmente, aqui
    ON p.Id = cp.Premio_Id
    WHERE cp.Campeonato_Id = @campeonato_id;         -->  (No te olvides de ";")
END
GO
