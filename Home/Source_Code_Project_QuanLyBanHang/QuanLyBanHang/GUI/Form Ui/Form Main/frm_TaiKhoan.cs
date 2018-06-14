using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frm_TaiKhoan : Form
    {

        TaiKhoan tk = new TaiKhoan();
        TaiKhoanBLL tkbll = new TaiKhoanBLL();

        public frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTaiKhoan();
            HienThiComboBoxMaQh();
        }

        // Hien thi tai khoan
        private void HienThiDanhSachTaiKhoan()
        {
            int i = 0;
            List<TaiKhoan> tklist = tkbll.ShowTaiKhoan();
            foreach(TaiKhoan tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDSTaiKhoan);
                row.Cells[0].Value = i+1;
                row.Cells[1].Value = tks.Id;
                row.Cells[2].Value = tks.Password;
                row.Cells[3].Value = tks.Fullname;
                row.Cells[4].Value = false;
                row.Cells[5].Value = false;
                row.Cells[6].Value = false;

                if (tks.Permission.ToString().Trim() == "QLBH")
                {
                    row.Cells[4].Value = true;
                }
                else if(tks.Permission.ToString().Trim() == "NVBH")
                {
                    row.Cells[5].Value = true;
                }
                else if(tks.Permission.ToString().Trim() == "NVNEW")
                {
                    row.Cells[6].Value = true;
                }
                
                dgvDSTaiKhoan.Rows.Add(row);
                ++i;
            }

            //
            txtFullname.Enabled = false;
            txtPermission.Enabled = false;
            txtUsername.Enabled = false;


            //
            dgvDSTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSTaiKhoan.AllowUserToAddRows = false;

            //
            dgvDS_QLBH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDS_QLBH.AllowUserToAddRows = false;

            //
            dgvDSTaiKhoan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDS_QLBH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        // Hien Thi ComboxBox MAQH
        private void HienThiComboBoxMaQh()
        {
            cboQuyen_QLBH.DataSource = tkbll.LoadComboBoxMAQH();
            //cboMaQuyen.DataSource = tkbll.LoadComboBoxMAQH();
            cboMaQuyen.Items.Add("QLBH");
            cboMaQuyen.Items.Add("NVBH");
            cboMaQuyen.Items.Add("NVNEW");

        }

        private void dgvDSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TaiKhoan tks = new TaiKhoan();
            if (e.ColumnIndex == 4)
            {
                string Id = dgvDSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                tk.Id = int.Parse(Id);

                tk.Permission = "QLBH";
                tks.Permission = "QLBH";
                cboQuyen_QLBH.Text = "QLBH";

                bool result = tkbll.PermissionForEmployee(tk);

                if (result)
                {
                    dgvDSTaiKhoan.Rows.Clear();
                    HienThiDanhSachTaiKhoan();
                    LocThongTinTaiKhoanTheoMaQh_2(tks);
                }
            }
            if(e.ColumnIndex == 5)
            {
                string Id = dgvDSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                tk.Id = int.Parse(Id);

                tk.Permission = "NVBH";
                tks.Permission = "NVBH";
                cboQuyen_QLBH.Text = "NVBH";

                bool result = tkbll.PermissionForEmployee(tk);

                if (result)
                {
                    dgvDSTaiKhoan.Rows.Clear();
                    HienThiDanhSachTaiKhoan();
                    LocThongTinTaiKhoanTheoMaQh_2(tks);
                }

            }
            if (e.ColumnIndex == 6)
            {
                string Id = dgvDSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                tk.Id = int.Parse(Id);

                tk.Permission = "NVNEW";
                tks.Permission = "NVNEW";
                cboQuyen_QLBH.Text = "NVNEW";

                bool result = tkbll.PermissionForEmployee(tk);

                if (result)
                {
                    dgvDSTaiKhoan.Rows.Clear();
                    HienThiDanhSachTaiKhoan();
                    LocThongTinTaiKhoanTheoMaQh_2(tks);
                }

            }


        }

        private void btnNon_Permission_Click(object sender, EventArgs e)
        {
            for (int i = dgvDSTaiKhoan.Rows.Count - 1; i >= 0; i--)
            {
                bool isCheck_1 = (bool)dgvDSTaiKhoan.Rows[i].Cells[4].Value;
                bool isCheck_2 = (bool)dgvDSTaiKhoan.Rows[i].Cells[5].Value;
                bool isCheck_3 = (bool)dgvDSTaiKhoan.Rows[i].Cells[6].Value;


                if (isCheck_1 == true)
                {
                    MessageBox.Show("Ok_1");
                }
                if(isCheck_2 == true)
                {
                    MessageBox.Show("Ok_2");

                }
                if(isCheck_3 == true)
                {
                    MessageBox.Show("Ok_3");

                }
            }
        }

        private void cboQuyen_QLBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboQuyen_QLBH.SelectedIndex == -1)
            //{
            //    return;
            //}

            //dgvDS_QLBH.Rows.Clear();
            //tk.Permission = cboQuyen_QLBH.Text;
            //LocThongTinTaiKhoanTheoMaQh_2(tk);

            #region
            //List<TaiKhoan> tklist = tkbll.FilterEmployeeFlowIdPermission(tk);
            //foreach (TaiKhoan tks in tklist)
            //{
            //    DataGridViewRow row = new DataGridViewRow();
            //    row.CreateCells(dgvDS_QLBH);
            //    row.Cells[0].Value = tks.Id;
            //    row.Cells[1].Value = tks.Password;
            //    row.Cells[2].Value = tks.Fullname;
            //    row.Cells[3].Value = tks.Namepermission;

            //    dgvDS_QLBH.Rows.Add(row);
            //}

            #endregion
        }

        // Loc Thong tin tai khoan theo MAQH _ 1
        private void LocThongTinTaiKhoanTheoMaQh_1(TaiKhoan permission)
        {
            int i = 0;
            dgvDSTaiKhoan.Rows.Clear();
            List<TaiKhoan> tklist = tkbll.FilterEmployeeFlowIdPermission(permission);
            foreach (TaiKhoan tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDSTaiKhoan);
                row.Cells[0].Value = i+1;
                row.Cells[1].Value = tks.Id;
                row.Cells[2].Value = tks.Password;
                row.Cells[3].Value = tks.Fullname;
                string nps = tks.Permission.ToString().Trim();
                if(nps != null)
                {
                    if (nps == "QLBH")
                    {
                        row.Cells[4].Value = true;
                    }
                    else if (nps == "NVBH")
                    {
                        row.Cells[5].Value = true;
                    }
                    else if (nps == "NVNEW")
                    {
                        row.Cells[6].Value = true;
                    }

                }
                else
                {
                    row.Cells[4].Value = false;
                    row.Cells[5].Value = false;
                    row.Cells[6].Value = false;
                }

                dgvDSTaiKhoan.Rows.Add(row);
                ++i;
            }
        }


        // Loc Thong tin tai khoan theo MAQH _ 2
        private void LocThongTinTaiKhoanTheoMaQh_2(TaiKhoan permission)
        {
            dgvDS_QLBH.Rows.Clear();
            List<TaiKhoan> tklist = tkbll.FilterEmployeeFlowIdPermission(permission);
            foreach (TaiKhoan tks in tklist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvDS_QLBH);
                row.Cells[0].Value = tks.Id;
                row.Cells[1].Value = tks.Password;
                row.Cells[2].Value = tks.Fullname;
                row.Cells[3].Value = tks.Namepermission;

                dgvDS_QLBH.Rows.Add(row);
            }
        }

        private void dgvDS_QLBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == -1)
            {
                return;
            }
            txtUsername.Text = dgvDS_QLBH.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvDS_QLBH.CurrentRow.Cells[1].Value.ToString();
            txtFullname.Text = dgvDS_QLBH.CurrentRow.Cells[2].Value.ToString();
            txtPermission.Text = dgvDS_QLBH.CurrentRow.Cells[3].Value.ToString();
        }

        private void cboMaQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboMaQuyen.SelectedIndex == -1)
            //{
            //    return;
            //}
            //tk.Permission = cboMaQuyen.Text;
            //LocThongTinTaiKhoanTheoMaQh_1(tk);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tk.Id=int.Parse(txtUsername.Text);
            tk.Password = int.Parse(txtPassword.Text);
            bool result = tkbll.UpdateTaiKhoan(tk);

            if (result)
            {
                dgvDSTaiKhoan.Rows.Clear();
                dgvDS_QLBH.Rows.Clear();
                HienThiDanhSachTaiKhoan();
            }
        }

        private void cboMaQuyen_TextChanged(object sender, EventArgs e)
        {
            if (cboMaQuyen.SelectedIndex == -1)
            {
                dgvDSTaiKhoan.Rows.Clear();
                HienThiDanhSachTaiKhoan();
                return;
            }
            tk.Permission = cboMaQuyen.Text;
            LocThongTinTaiKhoanTheoMaQh_1(tk);
        }

        private void cboQuyen_QLBH_TextChanged(object sender, EventArgs e)
        {
            if (cboQuyen_QLBH.SelectedIndex == -1)
            {
                //dgvDS_QLBH.Rows.Clear();
                //dgvDS_QLBH.Rows.Clear();
                LocThongTinTaiKhoanTheoMaQh_2(tk);
                return;
            }

            dgvDS_QLBH.Rows.Clear();
            tk.Permission = cboQuyen_QLBH.Text;
            LocThongTinTaiKhoanTheoMaQh_2(tk);
        }
    }
}
