CREATE TABLE [dbo].[Genre] (
    [Id_Genre]    INT           IDENTITY (1, 1) NOT NULL,
    [GenreDeFilm] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Genre] ASC)
);

