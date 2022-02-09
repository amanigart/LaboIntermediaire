CREATE TABLE [dbo].[Personne] (
    [Id_Personne]   INT PRIMARY KEY IDENTITY NOT NULL,
    [Nom]           NVARCHAR (50) NOT NULL,
    [Prenom]        NVARCHAR (50) NOT NULL,
    [DateNaissance] DATETIME2 (7) NOT NULL,
    [Nationalite]   NVARCHAR (50) NOT NULL
);

