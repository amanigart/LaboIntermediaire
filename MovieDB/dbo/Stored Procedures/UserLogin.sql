CREATE PROCEDURE UserLogin
	@email VARCHAR(50),
	@password VARCHAR(50)
AS
BEGIN
	DECLARE @secretKey VARCHAR(200)
	SET @secretKey = dbo.GetSecretKey()

	DECLARE @salt VARCHAR(100)
	SET @salt = (SELECT Salt FROM Utilisateur WHERE Email = @email)

	DECLARE @passwd_hash VARBINARY(64)
	SET @passwd_hash = HASHBYTES('SHA2_512', CONCAT(@salt, @secretKey, @password, @salt))

	SELECT Id_User, Email, Nickname FROM Utilisateur WHERE Email = @email AND Passwd = @passwd_hash
END