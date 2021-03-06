USE [master]
GO
/****** Object:  Database [Osiguranje]    Script Date: 8/30/2020 1:19:57 PM ******/
CREATE DATABASE [Osiguranje]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Osiguranje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Osiguranje.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Osiguranje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Osiguranje_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Osiguranje] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Osiguranje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Osiguranje] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Osiguranje] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Osiguranje] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Osiguranje] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Osiguranje] SET ARITHABORT OFF 
GO
ALTER DATABASE [Osiguranje] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Osiguranje] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Osiguranje] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Osiguranje] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Osiguranje] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Osiguranje] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Osiguranje] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Osiguranje] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Osiguranje] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Osiguranje] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Osiguranje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Osiguranje] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Osiguranje] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Osiguranje] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Osiguranje] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Osiguranje] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Osiguranje] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Osiguranje] SET RECOVERY FULL 
GO
ALTER DATABASE [Osiguranje] SET  MULTI_USER 
GO
ALTER DATABASE [Osiguranje] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Osiguranje] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Osiguranje] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Osiguranje] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Osiguranje] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Osiguranje', N'ON'
GO
ALTER DATABASE [Osiguranje] SET QUERY_STORE = OFF
GO
USE [Osiguranje]
GO
/****** Object:  Table [dbo].[Agent]    Script Date: 8/30/2020 1:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agent](
	[AgentID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Agent] PRIMARY KEY CLUSTERED 
(
	[AgentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 8/30/2020 1:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 8/30/2020 1:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[ClientID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PIB] [nvarchar](50) NULL,
	[RegistrationNumber] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InsurancePolicy]    Script Date: 8/30/2020 1:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InsurancePolicy](
	[PolicyID] [int] NOT NULL,
	[DateFrom] [date] NULL,
	[ExpitarionDate] [date] NULL,
	[Value] [numeric](18, 2) NULL,
	[ClientID] [int] NULL,
	[AgentID] [int] NULL,
 CONSTRAINT [PK_InsurancePolicy] PRIMARY KEY CLUSTERED 
(
	[PolicyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InsuranceType]    Script Date: 8/30/2020 1:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InsuranceType](
	[TypeID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PricePremium] [numeric](18, 2) NULL,
 CONSTRAINT [PK_InsuranceType] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 8/30/2020 1:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ClientID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[JMBG] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PolicyItem]    Script Date: 8/30/2020 1:19:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PolicyItem](
	[PolicyID] [int] NOT NULL,
	[OrdNumber] [int] NOT NULL,
	[Date] [date] NULL,
	[Amount] [numeric](18, 2) NULL,
	[Description] [nvarchar](50) NULL,
	[TypeID] [int] NULL,
 CONSTRAINT [PK_PolicyItem] PRIMARY KEY CLUSTERED 
(
	[PolicyID] ASC,
	[OrdNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Agent] ([AgentID], [FirstName], [LastName], [Username], [Password]) VALUES (1, N'Pera', N'Peric', N'pera', N'pera')
INSERT [dbo].[Agent] ([AgentID], [FirstName], [LastName], [Username], [Password]) VALUES (2, N'Katarina', N'Ilic', N'katarina', N'katarina')
INSERT [dbo].[Client] ([ClientID]) VALUES (1)
INSERT [dbo].[Client] ([ClientID]) VALUES (2)
INSERT [dbo].[Client] ([ClientID]) VALUES (3)
INSERT [dbo].[Company] ([ClientID], [Name], [PIB], [RegistrationNumber], [Address]) VALUES (3, N'Kompanija', N'1234', N'5678', N'Adresa')
INSERT [dbo].[InsurancePolicy] ([PolicyID], [DateFrom], [ExpitarionDate], [Value], [ClientID], [AgentID]) VALUES (1, CAST(N'2020-08-30' AS Date), CAST(N'2021-08-01' AS Date), CAST(7000.00 AS Numeric(18, 2)), 1, 2)
INSERT [dbo].[InsurancePolicy] ([PolicyID], [DateFrom], [ExpitarionDate], [Value], [ClientID], [AgentID]) VALUES (2, CAST(N'2020-08-30' AS Date), CAST(N'2020-12-01' AS Date), CAST(3998.00 AS Numeric(18, 2)), 3, 2)
INSERT [dbo].[InsuranceType] ([TypeID], [Name], [PricePremium]) VALUES (1, N'Type 1', CAST(1000.00 AS Numeric(18, 2)))
INSERT [dbo].[InsuranceType] ([TypeID], [Name], [PricePremium]) VALUES (2, N'Type 2', CAST(3998.00 AS Numeric(18, 2)))
INSERT [dbo].[InsuranceType] ([TypeID], [Name], [PricePremium]) VALUES (3, N'Type 3', CAST(6000.00 AS Numeric(18, 2)))
INSERT [dbo].[Person] ([ClientID], [FirstName], [LastName], [JMBG], [Email], [Phone], [Address]) VALUES (1, N'Pera', N'Peric', N'56789', N'7890', N'6789', N'Address 1')
INSERT [dbo].[Person] ([ClientID], [FirstName], [LastName], [JMBG], [Email], [Phone], [Address]) VALUES (2, N'Zika', N'Zikic', N'67890', N'zika@gmail', N'7890', N'Address 2')
INSERT [dbo].[PolicyItem] ([PolicyID], [OrdNumber], [Date], [Amount], [Description], [TypeID]) VALUES (1, 1, CAST(N'2020-08-30' AS Date), CAST(1000.00 AS Numeric(18, 2)), N'Desc 1', 1)
INSERT [dbo].[PolicyItem] ([PolicyID], [OrdNumber], [Date], [Amount], [Description], [TypeID]) VALUES (1, 2, CAST(N'2020-08-30' AS Date), CAST(6000.00 AS Numeric(18, 2)), N'Desc 2', 3)
INSERT [dbo].[PolicyItem] ([PolicyID], [OrdNumber], [Date], [Amount], [Description], [TypeID]) VALUES (2, 1, CAST(N'2020-08-30' AS Date), CAST(3998.00 AS Numeric(18, 2)), N'Desc', 2)
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Company_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Company_Client]
GO
ALTER TABLE [dbo].[InsurancePolicy]  WITH CHECK ADD  CONSTRAINT [FK_InsurancePolicy_Agent] FOREIGN KEY([AgentID])
REFERENCES [dbo].[Agent] ([AgentID])
GO
ALTER TABLE [dbo].[InsurancePolicy] CHECK CONSTRAINT [FK_InsurancePolicy_Agent]
GO
ALTER TABLE [dbo].[InsurancePolicy]  WITH CHECK ADD  CONSTRAINT [FK_InsurancePolicy_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[InsurancePolicy] CHECK CONSTRAINT [FK_InsurancePolicy_Client]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Client]
GO
ALTER TABLE [dbo].[PolicyItem]  WITH CHECK ADD  CONSTRAINT [FK_PolicyItem_InsurancePolicy] FOREIGN KEY([PolicyID])
REFERENCES [dbo].[InsurancePolicy] ([PolicyID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PolicyItem] CHECK CONSTRAINT [FK_PolicyItem_InsurancePolicy]
GO
ALTER TABLE [dbo].[PolicyItem]  WITH CHECK ADD  CONSTRAINT [FK_PolicyItem_InsuranceType] FOREIGN KEY([TypeID])
REFERENCES [dbo].[InsuranceType] ([TypeID])
GO
ALTER TABLE [dbo].[PolicyItem] CHECK CONSTRAINT [FK_PolicyItem_InsuranceType]
GO
USE [master]
GO
ALTER DATABASE [Osiguranje] SET  READ_WRITE 
GO
