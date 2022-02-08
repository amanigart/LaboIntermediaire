CREATE TABLE [dbo].[Film] (
    [Id_Film]     INT            IDENTITY (1, 1) NOT NULL,
    [Titre]       NVARCHAR (50)  NOT NULL,
    [Id_Genre]    INT            NOT NULL,
    [Realisateur] INT            NOT NULL,
    [Scenariste]  INT            NOT NULL,
    [Synopsis]    NVARCHAR (300) NOT NULL,
    [Duree]       NVARCHAR (50)  NOT NULL,
    [DateSortie]  INT            NULL,
    PRIMARY KEY CLUSTERED ([Id_Film] ASC),
    CONSTRAINT [FK_Genre] FOREIGN KEY ([Id_Genre]) REFERENCES [dbo].[Genre] ([Id_Genre]),
    CONSTRAINT [FK_Realisateur] FOREIGN KEY ([Realisateur]) REFERENCES [dbo].[Personne] ([Id_Personne]),
    CONSTRAINT [FK_Scenariste] FOREIGN KEY ([Scenariste]) REFERENCES [dbo].[Personne] ([Id_Personne])
);

