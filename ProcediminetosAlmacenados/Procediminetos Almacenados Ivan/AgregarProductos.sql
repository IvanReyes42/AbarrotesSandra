
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE AgregarProductos
	@Nombre nvarchar(50),
	@Descripcion nvarchar(50),
	@Precio numeric(18,2),
	@FkIdCategoria int,
	@Estatus nvarchar(50),
	@StockMinimo numeric(18,2),
	@ObtenerID int OUT

AS
BEGIN
	insert into Productos(Nombre,Descripcion,Precio,FkIdCategoria,Estatus) values
	(@Nombre,@Descripcion, @Precio, @FkIdCategoria, @Estatus)

	SET @ObtenerID = (Select Idproducto from Productos where Nombre = @Nombre AND Descripcion = @Descripcion)

	Insert into Inventario(FkIdProducto,CantidadExistente,stockMinimo) values (@ObtenerID,0,@StockMinimo)

END
GO
