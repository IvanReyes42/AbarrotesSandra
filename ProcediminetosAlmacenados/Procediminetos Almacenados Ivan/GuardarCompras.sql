SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GuardarCompras
	@Fecha nvarchar(50),
	@FkIdProducto int,
	@FkIdProveedor int,
	@Cantidad numeric(18,2),
	@Total numeric(18,2)
AS
BEGIN
	
	Insert into Compras(Fecha,FkIdProducto,FkIdProveedor,Cantidad,Total)
	values(@Fecha,@FkIdProducto,@FkIdProveedor,@Cantidad,@Total)

	update Inventario set CantidadExistente = CantidadExistente+@Cantidad where FkIdProducto = @FkIdProducto

END
GO
