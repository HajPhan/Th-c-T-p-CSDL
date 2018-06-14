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
    public partial class frm_KhachHang : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// 

        KhachHang kh = new KhachHang();
        KhachHangBLL khbll = new KhachHangBLL();


        public frm_KhachHang()
        {
            InitializeComponent();

            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Text = "Search Here";
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaKh.Text = "";
            txtHoten.Text = "";
            dtmNgaySinh.Text = "";
            cboGioiTinh.Text = "";
            txtSdt.Text = "";
            txtMail.Text = "";
            txtDiaChi.Text = "";
            dtmNgayDk.Text = "";
        }

        private void HienThiKhachHang()
        {
            
            dgvKhachHang.DataSource = khbll.HienThiDanhSachKhach();
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            txtMaKh.Enabled = false;
            HienThiKhachHang();
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sCommobox = this.cboGioiTinh.SelectedIndex.ToString();
                kh.Hoten = txtHoten.Text;
                kh.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                if (cboGioiTinh.SelectedIndex == 0)
                {
                    kh.GioiTinh = cboGioiTinh.Text;
                }
                else if (cboGioiTinh.SelectedIndex == 1)
                {
                    kh.GioiTinh = cboGioiTinh.Text;
                }
                else if (cboGioiTinh.SelectedIndex == 2)
                {
                    kh.GioiTinh = cboGioiTinh.Text;
                }
                kh.Sdt = int.Parse(txtSdt.Text);
                kh.Mail = txtMail.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.NgayDk = DateTime.Parse(dtmNgayDk.Value.ToShortDateString());

                bool result = khbll.InsertKhachHang(kh);
                if (result)
                {
                    HienThiKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Save !", ex.Message);
            }

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaKh.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
                txtHoten.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
                dtmNgaySinh.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
                cboGioiTinh.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
                txtSdt.Text = dgvKhachHang.CurrentRow.Cells[4].Value.ToString();
                txtMail.Text = dgvKhachHang.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[6].Value.ToString();
                dtmNgayDk.Text = dgvKhachHang.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found!", ex.Message);
            }
        }

    

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string sCommobox = this.cboGioiTinh.SelectedIndex.ToString();
                kh.MaKh = int.Parse(txtMaKh.Text);
                kh.Hoten = txtHoten.Text;
                kh.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                if (cboGioiTinh.SelectedIndex == 0)
                {
                    kh.GioiTinh = cboGioiTinh.Text;
                }
                else if (cboGioiTinh.SelectedIndex == 1)
                {
                    kh.GioiTinh = cboGioiTinh.Text;
                }
                else if (cboGioiTinh.SelectedIndex == 2)
                {
                    kh.GioiTinh = cboGioiTinh.Text;
                }
                kh.Sdt = int.Parse(txtSdt.Text);
                kh.Mail = txtMail.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.NgayDk = DateTime.Parse(dtmNgayDk.Value.ToShortDateString());

                bool result = khbll.UpdateKhachHang(kh);
                if (result)
                {
                    HienThiKhachHang();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi Edit", ex.Message);
            }

        }


        // Xu ly khi tim kiem
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search Here";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(Object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Here")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
    }
}
