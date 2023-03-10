USE [master]
GO
/****** Object:  Database [KashitsinAromatnyMir]    Script Date: 15.12.2022 15:34:32 ******/
CREATE DATABASE [KashitsinAromatnyMir]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KashitsinAromatnyMir', FILENAME = N'D:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\KashitsinAromatnyMir.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KashitsinAromatnyMir_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\KashitsinAromatnyMir_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [KashitsinAromatnyMir] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KashitsinAromatnyMir].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KashitsinAromatnyMir] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET ARITHABORT OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET  MULTI_USER 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KashitsinAromatnyMir] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KashitsinAromatnyMir] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [KashitsinAromatnyMir] SET QUERY_STORE = OFF
GO
USE [KashitsinAromatnyMir]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 15.12.2022 15:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 15.12.2022 15:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerID] [int] NOT NULL,
	[ManufacturerName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[ManufacturerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 15.12.2022 15:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductArticle] [nvarchar](30) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductUnit] [int] NOT NULL,
	[ProductCost] [decimal](19, 2) NOT NULL,
	[ProductManufacturer] [int] NOT NULL,
	[ProductProvider] [int] NOT NULL,
	[ProductCategory] [int] NOT NULL,
	[ProductDiscount] [int] NULL,
	[ProductMaxDiscount] [int] NULL,
	[ProductQuantity] [int] NOT NULL,
	[ProductDescription] [nvarchar](max) NOT NULL,
	[ProductPhoto] [image] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductArticle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 15.12.2022 15:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderID] [int] NOT NULL,
	[ProviderName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ProviderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 15.12.2022 15:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] NOT NULL,
	[RoleName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 15.12.2022 15:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [int] NOT NULL,
	[UnitName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 15.12.2022 15:34:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] NOT NULL,
	[UserSurname] [nvarchar](30) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[UserPatronymic] [nvarchar](30) NOT NULL,
	[UserLogin] [nvarchar](50) NOT NULL,
	[UserPassword] [nvarchar](20) NOT NULL,
	[UserRole] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Женский парфюм')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Мужской парфюм')
GO
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName]) VALUES (1, N'Chanel')
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName]) VALUES (2, N'Lsncoma')
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName]) VALUES (3, N'Lanvin
')
INSERT [dbo].[Manufacturer] ([ManufacturerID], [ManufacturerName]) VALUES (4, N'Dolce & Gabbana
')
GO
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'B320R5', N'Духи', 1, CAST(4300.00 AS Decimal(19, 2)), 2, 2, 1, 2, 15, 6, N'Цветочный аромат', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'B431R5', N'Одеколон', 1, CAST(2700.00 AS Decimal(19, 2)), 4, 2, 2, 2, 10, 5, N'Входит в набор', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'C436G5', N'Духи', 1, CAST(10200.00 AS Decimal(19, 2)), 4, 3, 1, 2, 15, 9, N'Объекм 100 мл', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'D268G5', N'Одеколон', 1, CAST(4399.00 AS Decimal(19, 2)), 1, 1, 2, 3, 10, 12, N'Ванильный аромат', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'D329H3', N'Туалетная вода', 1, CAST(1890.00 AS Decimal(19, 2)), 4, 2, 1, 4, 10, 4, N'Туалетная вода для женщин', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'D364R4', N'Духи', 1, CAST(12400.00 AS Decimal(19, 2)), 1, 3, 1, 2, 10, 5, N'Аромат чайной розы', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'D572U8', N'Духи', 1, CAST(4100.00 AS Decimal(19, 2)), 4, 3, 1, 3, 5, 6, N'Аромат чайной розы', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'E482R4', N'Одеколон', 1, CAST(1800.00 AS Decimal(19, 2)), 2, 1, 2, 2, 15, 14, N'Оформление в красивой упаковке', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'F427R5', N'Одеколон', 1, CAST(11800.00 AS Decimal(19, 2)), 1, 3, 2, 4, 10, 11, N'Поставляется вместе с галстуком', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'F572H7', N'Одеколон', 1, CAST(2700.00 AS Decimal(19, 2)), 3, 1, 2, 2, 15, 14, N'Объекм 100 мл', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'F635R4', N'Туалетная вода', 1, CAST(3244.00 AS Decimal(19, 2)), 2, 2, 1, 2, 20, 13, N'Туалетная вода 100 мл', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'G432E4', N'Спрей', 1, CAST(2800.00 AS Decimal(19, 2)), 1, 1, 2, 3, 10, 15, N'Терпкий аромат для мужщин', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'G531F4', N'Туалетная вода', 1, CAST(6600.00 AS Decimal(19, 2)), 3, 4, 2, 2, 5, 9, N'Подарочный вариант', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'G783F5', N'Спрей', 1, CAST(5900.00 AS Decimal(19, 2)), 1, 3, 1, 2, 25, 8, N'Легкий спрей', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'H535R5', N'Спрей', 1, CAST(2300.00 AS Decimal(19, 2)), 1, 2, 2, 2, 25, 7, N'Аромат морской волны', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'H782T5', N'Одеколон', 1, CAST(4499.00 AS Decimal(19, 2)), 3, 2, 2, 4, 30, 5, N'Насыщенный аромат', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'J384T6', N'Духи', 1, CAST(3800.00 AS Decimal(19, 2)), 1, 4, 1, 2, 10, 16, N'Концентрированные дихи', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'J542F5', N'Спрей', 1, CAST(500.00 AS Decimal(19, 2)), 1, 3, 2, 3, 5, 12, N'Объекм 100 мл', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'K345R4', N'Духи', 1, CAST(2100.00 AS Decimal(19, 2)), 1, 3, 1, 2, 15, 3, N'Цветочный аромат', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'K358H6', N'Духи', 1, CAST(599.00 AS Decimal(19, 2)), 2, 4, 1, 3, 5, 2, N'Концентрированные дихи', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'L754R4', N'Одеколон', 1, CAST(1700.00 AS Decimal(19, 2)), 2, 2, 2, 2, 10, 7, N'Аромат морской волны', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'M542T5', N'Духи', 1, CAST(2800.00 AS Decimal(19, 2)), 2, 3, 1, 5, 5, 3, N'Сладкий аромат', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'N457T5', N'Одеколон', 1, CAST(4600.00 AS Decimal(19, 2)), 3, 2, 2, 3, 5, 13, N'Максимальный объем', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'O754F4', N'Духи', 1, CAST(5400.00 AS Decimal(19, 2)), 4, 3, 1, 4, 10, 18, N'Насыщенный аромат', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'P764G4', N'Духи', 1, CAST(6800.00 AS Decimal(19, 2)), 3, 3, 1, 3, 30, 15, N'Концентрированные дихи', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'S213E3', N'Туалетная вода', 1, CAST(2156.00 AS Decimal(19, 2)), 4, 2, 2, 3, 5, 6, N'Аромат морской волны', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'S326R5', N'Туалетная вода', 1, CAST(9900.00 AS Decimal(19, 2)), 3, 1, 1, 3, 15, 15, N'Концентрированные дихи', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'S634B5', N'Спрей', 1, CAST(5500.00 AS Decimal(19, 2)), 1, 4, 2, 3, 20, 6, N'Объекм 100 мл', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'T324F5', N'Туалетная вода', 1, CAST(4699.00 AS Decimal(19, 2)), 3, 3, 1, 2, 15, 5, N'Цветочный аромат', NULL)
INSERT [dbo].[Product] ([ProductArticle], [ProductName], [ProductUnit], [ProductCost], [ProductManufacturer], [ProductProvider], [ProductCategory], [ProductDiscount], [ProductMaxDiscount], [ProductQuantity], [ProductDescription], [ProductPhoto]) VALUES (N'А112Т4', N'Духи', 1, CAST(4990.00 AS Decimal(19, 2)), 1, 1, 1, 3, 30, 6, N'Женские духи с толким ароматом', NULL)
GO
INSERT [dbo].[Provider] ([ProviderID], [ProviderName]) VALUES (1, N'NDK PARFUM
')
INSERT [dbo].[Provider] ([ProviderID], [ProviderName]) VALUES (2, N'Парфюм для дома')
INSERT [dbo].[Provider] ([ProviderID], [ProviderName]) VALUES (3, N'Elivero')
INSERT [dbo].[Provider] ([ProviderID], [ProviderName]) VALUES (4, N'GN-GROUP')
GO
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Администратор
')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Менеджер')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (3, N'Клиент')
GO
INSERT [dbo].[Unit] ([UnitID], [UnitName]) VALUES (1, N'шт.       ')
GO
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (1, N'Федоров', N'Глеб', N'Михайлович', N'o@outlook.com', N'2L6KZG', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (2, N'Семенова', N'Софья', N'Дмитриевна', N'hr6zdl@yandex.ru', N'uzWC67', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (3, N'Васильев', N'Егор', N'Германович', N'kaft93x@outlook.com', N'8ntwUp', 1)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (4, N'Смирнова', N'Ирина', N'Александровна', N'dcu@yandex.ru', N'YOyhfR', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (5, N'Петров', N'Андрей', N'Владимирович', N'19dn@outlook.com', N'RSbvHv', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (6, N'Егоров', N'Максим', N'Андреевич', N'pa5h@mail.ru', N'rwVDh9', 2)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (7, N'Никитин', N'Артур', N'Алексеевич', N'281av0@gmail.com', N'LdNyos', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (8, N'Киселев', N'Максим', N'Сергеевич', N'8edmfh@outlook.com', N'gynQMT', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (9, N'Борисов', N'Тимур', N'Егорович', N'sfn13i@mail.ru', N'AtnDjr', 3)
INSERT [dbo].[User] ([UserID], [UserSurname], [UserName], [UserPatronymic], [UserLogin], [UserPassword], [UserRole]) VALUES (10, N'Климов', N'Арсений', N'Тимурович', N'g0orc3x1@outlook.com', N'JlFRCZ', 3)
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([ProductCategory])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Manufacturer] FOREIGN KEY([ProductManufacturer])
REFERENCES [dbo].[Manufacturer] ([ManufacturerID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Manufacturer]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Provider] FOREIGN KEY([ProductProvider])
REFERENCES [dbo].[Provider] ([ProviderID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Provider]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Unit] FOREIGN KEY([ProductUnit])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Unit]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([UserRole])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [KashitsinAromatnyMir] SET  READ_WRITE 
GO
