CREATE FUNCTION Fn_TinhTongSoPhieuNhapTheoLoaiSp(@LoaiSp NVARCHAR(100))
RETURNS INT 
BEGIN
	DECLARE @kq INT 
    SELECT @kq = SUM(ctpn.SLN) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI AND lsp.TENLOAI =  @LoaiSp
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX

	RETURN ISNULL(@kq,0);
END
GO

DECLARE @tong INT
SET @tong = dbo.Fn_TinhTongSoPhieuNhapTheoLoaiSp(N'PC')
PRINT @tong

-- Tinh Tong So Luong Con Nhap Cho Phieu Nhap Theo Nha Cung Cap
CREATE FUNCTION Fn_TinhTongSoPhieuConNhapTheoLoaiSp(@LoaiSp NVARCHAR(100))
RETURNS INT
BEGIN
	DECLARE @kq INT
    SELECT @kq = SUM(ctdh.SLDH-ctpn.SLN) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI AND lsp.TENLOAI = @LoaiSp
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX

	RETURN ISNULL(@kq,0)
END
GO

SELECT dbo.Fn_TinhTongSoPhieuConNhapTheoLoaiSp(N'LAPTOP')

-- Tinh Tong Tong Thanh Tien Phieu Nhap Theo Loai San Pham
ALTER FUNCTION Fn_TinhTongThanhTienPhieuNhapTheoLoaiSp(@LoaiSp NVARCHAR(100))
RETURNS MONEY
BEGIN
	DECLARE @kq MONEY 
    SELECT @kq = SUM(dbo.Fn_ThanhTienNhap(dh.MADH)) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN 
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI AND lsp.TENLOAI = @LoaiSp
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	RETURN ISNULL(@kq,0)
END
GO

--SELECT dbo.Fn_TinhTongThanhTienPhieuNhapTheoLoaiSp(N'PC')


-- Tinh Tong So Phieu Nhap Theo Nha Cung Cap
CREATE FUNCTION Fn_TinhTongSoPhieuNhapTheoNhaCungCap(@NhaCc NVARCHAR(100))
RETURNS INT 
BEGIN
	DECLARE @kq INT
    SELECT @kq = SUM(ctpn.SLN) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI 
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	JOIN dbo.NHACC ncc
	ON ncc.MACC = dh.MACC AND ncc.TENCC = @NhaCc
	RETURN ISNULL(@kq,0)
END
GO


-- Tinh Tong So Luong Con Nhap Cho Phieu Nhap Theo Nha Cung Cap
CREATE FUNCTION Fn_TinhTongSoPhieuConNhapTheoNhaCungCap(@NhaCc NVARCHAR(100))
RETURNS INT
BEGIN
	DECLARE @kq INT
    SELECT @kq = SUM(ctdh.SLDH-ctpn.SLN) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI 
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	JOIN dbo.NHACC ncc
	ON ncc.MACC = dh.MACC AND ncc.TENCC = @NhaCc
	RETURN ISNULL(@kq,0)
END
GO

-- Tinh Tong Tong Thanh Tien Phieu Nhap Theo Nha Cung Cap
CREATE FUNCTION Fn_TinhTongThanhTienPhieuNhapTheoNhaCc(@NhaCc NVARCHAR(100))
RETURNS MONEY
BEGIN
	DECLARE @kq MONEY
    SELECT @kq = SUM(dbo.Fn_ThanhTienNhap(dh.MADH)) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN 
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	JOIN dbo.NHACC AS ncc
	ON ncc.MACC = dh.MACC AND ncc.TENCC = @NhaCc
	RETURN ISNULL(@kq,0)
END
GO


-- Tinh Tong So Luong Con Nhap Cho Phieu Nhap Theo Ngay Nhap
CREATE FUNCTION Fn_TinhTongSoPhieuConNhapTheoNgayNhap(@DateTimesOne DATETIME,@DateTimesTwo DATETIME)
RETURNS INT
BEGIN
	DECLARE @kq INT
    SELECT @kq = SUM(ctdh.SLDH-ctpn.SLN) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN AND pn.NGAYNHAP BETWEEN @DateTimesOne AND @DateTimesTwo
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	RETURN ISNULL(@kq,0)
END
GO

-- Tinh Tong Thanh Tien Phieu Nhap Theo Ngay Nhap
CREATE FUNCTION Fn_TinhTongThanhTienPhieuNhapTheoNgayNhap(@DateTimesOne DATETIME,@DateTimesTwo DATETIME)
RETURNS MONEY
BEGIN
	DECLARE @kq MONEY
    SELECT @kq = SUM(dbo.Fn_ThanhTienNhap(dh.MADH)) FROM dbo.PHIEUNHAP AS pn
	JOIN dbo.CTPN AS ctpn
	ON ctpn.MAPN = pn.MAPN AND pn.NGAYNHAP BETWEEN @DateTimesOne AND @DateTimesTwo
	JOIN dbo.DONDH AS dh
	ON dh.MADH = pn.MADH
	JOIN dbo.CTDH AS ctdh
	ON ctdh.MADH = dh.MADH
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctdh.MASP AND sp.MASP = ctpn.MASP
	JOIN dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	RETURN ISNULL(@kq,0)
END
GO


ALTER FUNCTION Fn_TinhTongSlxPhieuXuatTheoNgayXuat(@DateTimesOne DATETIME,@DateTimesTwo DATETIME)
RETURNS INT
BEGIN
	DECLARE @kq INT
	SELECT @kq = SUM(ctpx.SLX) FROM dbo.PHIEUXUAT AS px
	JOIN dbo.CTPX AS ctpx
	ON ctpx.MAPX = px.MAPX AND px.NGAYXUAT BETWEEN @DateTimesOne AND @DateTimesTwo
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctpx.MASP
	JOIN  dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI
	JOIN  dbo.KHACHHANG AS kh
	ON kh.MAKH = px.MAKH
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	RETURN ISNULL(@kq,0)
END
GO

SELECT dbo.Fn_TinhTongSlxPhieuXuatTheoNgayXuat('20170607','20180608')


-- TInh Tong Thanh Tien Theo Ngay
CREATE FUNCTION Fn_TinhTongThanhTienPhieuXuatTheoNgayXuat(@DateTimesOne DATETIME,@DateTimesTwo DATETIME)
RETURNS MONEY
BEGIN
	DECLARE @kq MONEY
	SELECT @kq = SUM(ctpx.THANHTIEN) FROM dbo.PHIEUXUAT AS px
	JOIN dbo.CTPX AS ctpx
	ON ctpx.MAPX = px.MAPX AND px.NGAYXUAT BETWEEN @DateTimesOne AND @DateTimesTwo
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctpx.MASP
	JOIN  dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI
	JOIN  dbo.KHACHHANG AS kh
	ON kh.MAKH = px.MAKH
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	RETURN ISNULL(@kq,0)
END
GO

SELECT dbo.Fn_TinhTongThanhTienPhieuXuatTheoNgayXuat('20170605','20180605')


-- TInh Tong SLX Theo Loai San Pham
CREATE FUNCTION Fn_TinhTongSlxPhieuXuatTheoLoaiSp(@LoaiSp NVARCHAR(100))
RETURNS INT
BEGIN
    DECLARE @kq INT
	SELECT @kq = SUM(ctpx.SLX) FROM dbo.PHIEUXUAT AS px
	JOIN dbo.CTPX AS ctpx
	ON ctpx.MAPX = px.MAPX
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctpx.MASP
	JOIN  dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI AND lsp.TENLOAI = @LoaiSp
	JOIN  dbo.KHACHHANG AS kh
	ON kh.MAKH = px.MAKH
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	RETURN ISNULL(@kq,0)
END
GO



-- Tinh Tong Thang Tien Theo Loai San Pham
CREATE FUNCTION Fn_TinhTongThanhTienPhieuXuatTheoLoaiSp(@LoaiSp NVARCHAR(100))
RETURNS MONEY
BEGIN
    DECLARE @kq MONEY
	SELECT @kq = SUM(ctpx.THANHTIEN) FROM dbo.PHIEUXUAT AS px
	JOIN dbo.CTPX AS ctpx
	ON ctpx.MAPX = px.MAPX
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctpx.MASP
	JOIN  dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI AND lsp.TENLOAI = @LoaiSp
	JOIN  dbo.KHACHHANG AS kh
	ON kh.MAKH = px.MAKH
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX
	RETURN ISNULL(@kq,0)
END
GO


SELECT dbo.Fn_TinhTongThanhTienPhieuXuatTheoLoaiSp('PC')




-- Tinh Tong SLX Theo Nha San Xuat
CREATE FUNCTION Fn_TinhTongSlxPhieuXuatTheoNhaSanXuat(@NhaSx NVARCHAR(100))
RETURNS INT
BEGIN
    DECLARE @kq INT
	SELECT @kq = SUM(ctpx.SLX) FROM dbo.PHIEUXUAT AS px
	JOIN dbo.CTPX AS ctpx
	ON ctpx.MAPX = px.MAPX
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctpx.MASP
	JOIN  dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI
	JOIN  dbo.KHACHHANG AS kh
	ON kh.MAKH = px.MAKH
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX AND nsx.TENSX = @NhaSx
	RETURN ISNULL(@kq,0)
END
GO

SELECT dbo.Fn_TinhTongSlxPhieuXuatTheoNhaSanXuat('ACER')


-- Tinh Tong Thanh Tien Theo Nha San Xuat
CREATE FUNCTION Fn_TinhTongThanhTienPhieuXuatTheoNhaSx(@NhaSx NVARCHAR(100))
RETURNS MONEY
BEGIN
    DECLARE @kq MONEY
	SELECT @kq = SUM(ctpx.THANHTIEN) FROM dbo.PHIEUXUAT AS px
	JOIN dbo.CTPX AS ctpx
	ON ctpx.MAPX = px.MAPX
	JOIN dbo.SANPHAM AS sp
	ON sp.MASP = ctpx.MASP
	JOIN  dbo.LOAISP AS lsp
	ON lsp.MALOAI = sp.MALOAI
	JOIN  dbo.KHACHHANG AS kh
	ON kh.MAKH = px.MAKH
	JOIN  dbo.NHASX AS nsx
	ON nsx.MASX = sp.MASX AND nsx.TENSX = @NhaSx
	RETURN ISNULL(@kq,0)
END
GO

 SELECT *FROM dbo.TONKHO


