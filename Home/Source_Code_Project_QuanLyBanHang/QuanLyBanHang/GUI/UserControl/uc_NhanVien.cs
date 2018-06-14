using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;
using BLL;

namespace GUI
{
    public partial class uc_NhanVien : UserControl
    {

        NhanVien nv = new NhanVien();
        NhanVienBLL nvbll = new NhanVienBLL();
        int isCheck = 0;

        public uc_NhanVien()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

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
            txtDiaChi.Enabled = isCheck;
            txtHoTen.Enabled = isCheck;
            txtMail.Enabled = isCheck;
            txtMaNv.Enabled = false;
            txtSdt.Enabled = isCheck;
            cboGioiTinh.Enabled = isCheck;
            dtmNgayLam.Enabled = isCheck;
            dtmNgaySinh.Enabled = isCheck;
        }

        private void uc_NhanVien_Load(object sender, EventArgs e)
        {
            //Hiển Thị Danh Sách
            HienThiDSNV();
            //
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AllowUserToAddRows = false;
            btnDelete.Enabled = false;
            dgvNhanVien.Columns[0].Width = 30;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // Hiển Thị Danh Sách Nhân Viên
        private void HienThiDSNV()
        {
            int i = 0;
            dgvNhanVien.Rows.Clear();
            TurnOffTextBox(false);
            List<NhanVien> nvlist = nvbll.GetAllLISTEmployee();
            foreach (NhanVien nvs in nvlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhanVien);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nvs.MaNv;
                row.Cells[2].Value = nvs.Hoten;
                row.Cells[3].Value = nvs.NgaySinh;
                row.Cells[4].Value = nvs.GioTinh;
                row.Cells[5].Value = nvs.Sdt;
                row.Cells[6].Value = nvs.Mail;
                row.Cells[7].Value = nvs.DiaChi;
                row.Cells[8].Value = nvs.NgayLam;
                //row.Cells[0].Value = nvs.MaNv;
                //row.Cells[1].Value = nvs.Hoten;
                //row.Cells[2].Value = nvs.NgaySinh;
                //row.Cells[3].Value = nvs.GioTinh;
                //row.Cells[4].Value = nvs.Sdt;
                //row.Cells[5].Value = nvs.Mail;
                //row.Cells[6].Value = nvs.DiaChi;
                //row.Cells[7].Value = nvs.NgayLam;
                //row.Cells[8].Value = nvs.Image_01;
                dgvNhanVien.Rows.Add(row);
                ++i;
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            #region
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "png file(*.png)|*.png|jpg file(*.jpg)|*.jpg|All file(*.*)|*.*";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    //nv.imagesLocation = openFileDialog.FileName.ToString();
            //    nv.Image_01 = openFileDialog.FileName.ToString();
            //    //picImages.ImageLocation = nv.imagesLocation;
            //    picImages.ImageLocation = nv.Image_01;
            //}
            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isCheck == 0)
            {
                try
                {
                    string sCommobox = this.cboGioiTinh.SelectedIndex.ToString();
                    nv.Hoten = txtHoTen.Text;
                    nv.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                    if (cboGioiTinh.SelectedIndex == 0)
                    {
                        nv.GioTinh = cboGioiTinh.Text;
                    }
                    else if (cboGioiTinh.SelectedIndex == 1)
                    {
                        nv.GioTinh = cboGioiTinh.Text;
                    }
                    else if (cboGioiTinh.SelectedIndex == 2)
                    {
                        nv.GioTinh = cboGioiTinh.Text;
                    }

                    int n = 0;

                    if (int.TryParse(txtSdt.Text, out n))
                    {
                        nv.Sdt = int.Parse(txtSdt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Sdt phải là số!");
                        return;
                    }

                    nv.Mail = txtMail.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.NgayLam = DateTime.Parse(dtmNgayLam.Value.ToShortDateString());


                    NhanVienBLL nvbll = new NhanVienBLL();
                    bool result = nvbll.InserNhanVien(nv);


                    if (result)
                    {
                        DialogResult dialogResult_01 = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK);
                        if (dialogResult_01 == DialogResult.OK)
                        {
                            EnableHome();
                            TurnOffTextBox(false);
                            RefreshTextBox();
                            HienThiDSNV();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Insert !" + ex.Message);
                }
            }
            else if (isCheck == 1)
            {
                try
                {
                    //string sCommobox = this.cboGioTinh.SelectedIndex.ToString();

                    nv.MaNv = int.Parse(txtMaNv.Text);
                    nv.Hoten = txtHoTen.Text;
                    nv.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());
                    if (cboGioiTinh.SelectedIndex == -1)
                    {
                        //cboGioiTinh.Text = UserInfo.GioiTinh.ToString().Trim();
                        if (cboGioiTinh.Text.Trim() == "nam")
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "nữ")
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "other")
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                    }
                    else
                    {
                        if (cboGioiTinh.Text.Trim() == "nam")
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "nữ")
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                        else if (cboGioiTinh.Text.Trim() == "other")
                        {
                            nv.GioTinh = cboGioiTinh.Text;
                        }
                    }

                    int n = 0;

                    if(int.TryParse(txtSdt.Text,out n))
                    {
                        nv.Sdt = int.Parse(txtSdt.Text);
                    }
                    else
                    {
                        MessageBox.Show("Sdt phải là số!");
                        return;
                    }
                    nv.Mail = txtMail.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.NgayLam = DateTime.Parse(dtmNgayLam.Value.ToShortDateString());

                    bool result = nvbll.UpdateNhanVien(nv);

                    if (result)
                    {
                        DialogResult dialogResult_01 = MessageBox.Show("Edit Success !", "Thông báo", MessageBoxButtons.OK);
                        if (dialogResult_01 == DialogResult.OK)
                        {
                            EnableHome();
                            btnDelete.Enabled = true;
                            TurnOffTextBox(false);
                            HienThiDSNV();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Edit !" + ex.Message);
                }

            }

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isCheck = 1;
            btnDelete.Enabled = true;
            txtMaNv.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            dtmNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            cboGioiTinh.Text = dgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtSdt.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dgvNhanVien.CurrentRow.Cells[6].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[7].Value.ToString();
            dtmNgayLam.Text = dgvNhanVien.CurrentRow.Cells[8].Value.ToString();
            //picImages.ImageLocation = dgvNhanVien.CurrentRow.Cells[8].ToString();
            // load image on a picturebox
            //MemoryStream ms = new MemoryStream((string)dgvNhanVien.CurrentRow.Cells[8].Value);
            //picImages.Image = Image.FromStream(ms);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            isCheck = 0;

            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            TurnOffTextBox(true);
            RefreshTextBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isCheck = 1;
            btnInsert.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnPrint.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            TurnOffTextBox(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResultDelete = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResultDelete == DialogResult.Yes)
            {
                nv.MaNv = int.Parse(txtMaNv.Text);

                if (txtMaNv.Text == null)
                {
                    DialogResult dialogResultCheck = MessageBox.Show("Không tồn tại nhân viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResultCheck == DialogResult.OK)
                    {
                        HienThiDSNV();
                    }
                }

                bool result = nvbll.DeleteNhanVien(nv);

                if (result)
                {
                    DialogResult dialogResult = MessageBox.Show("Delete successful!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        HienThiDSNV();
                    }

                }
                else
                {
                    MessageBox.Show("Error Delete !");
                }
            }


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                frm_ReportNhanVien rnv = new frm_ReportNhanVien();
                rnv.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            EnableHome();
            TurnOffTextBox(false);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTextBox();
            //btnSave.Enabled = false;
            //btnEdit.Enabled = false;
            //btnDelete.Enabled = false;
            //btnPrint.Enabled = false;
            //btnCancel.Enabled = false;
        }

        private void RefreshTextBox()
        {
            txtMaNv.Text = "";
            txtHoTen.Text = "";
            dtmNgayLam.Text = "";
            cboGioiTinh.Text = "";
            txtSdt.Text = "";
            txtMail.Text = "";
            txtDiaChi.Text = "";
            dtmNgayLam.Text = "";
            dtmNgaySinh.Text = "";
        }


        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
            //btnRefresh.Enabled = true;
            //btnSave.Enabled = true;
            //btnEdit.Enabled = false;
            //btnDelete.Enabled = false;
            //btnPrint.Enabled = false;
            //btnCancel.Enabled = true;
            //btnInsert.Enabled = false;
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            //nv.Search = txtSearch.Text;
            dgvNhanVien.DataSource = nvbll.SearchNhanVien(nv);
        }

        private void cboLoading_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoading.SelectedIndex == -1)
            {
                return;
            }
            nv.Search = cboLoading.Text;
            cboSearch.Items.Clear();
            List<NhanVien> nvlist = nvbll.LocDSNhanVien(nv);
            if(cboLoading.Text=="Mã Nhân Viên")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.MaNv);
                }
            }
            else if (cboLoading.Text == "Họ Tên")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.Hoten);
                }
            }
            else if (cboLoading.Text == "Ngày Sinh")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.NgaySinh);
                }
            }
            else if (cboLoading.Text == "Giới Tính")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.GioTinh);
                }
            }
            else if (cboLoading.Text == "Mail")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.Mail);
                }
            }
            else if (cboLoading.Text == "Số Điện Thoại")
            {
                cboSearch.Text = "";
                foreach (NhanVien nvs in nvlist)
                {
                    cboSearch.Items.Add(nvs.Sdt);
                }
            }
            else
            {
                return;
            }


        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (cboSearch.Text == "")
            {
                HienThiDSNV();
                return;
            }
            nv.Search = cboSearch.Text;
            List<NhanVien> nvlist = nvbll.TimKiemNhanVien(nv);
            dgvNhanVien.Rows.Clear();
            foreach(NhanVien nvs in nvlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNhanVien);
                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = nvs.MaNv.ToString();
                row.Cells[2].Value = nvs.Hoten.ToString();
                row.Cells[3].Value = nvs.NgaySinh.ToString();
                row.Cells[4].Value = nvs.GioTinh.ToString();
                row.Cells[5].Value = nvs.Sdt.ToString();
                row.Cells[6].Value = nvs.Mail.ToString();
                row.Cells[7].Value = nvs.DiaChi.ToString();
                row.Cells[8].Value = nvs.NgayLam.ToString();

                dgvNhanVien.Rows.Add(row);
                ++i;
            }
        }
    }
}
