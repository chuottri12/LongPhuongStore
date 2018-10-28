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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchProductName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.productSummaryLabel = new System.Windows.Forms.Label();
            this.searchProductId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.productNoticeText = new System.Windows.Forms.RichTextBox();
            this.productUnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.productAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productRetailPriceText = new System.Windows.Forms.TextBox();
            this.productWholePriceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distributorCombobox = new System.Windows.Forms.ComboBox();
            this.productPurcharsePriceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productTypeCombobox = new System.Windows.Forms.ComboBox();
            this.productIdText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.searchProductType = new System.Windows.Forms.ComboBox();
            this.grbCommon.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpAdvanceSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpFunction.SuspendLayout();
            this.grpBasicInfo.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(6, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.Controls.Add(this.searchProductType);
            this.tabPage1.Controls.Add(this.grpAdvanceSearch);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "                               Danh sách hàng hóa                              ";
            // 
            // grpAdvanceSearch
            // 
            this.grpAdvanceSearch.BackColor = System.Drawing.Color.White;
            this.grpAdvanceSearch.Controls.Add(this.statusLabel);
            this.grpAdvanceSearch.Controls.Add(this.dgvProduct);
            this.grpAdvanceSearch.Controls.Add(this.searchProductName);
            this.grpAdvanceSearch.Controls.Add(this.label13);
            this.grpAdvanceSearch.Controls.Add(this.productSummaryLabel);
            this.grpAdvanceSearch.Controls.Add(this.searchProductId);
            this.grpAdvanceSearch.Controls.Add(this.label16);
            this.grpAdvanceSearch.Controls.Add(this.label14);
            this.grpAdvanceSearch.Controls.Add(this.searchButton);
            this.grpAdvanceSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdvanceSearch.Location = new System.Drawing.Point(3, 50);
            this.grpAdvanceSearch.Name = "grpAdvanceSearch";
            this.grpAdvanceSearch.Size = new System.Drawing.Size(360, 413);
            this.grpAdvanceSearch.TabIndex = 7;
            this.grpAdvanceSearch.TabStop = false;
            this.grpAdvanceSearch.Text = "Advance Search";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tenSanPham,
            this.loaiSanPham});
            this.dgvProduct.Location = new System.Drawing.Point(6, 111);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(350, 229);
            this.dgvProduct.TabIndex = 36;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
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
            // searchProductName
            // 
            this.searchProductName.Location = new System.Drawing.Point(96, 76);
            this.searchProductName.Name = "searchProductName";
            this.searchProductName.Size = new System.Drawing.Size(171, 27);
            this.searchProductName.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 23);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tên sản phẩm";
            // 
            // productSummaryLabel
            // 
            this.productSummaryLabel.AutoSize = true;
            this.productSummaryLabel.Location = new System.Drawing.Point(132, 378);
            this.productSummaryLabel.Name = "productSummaryLabel";
            this.productSummaryLabel.Size = new System.Drawing.Size(46, 21);
            this.productSummaryLabel.TabIndex = 35;
            this.productSummaryLabel.Text = "1000";
            // 
            // searchProductId
            // 
            this.searchProductId.Location = new System.Drawing.Point(96, 32);
            this.searchProductId.Name = "searchProductId";
            this.searchProductId.Size = new System.Drawing.Size(171, 27);
            this.searchProductId.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 21);
            this.label16.TabIndex = 34;
            this.label16.Text = "Tổng số sản phẩm:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 8;
            this.label14.Text = "Mã sản phẩm";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(288, 32);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 23);
            this.searchButton.TabIndex = 33;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "Loại mặt hàng";
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
            this.grpBasicInfo.Controls.Add(this.productNoticeText);
            this.grpBasicInfo.Controls.Add(this.productUnit);
            this.grpBasicInfo.Controls.Add(this.label10);
            this.grpBasicInfo.Controls.Add(this.productAmount);
            this.grpBasicInfo.Controls.Add(this.label6);
            this.grpBasicInfo.Controls.Add(this.productRetailPriceText);
            this.grpBasicInfo.Controls.Add(this.productWholePriceText);
            this.grpBasicInfo.Controls.Add(this.label5);
            this.grpBasicInfo.Controls.Add(this.label3);
            this.grpBasicInfo.Controls.Add(this.label2);
            this.grpBasicInfo.Controls.Add(this.distributorCombobox);
            this.grpBasicInfo.Controls.Add(this.productPurcharsePriceText);
            this.grpBasicInfo.Controls.Add(this.label4);
            this.grpBasicInfo.Controls.Add(this.label9);
            this.grpBasicInfo.Controls.Add(this.productNameText);
            this.grpBasicInfo.Controls.Add(this.label8);
            this.grpBasicInfo.Controls.Add(this.productTypeCombobox);
            this.grpBasicInfo.Controls.Add(this.productIdText);
            this.grpBasicInfo.Controls.Add(this.label7);
            this.grpBasicInfo.Location = new System.Drawing.Point(10, 31);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(910, 322);
            this.grpBasicInfo.TabIndex = 18;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "Basic Information";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(24, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Ghi chú";
            // 
            // productNoticeText
            // 
            this.productNoticeText.Location = new System.Drawing.Point(146, 233);
            this.productNoticeText.Name = "productNoticeText";
            this.productNoticeText.Size = new System.Drawing.Size(741, 71);
            this.productNoticeText.TabIndex = 19;
            this.productNoticeText.Text = "";
            // 
            // productUnit
            // 
            this.productUnit.Location = new System.Drawing.Point(578, 82);
            this.productUnit.Name = "productUnit";
            this.productUnit.Size = new System.Drawing.Size(76, 27);
            this.productUnit.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(465, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đơn vị tính";
            // 
            // productAmount
            // 
            this.productAmount.Location = new System.Drawing.Point(827, 82);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(63, 27);
            this.productAmount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(705, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Số lượng còn";
            // 
            // productRetailPriceText
            // 
            this.productRetailPriceText.Location = new System.Drawing.Point(737, 172);
            this.productRetailPriceText.Name = "productRetailPriceText";
            this.productRetailPriceText.Size = new System.Drawing.Size(151, 27);
            this.productRetailPriceText.TabIndex = 14;
            // 
            // productWholePriceText
            // 
            this.productWholePriceText.Location = new System.Drawing.Point(439, 172);
            this.productWholePriceText.Name = "productWholePriceText";
            this.productWholePriceText.Size = new System.Drawing.Size(153, 27);
            this.productWholePriceText.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(646, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giá bán lẻ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(335, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá bán sỉ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(465, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhà phân phối";
            // 
            // distributorCombobox
            // 
            this.distributorCombobox.FormattingEnabled = true;
            this.distributorCombobox.Location = new System.Drawing.Point(578, 125);
            this.distributorCombobox.Name = "distributorCombobox";
            this.distributorCombobox.Size = new System.Drawing.Size(309, 27);
            this.distributorCombobox.TabIndex = 8;
            // 
            // productPurcharsePriceText
            // 
            this.productPurcharsePriceText.Location = new System.Drawing.Point(146, 172);
            this.productPurcharsePriceText.Name = "productPurcharsePriceText";
            this.productPurcharsePriceText.Size = new System.Drawing.Size(149, 27);
            this.productPurcharsePriceText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(24, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã sản phẩm";
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(146, 82);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(274, 27);
            this.productNameText.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(24, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loại sản phẩm";
            // 
            // productTypeCombobox
            // 
            this.productTypeCombobox.FormattingEnabled = true;
            this.productTypeCombobox.Location = new System.Drawing.Point(146, 125);
            this.productTypeCombobox.Name = "productTypeCombobox";
            this.productTypeCombobox.Size = new System.Drawing.Size(274, 27);
            this.productTypeCombobox.TabIndex = 2;
            // 
            // productIdText
            // 
            this.productIdText.Location = new System.Drawing.Point(146, 39);
            this.productIdText.Name = "productIdText";
            this.productIdText.Size = new System.Drawing.Size(741, 27);
            this.productIdText.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá nhập";
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Location = new System.Drawing.Point(6, 111);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(350, 229);
            this.statusLabel.TabIndex = 37;
            this.statusLabel.Text = "No Item";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchProductType
            // 
            this.searchProductType.FormattingEnabled = true;
            this.searchProductType.Location = new System.Drawing.Point(135, 13);
            this.searchProductType.Name = "searchProductType";
            this.searchProductType.Size = new System.Drawing.Size(222, 27);
            this.searchProductType.TabIndex = 37;
            this.searchProductType.SelectedIndexChanged += new System.EventHandler(this.searchProductType_SelectedIndexChanged);
            // 
            // UCMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.grbCommon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCMatHang";
            this.Size = new System.Drawing.Size(1326, 655);
            this.Load += new System.EventHandler(this.UCBanh_Load);
            this.grbCommon.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpAdvanceSearch.ResumeLayout(false);
            this.grpAdvanceSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grpFunction.ResumeLayout(false);
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCommon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpAdvanceSearch;
        private System.Windows.Forms.Label productSummaryLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox searchProductName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox searchProductId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiSanPham;
        private System.Windows.Forms.TextBox productPurcharsePriceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox productTypeCombobox;
        private System.Windows.Forms.TextBox productIdText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox distributorCombobox;
        private System.Windows.Forms.TextBox productRetailPriceText;
        private System.Windows.Forms.TextBox productWholePriceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productUnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox productAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox productNoticeText;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox searchProductType;
    }
}
