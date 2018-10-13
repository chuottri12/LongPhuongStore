namespace GUI
{
    partial class UCMatHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.grbCommon = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpAdvanceSearch = new System.Windows.Forms.GroupBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.tkmaloai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbtenbanh = new System.Windows.Forms.TextBox();
            this.tbmabanh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgbanh = new System.Windows.Forms.DataGridView();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbmaloaibanh = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNpp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGiaBanSi = new System.Windows.Forms.TextBox();
            this.tbGiaBanLe = new System.Windows.Forms.TextBox();
            this.tbSLTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDonViTinh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNotice = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grbCommon.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpAdvanceSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpFunction.SuspendLayout();
            this.grpBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1231, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN HÀNG HÓA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbCommon
            // 
            this.grbCommon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbCommon.Controls.Add(this.tabControl1);
            this.grbCommon.Controls.Add(this.groupBox1);
            this.grbCommon.Location = new System.Drawing.Point(1, 105);
            this.grbCommon.Name = "grbCommon";
            this.grbCommon.Size = new System.Drawing.Size(1325, 547);
            this.grbCommon.TabIndex = 6;
            this.grbCommon.TabStop = false;
            this.grbCommon.Text = "Common";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(6, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.Controls.Add(this.tkmaloai);
            this.tabPage1.Controls.Add(this.grpAdvanceSearch);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "                               Danh sách hàng hóa                              ";
            // 
            // grpAdvanceSearch
            // 
            this.grpAdvanceSearch.BackColor = System.Drawing.Color.White;
            this.grpAdvanceSearch.Controls.Add(this.dgbanh);
            this.grpAdvanceSearch.Controls.Add(this.tbtenbanh);
            this.grpAdvanceSearch.Controls.Add(this.label13);
            this.grpAdvanceSearch.Controls.Add(this.lblTong);
            this.grpAdvanceSearch.Controls.Add(this.tbmabanh);
            this.grpAdvanceSearch.Controls.Add(this.label16);
            this.grpAdvanceSearch.Controls.Add(this.label14);
            this.grpAdvanceSearch.Controls.Add(this.btnSearch);
            this.grpAdvanceSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdvanceSearch.Location = new System.Drawing.Point(3, 50);
            this.grpAdvanceSearch.Name = "grpAdvanceSearch";
            this.grpAdvanceSearch.Size = new System.Drawing.Size(360, 413);
            this.grpAdvanceSearch.TabIndex = 7;
            this.grpAdvanceSearch.TabStop = false;
            this.grpAdvanceSearch.Text = "Advance Search";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(132, 378);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(36, 16);
            this.lblTong.TabIndex = 35;
            this.lblTong.Text = "1000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Tổng số sản phẩm:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.grpFunction);
            this.groupBox1.Controls.Add(this.grpBasicInfo);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(386, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 484);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // grpFunction
            // 
            this.grpFunction.BackColor = System.Drawing.Color.DodgerBlue;
            this.grpFunction.Controls.Add(this.btxoa);
            this.grpFunction.Controls.Add(this.bthuy);
            this.grpFunction.Controls.Add(this.btluu);
            this.grpFunction.Controls.Add(this.btsua);
            this.grpFunction.Controls.Add(this.btthem);
            this.grpFunction.Location = new System.Drawing.Point(10, 362);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Size = new System.Drawing.Size(910, 109);
            this.grpFunction.TabIndex = 20;
            this.grpFunction.TabStop = false;
            this.grpFunction.Text = "Chuc nang";
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(708, 37);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(107, 38);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(547, 37);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(107, 38);
            this.bthuy.TabIndex = 5;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = true;
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(396, 37);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(107, 38);
            this.btluu.TabIndex = 4;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(231, 37);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(107, 38);
            this.btsua.TabIndex = 3;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(65, 37);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(107, 38);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // grpBasicInfo
            // 
            this.grpBasicInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grpBasicInfo.Controls.Add(this.label11);
            this.grpBasicInfo.Controls.Add(this.tbNotice);
            this.grpBasicInfo.Controls.Add(this.tbDonViTinh);
            this.grpBasicInfo.Controls.Add(this.label10);
            this.grpBasicInfo.Controls.Add(this.tbSLTon);
            this.grpBasicInfo.Controls.Add(this.label6);
            this.grpBasicInfo.Controls.Add(this.tbGiaBanLe);
            this.grpBasicInfo.Controls.Add(this.tbGiaBanSi);
            this.grpBasicInfo.Controls.Add(this.label5);
            this.grpBasicInfo.Controls.Add(this.label3);
            this.grpBasicInfo.Controls.Add(this.label2);
            this.grpBasicInfo.Controls.Add(this.cbbNpp);
            this.grpBasicInfo.Controls.Add(this.tbGiaNhap);
            this.grpBasicInfo.Controls.Add(this.label4);
            this.grpBasicInfo.Controls.Add(this.label9);
            this.grpBasicInfo.Controls.Add(this.textBox1);
            this.grpBasicInfo.Controls.Add(this.label8);
            this.grpBasicInfo.Controls.Add(this.cbmaloaibanh);
            this.grpBasicInfo.Controls.Add(this.textBox2);
            this.grpBasicInfo.Controls.Add(this.label7);
            this.grpBasicInfo.Location = new System.Drawing.Point(10, 31);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(910, 322);
            this.grpBasicInfo.TabIndex = 18;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "Basic Information";
            // 
            // tkmaloai
            // 
            this.tkmaloai.Location = new System.Drawing.Point(128, 13);
            this.tkmaloai.Name = "tkmaloai";
            this.tkmaloai.Size = new System.Drawing.Size(170, 23);
            this.tkmaloai.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "Loại mặt hàng";
            // 
            // tbtenbanh
            // 
            this.tbtenbanh.Location = new System.Drawing.Point(96, 76);
            this.tbtenbanh.Name = "tbtenbanh";
            this.tbtenbanh.Size = new System.Drawing.Size(171, 23);
            this.tbtenbanh.TabIndex = 10;
            // 
            // tbmabanh
            // 
            this.tbmabanh.Location = new System.Drawing.Point(96, 32);
            this.tbmabanh.Name = "tbmabanh";
            this.tbmabanh.Size = new System.Drawing.Size(171, 23);
            this.tbmabanh.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tên sản phẩm";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mã sản phẩm";
            // 
            // dgbanh
            // 
            this.dgbanh.BackgroundColor = System.Drawing.Color.White;
            this.dgbanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tenSanPham,
            this.loaiSanPham});
            this.dgbanh.Location = new System.Drawing.Point(6, 111);
            this.dgbanh.Name = "dgbanh";
            this.dgbanh.RowHeadersVisible = false;
            this.dgbanh.Size = new System.Drawing.Size(350, 229);
            this.dgbanh.TabIndex = 36;
            // 
            // maSanPham
            // 
            this.maSanPham.HeaderText = "Mã sản phẩm";
            this.maSanPham.Name = "maSanPham";
            this.maSanPham.Width = 115;
            // 
            // tenSanPham
            // 
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.Width = 117;
            // 
            // loaiSanPham
            // 
            this.loaiSanPham.HeaderText = "Loại sản phẩm";
            this.loaiSanPham.Name = "loaiSanPham";
            this.loaiSanPham.Width = 115;
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(146, 172);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(114, 23);
            this.tbGiaNhap.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 23);
            this.textBox1.TabIndex = 3;
            // 
            // cbmaloaibanh
            // 
            this.cbmaloaibanh.FormattingEnabled = true;
            this.cbmaloaibanh.Location = new System.Drawing.Point(146, 125);
            this.cbmaloaibanh.Name = "cbmaloaibanh";
            this.cbmaloaibanh.Size = new System.Drawing.Size(274, 24);
            this.cbmaloaibanh.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(741, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá nhập";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại sản phẩm";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(465, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhà phân phối";
            // 
            // cbbNpp
            // 
            this.cbbNpp.FormattingEnabled = true;
            this.cbbNpp.Location = new System.Drawing.Point(578, 125);
            this.cbbNpp.Name = "cbbNpp";
            this.cbbNpp.Size = new System.Drawing.Size(309, 24);
            this.cbbNpp.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(335, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá bán sỉ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(669, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá bán lẻ";
            // 
            // tbGiaBanSi
            // 
            this.tbGiaBanSi.Location = new System.Drawing.Point(439, 172);
            this.tbGiaBanSi.Name = "tbGiaBanSi";
            this.tbGiaBanSi.Size = new System.Drawing.Size(114, 23);
            this.tbGiaBanSi.TabIndex = 13;
            // 
            // tbGiaBanLe
            // 
            this.tbGiaBanLe.Location = new System.Drawing.Point(774, 172);
            this.tbGiaBanLe.Name = "tbGiaBanLe";
            this.tbGiaBanLe.Size = new System.Drawing.Size(114, 23);
            this.tbGiaBanLe.TabIndex = 14;
            // 
            // tbSLTon
            // 
            this.tbSLTon.Location = new System.Drawing.Point(827, 82);
            this.tbSLTon.Name = "tbSLTon";
            this.tbSLTon.Size = new System.Drawing.Size(63, 23);
            this.tbSLTon.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(705, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số lượng còn";
            // 
            // tbDonViTinh
            // 
            this.tbDonViTinh.Location = new System.Drawing.Point(578, 82);
            this.tbDonViTinh.Name = "tbDonViTinh";
            this.tbDonViTinh.Size = new System.Drawing.Size(76, 23);
            this.tbDonViTinh.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(465, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đơn vị tính";
            // 
            // tbNotice
            // 
            this.tbNotice.Location = new System.Drawing.Point(146, 233);
            this.tbNotice.Name = "tbNotice";
            this.tbNotice.Size = new System.Drawing.Size(741, 71);
            this.tbNotice.TabIndex = 19;
            this.tbNotice.Text = "";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(24, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ghi chú";
            // 
            // UCBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.grbCommon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCBanh";
            this.Size = new System.Drawing.Size(1326, 655);
            this.Load += new System.EventHandler(this.UCBanh_Load);
            this.grbCommon.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpAdvanceSearch.ResumeLayout(false);
            this.grpAdvanceSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpFunction.ResumeLayout(false);
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCommon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpAdvanceSearch;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.TextBox tkmaloai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbtenbanh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbmabanh;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgbanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSanPham;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmaloaibanh;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNpp;
        private System.Windows.Forms.TextBox tbGiaBanLe;
        private System.Windows.Forms.TextBox tbGiaBanSi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDonViTinh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSLTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox tbNotice;
    }
}
