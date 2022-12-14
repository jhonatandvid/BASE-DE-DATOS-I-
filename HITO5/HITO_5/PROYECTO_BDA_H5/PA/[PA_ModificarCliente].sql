USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_ModificarCliente]    Script Date: 4/12/2022 15:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PA_ModificarCliente]

	@Id_Cliente  VARCHAR(100),
	@ci INTEGER,
	@Nombre_Clientes VARCHAR(100),
	@Apellido_Clientes VARCHAR(100)

AS
BEGIN

	UPDATE [dbo].[Clientes]
	SET	Id_Cliente = @Id_Cliente,
		ci = @ci,
		Nombre_Clientes = @Nombre_Clientes,
		Apellido_Clientes = @Apellido_Clientes
	WHERE Id_Cliente = @Id_Cliente

END