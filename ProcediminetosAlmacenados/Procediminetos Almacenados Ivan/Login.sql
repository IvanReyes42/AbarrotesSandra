SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE Login 
	
AS
BEGIN
	Select FkIdUser,Usuario,CONVERT(NVARCHAR(500),DECRYPTBYPASSPHRASE('Contraseņa', Contraseņa)) as Contraseņa, Rol, Estatus from Empleados, Usuarios where IdUser = FkIdUser
END
GO
