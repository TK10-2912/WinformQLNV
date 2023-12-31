USE [master]
GO
/****** Object:  Database [QLNV]    Script Date: 13/12/2023 12:24:14 SA ******/
CREATE DATABASE [QLNV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNV', FILENAME = N'G:\sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLNV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNV_log', FILENAME = N'G:\sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLNV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLNV] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLNV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLNV] SET  MULTI_USER 
GO
ALTER DATABASE [QLNV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLNV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLNV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLNV', N'ON'
GO
ALTER DATABASE [QLNV] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLNV] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLNV]
GO
/****** Object:  Table [dbo].[HeSoLuong]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeSoLuong](
	[MaHSL] [int] IDENTITY(1,1) NOT NULL,
	[TenHSL] [nvarchar](50) NOT NULL,
	[LuongThang] [float] NOT NULL,
	[LuongPhuCap] [float] NOT NULL,
 CONSTRAINT [PK__HeSoLuon__3C901128DF5476ED] PRIMARY KEY CLUSTERED 
(
	[MaHSL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[MaLuong] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[MaHSL] [int] NOT NULL,
	[SoNgayCong] [int] NOT NULL,
	[SoNgayLamThem] [int] NOT NULL,
	[Phat] [float] NOT NULL,
	[LuongThucLinh] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[Hoten] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NgaySinh] [datetime] NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[MaPhongBan] [int] NOT NULL,
	[MaChucVu] [int] NOT NULL,
	[MaHSL] [int] NOT NULL,
	[AU_ID] [varchar](20) NULL,
 CONSTRAINT [PK__NhanVien__77B2CA47988A3D80] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewLuongNV]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewLuongNV] AS
SELECT
    nhanvien.Hoten,
    luong.thang,
    luong.Nam,
	luong.Phat,
	hesoluong.TenHSL,
	luong.SoNgayCong,
	luong.SoNgayLamThem
	
FROM
    luong 
JOIN
    nhanvien  ON nhanvien.MaNhanVien = luong.MaNhanVien
Join hesoluong on luong.MaHSL=hesoluong.MaHSL;
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[HoVaTen] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayCapNhat] [datetime] NOT NULL,
 CONSTRAINT [PK__NguoiDun__C539D76215D0A4A5] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [int] IDENTITY(1,1) NOT NULL,
	[TenPhongBan] [nvarchar](50) NOT NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiGianCongTac]    Script Date: 13/12/2023 12:24:15 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiGianCongTac](
	[MaCongTac] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaChucVu] [int] NOT NULL,
	[NgayNhanChuc] [datetime] NOT NULL,
 CONSTRAINT [PK__ThoiGian__77B2CA476ECE6374] PRIMARY KEY CLUSTERED 
(
	[MaCongTac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  CONSTRAINT [DF_NguoiDung_NgayTao]  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  CONSTRAINT [DF_NguoiDung_NgayCapNhat]  DEFAULT (getdate()) FOR [NgayCapNhat]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_HeSoLuong] FOREIGN KEY([MaHSL])
REFERENCES [dbo].[HeSoLuong] ([MaHSL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_HeSoLuong]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_HeSoLuong] FOREIGN KEY([MaHSL])
REFERENCES [dbo].[HeSoLuong] ([MaHSL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_HeSoLuong]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[ThoiGianCongTac]  WITH CHECK ADD  CONSTRAINT [FK_ThoiGianCongTac_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThoiGianCongTac] CHECK CONSTRAINT [FK_ThoiGianCongTac_ChucVu]
GO
ALTER TABLE [dbo].[ThoiGianCongTac]  WITH CHECK ADD  CONSTRAINT [FK_ThoiGianCongTac_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[ThoiGianCongTac] CHECK CONSTRAINT [FK_ThoiGianCongTac_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK_gender] CHECK  (([gioitinh]=N'Khác' OR [gioitinh]=N'Nữ' OR [gioitinh]=N'Nam'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK_gender]
GO
USE [master]
GO
ALTER DATABASE [QLNV] SET  READ_WRITE 
GO
