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
    public partial class frm_ReportNhaSanXuat : Form
    {
        NhaSanXuatBLL nsxbll = new NhaSanXuatBLL();

        public frm_ReportNhaSanXuat()
        {
            InitializeComponent();
        }

        private void frm_ReportNhaSanXuat_Load(object sender, EventArgs e)
        {
            this.NHASXTableAdapter.Fill(this.ds_QLBanHang.NHASX);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
