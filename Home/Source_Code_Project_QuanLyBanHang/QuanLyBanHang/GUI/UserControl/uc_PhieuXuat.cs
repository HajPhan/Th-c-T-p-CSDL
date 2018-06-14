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
    public partial class uc_PhieuXuat : UserControl
    {

        PhieuXuatHang px = new PhieuXuatHang();
        PhieuXuatBLL pxbll = new PhieuXuatBLL();
        int isCheck = 0;

        public uc_PhieuXuat()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void EnableHome(bool ischeck)
        {
            btnInsert.Enabled = ischeck;
            btnEdit.Enabled = ischeck;
            btnDelete.Enabled = !ischeck;
            btnSave.Enabled = !ischeck;
            btnPrint.Enabled = ischeck;
            btnCancel.Enabled = !ischeck;
            btnRefresh.Enabled = true;
        }

        private void TurnOnTextBox(bool isCheck)
        {
            txtMaNv.Enabled = false;
            txtMaPx.Enabled = false;
            txtPhanTram.Enabled = isCheck;
            cboMaKh.Enabled = isCheck;
            cboMaSp.Enabled = isCheck;
            cboSoLuongXuat.Enabled = isCheck;
            cboTenKh.Enabled = isCheck;
            cboTenSp.Enabled = isCheck;
            dtmNgayXuatHang.Enabled = true;
            //txtGiaSanPham.Enabled = isCheck;
            //txtKhuyenMai.Enabled = isCheck;
            //txtTienKhachDua.Enabled = isCheck;
            //txtTienThua.Enabled = isCheck;
            //txtTongTien.Enabled = isCheck;

        }

        private void RefreshTextBox()
        {
            //txtMaNv.Text = "";
            txtMaPx.Text = "";
            txtPhanTram.Text = "";
            cboMaKh.Text = "";
            cboMaSp.Text = "";
            cboSoLuongXuat.Text = "";
            cboTenKh.Text = "";
            cboTenSp.Text = "";
            dtmNgayXuatHang.Text = "";
            txtTongTien.Text = "";
        }

        private void HienThiDanhSanhSachPhieuXuat()
        {
            int i = 0;
            dgvPhieuXuat.Rows.Clear();
            List<PhieuXuatHang> pxlist = pxbll.GetAllListPhieuXuat();
            foreach (PhieuXuatHang pxs in pxlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPhieuXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = pxs.MaPx;
                row.Cells[2].Value = pxs.MaNv;
                row.Cells[3].Value = pxs.MaKh;
                row.Cells[4].Value = pxs.NgayXuat;
                row.Cells[5].Value = pxs.MaSp;
                row.Cells[6].Value = pxs.Slx;
                row.Cells[7].Value = pxs.PhanTram;
                row.Cells[8].Value = pxs.ThanhTiens;

                dgvPhieuXuat.Rows.Add(row);
                ++i;
            }
            cboMaSp.DataSource = pxbll.ShowMaSanPham();
            cboMaKh.DataSource = pxbll.ShowMaKhachHang();
            cboSoLuongXuat.DataSource = pxbll.ShowSoLuongDatHang();
            txtMaNv.Text = UserInfo.Id.ToString();
        }





        private void uc_PhieuXuat_Load(object sender, EventArgs e)
        {
            HienThiDanhSanhSachPhieuXuat();
            EnableHome(true);
            TurnOnTextBox(false);
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuXuat.AllowUserToAddRows = false;
            dgvPhieuXuat.Columns[2].Width = 125;
            dgvPhieuXuat.Columns[0].Width = 30;
            dgvPhieuXuat.Columns[8].DefaultCellStyle.Format = "c";

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;
            TurnOnTextBox(true);
            RefreshTextBox();
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
                    px.MaNv = int.Parse(txtMaNv.Text);
                    px.MaKh = int.Parse(cboMaKh.Text);
                    px.NgayXuat = DateTime.Parse(dtmNgayXuatHang.Value.ToShortDateString());
                    px.MaSp = int.Parse(cboMaSp.Text);

                    int n = 0;
                    if (cboSoLuongXuat.Text != "")
                    {
                        if (int.TryParse(cboSoLuongXuat.Text, out n))
                        {
                            int Slx = int.Parse(cboSoLuongXuat.Text);
                            if (Slx > 0)
                            {
                                px.Slx = int.Parse(cboSoLuongXuat.Text);
                            }
                            else
                            {
                                MessageBox.Show("Số Lượng Xuất phải > 0!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Giá trị Số Lượng Xuất phải là số!");
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Giá trị của trường Số Lượng Xuất không được để trống!");
                        return;
                    }

                    if (txtPhanTram.Text != "")
                    {
                        int phanTram = 0;
                        if (int.TryParse(this.txtPhanTram.Text, out phanTram))
                        {
                            phanTram = int.Parse(txtPhanTram.Text);
                            if (phanTram > 0)
                            {
                                px.PhanTram = phanTram;
                            }
                            else if (phanTram == 0)
                            {
                                px.PhanTram = 0;
                            }
                            else
                            {
                                MessageBox.Show("Giá trị của Phẩm Trăm phải >= 0!");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Giá trị của Phẩn Trăm phải là số!");
                            return;
                        }
                    }
                    else
                    {
                        px.PhanTram = 0;
                    }


                    bool result = pxbll.InsertPhieuXuatHang(px);

                    if (result)
                    {
                        EnableHome(true);
                        RefreshTextBox();
                        TurnOnTextBox(false);
                        HienThiDanhSanhSachPhieuXuat();
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
                    px.MaPx = int.Parse(txtMaPx.Text);
                    px.MaNv = int.Parse(txtMaNv.Text);
                    px.MaKh = int.Parse(cboMaKh.Text);
                    px.NgayXuat = DateTime.Parse(dtmNgayXuatHang.Value.ToShortDateString());
                    px.MaSp = int.Parse(cboMaSp.Text);
                    px.Slx = int.Parse(cboSoLuongXuat.Text);
                    px.PhanTram = float.Parse(txtPhanTram.Text);
                    px.ThanhTiens = double.Parse(lbThanhTien.Text);

                    bool result = pxbll.EditPhieuXuat(px);

                    if (result)
                    {
                        EnableHome(true);
                        TurnOnTextBox(false);
                        btnDelete.Enabled = true;
                        HienThiDanhSanhSachPhieuXuat();
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
            TurnOnTextBox(true);
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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhân xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    px.MaPx = int.Parse(txtMaPx.Text);

                    bool result = pxbll.DeletePhieuXuat(px);

                    if (result)
                    {
                        DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultDelete == DialogResult.OK)
                        {
                            RefreshTextBox();
                            HienThiDanhSanhSachPhieuXuat();
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
            TurnOnTextBox(false);
            frm_ReportPhieuXuat frmPhieuXuat = new frm_ReportPhieuXuat();
            frmPhieuXuat.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableHome(true);
            TurnOnTextBox(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
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

        private void cboMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSp.SelectedIndex == -1)
            {
                return;
            }
            px.MaSp = int.Parse(cboMaSp.Text);
            cboTenSp.DataSource = pxbll.HienThiTenSpTheoMaSp(px);
        }

        private void dtmNgayXuatHang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboMaDh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaDh.SelectedIndex == -1)
            //{
            //    return;
            //}
            //px.MaDh = int.Parse(cboMaDh.Text);
            //List<PhieuXuatHang> pxlist = pxbll.HienThiThongTinPhieuXuatTheoMaDh(px);
            //foreach (PhieuXuatHang pxs in pxlist)
            //{
            //    cboMaSp.Text = pxs.MaSp.ToString();
            //    cboSoLuongXuat.Text = pxs.Slx.ToString();
            //}
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                isCheck = 1;
                btnDelete.Enabled = true;
                txtMaPx.Text = dgvPhieuXuat.CurrentRow.Cells[1].Value.ToString();
                txtMaNv.Text = dgvPhieuXuat.CurrentRow.Cells[2].Value.ToString();
                cboMaKh.Text = dgvPhieuXuat.CurrentRow.Cells[3].Value.ToString();
                dtmNgayXuatHang.Text = dgvPhieuXuat.CurrentRow.Cells[4].Value.ToString();
                cboMaSp.Text = dgvPhieuXuat.CurrentRow.Cells[5].Value.ToString();
                cboSoLuongXuat.Text = dgvPhieuXuat.CurrentRow.Cells[6].Value.ToString();
                txtPhanTram.Text = dgvPhieuXuat.CurrentRow.Cells[7].Value.ToString();

                PhieuXuatHang.MaPxKh = int.Parse(txtMaPx.Text);
                PhieuXuatHang.NgayXuatKh = DateTime.Parse(dtmNgayXuatHang.Text);

                txtTienThua.Text = PhieuXuatHang.MaPxKh.ToString();
                double thanhTien = double.Parse(dgvPhieuXuat.CurrentRow.Cells[8].Value.ToString());
                lbThanhTien.Text = thanhTien.ToString("0,00.##");
                txtTongTien.Text = thanhTien.ToString("0,00.##");

                px.MaSp = int.Parse(cboMaSp.Text);
                
                cboGiaSanPham.DataSource = pxbll.SelectGiaThanhSanPham(px);
                double giaSp = double.Parse(cboGiaSanPham.Text);
                cboGiaSanPham.Text = giaSp.ToString("0,00.##");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void cboTienKhachDua_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTienKhachDua.SelectedIndex == -1)
            //{
            //    return;
            //}
            //px.TienKhachDua = double.Parse(cboTienKhachDua.Text);
            //px.MaSp = int.Parse(txtMaPx.Text);
            //cboTienThua.DataSource = pxbll.LocTienThua(px);
        }

        private void cboTienKhachDua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            //txtTienThua.Text = txtTongTien.Text + txtTienKhachDua.Text;
            if (txtTienKhachDua.Text == "")
            {
                return;
            }
            try
            {
                double money = (double.Parse(txtTongTien.Text) - double.Parse(txtTienKhachDua.Text));

                txtTienThua.Text = money.ToString("0,00.##");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txtTienThua_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLoading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoading.SelectedIndex == -1)
            {
                return;
            }

            px.Search = cboLoading.Text;
            cboSearch.Items.Clear();
            List<PhieuXuatHang> pxlist = pxbll.LocDanhSachPhieuXuatHang(px);

            if (cboLoading.Text == "Mã Phiếu Xuất")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaPx);
                }
            }
            else if (cboLoading.Text == "Mã Nhân Viên")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaNv);
                }
            }
            else if (cboLoading.Text == "Mã Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaSp);
                }
            }
            else if (cboLoading.Text == "Mã Khách Hàng")
            {
                cboSearch.Text = "";
                foreach (PhieuXuatHang pxs in pxlist)
                {
                    cboSearch.Items.Add(pxs.MaKh);
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
                HienThiDanhSanhSachPhieuXuat();
                return;
            }
            px.Search = cboSearch.Text;
            List<PhieuXuatHang> pxlist = pxbll.TimKiemPhieuXuatHang(px);
            dgvPhieuXuat.Rows.Clear();

            foreach (PhieuXuatHang pxs in pxlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvPhieuXuat);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = pxs.MaPx;
                row.Cells[2].Value = pxs.MaNv;
                row.Cells[3].Value = pxs.MaKh;
                row.Cells[4].Value = pxs.NgayXuat;
                row.Cells[5].Value = pxs.MaSp;
                row.Cells[6].Value = pxs.Slx;
                row.Cells[7].Value = pxs.PhanTram;
                row.Cells[8].Value = pxs.ThanhTiens;

                dgvPhieuXuat.Rows.Add(row);
                ++i;
            }
        }

        private void cboSoLuongXuat_Validating(object sender, CancelEventArgs e)
        {
            int n = 0;
            if (cboSoLuongXuat.Text == "")
            {
                MessageBox.Show("Số lượng xuất không được để trống");
                e.Cancel = true;
            }
            else if (cboSoLuongXuat.Text != "")
            {
                if (int.TryParse(cboSoLuongXuat.Text, out n))
                {
                    int Slx = int.Parse(cboSoLuongXuat.Text);
                    if (Slx > 0)
                    {
                        px.Slx = int.Parse(cboSoLuongXuat.Text);
                    }
                    else
                    {
                        MessageBox.Show("Số Lượng Xuất phải > 0!");
                        e.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị Số Lượng Xuất phải là số!");
                    e.Cancel = true;
                }

            }
            else
            {
                MessageBox.Show("Giá trị của trường Số Lượng Xuất không được để trống!");
                e.Cancel = true;
            }

        }

        private void txtPhanTram_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void txtPhanTram_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhanTram.Text != "")
            {
                int phanTram = 0;
                if (int.TryParse(this.txtPhanTram.Text, out phanTram))
                {
                    phanTram = int.Parse(txtPhanTram.Text);
                    if (phanTram > 0)
                    {
                        px.PhanTram = phanTram;
                    }
                    else if (phanTram == 0)
                    {
                        px.PhanTram = 0;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị của Phẩm Trăm phải >= 0!");
                        e.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị của Phẩn Trăm phải là số!");
                    e.Cancel = true;
                }
            }
            else
            {
                px.PhanTram = 0;
            }
        }
    }
}
