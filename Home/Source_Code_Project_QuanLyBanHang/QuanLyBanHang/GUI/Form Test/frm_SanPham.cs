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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frm_SanPham : Form
    {

        /// <summary>
        /// 
        /// </summary>
        /// 
        DTO.SanPham sp = new DTO.SanPham();
        DTO.SanPham sp1 = new DTO.SanPham();
        SanPhamBLL spbll = new SanPhamBLL();

        public frm_SanPham()
        {
            InitializeComponent();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            HienThiSanPham();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            sp.TenSp = txtTenSp.Text;
            sp.MaLoai = int.Parse(cboMaLoai.Text);
            sp.MaSx = int.Parse(cboMaSx.Text);
            sp.GiaThanh = int.Parse(txtGiaThanh.Text);
            sp.Cpu = txtCpu.Text;
            sp.Ram = cboRam_1.Text + " " + cboRam_2.Text + ", " + cboRam_3.Text;
            sp.Ocung = cboOcung_1.Text + ", " + cboOcung_2.Text + " " + cboOcung_3.Text;
            sp.ManHinh = txtManHinh.Text;
            sp.CardManHinh = txtCarMh.Text;
            sp.CongKetNoi = txtCongKetNoi.Text;
            sp.Hdt = txtHeDieuHanh.Text;
            sp.AmThanh = txtAmThanh.Text;
            sp.DiaQuang = cboDiaQuang.Text;
            sp.GiaoTiepMang = txtGiaoTiep.Text;
            sp.WebCam = txtWebcam.Text;
            sp.Pin = txtPin.Text;
            sp.TrongLuong = txtTrongLuong.Text + " " + cboTrongLuong.Text;
            sp.BaoHanh = cboBaoHanh_1.Text +" "+ cboBaoHanh_2.Text;

            bool result = spbll.InserSanPham(sp);
            if (result)
            {
                HienThiSanPham();
            }
            else
            {
                MessageBox.Show("Inser Product Not Success !");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaSp.Text = "";
            txtTenSp.Text = "";
            cboMaSx.Text = "";
            cboMaLoai.Text = "";
            txtGiaThanh.Text = "";
            txtCpu.Text = "";
            cboRam_1.Text = "";
            cboRam_2.Text = "";
            cboRam_3.Text = "";
            txtManHinh.Text = "";
            cboOcung_1.Text = "";
            cboOcung_2.Text = "";
            cboOcung_3.Text = "";
            txtCongKetNoi.Text = "";
            txtCarMh.Text = "";
            txtHeDieuHanh.Text = "";
            txtAmThanh.Text = "";
            cboDiaQuang.Text = "";
            txtGiaoTiep.Text = "";
            txtWebcam.Text = "";
            txtPin.Text = "";
            cboBaoHanh_1.Text = "";
            cboBaoHanh_2.Text = "";
            txtTrongLuong.Text = "";
            cboTrongLuong.Text = "";

            // Hien thi san pham
            HienThiSanPham();
        }

        private void HienThiSanPham()
        {
            dgvDanhSachSanPham.DataSource = spbll.ShowAllSanPham();
            dgvDanhSachChiTietSanPham.DataSource = spbll.ShowAllCTSP();
            cboMaLoai.DataSource = spbll.ShowAllMaLoaiSp();
            cboMaSx.DataSource = spbll.ShowAllMaSx();
            cboSearch.DataSource = spbll.ShowAllMaSp();
            cboTenSx.DataSource = spbll.ShowAllTenNhaSx();
            cboTenLoai.DataSource = spbll.ShowAllTenLoaiSp();
            txtMaSp.Enabled = false;
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSearch.SelectedIndex == -1)
            {
                return;
            }

        }

        private void SearchProduct(SanPham sp)
        {
            sp.MaSp = int.Parse(cboSearch.Text);

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt = new DataTable();
            List<SanPham> splist = spbll.SearchProduct(sp);
            

            foreach(SanPham sp1 in splist)
            {
                dt1.Rows.Add(sp1.MaSp.ToString());
                dt1.Rows.Add(sp1.TenSp);
                dt1.Rows.Add(sp1.MaSx);
                dt1.Rows[0][3] = sp1.MaLoai;
                dt1.Rows[0][4] = sp1.GiaThanh;

                dgvDanhSachSanPham.DataSource = dt1;

                dt2.Rows[0][0] = sp1.MaSp;
                dt2.Rows[0][1] = sp1.Cpu;
                dt2.Rows[0][2] = sp1.Ram;
                dt2.Rows[0][3] = sp1.Ocung;
                dt2.Rows[0][4] = sp1.ManHinh;
                dt2.Rows[0][5] = sp1.CardManHinh;
                dt2.Rows[0][6] = sp1.CongKetNoi;
                dt2.Rows[0][7] = sp1.Hdt;
                dt2.Rows[0][8] = sp1.AmThanh;
                dt2.Rows[0][9] = sp1.DiaQuang;
                dt2.Rows[0][10] = sp1.GiaoTiepMang;
                dt2.Rows[0][11] = sp1.WebCam;
                dt2.Rows[0][12] = sp1.Pin;
                dt2.Rows[0][13] = sp1.TrongLuong;
                dt2.Rows[0][14] = sp1.BaoHanh;

                dgvDanhSachChiTietSanPham.DataSource = dt2;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            sp.MaSp = int.Parse(cboSearch.Text);
            dgvDanhSachSanPham.DataSource = spbll.SearchIdProduct1(sp);
            dgvDanhSachChiTietSanPham.DataSource = spbll.SearchIdProduct2(sp);

            #region
            ////sp1.MaSp = int.Parse(cboSearch.Text);
            ////sp.MaSp = int.Parse(cboSearch.Text);
            ////dgvDanhSachSanPham.DataSource = spbll.SearchProduct(null,sp1);

            ////dgvDanhSachChiTietSanPham.DataSource = spbll.SearchProduct(sp, null);
            //sp.MaSp = int.Parse(cboSearch.Text);
            //DataTable dt1 = new DataTable();
            //DataTable dt2 = new DataTable();
            //List<SanPham> dsSp = spbll.SearchProduct(sp);
            //foreach(SanPham spl in dsSp)
            //{
            //    //DataGridViewRow row1 = new DataGridViewRow();
            //    //DataGridViewRow row2 = new DataGridViewRow();
            //    //row1.CreateCells(dataGridView1);
            //    //row1.CreateCells(dgvDanhSachSanPham);
            //    //row2.CreateCells(dgvDanhSachChiTietSanPham);

            //    //dt1.Rows.Add(spl.MaSp.ToString());
            //    //dt1.Rows.Add(spl.TenSp.ToString());
            //    //dt1.Rows.Add(spl.MaSx.ToString());
            //    //dt1.Rows.Add(spl.MaLoai.ToString());
            //    //dt1.Rows.Add(spl.GiaThanh.ToString());
            //    //dgvDanhSachSanPham.DataSource = dt1;

            //    dgvDanhSachSanPham.CurrentRow.Cells[0].Value = spl.MaSp;
            //    dgvDanhSachSanPham.CurrentRow.Cells[1].Value = spl.TenSp;
            //    dgvDanhSachSanPham.CurrentRow.Cells[2].Value = spl.MaSx;
            //    dgvDanhSachSanPham.CurrentRow.Cells[3].Value = spl.MaLoai;
            //    dgvDanhSachSanPham.CurrentRow.Cells[4].Value = spl.GiaThanh;

            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[0].Value = spl.MaSp;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[1].Value = spl.Cpu;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[2].Value = spl.Ram;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[3].Value = spl.Ocung;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[4].Value = spl.ManHinh;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[5].Value = spl.CardManHinh;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[6].Value = spl.CongKetNoi;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[7].Value = spl.Hdt;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[8].Value = spl.AmThanh;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[9].Value = spl.DiaQuang;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[10].Value = spl.GiaoTiepMang;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[11].Value = spl.WebCam;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[12].Value = spl.Pin;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[13].Value = spl.TrongLuong;
            //    dgvDanhSachChiTietSanPham.CurrentRow.Cells[14].Value = spl.BaoHanh;

            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[0].Value = spl.MaSp;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[1].Value = spl.Cpu;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[2].Value = spl.Ram;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[3].Value = spl.Ocung;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[4].Value = spl.ManHinh;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[5].Value = spl.CardManHinh;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[6].Value = spl.CongKetNoi;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[7].Value = spl.Hdt;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[8].Value = spl.AmThanh;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[9].Value = spl.DiaQuang;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[10].Value = spl.GiaoTiepMang;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[11].Value = spl.WebCam;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[12].Value = spl.Pin;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[13].Value = spl.TrongLuong;
            //    //dgvDanhSachChiTietSanPham.Rows[0].Cells[14].Value = spl.BaoHanh;

            //    //dataGridView1.Columns.Add("ma","sp");
            //    //dataGridView1.Rows.Add(spl.TenSp);
            //    //dataGridView1.Rows.Add(spl.MaSx);
            //    //dataGridView1.Rows.Add(spl.MaLoai);
            //    //dataGridView1.Rows.Add(spl.GiaThanh);
            //    //dataGridView1.Rows.Add(spl.Cpu);
            //    //dataGridView1.Rows.Add(spl.Ram);
            //    //dataGridView1.Rows.Add(spl.Ocung);
            //    //dataGridView1.Rows.Add(spl.ManHinh);
            //    //dataGridView1.Rows.Add(spl.CardManHinh);
            //    //dataGridView1.Rows.Add(spl.CongKetNoi);
            //    //dataGridView1.Rows.Add(spl.Hdt);
            //    //dataGridView1.Rows.Add(spl.AmThanh);
            //    //dataGridView1.Rows.Add(spl.DiaQuang);
            //    //dataGridView1.Rows.Add(spl.GiaoTiepMang);
            //    //dataGridView1.Rows.Add(spl.WebCam);
            //    //dataGridView1.Rows.Add(spl.Pin);
            //    //dataGridView1.Rows.Add(spl.TrongLuong);
            //    //dataGridView1.Rows.Add(spl.BaoHanh);


            //    //row1.Cells[0].Value = spl.MaSp.ToString();
            //    //row1.Cells[1].Value = spl.TenSp.ToString();
            //    //row1.Cells[2].Value = spl.MaSx.ToString();
            //    //row1.Cells[3].Value = spl.MaLoai.ToString();
            //    //row1.Cells[4].Value = spl.GiaThanh.ToString();
            //    //dgvDanhSachSanPham.Rows.Add(row1);

            //    //row1.Cells[5].Value = spl.Cpu.ToString();
            //    //row1.Cells[6].Value = spl.Ram.ToString();
            //    //row1.Cells[7].Value = spl.Ocung.ToString();
            //    //row1.Cells[8].Value = spl.ManHinh.ToString();
            //    //row1.Cells[9].Value = spl.CardManHinh.ToString();
            //    //row1.Cells[10].Value = spl.CongKetNoi.ToString();
            //    //row1.Cells[11].Value = spl.Hdt.ToString();
            //    //row1.Cells[12].Value = spl.AmThanh.ToString();
            //    //row1.Cells[13].Value = spl.DiaQuang.ToString();
            //    //row1.Cells[14].Value = spl.GiaoTiepMang.ToString();
            //    //row1.Cells[15].Value = spl.WebCam.ToString();
            //    //row1.Cells[16].Value = spl.Pin.ToString();
            //    //row1.Cells[17].Value = spl.TrongLuong.ToString();
            //    //row1.Cells[18].Value = spl.BaoHanh.ToString();
            //    ////dgvDanhSachChiTietSanPham.Rows.Add(row2);
            //    //dataGridView1.Rows.Add(row1);
            //}
            #endregion
        }

        private void cboMaSx_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            //if (cboMaSx.SelectedIndex == -1)
            //{
            //    return;
            //}
            ////if(cboSearch.SelectedIndex == 0)
            ////{
            ////}
            //sp.MaSx = int.Parse(cboMaSx.Text);
            //cboTenSx.DataSource = spbll.ShowNameNhaSxFlow(sp);
            #endregion
        }

        private void cboMaSx_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            //if (cboMaLoai.SelectedIndex == -1)
            //{
            //    return;
            //}

            //sp.MaLoai = int.Parse(cboMaLoai.Text);
            //cboTenLoai.DataSource = spbll.ShowNameLoaiSpFlow(sp);
            #endregion
        }

        private void cboTenSx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSx.SelectedIndex == -1)
            {
                return;
            }

            sp.TenSx = cboTenSx.Text;
            cboMaSx.DataSource = spbll.ShowIdNhaSxFlow(sp);
        }

        private void cboTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboTenLoai.SelectedIndex == -1)
            {
                return;
            }
//            label6.Text = cboTenLoai.Text;

            sp.TenLoai = cboTenLoai.Text;
            cboMaLoai.DataSource = spbll.ShowIdLoaiSanPhamFlow(sp);
        }
    }
}
