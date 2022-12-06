USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_AdicionarProducto]    Script Date: 4/12/2022 15:55:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PA_AdicionarProducto]
	@Id_Producto VARCHAR(100),
	@Nombre VARCHAR(100),
	@Precio VARCHAR(100),
	@Marca VARCHAR(100),  
	@Stock INTEGER

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO Producto(Id_Producto,Nombre,Precio,Marca,Stock)
	VALUES (@Id_Producto,@Marca,@Precio,@Nombre,@Stock)

END