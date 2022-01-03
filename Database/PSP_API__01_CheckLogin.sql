ALTER PROC PSP_API__01_CheckLogin
    @TenDangNhap NVARCHAR(50) ,
    @MatKhau VARCHAR(50)
AS
    DECLARE @ErrType INT;
    DECLARE @Message NVARCHAR(50);
    DECLARE @NhomTaiKhoan INT;
    IF EXISTS ( SELECT  1
                FROM    dbo.TaiKhoan
                WHERE   TenDangNhap = @TenDangNhap )
        BEGIN
            IF EXISTS ( SELECT  1
                        FROM    dbo.TaiKhoan
                        WHERE   PwdCompare(@MatKhau, MatKhau) = 1 )
                BEGIN
        --dung pass va user
                    SET @ErrType = 1;
                    SET @Message = N'Đăng nhập thành công!!!';
                    SET @NhomTaiKhoan = ( SELECT    MaNhom
                                          FROM      dbo.TaiKhoan
                                          WHERE     TenDangNhap = @TenDangNhap
                                                    AND PwdCompare(@MatKhau,
                                                              MatKhau) = 1
                                        );
                END;
            ELSE
                BEGIN
                    SET @ErrType = 2;--sai mat khau- dung ten dang nhap
                    SET @Message = N'Đăng nhập Không thành công!!! sai mật khẩu';
                END;
        END;
    ELSE
        BEGIN
            SET @ErrType = 3;--Sai ten dang nhap
            SET @Message = N'Đăng nhập Không thành công!!! sai ten đăng nhập';
        END;
    IF ( @ErrType = 1 )
        BEGIN
            IF @NhomTaiKhoan <> 7--tai khoan giao vien
                BEGIN
                    SELECT  @ErrType AS code ,
                            @Message AS [Message] ,
                            *
                    FROM    dbo.GiaoVien a
                            JOIN dbo.TaiKhoan b ON b.MaNguoiDung = a.MaNguoiDung
                    WHERE   TenDangNhap = @TenDangNhap
                            AND PwdCompare(@MatKhau, MatKhau) = 1;
                END; 
            ELSE
                BEGIN
                    SELECT  @ErrType AS code ,
                            @Message AS [Message] ,
                            *
                    FROM    dbo.SinhVien a
                            JOIN dbo.TaiKhoan b ON b.MaNguoiDung = a.MaNguoiDung
                    WHERE   TenDangNhap = @TenDangNhap
                            AND PwdCompare(@MatKhau, MatKhau) = 1;	    
                END;
        END;
    ELSE
        BEGIN
            SELECT  @ErrType AS code ,
                    @Message AS [Message];
        END;
        GO
EXEC PSP_API__01_CheckLogin '110002287', '110002287';