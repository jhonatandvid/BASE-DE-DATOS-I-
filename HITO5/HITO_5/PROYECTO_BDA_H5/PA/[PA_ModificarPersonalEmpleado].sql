USE [DB_SistemaDeVentas]
GO
/****** Object:  StoredProcedure [dbo].[PA_ModificarPersonalEmpleado]    Script Date: 4/12/2022 15:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[PA_ModificarPersonalEmpleado]

	@Id_Empleado INTEGER,
	@Nombre_Empleado VARCHAR(100),
	@Apellido_Empleado VARCHAR(100),
	@Sueldo_Empleado VARCHAR(100),
	@Turno_Empleado VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	UPDATE PersonalEmpleado
	SET Nombre_Empleado = @Nombre_Empleado,
		Apellido_Empleado = @Apellido_Empleado,
		Sueldo_Empleado = @Sueldo_Empleado,
		Turno_Empleado = @Turno_Empleado
	WHERE Id_Empleado = @Id_Empleado
END
