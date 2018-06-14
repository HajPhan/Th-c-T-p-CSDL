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


namespace GUI.Form_Ui.Form_Main
{
    public partial class frm_InsertTongDauTonKho : Form
    {
        ThongKe tk = new ThongKe();
        ThongKeBLL tkbll = new ThongKeBLL();

        private uc_ThongKe_TonKho tks { get; set; }
        public frm_InsertTongDauTonKho(uc_ThongKe_TonKho tks)
        {
            InitializeComponent();
            this.tks = tks;
        }

        private void frm_InsertTongDauTonKho_Load(object sender, EventArgs e)
        {
            txtMaSp.Text = ThongKe.MasP.ToString();
            txtMaSp.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tk.Sld = int.Parse(txtTongSld.Text);
            //txtMaSp.Text = ThongKe.MasP.ToString();
            tk.MaSp = int.Parse(txtMaSp.Text);

            bool result = tkbll.UpdateTongSldTonKho(tk);

            if (result)
            {
                tks.ThongKeTonKho();
                this.Close();
            }
        }
    }
}
