USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_MostrarCliente]    Script Date: 4/12/2022 15:58:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PA_MostrarCliente]


AS
BEGIN

	SELECT * FROM Clientes
	ORDER BY Id_Cliente

END