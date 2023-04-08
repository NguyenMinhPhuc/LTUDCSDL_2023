--Buổi học 08-04-2023
--Thực hiện form nhập hàng
--Kiểm tra thủ tục
--PSP_PhieuNhap_TaoPhieuMoi
ALTER PROC [dbo].[PSP_PhieuNhap_TaoPhieuMoi]
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