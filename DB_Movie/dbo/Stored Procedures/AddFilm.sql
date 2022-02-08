CREATE PROCEDURE [dbo].[AddFilm]
    -- Add the parameters for the stored procedure here
    @titre VARCHAR(50),
    @idgenre int,
    @realisateur int,
    @scenariste int,
    @brefsynop VARCHAR(300),
    @releasedt datetime2,
    @duree VARCHAR(50)
AS
BEGIN
    INSERT INTO Film (Titre, Id_Genre, Realisateur, Scenariste, Synopsis, DateSortie, Duree)
    OUTPUT inserted.Id_Film
    VALUES (@titre, @idgenre, @realisateur, @scenariste, @brefsynop, @releasedt, @duree);
END