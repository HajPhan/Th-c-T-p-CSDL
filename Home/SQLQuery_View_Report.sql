USE QLBANHANG
GO


-- View Danh Sach NHANVIEN
CREATE VIEW vw_DanhSachNhanVien
AS
	SELECT *FROM dbo.NHANVIEN
GO
--SELECT *FROM  dbo.vw_DanhSachNhanVien

-- View Danh Sach KHACHHANG
CREATE VIEW vw_DanhSachKhachHang
AS
	SELECT *FROM dbo.KHACHHANG
GO
--SELECT *FROM dbo.vw_DanhSachKhachHang


-- View Danh Sach NHACC
CREATE VIEW vw_DanhSachNhaCungCap
AS
	SELECT *FROM dbo.NHACC
GO
--SELECT *FROM dbo.vw_DanhSachNhaCungCap


-- View Danh Sach NHASX
CREATE VIEW vw_DanhSachNhaSanXuat
AS
	SELECT *FROM dbo.NHASX
GO
--SELECT *FROM dbo.vw_DanhSachNhaSanXuat


-- View Danh Sach LOAISP
CREATE VIEW vw_DanhSachLoaiSanPham
AS
	SELECT *FROM dbo.LOAISP
GO
--SELECT *FROM dbo.vw_DanhSachLoaiSanPham


-- View Danh Sach SANPHAM
CREATE VIEW vw_DanhSachSanPham
AS
		SELECT sp.TENSP, sp.MASX, nsx.TENSX, sp.MALOAI, lsp.TENLOAI, sp.GIATHANH, ct.* FROM dbo.SANPHAM AS sp
			JOIN dbo.CTSP AS ct
			ON ct.MASP = sp.MASP
			JOIN dbo.NHASX AS nsx
			ON nsx.MASX = sp.MASX
			JOIN  dbo.LOAISP AS lsp
			ON lsp.MALOAI = sp.MALOAI
GO

--SELECT *FROM dbo.vw_DanhSachSanPham

-- View Danh Sach DONDH
CREATE VIEW vw_DanhSachDonDatHang
AS
	SELECT dh.*, nv.HOTEN, ncc.TENCC, ctdh.MASP, sp.TENSP, ctdh.SLDH FROM dbo.DONDH AS dh
		JOIN dbo.CTDH AS ctdh
		ON ctdh.MADH = dh.MADH
		JOIN dbo.NHANVIEN AS nv
		ON nv.MANV = dh.MANV
		JOIN dbo.SANPHAM AS sp
		ON sp.MASP = ctdh.MASP
		JOIN  dbo.NHACC AS ncc
	    ON ncc.MACC = dh.MACC
GO

--SELECT *FROM dbo.vw_DanhSachDonDatHang


-- View Danh Sach PHIEUNHAP
CREATE VIEW vw_DanhSachPhieuNhap
AS
	SELECT pn.*, nv.HOTEN, ctpn.MASP, sp.TENSP, ctpn.SLN, ctpn.DONGIA FROM dbo.PHIEUNHAP AS pn
		JOIN  dbo.CTPN AS ctpn
		ON ctpn.MAPN = pn.MAPN
		JOIN dbo.NHANVIEN AS nv
		ON nv.MANV = pn.MANV
		JOIN dbo.SANPHAM AS sp
		ON sp.MASP = ctpn.MASP
GO

--SELECT *FROM dbo.vw_DanhSachPhieuNhap



-- View Danh PHIEUXUAT
ALTER VIEW vw_DanhSachPhieuXuat
AS
	SELECT px.*, nv.HOTEN, kh.TENKH, ctpx.MASP, sp.TENSP, ctpx.SLX, ctpx.PHANTRAM, ctpx.THANHTIEN, kh.DIACHI, sp.GIATHANH FROM dbo.PHIEUXUAT AS px
		JOIN  dbo.CTPX AS ctpx
		ON ctpx.MAPX = px.MAPX
		JOIN  dbo.NHANVIEN AS nv
		ON nv.MANV = px.MANV
		JOIN  dbo.KHACHHANG AS kh
		ON kh.MAKH = px.MAKH
		JOIN dbo.SANPHAM AS sp
		ON sp.MASP = ctpx.MASP
GO

--SELECT *FROM dbo.vw_DanhSachPhieuXuat

