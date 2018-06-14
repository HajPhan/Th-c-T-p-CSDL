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
using System.IO;

namespace GUI
{
    public partial class frm_NhanVien : Form
    {
        /// <summary>
        /// 
        /// </summary>

        NhanVien nv = new NhanVien();
        NhanVienBLL nvbll = new NhanVienBLL();

        ///
        public frm_NhanVien()
        {
            InitializeComponent();

            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Text = "Search Here";
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
        }



        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            nv.Search = txtSearch.Text;
            dgvbNhanVien.DataSource = nvbll.SearchNhanVien(nv);
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            txtMaNv.Enabled = false;
            HienThiNhanVien();
            LoadComboBoxGioTinh();
        }


        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png file(*.png)|*.png|jpg file(*.jpg)|*.jpg|All file(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                nv.imagesLocation = openFileDialog.FileName.ToString();
                picImages.ImageLocation = nv.imagesLocation;
            }
        }

        private void HienThiNhanVien()
        {
            NhanVienBLL nvbll = new NhanVienBLL();
            nv.MaNv = UserInfo.Id;
            #region
            //            List<NhanVien> dsnv = nvbll.GetAllEmployee();
            //bool result = nvbll.ShowListNhanVien(nv);
            //lvNhanVien.Items.Clear();

            //foreach(NhanVien nv in dsnv)
            //{
            //    ListViewItem lvi = new ListViewItem(nv.MaNv + "");
            //    lvi.SubItems.Add(nv.Hoten);
            //    lvi.SubItems.Add(nv.NgaySinh.ToShortDateString());
            //    lvi.SubItems.Add(nv.GioTinh);
            //    lvi.SubItems.Add(nv.Sdt + "");
            //    lvi.SubItems.Add(nv.Mail);
            //    lvi.SubItems.Add(nv.DiaChi);
            //    lvi.SubItems.Add(nv.NgayLam.ToShortDateString());

            //    dgvNhaVien.Items.Add(lvi);
            //}
            #endregion
            dgvbNhanVien.DataSource = nvbll.GetAllEmployee(nv);
            dgvbNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvbNhanVien.AutoResizeColumns();
            dgvbNhanVien.Columns[8].Width = 150;
            //            dgvbNhanVien.AutoResizeRows();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string sCommobox = this.cboGioTinh.SelectedIndex.ToString();
                nv.Hoten = txtHoTen.Text;
                nv.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());

                if (cboGioTinh.SelectedIndex == 0)
                {
                    nv.GioTinh = cboGioTinh.Text;
                }
                else if (cboGioTinh.SelectedIndex == 1)
                {
                    nv.GioTinh = cboGioTinh.Text;
                }
                else if (cboGioTinh.SelectedIndex == 2)
                {
                    nv.GioTinh = cboGioTinh.Text;
                }
                nv.Sdt = int.Parse(txtSdt.Text);
                nv.Mail = txtMail.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NgayLam = DateTime.Parse(dtmNgayLam.Value.ToShortDateString());

                NhanVienBLL nvbll = new NhanVienBLL();
                bool result = nvbll.InserNhanVien(nv);
                if (result)
                {
                    HienThiNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Save !" + ex.Message);
            }

        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(lvNhanVien.SelectedItems.Count == 0)
            //{
            //    return;
            //}
            //ListViewItem lvi = lvNhanVien.SelectedItems[0];
            //txtMaNv.Text = lvi.SubItems[0].Text;
            //txtHoTen.Text = lvi.SubItems[1].Text;
            //dtmNgaySinh.Text = lvi.SubItems[2].Text;
            //cboGioTinh.Text = lvi.SubItems[3].Text;
            //txtSdt.Text = lvi.SubItems[4].Text;
            //txtMail.Text = lvi.SubItems[5].Text;
            //txtDiaChi.Text = lvi.SubItems[6].Text;
            //dtmNgayLam.Text = lvi.SubItems[7].Text;




        }

        private void dgvNhaVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNv.Text = dgvNhaVien.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvNhaVien.CurrentRow.Cells[1].Value.ToString();
                dtmNgaySinh.Text = dgvNhaVien.CurrentRow.Cells[2].Value.ToString();
                cboGioTinh.Text = dgvNhaVien.CurrentRow.Cells[3].Value.ToString();
                txtSdt.Text = dgvNhaVien.CurrentRow.Cells[4].Value.ToString();
                txtMail.Text = dgvNhaVien.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dgvNhaVien.CurrentRow.Cells[6].Value.ToString();
                dtmNgayLam.Text = dgvNhaVien.CurrentRow.Cells[7].Value.ToString();

                // load image on a picturebox
                MemoryStream ms = new MemoryStream((byte[])dgvNhaVien.CurrentRow.Cells["IMAGES"].Value);
                picImages.Image = Image.FromStream(ms);

                //picImages.Image.Save(ms, picImages.Image.RawFormat);
                //UserInfo.Images = ms.GetBuffer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found!" + ex.Message);
            }

        }

        private void dgvbNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaNv.Text = dgvbNhanVien.CurrentRow.Cells[0].Value.ToString();
                txtHoTen.Text = dgvbNhanVien.CurrentRow.Cells[1].Value.ToString();
                dtmNgaySinh.Text = dgvbNhanVien.CurrentRow.Cells[2].Value.ToString();
                cboGioTinh.Text = dgvbNhanVien.CurrentRow.Cells[3].Value.ToString();
                //cboGioTinh.SelectedText = cboGioTinh.Text;
                UserInfo.GioiTinh = cboGioTinh.Text;

                txtSdt.Text = dgvbNhanVien.CurrentRow.Cells[4].Value.ToString();
                txtMail.Text = dgvbNhanVien.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dgvbNhanVien.CurrentRow.Cells[6].Value.ToString();
                dtmNgayLam.Text = dgvbNhanVien.CurrentRow.Cells[7].Value.ToString();

                // load image on a picturebox
                MemoryStream ms = new MemoryStream((byte[])dgvbNhanVien.CurrentRow.Cells["IMAGES"].Value);
                picImages.Image = Image.FromStream(ms);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found!" + ex.Message);
            }
        }

        private void LoadComboBoxGioTinh()
        {
            cboGioTinh.Items.Clear();
            cboGioTinh.Items.Add("nam");
            cboGioTinh.Items.Add("nữ");
            cboGioTinh.Items.Add("other");
            cboGioTinh.SelectedItem = 0;
        }

        private void LamMoi()
        {
            txtMaNv.Text = "";
            txtHoTen.Text = "";
            dtmNgayLam.Text = "";
            cboGioTinh.Text = "";
            txtSdt.Text = "";
            txtMail.Text = "";
            txtDiaChi.Text = "";
            dtmNgayLam.Text = "";
            picImages.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LamMoi();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //string sCommobox = this.cboGioTinh.SelectedIndex.ToString();

                nv.MaNv = int.Parse(txtMaNv.Text);
                nv.Hoten = txtHoTen.Text;
                nv.NgaySinh = DateTime.Parse(dtmNgaySinh.Value.ToShortDateString());
                if (cboGioTinh.SelectedIndex == -1)
                {
                    cboGioTinh.Text = UserInfo.GioiTinh.ToString().Trim();
                    if (cboGioTinh.Text == "nam")
                    {
                        nv.GioTinh = cboGioTinh.Text;
                    }
                    else if (cboGioTinh.Text == "nữ")
                    {
                        nv.GioTinh = cboGioTinh.Text;
                    }
                    else if (cboGioTinh.Text == "other")
                    {
                        nv.GioTinh = cboGioTinh.Text;
                    }
                }
                else
                {
                    if (cboGioTinh.Text == "nam")
                    {
                        nv.GioTinh = cboGioTinh.Text;
                    }
                    else if (cboGioTinh.Text == "nữ")
                    {
                        nv.GioTinh = cboGioTinh.Text;
                    }
                    else if (cboGioTinh.Text == "other")
                    {
                        nv.GioTinh = cboGioTinh.Text;
                    }
                }


                nv.Sdt = int.Parse(txtSdt.Text);
                nv.Mail = txtMail.Text;
                nv.DiaChi = txtDiaChi.Text;
                nv.NgayLam = DateTime.Parse(dtmNgayLam.Value.ToShortDateString());


                bool result = nvbll.UpdateNhanVien(nv);

                DialogResult dialogResult = MessageBox.Show("Edit Success !", "Thông báo", MessageBoxButtons.OK);


                if (result)
                {
                    if(dialogResult == DialogResult.OK)
                    {
                        LamMoi();
                        HienThiNhanVien();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Edit !" + ex.Message);
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nv.MaNv=int.Parse(txtMaNv.Text);

            bool result = nvbll.DeleteNhanVien(nv);

            if (result)
            {
                HienThiNhanVien();
            }
            else
            {
                MessageBox.Show("Error Delete !");
            }
        }

        private void dgvbNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
