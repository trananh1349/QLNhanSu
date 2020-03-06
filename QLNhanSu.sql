/* 
 Navicat Premium Data Transfer

 Source Server         : sqlsver
 Source Server Type    : SQL Server
 Source Server Version : 10504000
 Source Host           : DESKTOP-8V08BMC\SQLEXPRESS:1433
 Source Catalog        : QuanLyNhanSu
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 10504000
 File Encoding         : 65001

 Date: 06/03/2020 22:09:15
*/


-- ----------------------------
-- Table structure for ChucVu
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu]') AND type IN ('U'))
	DROP TABLE [dbo].[ChucVu]
GO

CREATE TABLE [dbo].[ChucVu] (
  [MaCV] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [TenCV] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[ChucVu] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for DangNhap
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[DangNhap]') AND type IN ('U'))
	DROP TABLE [dbo].[DangNhap]
GO

CREATE TABLE [dbo].[DangNhap] (
  [id] int  NOT NULL,
  [username] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [password] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[DangNhap] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for HopDong
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HopDong]') AND type IN ('U'))
	DROP TABLE [dbo].[HopDong]
GO

CREATE TABLE [dbo].[HopDong] (
  [MaHD] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [LoaiHD] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [TuNgay] datetime  NULL,
  [DenNgay] datetime  NULL,
  [GhiChu] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[HopDong] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Luong
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Luong]') AND type IN ('U'))
	DROP TABLE [dbo].[Luong]
GO

CREATE TABLE [dbo].[Luong] (
  [MaLuong] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [HSLuong] float(53)  NULL,
  [NgayCong] int  NULL,
  [LuongCB] float(53)  NULL,
  [HSPhuCap] float(53)  NULL
)
GO

ALTER TABLE [dbo].[Luong] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for NhanVien
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[NhanVien]') AND type IN ('U'))
	DROP TABLE [dbo].[NhanVien]
GO

CREATE TABLE [dbo].[NhanVien] (
  [MaNV] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [HoTen] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NgaySinh] datetime  NOT NULL,
  [GioiTinh] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DanToc] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [CMTND] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [SDT] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DiaChi] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [MaPhongBan] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MaCV] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MaHD] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MaTrinhDo] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MaLuong] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[NhanVien] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for PhongBan
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan]') AND type IN ('U'))
	DROP TABLE [dbo].[PhongBan]
GO

CREATE TABLE [dbo].[PhongBan] (
  [MaPhongBan] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [TenPhongBan] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DiaDiem] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [MaTP] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[PhongBan] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for TrinhDo
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TrinhDo]') AND type IN ('U'))
	DROP TABLE [dbo].[TrinhDo]
GO

CREATE TABLE [dbo].[TrinhDo] (
  [MaTrinhDo] varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [TenTrinhDo] nvarchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ChuyenNghanh] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[TrinhDo] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Procedure structure for sp_creatediagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_creatediagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_creatediagram]
GO

CREATE PROCEDURE [dbo].[sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
GO


-- ----------------------------
-- Procedure structure for sp_renamediagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_renamediagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_renamediagram]
GO

CREATE PROCEDURE [dbo].[sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_alterdiagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_alterdiagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_alterdiagram]
GO

CREATE PROCEDURE [dbo].[sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
GO


-- ----------------------------
-- Procedure structure for sp_dropdiagram
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_dropdiagram]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_dropdiagram]
GO

CREATE PROCEDURE [dbo].[sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
GO


-- ----------------------------
-- Function structure for fn_diagramobjects
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[fn_diagramobjects]') AND type IN ('FN', 'FS', 'FT', 'IF', 'TF'))
	DROP FUNCTION[dbo].[fn_diagramobjects]
GO

CREATE FUNCTION [dbo].[fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
GO


-- ----------------------------
-- Procedure structure for Bac_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Bac_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Bac_Delete]
GO

CREATE PROCEDURE [dbo].[Bac_Delete] 
@MaBac varchar(50)
AS

DELETE FROM Bac
      WHERE MaBac=@MaBac
GO


-- ----------------------------
-- Procedure structure for Bac_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Bac_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Bac_Insert]
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


-- ----------------------------
-- Procedure structure for Bac_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Bac_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Bac_Select]
GO

CREATE PROCEDURE [dbo].[Bac_Select]
As
Select MaBac, TenBac from Bac
GO


-- ----------------------------
-- Procedure structure for Bac_SelectById
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Bac_SelectById]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Bac_SelectById]
GO

CREATE PROCEDURE [dbo].[Bac_SelectById]
@MaBac varchar(50)
AS
Select MaBac from Bac
Where MaBac=@MaBac
GO


-- ----------------------------
-- Procedure structure for Bac_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Bac_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Bac_Update]
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


-- ----------------------------
-- Procedure structure for BangCong_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BangCong_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BangCong_Delete]
GO

CREATE PROCEDURE [dbo].[BangCong_Delete]
@MaNV varchar(50),
@Nam nvarchar(50),
@Thang nvarchar(50)
AS
DELETE FROM BangCong
      WHERE Thang=@Thang and MaNV=@MaNV and Thang=@Thang
GO


-- ----------------------------
-- Procedure structure for BangCong_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BangCong_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BangCong_Insert]
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


-- ----------------------------
-- Procedure structure for BangCong_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BangCong_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BangCong_Select]
GO

CREATE PROCEDURE [dbo].[BangCong_Select]
As
Select MaNV,HoTen,TenPhongBan,Nam,Thang,SoNgayCong,SocongBHXH from BangCong
GO


-- ----------------------------
-- Procedure structure for BangCong_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BangCong_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BangCong_SelectByID]
GO

CREATE PROCEDURE [dbo].[BangCong_SelectByID]
@MaNV varchar(50),
@Nam varchar (50),
@Thang nvarchar(50)
As
Select MaNV from BangCong
Where MaNV=@MaNV and Nam=@Nam and Thang=@Thang
GO


-- ----------------------------
-- Procedure structure for BangCong_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BangCong_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BangCong_update]
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


-- ----------------------------
-- Procedure structure for BaoHiem_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BaoHiem_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BaoHiem_delete]
GO

CREATE PROCEDURE [dbo].[BaoHiem_delete]
@MaBH varchar(50)
As
DELETE FROM BaoHiem
      WHERE MaBH=@MaBH
GO


-- ----------------------------
-- Procedure structure for BaoHiem_insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BaoHiem_insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BaoHiem_insert]
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


-- ----------------------------
-- Procedure structure for BaoHiem_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BaoHiem_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BaoHiem_Select]
GO

CREATE PROCEDURE [dbo].[BaoHiem_Select]
As
SELECT MaBH, LoaiBH, MaNV, HoTen, NgaycapBH, NoicapBH from BaoHiem
GO


-- ----------------------------
-- Procedure structure for BaoHiem_selectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BaoHiem_selectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BaoHiem_selectByID]
GO

CREATE PROCEDURE [dbo].[BaoHiem_selectByID]
@MaNV varchar(50),
@MaBH varchar(50)
As
Select MaBH, MaNV from BaoHiem
Where MaBH=@MaBH or MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for BaoHiem_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BaoHiem_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BaoHiem_update]
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


-- ----------------------------
-- Procedure structure for BH_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[BH_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[BH_Delete]
GO

CREATE PROCEDURE [dbo].[BH_Delete]
@LoaiBH nvarchar(50)
As
DELETE FROM BaoHiem
      WHERE LoaiBH=@LoaiBH
GO


-- ----------------------------
-- Procedure structure for ChiTietHS_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietHS_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChiTietHS_Delete]
GO

CREATE PROCEDURE [dbo].[ChiTietHS_Delete]
@MaNV varchar(50)
AS
DELETE FROM ChiTietHS
      WHERE MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for ChiTietHS_InSert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietHS_InSert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChiTietHS_InSert]
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


-- ----------------------------
-- Procedure structure for ChiTietHS_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietHS_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChiTietHS_Select]
GO

CREATE PROCEDURE [dbo].[ChiTietHS_Select]
As
Select MaNV, HoTen, NgaySinh, GioiTinh, TenPhongBan, TenChucDanh, TenChucVu, TenTrinhDo, LoaiHD, MaBH, QuocTich,DanToc,TonGiao, GhiChu,DangVien,DCThuongTru,DCTamTru,CMTND,Ngaycap,Noicap,SDT,NguyenQuan
From ChiTietHS
GO


-- ----------------------------
-- Procedure structure for ChiTietHS_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietHS_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChiTietHS_SelectByID]
GO

CREATE PROCEDURE [dbo].[ChiTietHS_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from ChiTietHS
Where MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for ChiTietHS_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChiTietHS_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChiTietHS_Update]
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


-- ----------------------------
-- Procedure structure for ChucDanh_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucDanh_delete]
GO

CREATE PROCEDURE [dbo].[ChucDanh_delete]
@MaChucDanh varchar(50)
AS
DELETE FROM ChucDanh
      WHERE MaChucDanh=@MaChucDanh
GO


-- ----------------------------
-- Procedure structure for ChucDanh_insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh_insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucDanh_insert]
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


-- ----------------------------
-- Procedure structure for ChucDanh_select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh_select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucDanh_select]
GO

CREATE PROCEDURE [dbo].[ChucDanh_select]
AS
Select MaChucDanh,TenChucDanh from ChucDanh
GO


-- ----------------------------
-- Procedure structure for ChucDanh_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucDanh_SelectByID]
GO

CREATE PROCEDURE [dbo].[ChucDanh_SelectByID]
@MaChucDanh varchar(50)
AS
Select MaChucDanh from ChucDanh
Where MaChucDanh=@MaChucDanh
GO


-- ----------------------------
-- Procedure structure for ChucDanh_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucDanh_update]
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


-- ----------------------------
-- Procedure structure for ChucVu_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucVu_delete]
GO

CREATE PROCEDURE [dbo].[ChucVu_delete]
@MaChucVu varchar(50)
AS
DELETE FROM ChucVu
      WHERE MaChucVu=@MaChucVu
GO


-- ----------------------------
-- Procedure structure for ChucVu_insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu_insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucVu_insert]
GO

CREATE PROCEDURE [dbo].[ChucVu_insert]
(@MaChucVu varchar(50)
           ,@TenChucVu nvarchar(50))
           AS
INSERT INTO [ChucVu]
           ([MaChucVu]
           ,[TenChucVu])
     VALUES
           (@MaChucVu
           ,@TenChucVu)
GO


-- ----------------------------
-- Procedure structure for ChucVu_select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu_select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucVu_select]
GO

CREATE PROCEDURE [dbo].[ChucVu_select]
AS
Select MaChucVu, TenChucVu from ChucVu
GO


-- ----------------------------
-- Procedure structure for ChucVu_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucVu_SelectByID]
GO

CREATE PROCEDURE [dbo].[ChucVu_SelectByID]
@MaChucVu varchar(50)
AS
Select MaChucVu from ChucVu
Where MaChucVu=@MaChucVu
GO


-- ----------------------------
-- Procedure structure for ChucVu_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucVu_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ChucVu_update]
GO

CREATE PROCEDURE [dbo].[ChucVu_update]
@MaChucVu varchar(50)
      ,@TenChucVu nvarchar(50)
      AS
UPDATE ChucVu
   SET MaChucVu = @MaChucVu
      ,TenChucVu = @TenChucVu
 WHERE MaChucVu=@MaChucVu
GO


-- ----------------------------
-- Procedure structure for CNBaoHiem_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CNBaoHiem_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[CNBaoHiem_delete]
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_delete]
@MaLoaiBH varchar(50)
As
DELETE FROM CapnhatBH
      WHERE MaLoaiBH=@MaLoaiBH
GO


-- ----------------------------
-- Procedure structure for CNBaoHiem_insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CNBaoHiem_insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[CNBaoHiem_insert]
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


-- ----------------------------
-- Procedure structure for CNBaoHiem_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CNBaoHiem_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[CNBaoHiem_Select]
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_Select]
AS
Select MaLoaiBH,LoaiBH from CapnhatBH
GO


-- ----------------------------
-- Procedure structure for CNBaoHiem_SelectById
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CNBaoHiem_SelectById]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[CNBaoHiem_SelectById]
GO

CREATE PROCEDURE [dbo].[CNBaoHiem_SelectById]
@MaLoaiBH varchar(50)
AS
Select MaLoaiBH from CapnhatBH
Where MaLoaiBH=@MaLoaiBH
GO


-- ----------------------------
-- Procedure structure for CNBaoHiem_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CNBaoHiem_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[CNBaoHiem_update]
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


-- ----------------------------
-- Procedure structure for HeSoLuong_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HeSoLuong_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HeSoLuong_Delete]
GO

CREATE PROCEDURE [dbo].[HeSoLuong_Delete]
@MaHSL varchar(50)
AS
DELETE FROM HeSoLuong
      WHERE MaHSL=@MaHSL
GO


-- ----------------------------
-- Procedure structure for HeSoLuong_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HeSoLuong_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HeSoLuong_Insert]
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


-- ----------------------------
-- Procedure structure for HeSoLuong_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HeSoLuong_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HeSoLuong_Select]
GO

CREATE PROCEDURE [dbo].[HeSoLuong_Select]
AS
Select MaHSL, MaNgach, TenBac, HSL from HeSoLuong
GO


-- ----------------------------
-- Procedure structure for HeSoLuong_SelectById
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HeSoLuong_SelectById]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HeSoLuong_SelectById]
GO

CREATE PROCEDURE [dbo].[HeSoLuong_SelectById]
@MaHSL varchar(50)
AS
Select MaHSL from HeSoLuong
Where MaHSL=@MaHSL
GO


-- ----------------------------
-- Procedure structure for HeSoLuong_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HeSoLuong_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HeSoLuong_Update]
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


-- ----------------------------
-- Procedure structure for HOPDONG_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HOPDONG_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HOPDONG_Delete]
GO

CREATE PROCEDURE [dbo].[HOPDONG_Delete]
@MaHD varchar(50)
AS
DELETE FROM HOPDONG
      WHERE MaHD=@MaHD
GO


-- ----------------------------
-- Procedure structure for HOPDONG_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HOPDONG_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HOPDONG_Insert]
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


-- ----------------------------
-- Procedure structure for HOPDONG_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HOPDONG_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HOPDONG_Select]
GO

CREATE PROCEDURE [dbo].[HOPDONG_Select]
AS
Select MAHD, LoaiHD,GhiChu from HOPDONG
GO


-- ----------------------------
-- Procedure structure for HOPDONG_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HOPDONG_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HOPDONG_SelectByID]
GO

CREATE PROCEDURE [dbo].[HOPDONG_SelectByID]
@MaHD varchar(50)
AS
Select MaHD from HOPDONG
Where MaHD=@MaHD
GO


-- ----------------------------
-- Procedure structure for HOPDONG_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[HOPDONG_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[HOPDONG_Update]
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


-- ----------------------------
-- Procedure structure for KhenThuong_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KhenThuong_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KhenThuong_delete]
GO

CREATE PROCEDURE [dbo].[KhenThuong_delete]
@MaNV varchar(50)
AS
DELETE FROM KhenThuong
      WHERE MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for KhenThuong_insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KhenThuong_insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KhenThuong_insert]
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


-- ----------------------------
-- Procedure structure for KhenThuong_select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KhenThuong_select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KhenThuong_select]
GO

CREATE PROCEDURE [dbo].[KhenThuong_select]
AS
Select MaNV, HoTen,SoQDKhenThuong,NgayQDKhenThuong,NoiDung,HinhThuc from KhenThuong
GO


-- ----------------------------
-- Procedure structure for KhenThuong_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KhenThuong_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KhenThuong_SelectByID]
GO

CREATE PROCEDURE [dbo].[KhenThuong_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from KhenThuong
Where MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for KhenThuong_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KhenThuong_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KhenThuong_update]
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


-- ----------------------------
-- Procedure structure for KyLuat_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KyLuat_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KyLuat_delete]
GO

CREATE PROCEDURE [dbo].[KyLuat_delete]
@MaNV varchar(50)
AS
DELETE FROM KyLuat
      WHERE MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for KyLuat_insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KyLuat_insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KyLuat_insert]
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


-- ----------------------------
-- Procedure structure for KyLuat_select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KyLuat_select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KyLuat_select]
GO

CREATE PROCEDURE [dbo].[KyLuat_select]
AS
select MaNV,HoTen,SoQDKyLuat,NgayQDKyLuat,NoiDung,HinhThuc from KyLuat
GO


-- ----------------------------
-- Procedure structure for KyLuat_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KyLuat_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KyLuat_SelectByID]
GO

CREATE PROCEDURE [dbo].[KyLuat_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from KyLuat
Where MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for KyLuat_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[KyLuat_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[KyLuat_update]
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


-- ----------------------------
-- Procedure structure for LuongNhanVien_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LuongNhanVien_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[LuongNhanVien_Delete]
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_Delete]
@MaNV varchar(50)
AS
DELETE FROM LuongNhanVien
      WHERE MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for LuongNhanVien_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LuongNhanVien_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[LuongNhanVien_Insert]
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


-- ----------------------------
-- Procedure structure for LuongNhanVien_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LuongNhanVien_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[LuongNhanVien_Select]
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_Select]
AS
Select MaNV,HoTen,TenPhongBan,TenChucVu,MaNgach,TenBac,LuongCB,HSPCCV,KhautruBH,HSL,PhucapGV,PhucapCV,Phucapkhac,Luongthuclanh,LyDo
From LuongNhanVien
GO


-- ----------------------------
-- Procedure structure for LuongNhanVien_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LuongNhanVien_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[LuongNhanVien_SelectByID]
GO

CREATE PROCEDURE [dbo].[LuongNhanVien_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from LuongNhanVien
Where MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for LuongNhanVien_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LuongNhanVien_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[LuongNhanVien_Update]
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


-- ----------------------------
-- Procedure structure for LuongNV_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LuongNV_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[LuongNV_Select]
GO

CREATE PROCEDURE [dbo].[LuongNV_Select]
AS
Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN,TongPC,LuongThucLanh from ThongTinLuong
GO


-- ----------------------------
-- Procedure structure for Ngach_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Ngach_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Ngach_Delete]
GO

CREATE PROCEDURE [dbo].[Ngach_Delete]
@MaNgach varchar(50)
AS
DELETE FROM Ngach
      WHERE MaNgach=@MaNgach
GO


-- ----------------------------
-- Procedure structure for Ngach_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Ngach_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Ngach_Insert]
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


-- ----------------------------
-- Procedure structure for Ngach_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Ngach_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Ngach_Select]
GO

CREATE PROCEDURE [dbo].[Ngach_Select]
AS
Select MaNgach, TenNgach from Ngach
GO


-- ----------------------------
-- Procedure structure for Ngach_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Ngach_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Ngach_SelectByID]
GO

CREATE PROCEDURE [dbo].[Ngach_SelectByID]
@MaNgach varchar(50)
AS
Select MaNgach from Ngach
Where MaNgach=@MaNgach
GO


-- ----------------------------
-- Procedure structure for Ngach_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Ngach_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Ngach_Update]
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


-- ----------------------------
-- Procedure structure for PhongBan_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhongBan_delete]
GO

CREATE PROCEDURE [dbo].[PhongBan_delete]
@MaPhongBan varchar(50)
AS
DELETE FROM PhongBan
      WHERE MaPhongBan=@MaPhongBan
GO


-- ----------------------------
-- Procedure structure for PhongBan_Inset
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan_Inset]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhongBan_Inset]
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


-- ----------------------------
-- Procedure structure for PhongBan_select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan_select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhongBan_select]
GO

CREATE PROCEDURE [dbo].[PhongBan_select]
AS
Select MaPhongBan,TenPhongBan from PhongBan
GO


-- ----------------------------
-- Procedure structure for PhongBan_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhongBan_SelectByID]
GO

CREATE PROCEDURE [dbo].[PhongBan_SelectByID]
@MaPhongBan varchar(50)
AS
Select MaPhongBan from PhongBan
Where MaPhongBan=@MaPhongBan
GO


-- ----------------------------
-- Procedure structure for PhongBan_update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan_update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhongBan_update]
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


-- ----------------------------
-- Procedure structure for PhuCap_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhuCap_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhuCap_Delete]
GO

CREATE PROCEDURE [dbo].[PhuCap_Delete]
@Thang nvarchar(50)
AS
DELETE FROM PhuCap
      WHERE Thang=@Thang
GO


-- ----------------------------
-- Procedure structure for PhuCap_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhuCap_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhuCap_Insert]
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


-- ----------------------------
-- Procedure structure for PhuCap_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhuCap_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhuCap_Select]
GO

CREATE PROCEDURE [dbo].[PhuCap_Select]
AS
Select Thang,Phucap,LyDo from PhuCap
GO


-- ----------------------------
-- Procedure structure for PhuCap_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhuCap_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhuCap_SelectByID]
GO

CREATE PROCEDURE [dbo].[PhuCap_SelectByID]
@Thang nvarchar(50)
AS
Select Thang from PhuCap
Where Thang=@Thang
GO


-- ----------------------------
-- Procedure structure for PhuCap_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PhuCap_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[PhuCap_Update]
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


-- ----------------------------
-- Procedure structure for Test_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Test_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Test_Select]
GO

CREATE PROCEDURE [dbo].[Test_Select]
AS
Select MaNV,HSL,Thangtangcuoicung from Test
GO


-- ----------------------------
-- Procedure structure for TestLuong_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TestLuong_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[TestLuong_Select]
GO

CREATE PROCEDURE [dbo].[TestLuong_Select]
AS
Select MaVN,HoTen,HSL,LuongCB,Luong from TestLuong
GO


-- ----------------------------
-- Procedure structure for ThongTinLuong_Delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ThongTinLuong_Delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ThongTinLuong_Delete]
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_Delete]
@MaNV varchar(50)
AS
DELETE FROM ThongTinLuong
      WHERE MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for ThongTinLuong_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ThongTinLuong_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ThongTinLuong_Insert]
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


-- ----------------------------
-- Procedure structure for ThongTinLuong_Select
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ThongTinLuong_Select]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ThongTinLuong_Select]
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_Select]
AS
Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN From ThongTinLuong
GO


-- ----------------------------
-- Procedure structure for ThongTinLuong_SelectByID
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ThongTinLuong_SelectByID]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ThongTinLuong_SelectByID]
GO

CREATE PROCEDURE [dbo].[ThongTinLuong_SelectByID]
@MaNV varchar(50)
AS
Select MaNV from ThongTinLuong
Where MaNV=@MaNV
GO


-- ----------------------------
-- Procedure structure for ThongTinLuong_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[ThongTinLuong_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[ThongTinLuong_Update]
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


-- ----------------------------
-- Procedure structure for Tong_Insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Tong_Insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Tong_Insert]
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


-- ----------------------------
-- Procedure structure for Tong_Update
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Tong_Update]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[Tong_Update]
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


-- ----------------------------
-- Procedure structure for TrinhDo_delete
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TrinhDo_delete]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[TrinhDo_delete]
GO

CREATE PROCEDURE [dbo].[TrinhDo_delete]
@MaTrinhDo varchar(50)
AS
DELETE FROM TrinhDo
      WHERE MaTrinhDo=@MaTrinhDo
GO


-- ----------------------------
-- Procedure structure for TrinhDo_insert
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[TrinhDo_insert]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[TrinhDo_insert]
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


-- ----------------------------
-- Procedure structure for sp_upgraddiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upgraddiagrams]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_upgraddiagrams]
GO

CREATE PROCEDURE [dbo].[sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
GO


-- ----------------------------
-- Procedure structure for sp_helpdiagrams
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_helpdiagrams]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_helpdiagrams]
GO

CREATE PROCEDURE [dbo].[sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
GO


-- ----------------------------
-- Procedure structure for sp_helpdiagramdefinition
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_helpdiagramdefinition]') AND type IN ('P', 'PC', 'RF', 'X'))
	DROP PROCEDURE[dbo].[sp_helpdiagramdefinition]
GO

CREATE PROCEDURE [dbo].[sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
GO


-- ----------------------------
-- Primary Key structure for table ChucVu
-- ----------------------------
ALTER TABLE [dbo].[ChucVu] ADD CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED ([MaCV])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table DangNhap
-- ----------------------------
ALTER TABLE [dbo].[DangNhap] ADD CONSTRAINT [PK__DangNhap__3213E83F0C85DE4D] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table HopDong
-- ----------------------------
ALTER TABLE [dbo].[HopDong] ADD CONSTRAINT [PK_HOPDONG] PRIMARY KEY CLUSTERED ([MaHD])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Luong
-- ----------------------------
ALTER TABLE [dbo].[Luong] ADD CONSTRAINT [PK_ThongTinLuong] PRIMARY KEY CLUSTERED ([MaLuong])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table NhanVien
-- ----------------------------
ALTER TABLE [dbo].[NhanVien] ADD CONSTRAINT [PK_ChiTietHS] PRIMARY KEY CLUSTERED ([MaNV])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table PhongBan
-- ----------------------------
ALTER TABLE [dbo].[PhongBan] ADD CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED ([MaPhongBan])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table TrinhDo
-- ----------------------------
ALTER TABLE [dbo].[TrinhDo] ADD CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED ([MaTrinhDo])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Luong
-- ----------------------------
ALTER TABLE [dbo].[Luong] ADD CONSTRAINT [FK_ThongTinLuong_ChiTietHS] FOREIGN KEY ([MaLuong]) REFERENCES [dbo].[NhanVien] ([MaNV]) ON DELETE CASCADE ON UPDATE CASCADE
GO


-- ----------------------------
-- Foreign Keys structure for table NhanVien
-- ----------------------------
ALTER TABLE [dbo].[NhanVien] ADD CONSTRAINT [F_NV_PHONGBAN] FOREIGN KEY ([MaPhongBan]) REFERENCES [dbo].[PhongBan] ([MaPhongBan]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[NhanVien] ADD CONSTRAINT [F_NV_HOPDONG] FOREIGN KEY ([MaHD]) REFERENCES [dbo].[HopDong] ([MaHD]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[NhanVien] ADD CONSTRAINT [F_NV_TRINHDO] FOREIGN KEY ([MaTrinhDo]) REFERENCES [dbo].[TrinhDo] ([MaTrinhDo]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[NhanVien] ADD CONSTRAINT [F_NV_CTCV] FOREIGN KEY ([MaCV]) REFERENCES [dbo].[ChucVu] ([MaCV]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[NhanVien] ADD CONSTRAINT [F_NV_LUONG] FOREIGN KEY ([MaLuong]) REFERENCES [dbo].[Luong] ([MaLuong]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


-- ----------------------------
-- Foreign Keys structure for table PhongBan
-- ----------------------------
ALTER TABLE [dbo].[PhongBan] ADD CONSTRAINT [F_TP_PHONGBAN] FOREIGN KEY ([MaTP]) REFERENCES [dbo].[NhanVien] ([MaNV]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

