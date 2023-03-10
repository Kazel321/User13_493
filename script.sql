USE [master]
GO
/****** Object:  Database [User13_493]    Script Date: 04.03.2023 16:02:04 ******/
CREATE DATABASE [User13_493]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'User13_493', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LOCAL\MSSQL\DATA\User13_493.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'User13_493_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LOCAL\MSSQL\DATA\User13_493_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [User13_493] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [User13_493].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [User13_493] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [User13_493] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [User13_493] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [User13_493] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [User13_493] SET ARITHABORT OFF 
GO
ALTER DATABASE [User13_493] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [User13_493] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [User13_493] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [User13_493] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [User13_493] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [User13_493] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [User13_493] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [User13_493] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [User13_493] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [User13_493] SET  ENABLE_BROKER 
GO
ALTER DATABASE [User13_493] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [User13_493] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [User13_493] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [User13_493] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [User13_493] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [User13_493] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [User13_493] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [User13_493] SET RECOVERY FULL 
GO
ALTER DATABASE [User13_493] SET  MULTI_USER 
GO
ALTER DATABASE [User13_493] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [User13_493] SET DB_CHAINING OFF 
GO
ALTER DATABASE [User13_493] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [User13_493] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [User13_493] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [User13_493] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'User13_493', N'ON'
GO
ALTER DATABASE [User13_493] SET QUERY_STORE = OFF
GO
USE [User13_493]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturer]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerId] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[StatusId] [int] NOT NULL,
	[OrderDeliveryDate] [datetime] NOT NULL,
	[PickupPointId] [int] NOT NULL,
	[OrderClientName] [nvarchar](max) NULL,
	[OrderCode] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[OrderId] [int] NOT NULL,
	[ProductArticleNumber] [nvarchar](100) NOT NULL,
	[OrderProductCount] [int] NOT NULL,
 CONSTRAINT [PK__OrderPro__817A2602B9A5C411] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductArticleNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PickupPoint]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PickupPoint](
	[PickupPointId] [int] IDENTITY(1,1) NOT NULL,
	[PickupPointName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PickupPointId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductArticleNumber] [nvarchar](100) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[UnitId] [int] NOT NULL,
	[ProductCost] [float] NOT NULL,
	[ProductDiscountMax] [tinyint] NOT NULL,
	[ManufacturerId] [int] NOT NULL,
	[ProviderId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductDiscountNow] [tinyint] NOT NULL,
	[ProductQuantityInStock] [int] NOT NULL,
	[ProductDescription] [nvarchar](max) NULL,
	[ProductImage] [nvarchar](max) NULL,
 CONSTRAINT [PK__Product__2EA7DCD5EB189185] PRIMARY KEY CLUSTERED 
(
	[ProductArticleNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ProviderId] [int] IDENTITY(1,1) NOT NULL,
	[ProviderName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProviderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitId] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 04.03.2023 16:02:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserFullName] [nvarchar](max) NOT NULL,
	[UserLogin] [nvarchar](max) NOT NULL,
	[UserPassword] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK__User__1788CC4CB49FAF46] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Спортивный инвентарь')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'Одежда')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufacturer] ON 

INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (1, N'X-Match')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (2, N'Perfetto Sport')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (3, N'ROMANA Next')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (4, N'Moby Kids')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (5, N'playToday')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (6, N'Совтехстром')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (7, N'Abtoys')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (8, N'DFC')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (9, N'Nordway')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (10, N'Ridex')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (11, N'Salomon')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (12, N'Mikasa')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (13, N'Molten')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (14, N'Colton')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (15, N'Atemi')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (16, N'Green Hill')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (17, N'SKIF')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (18, N'Starfit')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (19, N'Bradex')
INSERT [dbo].[Manufacturer] ([ManufacturerId], [ManufacturerName]) VALUES (20, N'Demix')
SET IDENTITY_INSERT [dbo].[Manufacturer] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (1, CAST(N'2022-05-15T00:00:00.000' AS DateTime), 1, CAST(N'2022-05-21T00:00:00.000' AS DateTime), 18, N'Поляков Степан Егорович', 401)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (2, CAST(N'2022-05-16T00:00:00.000' AS DateTime), 1, CAST(N'2022-05-22T00:00:00.000' AS DateTime), 20, N'Леонова Алиса Кирилловна', 402)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (3, CAST(N'2022-05-17T00:00:00.000' AS DateTime), 2, CAST(N'2022-05-23T00:00:00.000' AS DateTime), 20, N'Яковлев Платон Константинович', 403)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (4, CAST(N'2022-05-18T00:00:00.000' AS DateTime), 1, CAST(N'2022-05-24T00:00:00.000' AS DateTime), 22, N'Ковалева Ева Яковлевна', 404)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (5, CAST(N'2022-05-19T00:00:00.000' AS DateTime), 1, CAST(N'2022-05-25T00:00:00.000' AS DateTime), 22, N'', 405)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (6, CAST(N'2022-05-19T00:00:00.000' AS DateTime), 1, CAST(N'2022-05-25T00:00:00.000' AS DateTime), 16, N'', 406)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (7, CAST(N'2022-05-21T00:00:00.000' AS DateTime), 2, CAST(N'2022-05-27T00:00:00.000' AS DateTime), 16, N'', 407)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (8, CAST(N'2022-05-22T00:00:00.000' AS DateTime), 2, CAST(N'2022-05-28T00:00:00.000' AS DateTime), 18, N'', 408)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (9, CAST(N'2022-05-23T00:00:00.000' AS DateTime), 1, CAST(N'2022-05-29T00:00:00.000' AS DateTime), 24, N'', 409)
INSERT [dbo].[Order] ([OrderId], [OrderDate], [StatusId], [OrderDeliveryDate], [PickupPointId], [OrderClientName], [OrderCode]) VALUES (10, CAST(N'2022-05-24T00:00:00.000' AS DateTime), 2, CAST(N'2022-05-30T00:00:00.000' AS DateTime), 24, N'', 410)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (1, N'G598Y6', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (1, N'А112Т4', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (2, N'D830R5', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (2, N'F746E6', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (3, N'D648N7', 10)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (3, N'F735B6', 10)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (4, N'E324U7', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (4, N'F937G4', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (5, N'D038G6', 10)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (5, N'N483G5', 10)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (6, N'C324S5', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (6, N'G480F5', 2)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (7, N'J4DF5E', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (7, N'V312R4', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (8, N'G522B5', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (8, N'K432G6', 3)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (9, N'F047J7', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (9, N'S374B5', 1)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (10, N'D927K3', 5)
INSERT [dbo].[OrderProduct] ([OrderId], [ProductArticleNumber], [OrderProductCount]) VALUES (10, N'N836R5', 5)
GO
SET IDENTITY_INSERT [dbo].[PickupPoint] ON 

INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (1, N'344288, г. Дубна, ул. Чехова, 1')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (2, N'614164, г.Дубна,  ул. Степная, 30')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (3, N'394242, г. Дубна, ул. Коммунистическая, 43')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (4, N'660540, г. Дубна, ул. Солнечная, 25')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (5, N'125837, г. Дубна, ул. Шоссейная, 40')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (6, N'125703, г. Дубна, ул. Партизанская, 49')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (7, N'625283, г. Дубна, ул. Победы, 46')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (8, N'614611, г. Дубна, ул. Молодежная, 50')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (9, N'454311, г.Дубна, ул. Новая, 19')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (10, N'660007, г.Дубна, ул. Октябрьская, 19')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (11, N'603036, г. Дубна, ул. Садовая, 4')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (12, N'450983, г.Дубна, ул. Комсомольская, 26')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (13, N'394782, г. Дубна, ул. Чехова, 3')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (14, N'603002, г. Дубна, ул. Дзержинского, 28')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (15, N'450558, г. Дубна, ул. Набережная, 30')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (16, N'394060, г.Дубна, ул. Фрунзе, 43')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (17, N'410661, г. Дубна, ул. Школьная, 50')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (18, N'625590, г. Дубна, ул. Коммунистическая, 20')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (19, N'625683, г. Дубна, ул. 8 Марта')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (20, N'400562, г. Дубна, ул. Зеленая, 32')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (21, N'614510, г. Дубна, ул. Маяковского, 47')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (22, N'410542, г. Дубна, ул. Светлая, 46')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (23, N'620839, г. Дубна, ул. Цветочная, 8')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (24, N'443890, г. Дубна, ул. Коммунистическая, 1')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (25, N'603379, г. Дубна, ул. Спортивная, 46')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (26, N'603721, г. Дубна, ул. Гоголя, 41')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (27, N'410172, г. Дубна, ул. Северная, 13')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (28, N'420151, г. Дубна, ул. Вишневая, 32')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (29, N'125061, г. Дубна, ул. Подгорная, 8')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (30, N'630370, г. Дубна, ул. Шоссейная, 24')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (31, N'614753, г. Дубна, ул. Полевая, 35')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (32, N'426030, г. Дубна, ул. Маяковского, 44')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (33, N'450375, г. Дубна ул. Клубная, 44')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (34, N'625560, г. Дубна, ул. Некрасова, 12')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (35, N'630201, г. Дубна, ул. Комсомольская, 17')
INSERT [dbo].[PickupPoint] ([PickupPointId], [PickupPointName]) VALUES (36, N'190949, г. Дубна, ул. Мичурина, 26')
SET IDENTITY_INSERT [dbo].[PickupPoint] OFF
GO
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'1dsadas', N'dasdsad', 1, 1, 0, 1, 1, 1, 0, 0, N'', N'1dsadas.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'B538G6', N'Спортивный костюм', 1, 839, 5, 5, 1, 2, 3, 17, N'Спортивный костюм playToday (футболка + шорты)', N'B538G6.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'C324S5', N'Шлем', 1, 4000, 10, 11, 2, 1, 5, 16, N'Шлем г.л./сноуб. Salomon Grom р.:KS черный (L40836800)', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'D038G6', N'Лыжный комплект', 1, 3000, 30, 9, 2, 1, 4, 23, N'Лыжный комплект беговые NORDWAY XC Classic, 45-45-45мм, 160см', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'D648N7', N'Набор для хоккея', 1, 350, 10, 6, 2, 1, 4, 7, N'Набор для хоккея Совтехстром', N'D648N7.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'D830R5', N'Тренажер прыжков', 1, 1120, 15, 4, 1, 1, 4, 8, N'Тренажер для прыжков Moby Kids Moby-Jumper со счетчиком', N'D830R5.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'D893W4', N'Мяч', 1, 900, 5, 20, 1, 1, 2, 5, N'Мяч футбольный DEMIX 1STLS1JWWW, универсальный, 4-й размер, белый/зеленый', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'D927K3', N'Перчатки ', 1, 660, 15, 18, 2, 1, 4, 3, N'Перчатки Starfit SU-125 атлетические S черный', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'E324U7', N'Велотренажер', 1, 6480, 25, 8, 1, 1, 5, 5, N'Велотренажер двойной DFC B804 dual bike', N'E324U7.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'F047J7', N'Коврик', 1, 720, 15, 19, 1, 1, 5, 11, N'Коврик Bradex для мягкой йоги дл.:1730мм ш.:610мм т.:3мм серый', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'F687G5', N'Защита голени', 1, 1900, 15, 16, 1, 1, 4, 6, N'Защита голени GREEN HILL Panther, L, синий/черный', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'F735B6', N'Игровой набор', 1, 320, 15, 6, 2, 1, 2, 9, N'Игровой набор Совтехстром Кегли и шары', N'F735B6.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'F746E6', N'Шведская стенка', 1, 9900, 10, 3, 2, 1, 3, 5, N'Шведская стенка ROMANA Next, pastel', N'F746E6.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'F937G4', N'Игровой набор', 1, 480, 10, 7, 1, 1, 4, 12, N'Набор Abtoys Бадминтон и теннис ', N'F937G4.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'G403T5', N'Тюбинг', 1, 1450, 15, 9, 1, 1, 4, 13, N'Тюбинг Nordway, 73 см', N'G403T5.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'G480F5', N'Ролики', 1, 1600, 15, 10, 1, 1, 4, 7, N'Коньки роликовые Ridex Cricket жен. ABEC 3 кол.:72мм р.:39-42 синий', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'G522B5', N'Ласты', 1, 1980, 15, 14, 2, 1, 3, 6, N'Ласты Colton CF-02 для плавания р.:33-34 серый/голубой', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'G598Y6', N'Спортивный мат', 1, 2390, 15, 2, 2, 1, 2, 16, N'Спортивный мат 100x100x10 см Perfetto Sport № 3 бежевый', N'G598Y6.jpg')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'G873H4', N'Велосипед', 1, 14930, 5, 17, 1, 1, 4, 6, N'Велосипед SKIF 29 Disc (2021), горный (взрослый), рама: 17", колеса: 29", темно-серый', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'J4DF5E', N'Насос', 1, 300, 5, 13, 1, 1, 4, 12, N'Насос Molten HP-18-B для мячей мультиколор', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'J532D4', N'Перчатки для карате', 1, 1050, 15, 16, 1, 1, 3, 5, N'Перчатки для каратэ Green Hill KMС-6083 L красный', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'K432G6', N'Шапочка для плавания', 1, 440, 25, 15, 2, 1, 5, 17, N'Шапочка для плавания Atemi PU 140 ткань с покрытием желтый', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'K937A5', N'Гиря', 1, 890, 5, 18, 2, 1, 4, 10, N'Гиря Starfit ГМБ4 мягкое 4кг синий/оранжевый', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'N483G5', N'Клюшка', 1, 1299, 10, 9, 2, 1, 3, 4, N'Клюшка Nordway NDW300 (2019/2020) SR лев. 19 150см', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'N836R5', N'Коньки', 1, 2000, 10, 15, 2, 1, 3, 16, N'Коньки ATEMI AKSK01DXS, раздвижные, прогулочные, унисекс, 27-30, черный/зеленый', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'N892G6', N'Очки для плавания', 1, 500, 5, 15, 2, 1, 5, 14, N'Очки для плавания Atemi N8401 синий', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'S374B5', N'Ролик для йоги', 1, 700, 10, 19, 1, 1, 3, 12, N'Ролик для йоги Bradex Туба d=14см ш.:33см оранжевый', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'V312R4', N'Мяч', 1, 4150, 20, 12, 2, 1, 2, 5, N'Мяч волейбольный MIKASA VT370W, для зала, 5-й размер, желтый/синий', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'V392H7', N'Степ-платформа', 1, 4790, 10, 18, 1, 1, 3, 15, N'Степ-платформа Starfit SP-204 серый/черный', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'V423D4', N'Штанга', 1, 5600, 10, 18, 2, 1, 3, 8, N'Штанга Starfit BB-401 30кг пласт. черный ', N'')
INSERT [dbo].[Product] ([ProductArticleNumber], [ProductName], [UnitId], [ProductCost], [ProductDiscountMax], [ManufacturerId], [ProviderId], [CategoryId], [ProductDiscountNow], [ProductQuantityInStock], [ProductDescription], [ProductImage]) VALUES (N'А112Т4', N'Боксерская груша', 1, 778, 30, 1, 1, 1, 5, 6, N'Боксерская груша X-Match черная', N'А112Т4.jpg')
GO
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (1, N'Спортмастер')
INSERT [dbo].[Provider] ([ProviderId], [ProviderName]) VALUES (2, N'Декатлон')
SET IDENTITY_INSERT [dbo].[Provider] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Администратор')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Менеджер')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (3, N'Клиент')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (1, N'Новый ')
INSERT [dbo].[Status] ([StatusId], [StatusName]) VALUES (2, N'Завершен')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Unit] ON 

INSERT [dbo].[Unit] ([UnitId], [UnitName]) VALUES (1, N'шт.')
SET IDENTITY_INSERT [dbo].[Unit] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (1, 1, N'Пахомова Аиша Анатольевна', N'm4ic8j5qgstw@gmail.com', N'2L6KZG')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (2, 1, N'Жуков Роман Богданович', N'd43zfg9tlsyv@gmail.com', N'uzWC67')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (3, 1, N'Киселева Анастасия Максимовна', N'8ohgisf6k45w@outlook.com', N'8ntwUp')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (4, 2, N'Григорьева Арина Арсентьевна', N'hi1brwj46czx@mail.com', N'YOyhfR')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (5, 2, N'Иванов Лев Михайлович', N'fvkbcamhlj52@gmail.com', N'RSbvHv')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (6, 2, N'Григорьев Лев Давидович', N'9qxnce8jwruv@gmail.com', N'rwVDh9')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (7, 3, N'Поляков Степан Егорович', N'dotiex942p1r@gmail.com', N'LdNyos')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (8, 3, N'Леонова Алиса Кирилловна', N'n0bmi2h1xral@tutanota.com', N'gynQMT')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (9, 3, N'Яковлев Платон Константинович', N'sfm3t278kdvz@yahoo.com', N'AtnDjr')
INSERT [dbo].[User] ([UserId], [RoleId], [UserFullName], [UserLogin], [UserPassword]) VALUES (10, 3, N'Ковалева Ева Яковлевна', N'ilb8rdut0v7e@mail.com', N'JlFRCZ')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([PickupPointId])
REFERENCES [dbo].[PickupPoint] ([PickupPointId])
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK__OrderProd__Order__3E52440B] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK__OrderProd__Order__3E52440B]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK__OrderProd__Produ__3F466844] FOREIGN KEY([ProductArticleNumber])
REFERENCES [dbo].[Product] ([ProductArticleNumber])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK__OrderProd__Produ__3F466844]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK__Product__Categor__3B75D760] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK__Product__Categor__3B75D760]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK__Product__Manufac__398D8EEE] FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[Manufacturer] ([ManufacturerId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK__Product__Manufac__398D8EEE]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK__Product__Provide__3A81B327] FOREIGN KEY([ProviderId])
REFERENCES [dbo].[Provider] ([ProviderId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK__Product__Provide__3A81B327]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK__Product__UnitId__38996AB5] FOREIGN KEY([UnitId])
REFERENCES [dbo].[Unit] ([UnitId])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK__Product__UnitId__38996AB5]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK__User__RoleId__267ABA7A] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK__User__RoleId__267ABA7A]
GO
USE [master]
GO
ALTER DATABASE [User13_493] SET  READ_WRITE 
GO
