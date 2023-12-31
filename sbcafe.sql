USE [master]
GO
/****** Object:  Database [sbcafe]    Script Date: 24.08.2023 20:17:02 ******/
CREATE DATABASE [sbcafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sbcafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\sbcafe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'sbcafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\sbcafe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [sbcafe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [sbcafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [sbcafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [sbcafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [sbcafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [sbcafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [sbcafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [sbcafe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [sbcafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [sbcafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [sbcafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [sbcafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [sbcafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [sbcafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [sbcafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [sbcafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [sbcafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [sbcafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [sbcafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [sbcafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [sbcafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [sbcafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [sbcafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [sbcafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [sbcafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [sbcafe] SET  MULTI_USER 
GO
ALTER DATABASE [sbcafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [sbcafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [sbcafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [sbcafe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [sbcafe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [sbcafe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [sbcafe] SET QUERY_STORE = ON
GO
ALTER DATABASE [sbcafe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [sbcafe]
GO
/****** Object:  Table [dbo].[siparisler]    Script Date: 24.08.2023 20:17:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[siparisler](
	[siparisler] [varchar](500) NULL,
	[uyeID] [int] NULL,
	[fiyat] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[uyeler]    Script Date: 24.08.2023 20:17:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[uyeler](
	[uyeID] [int] NOT NULL,
	[cepNo] [char](13) NULL,
	[adSoyad] [varchar](50) NULL,
	[cinsiyet] [varchar](10) NULL,
	[sifre] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[adres] [text] NULL,
 CONSTRAINT [PK_uyeler] PRIMARY KEY CLUSTERED 
(
	[uyeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[yoneticigiris]    Script Date: 24.08.2023 20:17:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yoneticigiris](
	[kulad] [varchar](50) NOT NULL,
	[sifre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Köfte 70 TL, Mevsim Salata 40 TL, Cola 25 TL', -1, 270)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 285)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 181)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 148)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 67)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Köfte 70 TL, Tavuk Salata 70 TL, İce Americano 80 TL', -1, 220)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 186)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 190)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Köfte 70 TL, Pirzola 200 TL, Mantı 75 TL, Pide 120 TL, Lahmacun 50 TL, Mantı 75 TL, Mevsim Salata 40 TL, Sezar Salata 60 TL, İce Latte 50 TL', -2, 815)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Mantı 75 TL, Mevsim Salata 40 TL, İce Latte 50 TL', -3, 165)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Köfte 70 TL, Mevsim Salata 40 TL, İce Latte 50 TL', -4, 160)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 133)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Double T.KAHVE 70 TL', -5, 310)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Köfte 70 TL, Tavuk Salata 70 TL, Çay 10 TL', -6, 150)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pide 120 TL, Mevsim Salata 40 TL, İce Tea 20 TL', -7, 180)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 171)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 537)
INSERT [dbo].[siparisler] ([siparisler], [uyeID], [fiyat]) VALUES (N'Pirzola 200 TL, Mevsim Salata 40 TL, Mocha 50 TL', 3, 143)
GO
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (-7, N'adw          ', N'awd', N'uye degil', N'uye degil', N'uye degil', N'awdaw')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (-6, N'rgdr         ', N'drdr', N'uye degil', N'uye degil', N'uye degil', N'dgrdg')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (-5, N'srfsf        ', N'dgd', N'uye degil', N'uye degil', N'uye degil', N'fsfsfs')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (-4, N'ge5g         ', N'gegge5g', N'uye degil', N'uye degil', N'uye degil', N'e5g')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (-3, N'546          ', N'saldkled', N'uye degil', N'uye degil', N'uye degil', N'fesfs')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (-2, N'erge         ', N'erg', N'uye degil', N'uye degil', N'uye degil', N'erg')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (-1, N'34           ', N'misafir', N'yok', N'34', N'agu', N'bugu')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (1, N'553          ', N'seyit', N'erkek', N'123', N'agubugu', N'cugu bebe')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (3, N'98           ', N'tuba', N'KADIN', N'07', N'gdrgrdgd', N'grdgd')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (4, N'00           ', N'thrth', N'KADIN', N'00', N'thfth', N'fht')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (6, N'44           ', N'sefs', N'KADIN', N'44', N'fsef', N'fe')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (7, N'552          ', N'tuba', N'KADIN', N'75', N'dfg', N'adaw')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (8, N'552          ', N'fthth', N'ERKEK', N'74', N'grg', N'rgdrg')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (9, N'552          ', N'sfefs', N'ERKEK', N'efsef', N'gr', N'dgdr')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (10, N'552          ', N'acaef', N'ERKEK', N'acac', N'sfsf', N'sefs')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (11, N'552          ', N'sefsef', N'ERKEK', N'ewfef', N'fsrf', N'sefsef')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (12, N'552          ', N'awdawd', N'KADIN', N'wdawd', N'ttgh', N'gdrg')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (13, N'552          ', N'', N'', N'', N'', N'')
INSERT [dbo].[uyeler] ([uyeID], [cepNo], [adSoyad], [cinsiyet], [sifre], [mail], [adres]) VALUES (14, N'555          ', N'', N'', N'', N'', N'')
GO
INSERT [dbo].[yoneticigiris] ([kulad], [sifre]) VALUES (N'seyit', N'123')
GO
ALTER TABLE [dbo].[siparisler]  WITH CHECK ADD  CONSTRAINT [FK_siparisler_uyeler] FOREIGN KEY([uyeID])
REFERENCES [dbo].[uyeler] ([uyeID])
GO
ALTER TABLE [dbo].[siparisler] CHECK CONSTRAINT [FK_siparisler_uyeler]
GO
USE [master]
GO
ALTER DATABASE [sbcafe] SET  READ_WRITE 
GO
