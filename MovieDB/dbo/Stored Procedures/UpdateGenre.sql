CREATE PROCEDURE [dbo].[UpdateGenre]
	@idFilm INT,
	@idGenre INT,
	@genre NVARCHAR(50),
	@titre NVARCHAR(120),
	@idRealisateur INT,
	@nomRealisateur NVARCHAR(50),
	@prenomRealisateur NVARCHAR(50),
	@dateNaissRealisateur DATETIME2,
	@nationaliteRealisateur NVARCHAR(50),
	@idScenariste INT,
	@nomScenariste NVARCHAR(50),
	@prenomScenariste NVARCHAR(50),
	@dateNaissScenariste DATETIME2,
	@nationaliteScenariste NVARCHAR(50),
	@anneeSortie INT,
	@duree NVARCHAR(50),
	@synopsis NVARCHAR(500)

AS
BEGIN

	DECLARE @newIdGenre INT,
			@newIdRealisateur INT,
			@newIDScenariste INT

	-- Maj titre
	IF @titre != (SELECT Titre FROM Film WHERE Id_Film = @idFilm)
	BEGIN
		UPDATE Film SET Titre = @titre WHERE Id_Film = @idFilm
	END

	-- Maj Anne sortie
	IF @anneeSortie != (SELECT DateSortie FROM Film WHERE Id_Film = @idFilm)
	BEGIN
		UPDATE Film SET DateSortie = @anneeSortie WHERE Id_Film = @idFilm
	END

	-- Maj Duree
	IF @duree != (SELECT Duree FROM Film WHERE Id_Film = @idFilm)
	BEGIN
		UPDATE Film SET Duree = @duree WHERE Id_Film = @idFilm
	END

	-- Maj Synopsis
	IF @synopsis != (SELECT Synopsis FROM Film WHERE Id_Film = @idFilm)
	BEGIN
		UPDATE Film SET Synopsis = @synopsis WHERE Id_Film = @idFilm
	END


	-- Maj Genre 
	IF @genre != (SELECT GenreDeFilm FROM Genre WHERE Id_Genre = @idGenre)
	BEGIN
	    -- Si genre existe
	    IF @genre IN (SELECT GenreDeFilm FROM Genre)
		BEGIN
			SET @newIdGenre = (SELECT Id_Genre FROM Genre WHERE UPPER(GenreDeFilm) LIKE UPPER(@genre)) 
			UPDATE Film SET Id_Genre = @newIdGenre
		END
		-- Si non créer genre
		ELSE
		BEGIN
			SET @newIdGenre = AddGenre(@genre)
			UPDATE Film SET Id_Genre = @newIdGenre
		END
	END

	-- Maj Realisateur
	-- Nom
	--IF @nomRealisateur != (SELECT Nom FROM Personne WHERE Id_Personne = @idRealisateur)
	---- Prenom
	--IF @prenomRealisateur != (SELECT Prenom FROM Personne WHERE Id_Personne = @idRealisateur)
	---- Date naissance
	--IF @dateNaissRealisateur != (SELECT DateNaissance FROM Personne WHERE Id_Personne = @idRealisateur)
	---- Nationalité 
	--IF @nationaliteRealisateur != (SELECT Nationalite FROM Personne WHERE Id_Personne = @idRealisateur)


	-- Maj Nom Scenariste

END
