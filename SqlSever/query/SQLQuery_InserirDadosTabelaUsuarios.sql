-- =============================================
-- Author:		Bruno Souto
-- Create date: 07/10/2025
-- Description:	Inserir dados na tabela Usuários
-- =============================================
USE HARAS_3D87

BEGIN
INSERT INTO dbo.Usuarios 
	(NOME, SENHA, ACESSO, TELEFONE)
VALUES
	('LUISF', '123', 1, '3456-7894'),
	('BRUNOS', '1234', 0, '1234-4567')
END