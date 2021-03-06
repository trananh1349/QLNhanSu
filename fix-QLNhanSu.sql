USE [master]
GO
/****** Object:  Database [QuanLyNhanSu]    Script Date: 3/12/2020 11:02:21 AM ******/
CREATE DATABASE [QuanLyNhanSu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyNhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyNhanSu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyNhanSu] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNhanSu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNhanSu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNhanSu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyNhanSu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyNhanSu] SET QUERY_STORE = OFF
GO
USE [QuanLyNhanSu]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [varchar](50) NOT NULL,
	[TenCV] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[id] [int] NOT NULL,
	[username] [varchar](255) NULL,
	[password] [varchar](255) NULL,
 CONSTRAINT [PK__DangNhap__3213E83F0C85DE4D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [varchar](50) NOT NULL,
	[LoaiHD] [nvarchar](50) NOT NULL,
	[TuNgay] [datetime] NULL,
	[DenNgay] [datetime] NULL,
	[GhiChu] [varchar](255) NULL,
 CONSTRAINT [PK_HOPDONG] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[MaLuong] [varchar](50) NOT NULL,
	[NgayCong] [varchar](10) NULL,
	[LuongCB] [varchar](50) NULL,
 CONSTRAINT [PK_Luong_1] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[DanToc] [nvarchar](50) NOT NULL,
	[CMTND] [varchar](50) NOT NULL,
	[SDT] [varchar](50) NOT NULL,
	[DiaChi] [varchar](255) NOT NULL,
	[MaPhongBan] [varchar](50) NULL,
	[MaCV] [varchar](50) NULL,
	[MaHD] [varchar](50) NULL,
	[MaTrinhDo] [varchar](50) NULL,
	[MaLuong] [varchar](50) NULL,
 CONSTRAINT [PK_ChiTietHS] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [varchar](50) NOT NULL,
	[TenPhongBan] [nvarchar](50) NOT NULL,
	[DiaDiem] [varchar](255) NULL,
	[MaTP] [varchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDo]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDo](
	[MaTrinhDo] [varchar](50) NOT NULL,
	[TenTrinhDo] [nvarchar](50) NULL,
	[ChuyenNghanh] [varchar](255) NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'GD', N'Giam Doc')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'NV', N'Nhan Vien')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV]) VALUES (N'TP', N'Truong Phong')
INSERT [dbo].[HopDong] ([MaHD], [LoaiHD], [TuNgay], [DenNgay], [GhiChu]) VALUES (N'CTV', N'Cộng tác viên', NULL, NULL, NULL)
INSERT [dbo].[HopDong] ([MaHD], [LoaiHD], [TuNgay], [DenNgay], [GhiChu]) VALUES (N'HDLD', N'Hợp đồng lao động', NULL, NULL, NULL)
INSERT [dbo].[Luong] ([MaLuong], [NgayCong], [LuongCB]) VALUES (N'LuongHDLD031099005432', N'1', N'5000000')
INSERT [dbo].[NhanVien] ([MaNV], [HoTen], [NgaySinh], [GioiTinh], [DanToc], [CMTND], [SDT], [DiaChi], [MaPhongBan], [MaCV], [MaHD], [MaTrinhDo], [MaLuong]) VALUES (N'BA031099005432', N'Hoàng Van Vi?t', CAST(N'1999-08-21' AS Date), N'Nam', N'Kinh', N'031099005432', N'0359999574', N'H?i Phòng', N'PB03', N'NV', N'HDLD', N'2', N'LuongHDLD031099005432')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [DiaDiem], [MaTP]) VALUES (N'PB02', N'Phong Ky Thuat', N'BootAICompany', NULL)
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan], [DiaDiem], [MaTP]) VALUES (N'PB03', N'Phòng Hanh Chinh', N'BootAICompany', NULL)
INSERT [dbo].[TrinhDo] ([MaTrinhDo], [TenTrinhDo], [ChuyenNghanh]) VALUES (N'1', N'Manager', NULL)
INSERT [dbo].[TrinhDo] ([MaTrinhDo], [TenTrinhDo], [ChuyenNghanh]) VALUES (N'2', N'Development', NULL)
INSERT [dbo].[TrinhDo] ([MaTrinhDo], [TenTrinhDo], [ChuyenNghanh]) VALUES (N'3', N'Test', NULL)
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [F_NV_CTCV] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [F_NV_CTCV]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [F_NV_HOPDONG] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HopDong] ([MaHD])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [F_NV_HOPDONG]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [F_NV_PHONGBAN] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [F_NV_PHONGBAN]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [F_NV_TRINHDO] FOREIGN KEY([MaTrinhDo])
REFERENCES [dbo].[TrinhDo] ([MaTrinhDo])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [F_NV_TRINHDO]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Luong] FOREIGN KEY([MaLuong])
REFERENCES [dbo].[Luong] ([MaLuong])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Luong]
GO
ALTER TABLE [dbo].[PhongBan]  WITH CHECK ADD  CONSTRAINT [F_TP_PHONGBAN] FOREIGN KEY([MaTP])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhongBan] CHECK CONSTRAINT [F_TP_PHONGBAN]
GO
/****** Object:  StoredProcedure [dbo].[Bac_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Bac_Delete] 
@MaBac varchar(50)
AS

DELETE FROM Bac
      WHERE MaBac=@MaBac
GO
/****** Object:  StoredProcedure [dbo].[Bac_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Bac_Insert]
@MaBac varchar(50),
@TenBac nvarchar(50)
AS
INSERT INTO [Bac]
           ([MaBac]
           ,[TenBac])
     VALUES
           (@MaBac
           ,@TenBac)
GO
/****** Object:  StoredProcedure [dbo].[Bac_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Bac_Select]
As
Select MaBac, TenBac from Bac
GO
/****** Object:  StoredProcedure [dbo].[Bac_SelectById]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Bac_SelectById]
@MaBac varchar(50)
AS
Select MaBac from Bac
Where MaBac=@MaBac
GO
/****** Object:  StoredProcedure [dbo].[Bac_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Bac_Update]
@MaBac varchar(50),
@TenBac nvarchar(50)
AS
UPDATE Bac
   SET MaBac = @MaBac
      ,TenBac = @TenBac
 WHERE MaBac=@MaBac
GO
/****** Object:  StoredProcedure [dbo].[BangCong_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BangCong_Delete]
@MaNV varchar(50),
@Nam nvarchar(50),
@Thang nvarchar(50)
AS
DELETE FROM BangCong
      WHERE Thang=@Thang and MaNV=@MaNV and Thang=@Thang
GO
/****** Object:  StoredProcedure [dbo].[BangCong_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BangCong_Insert]
(@MaNV varchar(50)
           ,@HoTen nvarchar(50)
           ,@TenPhongBan nvarchar(50)
           ,@Nam varchar(50)
           ,@Thang nvarchar(50)
           ,@SoNgayCong int
           ,@SocongBHXH int)
           AS
INSERT INTO [BangCong]
           ([MaNV]
           ,[HoTen]
           ,[TenPhongBan]
           ,[Nam]
           ,[Thang]
           ,[SoNgayCong]
           ,[SocongBHXH])
     VALUES
           (@MaNV
           ,@HoTen
           ,@TenPhongBan
           ,@Nam
           ,@Thang
           ,@SoNgayCong
           ,@SocongBHXH)
GO
/****** Object:  StoredProcedure [dbo].[BangCong_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BangCong_Select]
As
Select MaNV,HoTen,TenPhongBan,Nam,Thang,SoNgayCong,SocongBHXH from BangCong
GO
/****** Object:  StoredProcedure [dbo].[BangCong_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BangCong_SelectByID]
@MaNV varchar(50),
@Nam varchar (50),
@Thang nvarchar(50)
As
Select MaNV from BangCong
Where MaNV=@MaNV and Nam=@Nam and Thang=@Thang
GO
/****** Object:  StoredProcedure [dbo].[BangCong_update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BangCong_update]
@MaNV varchar(50),
@HoTen nvarchar(50),
@TenPhongBan nvarchar(50),
@Nam varchar(50),
@Thang nvarchar(50),
@SoNgayCong int,
@SocongBHXH int
AS
UPDATE BangCong
   SET MaNV = @MaNV
      ,HoTen = @HoTen
      ,TenPhongBan = @TenPhongBan
      ,Nam = @Nam
      ,Thang = @Thang
      ,SoNgayCong = @SoNgayCong
      ,SocongBHXH = @SocongBHXH
 WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[BaoHiem_delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BaoHiem_delete]
@MaBH varchar(50)
As
DELETE FROM BaoHiem
      WHERE MaBH=@MaBH
GO
/****** Object:  StoredProcedure [dbo].[BaoHiem_insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BaoHiem_insert]
   @MaBH varchar(50)
  ,@LoaiBH nvarchar(50)
  ,@MaNV varchar(50)
  ,@HoTen nvarchar(50)
  ,@NgaycapBH datetime
  ,@NoicapBH nvarchar(50)
           As
INSERT INTO [BaoHiem]
           ([MaBH]
           ,[LoaiBH]
           ,[MaNV]
           ,[HoTen]
           ,[NgaycapBH]
           ,[NoicapBH])
     VALUES
           (@MaBH
           ,@LoaiBH
           ,@MaNV
           ,@HoTen
           ,@NgaycapBH
           ,@NoicapBH)
update ChiTietHS set MaBH=@MaBH where MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[BaoHiem_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BaoHiem_Select]
As
SELECT MaBH, LoaiBH, MaNV, HoTen, NgaycapBH, NoicapBH from BaoHiem
GO
/****** Object:  StoredProcedure [dbo].[BaoHiem_selectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BaoHiem_selectByID]
@MaNV varchar(50),
@MaBH varchar(50)
As
Select MaBH, MaNV from BaoHiem
Where MaBH=@MaBH or MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[BaoHiem_update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BaoHiem_update]
@MaBH varchar(50),
@LoaiBH nvarchar(50),
@MaNV varchar(50),
      @HoTen nvarchar(50),
      @NgaycapBH datetime,
      @NoicapBH nvarchar(50)
      AS
UPDATE BaoHiem
   SET MaBH = @MaBH
      ,LoaiBH = @LoaiBH
      ,MaNV = @MaNV
      ,HoTen = @HoTen
      ,NgaycapBH = @NgaycapBH
      ,NoicapBH = @NoicapBH
 WHERE MaBH=@MaBH
GO
/****** Object:  StoredProcedure [dbo].[BH_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BH_Delete]
@LoaiBH nvarchar(50)
As
DELETE FROM BaoHiem
      WHERE LoaiBH=@LoaiBH
GO
/****** Object:  StoredProcedure [dbo].[ChiTietHS_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChiTietHS_Delete]
@MaNV varchar(50)
AS
DELETE FROM ChiTietHS
      WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[ChiTietHS_InSert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChiTietHS_InSert]
(@MaNV varchar(50)
           ,@HoTen nvarchar(50)
           ,@NgaySinh datetime
           ,@GioiTinh nvarchar(50)
           ,@TenPhongBan nvarchar(50)
           ,@TenChucDanh nvarchar(50)
           ,@TenChucVu nvarchar(50)
           ,@TenTrinhDo nvarchar(50)
           ,@LoaiHD nvarchar(50)
           ,@MaBH varchar(50)
           ,@QuocTich nvarchar(50)
           ,@DanToc nvarchar(50)
           ,@TonGiao nvarchar(50)
           ,@GhiChu nvarchar(50)
           ,@DangVien nvarchar(50)
           ,@DCThuongTru nvarchar(50)
           ,@DCTamTru nvarchar(50)
           ,@CMTND varchar(50)
           ,@Ngaycap datetime
           ,@Noicap nvarchar(50)
           ,@SDT varchar(50)
           ,@NguyenQuan nvarchar(50))
           AS
INSERT INTO [ChiTietHS]
           ([MaNV]
           ,[HoTen]
           ,[NgaySinh]
           ,[GioiTinh]
           ,[TenPhongBan]
           ,[TenChucDanh]
           ,[TenChucVu]
           ,[TenTrinhDo]
           ,[LoaiHD]
           ,[MaBH]
           ,[QuocTich]
           ,[DanToc]
           ,[TonGiao]
           ,[GhiChu]
           ,[DangVien]
           ,[DCThuongTru]
           ,[DCTamTru]
           ,[CMTND]
           ,[Ngaycap]
           ,[Noicap]
           ,[SDT]
           ,[NguyenQuan])
     VALUES
           (@MaNV
           ,@HoTen
           ,@NgaySinh
           ,@GioiTinh
           ,@TenPhongBan
           ,@TenChucDanh
           ,@TenChucVu
           ,@TenTrinhDo
           ,@LoaiHD
           ,@MaBH
           ,@QuocTich
           ,@DanToc
           ,@TonGiao
           ,@GhiChu
           ,@DangVien
           ,@DCThuongTru
           ,@DCTamTru
           ,@CMTND
           ,@Ngaycap
           ,@Noicap
           ,@SDT
           ,@NguyenQuan)
GO
/****** Object:  StoredProcedure [dbo].[ChiTietHS_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChiTietHS_Select]
As
Select MaNV, HoTen, NgaySinh, GioiTinh, TenPhongBan, TenChucDanh, TenChucVu, TenTrinhDo, LoaiHD, MaBH, QuocTich,DanToc,TonGiao, GhiChu,DangVien,DCThuongTru,DCTamTru,CMTND,Ngaycap,Noicap,SDT,NguyenQuan
From ChiTietHS
GO
/****** Object:  StoredProcedure [dbo].[ChiTietHS_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChiTietHS_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from ChiTietHS
Where MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[ChiTietHS_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChiTietHS_Update]
@MaNV varchar(50)
      ,@HoTen nvarchar(50)
      ,@NgaySinh datetime
      ,@GioiTinh nvarchar(50)
      ,@TenPhongBan nvarchar(50)
      ,@TenChucDanh nvarchar(50)
      ,@TenChucVu nvarchar(50)
      ,@TenTrinhDo nvarchar(50)
      ,@LoaiHD nvarchar(50)
      ,@MaBH varchar(50)
      ,@QuocTich nvarchar(50)
      ,@DanToc nvarchar(50)
      ,@TonGiao nvarchar(50)
      ,@GhiChu nvarchar(50)
      ,@DangVien nvarchar(50)
      ,@DCThuongTru nvarchar(50)
      ,@DCTamTru nvarchar(50)
      ,@CMTND varchar(50)
      ,@Ngaycap datetime
      ,@Noicap nvarchar(50)
      ,@SDT varchar(50)
      ,@NguyenQuan nvarchar(50)
      AS
UPDATE ChiTietHS
   SET MaNV = @MaNV
      ,HoTen = @HoTen
      ,NgaySinh = @NgaySinh
      ,GioiTinh = @GioiTinh
      ,TenPhongBan = @TenPhongBan
      ,TenChucDanh = @TenChucDanh
      ,TenChucVu = @TenChucVu
      ,TenTrinhDo = @TenTrinhDo
      ,LoaiHD = @LoaiHD
      ,MaBH = @MaBH
      ,QuocTich = @QuocTich
      ,DanToc = @DanToc
      ,TonGiao = @TonGiao
      ,GhiChu = @GhiChu
      ,DangVien = @DangVien
      ,DCThuongTru = @DCThuongTru
      ,DCTamTru = @DCTamTru
      ,CMTND = @CMTND
      ,Ngaycap = @Ngaycap
      ,Noicap = @Noicap
      ,SDT = @SDT
      ,NguyenQuan = @NguyenQuan
 WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[ChucDanh_delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChucDanh_delete]
@MaChucDanh varchar(50)
AS
DELETE FROM ChucDanh
      WHERE MaChucDanh=@MaChucDanh
GO
/****** Object:  StoredProcedure [dbo].[ChucDanh_insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChucDanh_insert]
(@MaChucDanh varchar(50)
           ,@TenChucDanh nvarchar(50))
           AS
INSERT INTO [ChucDanh]
           ([MaChucDanh]
           ,[TenChucDanh])
     VALUES
           (@MaChucDanh
           ,@TenChucDanh)
GO
/****** Object:  StoredProcedure [dbo].[ChucDanh_select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChucDanh_select]
AS
Select MaChucDanh,TenChucDanh from ChucDanh
GO
/****** Object:  StoredProcedure [dbo].[ChucDanh_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChucDanh_SelectByID]
@MaChucDanh varchar(50)
AS
Select MaChucDanh from ChucDanh
Where MaChucDanh=@MaChucDanh
GO
/****** Object:  StoredProcedure [dbo].[ChucDanh_update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ChucDanh_update]
@MaChucDanh varchar(50)
      ,@TenChucDanh nvarchar(50)
      AS
UPDATE ChucDanh
   SET MaChucDanh = @MaChucDanh
      ,TenChucDanh = @TenChucDanh
 WHERE MaChucDanh=@MaChucDanh
GO
/****** Object:  StoredProcedure [dbo].[CNBaoHiem_delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_delete]
@MaLoaiBH varchar(50)
As
DELETE FROM CapnhatBH
      WHERE MaLoaiBH=@MaLoaiBH
GO
/****** Object:  StoredProcedure [dbo].[CNBaoHiem_insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_insert]
@MaLoaiBH varchar(50),
@LoaiBH nvarchar(50)
As
INSERT INTO [CapnhatBH]
           ([MaLoaiBH]
           ,[LoaiBH])
     VALUES
           (@MaLoaiBH
           ,@LoaiBH)
GO
/****** Object:  StoredProcedure [dbo].[CNBaoHiem_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_Select]
AS
Select MaLoaiBH,LoaiBH from CapnhatBH
GO
/****** Object:  StoredProcedure [dbo].[CNBaoHiem_SelectById]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_SelectById]
@MaLoaiBH varchar(50)
AS
Select MaLoaiBH from CapnhatBH
Where MaLoaiBH=@MaLoaiBH
GO
/****** Object:  StoredProcedure [dbo].[CNBaoHiem_update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_update]
@MaLoaiBH varchar(50),
@LoaiBH nvarchar(50)
As
UPDATE CapnhatBH
   SET MaLoaiBH = @MaLoaiBH
      ,LoaiBH = @LoaiBH
 WHERE MaLoaiBH=@MaLoaiBH
GO
/****** Object:  StoredProcedure [dbo].[HeSoLuong_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HeSoLuong_Delete]
@MaHSL varchar(50)
AS
DELETE FROM HeSoLuong
      WHERE MaHSL=@MaHSL
GO
/****** Object:  StoredProcedure [dbo].[HeSoLuong_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HeSoLuong_Insert]
@MaHSL varchar(50),
@MaNgach varchar(50),
@TenBac nvarchar(50),
@HSL float
AS
INSERT INTO [HeSoLuong]
           ([MaHSL]
           ,[MaNgach]
           ,[TenBac]
           ,[HSL])
     VALUES
           (@MaHSL
           ,@MaNgach
           ,@TenBac
           ,@HSL)
GO
/****** Object:  StoredProcedure [dbo].[HeSoLuong_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HeSoLuong_Select]
AS
Select MaHSL, MaNgach, TenBac, HSL from HeSoLuong
GO
/****** Object:  StoredProcedure [dbo].[HeSoLuong_SelectById]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HeSoLuong_SelectById]
@MaHSL varchar(50)
AS
Select MaHSL from HeSoLuong
Where MaHSL=@MaHSL
GO
/****** Object:  StoredProcedure [dbo].[HeSoLuong_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HeSoLuong_Update]
@MaHSL varchar(50),
@MaNgach varchar(50),
@TenBac nvarchar(50),
@HSL float
AS
UPDATE HeSoLuong
   SET MaHSL = @MaHSL
      ,MaNgach = @MaNgach
      ,TenBac = @TenBac
      ,HSL = @HSL
 WHERE MaHSL=@MaHSL
GO
/****** Object:  StoredProcedure [dbo].[HOPDONG_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HOPDONG_Delete]
@MaHD varchar(50)
AS
DELETE FROM HOPDONG
      WHERE MaHD=@MaHD
GO
/****** Object:  StoredProcedure [dbo].[HOPDONG_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HOPDONG_Insert]
(@MaHD varchar(50)
           ,@LoaiHD nvarchar(50)
           ,@GhiChu nvarchar(100))
           AS
INSERT INTO [HOPDONG]
           ([MaHD]
           ,[LoaiHD]
           ,[GhiChu])
     VALUES
           (@MaHD
           ,@LoaiHD
           ,@GhiChu)
GO
/****** Object:  StoredProcedure [dbo].[HOPDONG_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HOPDONG_Select]
AS
Select MAHD, LoaiHD,GhiChu from HOPDONG
GO
/****** Object:  StoredProcedure [dbo].[HOPDONG_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HOPDONG_SelectByID]
@MaHD varchar(50)
AS
Select MaHD from HOPDONG
Where MaHD=@MaHD
GO
/****** Object:  StoredProcedure [dbo].[HOPDONG_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[HOPDONG_Update]
@MaHD varchar(50),
@LoaiHD nvarchar(50),
@GhiChu nvarchar(100)
AS
UPDATE HOPDONG
   SET MaHD = @MaHD
      ,LoaiHD = @LoaiHD
      ,GhiChu = @GhiChu
 WHERE MaHD=@MaHD
GO
/****** Object:  StoredProcedure [dbo].[KhenThuong_delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KhenThuong_delete]
@MaNV varchar(50)
AS
DELETE FROM KhenThuong
      WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[KhenThuong_insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KhenThuong_insert]
(@MaNV varchar(50)
           ,@HoTen nvarchar(50)
           ,@SoQDKhenThuong varchar(50)
           ,@NgayQDKhenThuong datetime
           ,@NoiDung nvarchar(100)
           ,@HinhThuc nvarchar(100))
           AS
INSERT INTO [KhenThuong]
           ([MaNV]
           ,[HoTen]
           ,[SoQDKhenThuong]
           ,[NgayQDKhenThuong]
           ,[NoiDung]
           ,[HinhThuc])
     VALUES
           (@MaNV
           ,@HoTen
           ,@SoQDKhenThuong
           ,@NgayQDKhenThuong
           ,@NoiDung
           ,@HinhThuc)
GO
/****** Object:  StoredProcedure [dbo].[KhenThuong_select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KhenThuong_select]
AS
Select MaNV, HoTen,SoQDKhenThuong,NgayQDKhenThuong,NoiDung,HinhThuc from KhenThuong
GO
/****** Object:  StoredProcedure [dbo].[KhenThuong_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KhenThuong_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from KhenThuong
Where MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[KhenThuong_update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KhenThuong_update]
@MaNV varchar(50),
@HoTen nvarchar(50),
@SoQDKhenThuong varchar(50),
@NgayQDKhenThuong datetime,
@NoiDung nvarchar(100),
@HinhThuc nvarchar(100)
AS
UPDATE KhenThuong
   SET MaNV = @MaNV
      ,HoTen = @HoTen
      ,SoQDKhenThuong = @SoQDKhenThuong
      ,NgayQDKhenThuong = @NgayQDKhenThuong
      ,NoiDung = @NoiDung
      ,HinhThuc = @HinhThuc
 WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[KyLuat_delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KyLuat_delete]
@MaNV varchar(50)
AS
DELETE FROM KyLuat
      WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[KyLuat_insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KyLuat_insert]
(@MaNV varchar(50)
           ,@HoTen nvarchar(50)
           ,@SoQDKyLuat varchar(50)
           ,@NgayQDKyLuat datetime
           ,@NoiDung nvarchar(100)
           ,@HinhThuc nvarchar(100))
           AS
INSERT INTO [KyLuat]
           ([MaNV]
           ,[HoTen]
           ,[SoQDKyLuat]
           ,[NgayQDKyLuat]
           ,[NoiDung]
           ,[HinhThuc])
     VALUES
           (@MaNV
           ,@HoTen
           ,@SoQDKyLuat
           ,@NgayQDKyLuat
           ,@NoiDung
           ,@HinhThuc)
GO
/****** Object:  StoredProcedure [dbo].[KyLuat_select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KyLuat_select]
AS
select MaNV,HoTen,SoQDKyLuat,NgayQDKyLuat,NoiDung,HinhThuc from KyLuat
GO
/****** Object:  StoredProcedure [dbo].[KyLuat_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KyLuat_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from KyLuat
Where MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[KyLuat_update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[KyLuat_update]
 @MaNV varchar(50)
      ,@HoTen nvarchar(50)
      ,@SoQDKyLuat varchar(50)
      ,@NgayQDKyLuat datetime
      ,@NoiDung nvarchar(100)
      ,@HinhThuc nvarchar(100)
      AS
UPDATE KyLuat
   SET MaNV = @MaNV
      ,HoTen = @HoTen
      ,SoQDKyLuat = @SoQDKyLuat
      ,NgayQDKyLuat = @NgayQDKyLuat
      ,NoiDung = @NoiDung
      ,HinhThuc = @HinhThuc
 WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[LuongNhanVien_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_Delete]
@MaNV varchar(50)
AS
DELETE FROM LuongNhanVien
      WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[LuongNhanVien_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_Insert]
@MaNV varchar(50)
           ,@HoTen nvarchar(50)
           ,@TenPhongBan nvarchar(50)
           ,@TenChucVu nvarchar(50)
           ,@MaNgach varchar(50)
           ,@TenBac nvarchar(50)
           ,@LuongCB float
           ,@HSPCCV float
           ,@KhautruBH float
           ,@HSL float
           ,@PhucapGV float
           ,@PhucapCV float
           ,@Phucapkhac float
           ,@Luongthuclanh float
           ,@LyDo nvarchar(50)
           AS
INSERT INTO [LuongNhanVien]
           ([MaNV]
           ,[HoTen]
           ,[TenPhongBan]
           ,[TenChucVu]
           ,[MaNgach]
           ,[TenBac]
           ,[LuongCB]
           ,[HSPCCV]
           ,[KhautruBH]
           ,[HSL]
           ,[PhucapGV]
           ,[PhucapCV]
           ,[Phucapkhac]
           ,[Luongthuclanh]
           ,[LyDo])
     VALUES
           (@MaNV
           ,@HoTen
           ,@TenPhongBan
           ,@TenChucVu
           ,@MaNgach
           ,@TenBac
           ,@LuongCB
           ,@HSPCCV
           ,@KhautruBH
           ,@HSL
           ,@PhucapGV
           ,@PhucapCV
           ,@Phucapkhac
           ,@Luongthuclanh
           ,@LyDo)
GO
/****** Object:  StoredProcedure [dbo].[LuongNhanVien_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_Select]
AS
Select MaNV,HoTen,TenPhongBan,TenChucVu,MaNgach,TenBac,LuongCB,HSPCCV,KhautruBH,HSL,PhucapGV,PhucapCV,Phucapkhac,Luongthuclanh,LyDo
From LuongNhanVien
GO
/****** Object:  StoredProcedure [dbo].[LuongNhanVien_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from LuongNhanVien
Where MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[LuongNhanVien_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_Update]
@MaNV varchar(50)
           ,@HoTen nvarchar(50)
           ,@TenPhongBan nvarchar(50)
           ,@TenChucVu nvarchar(50)
           ,@MaNgach varchar(50)
           ,@TenBac nvarchar(50)
           ,@LuongCB float
           ,@HSPCCV float
           ,@KhautruBH float
           ,@HSL float
           ,@PhucapGV float
           ,@PhucapCV float
           ,@Phucapkhac float
           ,@Luongthuclanh float
           ,@LyDo nvarchar(50)
           AS
UPDATE LuongNhanVien
   SET MaNV = @MaNV
      ,HoTen = @HoTen
      ,TenPhongBan = @TenPhongBan
      ,TenChucVu = @TenChucVu
      ,MaNgach = @MaNgach
      ,TenBac = @TenBac
      ,LuongCB = @LuongCB
      ,HSPCCV = @HSPCCV
      ,KhautruBH = @KhautruBH
      ,HSL = @HSL
      ,PhucapGV = @PhucapGV
      ,PhucapCV = @PhucapCV
      ,Phucapkhac = @Phucapkhac
      ,Luongthuclanh = @Luongthuclanh
      ,LyDo = @LyDo
 WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[LuongNV_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LuongNV_Select]
AS
Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN,TongPC,LuongThucLanh from ThongTinLuong
GO
/****** Object:  StoredProcedure [dbo].[Ngach_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Ngach_Delete]
@MaNgach varchar(50)
AS
DELETE FROM Ngach
      WHERE MaNgach=@MaNgach
GO
/****** Object:  StoredProcedure [dbo].[Ngach_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Ngach_Insert]
@MaNgach varchar(50),
@TenNgach nvarchar(100)
AS
INSERT INTO [Ngach]
           ([MaNgach]
           ,[TenNgach])
     VALUES
           (@MaNgach
           ,@TenNgach)
GO
/****** Object:  StoredProcedure [dbo].[Ngach_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Ngach_Select]
AS
Select MaNgach, TenNgach from Ngach
GO
/****** Object:  StoredProcedure [dbo].[Ngach_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Ngach_SelectByID]
@MaNgach varchar(50)
AS
Select MaNgach from Ngach
Where MaNgach=@MaNgach
GO
/****** Object:  StoredProcedure [dbo].[Ngach_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Ngach_Update]
@MaNgach varchar(50),
@TenNgach nvarchar(100)
AS
UPDATE Ngach
   SET MaNgach = @MaNgach
      ,TenNgach = @TenNgach
 WHERE MaNgach=@MaNgach
GO
/****** Object:  StoredProcedure [dbo].[PhongBan_delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhongBan_delete]
@MaPhongBan varchar(50)
AS
DELETE FROM PhongBan
      WHERE MaPhongBan=@MaPhongBan
GO
/****** Object:  StoredProcedure [dbo].[PhongBan_Inset]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhongBan_Inset]
(@MaPhongBan varchar(50)
,@TenPhongBan nvarchar(50))
AS
INSERT INTO [PhongBan]
           ([MaPhongBan]
           ,[TenPhongBan])
     VALUES
           (@MaPhongBan
           ,@TenPhongBan)
GO
/****** Object:  StoredProcedure [dbo].[PhongBan_select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhongBan_select]
AS
Select MaPhongBan,TenPhongBan from PhongBan
GO
/****** Object:  StoredProcedure [dbo].[PhongBan_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhongBan_SelectByID]
@MaPhongBan varchar(50)
AS
Select MaPhongBan from PhongBan
Where MaPhongBan=@MaPhongBan
GO
/****** Object:  StoredProcedure [dbo].[PhongBan_update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhongBan_update]
@MaPhongBan varchar(50)
,@TenPhongBan nvarchar(50)
AS
UPDATE PhongBan
   SET [MaPhongBan] = @MaPhongBan
      ,[TenPhongBan] = @TenPhongBan
 WHERE MaPhongBan=@MaPhongBan
GO
/****** Object:  StoredProcedure [dbo].[PhuCap_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhuCap_Delete]
@Thang nvarchar(50)
AS
DELETE FROM PhuCap
      WHERE Thang=@Thang
GO
/****** Object:  StoredProcedure [dbo].[PhuCap_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhuCap_Insert]
@Thang nvarchar(50),
@Phucap float,
@LyDo nvarchar(100)
AS
INSERT INTO [PhuCap]
           ([Thang]
           ,[Phucap]
           ,[LyDo])
     VALUES
           (@Thang
           ,@Phucap
           ,@LyDo)
GO
/****** Object:  StoredProcedure [dbo].[PhuCap_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhuCap_Select]
AS
Select Thang,Phucap,LyDo from PhuCap
GO
/****** Object:  StoredProcedure [dbo].[PhuCap_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhuCap_SelectByID]
@Thang nvarchar(50)
AS
Select Thang from PhuCap
Where Thang=@Thang
GO
/****** Object:  StoredProcedure [dbo].[PhuCap_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PhuCap_Update]
@Thang nvarchar(50),
@Phucap float,
@LyDo nvarchar(100)
AS
UPDATE PhuCap
   SET Thang = @Thang
      ,Phucap = @Phucap
      ,LyDo = @LyDo
 WHERE Thang=@Thang
GO
/****** Object:  StoredProcedure [dbo].[Test_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Test_Select]
AS
Select MaNV,HSL,Thangtangcuoicung from Test
GO
/****** Object:  StoredProcedure [dbo].[TestLuong_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TestLuong_Select]
AS
Select MaVN,HoTen,HSL,LuongCB,Luong from TestLuong
GO
/****** Object:  StoredProcedure [dbo].[ThongTinLuong_Delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_Delete]
@MaNV varchar(50)
AS
DELETE FROM ThongTinLuong
      WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[ThongTinLuong_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_Insert]
@MaNV varchar(50)
           ,@HoTen nvarchar(50)
           ,@HSL float
           ,@Thangtangcuoicung datetime
           ,@BHXH float
           ,@BHYT float
           ,@BHTN float
           AS
INSERT INTO [ThongTinLuong]
           ([MaNV]
           ,[HoTen]
           ,[HSL]
           ,[Thangtangcuoicung]
           ,[BHXH]
           ,[BHYT]
           ,[BHTN])
     VALUES
           (@MaNV
           ,@HoTen
           ,@HSL
           ,@Thangtangcuoicung
           ,@BHXH
           ,@BHYT
           ,@BHTN)
GO
/****** Object:  StoredProcedure [dbo].[ThongTinLuong_Select]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_Select]
AS
Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN From ThongTinLuong
GO
/****** Object:  StoredProcedure [dbo].[ThongTinLuong_SelectByID]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from ThongTinLuong
Where MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[ThongTinLuong_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_Update]
@MaNV varchar(50),
@HoTen nvarchar(50),
@HSL float,
@Thangtangcuoicung datetime,
@BHXH float,
@BHYT float,
@BHTN float
AS
UPDATE ThongTinLuong
   SET MaNV = @MaNV
      ,HoTen = @HoTen
      ,HSL = @HSL
      ,Thangtangcuoicung = @Thangtangcuoicung
      ,BHXH = @BHXH
      ,BHYT = @BHYT
      ,BHTN = @BHTN
      
 WHERE MaNV=@MaNV
GO
/****** Object:  StoredProcedure [dbo].[Tong_Insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Tong_Insert]
@Thang nvarchar(50),
@TongPC float
AS
INSERT INTO [Tong]
           ([Thang]
           ,[TongPC])
     VALUES
           (@Thang
           ,@TongPC)
GO
/****** Object:  StoredProcedure [dbo].[Tong_Update]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Tong_Update]
@Thang nvarchar(50),
@TongPC float
AS
Update Tong
SET Thang=@Thang
	,TongPC=@TongPC
	where Thang=@Thang
GO
/****** Object:  StoredProcedure [dbo].[TrinhDo_delete]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TrinhDo_delete]
@MaTrinhDo varchar(50)
AS
DELETE FROM TrinhDo
      WHERE MaTrinhDo=@MaTrinhDo
GO
/****** Object:  StoredProcedure [dbo].[TrinhDo_insert]    Script Date: 3/12/2020 11:02:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TrinhDo_insert]
(@MaTrinhDo varchar(50)
           ,@TenTrinhDo nvarchar(50))
           AS
INSERT INTO [TrinhDo]
           ([MaTrinhDo]
           ,[TenTrinhDo])
     VALUES
           (@MaTrinhDo
           ,@TenTrinhDo)
GO
USE [master]
GO
ALTER DATABASE [QuanLyNhanSu] SET  READ_WRITE 
GO
