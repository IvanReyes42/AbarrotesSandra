
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE MostrarCompras
	@Producto nvarchar(50),
	@Fecha nvarchar(50)
AS
BEGIN
	select c.IdCompra,c.Fecha,p.Nombre as 'Producto', pr.RazonSocial as 'Proveedor', c.Cantidad,c.Total from Compras c, Inventario i, Productos p, Proveedores pr
	where c.FkIdProducto = i.FkIdProducto and i.FkIdProducto = p.IdProducto and c.FkIdProveedor = pr.FkIdUser and
	p.Nombre like '%'+@Producto+'%' and c.Fecha like '%'+@Fecha+'%'
END
GO
