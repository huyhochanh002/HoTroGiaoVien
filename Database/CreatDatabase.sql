--DROP DATABASE Data_QuanLyLopHoc
--go
--CREATE DATABASE Data_QuanLyLopHoc
--GO

USE Data_QuanLyLopHoc;
GO
--Phan system
CREATE TABLE NhomNguoiDung
    (
      MaNhom INT IDENTITY(1, 1)
                 NOT NULL
                 PRIMARY KEY ,
      TenNhom NVARCHAR(100) ,
      MoTa NVARCHAR(100) ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 )
    );
    GO
INSERT  INTO NhomNguoiDung
        ( TenNhom, MoTa )
VALUES  ( N'Admin', N'Quyền quản trị' );
INSERT  INTO NhomNguoiDung
        ( TenNhom ,
          MoTa
        )
VALUES  ( N'Quản sinh' ,
          N'Quyền Quản sinh'
        );
INSERT  INTO NhomNguoiDung
        ( TenNhom ,
          MoTa
        )
VALUES  ( N'Giáo viên' ,
          N'Quyền giáo viên chủ nhiệm'
        );
    GO
    
CREATE TABLE TaiKhoan
    (
      MaNguoiDung INT IDENTITY(1, 1)
                      NOT NULL
                      PRIMARY KEY ,
      TenDangNhap VARCHAR(50) NOT NULL ,
      MatKhau VARBINARY(MAX) NOT NULL ,
      MaNhom INT NOT NULL ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 ) ,
      CONSTRAINT fk_Nhom_TaiKhoan FOREIGN KEY ( MaNhom ) REFERENCES dbo.NhomNguoiDung ( MaNhom )
    );
GO 
CREATE TABLE ChucNang
    (
      MaChucNang INT IDENTITY(1, 1)
                     NOT NULL
                     PRIMARY KEY ,
      TenChucNang NVARCHAR(100) NOT NULL ,
      TenForm VARCHAR(100) NOT NULL ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 )
    );
GO 
CREATE TABLE PhanQuyen
    (
      MaNguoiDung INT NOT NULL ,
      MaChucNang INT NOT NULL ,
      TongQuyen INT NOT NULL
                    DEFAULT ( 0 ) ,
      CONSTRAINT pk_PhanQuyen PRIMARY KEY ( MaNguoiDung, MaChucNang )
    );
GO 
CREATE TABLE Lop
    (
      MaLop INT IDENTITY(1, 1)
                PRIMARY KEY
                NOT NULL ,
      TenLop NVARCHAR(20) NOT NULL ,
      MoTa NVARCHAR(200) NULL ,
      MaGiaoVien INT ,--Cột này sẽ được cập tự động khi thay đổi phân GV chủ nhiêm cho lớp.
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 )--mac dinh la chua xoa
    );
GO
CREATE TABLE Khoa
    (
      MaKhoa INT IDENTITY(1, 1)
                 PRIMARY KEY
                 NOT NULL ,
      TenKhoa NVARCHAR(100) ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 )
    );
GO 
CREATE TABLE GiaoVien
    (
      MaGiaoVien VARCHAR(9) PRIMARY KEY
                            NOT NULL ,
      HoGiaoVien NVARCHAR(50) NOT NULL ,
      TenGiaoVien NVARCHAR(20) NOT NULL ,
      DienThoai VARCHAR(20) ,
      Email VARCHAR(50) ,
      Facebook VARCHAR(100) ,
      Zalo VARCHAR(100) ,
      DiaChi NVARCHAR(100) ,
      MaKhoa INT ,
      IsDelete BIT
        NOT NULL
        DEFAULT ( 0 )
        CONSTRAINT fk_giaoVien_Khoa
        FOREIGN KEY ( MaKhoa ) REFERENCES dbo.Khoa ( MaKhoa )
    );
GO
CREATE TABLE GiaoVienChuNhiem
    (
      MaGiaoVien VARCHAR(9) NOT NULL ,
      MaLop INT NOT NULL ,
      Lan INT NOT NULL
              DEFAULT ( 1 ) ,-- cần tăng lần tự động
      HocKy INT ,
      NamHoc VARCHAR(9) ,
      TinhTrang BIT
        DEFAULT ( 1 )--1 la dang chu nhiem, 0 d chuyen
        CONSTRAINT pk_GiaoVienChuNhiem PRIMARY KEY ( MaGiaoVien, MaLop, Lan )
    );
GO
CREATE TABLE Tinh
    (
      MaTinh INT NOT NULL
                 PRIMARY KEY
                  ,
      TenTinh NVARCHAR(200)
    );
    GO 
CREATE TABLE QuanHuyen
    (
      MaQuanHuyen INT NOT NULL
                      PRIMARY KEY
                      ,
      TenQuanHuyen NVARCHAR(200) ,
      MaTinh INT NOT NULL ,
      CONSTRAINT pk_QuanHuyen_Tinh FOREIGN KEY ( MaTinh ) REFERENCES Tinh ( MaTinh )
    );
    GO 
CREATE TABLE PhuongXa
    (
      MaPhuongXa INT NOT NULL
                     PRIMARY KEY
                     ,
      TenPhuongXa NVARCHAR(200) ,
      MaQuanHuyen INT
        NOT	NULL
        CONSTRAINT pk_PhongXa_QuanHuyen
        FOREIGN KEY ( MaQuanHuyen ) REFERENCES QuanHuyen ( MaQuanHuyen )
    );
    GO 
CREATE TABLE ChucVu
    (
      MaChucVu INT IDENTITY
                   PRIMARY KEY
                   NOT NULL ,
      TenChucVu NVARCHAR(100) ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 )
    );
    GO 
CREATE TABLE SinhVien
    (
      MaSinhVien VARCHAR(9) NOT NULL
                            PRIMARY KEY ,
      HoSinhVien NVARCHAR(50) NOT NULL ,
      TenSinhVien NVARCHAR(20) ,
      NgaySinh DATE ,
      DiaChi NVARCHAR(100) ,
      Tinh INT NOT NULL ,
      QuanHuyen INT NOT NULL ,
      PhuongXa INT NOT NULL ,
      DienThoai VARCHAR(20) ,
      Email VARCHAR(100) ,
      Facebook VARCHAR(100) ,
      HinhDaiDien VARCHAR(500) ,
      MaLop INT NOT NULL ,
      TinhTrang INT NOT NULL
                    DEFAULT ( 1 ) ,--1: đang học; 2: bảo lưu; 3 Nghỉ luôn
      MaChucVu INT NOT NULL ,
      CONSTRAINT pk_SinhVien_Lop FOREIGN KEY ( MaLop ) REFERENCES Lop ( MaLop ) ,
      CONSTRAINT pk_SinhVien_MaChucVu FOREIGN KEY ( MaChucVu ) REFERENCES ChucVu ( MaChucVu ) ,
      CONSTRAINT pk_SinhVien_Tinh FOREIGN KEY ( Tinh ) REFERENCES Tinh ( MaTinh ) ,
      CONSTRAINT pk_SinhVien_QuanHuyen FOREIGN KEY ( QuanHuyen ) REFERENCES QuanHuyen ( MaQuanHuyen ) ,
      CONSTRAINT pk_SinhVien_PhuongXa FOREIGN KEY ( PhuongXa ) REFERENCES PhuongXa ( MaPhuongXa )
    );
    GO
CREATE TABLE NgoaiTru
    (
      MaNgoaiTru INT IDENTITY(1, 1)
                     NOT NULL ,
      MaSinhVien VARCHAR(9) NOT NULL ,
      PhanLoai INT DEFAULT ( 1 )
                   NOT NULL ,--1 NoiTru; 2 NgoaiTru; 3 O cung GD
      NoiCuTru NVARCHAR(200) ,--KTX, Với gia Đình, Tên chủ nhà trọ
      DiaChiCuTru NVARCHAR(100) ,--Số nhà, Khu phố
      Tinh INT NOT NULL ,
      QuanHuyen INT NOT NULL ,
      PhuongXa INT NOT NULL ,
      CONSTRAINT fk_NgoaiTru_SinhVien FOREIGN KEY ( MaSinhVien ) REFERENCES SinhVien ( MaSinhVien ) ,
      CONSTRAINT pk_NgoaiTru PRIMARY KEY ( MaNgoaiTru, MaSinhVien ) ,
      CONSTRAINT pk_NgoaiTru_Tinh FOREIGN KEY ( Tinh ) REFERENCES Tinh ( MaTinh ) ,
      CONSTRAINT pk_NgoaiTru_QuanHuyen FOREIGN KEY ( QuanHuyen ) REFERENCES QuanHuyen ( MaQuanHuyen ) ,
      CONSTRAINT pk_NgoaiTru_PhuongXa FOREIGN KEY ( PhuongXa ) REFERENCES PhuongXa ( MaPhuongXa )
    );
 GO 
CREATE TABLE LoaiXuLyHocVu
    (
      MaLoaiXuLy INT IDENTITY(1, 1)
                     NOT NULL
                     PRIMARY KEY ,
      TenLoaiXuLy NVARCHAR(200) NOT NULL ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 )
    );
    GO
    
INSERT  INTO LoaiXuLyHocVu
        ( TenLoaiXuLy )
VALUES  ( N'Nợ học phí' );
INSERT  INTO LoaiXuLyHocVu
        ( TenLoaiXuLy )
VALUES  ( N'Nợ Trên ba môn' );
INSERT  INTO LoaiXuLyHocVu
        ( TenLoaiXuLy )
VALUES  ( N'Nợ tất cả các môn' );
 GO
CREATE TABLE HocKy
    (
      MaHocKy INT IDENTITY(1, 1)
                  NOT NULL
                  PRIMARY KEY ,
      TenHocKy NVARCHAR(100) NOT NULL ,
      IsDelete BIT DEFAULT ( 0 )
                   NOT NULL
    ); 
 GO
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 1' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 2' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 3' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 4' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 5' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 6' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 7' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 8' );
INSERT  INTO HocKy
        ( TenHocKy )
VALUES  ( N'Học kỳ 9' );
 GO
 
CREATE TABLE XuLyHocVu
    (
      MaSinhVien VARCHAR(9) NOT NULL ,
      MaHocKy INT NOT NULL
                  DEFAULT ( 1 ) ,--Hoc ky 1-9
      NgayLamViec DATE NOT NULL
                       DEFAULT ( GETDATE() ) ,
      NoiDungLamViec NVARCHAR(500) ,
      KetLuan NVARCHAR(100) ,--ket luan xu ly cap nhat tinh trang
      MaLoaiXuLy INT NOT NULL ,
      CONSTRAINT pk_XuLyHocVu PRIMARY KEY ( MaSinhVien, MaHocKy ) ,
      CONSTRAINT fk_XuLyHocVu_LoaiXuLyHocVu FOREIGN KEY ( MaLoaiXuLy ) REFERENCES LoaiXuLyHocVu ( MaLoaiXuLy ) ,
      CONSTRAINT fk_XuLyHocVu_SinhVien FOREIGN KEY ( MaSinhVien ) REFERENCES SinhVien ( MaSinhVien ) ,
      CONSTRAINT fk_XuLyHocVu_HocKy FOREIGN KEY ( MaHocKy ) REFERENCES HocKy ( MaHocKy )
    );
 GO
CREATE TABLE GhiChu
    (
      MaSinhVien VARCHAR(9) NOT NULL ,
      MaGhiChu INT NOT NULL ,--Tang theo MaSV
      NoiDung NVARCHAR(MAX) ,
      NgayTao DATE ,
      MaGiaoVien VARCHAR(9) NOT NULL ,
      CONSTRAINT pk_GhiChu PRIMARY KEY ( MaSinhVien, MaGhiChu ) ,
      CONSTRAINT fk_GhiChu_SinhVien FOREIGN KEY ( MaSinhVien ) REFERENCES SinhVien ( MaSinhVien ) ,
      CONSTRAINT fk_GhiChu_GiaoVien FOREIGN KEY ( MaGiaoVien ) REFERENCES GiaoVien ( MaGiaoVien )
    );
 GO
CREATE TABLE QuanHe
    (
      MaQuanHe INT IDENTITY(1, 1)
                   NOT NULL
                   PRIMARY KEY ,
      TenQuanHe NVARCHAR(100) NOT NULL ,
      IsDelete BIT NOT NULL
                   DEFAULT ( 0 )
    );
 GO
INSERT  INTO QuanHe
        ( TenQuanHe )
VALUES  ( N'Ba' );
INSERT  INTO QuanHe
        ( TenQuanHe )
VALUES  ( N'Mẹ' );
INSERT  INTO QuanHe
        ( TenQuanHe )
VALUES  ( N'Anh' );
INSERT  INTO QuanHe
        ( TenQuanHe )
VALUES  ( N'Chị' );
INSERT  INTO QuanHe
        ( TenQuanHe )
VALUES  ( N'Em' );
 GO
 
CREATE TABLE GiaDinh
    (
      MaSinhVien VARCHAR(9) NOT NULL ,
      MaQuanHe INT NOT NULL ,
      DienThoai VARCHAR(20) ,
      Zalo VARCHAR(50) ,
      Facebook VARCHAR(50) ,
      CONSTRAINT pk_GiaDinh PRIMARY KEY ( MaSinhVien, MaQuanHe ) ,
      CONSTRAINT fk_GiaDinh_SinhVien FOREIGN KEY ( MaSinhVien ) REFERENCES SinhVien ( MaSinhVien ) ,
      CONSTRAINT fk_GiaDinh_QuanHe FOREIGN KEY ( MaQuanHe ) REFERENCES QuanHe ( MaQuanHe )
    );
 GO
CREATE TABLE KetQua
    (
      MaSinhVien VARCHAR(9) NOT NULL ,
      MaHocKy INT NOT NULL , --1->9
      DiemTB FLOAT DEFAULT ( 0 )
                   NOT NULL ,
      XepLoaiRenLuyen NVARCHAR(30) ,
      CONSTRAINT pk_KetQua PRIMARY KEY ( MaSinhVien, MaHocKy ) ,
      CONSTRAINT fk_XuLyHocVu_SinhVien FOREIGN KEY ( MaSinhVien ) REFERENCES SinhVien ( MaSinhVien ) ,
      CONSTRAINT fk_KetQua_HocKy FOREIGN KEY ( MaHocKy ) REFERENCES HocKy ( MaHocKy )
    );
    GO
    CREATE TABLE SoThich
        (
          MaSinhVien VARCHAR(9) NOT NULL ,
          SoLuong INT IDENTITY(1,1) NOT NULL ,
          NoiDung NVARCHAR(100) ,
          IsDelete BIT NOT NULL
                       DEFAULT ( 0 ),
                       CONSTRAINT pk_SoThich PRIMARY KEY(MaSinhVien,SoLuong),
                       CONSTRAINT fk_SoThich_SinhVien FOREIGN KEY(MaSinhVien) REFERENCES dbo.SinhVien(MaSinhVien)
                       
        ); 
        GO
    