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

namespace GUI
{
    public partial class frm_PhieuXuat : Form
    {
        /// <summary>
        /// 
        /// </summary>

        PhieuXuatHang px = new PhieuXuatHang();
        PhieuXuatBLL pxbll = new PhieuXuatBLL();
         
        public frm_PhieuXuat()
        {
            InitializeComponent();
        }

        private void frm_PhieuXuat_Load(object sender, EventArgs e)
        {
            HienThiPhieuXuat();
        }

        private void HienThiPhieuXuat()
        {
            dgvPhieuXuat.DataSource = pxbll.ShowListPhieuXuat();
            dgvCTPX.DataSource = pxbll.ShowListCTPX();
            cboMaKh.DataSource = pxbll.ShowMaKhachHang();
            cboTenKh.DataSource = pxbll.ShowTenKhachHang();
            cboMaSp.DataSource = pxbll.ShowMaSanPham();
            cboMaDh.DataSource = pxbll.ShowMaDonHang();
            cboSoLuongXuat.DataSource = pxbll.ShowSoLuongDatHang();
            txtMaNv.Text = UserInfo.Id.ToString();
            cboMaSp.Enabled = false;
            txtMaNv.Enabled = false;
            txtMaPx.Enabled = false;

            // Căn chỉnh các columns trong DataGridView
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTPX.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            lbDateTime.Text = datetime;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                px.MaNv = int.Parse(txtMaNv.Text);
                px.MaKh = int.Parse(cboMaKh.Text);
                px.NgayXuat = DateTime.Parse(dtmNgayXuatHang.Value.ToLongTimeString());
                px.MaDh = int.Parse(cboMaDh.Text);
                px.MaSp = int.Parse(cboMaSp.Text);
                px.Slx = int.Parse(cboSoLuongXuat.Text);
                px.PhanTram = float.Parse(txtPhanTram.Text);

                bool result = pxbll.InsertPhieuXuatHang(px);

                if (result)
                {
                    HienThiPhieuXuat();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Save !", ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LamMoi();
        }

        private void LamMoi()
        {
            txtMaPx.Text = "";
            txtPhanTram.Text = "";
            cboSoLuongXuat.Text = "";
            dtmNgayXuatHang.Text = "";
            cboMaDh.Text = "";
            cboMaKh.Text = "";
            cboMaSp.Text = "";
            cboTenKh.Text = "";
            lbThanhTien.Text = "";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaKh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaKh.SelectedIndex == -1)
            {
                return;
            }
            px.MaKh = int.Parse(cboMaKh.Text);
            cboTenKh.DataSource = pxbll.ShowTenKhTheoMaKn(px);

        }

        private void cboMaDh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaDh.SelectedIndex == -1)
            {
                return;
            }
            px.MaDh = int.Parse(cboMaDh.Text);
            cboSoLuongXuat.DataSource = pxbll.ShowSlxTheoMaDh(px);
            cboMaSp.DataSource = pxbll.ShowMaSpTheoMaDh(px);
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPx.Text = dgvPhieuXuat.CurrentRow.Cells[0].Value.ToString();
            txtMaNv.Text = dgvPhieuXuat.CurrentRow.Cells[1].Value.ToString();
            cboMaKh.Text = dgvPhieuXuat.CurrentRow.Cells[2].Value.ToString();
            dtmNgayXuatHang.Text = dgvPhieuXuat.CurrentRow.Cells[3].Value.ToString();

            //
            //cboMaSp.Text = dgvCTPX.CurrentRow.Cells[1].Value.ToString();
            //cboSoLuongXuat.Text = dgvCTPX.CurrentRow.Cells[2].Value.ToString();
            //cboMaDh.Text = dgvCTPX.CurrentRow.Cells[3].Value.ToString();
            //txtPhanTram.Text = dgvCTPX.CurrentRow.Cells[4].Value.ToString();
            //lbThanhTien.Text = dgvCTPX.CurrentRow.Cells[5].Value.ToString();
            dgvCTPX_CellClick(sender, e);
        }

        private void dgvCTPX_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cboMaSp.Text = dgvCTPX.CurrentRow.Cells[1].Value.ToString();
            cboSoLuongXuat.Text = dgvCTPX.CurrentRow.Cells[2].Value.ToString();
            cboMaDh.Text = dgvCTPX.CurrentRow.Cells[3].Value.ToString();
            txtPhanTram.Text = dgvCTPX.CurrentRow.Cells[4].Value.ToString();
            lbThanhTien.Text = dgvCTPX.CurrentRow.Cells[5].Value.ToString();

            //
            txtMaPx.Text = dgvPhieuXuat.CurrentRow.Cells[0].Value.ToString();
            txtMaNv.Text = dgvPhieuXuat.CurrentRow.Cells[1].Value.ToString();
            cboMaKh.Text = dgvPhieuXuat.CurrentRow.Cells[2].Value.ToString();
            dtmNgayXuatHang.Text = dgvPhieuXuat.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
