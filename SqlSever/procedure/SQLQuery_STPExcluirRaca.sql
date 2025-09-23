SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bruno Souto
-- Create date: 22/09/2025
-- Description:	Exclui dados de registro de Ra�a
-- =============================================
CREATE PROCEDURE STPExcluirRaca
	(
		@RACAID int
	)
AS
BEGIN
    -- Localiza e exclui os registros de Ra�a
	DELETE FROM Raca
	WHERE
	Raca_Id = @RACAID
END
GO

