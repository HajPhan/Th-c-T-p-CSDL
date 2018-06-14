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
    public partial class frm_ReportKhachHang : Form
    {
        KhachHangBLL khbll = new KhachHangBLL();

        public frm_ReportKhachHang()
        {
            InitializeComponent();
        }

        private void frm_ReportKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_QLBanHang.KHACHHANG' table. You can move, or remove it, as needed.
            this.KHACHHANGTableAdapter.Fill(this.ds_QLBanHang.KHACHHANG);

            this.reportViewer1.RefreshReport();
        }
    }
}
