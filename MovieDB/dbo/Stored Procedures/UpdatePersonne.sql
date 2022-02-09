CREATE PROCEDURE [dbo].[UpdatePersonne]
	@id INT,
	@nom NVARCHAR(50),
	@prenom NVARCHAR(50),
	@dateNaiss DATETIME2,
	@nationalite NVARCHAR(50)
AS
BEGIN
	UPDATE Personne 
	SET Nom = @nom,
		Prenom = @prenom,
		DateNaissance = @dateNaiss,
		Nationalite = @nationalite
	WHERE Id_Personne = @id
END
