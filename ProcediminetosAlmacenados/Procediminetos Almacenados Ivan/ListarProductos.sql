use AbarrotesSandra
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ListarProductos
	@Nombre nvarchar(50)
AS
BEGIN
	select IdProducto, CONCAT(Nombre,Descripcion) Producto, Precio from Productos,Inventario where Estatus = 'Activo' and
	CantidadExistente > 0 and Nombre like '%'+@Nombre+'%' and IdProducto = FkIdProducto
END
GO
