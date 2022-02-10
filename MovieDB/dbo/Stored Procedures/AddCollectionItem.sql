CREATE PROCEDURE [dbo].[AddCollectionItem]
	@idFilm int,
	@idUser int
AS
BEGIN
	INSERT INTO Collection (Id_Film, Id_User) VALUES (@idFilm, @idUser)
END
