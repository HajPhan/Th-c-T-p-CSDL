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
    public partial class frm_NhaSanXuat : Form
    {
        NhaSx nsx = new NhaSx();
        NhaSanXuatBLL nsxbll = new NhaSanXuatBLL();

        public frm_NhaSanXuat()
        {
            InitializeComponent();

            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Text = "Search Here";
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaNhaSx.Text = "";
            txtQuocGia.Text = "";
            txtTenNhaSx.Text = "";
        }


        private void frm_NhaSanXuat_Load(object sender, EventArgs e)
        {
            txtMaNhaSx.Enabled = false;
            HienThiNhaSanXuat();
        }

        private void HienThiNhaSanXuat()
        {
            NhaSanXuatBLL nsxbll = new NhaSanXuatBLL();
            dgvNhaSx.DataSource = nsxbll.ShowAllNhaSx();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            nsx.TenSx = txtTenNhaSx.Text;
            nsx.QuocGia = txtQuocGia.Text;

            bool result = nsxbll.InserNhaSx(nsx);
            if (result)
            {
                HienThiNhaSanXuat();
            }
            else
            {
                MessageBox.Show("Inser Provider not success !");
            }
        }

        private void dgvNhaSx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNhaSx.Text = dgvNhaSx.CurrentRow.Cells[0].Value.ToString();
            txtTenNhaSx.Text = dgvNhaSx.CurrentRow.Cells[1].Value.ToString();
            txtQuocGia.Text = dgvNhaSx.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            nsx.TenSx = txtTenNhaSx.Text;
            nsx.QuocGia = txtQuocGia.Text;
            nsx.MaSx = int.Parse(txtMaNhaSx.Text);

            bool result = nsxbll.EditNhaSx(nsx);
            if (result)
            {
                HienThiNhaSanXuat();
            }
            else
            {
                MessageBox.Show("Inser Provider not success !");
            }
        }

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
