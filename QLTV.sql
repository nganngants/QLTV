-- Note: you have to drop QLTV database (if you had) first before running entire script
-- Note: Just run the script and you're good to go with a new database
--DROP DATABASE QLTV
CREATE DATABASE QLTV
go
USE QLTV

go
CREATE TABLE NHOMNGUOIDUNG
(
	id int IDENTITY(1,1) primary key,
	MaNhomNguoiDung AS CAST('NND' + right('000' + CAST(id as varchar(5)), 3) AS CHAR(6)) persisted ,
	TenNhomNguoiDung nvarchar(max) NOT NULL
);
go
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Quản Lý')
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Thủ Thư')
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values (N'Độc Giả')

go
CREATE TABLE CHUCNANG
(
     id int  primary key IDENTITY(1,1),
	 MaChucNang AS CAST('CN' + right('000' + CAST(id as varchar(3)), 3) as char(5))persisted,
     TenChucNang NVARCHAR(MAX) NOT NULL,
     TenManHinh NVARCHAR(MAX) NOT NULL
)
go

insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLDG', N'Quản Lý Độc Giả')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLS', N'Quản Lý Sách')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLPM', N'Quản Lý Phiếu Mượn Trả')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLPT', N'Quản Lý Phiếu Thu')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('BCTK', N'Báo Cáo Thống Kê')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLND', N'Quản Lý Người Dùng')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('TDQD', N'Thay Đổi Quy Định')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('DG', N'Là Độc Giả')

go
CREATE TABLE PHANQUYEN
(
    idNhomNguoiDung INT FOREIGN KEY REFERENCES NHOMNGUOIDUNG on delete cascade,
    idChucNang INT FOREIGN KEY REFERENCES CHUCNANG on delete cascade,
    PRIMARY KEY (idNhomNguoiDung, idChucNang)
)
go
INSERT INTO PHANQUYEN VALUES (1, 1)
INSERT INTO PHANQUYEN VALUES (1, 2)
INSERT INTO PHANQUYEN VALUES (1, 3)
INSERT INTO PHANQUYEN VALUES (1, 4)
INSERT INTO PHANQUYEN VALUES (1, 5)
INSERT INTO PHANQUYEN VALUES (1, 6)
INSERT INTO PHANQUYEN VALUES (1, 7)

INSERT INTO PHANQUYEN VALUES (2, 1)
INSERT INTO PHANQUYEN VALUES (2, 2)
INSERT INTO PHANQUYEN VALUES (2, 3)
INSERT INTO PHANQUYEN VALUES (2, 4)
INSERT INTO PHANQUYEN VALUES (2, 5)

INSERT INTO PHANQUYEN VALUES (3, 8)



go
CREATE TABLE NGUOIDUNG
(
	id INT IDENTITY PRIMARY KEY,
	MaNguoiDung  AS CAST('ND'+ RIGHT('000000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    TenNguoiDung NVARCHAR(MAX) NOT NULL,
    NgaySinh datetime,
    ChucVu NVARCHAR(MAX),
    TenDangNhap VARCHAR(MAX) NOT NULL,
    MatKhau VARCHAR(MAX) NOT NULL,
    idNhomNguoiDung INT REFERENCES NHOMNGUOIDUNG on delete cascade NOT NULL
)
go

set dateformat dmy

go
INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung) 
VALUES (N'Admin Hệ Thống', 'admin', '123', 1)
INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung) 
VALUES (N'Thủ Thư', 'lib', '123', 2)
INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, NgaySinh, MatKhau, idNhomNguoiDung) 
VALUES (N'Độc Giả A', 'docgia1', '13/12/1999', '123', 3)

go
CREATE TABLE THELOAI
(
	id int IDENTITY(1,1)  primary key,
	MaTheLoai As Cast('TL' + right('0000' + CAST(id as varchar(4)), 4) as char(6)) persisted,  
	TenTheLoai NVARCHAR(MAX) NOT NULL
)
go
insert into THELOAI values(N'Thể loại X')
insert into THELOAI values(N'Thể loại Y')

go

CREATE TABLE TUASACH
(
	id INT IDENTITY  PRIMARY KEY,
	MaTuaSach  AS cast('TS'+ right('0000' + CAST(ID AS VARCHAR(10)), 4) as char(6)) PERSISTED,
	TenTuaSach NVARCHAR(MAX) NOT NULL,
	idTheLoai int references THELOAI NOT NULL,
	DaAn int DEFAULT 0
)
go
insert into TUASACH values (N'Tựa sách 1', 1, 0)
insert into TUASACH values (N'Tựa sách 2', 2, 0)
go

CREATE TABLE TACGIA
(
	id INT IDENTITY PRIMARY KEY,
	MATACGIA  AS CAST('TG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenTacGia NVARCHAR(MAX) NOT NULL
)
go
INSERT INTO TACGIA VALUES (N'Nguyễn Nhật Ánh')
go
CREATE TABLE CT_TACGIA
(
	idTacGia int references TACGIA  on delete cascade,
	idTuaSach int references TUASACH on delete cascade,
	primary key (idTacGia, idTuaSach)
)
go
INSERT INTO CT_TACGIA VALUES (1, 1)
go

CREATE TABLE LOAIDOCGIA
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	MaLoaiDocGia  AS CAST('LDG'+ RIGHT('000' + CAST(ID AS VARCHAR(10)), 3) AS CHAR(6))PERSISTED,
	TenLoaiDocGia NVARCHAR(MAX) NOT NULL
)
go
INSERT INTO LOAIDOCGIA VALUES(N'Giảng viên')
INSERT INTO LOAIDOCGIA VALUES(N'Sinh viên')
INSERT INTO LOAIDOCGIA VALUES(N'Khác')
go
CREATE TABLE DOCGIA
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	MaDocGia  AS CAST('DG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenDocGia NVARCHAR(MAX) NOT NULL,
	NgaySinh datetime NOT NULL, 
	DiaChi NVARCHAR(MAX),
	Email VARCHAR(MAX),
	NgayLapThe Datetime NOT NULL, 
	NgayHetHan Datetime NOT NULL, 
	idLoaiDocGia INT references LOAIDOCGIA NOT NULL, 
	TongNoHienTai int NOT NULL DEFAULT 0,
	idNguoiDung INT REFERENCES NGUOIDUNG NOT NULL
)
go
INSERT INTO DOCGIA (TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia, idNguoiDung)
VALUES (N'Độc Giả A', '13/12/1999', '20/10/2020', '20/4/2021', 2, 3)

go
CREATE TABLE SACH
(
	id int IDENTITY(1,1) primary key,
	MaSach AS CAST('S'+ RIGHT('00000' + CAST(id AS VARCHAR(10)), 5) AS CHAR(6)) PERSISTED,
	idTuaSach int references TUASACH NOT NULL, 
	SoLuong int NOT NULL, 
	SoLuongConLai int NOT NULL, 
	DonGia int NOT NULL, 
	NamXB int NOT NULL, 
	NhaXB NVARCHAR(MAX) NOT NULL,
	DaAn int NOT NULL DEFAULT 0
)

go
CREATE TABLE PHIEUNHAPSACH
(
	SoPhieuNhap int IDENTITY(1,1) primary key,
	TongTien int NOT NULL DEFAULT 0, 
	NgayNhap Datetime NOT NULL
)
go
CREATE TABLE CT_PHIEUNHAP
(
	SoPhieuNhap int references PHIEUNHAPSACH(SoPhieuNhap),
	idSach int references SACH,
	DonGia int NOT NULL, 
	ThanhTien int NOT NULL, 
	SoLuongNhap int NOT NULL, 
	primary key (SoPhieuNhap, idSach)
)
go 
create table CUONSACH
(
	id int IDENTITY(1,1) primary key,
	MaCuonSach AS CAST('CS'+ RIGHT('0000' + CAST(id AS VARCHAR(10)), 4) AS CHAR(6)) PERSISTED,
	idSach int references SACH NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1,
	DaAn int NOT NULL DEFAULT 0
)
go
create table PHIEUMUONTRA
(
	SoPhieuMuonTra int IDENTITY(1,1) primary key,
	idDocGia int references DOCGIA NOT NULL,
	idCuonSach int references CUONSACH NOT NULL,
	NgayMuon Datetime NOT NULL, 
	NgayTra Datetime, 
	HanTra Datetime NOT NULL,
	SoTienPhat int DEFAULT 0
)
go
create table PHIEUTHU
(
	SoPhieuThu int IDENTITY(1,1) primary key,
	idDocGia int references DOCGIA NOT NULL,
	SoTienThu int NOT NULL DEFAULT 0,
	NgayLap datetime NOT NULL
)
go
create table BCLUOTMUONTHEOTHELOAI
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Thang int NOT NULL, 
	Nam int NOT NULL, 
	MaBaoCao AS CAST('BCLM' + RIGHT('0' + CAST(THANG AS CHAR(2)), 2) + CAST(NAM AS CHAR(4)) AS CHAR(10)) 
				PERSISTED,
	TongSoLuotMuon int NOT NULL DEFAULT 0
)
go
create table CT_BCLUOTMUONTHEOTHELOAI
(
	idBaoCao INT references BCLUOTMUONTHEOTHELOAI,
	idTheLoai int references THELOAI,
	SoLuotMuon int NOT NULL DEFAULT 0, 
	TiLe numeric(4,2) DEFAULT 0,
	primary key (idBaoCao, idTheLoai)
)
go
create table BCSACHTRATRE
(
	Ngay datetime not null,
	idCuonSach int references CUONSACH on delete cascade,
	NgayMuon datetime NOT NULL,
	SoNgayTre int NOT NULL DEFAULT 0
	primary key(Ngay, idCuonSach)
)
go

create table THAMSO
(
	id int identity(1,1) primary key,
	TuoiToiThieu int NOT NULL, 
	TuoiToiDa int NOT NULL, 
	ThoiHanThe int NOT NULL, 
	KhoangCachXuatBan int NOT NULL , 
	SoSachMuonToiDa int NOT NULL, 
	SoNgayMuonToiDa int NOT NULL, 
	DonGiaPhat int NOT NULL,
	AD_QDKTTienThu int NOT NULL
)
go
INSERT INTO THAMSO VALUES(18, 55, 6, 8, 5, 4, 1000, 1)
