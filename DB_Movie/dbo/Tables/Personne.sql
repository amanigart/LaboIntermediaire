CREATE TABLE [dbo].[Personne] (
    [Id_Personne]   INT           IDENTITY (1, 1) NOT NULL,
    [Nom]           NVARCHAR (50) NOT NULL,
    [Prenom]        NVARCHAR (50) NOT NULL,
    [DateNaissance] DATETIME2 (7) NOT NULL,
    [Nationalite]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Personne] ASC)
);

