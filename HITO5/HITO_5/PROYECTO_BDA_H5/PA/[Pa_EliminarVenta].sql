USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[Pa_EliminarVenta]    Script Date: 4/12/2022 15:57:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[Pa_EliminarVenta]

	@Id_Ventas INTEGER

AS
BEGIN

	DELETE FROM Ventas
	WHERE Id_Ventas LIKE '%' + @Id_Ventas + '%'

END