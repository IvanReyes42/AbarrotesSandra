
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE CorteDeCaja 
	@IdUsuario int,
	@Fecha nvarchar(50)
AS
BEGIN
	select Usuario,(select SUM(Total) from TicketVenta where FkIdUser = @IdUsuario ) as 'Total'  from Empleados, TicketVenta where FkIdUser = @IdUsuario and Fecha = @Fecha and FkIdUser = FkIdUsuario
END
GO
