USE [HARAS_3D87]
GO

/****** Object:  StoredProcedure [dbo].[STPExcluirAnimais]    Script Date: 10/20/2025 11:12:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Bruno Souto
-- Create date: 20/10/2025
-- Description:	Exclui dados de registro de Animais
-- =============================================
CREATE PROCEDURE [dbo].[STPExcluirAnimais]
	(
		@ANIMAISID int
	)
AS
BEGIN
    -- Localiza e exclui os registros de Animais
	DELETE FROM Animais
	WHERE
	Animais_Id = @ANIMAISID
END
GO
