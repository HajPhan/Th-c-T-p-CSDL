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


namespace GUI
{
    public partial class frm_DONDH : Form
    {
        /// <summary>
        /// 
        /// </summary>

        DonDatHangBLL dhbll = new DonDatHangBLL();
        DonDatHang dh = new DonDatHang();

        public frm_DONDH()
        {
            InitializeComponent();

            txtSearch.ForeColor = Color.LightGray;
            txtSearch.Text = "Search Here";
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
        }

        private void frm_DONDH_Load(object sender, EventArgs e)
        {
            HienThiDonHang();
        }


        private void HienThiDonHang()
        {

            dgvDonDh.DataSource = dhbll.ShowDataDonDatHang();
            dgvCTDH.DataSource = dhbll.ShowDataCTDH();
            cboMaSp.DataSource = dhbll.ShowDataMaSp();
            cboTenCC.DataSource = dhbll.LoadTenNhaCC();
            cboMaCC.DataSource = dhbll.LoadComboBoxMacc();
            txtMaNv.Text = UserInfo.Id.ToString();
            txtMaNv.Enabled = false;
            txtMaDh.Enabled = false;

            // Căn chỉnh kích thước cột: Tên cột cho vào giữa cột
            dgvDonDh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCTDH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvDonDh.AutoResizeColumns();
            //dgvCTDH.AutoResizeColumns();
            dgvDonDh.Columns[3].Width = 200;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LamMoi();

        }

        private void LamMoi()
        {
            txtSearch.Text = "";
            txtMaDh.Text = "";
            cboMaCC.Text = "";
            cboMaSp.Text = "";
            cboSoLuongDH.Text = "";
            cboTenCC.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dh.MaNv = int.Parse(txtMaNv.Text);
                dh.MaCc = int.Parse(cboMaCC.Text);
                dh.MaSp = int.Parse(cboMaSp.Text);
                dh.SlDh = int.Parse(cboSoLuongDH.Text);
                dh.NgayDh = DateTime.Now;
                bool result = dhbll.InsertDonDatHang(dh);
                
                if (result)
                {
                    DialogResult dr = MessageBox.Show("Insert Success !", "Thông báo", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        HienThiDonHang();
                    }

                }
                else
                {
                    MessageBox.Show("Insert Not Success !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Save !" + ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            lbDateTime.Text = datetime;
        }

        private void dgvDonDh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDh.Text = dgvDonDh.CurrentRow.Cells[0].Value.ToString();
            txtMaNv.Text = dgvDonDh.CurrentRow.Cells[1].Value.ToString();
            cboMaCC.Text = dgvDonDh.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboMaSp.Text = dgvCTDH.CurrentRow.Cells[1].Value.ToString();
            cboSoLuongDH.Text = dgvCTDH.CurrentRow.Cells[2].Value.ToString();

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
    }
}
