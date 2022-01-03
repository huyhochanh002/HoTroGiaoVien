USE Data_QuanLyLopHoc;
GO
ALTER PROC PSP_ThongKe_SoLuongSinhVien
AS
    SELECT  COUNT(*) TongSV ,
            ( SELECT    COUNT(MaSinhVien)
              FROM      dbo.SinhVien
              WHERE     GioiTinh = 1
            ) Nam ,
            ( SELECT    COUNT(MaSinhVien)
              FROM      dbo.SinhVien
              WHERE     GioiTinh = 0
            ) AS Nu
    FROM    dbo.SinhVien;
    GO
ALTER PROC PSP_ThongKe_LaySoLuongTheoTungNam
AS
    SELECT  Nam ,
            COUNT(*) Tong ,
            ( SELECT    COUNT(MaSinhVien)
              FROM      dbo.SinhVien
                        JOIN dbo.Lop ON Lop.MaLop = SinhVien.MaLop
              WHERE     GioiTinh = 1
                        AND dbo.Lop.Nam = b.Nam
            ) Male ,
            ( SELECT    COUNT(MaSinhVien)
              FROM      dbo.SinhVien
                        JOIN dbo.Lop ON Lop.MaLop = SinhVien.MaLop
              WHERE     GioiTinh = 0
                        AND dbo.Lop.Nam = b.Nam
            ) AS Female ,
            ( SELECT    COUNT(MaSinhVien)
              FROM      dbo.SinhVien
                        JOIN dbo.Lop ON Lop.MaLop = SinhVien.MaLop
              WHERE     TinhTrang = 1
                        AND dbo.Lop.Nam = b.Nam
            ) AS DangHoc ,
            ( SELECT    COUNT(MaSinhVien)
              FROM      dbo.SinhVien
                        JOIN dbo.Lop ON Lop.MaLop = SinhVien.MaLop
              WHERE     TinhTrang = 3
                        AND dbo.Lop.Nam = b.Nam
            ) AS Nghi ,
            ( SELECT    COUNT(MaSinhVien)
              FROM      dbo.SinhVien
                        JOIN dbo.Lop ON Lop.MaLop = SinhVien.MaLop
              WHERE     TinhTrang = 2
                        AND dbo.Lop.Nam = b.Nam
            ) AS BaoLuu
    FROM    dbo.SinhVien
            JOIN dbo.Lop b ON b.MaLop = SinhVien.MaLop
                              AND b.IsDelete = 0
    GROUP BY Nam;
    GO
ALTER PROC PSP_ThongKe_DanhSachCanBoLop @IsCanBo BIT = 0
AS
    IF ( @IsCanBo = 0 )
        BEGIN
            SELECT  ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                                 ) ) AS STT ,
                    MaSinhVien ,
                    HoSinhVien ,
                    TenSinhVien ,
                    DienThoai ,
                    Email ,
                    MaLop ,
                    CASE GioiTinh
                      WHEN 1 THEN N'Nam'
                      ELSE N'Nữ'
                    END AS GioiTinh ,
                    b.TenChucVu
            FROM    dbo.SinhVien a
                    JOIN dbo.ChucVu b ON b.MaChucVu = a.MaChucVu
                                         AND b.IsDelete = 0
            WHERE   TinhTrang = 1
                    AND a.MaChucVu = 7;
        END;
    ELSE
        BEGIN
            SELECT  ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                                 ) ) AS STT ,
                    MaSinhVien ,
                    HoSinhVien ,
                    TenSinhVien ,
                    DienThoai ,
                    Email ,
                    MaLop ,
                    CASE GioiTinh
                      WHEN 1 THEN N'Nam'
                      ELSE N'Nữ'
                    END AS GioiTinh ,
                    b.TenChucVu
            FROM    dbo.SinhVien a
                    JOIN dbo.ChucVu b ON b.MaChucVu = a.MaChucVu
                                         AND b.IsDelete = 0
            WHERE   TinhTrang = 1
                    AND a.MaChucVu <> 7;
           
        END;
    GO
EXEC PSP_ThongKe_DanhSachCanBoLop 1;
    GO
ALTER PROC PSP_Lop_LayDanhSachChoCombo --'NV0000309'
    @MaGiaoVien VARCHAR(9) = '0'
AS
    IF @MaGiaoVien = '0'
        BEGIN
            SELECT  MaLop ,
                    TenLop
            FROM    dbo.Lop
            WHERE   IsDelete = 0;
        END;
    ELSE --Lấy theo mã giáo viên
        BEGIN
            SELECT  a.MaLop ,
                    TenLop
            FROM    dbo.Lop a
            WHERE   a.MaGiaoVien = @MaGiaoVien
                    AND IsDelete = 0;
        END;
    
    
    GO
ALTER PROC PSP_Lop_LayDanhSachLop
AS
    SELECT  ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                         ) ) AS STT ,
            MaLop ,
            TenLop ,
            MaGiaoVien ,
            SiSo
    FROM    dbo.Lop
    WHERE   IsDelete = 0;
    
    GO
CREATE PROC PSP_GiaoVien_HienThiDanhSachGiaoVienCbo
AS
    SELECT  MaGiaoVien ,
            HoGiaoVien + ' ' + TenGiaoVien AS HoTenGiaoVien
    FROM    dbo.GiaoVien
    WHERE   IsDelete = 0
    ORDER BY TenGiaoVien;
    
GO

ALTER PROC PSP_SinhVien_LayDanhSachTheo__GiaoVienChuNhiem-- 'NV0000309'
    @MaGiaoVien VARCHAR(9) = '0'
AS
    IF ( @MaGiaoVien = '0' )
        BEGIN
    --Lay tat ca cac lop
            SELECT  ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                                 ) ) AS STT ,
                    MaSinhVien ,
                    HoSinhVien ,
                    TenSinhVien ,
                    NgaySinh ,
                    DiaChi ,
                    Tinh ,
                    QuanHuyen ,
                    PhuongXa ,
                    DienThoai ,
                    Email ,
                    Facebook ,
                    HinhDaiDien ,
                    a.MaLop ,
                    TinhTrang ,
                    MaChucVu ,
                    GioiTinh ,
                    DTBHocTap ,
                    DanToc ,
                    TonGiao ,
                    QueQuan ,
                    QuocTich ,
                    NoiSinh
            FROM    SinhVien a
                    JOIN Lop b ON b.MaLop = a.MaLop;
        END;
    ELSE
        BEGIN
     --Lay theo ma giao vien
            SELECT  ROW_NUMBER() OVER ( ORDER BY ( SELECT   1
                                                 ) ) AS STT ,
                    MaSinhVien ,
                    HoSinhVien ,
                    TenSinhVien ,
                    NgaySinh ,
                    DiaChi ,
                    Tinh ,
                    QuanHuyen ,
                    PhuongXa ,
                    DienThoai ,
                    Email ,
                    Facebook ,
                    HinhDaiDien ,
                    a.MaLop ,
                    TinhTrang ,
                    MaChucVu ,
                    GioiTinh ,
                    DTBHocTap ,
                    DanToc ,
                    TonGiao ,
                    QueQuan ,
                    QuocTich ,
                    NoiSinh
            FROM    SinhVien a
                    JOIN Lop b ON b.MaLop = a.MaLop
            WHERE   b.MaGiaoVien = @MaGiaoVien;
        END;
