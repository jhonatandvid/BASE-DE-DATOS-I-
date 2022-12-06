USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarInventario]    Script Date: 4/12/2022 15:57:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PA_EliminarInventario]
	@Id_Inventario VARCHAR(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DELETE FROM Inventario
	WHERE Id_Inventario LIKE '%' + @Id_Inventario + '%' 
END