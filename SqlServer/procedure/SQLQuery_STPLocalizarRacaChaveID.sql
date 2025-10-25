-- ================================================

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bruno Souto
-- Create date: 22/09/2025
-- Description:	Configuração da função localizar pelo Raca_Id
-- =============================================
CREATE PROCEDURE STPLocalizarRacaChaveID 
	(
		@RACA_ID int
	)
AS
BEGIN
    -- localiza o ID correspondente ao digitado
	SELECT * FROM Raca
	WHERE Raca_Id = @RACA_ID
	RETURN
END
GO
