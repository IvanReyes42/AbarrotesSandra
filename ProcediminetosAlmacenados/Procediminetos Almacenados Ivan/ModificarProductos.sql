SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ModificarProductos
	@IdProducto int,
	@Nombre nvarchar(50),
	@Descripcion nvarchar(50),
	@Precio numeric(18,2),
	@FkIdCategoria int,
	@Estatus nvarchar(50),
	@Cantidad numeric(18,2),
	@StockMinimo numeric(18,2)
AS
BEGIN
	update Productos set Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, FkIdCategoria = @FkIdCategoria, Estatus = @Estatus where IdProducto = @IdProducto;
	update Inventario set CantidadExistente =  @Cantidad, stockMinimo = @StockMinimo where FkIdProducto = @IdProducto
END
GO
