CREATE TABLE [dbo].[Film] (
    [Id_Film]     INT PRIMARY KEY IDENTITY NOT NULL,
    [Titre]       NVARCHAR (120)  NOT NULL,
    [Id_Genre]    INT            NOT NULL,
    [Realisateur] INT            NOT NULL,
    [Scenariste]  INT            NOT NULL,
    [Synopsis]    NVARCHAR (500) NOT NULL,
    [Duree]       NVARCHAR (50)  NOT NULL,
    [DateSortie]  INT            NOT NULL,
    [Affiche]     NVARCHAR(MAX),
    CONSTRAINT [FK_Genre] FOREIGN KEY (Id_Genre) REFERENCES Genre (Id_Genre),
    CONSTRAINT [FK_Realisateur] FOREIGN KEY (Realisateur) REFERENCES Personne (Id_Personne),
    CONSTRAINT [FK_Scenariste] FOREIGN KEY (Scenariste) REFERENCES Personne (Id_Personne)
);

