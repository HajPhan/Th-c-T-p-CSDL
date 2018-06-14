using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Form_Ui.Form_Report
{
    public partial class frm_ReportSanPham : Form
    {
        public frm_ReportSanPham()
        {
            InitializeComponent();
        }

        private void frm_ReportSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBANHANGDataSet.vw_DanhSachSanPhams' table. You can move, or remove it, as needed.
            this.vw_DanhSachSanPhamsTableAdapter.Fill(this.qLBANHANGDataSet.vw_DanhSachSanPhams);



            this.reportViewer1.RefreshReport();
        }
    }
}
