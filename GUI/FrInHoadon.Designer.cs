namespace GUI
{
    partial class FrInHoadon
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
            this.HoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanlybanbanhDataSet2 = new GUI.QuanlybanbanhDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoadonTableAdapter = new GUI.QuanlybanbanhDataSet2TableAdapters.HoadonTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanbanhDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // HoadonBindingSource
            // 
            this.HoadonBindingSource.DataMember = "Hoadon";
            this.HoadonBindingSource.DataSource = this.QuanlybanbanhDataSet2;
            // 
            // QuanlybanbanhDataSet2
            // 
            this.QuanlybanbanhDataSet2.DataSetName = "QuanlybanbanhDataSet2";
            this.QuanlybanbanhDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoadonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.RInhoadon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1088, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoadonTableAdapter
            // 
            this.HoadonTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(433, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã hóa đơn";
            // 
            // FrInHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrInHoadon";
            this.Text = "FrInHoadon";
            this.Load += new System.EventHandler(this.FrInHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanlybanbanhDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoadonBindingSource;
        private QuanlybanbanhDataSet2 QuanlybanbanhDataSet2;
        private QuanlybanbanhDataSet2TableAdapters.HoadonTableAdapter HoadonTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}