ALTER FUNCTION Pfc_SinhMaTuDong
(
    @MaxID VARCHAR(20), --PN0000001
    @Start INT,
    @Lenght INT,
    @Asign VARCHAR(20),
    @Format VARCHAR(20)
)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @number INT;
    DECLARE @Result VARCHAR(20);
    SET @number = CONVERT(INT, SUBSTRING(@MaxID, @Start, @Lenght)) + 1;

    SET @Result = @Asign + FORMAT(@number, @Format);
    RETURN @Result;
END;
GO
SELECT dbo.Pfc_SinhMaTuDong('PN0000001', 3, 9, 'PN', '0000000');

GO
--thu kiem tra phieu theo User
CREATE PROC PSP_PhieuNhap_KiemTraPhieuTonTaiTheoUser @MaNhanVien CHAR(9)
AS
IF EXISTS
(
    SELECT 1
    FROM dbo.PhieuNhap
    WHERE MaNhanVien = @MaNhanVien
          AND StatusPhieuNhap = 0
)
BEGIN
    SELECT DISTINCT
           MaPhieuNhap
    FROM dbo.PhieuNhap
    WHERE MaNhanVien = @MaNhanVien
          AND StatusPhieuNhap = 0;
END;
ELSE
BEGIN
    SELECT 'no';
END;
GO
EXEC PSP_PhieuNhap_KiemTraPhieuTonTaiTheoUser 'NV0000001';

GO
CREATE PROC PSP_PhieuNhap_LoadDataPhieuNhapCu @MaPhieuNhap CHAR(9)
AS
SELECT a.MaPhieuNhap,
       NgayNhap,
       MaNhanVien,
       b.MaSP,
       c.TenSP,
       c.MaDVT,
       d.TenDVT,
       b.SoLuongNhap,
       b.DonGiaNhap,
       b.SoLuongNhap * b.DonGiaNhap AS ThanhTien
FROM dbo.PhieuNhap a
    JOIN dbo.ChiTietPhieuNhap b
        ON b.MaPhieuNhap = a.MaPhieuNhap
    JOIN dbo.SanPham c
        ON c.MaSP = b.MaSP
    JOIN dbo.DonViTinh d
        ON d.MaDVT = c.MaDVT
WHERE a.MaPhieuNhap = @MaPhieuNhap;

GO
EXEC PSP_PhieuNhap_LoadDataPhieuNhapCu '230300001';

GO
ALTER PROC PSP_PhieuNhap_TaoPhieuMoi
AS
BEGIN

    DECLARE @Asign VARCHAR(20);
    SET @Asign = SUBSTRING(CONVERT(VARCHAR(4), YEAR(GETDATE())), 3, 2) + FORMAT(MONTH(GETDATE()), '00');

    DECLARE @maxID VARCHAR(20);
    SET @maxID =
    (
        SELECT ISNULL(MAX(MaPhieuNhap), @Asign + '00000')
        FROM dbo.PhieuNhap
        WHERE YEAR(NgayNhap) = YEAR(GETDATE())
              AND MONTH(NgayNhap) = MONTH(GETDATE())
    );
    SELECT dbo.Pfc_SinhMaTuDong(@maxID, 5, 9, @Asign, '00000') AS MaPhieuMoi;
END;
GO
EXEC PSP_PhieuNhap_TaoPhieuMoi;

GO
CREATE PROC PSP_PhieuNhap_Insert202303
    @MaPhieuNhap CHAR(9),
    @NgayNhap DATETIME,
    @MaNhanVien CHAR(9)
AS
BEGIN
    INSERT INTO PhieuNhap
    (
        [MaPhieuNhap],
        [NgayNhap],
        [MaNhanVien],
        [StatusPhieuNhap]
    )
    VALUES
    (@MaPhieuNhap, @NgayNhap, @MaNhanVien, 0);
END;