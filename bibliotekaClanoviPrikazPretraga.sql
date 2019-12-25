USE [biblioteka]
GO
/****** Object:  StoredProcedure [dbo].[bibliotekaClanoviPrikazPretraga]    Script Date: 14.8.2018. 12:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[bibliotekaClanoviPrikazPretraga]
	@PodaciClana NVARCHAR (50)
AS
BEGIN
	SELECT
		BrojClanskeKarte,
		Ime,
		Prezime,
		Adresa,
		BrojTelefona 
	FROM bibliotekaClanovi
	WHERE (BrojClanskeKarte LIKE @PodaciClana + '%') OR (Ime LIKE @PodaciClana + '%')
END
