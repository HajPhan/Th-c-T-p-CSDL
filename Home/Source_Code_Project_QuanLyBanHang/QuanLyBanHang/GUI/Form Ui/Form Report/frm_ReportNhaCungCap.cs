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
    public partial class frm_ReportNhaCungCap : Form
    {
        NhaCungCapBLL nccbll = new NhaCungCapBLL();

        public frm_ReportNhaCungCap()
        {
            InitializeComponent();
        }

        private void frm_ReportNhaCungCap_Load(object sender, EventArgs e)
        {
            this.NHACCTableAdapter.Fill(this.ds_QLBanHang.NHACC);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
