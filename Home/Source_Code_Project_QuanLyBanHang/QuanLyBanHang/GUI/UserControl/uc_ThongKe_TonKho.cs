using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.Form_Ui.Form_Main;

namespace GUI
{
    public partial class uc_ThongKe_TonKho : UserControl
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();

        public uc_ThongKe_TonKho()
        {
            InitializeComponent();
        }
        private void EnableHome()
        {

        }
        private void uc_ThongKe_TonKho_Load(object sender, EventArgs e)
        {
            ThongKeTonKho();

            dgvThongKeTonKhoSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKeTonKhoSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeTonKhoSanPham.AllowUserToAddRows = false;
            dgvThongKeTonKhoSanPham.Columns[0].Width = 30;
            HienThiTenLoaiSp();
            HienThiTenSanXuat();
        }

        public void ThongKeTonKho()
        {
            int i = 0;
            List<ThongKe> tklist = tkbll.ThongKeTonKho();
            foreach(ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeTonKhoSanPham);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.Sld;
                row.Cells[4].Value = tks.Sln;
                row.Cells[5].Value = tks.Slx;
                row.Cells[6].Value = tks.Slcl;

                dgvThongKeTonKhoSanPham.Rows.Add(row);
                ++i;
            }
        }

        private void HienThiTenLoaiSp()
        {
            List<ThongKe> tklist = tkbll.HienThiTenLoaiSanPham();
            foreach (ThongKe tks in tklist)
            {
                cboLoaiSp.Items.Add(tks.TenLoai);
            }
        }

        private void HienThiTenSanXuat()
        {
            List<ThongKe> tklist = tkbll.HienThiTenNhaSanXuat();
            foreach (ThongKe tks in tklist)
            {
                cboTenSx.Items.Add(tks.TenSx);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int i = 0;
            tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

            List<ThongKe> tklist = tkbll.ThongKeTonKhoTheoNgayThang(tk);
            dgvThongKeTonKhoSanPham.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeTonKhoSanPham);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.Sld;
                row.Cells[4].Value = tks.Sln;
                row.Cells[5].Value = tks.Slx;
                row.Cells[6].Value = tks.Slcl;

                dgvThongKeTonKhoSanPham.Rows.Add(row);
                ++i;
            }
            cboTongso.Text = i.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frm_ReportThongKeTonKho frmReportThongKe = new frm_ReportThongKeTonKho();
            frmReportThongKe.ShowDialog();
        }

        private void dgvThongKeTonKhoSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_InsertTongDauTonKho frmTongSld = new frm_InsertTongDauTonKho(this);
            ThongKe.MasP = int.Parse(dgvThongKeTonKhoSanPham.CurrentRow.Cells[1].Value.ToString());
            frmTongSld.ShowDialog();
        }
    }
}
