using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenAccess phanQuyenAccess = new PhanQuyenAccess();
        
        // Hiển Thi Danh Sách Quyền Hạn
        public DataTable ShowListPermissionGroup()
        {
            return phanQuyenAccess.HienThiNhomQuyen();
        }

        // Hiển Thi Danh Sách Chi Tiết Quyền Hạn
        public List<PhanQuyen> ShowListDetailsPermission(PhanQuyen pq)
        {
            return phanQuyenAccess.HienThiDanhSachChucNang(pq);
        }
    }
}
