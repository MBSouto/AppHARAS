SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bruno Souto
-- Create date: 22/09/2025
-- Description:	Configuração da função editar dados de Raça
-- =============================================
CREATE PROCEDURE STPAlterarRaca
	(
		@REGISTRO int, 
		@DESCRICAO varchar(40),
		@DATA date,
		@HORA nvarchar(5),
		@RACAID int
	)
AS
BEGIN
    -- Localiza e edita os registros de Raça
	UPDATE Raca
	
	SET 
	Registro = @REGISTRO,
	Descricao = @DESCRICAO,
	Data = @DATA,
	hora = @HORA
	
	WHERE
	Raca_Id = @RACAID
END
GO
