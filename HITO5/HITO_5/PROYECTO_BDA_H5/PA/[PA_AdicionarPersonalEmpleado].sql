USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_AdicionarPersonalEmpleado]    Script Date: 4/12/2022 15:54:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PA_AdicionarPersonalEmpleado]

	@Id_Empleado INTEGER,
	@Nombre_Empleado VARCHAR(100),
	@Apellido_Empleado VARCHAR(100),
	@Sueldo_Empleado VARCHAR(100),
	@Turno_Empleado VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	INSERT INTO PersonalEmpleado(Id_Empleado,Nombre_Empleado,Apellido_Empleado,Sueldo_Empleado,Turno_Empleado)
	VALUES (@Id_Empleado,@Nombre_Empleado,@Apellido_Empleado,@Sueldo_Empleado,@Turno_Empleado)
END
