namespace GUI.Form_Ui.Form_Report
{
    partial class frm_ReportSanPham
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLBANHANGDataSet = new GUI.QLBANHANGDataSet();
            this.vwDanhSachSanPhamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_DanhSachSanPhamsTableAdapter = new GUI.QLBANHANGDataSetTableAdapters.vw_DanhSachSanPhamsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDanhSachSanPhamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vwDanhSachSanPhamsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.ReportSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLBANHANGDataSet
            // 
            this.qLBANHANGDataSet.DataSetName = "QLBANHANGDataSet";
            this.qLBANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDanhSachSanPhamsBindingSource
            // 
            this.vwDanhSachSanPhamsBindingSource.DataMember = "vw_DanhSachSanPhams";
            this.vwDanhSachSanPhamsBindingSource.DataSource = this.qLBANHANGDataSet;
            // 
            // vw_DanhSachSanPhamsTableAdapter
            // 
            this.vw_DanhSachSanPhamsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReportSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReportSanPham";
            this.Text = "frm_ReportSanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ReportSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDanhSachSanPhamsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLBANHANGDataSet qLBANHANGDataSet;
        private System.Windows.Forms.BindingSource vwDanhSachSanPhamsBindingSource;
        private QLBANHANGDataSetTableAdapters.vw_DanhSachSanPhamsTableAdapter vw_DanhSachSanPhamsTableAdapter;
    }
}