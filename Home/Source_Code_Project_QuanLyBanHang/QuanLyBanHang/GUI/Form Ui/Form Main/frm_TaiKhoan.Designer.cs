namespace GUI
{
    partial class frm_TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNon_Permission = new System.Windows.Forms.Button();
            this.cboMaQuyen = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel_QLBH = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDS_QLBH = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuyen_QLBH = new System.Windows.Forms.Button();
            this.cboQuyen_QLBH = new System.Windows.Forms.ComboBox();
            this.panel_NVBH = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPermission = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_QLBH.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS_QLBH)).BeginInit();
            this.panel_NVBH.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 628);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Tài Khoản Nhân Viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSTaiKhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 566);
            this.panel2.TabIndex = 3;
            // 
            // dgvDSTaiKhoan
            // 
            this.dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.user,
            this.password,
            this.name,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDSTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            this.dgvDSTaiKhoan.Size = new System.Drawing.Size(743, 566);
            this.dgvDSTaiKhoan.TabIndex = 0;
            this.dgvDSTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTaiKhoan_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNon_Permission);
            this.panel1.Controls.Add(this.cboMaQuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnNon_Permission
            // 
            this.btnNon_Permission.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNon_Permission.Location = new System.Drawing.Point(0, 21);
            this.btnNon_Permission.Name = "btnNon_Permission";
            this.btnNon_Permission.Size = new System.Drawing.Size(743, 23);
            this.btnNon_Permission.TabIndex = 3;
            this.btnNon_Permission.Text = "NonPermission";
            this.btnNon_Permission.UseVisualStyleBackColor = true;
            this.btnNon_Permission.Click += new System.EventHandler(this.btnNon_Permission_Click);
            // 
            // cboMaQuyen
            // 
            this.cboMaQuyen.DisplayMember = "MAQH";
            this.cboMaQuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMaQuyen.FormattingEnabled = true;
            this.cboMaQuyen.Location = new System.Drawing.Point(0, 0);
            this.cboMaQuyen.Name = "cboMaQuyen";
            this.cboMaQuyen.Size = new System.Drawing.Size(743, 21);
            this.cboMaQuyen.TabIndex = 2;
            this.cboMaQuyen.ValueMember = "MAQH";
            this.cboMaQuyen.SelectedIndexChanged += new System.EventHandler(this.cboMaQuyen_SelectedIndexChanged);
            this.cboMaQuyen.TextChanged += new System.EventHandler(this.cboMaQuyen_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(653, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(554, 40);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel_QLBH
            // 
            this.panel_QLBH.Controls.Add(this.panel4);
            this.panel_QLBH.Controls.Add(this.btnQuyen_QLBH);
            this.panel_QLBH.Controls.Add(this.cboQuyen_QLBH);
            this.panel_QLBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_QLBH.Location = new System.Drawing.Point(3, 3);
            this.panel_QLBH.Name = "panel_QLBH";
            this.panel_QLBH.Size = new System.Drawing.Size(493, 380);
            this.panel_QLBH.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDS_QLBH);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 336);
            this.panel4.TabIndex = 3;
            // 
            // dgvDS_QLBH
            // 
            this.dgvDS_QLBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDS_QLBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column9});
            this.dgvDS_QLBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDS_QLBH.Location = new System.Drawing.Point(0, 0);
            this.dgvDS_QLBH.Name = "dgvDS_QLBH";
            this.dgvDS_QLBH.Size = new System.Drawing.Size(493, 336);
            this.dgvDS_QLBH.TabIndex = 1;
            this.dgvDS_QLBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDS_QLBH_CellClick);
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Username";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Password";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "FullName";
            this.Column12.Name = "Column12";
            this.Column12.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "nonPermission";
            this.Column9.Name = "Column9";
            // 
            // btnQuyen_QLBH
            // 
            this.btnQuyen_QLBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuyen_QLBH.Location = new System.Drawing.Point(0, 21);
            this.btnQuyen_QLBH.Name = "btnQuyen_QLBH";
            this.btnQuyen_QLBH.Size = new System.Drawing.Size(493, 23);
            this.btnQuyen_QLBH.TabIndex = 2;
            this.btnQuyen_QLBH.Text = "nonPermission";
            this.btnQuyen_QLBH.UseVisualStyleBackColor = true;
            // 
            // cboQuyen_QLBH
            // 
            this.cboQuyen_QLBH.DisplayMember = "MAQH";
            this.cboQuyen_QLBH.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboQuyen_QLBH.FormattingEnabled = true;
            this.cboQuyen_QLBH.Location = new System.Drawing.Point(0, 0);
            this.cboQuyen_QLBH.Name = "cboQuyen_QLBH";
            this.cboQuyen_QLBH.Size = new System.Drawing.Size(493, 21);
            this.cboQuyen_QLBH.TabIndex = 0;
            this.cboQuyen_QLBH.ValueMember = "MAQH";
            this.cboQuyen_QLBH.SelectedIndexChanged += new System.EventHandler(this.cboQuyen_QLBH_SelectedIndexChanged);
            this.cboQuyen_QLBH.TextChanged += new System.EventHandler(this.cboQuyen_QLBH_TextChanged);
            // 
            // panel_NVBH
            // 
            this.panel_NVBH.Controls.Add(this.groupBox3);
            this.panel_NVBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_NVBH.Location = new System.Drawing.Point(3, 389);
            this.panel_NVBH.Name = "panel_NVBH";
            this.panel_NVBH.Size = new System.Drawing.Size(493, 217);
            this.panel_NVBH.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.txtPermission);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.txtFullname);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 217);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chi Tiết Tài Khoản";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(378, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(149, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(304, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPermission
            // 
            this.txtPermission.Location = new System.Drawing.Point(149, 126);
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Size = new System.Drawing.Size(304, 20);
            this.txtPermission.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PassWord:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Permission:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 74);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(304, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(149, 100);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(304, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FullName:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(749, 628);
            this.panel7.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel_QLBH, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel_NVBH, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(499, 609);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(749, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 628);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản Theo Từng Quyền Hạn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // user
            // 
            this.user.HeaderText = "Username";
            this.user.Name = "user";
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // name
            // 
            this.name.HeaderText = "FullName";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "QLBH";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NVBH";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "NVNEW";
            this.Column6.Name = "Column6";
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Name = "frm_TaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TaiKhoan";
            this.Load += new System.EventHandler(this.frm_TaiKhoan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_QLBH.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDS_QLBH)).EndInit();
            this.panel_NVBH.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataGridView dgvDSTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNon_Permission;
        private System.Windows.Forms.ComboBox cboMaQuyen;
        private System.Windows.Forms.Panel panel_QLBH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDS_QLBH;
        private System.Windows.Forms.Button btnQuyen_QLBH;
        private System.Windows.Forms.ComboBox cboQuyen_QLBH;
        private System.Windows.Forms.Panel panel_NVBH;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPermission;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
    }
}