
-- =========================================================
-- Author:		<Eric Rudasingwa>
-- Create date: <2022-02-08>
-- Description:	<Procedure stockée pour ajouter une personne>
-- ==========================================================
CREATE   PROCEDURE [dbo].[AddGenre]
	-- Add the parameters for the stored procedure here
	@genre VARCHAR(50)
AS
BEGIN
	INSERT INTO Genre (GenreDeFilm)
	OUTPUT inserted.Id_Genre
	VALUES (@genre);
END
