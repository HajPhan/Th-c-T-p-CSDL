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
    public partial class uc_LoaiSanPham : UserControl
    {

        LoaiSp lsp = new LoaiSp();
        LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
        int isCheck = 0;

        public uc_LoaiSanPham()
        {
            InitializeComponent();
        }

        private void EnableHome()
        {
            btnRefresh.Enabled = true;
            btnSave.Enabled = false;
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnPrint.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaLoaiSp.Enabled = false
                ;
            txtTenLoaiSp.Enabled = isCheck;
            txtDvt.Enabled = isCheck;
        }

        private void HienThiLoaiSanPham()
        {
            int i = 0;
            dgvLoaiSp.Rows.Clear();
            TurnOffTextBox(false);
            List<LoaiSp> lsplist = lspbll.GetAllListLoaiSp();
            foreach (LoaiSp lsps in lsplist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvLoaiSp);
                row.Cells[0].Value = i+1;
                row.Cells[1].Value = lsps.MaLoai;
                row.Cells[2].Value = lsps.TenLoai;
                row.Cells[3].Value = lsps.Dvt;

                dgvLoaiSp.Rows.Add(row);
                ++i;

            }

        }

        private void uc_LoaiSanPham_Load(object sender, EventArgs e)
        {
            HienThiLoaiSanPham();
            EnableHome();
            TurnOffTextBox(false);
            dgvLoaiSp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiSp.AllowUserToAddRows = false;
            dgvLoaiSp.Columns[0].Width = 30;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            RefreshTextBox();
            TurnOffTextBox(true);
            btnRefresh.Enabled = true;
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isCheck == 0)
            {
                try
                {
                    lsp.TenLoai = txtTenLoaiSp.Text;
                    lsp.Dvt = txtDvt.Text;

                    bool result = lspbll.InserLoaiSanPham(lsp);

                    if (result)
                    {
                        DialogResult dialogResultInsert = MessageBox.Show("Insert Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultInsert == DialogResult.OK)
                        {
                            HienThiLoaiSanPham();
                            EnableHome();
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert Fail!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (isCheck == 1)
            {
                try
                {
                    lsp.TenLoai = txtTenLoaiSp.Text;
                    lsp.Dvt = txtDvt.Text;
                    lsp.MaLoai = int.Parse(txtMaLoaiSp.Text);

                    bool result = lspbll.EditLoaiSanPham(lsp);

                    if (result)
                    {
                        DialogResult dialogResultEdit = MessageBox.Show("Edit Successfull!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultEdit == DialogResult.OK)
                        {
                            HienThiLoaiSanPham();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Edit Fail!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            EnableHome();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            TurnOffTextBox(true);
            btnRefresh.Enabled = true;
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lsp.MaLoai = int.Parse(txtMaLoaiSp.Text);

                bool result = lspbll.DeleteLoaiSanPham(lsp);
                if (result)
                {
                    DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResultDelete == DialogResult.OK)
                    {
                        RefreshTextBox();
                        HienThiLoaiSanPham();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frm_ReportLoaiSanPham frmrLoaiSanPham = new frm_ReportLoaiSanPham();
            frmrLoaiSanPham.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome();
            TurnOffTextBox(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
        }


        private void RefreshTextBox()
        {
            txtMaLoaiSp.Text = "";
            txtTenLoaiSp.Text = "";
            txtDvt.Text = "";

        }

        private void dgvLoaiSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaLoaiSp.Text = dgvLoaiSp.CurrentRow.Cells[1].Value.ToString();
            txtTenLoaiSp.Text = dgvLoaiSp.CurrentRow.Cells[2].Value.ToString();
            txtDvt.Text = dgvLoaiSp.CurrentRow.Cells[3].Value.ToString();
        }

        


        private void cboLoading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoading.SelectedIndex == -1)
            {
                return;
            }

            lsp.Search = cboLoading.Text;
            cboSearch.Items.Clear();
            List<LoaiSp> lsplist = lspbll.LocDanhSachLoaiSanPham(lsp);

            if (cboLoading.Text == "Mã Loại")
            {
                cboSearch.Text = "";
                foreach (LoaiSp lsps in lsplist)
                {
                    cboSearch.Items.Add(lsps.MaLoai);
                }
            }
            else if (cboLoading.Text == "Tên Loại")
            {
                cboSearch.Text = "";
                foreach (LoaiSp lsps in lsplist)
                {
                    cboSearch.Items.Add(lsps.TenLoai);
                }
            }
            else if (cboLoading.Text == "Đơn Vị Tính")
            {
                cboSearch.Text = "";
                foreach (LoaiSp lsps in lsplist)
                {
                    cboSearch.Items.Add(lsps.Dvt);
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
                HienThiLoaiSanPham();
                return;
            }
            lsp.Search = cboSearch.Text;
            List<LoaiSp> lsplist = lspbll.TimKiemLoaiSanPham(lsp);
            dgvLoaiSp.Rows.Clear();

            foreach (LoaiSp lsps in lsplist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvLoaiSp);
                row.Cells[0].Value = i+1;
                row.Cells[1].Value = lsps.MaLoai;
                row.Cells[2].Value = lsps.TenLoai;
                row.Cells[3].Value = lsps.Dvt;

                dgvLoaiSp.Rows.Add(row);
                ++i;
            }
        }
    }
}
