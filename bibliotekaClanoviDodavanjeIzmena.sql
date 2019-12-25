CREATE PROCEDURE dbo.[bibliotekaClanoviDodavanjeIzmena]	
	@Mode NVARCHAR (10),
	@BrojClanskeKarte INT,
	@Ime NVARCHAR (50),
	@Prezime NVARCHAR(50),
	@Adresa NVARCHAR (200),
	@BrojTelefona NVARCHAR (20)
AS

	IF @Mode = 'Add'
	BEGIN 
		INSERT INTO dbo.bibliotekaClanovi
		(
			Ime,
			Prezime,
			Adresa,
			BrojTelefona 
		)
		VALUES 
		(
			@Ime,
			@Prezime,
			@Adresa,
			@BrojTelefona 
		)
END

	ELSE IF @Mode = 'Edit'
	BEGIN
		UPDATE dbo.bibliotekaClanovi
		SET 
			Ime = @Ime,
			Prezime = @Prezime,
			Adresa = @Adresa,
			BrojTelefona = @BrojTelefona
		WHERE BrojClanskeKarte = @BrojClanskeKarte
END