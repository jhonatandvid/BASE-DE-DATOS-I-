USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_ModificarVenta]    Script Date: 4/12/2022 15:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[PA_ModificarVenta]

	@Id_Ventas VARCHAR(100),
	@Id_Cliente VARCHAR(100),
	@Id_Productos VARCHAR(100),
	@Cuenta_a_Pagar VARCHAR(100),
	@Cuenta_Pagada VARCHAR(100),
	@Total_a_Pagar VARCHAR(100)

AS
BEGIN

	UPDATE [dbo].[Ventas]
	SET	Id_Ventas = @Id_Ventas,
		Id_Cliente = @Id_Cliente,
		Id_Productos = @Id_Productos,
		Cuenta_a_Pagar = @Cuenta_a_Pagar,
		Cuenta_Pagada = @Cuenta_Pagada,
		Total_a_Pagar = @Total_a_Pagar
	WHERE Id_Ventas = @Id_Ventas

END