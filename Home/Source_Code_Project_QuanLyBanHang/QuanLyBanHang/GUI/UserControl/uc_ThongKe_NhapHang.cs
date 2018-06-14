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
    public partial class uc_ThongKe_NhapHang : UserControl
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();

        public uc_ThongKe_NhapHang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_ThongKe_NhapHang_Load(object sender, EventArgs e)
        {
            DanhSachThongKe();
            dgvThongKePhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvThongKePhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKePhieuNhap.AllowUserToAddRows = false;
            dgvThongKePhieuNhap.Columns[0].Width = 30;
            HienThiTenLoaiSp();
            HienThiTenCc();
        }

        private void HienThiTenLoaiSp()
        {
            List<ThongKe> tklist = tkbll.HienThiTenLoaiSanPham();
            foreach (ThongKe tks in tklist)
            {
                cboLoaiSp.Items.Add(tks.TenLoai);
            }
        }

        private void HienThiTenCc()
        {
            List<ThongKe> tklist = tkbll.HienThiTenNhaCungCap();
            foreach (ThongKe tks in tklist)
            {
                cboTenCc.Items.Add(tks.TenCc);
            }

        }

        private void DanhSachThongKe()
        {
            try
            {
                int i = 0;
                List<ThongKe> tklist = tkbll.ThongKePhieuNhap();
                foreach (ThongKe tks in tklist)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvThongKePhieuNhap);
                    row.Cells[0].Value = i + 1;
                    row.Cells[1].Value = tks.MaSp.ToString();
                    row.Cells[2].Value = tks.TenSp.ToString();
                    row.Cells[3].Value = tks.TenLoai.ToString();
                    row.Cells[4].Value = tks.TenSx.ToString();
                    row.Cells[5].Value = tks.Sld.ToString();
                    row.Cells[6].Value = tks.Sln.ToString();
                    row.Cells[7].Value = tks.Slcl.ToString();
                    row.Cells[8].Value = tks.DonGia.ToString();
                    row.Cells[9].Value = tks.ThanhTien.ToString();

                    dgvThongKePhieuNhap.Rows.Add(row);
                    ++i;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvThongKePhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //int i = 0;
            //tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            //tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

            //List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNgayThang(tk);
            //dgvThongKePhieuNhap.Rows.Clear();
            //foreach (ThongKe tks in tklist)
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row.CreateCells(dgvThongKePhieuNhap);
            //    row.Cells[0].Value = i + 1;
            //    row.Cells[1].Value = tks.MaSp;
            //    row.Cells[2].Value = tks.TenSp;
            //    row.Cells[3].Value = tks.TenLoai;
            //    row.Cells[4].Value = tks.TenSx;
            //    row.Cells[5].Value = tks.Sld;

            //    dgvThongKePhieuNhap.Rows.Add(row);
            //    ++i;
            //}
            //txtTongPhieuNhap.Text = i.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //int i = 0;
            //tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            //tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

            //List<ThongKe> tklist = tkbll.ThongKeDonDatHangTheoNgayThang(tk);
            //dgvThongKePhieuNhap.Rows.Clear();
            //foreach (ThongKe tks in tklist)
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row.CreateCells(dgvThongKePhieuNhap);
            //    row.Cells[0].Value = i + 1;
            //    row.Cells[1].Value = tks.MaSp;
            //    row.Cells[2].Value = tks.TenSp;
            //    row.Cells[3].Value = tks.TenLoai;
            //    row.Cells[4].Value = tks.TenSx;
            //    row.Cells[5].Value = tks.Sld;

            //    dgvThongKePhieuNhap.Rows.Add(row);
            //    ++i;
            //}
            //txtTongPhieuNhap.Text = i.ToString();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int i = 0;
            tk.DateOne = DateTime.Parse(dtmTuNgay.Value.ToShortDateString());
            tk.DateTwo = DateTime.Parse(dtmDenNgay.Value.ToShortDateString());

            List<ThongKe> tklist = tkbll.ThongKePhieuNhapTheoNgayThang(tk);
            dgvThongKePhieuNhap.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuNhap);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.Sld.ToString();
                row.Cells[6].Value = tks.Sln.ToString();
                row.Cells[7].Value = tks.Slcl.ToString();
                row.Cells[8].Value = tks.DonGia.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString();

                dgvThongKePhieuNhap.Rows.Add(row);
                ++i;
            }
            txtTongPhieuNhap.Text = i.ToString();
        }

        private void cboTenCc_TextChanged(object sender, EventArgs e)
        {
            if (cboTenCc.Text == "")
            {
                DanhSachThongKe();
                return;
            }

            cboLoaiSp.Text = "";

            int i = 0;
            int Sum = 0;
            tk.TenCc = cboTenCc.Text;
            List<ThongKe> tklist = tkbll.ThongKePhieuNhapTheoNhaCungCap(tk);

            dgvThongKePhieuNhap.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuNhap);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.Sld.ToString();
                row.Cells[6].Value = tks.Sln.ToString();
                row.Cells[7].Value = tks.Slcl.ToString();
                row.Cells[8].Value = tks.DonGia.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString();

                dgvThongKePhieuNhap.Rows.Add(row);
                ++i;
                Sum += i;
            }
            txtTongPhieuNhap.Text = i.ToString();
        }

        private void cboLoaiSp_TextChanged(object sender, EventArgs e)
        {
            if (cboLoaiSp.Text == "")
            {
                DanhSachThongKe();
                return;
            }

            cboTenCc.Text = "";

            int i = 0;
            int Sum = 0;
            tk.TenLoai = cboLoaiSp.Text;
            List<ThongKe> tklist = tkbll.ThongKePhieuNhapLoaiSp(tk);

            dgvThongKePhieuNhap.Rows.Clear();
            foreach (ThongKe tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvThongKePhieuNhap);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = tks.MaSp.ToString();
                row.Cells[2].Value = tks.TenSp.ToString();
                row.Cells[3].Value = tks.TenLoai.ToString();
                row.Cells[4].Value = tks.TenSx.ToString();
                row.Cells[5].Value = tks.Sld.ToString();
                row.Cells[6].Value = tks.Sln.ToString();
                row.Cells[7].Value = tks.Slcl.ToString();
                row.Cells[8].Value = tks.DonGia.ToString();
                row.Cells[9].Value = tks.ThanhTien.ToString();

                dgvThongKePhieuNhap.Rows.Add(row);
                ++i;
                Sum += i;
            }
            txtTongPhieuNhap.Text = i.ToString();

        }
    }
}
