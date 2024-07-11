USE [master]
GO

/****** Object:  Database [hurtownia_danych]    Script Date: 11.07.2024 20:49:18 ******/
CREATE DATABASE [hurtownia_danych]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'hurtownia_danych', FILENAME = N'/var/opt/mssql/data/hurtownia_danych.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'hurtownia_danych_log', FILENAME = N'/var/opt/mssql/data/hurtownia_danych_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hurtownia_danych].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [hurtownia_danych] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [hurtownia_danych] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [hurtownia_danych] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [hurtownia_danych] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [hurtownia_danych] SET ARITHABORT OFF 
GO

ALTER DATABASE [hurtownia_danych] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [hurtownia_danych] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [hurtownia_danych] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [hurtownia_danych] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [hurtownia_danych] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [hurtownia_danych] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [hurtownia_danych] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [hurtownia_danych] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [hurtownia_danych] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [hurtownia_danych] SET  ENABLE_BROKER 
GO

ALTER DATABASE [hurtownia_danych] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [hurtownia_danych] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [hurtownia_danych] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [hurtownia_danych] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [hurtownia_danych] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [hurtownia_danych] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [hurtownia_danych] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [hurtownia_danych] SET RECOVERY FULL 
GO

ALTER DATABASE [hurtownia_danych] SET  MULTI_USER 
GO

ALTER DATABASE [hurtownia_danych] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [hurtownia_danych] SET DB_CHAINING OFF 
GO

ALTER DATABASE [hurtownia_danych] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [hurtownia_danych] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [hurtownia_danych] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [hurtownia_danych] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [hurtownia_danych] SET QUERY_STORE = ON
GO

ALTER DATABASE [hurtownia_danych] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [hurtownia_danych] SET  READ_WRITE 
GO


-- table creation

USE [hurtownia_danych]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[historia_eksportow](
	[id] [int] NOT NULL,
	[nazwa] [varchar](100) NULL,
	[data_eksportu] [datetime] NULL,
	[nazwa_uzytkownika] [varchar](100) NULL,
	[lokal] [varchar](100) NULL
) ON [PRIMARY]
GO



-- view creation
USE [hurtownia_danych]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_historia_eksportow] AS
SELECT 
    id,
    nazwa AS 'Nazwa',
    CONVERT(DATE, data_eksportu) AS 'Data',
    FORMAT(data_eksportu, 'HH:mm') AS 'Godzina',
    nazwa_uzytkownika AS 'Użytkownik',
    lokal AS 'Lokal' 
FROM historia_eksportow;
GO

