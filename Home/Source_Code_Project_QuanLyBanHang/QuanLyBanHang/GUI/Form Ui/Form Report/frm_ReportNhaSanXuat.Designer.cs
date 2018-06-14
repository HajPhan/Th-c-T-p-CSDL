

namespace GUI
{
    partial class frm_ReportNhaSanXuat
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
            this.NHASXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHASXTableAdapter = new GUI.ds_QLBanHangTableAdapters.NHASXTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHASXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNhaSanXuat";
            reportDataSource1.Value = this.NHASXBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.ReportNhaSanXuat.rdlc";
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
            // NHASXBindingSource
            // 
            this.NHASXBindingSource.DataMember = "NHASX";
            this.NHASXBindingSource.DataSource = this.ds_QLBanHang;
            // 
            // NHASXTableAdapter
            // 
            this.NHASXTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReportNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 696);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReportNhaSanXuat";
            this.Text = "frm_ReportNhaSanXuat";
            this.Load += new System.EventHandler(this.frm_ReportNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHASXBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHASXBindingSource;
        private ds_QLBanHang ds_QLBanHang;
        private ds_QLBanHangTableAdapters.NHASXTableAdapter NHASXTableAdapter;
    }
}