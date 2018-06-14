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
    public partial class frm_ReportDonDh : Form
    {
        public frm_ReportDonDh()
        {
            InitializeComponent();
        }

        private void frm_ReportDonDh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_DanhSachDonDh' table. You can move, or remove it, as needed.
            this.vw_DanhSachDonDhTableAdapter.Fill(this.QLBANHANGDataSet.vw_DanhSachDonDh);

            this.reportViewer1.RefreshReport();
        }
    }
}
