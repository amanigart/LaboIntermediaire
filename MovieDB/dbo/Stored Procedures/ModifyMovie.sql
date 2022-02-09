CREATE PROCEDURE ModifyMovie
	@titre nvarchar(120)
AS
BEGIN
	UPDATE Film SET Titre = @titre
END