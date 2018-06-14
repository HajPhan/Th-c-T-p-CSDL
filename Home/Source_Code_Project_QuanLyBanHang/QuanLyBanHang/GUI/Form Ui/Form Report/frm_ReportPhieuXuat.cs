using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DTO;

namespace GUI
{
    public partial class frm_ReportPhieuXuat : Form
    {
        public frm_ReportPhieuXuat()
        {
            InitializeComponent();
        }

        uc_PhieuXuat px = new uc_PhieuXuat();
        private void SetParameters(int maxp, DateTime ngayxuat)
        {
            ReportParameter rp = new ReportParameter("MaPx");
            ReportParameter rps = new ReportParameter("NgayXuat");
            rp.Values.Add(maxp.ToString());
            rps.Values.Add(ngayxuat.ToShortDateString());

            reportViewer1.LocalReport.SetParameters(rp);
            reportViewer1.LocalReport.SetParameters(rps);

        }

        private void frm_ReportPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBANHANGDataSet.vw_PhieuXuatKhachHang' table. You can move, or remove it, as needed.
            this.vw_PhieuXuatKhachHangTableAdapter.Fill(this.QLBANHANGDataSet.vw_PhieuXuatKhachHang);


            uc_PhieuXuat px = new uc_PhieuXuat();
            int mapx = PhieuXuatHang.MaPxKh;
            DateTime ngayxuat = PhieuXuatHang.NgayXuatKh;

            SetParameters(mapx,ngayxuat);


            this.reportViewer1.RefreshReport();
        }
    }
}
