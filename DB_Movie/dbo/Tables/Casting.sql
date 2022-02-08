CREATE TABLE [dbo].[Casting] (
    [Id_Film]         INT           NOT NULL,
    [Id_Personne]     INT           NOT NULL,
    [Role_Personnage] NVARCHAR (50) NOT NULL,
    CONSTRAINT [FK_Film] FOREIGN KEY ([Id_Film]) REFERENCES [dbo].[Film] ([Id_Film]),
    CONSTRAINT [FK_Personne] FOREIGN KEY ([Id_Personne]) REFERENCES [dbo].[Personne] ([Id_Personne])
);

