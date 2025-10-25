USE [HARAS_3D87]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Bruno Souto
-- Create date: 10/10/2025
-- Description:	Procedure para autenticar usuário no formulário de login
-- =============================================
CREATE PROCEDURE [dbo].[STPLocalizarUsuario]
	(
	@NOME varchar(50),
	@SENHA varchar(15),
	@ACESSO int=0 output
	)
AS
BEGIN
	SELECT ACESSO 
	FROM Usuarios 
	WHERE NOME = @NOME 
	AND SENHA = @SENHA
	RETURN
END

GO


