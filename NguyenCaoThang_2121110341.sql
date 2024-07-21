USE [master]
GO
/****** Object:  Database [QLNV_THUEHANGHOA]    Script Date: 11/9/2023 9:02:54 PM ******/
CREATE DATABASE [QLNV_THUEHANGHOA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNV_THUEHANGHOA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLNV_THUEHANGHOA.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLNV_THUEHANGHOA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLNV_THUEHANGHOA_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNV_THUEHANGHOA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET  MULTI_USER 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLNV_THUEHANGHOA]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 11/9/2023 9:02:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[SOHD] [char](2) NOT NULL,
	[MAHH] [nvarchar](3) NOT NULL,
	[SL] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[SOHD] ASC,
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 11/9/2023 9:02:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MAHH] [nvarchar](3) NOT NULL,
	[TENHH] [nvarchar](20) NULL,
	[DONVI] [nvarchar](4) NULL,
	[DONGIA] [numeric](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 11/9/2023 9:02:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[SOHD] [char](2) NOT NULL,
	[MANV] [char](2) NOT NULL,
	[NGAYTAO] [datetime] NULL,
	[KV] [char](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[SOHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOGIN]    Script Date: 11/9/2023 9:02:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGIN](
	[username] [nchar](10) NULL,
	[password] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/9/2023 9:02:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [char](2) NOT NULL,
	[TENNV] [nvarchar](30) NULL,
	[diachi] [nvarchar](20) NULL,
	[DIENTHOAI] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THUEHANGHOA]    Script Date: 11/9/2023 9:02:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THUEHANGHOA](
	[MANV] [char](2) NOT NULL,
	[MAHH] [nvarchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC,
	[MAHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([MAHH])
REFERENCES [dbo].[HANGHOA] ([MAHH])
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD FOREIGN KEY([SOHD])
REFERENCES [dbo].[HOADON] ([SOHD])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[THUEHANGHOA]  WITH CHECK ADD FOREIGN KEY([MAHH])
REFERENCES [dbo].[HANGHOA] ([MAHH])
GO
ALTER TABLE [dbo].[THUEHANGHOA]  WITH CHECK ADD FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
USE [master]
GO
ALTER DATABASE [QLNV_THUEHANGHOA] SET  READ_WRITE 
GO
