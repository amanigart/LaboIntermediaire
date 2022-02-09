CREATE PROCEDURE [dbo].[UpdateFilm]
	@idFilm INT,
	@idRealisateur INT,
	@idScenariste INT,
	@titre NVARCHAR(120),
	@synopsis NVARCHAR(500),
	@duree NVARCHAR(50),
	@dateSortie INT
AS
BEGIN
	UPDATE Film
	SET Realisateur = @idRealisateur,
		Scenariste = @idScenariste,
		Titre = @titre,
		Synopsis = @synopsis,
		Duree = @duree,
		DateSortie = @dateSortie
	WHERE Id_Film = @idFilm
END
