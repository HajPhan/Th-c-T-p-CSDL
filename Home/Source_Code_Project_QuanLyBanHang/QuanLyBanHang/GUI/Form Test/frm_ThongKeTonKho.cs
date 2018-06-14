using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class frm_ThongKeTonKho : Form
    {
        public frm_ThongKeTonKho()
        {
            InitializeComponent();
        }

        private void frm_ThongKeTonKho_Load(object sender, EventArgs e)
        {

        }

        private void uaReport1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-KM5FA0O;Initial Catalog=QLBANHANG;Integrated Security=True");
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT *FROM NHANVIEN", con);
            DataSet ds = new DataSet();
            sqlData.Fill(ds, "NHANVIEN");

            this.crystalReportViewer1.ReportSource = ds;

            this.crystalReportViewer1.RefreshReport();
        }
    }
}
