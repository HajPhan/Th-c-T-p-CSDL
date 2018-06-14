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
using GUI.Form_Ui.Form_Report;

namespace GUI
{
    public partial class uc_SanPham : UserControl
    {

        SanPham sp = new SanPham();
        SanPhamBLL spbll = new SanPhamBLL();
        int isCheck = 0;

        public uc_SanPham()
        {
            InitializeComponent();
        }

        public void EnableHome()
        {
            btnInsert.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnPrint.Enabled = true;
            btnRefresh.Enabled = true;
        }

        private void TurnOffTextBox(bool isCheck)
        {
            txtMaSp.Enabled = false;
            txtAmThanh.Enabled = isCheck;
            txtCarMh.Enabled = isCheck;
            txtCongKetNoi.Enabled = isCheck;
            txtCpu.Enabled = isCheck;
            txtGiaoTiep.Enabled = isCheck;
            txtGiaThanh.Enabled = isCheck;
            txtHeDieuHanh.Enabled = isCheck;
            txtManHinh.Enabled = isCheck;
            txtPin.Enabled = isCheck;
            txtTenSp.Enabled = isCheck;
            txtTrongLuong.Enabled = isCheck;
            txtWebcam.Enabled = isCheck;
            cboBaoHanh_1.Enabled = isCheck;
            cboBaoHanh_2.Enabled = isCheck;
            cboDiaQuang.Enabled = isCheck;
            cboMaLoai.Enabled = isCheck;
            cboMaSx.Enabled = isCheck;
            cboOcung_1.Enabled = isCheck;
            cboOcung_2.Enabled = isCheck;
            cboOcung_3.Enabled = isCheck;
            cboRam_1.Enabled = isCheck;
            cboRam_2.Enabled = isCheck;
            cboRam_3.Enabled = isCheck;
            cboTenLoai.Enabled = isCheck;
            cboTenSx.Enabled = isCheck;
            cboTrongLuong.Enabled = isCheck;


        }

        private void RefreshTextBox()
        {
            txtAmThanh.Text = "";
            txtCarMh.Text = "";
            txtCongKetNoi.Text = "";
            txtCpu.Text = "";
            txtGiaoTiep.Text = "";
            txtGiaThanh.Text = "";
            txtHeDieuHanh.Text = "";
            txtManHinh.Text = "";
            txtMaSp.Text = "";
            txtPin.Text = "";
            txtTenSp.Text = "";
            txtTrongLuong.Text = "";
            txtWebcam.Text = "";
            cboBaoHanh_1.Text = "";
            cboBaoHanh_2.Text = "";
            cboDiaQuang.Text = "";
            cboMaLoai.Text = "";
            cboMaSx.Text = "";
            cboOcung_1.Text = "";
            cboOcung_2.Text = "";
            cboOcung_3.Text = "";
            cboRam_1.Text = "";
            cboRam_2.Text = "";
            cboRam_3.Text = "";
            cboTenLoai.Text = "";
            cboTenSx.Text = "";
            cboTrongLuong.Text = "";
        }

        private void HienThiDanhSachSanPham()
        {
            int i = 0;
            dgvSanPham.Rows.Clear();
            List<SanPham> splist = spbll.GetAllListSanPham();
            foreach (SanPham sps in splist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = i+1;
                row.Cells[1].Value = sps.MaSp;
                row.Cells[2].Value = sps.TenSp;
                row.Cells[3].Value = sps.MaSx;
                row.Cells[4].Value = sps.MaLoai;
                row.Cells[5].Value = sps.GiaThanhs;
                row.Cells[6].Value = sps.Cpu;
                row.Cells[7].Value = sps.Ram;
                row.Cells[8].Value = sps.Ocung;
                row.Cells[9].Value = sps.ManHinh;
                row.Cells[10].Value = sps.CardManHinh;
                row.Cells[11].Value = sps.CongKetNoi;
                row.Cells[12].Value = sps.Hdt;
                row.Cells[13].Value = sps.AmThanh;
                row.Cells[14].Value = sps.DiaQuang;
                row.Cells[15].Value = sps.GiaoTiepMang;
                row.Cells[16].Value = sps.WebCam;
                row.Cells[17].Value = sps.Pin;
                row.Cells[18].Value = sps.TrongLuong;
                row.Cells[19].Value = sps.BaoHanh;
                
                dgvSanPham.Rows.Add(row);
                ++i;
            }
            cboMaLoai.DataSource = spbll.ShowAllMaLoaiSp();
            cboMaSx.DataSource = spbll.ShowAllMaSx();
            //cboSearch.DataSource = spbll.ShowAllMaSp();
            cboTenSx.DataSource = spbll.ShowAllTenNhaSx();
            cboTenLoai.DataSource = spbll.ShowAllTenLoaiSp();
        }

        private void uc_SanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            EnableHome();
            TurnOffTextBox(false);
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.Columns[0].Width = 30;
            dgvSanPham.Columns[1].Width = 150;
            dgvSanPham.Columns[2].Width = 150;
            dgvSanPham.Columns[3].Width = 150;
            dgvSanPham.Columns[10].Width = 150;
            dgvSanPham.Columns[11].Width = 150;
            dgvSanPham.Columns[12].Width = 150;
            dgvSanPham.Columns[15].Width = 150;
            dgvSanPham.Columns[18].Width = 150;

        }

        private void cboOcung_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboRam_2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            btnCancel.Enabled = true;
            btnPrint.Enabled = false;
            btnRefresh.Enabled = true;
        }

        // Button Delete
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            try
            {
                sp.MaSp = int.Parse(txtMaSp.Text);
                bool result = spbll.DeleteSanPham(sp);

                if (result)
                {
                    DialogResult dialogResultDelete = MessageBox.Show("Delete Successful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResultDelete == DialogResult.OK)
                    {
                        RefreshTextBox();
                        EnableHome();
                        HienThiDanhSachSanPham();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Delete Error!" + "\n\n\t" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Edit
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            TurnOffTextBox(true);

            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnPrint.Enabled = false;
            btnRefresh.Enabled = true;
        }

        // Button Save
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (isCheck == 0)
            {
                try
                {
                    sp.AmThanh = txtAmThanh.Text;
                    sp.CardManHinh = txtCarMh.Text;
                    sp.CongKetNoi = txtCongKetNoi.Text;
                    sp.Cpu = txtCpu.Text;
                    sp.GiaoTiepMang = txtGiaoTiep.Text;
                    sp.GiaThanh = float.Parse(txtGiaThanh.Text);
                    sp.Hdt = txtHeDieuHanh.Text;
                    sp.ManHinh = txtManHinh.Text;
                    sp.Pin = txtPin.Text;
                    sp.TenSp = txtTenSp.Text;
                    sp.TrongLuong = txtTrongLuong.Text;
                    sp.WebCam = txtWebcam.Text;
                    sp.BaoHanh = cboBaoHanh_1.Text + " " + cboBaoHanh_2.Text;
                    sp.DiaQuang = cboDiaQuang.Text;
                    sp.MaLoai = int.Parse(cboMaLoai.Text);
                    sp.MaSx = int.Parse(cboMaSx.Text);
                    sp.Ocung = cboOcung_1.Text + " " + cboOcung_2.Text + " " + cboOcung_3.Text;
                    sp.Ram = cboRam_1.Text + " " + cboRam_2.Text + " " + cboRam_3.Text;
                    sp.TenLoai = cboTenLoai.Text;
                    sp.TenSx = cboTenSx.Text;
                    sp.TrongLuong = txtTrongLuong.Text + " " + cboTrongLuong.Text;
                    sp.NgayNhap = DateTime.Now;

                    bool result = spbll.InserSanPham(sp);
                    if (result)
                    {
                        DialogResult dialogResultInsert = MessageBox.Show("Insert Sucessful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultInsert == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            RefreshTextBox();
                            HienThiDanhSachSanPham();
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
                    sp.AmThanh = txtAmThanh.Text;
                    sp.CardManHinh = txtCarMh.Text;
                    sp.CongKetNoi = txtCongKetNoi.Text;
                    sp.Cpu = txtCpu.Text;
                    sp.GiaoTiepMang = txtGiaoTiep.Text;
                    sp.GiaThanh = float.Parse(txtGiaThanh.Text);
                    sp.Hdt = txtHeDieuHanh.Text;
                    sp.ManHinh = txtManHinh.Text;
                    sp.MaSp = int.Parse(txtMaSp.Text);
                    sp.Pin = txtPin.Text;
                    sp.TenSp = txtTenSp.Text;
                    sp.TrongLuong = txtTrongLuong.Text;
                    sp.WebCam = txtWebcam.Text;
                    sp.BaoHanh = cboBaoHanh_1.Text + " " + cboBaoHanh_2.Text;
                    sp.DiaQuang = cboDiaQuang.Text;
                    sp.MaLoai = int.Parse(cboMaLoai.Text);
                    sp.MaSx = int.Parse(cboMaSx.Text);
                    sp.Ocung = cboOcung_1.Text + " " + cboOcung_2.Text + " " + cboOcung_3.Text;
                    sp.Ram = cboRam_1.Text + " " + cboRam_2.Text + " " + cboRam_3.Text;
                    sp.TenLoai = cboTenLoai.Text;
                    sp.TenSx = cboTenSx.Text;
                    sp.TrongLuong = txtTrongLuong.Text + " " + cboTrongLuong.Text;
                    bool result = spbll.EditSanPham(sp);
                    if (result)
                    {
                        DialogResult dialogResultInsert = MessageBox.Show("Insert Sucessful!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResultInsert == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            btnDelete.Enabled = true;
                            HienThiDanhSachSanPham();
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
            frm_ReportSanPham frmReportSanPham = new frm_ReportSanPham();
            frmReportSanPham.ShowDialog();
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

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnDelete.Enabled = true;
                txtMaSp.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtTenSp.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                cboMaSx.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
                cboMaLoai.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
                txtGiaThanh.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
                txtCpu.Text = dgvSanPham.CurrentRow.Cells[6].Value.ToString();

                string strRam = dgvSanPham.CurrentRow.Cells[7].Value.ToString();
                string[] arrListRam = strRam.Split(' ');
                cboRam_1.Text = arrListRam[0].ToString();
                cboRam_2.Text = arrListRam[1].ToString();
                cboRam_3.Text = arrListRam[2].ToString();

                string strOcung = dgvSanPham.CurrentRow.Cells[8].Value.ToString();
                string[] arrayListOcung = strOcung.Split(' ');
                cboOcung_1.Text = arrayListOcung[0].ToString();
                cboOcung_2.Text = arrayListOcung[1].ToString();
                cboOcung_3.Text = arrayListOcung[2].ToString();

                txtManHinh.Text = dgvSanPham.CurrentRow.Cells[9].Value.ToString();
                txtCarMh.Text = dgvSanPham.CurrentRow.Cells[10].Value.ToString();
                txtCongKetNoi.Text = dgvSanPham.CurrentRow.Cells[11].Value.ToString();
                txtHeDieuHanh.Text = dgvSanPham.CurrentRow.Cells[12].Value.ToString();
                txtAmThanh.Text = dgvSanPham.CurrentRow.Cells[13].Value.ToString();
                cboDiaQuang.Text = dgvSanPham.CurrentRow.Cells[14].Value.ToString();
                txtGiaoTiep.Text = dgvSanPham.CurrentRow.Cells[15].Value.ToString();
                txtWebcam.Text = dgvSanPham.CurrentRow.Cells[16].Value.ToString();
                txtPin.Text = dgvSanPham.CurrentRow.Cells[17].Value.ToString();

                string strTrongLuong = dgvSanPham.CurrentRow.Cells[18].Value.ToString();
                string[] strListTrongLuong = strTrongLuong.Split(' ');
                txtTrongLuong.Text = strListTrongLuong[0].ToString();
                cboTrongLuong.Text = strListTrongLuong[1].ToString();

                string strBaoHanh = dgvSanPham.CurrentRow.Cells[19].Value.ToString();
                string[] strListbaohanh = strBaoHanh.Split(' ');
                cboBaoHanh_1.Text = strListbaohanh[0].ToString();
                cboBaoHanh_2.Text = strListbaohanh[1].ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Dat Grid View Loi" + ex.Message);
            }


        }

        private void cboMaSx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSx.SelectedIndex == -1)
            {
                return;
            }
            sp.MaSx = int.Parse(cboMaSx.Text);
            cboTenSx.DataSource = spbll.ShowNameNhaSxFlow(sp);
        }

        private void cboTenSx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTenSx.SelectedIndex == -1)
            //{
            //    return;
            //}
            //sp.TenSx = cboTenSx.Text;
            //cboMaSx.DataSource = spbll.ShowIdNhaSxFlow(sp);
        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaLoai.SelectedIndex == -1)
            {
                return;
            }
            sp.MaLoai = int.Parse(cboMaLoai.Text);
            cboTenLoai.DataSource = spbll.ShowNameLoaiSpFlow(sp);
        }

        private void cboTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboTenLoai.SelectedIndex == -1)
            //{
            //    return;
            //}
            //sp.TenLoai = cboTenLoai.Text;
            //cboMaLoai.DataSource = spbll.ShowIdLoaiSanPhamFlow(sp);
        }

        private void cboLoading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoading.SelectedIndex == -1)
            {
                return;
            }
            
            sp.Search = cboLoading.Text;
            cboSearch.Items.Clear();
            List<SanPham> splist = spbll.LocDanhSachSanPham(sp);
            if (cboLoading.Text == "Mã Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.MaSp);
                }
            }
            else if (cboLoading.Text == "Mã Sản Xuất")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.MaSx);
                }
            }
            else if (cboLoading.Text == "Mã Loại")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.MaLoai);
                }
            }
            else if (cboLoading.Text == "Tên Sản Phẩm")
            {
                cboSearch.Text = "";
                foreach (SanPham sps in splist)
                {
                    cboSearch.Items.Add(sps.TenSp);
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
                HienThiDanhSachSanPham();
                return;
            }
            sp.Search = cboSearch.Text;
            List<SanPham> splist = spbll.TimKiemSanPham(sp);
            dgvSanPham.Rows.Clear();

            foreach (SanPham sps in splist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvSanPham);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = sps.MaSp;
                row.Cells[2].Value = sps.TenSp;
                row.Cells[3].Value = sps.MaSx;
                row.Cells[4].Value = sps.MaLoai;
                row.Cells[5].Value = sps.GiaThanhs;
                row.Cells[6].Value = sps.Cpu;
                row.Cells[7].Value = sps.Ram;
                row.Cells[8].Value = sps.Ocung;
                row.Cells[9].Value = sps.ManHinh;
                row.Cells[10].Value = sps.CardManHinh;
                row.Cells[11].Value = sps.CongKetNoi;
                row.Cells[12].Value = sps.Hdt;
                row.Cells[13].Value = sps.AmThanh;
                row.Cells[14].Value = sps.DiaQuang;
                row.Cells[15].Value = sps.GiaoTiepMang;
                row.Cells[16].Value = sps.WebCam;
                row.Cells[17].Value = sps.Pin;
                row.Cells[18].Value = sps.TrongLuong;
                row.Cells[19].Value = sps.BaoHanh;

                dgvSanPham.Rows.Add(row);
                ++i;
            }
        }
    }
}
