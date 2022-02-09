CREATE VIEW [dbo].[Collection_View]
	AS 
	SELECT f.Titre, CONCAT(p.Prenom,' ',p.Nom) AS Realisateur, f.Duree, c.Rating
	FROM Film f JOIN Collection c ON (f.Id_Film = c.Id_Film)
			    JOIN Utilisateur u ON (u.Id_User = c.Id_User)
				JOIN Personne p ON (p.Id_Personne = f.Realisateur)
	WHERE u.Id_User = 1
