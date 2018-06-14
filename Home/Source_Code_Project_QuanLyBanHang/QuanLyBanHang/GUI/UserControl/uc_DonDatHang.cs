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
    public partial class uc_DonDatHang : UserControl
    {
        DonDatHang dh = new DonDatHang();
        DonDatHangBLL dhbll = new DonDatHangBLL();
        int isCheck = 0;

        public uc_DonDatHang()
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
            txtMaDh.Enabled = false;
            txtMaNv.Enabled = false;
            cboMaCC.Enabled = isCheck;
            cboMaSp_1.Enabled = isCheck;
            cboTenCC.Enabled = isCheck;
            cboMaSp_2.Enabled = isCheck;
            txtNgayDh.Enabled = true;
            btnTime.Enabled = false;
            txtSoLuongDonHang.Enabled = isCheck;
        }

        private void RefreshTextBox()
        {
            txtMaDh.Text = "";
            //txtMaNv.Text = "";
            //txtNgayDh.Text = "";
            txtSoLuongDonHang.Text = "";
            cboMaCC.Text = "";
            cboMaSp_1.Text = "";
            cboTenCC.Text = "";
            cboMaSp_2.Text = "";
            txtSoLuongDonHang.Text = "";

        }

        private void HienThiDonHang()
        {
            int i = 0;
            dgvDonDatHang.Rows.Clear();
            List<DonDatHang> dhlist = dhbll.GetAllDataDonDh();
            foreach (DonDatHang dhs in dhlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDonDatHang);
                row.Cells[0].Value = i+1;
                row.Cells[1].Value = dhs.MaDh;
                row.Cells[2].Value = dhs.MaNv;
                row.Cells[3].Value = dhs.MaCc;
                row.Cells[4].Value = dhs.MaSp;
                row.Cells[5].Value = dhs.SlDh;
                row.Cells[6].Value = dhs.NgayDh;

                dgvDonDatHang.Rows.Add(row);
                ++i;
            }
            cboMaCC.DataSource = dhbll.LoadComboBoxMacc();
            cboMaSp_1.DataSource = dhbll.ShowDataMaSp();
            txtMaNv.Text = UserInfo.Id.ToString();
            //string datetime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            //txtNgayDh.Text = datetime;
        }

        private void uc_DonDatHang_Load(object sender, EventArgs e)
        {
            HienThiDonHang();
            EnableHome();
            TurnOffTextBox(false);
            dgvDonDatHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDonDatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonDatHang.AllowUserToAddRows = false;
            dgvDonDatHang.Columns[0].Width = 30;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            TurnOffTextBox(true);
            RefreshTextBox();
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnPrint.Enabled = false;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isCheck == 0)
            {
                try
                {
                    dh.MaNv = int.Parse(txtMaNv.Text);
                    dh.MaCc = int.Parse(cboMaCC.Text);
                    dh.MaSp = int.Parse(cboMaSp_1.Text);
                    dh.SlDh = int.Parse(txtSoLuongDonHang.Text);
                    //dh.NgayDh = DateTime.Now;
                    dh.NgayDh = DateTime.Parse(dtmNgayDat.Value.ToLongDateString());

                    bool result = dhbll.InsertDonDatHang(dh);

                    if (result)
                    {
                        DialogResult dr = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            RefreshTextBox();
                            TurnOffTextBox(false);
                            EnableHome();
                            HienThiDonHang();
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
                    dh.MaDh = int.Parse(txtMaDh.Text);
                    dh.MaNv = int.Parse(txtMaNv.Text);
                    dh.MaCc = int.Parse(cboMaCC.Text);
                    dh.MaSp = int.Parse(cboMaSp_1.Text);
                    dh.SlDh = int.Parse(txtSoLuongDonHang.Text);
                    //dh.NgayDh = DateTime.Parse(txtNgayDh.Text);
                    dh.NgayDh = DateTime.Parse(dtmNgayDat.Value.ToLongDateString());
                    //dh.NgayDh = DateTime.Now;
                    bool result = dhbll.EditDonDatHang(dh);

                    if (result)
                    {
                        DialogResult dr = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            btnDelete.Enabled = true;
                            HienThiDonHang();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Edit Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhân xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    dh.MaDh = int.Parse(txtMaDh.Text);

                    bool result = dhbll.DeleteDonDatHang(dh);

                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {
                            RefreshTextBox();
                            HienThiDonHang();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frm_ReportDonDh frmReportDoDh = new frm_ReportDonDh();
            frmReportDoDh.ShowDialog();

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

        private void dgvDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaDh.Text = dgvDonDatHang.CurrentRow.Cells[1].Value.ToString();
            txtMaNv.Text = dgvDonDatHang.CurrentRow.Cells[2].Value.ToString();
            cboMaCC.Text = dgvDonDatHang.CurrentRow.Cells[3].Value.ToString();
            cboMaSp_1.Text = dgvDonDatHang.CurrentRow.Cells[4].Value.ToString();
            txtSoLuongDonHang.Text = dgvDonDatHang.CurrentRow.Cells[5].Value.ToString();
            txtNgayDh.Text = dgvDonDatHang.CurrentRow.Cells[6].Value.ToString();
            //txtNgayDh.Text = dgvDonDatHang.CurrentRow.Cells[5].Value.ToString();
        }

        private void cboMaSp_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSp_1.SelectedIndex == -1)
            {
                return;
            }
            dh.MaSp = int.Parse(cboMaSp_1.Text);
            cboMaSp_2.DataSource = dhbll.HienThiTenSpTheoMaSp(dh);
        }

        private void cboMaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaCC.SelectedIndex == -1)
            {
                return;
            }
            dh.MaCc = int.Parse(cboMaCC.Text);
            cboTenCC.DataSource = dhbll.ShowTenCCFlowMaCC(dh);
        }

        




        private void cboLoading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoading.SelectedIndex == -1)
            {
                return;
            }

            dh.Search = cboLoading.Text;
            cboSearch.Items.Clear();
            List<DonDatHang> dhlist = dhbll.LocDanhSanhSachDonDatHang(dh);

            if (cboLoading.Text == "Mã Đơn Hàng")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaDh);
                }
            }
            else if (cboLoading.Text == "Mã Nhân Viên")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaNv);
                }
            }
            else if (cboLoading.Text == "Mã Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaSp);
                }
            }
            else if (cboLoading.Text == "Mã Cung Cấp")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.MaCc);
                }
            }
            else if (cboLoading.Text == "Số Lượng Đặt")
            {
                cboSearch.Text = "";
                foreach (DonDatHang dhs in dhlist)
                {
                    cboSearch.Items.Add(dhs.SlDh);
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
                HienThiDonHang();
                return;
            }
            dh.Search = cboSearch.Text;
            List<DonDatHang> dhlist = dhbll.TimKiemDonDatHang(dh);
            dgvDonDatHang.Rows.Clear();

            foreach (DonDatHang dhs in dhlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDonDatHang);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = dhs.MaDh;
                row.Cells[2].Value = dhs.MaNv;
                row.Cells[3].Value = dhs.MaCc;
                row.Cells[4].Value = dhs.MaSp;
                row.Cells[5].Value = dhs.SlDh;
                row.Cells[6].Value = dhs.NgayDh;

                dgvDonDatHang.Rows.Add(row);
                ++i;
            }
        }
    }
}
