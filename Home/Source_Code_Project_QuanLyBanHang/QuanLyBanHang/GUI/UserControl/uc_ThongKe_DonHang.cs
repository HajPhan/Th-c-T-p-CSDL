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

namespace GUI
{
    public partial class uc_ThongKe_DonHang : UserControl
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();
        int Sum = 0;

        public uc_ThongKe_DonHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            #region
            //cboNhaSx.Text = "";
            //cboLoaiSp.Text = "";

            //int i = 0;
            //tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            //tk.DateTwo = DateTime.Now;

            //List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNgayThang(tk);
            //dgvThongKeDoDh.Rows.Clear();
            //foreach (ThongKe tks in tklist)
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row.CreateCells(dgvThongKeDoDh);
            //    row.Cells[0].Value = i + 1;
            //    row.Cells[1].Value = tks.MaSp;
            //    row.Cells[2].Value = tks.TenSp;
            //    row.Cells[3].Value = tks.TenLoai;
            //    row.Cells[4].Value = tks.TenSx;
            //    row.Cells[5].Value = tks.Sld;

            //    dgvThongKeDoDh.Rows.Add(row);
            //    ++i;
            //}
            //cboTongDodh.Text = i.ToString();
            #endregion
        }

        private void dtmDenNgay_ValueChanged(object sender, EventArgs e)
        {
            #region
            //int i = 0;
            //tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            //tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToLongDateString());

            //List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNgayThang(tk);
            //dgvThongKeDoDh.Rows.Clear();
            //foreach (ThongKe tks in tklist)
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row.CreateCells(dgvThongKeDoDh);
            //    row.Cells[0].Value = i + 1;
            //    row.Cells[1].Value = tks.MaSp;
            //    row.Cells[2].Value = tks.TenSp;
            //    row.Cells[3].Value = tks.TenLoai;
            //    row.Cells[4].Value = tks.TenSx;
            //    row.Cells[5].Value = tks.Sld;

            //    dgvThongKeDoDh.Rows.Add(row);
            //    ++i;
            //    Sum += i;
            //}
            //cboTongDodh.Text = i.ToString();

            #endregion
        }

        public void HienThiThongKe()
        {
            int i = 0;
            List<ThongKe> tklist = tkbll.ThongKeDonDatHang();
            dgvThongKeDoDh.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeDoDh);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.TenLoai;
                row.Cells[4].Value = tks.TenSx;
                row.Cells[5].Value = tks.Sld;

                dgvThongKeDoDh.Rows.Add(row);
                ++i;
                Sum += i;
            }
            cboTongDodh.Text = i.ToString();
        }

        private void uc_ThongKe_DonHang_Load(object sender, EventArgs e)
        {
            HienThiThongKe();
            dgvThongKeDoDh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKeDoDh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKeDoDh.AllowUserToAddRows = false;
            dgvThongKeDoDh.Columns[0].Width = 30;
            cboTongDodh.DataSource = tkbll.TongSldh();
            HienThiTenLoaiSp();
            HienThiTenSanXuat();
        }

        private void dgvThongKeDoDh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tk.MaSp = int.Parse(dgvThongKeDoDh.CurrentRow.Cells[1].Value.ToString());
            cboTongSldh.DataSource = tkbll.TonSldhTheoMaSp(tk);
        }

        private void cboLoaiSp_TextChanged(object sender, EventArgs e)
        {
            if (cboLoaiSp.Text == "")
            {
                HienThiThongKe();
                return;
            }

            cboNhaSx.Text = "";

            int i = 0;

            tk.TenLoai = cboLoaiSp.Text;
            List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoLoaiSp(tk);

            dgvThongKeDoDh.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeDoDh);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.TenLoai;
                row.Cells[4].Value = tks.TenSx;
                row.Cells[5].Value = tks.Sld;

                dgvThongKeDoDh.Rows.Add(row);
                ++i;
                Sum += i;
            }
            cboTongDodh.Text = i.ToString();

        }

        private void HienThiTenLoaiSp()
        {
            List<ThongKe> tklist = tkbll.HienThiTenLoaiSanPham();
            foreach(ThongKe tks in tklist)
            {
                cboLoaiSp.Items.Add(tks.TenLoai);
            }
        }

        private void HienThiTenSanXuat()
        {
            List<ThongKe> tklist = tkbll.HienThiTenNhaSanXuat();
            foreach (ThongKe tks in tklist)
            {
                cboNhaSx.Items.Add(tks.TenSx);
            }
        }

        private void cboNhaSx_TextChanged(object sender, EventArgs e)
        {
            if (cboNhaSx.Text == "")
            {
                HienThiThongKe();
                return;
            }

            cboLoaiSp.Text = "";

            int i = 0;
            tk.TenLoai = cboNhaSx.Text;
            List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNhaSx(tk);

            dgvThongKeDoDh.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeDoDh);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.TenLoai;
                row.Cells[4].Value = tks.TenSx;
                row.Cells[5].Value = tks.Sld;

                dgvThongKeDoDh.Rows.Add(row);
                ++i;
                Sum += i;
            }
            cboTongDodh.Text = i.ToString();

        }

        private void cboLoaiSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            //if (cboLoaiSp.Text == "")
            //{
            //    HienThiThongKe();
            //    return;
            //}
            //else
            //{
            //    int i = 0;

            //    tk.TenLoai = cboLoaiSp.Text;
            //    List<ThongKe> tklist = new List<ThongKe>();

            //    dgvThongKeDoDh.Rows.Clear();
            //    foreach (ThongKe tks in tklist)
            //    {
            //        DataGridViewRow row = new DataGridViewRow();
            //        row.CreateCells(dgvThongKeDoDh);
            //        row.Cells[0].Value = i + 1;
            //        row.Cells[1].Value = tks.MaSp;
            //        row.Cells[2].Value = tks.TenSp;
            //        row.Cells[3].Value = tks.TenLoai;
            //        row.Cells[4].Value = tks.TenSx;
            //        row.Cells[5].Value = tks.Sld;

            //        dgvThongKeDoDh.Rows.Add(row);
            //        ++i;
            //        Sum += i;
            //    }
            //    cboTongDodh.Text = i.ToString();
            //}
            #endregion
        }

        private void cboNhaSx_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            //if (cboNhaSx.Text == "")
            //{
            //    HienThiThongKe();
            //    return;
            //}
            //else
            //{
            //    int i = 0;

            //    tk.TenLoai = cboNhaSx.Text;
            //    List<ThongKe> tklist = new List<ThongKe>();

            //    dgvThongKeDoDh.Rows.Clear();
            //    foreach (ThongKe tks in tklist)
            //    {
            //        DataGridViewRow row = new DataGridViewRow();
            //        row.CreateCells(dgvThongKeDoDh);
            //        row.Cells[0].Value = i + 1;
            //        row.Cells[1].Value = tks.MaSp;
            //        row.Cells[2].Value = tks.TenSp;
            //        row.Cells[3].Value = tks.TenLoai;
            //        row.Cells[4].Value = tks.TenSx;
            //        row.Cells[5].Value = tks.Sld;

            //        dgvThongKeDoDh.Rows.Add(row);
            //        ++i;
            //        Sum += i;
            //    }
            //    cboTongDodh.Text = i.ToString();
            //}
            #endregion
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            cboNhaSx.Text = "";
            cboLoaiSp.Text = "";

            int i = 0;
            tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

            List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNgayThang(tk);
            dgvThongKeDoDh.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKeDoDh);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp;
                row.Cells[2].Value = tks.TenSp;
                row.Cells[3].Value = tks.TenLoai;
                row.Cells[4].Value = tks.TenSx;
                row.Cells[5].Value = tks.Sld;

                dgvThongKeDoDh.Rows.Add(row);
                ++i;
            }
            cboTongDodh.Text = i.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_ReportThongKeDonDh frmThongKe = new frm_ReportThongKeDonDh();
            frmThongKe.ShowDialog();
        }
    }
}
