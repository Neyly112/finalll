create database QLCH2
use QLCH2
drop database QLCH2
use master


CREATE TABLE Chu_ho
(
  Ten NVARCHAR(50) NOT NULL,
  DiaChi NVARCHAR(255) NOT NULL,
  Email NVARCHAR(50) NOT NULL,
  SoDienThoai VARCHAR(11) NOT NULL,
  MatKhau NVARCHAR(50) NOT NULL,
  MaChuHo VARCHAR(50) NOT NULL,
  PRIMARY KEY (MaChuHo)
)
go
ALTER TABLE Chu_ho
ADD CONSTRAINT SDTCH UNIQUE (SoDienThoai)
ALTER TABLE Chu_ho
ADD CONSTRAINT MK DEFAULT '1' FOR MatKhau
go
INSERT INTO Chu_ho (Ten, DiaChi, Email, SoDienThoai, MatKhau, MaChuHo)
VALUES
(N'Chủ hộ 1', N'Địa chỉ 1', 'thuanminh1390@gmail.com', '123456789', 'password1', 'CH001')


go
CREATE TABLE Quan_li
(
  Ten NVARCHAR(50) NOT NULL,
  DiaChi NVARCHAR(255) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  SoDienThoai VARCHAR(11) NOT NULL,
  MatKhau NVARCHAR(50) NOT NULL,
  MaQuanLi VARCHAR(50) NOT NULL,
  PRIMARY KEY (MaQuanLi)
)
ALTER TABLE Quan_li
ADD CONSTRAINT MK_QL DEFAULT '1' FOR MatKhau
ALTER TABLE Quan_li
ADD CONSTRAINT SDTQL UNIQUE (SoDienThoai)
go
INSERT INTO Quan_li (Ten, DiaChi, Email, SoDienThoai, MatKhau, MaQuanLi)
VALUES
(N'Quản lí 1', N'Địa chỉ 4', 'thuanminh1390@gmail.com', '000','password4', 'QL001')
go
CREATE TABLE Nguoi_thue
(
  Ten NVARCHAR(50) NOT NULL,
  DiaChi NVARCHAR(255) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  SoDienThoai VARCHAR(11) NOT NULL,
  MatKhau NVARCHAR(50) NOT NULL,
  MaNguoiThue VARCHAR(50) NOT NULL,
  PRIMARY KEY (MaNguoiThue),
)
ALTER TABLE Nguoi_thue
ADD CONSTRAINT SDTNT UNIQUE (SoDienThoai)
ALTER TABLE Nguoi_thue
ADD CONSTRAINT MK_NT DEFAULT '1' FOR MatKhau
go
INSERT INTO Nguoi_thue (Ten, DiaChi, Email, SoDienThoai, MatKhau, MaNguoiThue)
VALUES
(N'Người thuê 1', N'Địa chỉ 7', 'nguoithue1@example.com', '0123456781', 'password7', 'NT001'),
(N'Người thuê 2', N'Địa chỉ 8', 'nguoithue2@example.com', '0123456782', 'password8', 'NT002'),
(N'Người thuê 3', N'Địa chỉ 9', 'nguoithue3@example.com', '0123456783', 'password9', 'NT003'),
(N'Người thuê 4', N'Địa chỉ 10', 'nguoithue4@example.com', '0123456784', 'password10', 'NT004'),
(N'Người thuê 5', N'Địa chỉ 11', 'nguoithue5@example.com', '0123456785', 'password11', 'NT005');

go
CREATE TABLE Dang_ki_xe
(
  Ngay_dang_ki DATE NOT NULL,
  bien_so VARCHAR(50) NOT NULL,
  loai_xe NVARCHAR(50) NOT NULL,
  MaNguoiThue VARCHAR(50) NOT NULL,
  PRIMARY KEY (bien_so),
  FOREIGN KEY (MaNguoiThue) REFERENCES Nguoi_thue(MaNguoiThue)
)

go
-- Insert data into Nguoi_thue (Renter) table

-- Insert data into Dang_ki_xe (Vehicle Registration) table
INSERT INTO Dang_ki_xe (Ngay_dang_ki, bien_so, loai_xe, MaNguoiThue)
VALUES ('2023-12-31', 'ABC-123', N'xe máy', 'NT001')
go


create proc xemXe
as
begin
	select Dang_ki_xe.loai_xe from Dang_ki_xe join Nguoi_thue on Dang_ki_xe.MaNguoiThue = Nguoi_thue.MaNguoiThue join Phong_thue_so_huu on Nguoi_thue.MaNguoiThue = Phong_thue_so_huu.TaiKhoan
end


go

CREATE TABLE Phong_cho_thue
(
  MaPhong VARCHAR(50) NOT NULL,
  MoTaPhong NVARCHAR(255) NOT NULL,
  GiaPhong FLOAT NOT NULL check(GiaPhong > 0),
  TrangThaiPhong NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaPhong),
)
go
INSERT INTO Phong_cho_thue(MaPhong, MoTaPhong, GiaPhong, TrangThaiPhong)
VALUES
('P001',N'1 phòng ngủ, 2 máy lạnh, 1 nhà bếp',50000000,N'Đã cho thuê'),
('P002',N'1 phòng ngủ, 2 máy lạnh, 1 nhà bếp',50000000,N'Đã cho thuê'),
('P003',N'3 phòng ngủ, 3 máy lạnh, 1 nhà bếp',250000000,N'Đã cho thuê'),
('P004',N'2 phòng ngủ, 2 máy lạnh, 1 nhà bếp',15000000,N'Đã cho thuê'),
('P005',N'3 phòng ngủ, 1 máy lạnh, 1 nhà bếp',18000000,N'Đã cho thuê'),
('P006',N'1 phòng ngủ, 3 máy lạnh, 1 nhà bếp',22000000,N'Đã cho thuê'),
('P007',N'2 phòng ngủ, 1 máy lạnh, 1 nhà bếp',20000000,N'Đã cho thuê'),
('P008',N'4 phòng ngủ, 2 máy lạnh, 1 nhà bếp',25000000,N'Đã cho thuê'),
('P009',N'1 phòng ngủ, 1 máy lạnh, 1 nhà bếp',12000000,N'Chưa được thuê'),
('P010',N'3 phòng ngủ, 2 máy lạnh, 1 nhà bếp',19000000,N'Chưa được thuê'),
('P011',N'2 phòng ngủ, 2 máy lạnh, 1 nhà bếp',17000000,N'Chưa được thuê'),
('P012',N'1 phòng ngủ, 1 máy lạnh, 1 nhà bếp',13000000,N'Chưa được thuê'),
('P013',N'3 phòng ngủ, 3 máy lạnh, 1 nhà bếp',23000000,N'Chưa được thuê');
go
CREATE TABLE Phong_thue_so_huu
(
  TaiKhoan VARCHAR(50) NOT NULL,
  MaPhong VARCHAR(50) NOT NULL,
  FOREIGN KEY (MaPhong) REFERENCES Phong_cho_thue(MaPhong),
  FOREIGN KEY (TaiKhoan) REFERENCES Nguoi_thue(MaNguoiThue)
)
go
INSERT INTO Phong_thue_so_huu (TaiKhoan, MaPhong)
VALUES 
('NT001', 'P002'),
('NT001', 'P006'),
('NT001', 'P007'),
('NT002', 'P001'),
('NT003', 'P003'),
('NT004', 'P004'),
('NT005', 'P005'),
('NT002', 'P008');

go

CREATE TABLE Hop_dong
(
  MaHopDong VARCHAR(50) NOT NULL default 'HD001',
  NgayBatDau DATE NOT NULL,
  NgayKetThuc DATE NOT NULL,
  SoNguoiO INT NOT NULL check(SoNguoiO > 0),
  MaPhong VARCHAR(50) NOT NULL,
  TrangThai NVARCHAR(50),
  MaChuHo VARCHAR(50) NOT NULL,
  MaNguoiThue VARCHAR(50) NOT NULL,
  MaQuanLi VARCHAR(50),
  PRIMARY KEY (MaHopDong),
  FOREIGN KEY (MaQuanLi) REFERENCES Quan_li(MaQuanLi),
  FOREIGN KEY (MaChuHo) REFERENCES Chu_ho(MaChuHo),
  FOREIGN KEY (MaNguoiThue) REFERENCES Nguoi_thue(MaNguoiThue),
  FOREIGN KEY (MaPhong) REFERENCES Phong_cho_thue(MaPhong)
);
go
INSERT INTO Hop_dong (MaHopDong, NgayBatDau, NgayKetThuc, SoNguoiO, MaPhong, TrangThai, MaChuHo, MaNguoiThue, MaQuanLi)
VALUES 
('HD001', '2024-05-14', '2024-06-1', 1, 'P002', N'Chưa xác nhận', 'CH001', 'NT001', 'QL001');

go
CREATE TABLE Bang_phi
(
  TienNuoc FLOAT NOT NULL Check(TienNuoc > 0),
  PhiSinhHoat FLOAT NOT NULL check(PhiSinhHoat > 0),
  TienDien FLOAT NOT NULL Check(TienDien > 0),
  TienXeMay FLOAT NOT NULL Check(TienXeMay >= 0),
  TienXeDap FLOAT NOT NULL CHECK(TienXeDap >= 0),
  TienXeDuoi1_5Tan FLOAT NOT NULL Check(TienXeDuoi1_5Tan  >= 0),
  MaBangPhi VARCHAR(50) NOT NULL,
  MaChuHo VARCHAR(50) NOT NULL,
  MaQuanLi VARCHAR(50) NOT NULL,
  PRIMARY KEY (MaBangPhi),
  FOREIGN KEY (MaChuHo) REFERENCES Chu_ho(MaChuHo),
  FOREIGN KEY (MaQuanLi) REFERENCES Quan_li(MaQuanLi)
)
go
INSERT INTO Bang_phi (TienNuoc, PhiSinhHoat, TienDien, TienXeMay, TienXeDap, TienXeDuoi1_5Tan, MaBangPhi, MaChuHo, MaQuanLi) 
VALUES 
(50.00, 100.00, 80.00, 20.00, 0.00, 50.00, 'BP001', 'CH001', 'QL001'),
(60.00, 110.00, 80.00, 20.00, 0.00, 40.00, 'BP002', 'CH001', 'QL001'),
(50.00, 100.00, 70.00, 10.00, 0.00, 50.00, 'BP003', 'CH001', 'QL001');



go

CREATE TABLE Hoa_don
(
  MaHoaDon VARCHAR(50) NOT NULL,
  TuNgay DATE NOT NULL,
  DenNgay DATE NOT NULL,
  MaPhong VARCHAR(50) NOT NULL,
  MaBangPhi VARCHAR(50) NOT NULL,
  TongTien float NOT NULL check(TongTien >0),
  TrangThai NVARCHAR(50) NOT NULL,
  PRIMARY KEY (MaHoaDon),
  FOREIGN KEY (MaPhong) REFERENCES Phong_cho_thue(MaPhong),
  FOREIGN KEY (MaBangPhi) REFERENCES Bang_phi(MaBangPhi)
)
go
INSERT INTO Hoa_don (MaHoaDon, TuNgay, DenNgay, MaPhong, MaBangPhi, TongTien, TrangThai) 
VALUES 
('HD001', '2024-05-21', '2024-05-30', 'P001', 'BP001', 120000000, N'Thanh toán'),
('HD002', '2024-05-21', '2024-05-30', 'P002', 'BP002', 225000000, N'Thanh toán'),
('HD003', '2024-05-21', '2024-05-30', 'P003', 'BP001', 178900000, N'Chưa thanh toán'),
('HD004', '2024-05-21', '2024-05-30', 'P004', 'BP002', 212345000, N'Chưa thanh toán'),
('HD005', '2024-05-21', '2024-05-30', 'P005', 'BP002', 223256000, N'Chưa thanh toán'),
('HD006', '2024-05-21', '2024-05-30', 'P006', 'BP001', 122334500, N'Chưa thanh toán'),
('HD007', '2024-05-21', '2024-05-30', 'P007', 'BP003', 123120000, N'Chưa thanh toán'),
('HD008', '2024-05-21', '2024-05-30', 'P008', 'BP001', 785987000, N'Chưa thanh toán');

go
CREATE TABLE Dien
(
  so_kwh FLOAT NOT NULL check(so_kwh > 0) ,
  Tong_tien_dien FLOAT NOT NULL check(Tong_tien_dien > 0),
  MaHoaDon VARCHAR(50) NOT NULL,
  FOREIGN KEY (MaHoaDon) REFERENCES Hoa_don(MaHoaDon)
)

CREATE TABLE Nuoc
(
  So_m3 FLOAT NOT NULL check(So_m3 > 0) ,
  Tong_tien_nuoc FLOAT NOT NULL check(Tong_tien_nuoc > 0),
  MaHoaDon VARCHAR(50) NOT NULL,
  FOREIGN KEY (MaHoaDon) REFERENCES Hoa_don(MaHoaDon)
)

go
CREATE TABLE Tin_nhan (
    Sender NVARCHAR(50),
    Receiver NVARCHAR(50),
    Content NVARCHAR(255),
    SentDateTime VARCHAR(255),
    ReadStatus INTEGER DEFAULT 0 -- 0: unread, 1: read
);
go
CREATE TABLE Thong_ke (
	thang varchar(10),
	so_nguoi_thue varchar(256),
	so_phong_con_trong varchar(256),
	so_nguoi_chua_thanh_toan varchar(256),
	tong_thanh_toan varchar(256)
)
go
CREATE TABLE Tien_xe
(
  soLuongXe INT NOT NULL check(soLuongXe > 0) ,
  Tong_tien_xe FLOAT NOT NULL check(Tong_tien_xe > 0),
  MaHoaDon VARCHAR(50) NOT NULL,
  FOREIGN KEY (MaHoaDon) REFERENCES Hoa_don(MaHoaDon)
)
go
insert into Tien_xe values(1, 20.00, 'HD001')
go
CREATE FUNCTION getTopMaHoaDonn() 
RETURNS VARCHAR(10)
AS
BEGIN 
    DECLARE @result VARCHAR(10);
    SELECT @result = (SELECT TOP 1 MaHoaDon FROM Hoa_don ORDER BY MaHoaDon DESC);
    RETURN @result;
END;
go
create proc insertToNuoc 
@so_m3 float, @tongTienNuoc float
as 
begin
	declare @ma varchar(10)
	set @ma = dbo.getTopMaHoaDonn()
	insert into Nuoc values(@so_m3, @tongTienNuoc, @ma)
end
go
create proc insertToDien 
@soKwh float, @tongTienDien float
as 
begin
	declare @ma varchar(10)
	set @ma = dbo.getTopMaHoaDonn()
	insert into Dien values(@soKwh, @tongTienDien, @ma)
end
go
create proc insertToTienXe
@soLuongXe float, @tongTienXe float
as 
begin
	declare @ma varchar(10)
	set @ma = dbo.getTopMaHoaDonn()
	insert into Tien_xe values(@soLuongXe, @tongTienXe, @ma)
end
go

create proc getGiaPhong 
@maPhong varchar(10)
as
begin 
	select GiaPhong from Phong_cho_thue where MaPhong = @maPhong
end
go

-- trigger kiểm tra ngày lập họp đồng --
CREATE TRIGGER CheckStartDateBeforeEndDate
ON Hop_dong
for insert
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE NgayBatDau >= NgayKetThuc
    )
    BEGIN
        print (N'Ngày bắt đầu phải trước ngày kết thúc.')
        ROLLBACK TRANSACTION
        RETURN
    END
END
go

CREATE FUNCTION getTopMa() 
RETURNS VARCHAR(10)
AS
BEGIN 
    DECLARE @result VARCHAR(10);
    SELECT @result = (SELECT TOP 1 MaChuHo FROM Chu_ho ORDER BY MaChuHo DESC);
    RETURN @result;
END;
go
--tao ma tu dong
create function insertTableChuho()
returns varchar(10) as
begin 
	declare @ma varchar(10)
	set @ma = dbo.getTopMa()
	declare @stt int 
	set @stt = cast(right(@ma, 3) as int) + 1
	if @stt < 10 
	begin 
		set @ma = left(@ma, 4) + cast(@stt as varchar(1))	
	end
	else if @stt < 100 
	begin 
		set @ma = left(@ma, 3) + cast(@stt as varchar(2))	
	end
	else
	begin 
		set @ma = left(@ma, 2) + cast(@stt as varchar(3))	
	end
	return @ma
end
go
create proc insertToChuho
@ten nvarchar(255),@diachi nvarchar(255), @email varchar(255),@sodienthoai varchar(50), @matkhau nvarchar(10)
as 
begin
	declare @ma varchar(10)
	set @ma = dbo.insertTableChuho()
	insert into Chu_ho values(@ten, @diachi, @email, @sodienthoai, @matkhau, @ma)
end
go

---ma nguoi thue
 
create function getTopMaNT() 
returns varchar(10) as
	begin 
		return (select top 1 MaNguoiThue from Nguoi_thue order by MaNguoiThue desc)
	end
go
--tao ma tu dong
create function insertTableNguoiThue()
returns varchar(10) as
begin 
	declare @ma varchar(10)
	set @ma = dbo.getTopMaNT()
	declare @stt int 
	set @stt = cast(right(@ma, 3) as int) + 1
	if @stt < 10 
	begin 
		set @ma = left(@ma, 4) + cast(@stt as varchar(1))	
	end
	else if @stt < 100 
	begin 
		set @ma = left(@ma, 3) + cast(@stt as varchar(2))	
	end
	else
	begin 
		set @ma = left(@ma, 2) + cast(@stt as varchar(3))	
	end
	return @ma
end
go
create proc insertToNguoiThue
 @email varchar(255), @diachi nvarchar(255), @sodienthoai varchar(50), @ten nvarchar(255), @matkhau nvarchar(10)
as 
begin
	declare @ma varchar(10)
	set @ma = dbo.insertTableNguoiThue()
	insert into Nguoi_thue values(@ten, @diachi, @email, @sodienthoai, @matkhau, @ma)
end
go
create proc getTenNguoiThue
@maPhong varchar(50)
as 
begin
	select top 1 Nguoi_thue.Ten from Nguoi_thue join Phong_thue_so_huu on Nguoi_thue.MaNguoiThue = Phong_thue_so_huu.TaiKhoan where Phong_thue_so_huu.MaPhong = @maPhong order by MaNguoiThue desc
end
go

create function getTopMaHD() 
returns varchar(10) as
	begin 
		return (select top 1 MaHopDong from Hop_dong order by MaHopDong desc)
	end
go

create function getTopMaBP() 
returns varchar(10) as
	begin 
		return (select top 1 MaBangPhi from Bang_phi order by MaBangPhi desc)
	end
go

create function insertTableBP()
returns varchar(10) as
begin 
	declare @ma varchar(10)
	set @ma = dbo.getTopMaBP()
	declare @stt int 
	set @stt = cast(right(@ma, 3) as int) + 1
	if @stt < 10 
	begin 
		set @ma = left(@ma, 4) + cast(@stt as varchar(1))	
	end
	else if @stt < 100 
	begin 
		set @ma = left(@ma, 3) + cast(@stt as varchar(2))	
	end
	else
	begin 
		set @ma = left(@ma, 2) + cast(@stt as varchar(3))	
	end
	return @ma
end
go
create proc insertToBP
@TienNuoc float, @PhiSinhHoat float, @TienDien float, @TienXeMay float, @TienXeDap float, @TienXeDuoi1_5Tan float
as 
begin
	declare @ma varchar(10)
	declare @maCH varchar(10)
	declare @maQL varchar(10)
	set @ma = dbo.insertTableBP()
	set @maCH = dbo.getTopMaCH()
	set @maQL = dbo.getTopMaQL()
	insert into Bang_phi values(@TienNuoc, @PhiSinhHoat, @TienDien, @TienXeMay, @TienXeDap, @TienXeDuoi1_5Tan, @ma, @maCH, @maQL)
end
go
create function getTopMaCH() 
returns varchar(10) as
	begin 
		return (select top 1 MaChuHo from Chu_ho order by MaChuHo desc)
	end
go
--tao ma tu dong
create function insertTableHD()
returns varchar(10) as
begin 
	
	declare @ma varchar(10)
	set @ma = dbo.getTopMaHD()
	declare @stt int 
	set @stt = cast(right(@ma, 3) as int) + 1
	if @stt < 10 
	begin 
		set @ma = left(@ma, 4) + cast(@stt as varchar(1))	
	end
	else if @stt < 100 
	begin 
		set @ma = left(@ma, 3) + cast(@stt as varchar(2))	
	end
	else
	begin 
		set @ma = left(@ma, 2) + cast(@stt as varchar(3))	
	end
	return @ma
end
go
create proc insertToHD
@NgayKT date, @nguoi int, @NgayBD date, @maPhong varchar(50)
as 
begin
	declare @maHD varchar(10)
	declare @maQL varchar(10)
	declare @maCH varchar(10)
	declare @maNT varchar(10)
	set @maHD = dbo.insertTableHD()
	set @maQL = dbo.getTopMaQL()
	set @maCH = dbo.getTopMa()
	set @maNT = dbo.getTopMaNT()
	insert into Hop_dong values(@maHD, @NgayBD, @NgayKT, @nguoi,  @maPhong, N'Chưa xác nhận', @maCH, @maNT, @maQL)
end
go

create proc insertToHD1
@maNT varchar(50), @NgayKT date, @nguoi int, @NgayBD date, @maPhong varchar(50)
as 
begin
	declare @maHD varchar(10)
	declare @maQL varchar(10)
	declare @maCH varchar(10)
	
	set @maHD = dbo.insertTableHD()
	set @maQL = dbo.getTopMaQL()
	set @maCH = dbo.getTopMa()
	
	insert into Hop_dong values(@maHD, @NgayBD, @NgayKT, @nguoi,  @maPhong, N'Chưa xác nhận', @maCH, @maNT, @maQL)
end

go
create function getTopMaQL() 
returns varchar(10) as
	begin 
		return (select top 1 MaQuanLi from Quan_li order by MaQuanLi desc)
	end
go

create function getTopMaHoaDon() 
returns varchar(10) as
	begin 
		return (select top 1 MaHoaDon from Hoa_don order by MaHoaDon desc)
	end
go
--tao ma tu dong
create function insertTableHoaDon()
returns varchar(10) as
begin 
	declare @ma varchar(10)
	set @ma = dbo.getTopMaHoaDon()
	declare @stt int 
	set @stt = cast(right(@ma, 3) as int) + 1
	if @stt < 10 
	begin 
		set @ma = left(@ma, 4) + cast(@stt as varchar(1))	
	end
	else if @stt < 100 
	begin 
		set @ma = left(@ma, 3) + cast(@stt as varchar(2))	
	end
	else
	begin 
		set @ma = left(@ma, 2) + cast(@stt as varchar(3))	
	end
	return @ma
end
go

create proc insertToHoaDon
@Ngay_lap_hoa_don date, @DenNgay date, @maPhong varchar(10), @Ma_bang_phi varchar(10), @tongTien float
as 
begin
	declare @ma varchar(10)
	set @ma = dbo.insertTableHoaDon()
	insert into Hoa_don values(@ma, @Ngay_lap_hoa_don, @DenNgay, @maPhong, @Ma_bang_phi, @tongTien, N'Chưa thanh toán')
end

select * from Nguoi_thue
select * from Quan_li
select * from Phong_cho_thue
update Phong_cho_thue set TrangThaiPhong = N'Đã thuê' where MaPhong = 'P002'
select * from Chu_ho
select * from Dang_ki_xe
select * from Tin_nhan
select * from Thong_ke
select * from Phong_thue_so_huu
select * from Hoa_don
select * from Hop_dong
select MaNguoiThue from Nguoi_thue where Ten = N'Dương'

exec insertToHD1 'NT004', '2024-5-31', 2, '2024-5-27', 'P009'
