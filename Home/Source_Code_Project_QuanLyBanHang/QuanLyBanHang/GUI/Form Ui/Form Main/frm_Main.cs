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
    public partial class frm_Main : Form
    {
        loginBLL logbll = new loginBLL();
        //bool isCheckNhanVien = false, isCheckKhangHang = false, isCheckNhaCc = false, isCheckNhaSx = false, isCheckLoaiSp = false, isCheckDonDh = false, isCheckPhieuNhap = false, isCheckPhieuXuat = false;
        //isCheckNhanVien  = isCheckNhaCc = isCheckNhaSx = isCheckLoaiSp = isCheckDonDh, isCheckPhieuNhap, isCheckPhieuXuat;

        public frm_Main(string fullname,string namepermission)
        {
            InitializeComponent();
            //this.Text = "Xin chào: " + fullname + " - " + namepermission;
            lbTenNv.Text = fullname;
            lbTenQh.Text = namepermission;
        }



        private void chươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frm_Login login = new frm_Login();
            login.ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
//            UserInfo userInfo = new UserInfo();
            đăngNhậpToolStripMenuItem.Visible = false;
            if (UserInfo.permission == "NVBH")
            {
                tàiKhoảnToolStripMenuItem.Visible = false;
                toolStripSeparator5.Visible = false;
                PhanQuyentoolStripMenuItem.Visible = false;
                toolStripSeparator7.Visible = false;
                thốngKêToolStripMenuItem1.Visible = false;
                saoLưuDữLiệuToolStripMenuItem.Visible = false;
                btnNhanVien.Visible = false;
            }

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SanPham frmSanPham = new frm_SanPham();
            //frmSanPham.MdiParent = this;
            frmSanPham.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien frnNhanVien = new frm_NhanVien();
            //frnNhanVien.MdiParent = this;
            frnNhanVien.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_KhachHang frmKhachHang = new frm_KhachHang();
            //frmKhachHang.MdiParent = this;
            frmKhachHang.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frmNhaCungCap = new frm_NhaCungCap();
            //frmNhaCungCap.MdiParent = this;
            frmNhaCungCap.Show();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhaSanXuat frmNhaSx = new frm_NhaSanXuat();
            //frmNhaSx.MdiParent = this;
            frmNhaSx.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LoaiSanPham frmLoaiSp = new frm_LoaiSanPham();
            //frmLoaiSp.MdiParent = this;
            frmLoaiSp.Show();
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DONDH frmDonDh = new frm_DONDH();
            //frmDonDh.MdiParent = this;
            frmDonDh.Show();
        }

        private void phiếuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhieuNhap frmPhieuNhap = new frm_PhieuNhap();
            //frmPhieuNhap.MdiParent = this;
            frmPhieuNhap.Show();
        }

        private void phiếuXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhieuXuat frmPhieuXuat = new frm_PhieuXuat();
            //frmPhieuXuat.MdiParent = this;
            frmPhieuXuat.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panShowAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

        }

        private void sôPhieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKe_NhapHang());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_TaiKhoan frmTaiKhoan = new frm_TaiKhoan();
            //frmTaiKhoan.MdiParent = this;
            frmTaiKhoan.Show();
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DONDH frmDonHang = new frm_DONDH();
            //frmDonHang.MdiParent = this;
            frmDonHang.Show();
        }

        private void phiếuNhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frm_PhieuNhap frmPhieuNhap = new frm_PhieuNhap();
            ////frmPhieuNhap.MdiParent = this;
            //frmPhieuNhap.Show();
        }

        private void phiếuXuấtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_PhieuXuat frmPhieuXuat = new frm_PhieuXuat();
            //frmPhieuXuat.MdiParent = this;
            frmPhieuXuat.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test_1 test = new test_1();
            //test.MdiParent = this;
            test.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoaiSp_Click(object sender, EventArgs e)
        {

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnNhaCC_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbNamePermission_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 250)
            {
                panelMenu.Width = 60;
            }
            else
            {
                panelMenu.Width = 250;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //panel_Move.Height = btnHelp.Height;
            //panel_Move.Top = btnHelp.Top;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel_Move.Height = btnNhanVien.Height;
            panel_Move.Top = btnNhanVien.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhanVien());

            //btnNhanVien.Normalcolor = Color.FromArgb(37, 37, 38);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panel_Move.Height = btnKhachHang.Height;
            panel_Move.Top = btnKhachHang.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_KhachHang());
        }

        private void btnNhaCC_Click_1(object sender, EventArgs e)
        {
            panel_Move.Height = btnNhaCC.Height;
            panel_Move.Top = btnNhaCC.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhaCungCap());
        }

        private void btnNhaSx_Click(object sender, EventArgs e)
        {
            panel_Move.Height = btnNhaSx.Height;
            panel_Move.Top = btnNhaSx.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_NhaSanXuat());
        }

        private void btnLoaiSp_Click_1(object sender, EventArgs e)
        {
            panel_Move.Height = btnLoaiSp.Height;
            panel_Move.Top = btnLoaiSp.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_LoaiSanPham());
        }

        private void btnSanPham_Click_1(object sender, EventArgs e)
        {
            panel_Move.Height = btnSanPham.Height;
            panel_Move.Top = btnSanPham.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_SanPham());
        }

        private void btnDonDh_Click(object sender, EventArgs e)
        {
            panel_Move.Height = btnDonDh.Height;
            panel_Move.Top = btnDonDh.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_DonDatHang());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            panel_Move.Height = btnPhieuNhap.Height;
            panel_Move.Top = btnPhieuNhap.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_PhieuNhap());
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            panel_Move.Height = btnPhieuXuat.Height;
            panel_Move.Top = btnPhieuXuat.Top;

            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_PhieuXuat());
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BackupData frmRestore = new frm_BackupData();
            frmRestore.ShowDialog();
        }

        private void tồnKhoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKe_TonKho());
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_RestoreData frmRestore = new frm_RestoreData();
            frmRestore.ShowDialog();
        }

        private void sốĐơnDặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKe_DonHang());
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_ThongKe_XuatHang());
        }

        private void biểuĐồBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(new uc_BieuDoThongKe());
        }
    }
}
