CREATE PROCEDURE [dbo].[SearchMovies]
	@query NVARCHAR(100)
AS
BEGIN
	SELECT f.Id_Film, 
		   f.Titre, 
		   g.Id_Genre,
		   g.GenreDeFilm, 
		   r.Id_Personne AS idRealisateur,
		   r.Prenom AS prenomRealisateur, 
		   r.Nom As nomRealisateur,
		   r.DateNaissance AS datenaissRealisateur,
		   r.Nationalite AS nationaliteRealisateur,
		   s.Id_Personne AS idScenariste,
		   s.Prenom AS prenomScenariste,
		   s.Nom AS nomScenariste,
		   s.DateNaissance AS datenaissScenariste,
		   s.Nationalite AS nationaliteScenariste,
		   f.Synopsis, 
		   f.DateSortie, 
		   f.Duree,
		   f.Affiche
	FROM Film f JOIN Genre g ON(f.Id_Genre = g.Id_Genre) 
				JOIN Personne r ON(f.Realisateur = r.Id_Personne) 
				JOIN Personne s ON(f.Scenariste = s.Id_Personne)
	WHERE f.Titre LIKE '%@query%'
END
