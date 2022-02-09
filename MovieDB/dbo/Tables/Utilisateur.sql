CREATE TABLE [dbo].[Utilisateur] (
    [Id_User]  INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
    [Nom]      NVARCHAR (50)  NOT NULL,
    [Prenom]   NVARCHAR (50)  NOT NULL,
    [Email]    NVARCHAR (380) NOT NULL,
    [Nickname] NVARCHAR (50)  NOT NULL,
    [Passwd]   VARBINARY (64) NOT NULL,
    [Salt]     NVARCHAR (100) NOT NULL,
);

