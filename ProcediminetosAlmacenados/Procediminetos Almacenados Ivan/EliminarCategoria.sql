CREATE PROCEDURE EliminarCategoria
	@IdCategoria int
AS
DECLARE @Resultado int
BEGIN
	If not exists (select COUNT(FkIdCategoria) from Productos where FkIdCategoria = @IdCategoria)
	Begin
		Delete from Categorias where IdCategoria = @IdCategoria
		Return 'Correcto'
	End
	else
	Begin
		Return 'Error'
	end

END
GO
