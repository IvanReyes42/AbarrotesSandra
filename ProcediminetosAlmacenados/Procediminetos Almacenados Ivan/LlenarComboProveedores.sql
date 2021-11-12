
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE LlenarComboProveedor
	
AS
BEGIN
	select fkiduser, razonsocial from Proveedores 
END
GO
