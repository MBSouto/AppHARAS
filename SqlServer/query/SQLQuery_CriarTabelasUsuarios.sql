-- =============================================
-- Author:		Bruno Souto
-- Create date: 07/10/2025
-- Description:	Criação da tabela Usuarios
-- =============================================

USE HARAS_3D87

BEGIN
CREATE TABLE Usuarios
(
	NOME varchar (50) PRIMARY KEY,
	SENHA varchar (15) NULL, 
	ACESSO int NULL, 
	TELEFONE nvarchar (20) NULL
)
END