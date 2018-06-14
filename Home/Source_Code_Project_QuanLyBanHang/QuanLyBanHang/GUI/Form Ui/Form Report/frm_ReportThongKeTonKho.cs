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
    public partial class frm_ReportThongKeTonKho : Form
    {
        public frm_ReportThongKeTonKho()
        {
            InitializeComponent();
        }

        private void frm_ReportThongKeTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.TONKHO' table. You can move, or remove it, as needed.
            this.TONKHOTableAdapter.Fill(this.QLBANHANGDataSet.TONKHO);

            this.reportViewer1.RefreshReport();
        }
    }
}
