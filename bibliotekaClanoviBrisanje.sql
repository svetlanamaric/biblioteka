USE [biblioteka]
GO
/****** Object:  StoredProcedure [dbo].[bibliotekaClanoviBrisanje]    Script Date: 14.8.2018. 12:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[bibliotekaClanoviBrisanje]
	@Id NVARCHAR (50)
AS
DELETE bibliotekaClanovi WHERE BrojClanskeKarte = @Id