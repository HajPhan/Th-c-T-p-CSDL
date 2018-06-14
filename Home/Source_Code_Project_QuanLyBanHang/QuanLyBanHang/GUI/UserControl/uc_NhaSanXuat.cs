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
    public partial class uc_NhaSanXuat : UserControl
    {

        NhaSx nsx = new NhaSx();
        NhaSanXuatBLL nsxbll = new NhaSanXuatBLL();
        int isCheck = 0;

        public uc_NhaSanXuat()
        {
            InitializeComponent();
        }

        private void EnableHome()
        {
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnPrint.Enabled = true;
            btnCancel.Enabled = false;
            btnRefresh.Enabled = true;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaNhaSx.Enabled = false;
            txtTenNhaSx.Enabled = isCheck;
            txtQuocGia.Enabled = isCheck;

        }

        private void HienThiNhaSanxuat()
        {
            int i = 0;
            dgvNhaSanXuat.Rows.Clear();
            List<NhaSx> nsxlist = nsxbll.GetAllListNhaSx();
            foreach (NhaSx nsxs in nsxlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaSanXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nsxs.MaSx;
                row.Cells[2].Value = nsxs.TenSx;
                row.Cells[3].Value = nsxs.QuocGia;

                dgvNhaSanXuat.Rows.Add(row);
                ++i;
            }
        }


        private void uc_NhaSanXuat_Load(object sender, EventArgs e)
        {
            HienThiNhaSanxuat();
            EnableHome();
            TurnOffTextBox(false);
            dgvNhaSanXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhaSanXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaSanXuat.AllowUserToAddRows = false;
            dgvNhaSanXuat.Columns[0].Width = 30;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            RefreshTextBox();
            TurnOffTextBox(true);
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
            btnRefresh.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            TurnOffTextBox(true);
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
            btnRefresh.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhân xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResultDelete == DialogResult.Yes)
            {
                try
                {
                    nsx.MaSx = int.Parse(txtMaNhaSx.Text);
                    bool result = nsxbll.DeleteNhaSx(nsx);
                    if (result)
                    {
                        DialogResult dialogResult = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            HienThiNhaSanxuat();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isCheck == 0)
            {
                try
                {
                    nsx.TenSx = txtTenNhaSx.Text;
                    nsx.QuocGia = txtQuocGia.Text;

                    bool result = nsxbll.InserNhaSx(nsx);
                    if (result)
                    {
                        DialogResult dialogResultInsert = MessageBox.Show("Insert Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultInsert == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            HienThiNhaSanxuat();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (isCheck == 1)
            {
                try
                {
                    nsx.MaSx = int.Parse(txtMaNhaSx.Text);
                    nsx.TenSx = txtTenNhaSx.Text;
                    nsx.QuocGia = txtQuocGia.Text;

                    bool result = nsxbll.EditNhaSx(nsx);
                    if (result)
                    {
                        DialogResult dialogResultInsert = MessageBox.Show("Edit Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultInsert == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            btnDelete.Enabled = true;
                            HienThiNhaSanxuat();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Edit Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frm_ReportNhaSanXuat frmrNhaSx = new frm_ReportNhaSanXuat();
            frmrNhaSx.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TurnOffTextBox(false);
            EnableHome();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
        }


        private void RefreshTextBox()
        {
            txtMaNhaSx.Text = "";
            txtTenNhaSx.Text = "";
            txtQuocGia.Text = "";

        }

        private void dgvNhaSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaNhaSx.Text = dgvNhaSanXuat.CurrentRow.Cells[1].Value.ToString();
            txtTenNhaSx.Text = dgvNhaSanXuat.CurrentRow.Cells[2].Value.ToString();
            txtQuocGia.Text = dgvNhaSanXuat.CurrentRow.Cells[3].Value.ToString();
        }




        private void cboLoading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoading.SelectedIndex == -1)
            {
                return;
            }

            nsx.Search = cboLoading.Text;
            cboSearch.Items.Clear();
            List<NhaSx> nsxlist = nsxbll.LocDanhSachNhaSanXuat(nsx);

            if (cboLoading.Text == "Mã Sản Xuất")
            {
                cboSearch.Text = "";
                foreach (NhaSx nsxs in nsxlist)
                {
                    cboSearch.Items.Add(nsxs.MaSx);
                }
            }
            else if (cboLoading.Text == "Tên Sản Xuất")
            {
                cboSearch.Text = "";
                foreach (NhaSx nsxs in nsxlist)
                {
                    cboSearch.Items.Add(nsxs.TenSx);
                }
            }
            else if (cboLoading.Text == "Quốc Gia")
            {
                cboSearch.Text = "";
                foreach (NhaSx nsxs in nsxlist)
                {
                    cboSearch.Items.Add(nsxs.QuocGia);
                }
            }
            else
            {
                return;
            }
        }

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (cboSearch.Text == "")
            {
                HienThiNhaSanxuat();
                return;
            }
            nsx.Search = cboSearch.Text;
            List<NhaSx> nsxlist = nsxbll.TimKiemNhaSx(nsx);
            dgvNhaSanXuat.Rows.Clear();

            foreach (NhaSx nsxs in nsxlist)
            {

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaSanXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nsxs.MaSx;
                row.Cells[2].Value = nsxs.TenSx;
                row.Cells[3].Value = nsxs.QuocGia;

                dgvNhaSanXuat.Rows.Add(row);
                ++i;

            }
        }
    }
}
