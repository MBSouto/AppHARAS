
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Bruno Souto>
-- Create date: <22/09/2025>
-- Description:	Configuração da função filtrar pela descrição
-- =============================================
CREATE PROCEDURE STPMontarListaRaca 
	(
		@DESCRICAO Varchar (30)
	)
AS
BEGIN
	-- Inclui o filtro em qualquer correspondência do texto digitado
	DECLARE @FILTRO VARCHAR(34)
    SET @FILTRO = '%' + @DESCRICAO + '%'

	-- Monta lista com todos os dados da tabela raça
	SELECT * FROM RACA
	WHERE Descricao LIKE @FILTRO
	ORDER BY Descricao
END
GO
