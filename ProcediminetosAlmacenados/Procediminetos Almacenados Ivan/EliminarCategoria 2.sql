CREATE PROCEDURE EliminarCategoria
	@IdCategoria int
AS
BEGIN
	Delete from Categorias where IdCategoria = @IdCategoria
END
GO
