using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class ThongKeBLL
    {
        ThongKeAccess thongKeAccess = new ThongKeAccess();
        public List<ThongKe> ThongKeDonDatHangTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKeDonDatHangTheoNgayThang(tk);
        }

        public List<ThongKe> ThongKeDonDatHang()
        {
            return thongKeAccess.ThongKeDonDatHang();
        }

        public DataTable TongSldh()
        {
            return thongKeAccess.TongSldh();
        }

        public DataTable TonSldhTheoMaSp(ThongKe tk)
        {
            return thongKeAccess.TonSldhTheoMaSp(tk);
        }

        public List<ThongKe> ThongKeTonKho()
        {
            return thongKeAccess.ThongKeTonKho();
        }

        public List<ThongKe> ThongKeTonKhoTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKeTonKhoTheoNgayThang(tk);
        }

        public List<ThongKe> HienThiTenLoaiSanPham()
        {
            return thongKeAccess.HienThiTenLoaiSanPham();
        }

        public List<ThongKe> HienThiTenNhaSanXuat()
        {
            return thongKeAccess.HienThiTenNhaSanXuat();
        }

        public List<ThongKe> ThongKeDonDatHangTheoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.ThongKeDonDatHangTheoLoaiSp(tk);
        }

        public List<ThongKe> ThongKeDonDatHangTheoNhaSx(ThongKe tk)
        {
            return thongKeAccess.ThongKeDonDatHangTheoNhaSx(tk);
        }

        public List<ThongKe> ThongKePhieuNhap()
        {
            return thongKeAccess.ThongKePhieuNhap();
        }

        public List<ThongKe> ThongKePhieuNhapTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuNhapTheoNgayThang(tk);
        }

        public List<ThongKe> ThongKePhieuXuat()
        {
            return thongKeAccess.ThongKePhieuXuat();
        }

        public List<ThongKe> ThongKePhieuXuatTheoNgayThang(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuXuatTheoNgayThang(tk);
        }

        public List<ThongKe> HienThiTenNhaCungCap()
        {
            return thongKeAccess.HienThiTenNhaCungCap();
        }

        public List<ThongKe> ThongKePhieuNhapTheoNhaCungCap(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuNhapTheoNhaCungCap(tk);
        }

        public List<ThongKe> ThongKePhieuNhapLoaiSp(ThongKe tk)
        {
            return thongKeAccess.ThongKePhieuNhapLoaiSp(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoSanPham(ThongKe tk)
        {
            return thongKeAccess.ThongKePHieuXuatTHeoSanPham(tk);
        }

        public List<ThongKe> ThongKePHieuXuatTHeoLoaiSp(ThongKe tk)
        {
            return thongKeAccess.ThongKePHieuXuatTHeoLoaiSp(tk);
        }

        public bool UpdateTongSldTonKho(ThongKe tk)
        {
            return thongKeAccess.UpdateTongSldTonKho(tk);
        }
    }
}
