
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE MostrarProductos 
	@Nombre nvarchar(50)
AS
BEGIN
	select p.IdProducto as 'Codigo', p.Nombre, p.Descripcion,i.CantidadExistente, p.Precio,c.Nombre as 'Categoria', p.Estatus, i.stockMinimo
	from Productos p, Categorias c, Inventario i where p.FkIdCategoria = c.IdCategoria and p.IdProducto = i.FkIdProducto and p.Nombre like '%'+@Nombre+'%'
END
GO
