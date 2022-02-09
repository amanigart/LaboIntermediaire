CREATE PROCEDURE GetActorsList
AS
BEGIN
	SELECT DISTINCT p.Id_Personne, p.Nom, p.Prenom, p.DateNaissance, p.Nationalite
	FROM Personne p JOIN Casting c ON (p.Id_Personne = c.Id_Personne)
END
