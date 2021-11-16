CREATE PROCEDURE AgregarCategoria
	@Nombre nvarchar(50)
AS
BEGIN
	insert into Categorias(Nombre) values (@Nombre)
END
GO
