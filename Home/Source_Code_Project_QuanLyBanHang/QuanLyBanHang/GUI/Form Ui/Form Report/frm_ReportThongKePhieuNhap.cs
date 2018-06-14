using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_ReportThongKePhieuNhap : Form
    {
        public frm_ReportThongKePhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_ReportThongKePhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.PHIEUNHAPTableAdapter.Fill(this.QLBANHANGDataSet.PHIEUNHAP);
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.TONKHO' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
        }
    }
}
