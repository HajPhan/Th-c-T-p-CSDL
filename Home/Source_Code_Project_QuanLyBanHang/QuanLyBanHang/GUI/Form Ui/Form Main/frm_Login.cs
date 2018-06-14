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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();

            // xử lý khi đăng nhập
            txtUser.ForeColor = Color.DimGray;
            txtUser.Text = "Username";
            this.txtUser.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUser.Enter += new System.EventHandler(this.txtUsername_Enter);

            txtPass.ForeColor = Color.DimGray;
            txtPass.Text = "Password";
            this.txtPass.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPass.Enter += new System.EventHandler(this.txtPassword_Enter);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region
            //try
            //{
            //    Login login = new Login();

            //    login.username = int.Parse(txtUsername.Text);
            //    login.password = int.Parse(txtPassword.Text);

            //    UserInfo.Id = int.Parse(txtUsername.Text);

            //    loginBLL logbll = new loginBLL();

            //    bool kq = logbll.CheckLogin(login);

            //    if (kq == true)
            //    {
            //        MessageBox.Show(login.permission.ToString());
            //        if (login.permission == "QLBH")
            //        {
            //            this.Hide();
            //            frm_Main main = new frm_Main(login.fullname, login.namepermision);
            //            UserInfo.permission = login.permission;
            //            main.ShowDialog();
            //            this.Close();
            //        }
            //        else if (login.permission == "NVBH")
            //        {
            //            this.Hide();
            //            frm_Main main = new frm_Main(login.fullname, login.namepermision);
            //            UserInfo.permission = login.permission;
            //            main.ShowDialog();
            //            this.Close();
            //        }
            //        else if (login.permission == "NVNEW")
            //        {
            //            MessageBox.Show("Bạn không có quyền đăng nhập vào hệ thống!");
            //        }

            //    }

            //}
            //catch
            //{
            //    MessageBox.Show("Username or Password not correct !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            #endregion

        }


        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtUsername_Enter(Object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.DimGray;
            }


        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
            }

        }



        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_OnValueChanged(object sender, EventArgs e)
        {
            #region
            //SlidePanel.Height = txtUsername.Height;
            //SlidePanel.Top = txtUsername.Top;
            #endregion
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            #region
            //    SlidePanel.Height = txtPassword.Height;
            //    SlidePanel.Top = txtPassword.Top;
            #endregion
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            #region
            //Application.Exit();
            // string test = " ";
            //txtUser.text = test.ToString();
            //txtUser.Text = " _";
            //MessageBox.Show("txtUsert = " + txtUser.Text, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            #region
            //try
            //{
            //    //MessageBox.Show("Login: " + txtUser.Text + " " + txtPass.Text, "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Login login = new Login();

            //    string userName = txtUser.Text;
            //    //string passWord = txtPass.Text;
            //    login.username = int.Parse(txtUser.Text);
            //    login.password = int.Parse(txtPass.Text);

            //    UserInfo.Id = int.Parse(userName);

            //    loginBLL logbll = new loginBLL();

            //    bool kq = logbll.CheckLogin(login);

            //    if (kq == true)
            //    {
            //        MessageBox.Show(login.permission.ToString());
            //        if (login.permission == "QLBH")
            //        {
            //            this.Hide();
            //            frm_Main main = new frm_Main(login.fullname, login.namepermision);
            //            UserInfo.permission = login.permission;
            //            main.ShowDialog();
            //            this.Close();
            //        }
            //        else if (login.permission == "NVBH")
            //        {
            //            this.Hide();
            //            frm_Main main = new frm_Main(login.fullname, login.namepermision);
            //            UserInfo.permission = login.permission;
            //            main.ShowDialog();
            //            this.Close();
            //        }
            //        else if (login.permission == "NVNEW")
            //        {
            //            MessageBox.Show("Bạn không có quyền đăng nhập vào hệ thống!");
            //        }

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Loi Login!" + ex.Message);
            //}
            #endregion
        }

        private void txtUser_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtPass_OnTextChange(object sender, EventArgs e)
        {

        }

        private void txtUser_OnValueChanged(object sender, EventArgs e)
        {
            //slide.Height = txtUser.Height;
            //slide.Top = txtUser.Top;
        }

        private void txtPass_OnValueChanged(object sender, EventArgs e)
        {
            //panel_Slide.Height = txtPass.Height;
            //panel_Slide.Top = txtPass.Top;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            #region
            //try
            //{

            //    Login login = new Login();

            //    string userName = txtUser.Text;
            //    login.username = int.Parse(txtUser.Text);
            //    login.password = int.Parse(txtPass.Text);

            //    UserInfo.Id = int.Parse(userName);

            //    loginBLL logbll = new loginBLL();

            //    bool kq = logbll.CheckLogin(login);

            //    if (kq == true)
            //    {
            //        MessageBox.Show(login.permission.ToString());
            //        if (login.permission == "QLBH")
            //        {
            //            this.Hide();
            //            frm_Main main = new frm_Main(login.fullname, login.namepermision);
            //            UserInfo.permission = login.permission;
            //            main.ShowDialog();
            //            this.Close();
            //        }
            //        else if (login.permission == "NVBH")
            //        {
            //            this.Hide();
            //            frm_Main main = new frm_Main(login.fullname, login.namepermision);
            //            UserInfo.permission = login.permission;
            //            main.ShowDialog();
            //            this.Close();
            //        }
            //        else if (login.permission == "NVNEW")
            //        {
            //            MessageBox.Show("Bạn không có quyền đăng nhập vào hệ thống!");
            //        }

            //    }

            //}
            //catch
            //{
            //    MessageBox.Show("Username hoặc Password không đúng");
            //}
            #endregion
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {

                Login login = new Login();

                string userName = txtUser.Text;
                login.username = int.Parse(txtUser.Text);
                login.password = int.Parse(txtPass.Text);

                UserInfo.Id = int.Parse(userName);

                loginBLL logbll = new loginBLL();

                bool kq = logbll.CheckLogin(login);

                if (kq == true)
                {
                    MessageBox.Show(login.permission.ToString());
                    if (login.permission == "QLBH")
                    {
                        this.Hide();
                        frm_Main main = new frm_Main(login.fullname, login.namepermision);
                        UserInfo.permission = login.permission;
                        main.ShowDialog();
                        this.Close();
                    }
                    else if (login.permission == "NVBH")
                    {
                        this.Hide();
                        frm_Main main = new frm_Main(login.fullname, login.namepermision);
                        UserInfo.permission = login.permission;
                        main.ShowDialog();
                        this.Close();
                    }
                    else if (login.permission == "NVNEW")
                    {
                        MessageBox.Show("Bạn không có quyền đăng nhập vào hệ thống!");
                    }

                }

            }
            catch
            {
                MessageBox.Show("Username hoặc Password không đúng");
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkPassword_OnChange(object sender, EventArgs e)
        {


            //if (checkPassword.Checked == false)
            //{
            //    txtPass.isPassword = true;
            //}
            //else
            //{
            //    txtPass.isPassword = false;
            //}
        }
    }
}
