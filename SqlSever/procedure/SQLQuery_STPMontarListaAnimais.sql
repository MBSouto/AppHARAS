
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bruno Souto
-- Create date: 14/10/2025
-- Description:	Monta lista de Animais no datagridview
-- =============================================
CREATE PROCEDURE [dbo].[STPMontarListaAnimais]

	@NOME varchar(40)
	
AS
BEGIN

	SELECT * FROM [dbo].[Animais]
    WHERE NOME LIKE '%' + @NOME + '%'
    ORDER BY NOME

END
GO