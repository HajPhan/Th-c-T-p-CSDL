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
    public partial class uc_NhaCungCap : UserControl
    {

        NhaCungCap ncc = new NhaCungCap();
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        int isCheck = 0;

        public uc_NhaCungCap()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
            txtMaNhaCC.Enabled = false;
            txtTenNhaCC.Enabled = isCheck;
            txtSdt.Enabled = isCheck;
            txtDiaChiNhaCC.Enabled = isCheck;
        }

        private void HienThiDanhSachNhaCungCap()
        {
            int i = 0;
            dgvNhaCungCap.Rows.Clear();
            List<NhaCungCap> ncclist = nccbll.GetAllListNhaCungCap();
            foreach (NhaCungCap nccs in ncclist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaCungCap);
                row.Cells[0].Value = i+1;
                row.Cells[1].Value = nccs.MaCC;
                row.Cells[2].Value = nccs.TenCC;
                row.Cells[3].Value = nccs.DiaChi;
                row.Cells[4].Value = nccs.Sdt;

                dgvNhaCungCap.Rows.Add(row);
                ++i;
            }
        }

        private void uc_NhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhaCungCap();
            TurnOffTextBox(false);
            EnableHome();
            dgvNhaCungCap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.Columns[0].Width = 30;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isCheck == 0)
            {
                try
                {
                    ncc.TenCC = txtTenNhaCC.Text;
                    ncc.DiaChi = txtDiaChiNhaCC.Text;
                    ncc.Sdt = int.Parse(txtSdt.Text);

                    bool result = nccbll.InsertNhaCungCap(ncc);

                    if (result)
                    {
                        DialogResult dialogResultInsert = MessageBox.Show("Insert Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultInsert == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            HienThiDanhSachNhaCungCap();
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
                    ncc.TenCC = txtTenNhaCC.Text;
                    ncc.DiaChi = txtDiaChiNhaCC.Text;
                    ncc.Sdt = int.Parse(txtSdt.Text);
                    ncc.MaCC = int.Parse(txtMaNhaCC.Text);

                    bool result = nccbll.EditNhaCungCap(ncc);
                    if (result)
                    {
                        DialogResult dialogResultEdit = MessageBox.Show("Edit Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultEdit == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            btnDelete.Enabled = true;
                            HienThiDanhSachNhaCungCap();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Edit Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //TurnOffTextBox(false);
            //EnableHome();
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
            try
            {
                ncc.MaCC = int.Parse(txtMaNhaCC.Text);
                bool result = nccbll.DeleteNhaCungCap(ncc);

                if (result)
                {
                    DialogResult dialogResultDelete = MessageBox.Show("Delete Successfull!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResultDelete == DialogResult.OK)
                    {
                        HienThiDanhSachNhaCungCap();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Delete Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frm_ReportNhaCungCap frmrNhaCungCap = new frm_ReportNhaCungCap();
            frmrNhaCungCap.ShowDialog();
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
            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            txtDiaChiNhaCC.Text = "";
            txtSdt.Text = "";
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaNhaCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txtTenNhaCC.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txtDiaChiNhaCC.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dgvNhaCungCap.CurrentRow.Cells[4].Value.ToString();
        }

        


        private void cboLoading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoading.SelectedIndex == -1)
            {
                return;
            }

            ncc.Search = cboLoading.Text;
            cboSearch.Items.Clear();
            List<NhaCungCap> ncclist = nccbll.LocDanhSachNhaCungCap(ncc);

            if (cboLoading.Text == "Mã Cung Cấp")
            {
                cboSearch.Text = "";
                foreach (NhaCungCap nccs in ncclist)
                {
                    cboSearch.Items.Add(nccs.MaCC);
                }
            }
            else if (cboLoading.Text == "Tên Cung Cấp")
            {
                cboSearch.Text = "";
                foreach (NhaCungCap nccs in ncclist)
                {
                    cboSearch.Items.Add(nccs.TenCC);
                }
            }
            else if (cboLoading.Text == "Số Điện Thoại")
            {
                cboSearch.Text = "";
                foreach (NhaCungCap nccs in ncclist)
                {
                    cboSearch.Items.Add(nccs.Sdt);
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
                HienThiDanhSachNhaCungCap();
                return;
            }
            ncc.Search = cboSearch.Text;
            List<NhaCungCap> ncclist = nccbll.TimKiemNhaCungCap(ncc);
            dgvNhaCungCap.Rows.Clear();

            foreach (NhaCungCap nccs in ncclist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhaCungCap);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nccs.MaCC;
                row.Cells[2].Value = nccs.TenCC;
                row.Cells[3].Value = nccs.DiaChi;
                row.Cells[4].Value = nccs.Sdt;

                dgvNhaCungCap.Rows.Add(row);
                ++i;
            }
        }
    }
}
