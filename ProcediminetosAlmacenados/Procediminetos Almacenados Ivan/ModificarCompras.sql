
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE ModificarCompra
	@IdCompra int,
	@Fecha nvarchar(50),
	@FkIdProducto int,
	@FkIdProveedor int,
	@CantidadActual numeric(18,2),
	@CantidadNueva numeric(18,2),
	@Total numeric(18,2)
AS
BEGIN
	update Compras set Fecha = @Fecha, FkIdProducto = @FkIdProducto, FkIdProveedor = @FkIdProveedor, Cantidad = @CantidadNueva, Total = @Total where IdCompra = @IdCompra
	if(@CantidadActual > @CantidadNueva)
	BEGIN
	update Inventario set CantidadExistente = CantidadExistente - (@CantidadActual - @CantidadNueva) where FkIdProducto = @FkIdProducto
	End 
	else if(@CantidadActual < @CantidadNueva)
	begin
	update Inventario set CantidadExistente = CantidadExistente + ( @CantidadNueva-@CantidadActual) where FkIdProducto = @FkIdProducto
	end

END
GO
