USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_AdicionarPersonalGerente]    Script Date: 4/12/2022 15:55:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PA_AdicionarPersonalGerente]

	@Id_Gerente INTEGER,
	@Nombre_Gerente VARCHAR(100),
	@Apellido_Gerente VARCHAR(100),
	@Sueldo_Gerente VARCHAR(100),
	@Turno_Gerente VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO PersonalGerente(Id_Gerente,Nombre_Gerente,Apellido_Gerente,Sueldo_Gerente,Turno_Gerente)
	VALUES (@Id_Gerente,@Nombre_Gerente,@Apellido_Gerente,@Sueldo_Gerente,@Turno_Gerente)
END
