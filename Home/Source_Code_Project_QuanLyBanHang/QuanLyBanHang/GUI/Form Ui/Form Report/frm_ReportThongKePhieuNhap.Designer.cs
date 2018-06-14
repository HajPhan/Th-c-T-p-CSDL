

namespace GUI
{
    partial class frm_ReportThongKePhieuNhap
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
            this.vw_ThongKeDonDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLBANHANGDataSet = new GUI.QLBANHANGDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vw_ThongKeDonDatHangTableAdapter = new GUI.QLBANHANGDataSetTableAdapters.vw_ThongKeDonDatHangTableAdapter();
            this.TONKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TONKHOTableAdapter = new GUI.QLBANHANGDataSetTableAdapters.TONKHOTableAdapter();
            this.PHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PHIEUNHAPTableAdapter = new GUI.QLBANHANGDataSetTableAdapters.PHIEUNHAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vw_ThongKeDonDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TONKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vw_ThongKeDonDatHangBindingSource
            // 
            this.vw_ThongKeDonDatHangBindingSource.DataMember = "vw_ThongKeDonDatHang";
            this.vw_ThongKeDonDatHangBindingSource.DataSource = this.QLBANHANGDataSet;
            // 
            // QLBANHANGDataSet
            // 
            this.QLBANHANGDataSet.DataSetName = "QLBANHANGDataSet";
            this.QLBANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PHIEUNHAPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportPhieuNhap.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // vw_ThongKeDonDatHangTableAdapter
            // 
            this.vw_ThongKeDonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // TONKHOBindingSource
            // 
            this.TONKHOBindingSource.DataMember = "TONKHO";
            this.TONKHOBindingSource.DataSource = this.QLBANHANGDataSet;
            // 
            // TONKHOTableAdapter
            // 
            this.TONKHOTableAdapter.ClearBeforeFill = true;
            // 
            // PHIEUNHAPBindingSource
            // 
            this.PHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            this.PHIEUNHAPBindingSource.DataSource = this.QLBANHANGDataSet;
            // 
            // PHIEUNHAPTableAdapter
            // 
            this.PHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReportThongKePhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReportThongKePhieuNhap";
            this.Text = "frm_ReportThongKePhieuNhap";
            this.Load += new System.EventHandler(this.frm_ReportThongKePhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vw_ThongKeDonDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLBANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TONKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_ThongKeDonDatHangBindingSource;
        private QLBANHANGDataSet QLBANHANGDataSet;
        private QLBANHANGDataSetTableAdapters.vw_ThongKeDonDatHangTableAdapter vw_ThongKeDonDatHangTableAdapter;
        private System.Windows.Forms.BindingSource TONKHOBindingSource;
        private QLBANHANGDataSetTableAdapters.TONKHOTableAdapter TONKHOTableAdapter;
        private System.Windows.Forms.BindingSource PHIEUNHAPBindingSource;
        private QLBANHANGDataSetTableAdapters.PHIEUNHAPTableAdapter PHIEUNHAPTableAdapter;
    }
}