USE [master]
GO
/****** Object:  Database [biblioteka]    Script Date: 17.8.2018. 10:27:45 ******/
CREATE DATABASE [biblioteka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'biblioteka', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\biblioteka.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'biblioteka_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\biblioteka_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [biblioteka] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [biblioteka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [biblioteka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [biblioteka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [biblioteka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [biblioteka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [biblioteka] SET ARITHABORT OFF 
GO
ALTER DATABASE [biblioteka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [biblioteka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [biblioteka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [biblioteka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [biblioteka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [biblioteka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [biblioteka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [biblioteka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [biblioteka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [biblioteka] SET  DISABLE_BROKER 
GO
ALTER DATABASE [biblioteka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [biblioteka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [biblioteka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [biblioteka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [biblioteka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [biblioteka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [biblioteka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [biblioteka] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [biblioteka] SET  MULTI_USER 
GO
ALTER DATABASE [biblioteka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [biblioteka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [biblioteka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [biblioteka] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [biblioteka] SET DELAYED_DURABILITY = DISABLED 
GO
USE [biblioteka]
GO
/****** Object:  Table [dbo].[bibliotekaClanovi]    Script Date: 17.8.2018. 10:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bibliotekaClanovi](
	[BrojClanskeKarte] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nchar](50) NULL,
	[Prezime] [nchar](50) NULL,
	[Adresa] [nchar](50) NULL,
	[BrojTelefona] [nchar](20) NULL,
 CONSTRAINT [PK_bibliotekaClanovi] PRIMARY KEY CLUSTERED 
(
	[BrojClanskeKarte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bibliotekaRezervisaneKnjige]    Script Date: 17.8.2018. 10:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bibliotekaRezervisaneKnjige](
	[IdRezervacije] [int] IDENTITY(1,1) NOT NULL,
	[BrojClanskeKarte] [int] NULL,
	[NazivKnjige] [nchar](50) NULL,
	[Autor] [nchar](50) NULL,
 CONSTRAINT [PK_bibliotekaRezervisaneKnjige] PRIMARY KEY CLUSTERED 
(
	[IdRezervacije] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[bibliotekaClanoviBrisanje]    Script Date: 17.8.2018. 10:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[bibliotekaClanoviBrisanje]
	@Id NVARCHAR (50)
AS
DELETE bibliotekaClanovi WHERE BrojClanskeKarte = @Id
GO
/****** Object:  StoredProcedure [dbo].[bibliotekaClanoviDodavanjeIzmena]    Script Date: 17.8.2018. 10:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[bibliotekaClanoviDodavanjeIzmena]	
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
GO
/****** Object:  StoredProcedure [dbo].[bibliotekaClanoviPrikazPretraga]    Script Date: 17.8.2018. 10:27:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[bibliotekaClanoviPrikazPretraga]
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

GO
USE [master]
GO
ALTER DATABASE [biblioteka] SET  READ_WRITE 
GO
