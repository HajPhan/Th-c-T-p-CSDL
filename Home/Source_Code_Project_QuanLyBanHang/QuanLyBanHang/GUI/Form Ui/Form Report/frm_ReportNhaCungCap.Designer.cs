﻿

namespace GUI
{
    partial class frm_ReportNhaCungCap
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
            this.NHACCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHACCTableAdapter = new GUI.ds_QLBanHangTableAdapters.NHACCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHACCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetNhaCungCap";
            reportDataSource1.Value = this.NHACCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report.ReportNhaCungCap.rdlc";
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
            // NHACCBindingSource
            // 
            this.NHACCBindingSource.DataMember = "NHACC";
            this.NHACCBindingSource.DataSource = this.ds_QLBanHang;
            // 
            // NHACCTableAdapter
            // 
            this.NHACCTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReportNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 696);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReportNhaCungCap";
            this.Text = "frm_ReportNhaCungCap";
            this.Load += new System.EventHandler(this.frm_ReportNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_QLBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHACCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHACCBindingSource;
        private ds_QLBanHang ds_QLBanHang;
        private ds_QLBanHangTableAdapters.NHACCTableAdapter NHACCTableAdapter;
    }
}