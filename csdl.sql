use [master]
go
drop database IF EXISTS CarParking
create database CarParking
go
use CarParking
go
drop table if exists BaiGiuXe
create table BaiGiuXe
(
	ID int identity primary key,
	Ten nvarchar(120),
	TongSoCho int,
	DaCoXe int,
	DatTruoc int,
	DiaDiem nvarchar(120),
)
insert into BaiGiuXe values ('MTA',32,19,3,N'236 HQV')
insert into BaiGiuXe values ('T32',40,33,3,N'221 Tran AV')
drop table if exists ChoGiuXe
create table ChoGiuXe
(
	ID int identity primary key,
	BGX_ID int references BaiGiuXe(ID),
	TrangThai int, --0 trong, 1 dang co xe, 2 da dat cho
	ViTri char(4),
)
insert into ChoGiuXe values (1,0,'A001')
insert into ChoGiuXe values (1,0,'A002')
insert into ChoGiuXe values (1,1,'A003')
insert into ChoGiuXe values (1,1,'A004')
insert into ChoGiuXe values (1,0,'A005')
insert into ChoGiuXe values (1,1,'A006')
insert into ChoGiuXe values (1,2,'A007')
insert into ChoGiuXe values (1,0,'A008')
insert into ChoGiuXe values (1,2,'B001')
insert into ChoGiuXe values (1,1,'B002')
insert into ChoGiuXe values (1,1,'B003')
insert into ChoGiuXe values (1,0,'B004')
insert into ChoGiuXe values (1,3,'B005')
insert into ChoGiuXe values (1,0,'B006')
insert into ChoGiuXe values (1,1,'B007')
insert into ChoGiuXe values (1,0,'B008')
insert into ChoGiuXe values (1,2,'C001')
insert into ChoGiuXe values (1,1,'C002')
insert into ChoGiuXe values (1,1,'C003')
insert into ChoGiuXe values (1,0,'C004')
insert into ChoGiuXe values (1,3,'C005')
insert into ChoGiuXe values (1,0,'C006')
insert into ChoGiuXe values (1,1,'C007')
insert into ChoGiuXe values (1,0,'C008')
insert into ChoGiuXe values (1,2,'D001')
insert into ChoGiuXe values (1,1,'D002')
insert into ChoGiuXe values (1,1,'D003')
insert into ChoGiuXe values (1,0,'D004')
insert into ChoGiuXe values (1,3,'D005')
insert into ChoGiuXe values (1,0,'D006')
insert into ChoGiuXe values (1,1,'D007')
insert into ChoGiuXe values (1,0,'D008')
drop table if exists TaiKhoan
create table TaiKhoan
(
	DangNhap varchar(30) primary key,
	Pass varchar(30),
	HoTen nvarchar(100),
	SDT char(11),
	SoDu int,
)
drop table if exists Xe_TaiKhoan
create table Xe_TaiKhoan
(
	ID int identity primary key,
	BienSoXe varchar(9),
	DangNhap varchar(30),
	TrangThai int, --1 Da dat cho, 2 da thanh toan, 3 dang su dung, 4 datraxe
	ThoiGianDatCho datetime default getdate(),
	ID_Vitri int references ChoGiuXe(ID)
)
drop table if exists Xe
create table Xe
(
	ID int identity primary key,
	BienSoXe varchar(9),
	ThoiGianBatDau datetime,
	ThoiGianKetThuc datetime,
	TaiKhoan varchar(30) references TaiKhoan(DangNhap),
	Phi int,
	CodeLayXe varchar(30),
	TrangThai int, --1 dang gui, 2 da lay, 3 dang dat
)
drop table if exists DangNhap
create table DangNhap
(
	ID int identity primary key,
	TaiKhoan varchar(30),
	MatKhau varchar(30),
)
insert into DangNhap values ('admin','1')
drop table if exists TheRFID
create table TheRFID
(
	MaCode varchar(30) primary key,
	BienSoXe varchar(15),
	TrangThai int,
	ThoiGianBatDau datetime default getdate(),
	ThoiGianKetThuc datetime
)
drop FUNCTION if exists dbo.GetCarParking
go
CREATE FUNCTION dbo.GetCarParking 
()
RETURNS nvarchar(max)
AS
	begin
		declare @out varchar(9)
		set @out = (select * from dbo.BaiGiuXe where DaCoXe < TongSoCho for json auto)
		return (@out)
	end
go
drop FUNCTION if exists dbo.GetLiscense
go
CREATE FUNCTION dbo.GetLiscense 
(@Lis varchar(30))
RETURNS nvarchar(max)
AS
	begin
		declare @out nvarchar(max)
		select @out =BienSoXe from dbo.TheRFID where MaCode=@Lis 
		return (@out)
	end
go

drop TRIGGER if exists trg_cgx
go
CREATE TRIGGER trg_cgx ON ChoGiuXe AFTER Update AS 
BEGIN
	declare @ID int,@stt int
	select @ID=BGX_ID,@stt=TrangThai from inserted
	if @stt = 0
		begin
			UPDATE BaiGiuXe SET DaCoXe = DaCoXe - 1  where ID=@ID
		end
	else
		begin
			UPDATE BaiGiuXe SET DaCoXe = DaCoXe + 1  where ID=@ID
		end
END
--drop PROCEDURE if exists DatXe
--go
--CREATE PROCEDURE DatXe  @bsx varchar(9),@tk varchar(30), @out int out
--as
--begin
--	insert into 
--end
--go

insert into TaiKhoan values('Tuan','1',N'Bùi Đức Tuấn','0886938129',1000000000)
insert into TheRFID values('B2D1C849','51A-175.56',1,'20200702','20201202')--anh 1
insert into TheRFID values('F5753E2A','60A-696.97',1,'20200702','20201202')--anh 2
insert into TheRFID values('F29E9F0D','30E-921.15',1,'20200702','20201202')--anh 3

SELECT dbo.GetLiscense('B2D1C849') as carparking