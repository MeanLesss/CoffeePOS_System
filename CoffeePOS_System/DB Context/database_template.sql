﻿USE [master]
GO
/****** Object:  Database [Coffee_POS]    Script Date: 09-Dec-24 12:50:48 AM ******/
CREATE DATABASE [Coffee_POS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Coffee_POS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Coffee_POS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Coffee_POS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Coffee_POS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Coffee_POS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Coffee_POS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Coffee_POS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Coffee_POS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Coffee_POS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Coffee_POS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Coffee_POS] SET ARITHABORT OFF 
GO
ALTER DATABASE [Coffee_POS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Coffee_POS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Coffee_POS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Coffee_POS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Coffee_POS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Coffee_POS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Coffee_POS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Coffee_POS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Coffee_POS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Coffee_POS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Coffee_POS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Coffee_POS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Coffee_POS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Coffee_POS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Coffee_POS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Coffee_POS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Coffee_POS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Coffee_POS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Coffee_POS] SET  MULTI_USER 
GO
ALTER DATABASE [Coffee_POS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Coffee_POS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Coffee_POS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Coffee_POS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Coffee_POS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Coffee_POS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Coffee_POS] SET QUERY_STORE = ON
GO
ALTER DATABASE [Coffee_POS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Coffee_POS]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 09-Dec-24 12:50:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK__Category__3214EC079B49343C] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 09-Dec-24 12:50:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[InvoiceNo] [nchar](10) NULL,
	[Total] [numeric](18, 0) NULL,
	[PaidBy] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[OrderByCode] [nvarchar](50) NULL,
	[ChangeAmount] [numeric](18, 0) NULL,
	[PaidAmount] [numeric](18, 0) NULL,
	[PaidDate] [datetime] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 09-Dec-24 12:50:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[ProductGuid] [uniqueidentifier] NULL,
	[OrderDate] [datetime] NULL,
	[Qty] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[OrderBy] [nvarchar](50) NULL,
	[OrderFrom] [nvarchar](50) NULL,
	[PaidBy] [nvarchar](20) NULL,
	[PaidAmount] [decimal](18, 0) NOT NULL,
	[ChangeAmount] [decimal](18, 0) NULL,
	[Status] [tinyint] NULL,
	[OrderByCode] [nvarchar](50) NULL,
	[InvoiceNo] [nchar](10) NULL,
	[InvoiceGuid] [uniqueidentifier] NULL,
	[ProductName] [nvarchar](50) NULL,
 CONSTRAINT [PK__Sales__3214EC07BB1A5D19] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 09-Dec-24 12:50:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Price] [decimal](18, 0) NULL,
	[Description] [text] NULL,
	[Remark] [nvarchar](250) NULL,
	[ImagePath] [text] NULL,
	[StockCount] [int] NULL,
	[ImportDate] [datetime] NULL,
	[Status] [tinyint] NULL,
	[CategoryGuid] [uniqueidentifier] NULL,
 CONSTRAINT [PK__Products__3214EC07F9A51B63] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09-Dec-24 12:50:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] NOT NULL,
	[Guid] [uniqueidentifier] NOT NULL,
	[Username] [nvarchar](100) NULL,
	[Password] [nvarchar](50) NULL,
	[Status] [tinyint] NULL,
	[Role] [nvarchar](20) NULL,
	[UserCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Guid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_Status]  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products] FOREIGN KEY([ProductGuid])
REFERENCES [dbo].[Products] ([Guid])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryGuid])
REFERENCES [dbo].[Categories] ([Guid])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
USE [master]
GO
ALTER DATABASE [Coffee_POS] SET  READ_WRITE 
GO
	 
USE [Coffee_POS];
GO

-- Insert a default admin user
INSERT INTO [dbo].[Users] ([Guid], [Username], [Password], [Status], [Role], [UserCode])
VALUES 
( 
    NEWID(), -- Generate a new unique identifier for the user
    'admin', -- Default admin username
    '123', -- Password hashed (change the hashing method as needed)
    1, -- Status (1 = Active)
    'Admin', -- Role
    '00000' -- UserCode
);
GO
