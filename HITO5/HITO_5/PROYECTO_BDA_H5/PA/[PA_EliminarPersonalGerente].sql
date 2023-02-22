USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarPersonalGerente]    Script Date: 4/12/2022 15:57:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PA_EliminarPersonalGerente]

	@Id_Gerente INTEGER
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	DELETE FROM PersonalGerente
	WHERE Id_Gerente = @Id_Gerente

END
