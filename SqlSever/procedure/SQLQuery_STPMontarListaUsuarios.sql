SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Bruno Souto
-- Create date: 07/10/2025
-- Description:	Monta lista de Usuários
-- =============================================
CREATE PROCEDURE STPMontarListaUsuarios
	@NOME varchar(50)
AS
BEGIN

	SELECT * FROM [dbo.Usuarios]
	ORDER BY NOME
	RETURN

END
GO
