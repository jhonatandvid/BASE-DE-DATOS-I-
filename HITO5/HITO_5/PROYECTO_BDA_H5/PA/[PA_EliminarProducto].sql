USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarProducto]    Script Date: 4/12/2022 15:57:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PA_EliminarProducto]
	@Id_Producto VARCHAR(100)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DELETE FROM Producto
	WHERE Id_Producto LIKE '%' + @Id_Producto + '%'

END