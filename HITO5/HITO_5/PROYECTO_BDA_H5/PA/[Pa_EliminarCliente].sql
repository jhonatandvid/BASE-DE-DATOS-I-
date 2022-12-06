USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[Pa_EliminarCliente]    Script Date: 4/12/2022 15:57:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Pa_EliminarCliente]

	@Id_Cliente VARCHAR(100)

AS
BEGIN

	DELETE FROM Clientes
	WHERE Id_Cliente = @Id_Cliente

END