-- Note: u have to drop QLTV database first before running entire script
CREATE DATABASE QLTV
go
USE QLTV

go
CREATE TABLE NHOMNGUOIDUNG
(
	id int IDENTITY(1,1) primary key,
	MaNhomNguoiDung AS CAST('NND' + right('000' + CAST(id as varchar(5)), 3) AS CHAR(6)) persisted ,
	TenNhomNguoiDung varchar(max)
);
go
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values ('Quan ly')
insert into NHOMNGUOIDUNG (TenNhomNguoiDung) values ('Thu thu')
go
CREATE TABLE CHUCNANG
(
     id int  primary key IDENTITY(1,1),
	 MaChucNang AS CAST('CN' + right('000' + CAST(id as varchar(3)), 3) as char(5))persisted,
     TenChucNang VARCHAR(MAX),
     TenManHinh VARCHAR(MAX)
)
go

insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLDG', 'Quan Ly Doc Gia')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLS', 'Quan Ly Sach')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLPM', 'Quan Ly Phieu Muon Tra')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLPT', 'Quan Ly Phieu Thu')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('BCTK', 'Bao Cao Thong Ke')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('QLND', 'Quan Ly Nguoi Dung')
insert into CHUCNANG (TenChucNang, TenManHinh) VALUES ('TDQD', 'Thay Doi Quy Dinh')

go
CREATE TABLE PHANQUYEN
(
    idNhomNguoiDung INT FOREIGN KEY REFERENCES NHOMNGUOIDUNG on delete cascade,
    idChucNang INT FOREIGN KEY REFERENCES CHUCNANG on delete cascade,
    PRIMARY KEY (idNhomNguoiDung, idChucNang)
)
go
INSERT INTO PHANQUYEN VALUES (1, 1)

go
CREATE TABLE NGUOIDUNG
(
	id INT IDENTITY PRIMARY KEY,
	MaNguoiDung  AS CAST('ND'+ RIGHT('000000' + CAST(id AS VARCHAR(4)), 4) AS CHAR(6)) PERSISTED,
    TenNguoiDung VARCHAR(MAX),
    NgaySinh datetime,
    ChucVu VARCHAR(MAX),
    TenDangNhap VARCHAR(MAX) NOT NULL,
    MatKhau VARCHAR(MAX) NOT NULL,
    idNhomNguoiDung INT REFERENCES NHOMNGUOIDUNG on delete cascade NOT NULL
)
go

INSERT INTO NGUOIDUNG(TenNguoiDung, TenDangNhap, MatKhau, idNhomNguoiDung) VALUES ('Ngan Ngan', 'admin', '123', 1)

go
CREATE TABLE THELOAI
(
	id int IDENTITY(1,1)  primary key,
	MaTheLoai As Cast('TL' + right('000' + CAST(id as varchar(3)), 3) as char(5)) persisted,  
	TenTheLoai VARCHAR(MAX) 
)
go
insert into THELOAI values('X')
insert into THELOAI values('Y')

go

CREATE TABLE TUASACH
(
	id INT IDENTITY  PRIMARY KEY,
	MaTuaSach  AS cast('TS'+ right('0000' + CAST(ID AS VARCHAR(10)), 4) as char(6)) PERSISTED,
	TenTuaSach VARCHAR(MAX),
	idTheLoai int references THELOAI on delete cascade
)
go
insert into TUASACH values ('Tua sach 1', 1)
insert into TUASACH values ('Tua sach 2', 2)
go

CREATE TABLE TACGIA
(
	id INT IDENTITY PRIMARY KEY,
	MATACGIA  AS CAST('TG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenTacGia VARCHAR(MAX)
)
go
INSERT INTO TACGIA VALUES ('Nguyen Nhat Anh')
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
	TenLoaiDocGia VARCHAR(MAX)
)
go
INSERT INTO LOAIDOCGIA VALUES('Giang vien')
INSERT INTO LOAIDOCGIA VALUES('Sinh vien UIT')
INSERT INTO LOAIDOCGIA VALUES('Sinh vien khac')
go
CREATE TABLE DOCGIA
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	MaDocGia  AS CAST('DG'+ RIGHT('0000' + CAST(ID AS VARCHAR(10)), 4) AS CHAR(6))PERSISTED,
	TenDocGia VARCHAR(MAX) NOT NULL,
	NgaySinh datetime NOT NULL, 
	DiaChi VARCHAR(MAX),
	Email VARCHAR(MAX),
	NgayLapThe Datetime NOT NULL, 
	NgayHetHan Datetime NOT NULL, 
	idLoaiDocGia INT references LOAIDOCGIA on delete cascade, 
	TongNoHienTai int
)
go
set dateformat dmy
INSERT INTO DOCGIA(TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia) 
VALUES ('Doc Gia A', '13/12/1989', '27/10/2022', '11/9/2023', 1)
INSERT INTO DOCGIA(TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia) 
VALUES ('Doc Gia B', '13/12/1989', '31/10/2022', '11/11/2023', 2)
INSERT INTO DOCGIA(TenDocGia, NgaySinh, NgayLapThe, NgayHetHan, idLoaiDocGia) 
VALUES ('Doc Gia C', '13/12/1989', '27/8/2022', '11/5/2023', 3)
go
CREATE TABLE SACH
(
	id int IDENTITY(1,1) primary key,
	MaSach AS CAST('S'+ RIGHT('00000' + CAST(id AS VARCHAR(10)), 5) AS CHAR(6)) PERSISTED,
	idTuaSach int references TUASACH on delete cascade , 
	SoLuong int NOT NULL, 
	SoLuongConLai int NOT NULL, 
	DonGia int, 
	NamXB int, 
	NhaXB VARCHAR(MAX)
)
go
INSERT INTO SACH(idTuaSach, SoLuong, SoLuongConLai, DonGia, NamXB, NhaXB)
VALUES (1, 100, 25, 23000, 2015, 'NXB')
INSERT INTO SACH(idTuaSach, SoLuong, SoLuongConLai, DonGia, NamXB, NhaXB)
VALUES (2, 50, 35, 35000, 2020, 'NXB KHAC')
go
CREATE TABLE PHIEUNHAPSACH
(
	SoPhieuNhap int IDENTITY(1,1) primary key,
	TongTien int, 
	NgayNhap Datetime
)
go
CREATE TABLE CT_PHIEUNHAP
(
	SoPhieuNhap int references PHIEUNHAPSACH(SoPhieuNhap) on delete cascade,
	idSach int references SACH on delete cascade,
	DonGia int, 
	ThanhTien int, 
	SoLuongNhap int, 
	primary key (SoPhieuNhap, idSach)
)
go 
create table CUONSACH
(
	id int IDENTITY(1,1) primary key,
	MaCuonSach AS CAST('CS'+ RIGHT('0000' + CAST(id AS VARCHAR(10)), 4) AS CHAR(6)) PERSISTED,
	idSach int references SACH on delete cascade,
	TinhTrang INT
)
go
create table PHIEUMUONTRA
(
	SoPhieuMuonTra int IDENTITY(1,1) primary key,
	idDocGia int references DOCGIA on delete cascade,
	idCuonSach int references CUONSACH on delete cascade,
	NgayMuon Datetime, 
	NgayTra Datetime, 
	HanTra Datetime,
	SoTienPhat int
)
go
create table PHIEUTHU
(
	SoPhieuThu int IDENTITY(1,1) primary key,
	idDocGia int references DOCGIA on delete cascade,
	SoTienThu int ,
	NgayLap datetime
)
go
create table BCLUOTMUONTHEOTHELOAI
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	Thang int, 
	Nam int, 
	MaBaoCao AS CAST('BCLM' + RIGHT('0' + CAST(THANG AS CHAR(2)), 2) + CAST(NAM AS CHAR(4)) AS CHAR(10)) 
				PERSISTED,
	TongSoLuotMuon int
)
go
create table CT_BCLUOTMUONTHEOTHELOAI
(
	idBaoCao INT references BCLUOTMUONTHEOTHELOAI on delete cascade ,
	idTheLoai int references THELOAI on delete cascade,
	SoLuotMuon int, 
	TiLe numeric(4,2),
	primary key (idBaoCao, idTheLoai)
)
go
create table BCSACHTRATRE
(
	Ngay datetime not null,
	idCuonSach int references CUONSACH on delete cascade,
	NgayMuon datetime,
	SoNgayTre int
	primary key(Ngay, idCuonSach)
)
go

create table THAMSO
(
	TuoiToiThieu int, 
	TuoiToiDa int, 
	ThoiHanThe int, 
	KhoangCachXuatBan int , 
	SoSachMuonToiDa int, 
	SoNgayMuonToiDa int, 
	DonGiaPhat int,
	AD_QDKTTienThu int
)
go

--SET DATEFORMAT DMY
--go
--ALTER TABLE DOCGIA 
--ADD CHECK (NgayHetHan>=NgayLapThe)
--ALTER TABLE PHIEUMUONTRA
--ADD CHECK (HanTra>=NgayMuon and NgayTra >= NgayMuon and SoTienPhat >=0 )
--ALTER TABLE BCLUOTMUONTHEOTHELOAI
--ADD CHECK (Thang >= 1 and Thang <= 12 and Nam >=0)
--insert into THAMSO values (18,55,6,8,5,4,1000,1)
--insert into LOAIDOCGIA values ('X')
--insert into LOAIDOCGIA values ('Y')
--insert into THELOAI values ('A')
--insert into THELOAI values ('B')
--insert into THELOAI values ('C')
--select * from THELOAI
--SELECT *FROM loaidocgia
--select * from thamso
--go

----CRUD--
--CREATE PROC INS_DOCGIA
--@TENDOCGIA VARCHAR(MAX),@NGAYSINH DATETIME, @DIACHI VARCHAR(MAX), @EMAIL VARCHAR(MAX), @NGAYLAPTHE DATETIME, @NGAYHETHAN DATETIME, @MALOAIDOCGIA INT
--AS
--INSERT INTO DOCGIA VALUES(@TENDOCGIA,@NGAYSINH,@DIACHI,@EMAIL,@NGAYLAPTHE,@NGAYHETHAN,@MALOAIDOCGIA,0)
--GO

--CREATE PROC INS_LOAIDOCGIA
--@TENLOAIDOCGIA VARCHAR(MAX)
--AS
--INSERT INTO LOAIDOCGIA VALUES (@TENLOAIDOCGIA)
--GO

--CREATE PROC INS_THELOAI
--@TENTHELOAI VARCHAR(MAX)
--AS 
--INSERT INTO THELOAI VALUES (@TENTHELOAI)
--GO

--CREATE PROC INS_PHIEUTHU
--@MADOCGIA INT, @SOTIENTHU INT, @NGAYLAP DATETIME
--AS
--INSERT INTO PHIEUTHU VALUES (@MADOCGIA, @SOTIENTHU, @NGAYLAP)
--GO 

--CREATE PROC INS_TUASACH
--@TENTUASACH VARCHAR(MAX), @MATHELOAI INT
--AS
--INSERT INTO TUASACH VALUES(@TENTUASACH,@MATHELOAI)
--GO

--CREATE PROC INS_SACH
--@MATUASACH INT, @SOLUONG INT, @SOLUONGCONLAI INT, @DONGIA INT, @NAMXB INT, @NHAXB VARCHAR(MAX)
--AS
--INSERT INTO SACH VALUES(@MATUASACH, @SOLUONG, @SOLUONGCONLAI,@DONGIA,@NAMXB,@NHAXB)
--GO

--CREATE PROC INS_PHIEUNHAP
--@TONGTIEN INT, @NGAYNHAP DATETIME
--AS
--INSERT INTO PHIEUNHAP VALUES(@TONGTIEN,@NGAYNHAP)
--GO 

--CREATE PROC INS_CTPHIEUNHAP
--@SOPHIEUNHAP INT, @MASACH INT, @DONGIA INT, @THANHTIEN INT, @SOLUONGNHAP INT
--AS 
--INSERT INTO CT_PHIEUNHAP VALUES(@SOPHIEUNHAP,@MASACH,@DONGIA,@THANHTIEN,@SOLUONGNHAP)
--GO

--CREATE PROC INS_PHIEUTHU
--@MADOCGIA INT, @SOTIENTHU INT, @MGAYLAP DATETIME
--AS
--INSERT INTO PHIEUTHU VALUES(@MADOCGIA,@SOTIENTHU,@NGAYLAP)
--GO 

--CREATE PROC INS_PHIEUMUONTRA
--@MADOCGIA INT, @MACUONSACH INT, @NGAYMUON DATETIME, @NGAYTRA DATETIME, @HANTRA DATETIME, @SOTIENPHAT INT
--AS
--INSERT INTO PHIEUMUONTRA VALUES(@MADOCGIA,@MACUONSACH,@NGAYMUON,@NGAYTRA,@HANTRA,@SOTIENPHAT)
--GO 

--CREATE PROC INS_TACGIA
--@TENTACGIA VARCHAR(MAX)
--AS 
--INSERT INTO TACGIA(@TENTACGIA)
--GO 

--CREATE PROC INS_CTTACGGIA
--@MATUASACH INT, @MATACGIA INT
--AS
--INSERT INTO CT_TACGIA VALUES (@MATUASACH,@MATACGIA)
--GO 

--CREATE PROC INS_CHUCNANG
--@TENCHUCNANG VARCHAR(MAX), @TENMANHINH VARCHAR(MAX)
--AS 
--INSERT INTO CHUCNANG VALUES (@TENCHUCNANG,@TENMANHINH)
--GO

--CREATE PROC INS_PHANQUYEN
--@MANHOMNGUOIDUNG INT, @MACHUCNANG INT
--AS
--INSERT INTO PHANQUYEN VALUES(@MANHOMNGUOIDUNG, @MACHUCNANG)
--GO 

--CREATE PROC INS_NGUOIDUNG
--@TENNGUOIDUNG VARCHAR(MAX), @NGAYSINH DATETIME, @CHUCVU VARCHAR(MAX),@TENDANGNHAP VARCHAR(MAX), @MATKHAU VARCHAR(MAX), @MANHOM INT
--AS
--INSERT INTO NGUOIDUNG VALUES(@TENNGUOIDUNG, @NGAYSINH, @CHUCVU, @TENDANGNHAP, @MATKHAU,@MANHOM)
--GO

--CREATE PROC INS_NHOMNGUOIDUNG
--@TENNHOMNGUOIDUNG VARCHAR(MAX)
--AS
--INSERT INTO NHOMNGUOIDUNG VALUES (@TENNHOMNGUOIDUNG)
--GO 

--CREATE PROC UPD_THAMSO
--@TUOITOITHIEU INT = NULL, @TUOITOIDA INT = NULL, @THOIHANTHE INT = NULL, @KHOANGCACHXUATBAN INT = NULL, @SOSACHMUONTOIDA INT = NULL, @SONGAYMUONTOIDA INT = NULL, @DONGIAPHAT INT = NULL, @AD_QDKTTIENTHU INT = NULL
--AS
--UPDATE THAMSO 
--SET TUOITOITHIEU=isnull(@TUOITOITHIEU,TUOITOITHIEU),
--TUOITOIDA=isnull(@TUOITOIDA,TUOITOIDA),
--THOIHANTHE=ISNULL(@THOIHANTHE,THOIHANTHE),
--KHOANGCACHXUATBAN=ISNULL(@KHOANGCACHXUATBAN,KHOANGCACHXUATBAN),
--SOSACHMUONTOIDA=ISNULL(@SOSACHMUONTOIDA,SOSACHMUONTOIDA),
--SONGAYMUONTOIDA=ISNULL(@SONGAYMUONTOIDA,SONGAYMUONTOIDA),
--DONGIAPHAT= ISNULL(DONGIAPHAT,@DONGIAPHAT), 
--AD_QDKTTIENTHU =ISNULL(AD_QDKTTIENTHU,@AD_QDKTTIENTHU )
--GO

---- TRIGGERS
--CREATE TRIGGER INS_SACH ON SACH
--FOR INSERT, UPDATE
--AS
--BEGIN
--	DECLARE @MASACH CHAR(6)
--	SELECT @MASACH = MASACH FROM inserted
	
--END
