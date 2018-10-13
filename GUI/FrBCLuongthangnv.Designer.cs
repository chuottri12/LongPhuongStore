namespace GUI
{
    partial class FrBCLuongthangnv
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
            this.QuanlybanbanhDataSet2 = new GUI.QuanlybanbanhDataSet2();
            this.VWLuongThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VWLuongThangTableAdapter = new GUI.QuanlybanbanhDataSet2TableAdapters.VWLuongThangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanbanhDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VWLuongThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.VWLuongThangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.RBaocaoluongnv.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(956, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanlybanbanhDataSet2
            // 
            this.QuanlybanbanhDataSet2.DataSetName = "QuanlybanbanhDataSet2";
            this.QuanlybanbanhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VWLuongThangBindingSource
            // 
            this.VWLuongThangBindingSource.DataMember = "VWLuongThang";
            this.VWLuongThangBindingSource.DataSource = this.QuanlybanbanhDataSet2;
            // 
            // VWLuongThangTableAdapter
            // 
            this.VWLuongThangTableAdapter.ClearBeforeFill = true;
            // 
            // FrBCLuongthangnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 498);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrBCLuongthangnv";
            this.Text = "FrBCLuongthangnv";
            this.Load += new System.EventHandler(this.FrBCLuongthangnv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanbanhDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VWLuongThangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VWLuongThangBindingSource;
        private QuanlybanbanhDataSet2 QuanlybanbanhDataSet2;
        private QuanlybanbanhDataSet2TableAdapters.VWLuongThangTableAdapter VWLuongThangTableAdapter;
    }
}