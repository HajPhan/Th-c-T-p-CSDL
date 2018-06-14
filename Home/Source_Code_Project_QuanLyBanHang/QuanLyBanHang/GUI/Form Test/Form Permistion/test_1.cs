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
    public partial class test_1 : Form
    {

        /// <summary>
        /// 
        /// </summary>

        PhanQuyen pq = new PhanQuyen();
        PhanQuyenBLL pqbll = new PhanQuyenBLL();



        public test_1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvCTQH);
            if (e.Node != null)
            {

                if (e.Node.Text == "Nhân Viên")
                {
                    MessageBox.Show("click choose" + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.idPermission = "NHANVIEN";


                }
                else if (e.Node.Text == "Khách Hàng")
                {
                    MessageBox.Show("click choose:" + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Nhà Cung Cấp")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Nhà Sản Xuất")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Sản Phẩm")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Loại Sản Phẩm")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);

                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Đơn Đặt Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Phiếu Nhập Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);

                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Phiếu Xuất Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Chi Tiết Bán Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Tồn Kho")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Biểu Đồ Thống Kê")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Backup")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }
                else if (e.Node.Text == "Restore")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                }

            }

        }

        private void btnDSPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }
            //if(e.RowIndex == 2)
            //{
            //    tvDanhSachChucNang.SelectedNode.Text = "Main";
            //    tvDanhSachChucNang.SelectedNode.Collapse();
            //}
            //tvDanhSachChucNang.Visible = true;
            HienThiTreeViewDanhSachCacChucNang();
            pq.idPermission = dgvDSPhanQuyen.CurrentRow.Cells[0].Value.ToString();



        }

        private void rdoNhomNguoiDung_CheckedChanged(object sender, EventArgs e)
        {
            HienThiDanhSachNhomQuyen();
            //HienThiTreeViewDanhSachCacChucNang();
            //tvDanhSachChucNang.Visible = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void test_1_Load(object sender, EventArgs e)
        {
            
            //HienThiDanhSachChiTietNhomQuyen();
            //HienThiDanhSachNhomQuyen();
        }


        // Hiển Thi Danh Sách Nhóm Quyền
        public void HienThiDanhSachNhomQuyen()
        {
            dgvDSPhanQuyen.DataSource = pqbll.ShowListPermissionGroup();
            dgvDSPhanQuyen.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDSPhanQuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSPhanQuyen.AutoResizeColumns();
            dgvDSPhanQuyen.Columns[0].Width = 80;
            dgvDSPhanQuyen.AllowUserToAddRows = false;

        }


        // Hiển Thị TreeView Danh Sách Chức Năng
        private void HienThiTreeViewDanhSachCacChucNang()
        {
            treeView1.Nodes.Clear();
            TreeNode node_DanhMuc_1 = new TreeNode("Nhân Viên");
            TreeNode node_DanhMuc_2 = new TreeNode("Khách Hàng");
            TreeNode node_DanhMuc_3 = new TreeNode("Nhà Cung Cấp");
            TreeNode node_DanhMuc_4 = new TreeNode("Nhà Sản Xuất");
            TreeNode node_DanhMuc_5 = new TreeNode("Loại Sản Phẩm");
            TreeNode node_DanhMuc_6 = new TreeNode("Sản Phẩm");


            TreeNode node_QuanLyBanHang_1 = new TreeNode("Đơn Đặt Hàng");
            TreeNode node_QuanLyBanHang_2 = new TreeNode("Phiếu Nhập Hàng");
            TreeNode node_QuanLyBanHang_3 = new TreeNode("Phiếu Xuất Hàng");
            TreeNode node_QuanLyBanHang_4 = new TreeNode("Chi Tiết Bán Hàng");

            TreeNode node_Thongke_1 = new TreeNode("Đơn Hàng");
            TreeNode node_ThongKe_2 = new TreeNode("Nhập Hàng");
            TreeNode node_ThongKe_3 = new TreeNode("Xuất Hàng");
            TreeNode node_ThongKe_4 = new TreeNode("Tồn Kho");
            TreeNode node_ThongKe_5 = new TreeNode("Biểu Đồ Thống Kê");

            TreeNode node_SaoLuu_1 = new TreeNode("Backup");
            TreeNode node_SaoLuu_2 = new TreeNode("Restore");



            TreeNode[] array_DanhMuc = new TreeNode[] { node_DanhMuc_1, node_DanhMuc_2, node_DanhMuc_3, node_DanhMuc_4, node_DanhMuc_5, node_DanhMuc_6 };
            TreeNode[] array_QuanLyBanHang = new TreeNode[] { node_QuanLyBanHang_1, node_QuanLyBanHang_2, node_QuanLyBanHang_3, node_QuanLyBanHang_4 };
            TreeNode[] array_ThongKe = new TreeNode[] { node_Thongke_1, node_ThongKe_2, node_ThongKe_3, node_ThongKe_4, node_ThongKe_5 };
            TreeNode[] array_SaoLuu = new TreeNode[] { node_SaoLuu_1, node_SaoLuu_2 };


            TreeNode node_DanhMuc = new TreeNode("Danh Mục", array_DanhMuc);
            TreeNode node_QuanLyBanHang = new TreeNode("Quản Lý Bán Hàng", array_QuanLyBanHang);
            TreeNode node_ThongKe = new TreeNode("Thống Kê", array_ThongKe);
            TreeNode node_SaoLuu = new TreeNode("Sao Lưu", array_SaoLuu);
            TreeNode node_Help = new TreeNode("Help");


            TreeNode[] array_Main = new TreeNode[] { node_DanhMuc, node_QuanLyBanHang, node_ThongKe, node_SaoLuu, node_Help };
            TreeNode root = new TreeNode("Main", array_Main);

            root.ImageIndex = 0;
            root.SelectedImageIndex = 3;

            node_DanhMuc.ImageIndex = 1;
            node_DanhMuc.SelectedImageIndex = 3;

            node_QuanLyBanHang.ImageIndex = 1;
            node_QuanLyBanHang.SelectedImageIndex = 3;

            node_ThongKe.ImageIndex = 1;
            node_ThongKe.SelectedImageIndex = 3;

            node_SaoLuu.ImageIndex = 1;
            node_SaoLuu.SelectedImageIndex = 3;

            node_Help.ImageIndex = 1;
            node_Help.SelectedImageIndex = 3;


            node_DanhMuc_1.ImageIndex = 2;
            node_DanhMuc_1.SelectedImageIndex = 3;
            node_DanhMuc_2.ImageIndex = 2;
            node_DanhMuc_2.SelectedImageIndex = 3;
            node_DanhMuc_3.ImageIndex = 2;
            node_DanhMuc_3.SelectedImageIndex = 3;
            node_DanhMuc_4.ImageIndex = 2;
            node_DanhMuc_4.SelectedImageIndex = 3;
            node_DanhMuc_5.ImageIndex = 2;
            node_DanhMuc_5.SelectedImageIndex = 3;
            node_DanhMuc_6.ImageIndex = 2;
            node_DanhMuc_6.SelectedImageIndex = 3;

            node_QuanLyBanHang_1.ImageIndex = 2;
            node_QuanLyBanHang_1.SelectedImageIndex = 3;
            node_QuanLyBanHang_2.ImageIndex = 2;
            node_QuanLyBanHang_2.SelectedImageIndex = 3;
            node_QuanLyBanHang_3.ImageIndex = 2;
            node_QuanLyBanHang_3.SelectedImageIndex = 3;
            node_QuanLyBanHang_4.ImageIndex = 2;
            node_QuanLyBanHang_4.SelectedImageIndex = 3;

            node_Thongke_1.ImageIndex = 2;
            node_Thongke_1.SelectedImageIndex = 3;
            node_ThongKe_2.ImageIndex = 2;
            node_ThongKe_2.SelectedImageIndex = 3;
            node_ThongKe_3.ImageIndex = 2;
            node_ThongKe_3.SelectedImageIndex = 3;
            node_ThongKe_4.ImageIndex = 2;
            node_ThongKe_4.SelectedImageIndex = 3;
            node_ThongKe_5.ImageIndex = 2;
            node_ThongKe_5.SelectedImageIndex = 3;

            node_SaoLuu_1.ImageIndex = 2;
            node_SaoLuu_1.SelectedImageIndex = 3;
            node_SaoLuu_2.ImageIndex = 2;
            node_SaoLuu_2.SelectedImageIndex = 3;

            treeView1.Nodes.Add(root);

        }

        // Hiển Thi Danh Sách Chi Tiết Nhóm Quyền
        private void HienThiDanhSachChiTietNhomQuyen(bool check)
        {
            dgvCTQH.Rows.Clear();
            dgvCTQH.Rows.Add("Insert", check);
            dgvCTQH.Rows.Add("Update", check);
            dgvCTQH.Rows.Add("Delete", check);
            dgvCTQH.Rows.Add("Search", check);
            dgvCTQH.Rows.Add("Prints", check);
            chkSelect.Checked = check;

            //
            dgvCTQH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTQH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTQH.AllowUserToAddRows = false;
        }
        //private void HienThiDanhSachChiTietNhomQuyen()
        //{
        //    dgvCTQH.DataSource = pqbll.ShowListDetailsPermission();
        //    dgvCTQH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dgvCTQH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //}

        private void rdoUserDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUserDangNhap.Checked == true)
            {
                btnTaoMoi.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnCancel.Visible = false;
            }
            else
            {
                btnTaoMoi.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnCancel.Visible = true;
            }
            


        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            frm_Permission frmPermission = new frm_Permission(this);
            frmPermission.ShowDialog();
        }

        private void dgvCTQH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                return;
            }
            else if (e.ColumnIndex == 1)
            {
                txtSearch.Text = dgvCTQH.CurrentRow.Cells[0].Value.ToString();
                string nameChucNang = dgvCTQH.CurrentRow.Cells[0].Value.ToString().Trim();
                string sosanh = dgvCTQH.CurrentRow.Cells[1].Value.ToString().Trim();
                if (sosanh == "False")
                {
                    dgvCTQH.CurrentRow.Cells[1].Value = true;
                    if(nameChucNang=="Insert")
                    {
                        pq.Inserts = 1;
                    }
                    else if(nameChucNang=="Update")
                    {
                        pq.Updates = 1;
                    }
                    else if (nameChucNang == "Delete")
                    {
                        pq.Deletes = 1;
                    }
                    else if (nameChucNang == "Search")
                    {
                        pq.Searchs = 1;
                    }
                    else if (nameChucNang == "Print")
                    {
                        pq.In = 1;
                    }
                }
                else if(sosanh=="True")
                {
                    dgvCTQH.CurrentRow.Cells[1].Value = false;
                    if (nameChucNang == "Insert")
                    {
                        pq.Inserts = 0;
                    }
                    else if (nameChucNang == "Update")
                    {
                        pq.Updates = 0;
                    }
                    else if (nameChucNang == "Delete")
                    {
                        pq.Deletes = 0;
                    }
                    else if (nameChucNang == "Search")
                    {
                        pq.Searchs = 0;
                    }
                    else if (nameChucNang == "Print")
                    {
                        pq.In = 0;
                    }
                }
                label2.Text = dgvCTQH.CurrentRow.Cells[1].Value.ToString();
                txtSearch.Text = pq.Inserts.ToString();
                label3.Text = nameChucNang;
                label4.Text = pq.Inserts.ToString();
                label5.Text = pq.idChucNang.ToString();
                label6.Text = pq.nameChucNang.ToString();
                label7.Text = pq.idPermission.ToString();
                //else if()
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(tvDanhSachChucNang.SelectedNode.IsExpanded)
            {
                tvDanhSachChucNang.SelectedNode.Collapse();
                MessageBox.Show(tvDanhSachChucNang.SelectedNode.Text + " tree node collapsed");

            }
            else
            {
                tvDanhSachChucNang.SelectedNode.Expand();
                MessageBox.Show(tvDanhSachChucNang.SelectedNode.Text + " tree node expanded");

            }
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvCTQH);

            if(chkSelect.Checked == true)
            {
                HienThiDanhSachChiTietNhomQuyen(true);
                row.Cells[1].Value = true;

            }
            else if (chkSelect.Checked == false)
            {
                HienThiDanhSachChiTietNhomQuyen(false);
                row.Cells[1].Value = false;
            }
            label2.Text = row.Cells[1].Value.ToString();
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvCTQH);
            if (e.Node != null)
            {

                if (e.Node.Text == "Nhân Viên")
                {
                    MessageBox.Show("click choose" + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "NHAN VIEN";
                    pq.idChucNang = "DANHMUC";


                }
                else if (e.Node.Text == "Khách Hàng")
                {
                    MessageBox.Show("click choose:" + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "KHACH HANG";
                    pq.idChucNang = "DANHMUC";

                }
                else if (e.Node.Text == "Nhà Cung Cấp")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "NHA CUNG CAP";
                    pq.idChucNang = "DANHMUC";


                }
                else if (e.Node.Text == "Nhà Sản Xuất")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "NHA SAN XUAT";
                    pq.idChucNang = "DANHMUC";

                }
                else if (e.Node.Text == "Sản Phẩm")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "SAN PHAM";
                    pq.idChucNang = "DANHMUC";

                }
                else if (e.Node.Text == "Loại Sản Phẩm")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);

                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "LOAI SAN PHAM";
                    pq.idChucNang = "DANHMUC";

                }
                else if (e.Node.Text == "Đơn Đặt Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "DON DAT HANG";
                    pq.idChucNang = "QUANLYBANHANG";

                }
                else if (e.Node.Text == "Phiếu Nhập Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);

                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "PHIEU NHAP HANG";
                    pq.idChucNang = "QUANLYBANHANG";

                }
                else if (e.Node.Text == "Phiếu Xuất Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "PHIEU XUAT HANG";
                    pq.idChucNang = "QUANLYBANHANG";
                }
                else if (e.Node.Text == "Chi Tiết Bán Hàng")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "CHI TIET BAN HANG";
                    pq.idChucNang = "QUANLYBANHANG";
                }
                else if(e.Node.Text=="Đơn Hàng")
                {
                    MessageBox.Show("click choose: " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "DON HANG";
                    pq.idChucNang = "THONGKE";
                }
                else if(e.Node.Text=="Nhập Hàng")
                {
                    MessageBox.Show("click choose: " + e.Node.Text);
                    pq.nameChucNang = "NHAP HANG";
                    pq.idChucNang = "THONGKE";
                }
                else if(e.Node.Text=="Xuất Hàng")
                {
                    MessageBox.Show("clik choose: " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "XUAT HANG";
                    pq.idChucNang = "THONGKE";
                }
                else if (e.Node.Text == "Tồn Kho")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "TON KHO";
                    pq.idChucNang = "THONGKE";
                }
                else if (e.Node.Text == "Biểu Đồ Thống Kê")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "BIEU DO THONG KE";
                    pq.idChucNang = "THONGKE";
                }
                else if (e.Node.Text == "Backup")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "BACKUP";
                    pq.idChucNang = "SAOLUUDULIEU";

                }
                else if (e.Node.Text == "Restore")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "RESTORE";
                    pq.idChucNang = "SAOLUUDULIEU";
                }
                else if(e.Node.Text=="Help")
                {
                    MessageBox.Show("click choose: " + " " + e.Node.Text);
                    HienThiDanhSachChiTietNhomQuyen(false);
                    pq.nameChucNang = "HELPS";
                    pq.idChucNang = "HELP";
                }

            }
        }


        // HIen thi danh sach ChucNang
        private void HienThiDanhSAchChucNang(PhanQuyen pqs)
        {
         
            List<PhanQuyen> pqlist = pqbll.ShowListDetailsPermission(pqs);

            foreach(PhanQuyen pq_1 in pqlist)
            {

            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
