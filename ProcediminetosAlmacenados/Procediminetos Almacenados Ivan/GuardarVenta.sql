
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GuardarVenta
	@Fecha nvarchar(50),
	@Total numeric(18,2),
	@FkIdUsuario int,
	@ObtenerID int OUT,
	@FkIdProducto int,
	@cantidad numeric(18,2),
	@SubTotal numeric(18,2),
	@Opcion int

AS
BEGIN
	if(@Opcion = 1)
	begin
		insert into TicketVenta(Fecha,Total,FkIdUsuario) values(@Fecha,@Total,@FkIdUsuario)
	end
	else if(@Opcion = 2)
	Begin
		Set @ObtenerID = (SELECT IdVenta FROM TicketVenta WHERE IdVenta=(SELECT max(IdVenta) FROM TicketVenta))
		insert into DetallesVentas(FkIdProducto,Cantidad,Subtotal,FkIdVenta) values(@FkIdProducto,@cantidad,@SubTotal,@ObtenerID)
		update Inventario set CantidadExistente = CantidadExistente - @cantidad where FkIdProducto = @FkIdProducto
	end
END
GO
