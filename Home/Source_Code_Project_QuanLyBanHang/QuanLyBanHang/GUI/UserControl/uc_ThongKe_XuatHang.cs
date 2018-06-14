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
    public partial class uc_ThongKe_XuatHang : UserControl
    {

        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();
        int i = 0;
        int sum = 0;

        public uc_ThongKe_XuatHang()
        {
            InitializeComponent();
        }

        private void dgvThongKePhieuXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double ThanhTien = double.Parse(dgvThongKePhieuXuatHang.CurrentRow.Cells[9].Value.ToString());

            lbTongTien.Text = ThanhTien.ToString("00,00.##");
        }

        private void uc_ThongKe_XuatHang_Load(object sender, EventArgs e)
        {
            DanhSachThongKe();
            dgvThongKePhieuXuatHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKePhieuXuatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKePhieuXuatHang.AllowUserToAddRows = false;
            dgvThongKePhieuXuatHang.Columns[0].Width = 30;
            dgvThongKePhieuXuatHang.Columns[3].Width = 80;
            HienThiTenLoaiSp();
            HienThiTenSanXuat();
        }

        private void DanhSachThongKe()
        {
            List<ThongKe> tklist = tkbll.ThongKePhieuXuat();
            dgvThongKePhieuXuatHang.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuXuatHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.TenKh.ToString();
                row.Cells[6].Value = tks.Slx.ToString();
                row.Cells[7].Value = tks.TongTien.ToString();
                row.Cells[8].Value = tks.PhanTram.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString();

                dgvThongKePhieuXuatHang.Rows.Add(row);
                ++i;
            }
            sum += i;
            lbTong.Text = sum.ToString();
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
            //List<ThongKe> tklist = tkbll.HienThiTenNhaSanXuat();
            //foreach (ThongKe tks in tklist)
            //{
            //    cboTenSp.Items.Add(tks.TenSx);
            //}

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
                tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

                List<ThongKe> tklist = tkbll.ThongKePhieuXuatTheoNgayThang(tk);
                dgvThongKePhieuXuatHang.Rows.Clear();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKePhieuXuatHang);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp.ToString();
                    row.Cells[2].Value = tks.TenSp.ToString();
                    row.Cells[3].Value = tks.TenLoai.ToString();
                    row.Cells[4].Value = tks.TenSx.ToString();
                    row.Cells[5].Value = tks.TenKh.ToString();
                    row.Cells[6].Value = tks.Slx.ToString();
                    row.Cells[7].Value = tks.TongTien.ToString();
                    row.Cells[8].Value = tks.PhanTram.ToString();
                    row.Cells[9].Value = tks.ThanhTien.ToString();

                    dgvThongKePhieuXuatHang.Rows.Add(row);
                    ++i;
                }
                lbTong.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cboTenSp_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLoaiSp_TextChanged(object sender, EventArgs e)
        {
            if (cboLoaiSp.Text == "")
            {
                DanhSachThongKe();
                return;
            }

            //cboTenSp.Text = "";

            int i = 0;
            int Sum = 0;
            tk.TenLoai = cboLoaiSp.Text;
            List<ThongKe> tklist = tkbll.ThongKePHieuXuatTHeoLoaiSp(tk);

            dgvThongKePhieuXuatHang.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuXuatHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.TenKh.ToString();
                row.Cells[6].Value = tks.Slx.ToString();
                row.Cells[7].Value = tks.TongTien.ToString();
                row.Cells[8].Value = tks.PhanTram.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString();

                dgvThongKePhieuXuatHang.Rows.Add(row);
                ++i;
                Sum += i;
            }
            lbTong.Text = i.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
