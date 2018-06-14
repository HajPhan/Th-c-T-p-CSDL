using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen
    {
        public string idPermission { get; set; }
        public string namePermission { get; set; }
        public string ghiChu { get; set; }
        public int Inserts { get; set; }
        public int Updates { get; set; }
        public int Deletes { get; set; }
        public int Searchs { get; set; }
        public int In { get; set; }
        public string idChucNang { get; set; }
        public string nameChucNang { get; set; }
        public int DanhMuc { get; set; }
        public int QuanLyBanHang { get; set; }
        public int ThongKe { get; set; }
        public int SaoLuu { get; set; }
        public int Help { get; set; }

    }
}
