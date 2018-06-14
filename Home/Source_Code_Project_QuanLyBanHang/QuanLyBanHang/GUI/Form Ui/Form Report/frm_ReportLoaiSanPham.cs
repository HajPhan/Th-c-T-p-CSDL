using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frm_ReportLoaiSanPham : Form
    {
        LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();

        public frm_ReportLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frm_ReportLoaiSanPham_Load(object sender, EventArgs e)
        {
            this.LOAISPTableAdapter.Fill(this.ds_QLBanHang.LOAISP);

            this.reportViewer1.RefreshReport();
        }
    }
}
