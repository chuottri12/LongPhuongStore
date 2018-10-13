namespace GUI
{
    partial class FrBCDanhsachkhachhang
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
            this.QuanlybanbanhDataSet1 = new GUI.QuanlybanbanhDataSet1();
            this.KhachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachhangTableAdapter = new GUI.QuanlybanbanhDataSet1TableAdapters.KhachhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanbanhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachhangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KhachhangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.RDanhsachkhachhang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(938, 502);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanlybanbanhDataSet1
            // 
            this.QuanlybanbanhDataSet1.DataSetName = "QuanlybanbanhDataSet1";
            this.QuanlybanbanhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhachhangBindingSource
            // 
            this.KhachhangBindingSource.DataMember = "Khachhang";
            this.KhachhangBindingSource.DataSource = this.QuanlybanbanhDataSet1;
            // 
            // KhachhangTableAdapter
            // 
            this.KhachhangTableAdapter.ClearBeforeFill = true;
            // 
            // FrBCDanhsachkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 502);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrBCDanhsachkhachhang";
            this.Text = "FrBCDanhsachkhachhang";
            this.Load += new System.EventHandler(this.FrBCDanhsachkhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanbanhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachhangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KhachhangBindingSource;
        private QuanlybanbanhDataSet1 QuanlybanbanhDataSet1;
        private QuanlybanbanhDataSet1TableAdapters.KhachhangTableAdapter KhachhangTableAdapter;
    }
}