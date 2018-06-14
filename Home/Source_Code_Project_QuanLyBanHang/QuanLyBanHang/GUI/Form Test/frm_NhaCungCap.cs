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
    public partial class frm_NhaCungCap : Form
    {
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void HienThiNhaCungCap()
        {
            NhaCungCapBLL nccbll = new NhaCungCapBLL();
            dgvNhaCC.DataSource = nccbll.ShowAllNhaCC();
            //dataGridView1.AutoResizeColumns();
            //dataGridView1.AutoResizeRows();

            //dataGridView1.Columns[1].Width = 200;
            //dataGridView1.Columns[2].Width = 200;
            dgvNhaCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgvNhaCC.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvNhaCC.Columns[1].Width = 200;
            dgvNhaCC.Columns[2].Width = 200;
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            txtMaNhaCC.Enabled = false;
            HienThiNhaCungCap();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            txtDiaChiNhaCC.Text = "";
            txtSdt.Text = "";
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNhaCC.Text = dgvNhaCC.CurrentRow.Cells[0].Value.ToString();
                txtTenNhaCC.Text = dgvNhaCC.CurrentRow.Cells[1].Value.ToString();
                txtDiaChiNhaCC.Text = dgvNhaCC.CurrentRow.Cells[2].Value.ToString();
                txtSdt.Text = dgvNhaCC.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !", ex.Message);
            }
        }

        //
        NhaCungCap ncc = new NhaCungCap();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCapBLL nccbll = new NhaCungCapBLL();

                ncc.TenCC = txtTenNhaCC.Text;
                ncc.Sdt = int.Parse(txtSdt.Text);
                ncc.DiaChi = txtDiaChiNhaCC.Text;

                bool result = nccbll.InsertNhaCungCap(ncc);
                if (result)
                {
                    HienThiNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Insert NhaCC not Sussuce !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Save!", ex.Message);
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCapBLL nccbll = new NhaCungCapBLL();

                ncc.TenCC = txtTenNhaCC.Text;
                ncc.DiaChi = txtDiaChiNhaCC.Text;
                ncc.Sdt = int.Parse(txtSdt.Text);
                ncc.MaCC = int.Parse(txtMaNhaCC.Text);

                bool result = nccbll.EditNhaCungCap(ncc);
                if (result)
                {
                    HienThiNhaCungCap();
                }
                else
                {
                    MessageBox.Show("Edit NhaCC not Sussuce !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Edit!" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
