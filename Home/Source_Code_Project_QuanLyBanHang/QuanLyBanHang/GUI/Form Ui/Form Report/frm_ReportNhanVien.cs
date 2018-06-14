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
using GUI.Form_Ui;

namespace GUI
{
    public partial class frm_ReportNhanVien : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        
        public frm_ReportNhanVien()
        {
            InitializeComponent();
        }

        private void frm_ReportNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.NHANVIENTableAdapter.Fill(this.QLBANHANGDataSet.NHANVIEN);


            //crvNhanVien.ReportSource = crnv;
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
    }
}
