USE [HARAS_3D87]
GO

INSERT INTO [dbo].[Animais]
           ([nrchip]
           ,[nome]
           ,[dtNascimento]
           ,[valor]
           ,[vendido]
           ,[Raca_Id])
     VALUES
           (999, 'DENUNCIA BRASIL', '', 4150.00, 0, 1),
		   (23456, 'SEVILHA DA MORADA NOVA', '', 8760.00, 0, 2),
		   (34567, 'TEOREMA DE BATATAIS', '', 12300.00, 1, 2),
		   (456789, 'SAFIRA MAIOR', '', 9100.00, 0, 1),
		   (1237, 'MAX GEORGE HORSE', '', 6000.00, 0, 3),
		   (1238, 'PÉ DE PANO', '', 4401.00, 1, 2)
GO


