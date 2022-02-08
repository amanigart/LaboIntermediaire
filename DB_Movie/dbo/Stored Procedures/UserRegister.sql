CREATE PROCEDURE UserRegister
	@name VARCHAR(50),
	@firstName VARCHAR(50),
	@email VARCHAR(50),
	@password VARCHAR(50),
	@nickname VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @secretKey VARCHAR(200)
	SET @secretKey = dbo.GetSecretKey()

	DECLARE @salt VARCHAR(100)
	SET @salt = CONCAT(NEWID(), NEWID(), NEWID())

	DECLARE @passwd_hash VARBINARY(64)
	SET @passwd_hash = HASHBYTES('SHA2_512', CONCAT(@salt, @secretKey, @password, @salt))

	INSERT INTO [Utilisateur] (Nom, Prenom, Email, Nickname, Passwd, Salt)
	OUTPUT inserted.Id_User
	VALUES (@name, @firstName, @email, @nickname, @passwd_hash, @salt)
END