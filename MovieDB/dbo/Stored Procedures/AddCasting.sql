
-- =========================================================
-- Author:		<Eric Rudasingwa>
-- Create date: <2022-02-08>
-- Description:	<Procedure stockée pour ajouter une personne>
-- ==========================================================
CREATE PROCEDURE [dbo].[AddCasting]
	-- Add the parameters for the stored procedure here
	@idfilm int,
	@idpersonne int,
	@rolepersonnage VARCHAR(50)

AS
BEGIN
	INSERT INTO Casting (Id_Film, Id_Personne, Role_Personnage)
	VALUES (@idfilm, @idpersonne, @rolepersonnage);
END
