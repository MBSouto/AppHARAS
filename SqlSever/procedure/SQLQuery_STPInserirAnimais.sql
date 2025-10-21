USE [HARAS_3D87]
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Bruno Souto
-- Create date: 20/10/2025
-- Description:	Inclui dados de registro de Animais
-- =============================================
CREATE PROCEDURE [dbo].[STPInserirAnimais]
	(
		@CHIP int,
		@NOME varchar(40),
		@DTNASCIMENTO datetime,
		@VALOR decimal(10,2),
		@VENDIDO bit,
		@RACAID int
	)
AS
BEGIN
    -- Inclui os registros de Animais
	INSERT INTO 
	ANIMAIS (nrchip, nome, dtNascimento, valor, vendido, Raca_Id)
	VALUES
			(@CHIP, @NOME, @DTNASCIMENTO, @VALOR, @VENDIDO, @RACAID)

END
GO
