CREATE PROCEDURE MostrarCategorias	
	@Nombre nvarchar(50)
AS
BEGIN
	select * from Categorias where Nombre like '%'+@Nombre+'%'
END
GO
