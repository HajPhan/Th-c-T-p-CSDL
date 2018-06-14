

namespace GUI
{
    partial class frm_ReportLoaiSanPham
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds_QLBanHang = new GUI.ds_QLBanHang();
            this.LOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LOAISPTableAdapter = new GUI.ds_QLBanHangTableAdapters.LOAISPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAISPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetLoaiSanPham";
            reportDataSource1.Value = this.LOAISPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.ReportLoaiSanPham.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1091, 696);
            this.reportViewer1.TabIndex = 0;
            // 
            // ds_QLBanHang
            // 
            this.ds_QLBanHang.DataSetName = "ds_QLBanHang";
            this.ds_QLBanHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LOAISPBindingSource
            // 
            this.LOAISPBindingSource.DataMember = "LOAISP";
            this.LOAISPBindingSource.DataSource = this.ds_QLBanHang;
            // 
            // LOAISPTableAdapter
            // 
            this.LOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReportLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 696);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReportLoaiSanPham";
            this.Text = "frm_ReportLoaiSanPham";
            this.Load += new System.EventHandler(this.frm_ReportLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOAISPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LOAISPBindingSource;
        private ds_QLBanHang ds_QLBanHang;
        private ds_QLBanHangTableAdapters.LOAISPTableAdapter LOAISPTableAdapter;
    }
}