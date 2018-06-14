using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class NhaSanXuatBLL
    {
        NhaSaXuatAccess nhaSaXuatAccess = new NhaSaXuatAccess();
        public DataTable ShowAllNhaSx()
        {
            return nhaSaXuatAccess.HienThiDanhSachNhaSanXuat();
        }

        public List<NhaSx> GetAllListNhaSx()
        {
            return nhaSaXuatAccess.GetAllListNhaSx();
        }

        public bool InserNhaSx(NhaSx nsx)
        {
            return nhaSaXuatAccess.ThemNhaSanXuat(nsx);
        }

        public bool EditNhaSx(NhaSx nsx)
        {
            return nhaSaXuatAccess.SuaNhaNhaSanXuat(nsx);
        }

        public bool DeleteNhaSx(NhaSx nsx)
        {
            return nhaSaXuatAccess.DeleteNhaSanXuat(nsx);
        }

        // Hien Thi Report Nha San Xuat
        public DataTable HienThiReportNhaSanXuat()
        {
            return nhaSaXuatAccess.HienThiReportNhaSanXuat();
        }

        // Tim kiem Nha San Xuat
        public List<NhaSx> TimKiemNhaSx(NhaSx nsx)
        {
            return nhaSaXuatAccess.TimKiemNhaSx(nsx);
        }

        // Loc Danh sAch Nha San Xuat
        public List<NhaSx> LocDanhSachNhaSanXuat(NhaSx nsx)
        {
            return nhaSaXuatAccess.LocDanhSachNhaSx(nsx);
        }
    }
}
