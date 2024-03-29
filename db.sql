USE [master]
GO
/****** Object:  Database [Proxit]    Script Date: 03/20/2012 22:40:08 ******/
CREATE DATABASE [Proxit] ON  PRIMARY 
( NAME = N'Proxit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Proxit.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Proxit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Proxit_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Proxit] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proxit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proxit] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Proxit] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Proxit] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Proxit] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Proxit] SET ARITHABORT OFF
GO
ALTER DATABASE [Proxit] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Proxit] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Proxit] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Proxit] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Proxit] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Proxit] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Proxit] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Proxit] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Proxit] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Proxit] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Proxit] SET  DISABLE_BROKER
GO
ALTER DATABASE [Proxit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Proxit] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Proxit] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Proxit] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Proxit] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Proxit] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Proxit] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Proxit] SET  READ_WRITE
GO
ALTER DATABASE [Proxit] SET RECOVERY FULL
GO
ALTER DATABASE [Proxit] SET  MULTI_USER
GO
ALTER DATABASE [Proxit] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Proxit] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proxit', N'ON'
GO
USE [Proxit]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 03/20/2012 22:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[klantid] [int] NULL,
	[gebruikerid] [int] NULL,
	[datetime] [datetime2](7) NULL,
	[prioritair] [bit] NULL,
	[tickettype] [int] NOT NULL,
	[status] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ticket_items]    Script Date: 03/20/2012 22:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ticketid] [int] NOT NULL,
	[timestamp] [datetime2](7) NOT NULL,
	[productid] [int] NULL,
	[dienstid] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productenlijst]    Script Date: 03/20/2012 22:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productenlijst](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[typeid] [int] NOT NULL,
	[serienummer] [varchar](100) NULL,
	[inkoopdatum] [date] NULL,
	[verkoopdatum] [date] NULL,
	[verkoopprijs] [float] NULL,
	[inkoopprijs] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producten]    Script Date: 03/20/2012 22:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producten](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[productnaam] [nchar](10) NOT NULL,
	[btwtarief] [nchar](10) NOT NULL,
	[verkoopprijs] [nchar](10) NOT NULL,
	[garantietermijn] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gebruikers]    Script Date: 03/20/2012 22:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gebruikers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[wachtwoord] [varchar](max) NOT NULL,
	[emailadres] [nvarchar](150) NOT NULL,
	[voornaam] [nvarchar](50) NULL,
	[achternaam] [nvarchar](50) NULL,
	[telefoon] [nchar](15) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diensten_tijden]    Script Date: 03/20/2012 22:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diensten_tijden](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dienstid] [int] NOT NULL,
	[omschrijving] [varchar](255) NULL,
	[looptijd] [int] NOT NULL,
	[standaardprijs] [float] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diensten_klanten]    Script Date: 03/20/2012 22:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diensten_klanten](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[klantid] [int] NULL,
	[dienst_tijd_id] [int] NULL,
	[prijs] [int] NULL,
	[vervaldatum] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diensten]    Script Date: 03/20/2012 22:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diensten](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[naam] [varchar](max) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Table_1_priority]    Script Date: 03/20/2012 22:40:10 ******/
ALTER TABLE [dbo].[Tickets] ADD  CONSTRAINT [DF_Table_1_priority]  DEFAULT ((0)) FOR [prioritair]
GO
