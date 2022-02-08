CREATE PROCEDURE ModifyMovie
	@titre nvarchar(50)
AS
BEGIN
	UPDATE Film SET Titre = @titre
END
