USE [master]
GO
/****** Object:  Database [QLNV]    Script Date: 11/12/2023 10:35:43 CH ******/
CREATE DATABASE [QLNV] ON  PRIMARY 
( NAME = N'QLNV', FILENAME = N'G:\sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLNV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNV_log', FILENAME = N'G:\sql\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLNV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
EXEC sys.sp_db_vardecimal_storage_format N'QLNV', N'ON'
GO
USE [QLNV]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/12/2023 10:35:44 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](255) NULL,
	[PhoneNumber] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeSoLuong]    Script Date: 11/12/2023 10:35:44 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 11/12/2023 10:35:44 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[HoVaTen] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayCapNhat] [datetime] NOT NULL,
 CONSTRAINT [PK__NguoiDun__C539D76215D0A4A5] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[SoDienThoai] [nvarchar](20) NULL,
	[MaPhongBan] [int] NOT NULL,
	[MaChucVu] [int] NOT NULL,
	[MaHSL] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 11/12/2023 10:35:44 CH ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrintInfo]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrintInfo](
	[PrintID] [int] NOT NULL,
	[Content] [text] NULL,
	[Format] [varchar](50) NULL,
	[EmployeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PrintID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[StatID] [int] NOT NULL,
	[Month] [int] NULL,
	[Quarter] [int] NULL,
	[Year] [int] NULL,
	[EmployeeCount] [int] NULL,
	[TotalSalary] [decimal](15, 2) NULL,
	[EmployeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryPayments]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryPayments](
	[PaymentID] [int] NOT NULL,
	[EmployeeID] [int] NULL,
	[PaymentDate] [date] NULL,
	[Amount] [decimal](10, 2) NULL,
	[PaymentMethod] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryPolicies]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryPolicies](
	[PolicyID] [int] NOT NULL,
	[BasicSalary] [decimal](10, 2) NULL,
	[Bonus] [decimal](5, 2) NULL,
	[PolicyDescription] [varchar](255) NULL,
	[EmployeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PolicyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SearchInfo]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SearchInfo](
	[SearchID] [int] NOT NULL,
	[Keyword] [varchar](50) NULL,
	[Result] [text] NULL,
	[EmployeeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SearchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiGianCongTac]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiGianCongTac](
	[MaCongTac] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[MaChucVu] [int] NOT NULL,
	[NgayNhanChuc] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nchar](20) NULL,
	[PWord] [nchar](20) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkHistory]    Script Date: 11/12/2023 10:35:44 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkHistory](
	[HistoryID] [int] NOT NULL,
	[EmployeeID] [int] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[JobDescription] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[HistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
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
ALTER TABLE [dbo].[PrintInfo]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[PrintInfo]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[SalaryPayments]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[SalaryPayments]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[SalaryPolicies]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[SalaryPolicies]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[SearchInfo]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[SearchInfo]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[ThoiGianCongTac]  WITH CHECK ADD  CONSTRAINT [FK_ThoiGianCongTac_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ThoiGianCongTac] CHECK CONSTRAINT [FK_ThoiGianCongTac_ChucVu]
GO
ALTER TABLE [dbo].[WorkHistory]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[WorkHistory]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
USE [master]
GO
ALTER DATABASE [QLNV] SET  READ_WRITE 
GO
