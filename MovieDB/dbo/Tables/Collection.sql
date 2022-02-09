CREATE TABLE [dbo].[Collection]
(
	Id_User INT NOT NULL,
	Id_Film INT NOT NULL,
	Rating INT,
	Favori BIT DEFAULT 0,
	Corbeille BIT DEFAULT 0,
	CONSTRAINT FK_IdUSer_Collection FOREIGN KEY (Id_User) REFERENCES Utilisateur (Id_User),
	CONSTRAINT FK_IdFilm_Collection FOREIGN KEY (Id_Film) REFERENCES Film (Id_Film)
)
