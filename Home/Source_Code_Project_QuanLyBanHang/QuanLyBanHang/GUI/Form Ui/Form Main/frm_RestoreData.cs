﻿using System;
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
    public partial class frm_RestoreData : Form
    {

        SaoLuu sl = new SaoLuu();
        SaoLuuBLL slbll = new SaoLuuBLL();

        public frm_RestoreData()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChoose.Text = dlg.FileName;
                btnOk.Enabled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                sl.Path = txtChoose.Text;
                bool result = slbll.RestoreDataBase(sl);
                if (result)
                {
                    MessageBox.Show("Restore thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Restore! " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_RestoreData_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
        }
    }
}
