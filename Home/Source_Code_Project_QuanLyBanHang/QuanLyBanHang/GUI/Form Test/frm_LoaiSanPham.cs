using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frm_LoaiSanPham : Form
    {
        /// <summary>
        /// /////
        /// </summary>
        LoaiSp lsp = new LoaiSp();
        LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();



        public frm_LoaiSanPham()
        {
            InitializeComponent();

            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Text = "Search Here";
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaLoaiSp.Text = "";
            txtTenLoaiSp.Text = "";
            txtDvt.Text = "";
        }

        private void frm_LoaiSanPham_Load(object sender, EventArgs e)
        {
            txtMaLoaiSp.Enabled = false;
            HienThiLoaiSanPham();
        }
        
        private void HienThiLoaiSanPham()
        {
            LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
            txtMaLoaiSp.Enabled = false;
            dgvLoaiSanPham.DataSource = lspbll.ShowAllLoaiSanPham();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lsp.TenLoai = txtTenLoaiSp.Text;
            lsp.Dvt = txtDvt.Text;

            bool result = lspbll.InserLoaiSanPham(lsp);

            if (result)
            {
                HienThiLoaiSanPham();
            }
            else
            {
                MessageBox.Show("Inser Type Product Not Success !");
            }
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiSp.Text = dgvLoaiSanPham.CurrentRow.Cells[0].Value.ToString();
            txtTenLoaiSp.Text = dgvLoaiSanPham.CurrentRow.Cells[1].Value.ToString();
            txtDvt.Text = dgvLoaiSanPham.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lsp.TenLoai = txtTenLoaiSp.Text;
            lsp.Dvt = txtDvt.Text;
            lsp.MaLoai = int.Parse(txtMaLoaiSp.Text);

            bool result = lspbll.EditLoaiSanPham(lsp);

            if (result)
            {
                HienThiLoaiSanPham();
            }
            else
            {
                MessageBox.Show("Inser Type Product Not Success !");
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
