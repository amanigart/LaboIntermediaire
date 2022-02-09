
-- =========================================================
-- Author:		<Eric Rudasingwa>
-- Create date: <2022-02-08>
-- Description:	<Procedure stockée pour ajouter une personne>
-- ==========================================================
CREATE   PROCEDURE [dbo].[AddPersonne]
	-- Add the parameters for the stored procedure here
	@nom VARCHAR(50),
	@prenom VARCHAR(50),
	@datenaissance datetime2(7),
	@nationalite VARCHAR(50)

AS
BEGIN
	INSERT INTO Personne (Nom, Prenom, DateNaissance, Nationalite)
	OUTPUT inserted.Id_Personne
	VALUES (@nom, @prenom, @datenaissance, @nationalite);
END
