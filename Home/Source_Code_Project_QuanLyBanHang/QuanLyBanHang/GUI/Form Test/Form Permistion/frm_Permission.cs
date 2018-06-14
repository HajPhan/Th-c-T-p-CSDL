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
    public partial class frm_Permission : Form
    {
        //

        PermissonBLL pmsbll = new PermissonBLL();
        Permission pms = new Permission();

        //
        private test_1 test { get; set; }
        public frm_Permission(test_1 test)
        {
            InitializeComponent();
            this.test = test;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {

                pms.idPermission = txtMaQuyen.Text;
                pms.namePermisson = txtTenQuyen.Text;
                pms.notePermisson = txtGhiChu.Text;

                bool result = pmsbll.InsertPermissonInfo(pms);

                if (result)
                {
                    test.HienThiDanhSachNhomQuyen();
//                    test.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Ok!" + ex.Message);
            }


        }
    }
}
