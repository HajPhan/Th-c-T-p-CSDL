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
    public partial class frm_PhieuNhap : Form
    {

        /// <summary>
        /// 
        /// </summary>
        /// 

        PhieuNhapHang pn = new PhieuNhapHang();
        PhieuNhapBLL pnbll = new PhieuNhapBLL();

        public frm_PhieuNhap()
        {
            InitializeComponent();
        }

        private void frm_PhieuNhap_Load(object sender, EventArgs e)
        {
            HienThiPhieuNhap();
        }


        private void HienThiPhieuNhap()
        {
            dgvPhieuNhap.DataSource = pnbll.ShowDataPhieuNhap();
            dgvCTPN.DataSource = pnbll.ShowDataCTPN();
            txtMaNv.Text = UserInfo.Id.ToString();
            cboMaCC.DataSource = pnbll.LoadComboxBoxMaDh();
            cboTenCC.DataSource = pnbll.LoadComboxTenNhaCungCap();
            cboMaSp.DataSource = pnbll.LoadComboBoxMaSanPham();
            txtMaPn.Enabled = false;
            txtMaNv.Enabled = false;
            txtNgayNhap.Enabled = false;

            // Tùy chỉnh kích thước cột
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTPN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuNhap.Columns[3].Width = 200;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            lbDateTime.Text = datetime;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaPn.Text = "";
            cboMaCC.Text = "";
            cboTenCC.Text = "";
            txtNgayNhap.Text = "";
            cboMaSp.Text = "";
            txtSoLuongNhap.Text = "";
            txtDonGia.Text = "";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                pn.MaNv = int.Parse(txtMaNv.Text);
                pn.MaDh = int.Parse(cboMaCC.Text);
                pn.NgayNhap = DateTime.Now;
                pn.MaSp = int.Parse(cboMaSp.Text);
                pn.Sln = int.Parse(txtSoLuongNhap.Text);
                pn.Dongia = float.Parse(txtDonGia.Text);

                bool result = pnbll.InsertPhieuNhap(pn);
                if (result)
                {
                    HienThiPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Insert Not Success !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Save!" + ex.Message);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void cboMaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaCC.SelectedIndex == -1)
            //{
            //    return;
            //}
            //pn.MaCc = int.Parse(cboMaCC.Text);
            //cboTenCC.DataSource = pnbll.ShowTenNhaCungCapFlowMaCungCap(pn);
            
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPn.Text = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            txtMaNv.Text = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            cboMaCC.Text = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            txtNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells[3].Value.ToString();

            //
            cboMaSp.Text = dgvCTPN.CurrentRow.Cells[1].Value.ToString();
            txtSoLuongNhap.Text = dgvCTPN.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvCTPN.CurrentRow.Cells[3].Value.ToString();

        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaSp.Text = dgvCTPN.CurrentRow.Cells[1].Value.ToString();
            txtSoLuongNhap.Text = dgvCTPN.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvCTPN.CurrentRow.Cells[3].Value.ToString();

            //
            txtMaPn.Text = dgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            txtMaNv.Text = dgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            cboMaCC.Text = dgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            txtNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells[3].Value.ToString();


        }
    }
}
