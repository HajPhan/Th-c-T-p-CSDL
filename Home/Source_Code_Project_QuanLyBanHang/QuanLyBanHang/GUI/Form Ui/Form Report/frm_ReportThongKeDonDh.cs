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
    public partial class frm_ReportThongKeDonDh : Form
    {
        public frm_ReportThongKeDonDh()
        {
            InitializeComponent();
        }

        private void frm_ReportThongKeDonDh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_ThongKeDonDatHang' table. You can move, or remove it, as needed.
            

            this.reportViewer1.RefreshReport();
        }
    }
}
