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
    public partial class frm_ReportThongKePhieuXuat : Form
    {
        public frm_ReportThongKePhieuXuat()
        {
            InitializeComponent();
        }

        private void frm_ReportThongKePhieuXuat_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
