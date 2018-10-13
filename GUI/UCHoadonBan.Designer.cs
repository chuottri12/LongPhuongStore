namespace GUI
{
    partial class UCHoadonBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbmakh = new System.Windows.Forms.ComboBox();
            this.dtngaylap = new System.Windows.Forms.DateTimePicker();
            this.tbtennv = new System.Windows.Forms.TextBox();
            this.tbtenkh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmaloaihd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dghoadon = new System.Windows.Forms.DataGridView();
            this.maMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTongTienLe = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.ckbGhiNo = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvGiaBanSi = new System.Windows.Forms.DataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dghoadon)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaBanSi)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1320, 53);
            this.label14.TabIndex = 15;
            this.label14.Text = "CẬP NHẬT HÓA ĐƠN";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 589);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.ckbGhiNo);
            this.groupBox2.Controls.Add(this.btnThanhToan);
            this.groupBox2.Controls.Add(this.cbmaloaihd);
            this.groupBox2.Controls.Add(this.cbmakh);
            this.groupBox2.Controls.Add(this.dtngaylap);
            this.groupBox2.Controls.Add(this.tbtennv);
            this.groupBox2.Controls.Add(this.tbtenkh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1273, 102);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // cbmakh
            // 
            this.cbmakh.FormattingEnabled = true;
            this.cbmakh.Location = new System.Drawing.Point(202, 70);
            this.cbmakh.Name = "cbmakh";
            this.cbmakh.Size = new System.Drawing.Size(149, 24);
            this.cbmakh.TabIndex = 24;
            // 
            // dtngaylap
            // 
            this.dtngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaylap.Location = new System.Drawing.Point(519, 28);
            this.dtngaylap.Name = "dtngaylap";
            this.dtngaylap.Size = new System.Drawing.Size(173, 23);
            this.dtngaylap.TabIndex = 22;
            // 
            // tbtennv
            // 
            this.tbtennv.Location = new System.Drawing.Point(851, 70);
            this.tbtennv.Name = "tbtennv";
            this.tbtennv.ReadOnly = true;
            this.tbtennv.Size = new System.Drawing.Size(173, 23);
            this.tbtennv.TabIndex = 18;
            // 
            // tbtenkh
            // 
            this.tbtenkh.Location = new System.Drawing.Point(519, 70);
            this.tbtenkh.Name = "tbtenkh";
            this.tbtenkh.ReadOnly = true;
            this.tbtenkh.Size = new System.Drawing.Size(173, 23);
            this.tbtenkh.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(397, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày lập";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(742, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nhân viên bán";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(397, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã khách hàng ( nếu có )";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbmaloaihd
            // 
            this.cbmaloaihd.FormattingEnabled = true;
            this.cbmaloaihd.Location = new System.Drawing.Point(203, 30);
            this.cbmaloaihd.Name = "cbmaloaihd";
            this.cbmaloaihd.Size = new System.Drawing.Size(148, 24);
            this.cbmaloaihd.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Yellow;
            this.groupBox3.Controls.Add(this.lblTongTienLe);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dghoadon);
            this.groupBox3.Location = new System.Drawing.Point(15, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 342);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giá bán lẻ";
            // 
            // dghoadon
            // 
            this.dghoadon.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dghoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dghoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMatHang,
            this.nameProduct,
            this.soLuong,
            this.unit,
            this.price,
            this.totalPrice});
            this.dghoadon.Location = new System.Drawing.Point(12, 22);
            this.dghoadon.Name = "dghoadon";
            this.dghoadon.RowHeadersVisible = false;
            this.dghoadon.Size = new System.Drawing.Size(596, 280);
            this.dghoadon.TabIndex = 0;
            // 
            // maMatHang
            // 
            this.maMatHang.HeaderText = "Mã sản phẩm";
            this.maMatHang.Name = "maMatHang";
            this.maMatHang.Width = 125;
            // 
            // nameProduct
            // 
            this.nameProduct.HeaderText = "Tên sản phẩm";
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 50;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn vị";
            this.unit.Name = "unit";
            this.unit.Width = 60;
            // 
            // price
            // 
            this.price.HeaderText = "Đơn giá";
            this.price.Name = "price";
            this.price.Width = 115;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Thành tiền";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Width = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(409, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // lblTongTienLe
            // 
            this.lblTongTienLe.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblTongTienLe.ForeColor = System.Drawing.Color.Red;
            this.lblTongTienLe.Location = new System.Drawing.Point(490, 315);
            this.lblTongTienLe.Name = "lblTongTienLe";
            this.lblTongTienLe.Size = new System.Drawing.Size(118, 18);
            this.lblTongTienLe.TabIndex = 2;
            this.lblTongTienLe.Text = "100000000";
            this.lblTongTienLe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(1127, 24);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(128, 35);
            this.btnThanhToan.TabIndex = 26;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // ckbGhiNo
            // 
            this.ckbGhiNo.AutoSize = true;
            this.ckbGhiNo.Location = new System.Drawing.Point(1127, 73);
            this.ckbGhiNo.Name = "ckbGhiNo";
            this.ckbGhiNo.Size = new System.Drawing.Size(64, 20);
            this.ckbGhiNo.TabIndex = 27;
            this.ckbGhiNo.Text = "Ghi Nợ";
            this.ckbGhiNo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dgvGiaBanSi);
            this.groupBox4.Location = new System.Drawing.Point(666, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(622, 342);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Giá bán sỉ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(490, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "100000000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label6.Location = new System.Drawing.Point(409, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng tiền";
            // 
            // dgvGiaBanSi
            // 
            this.dgvGiaBanSi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiaBanSi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGiaBanSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaBanSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.productName,
            this.soLuongSi,
            this.unitSi,
            this.priceSi,
            this.thanhTienSi});
            this.dgvGiaBanSi.Location = new System.Drawing.Point(12, 22);
            this.dgvGiaBanSi.Name = "dgvGiaBanSi";
            this.dgvGiaBanSi.RowHeadersVisible = false;
            this.dgvGiaBanSi.Size = new System.Drawing.Size(596, 280);
            this.dgvGiaBanSi.TabIndex = 0;
            // 
            // idProduct
            // 
            this.idProduct.HeaderText = "Mã sản phẩm";
            this.idProduct.Name = "idProduct";
            this.idProduct.Width = 125;
            // 
            // productName
            // 
            this.productName.HeaderText = "Tên sản phẩm";
            this.productName.Name = "productName";
            this.productName.Width = 125;
            // 
            // soLuongSi
            // 
            this.soLuongSi.HeaderText = "Số lượng";
            this.soLuongSi.Name = "soLuongSi";
            this.soLuongSi.Width = 50;
            // 
            // unitSi
            // 
            this.unitSi.HeaderText = "Đơn vị";
            this.unitSi.Name = "unitSi";
            this.unitSi.Width = 60;
            // 
            // priceSi
            // 
            this.priceSi.HeaderText = "Đơn giá";
            this.priceSi.Name = "priceSi";
            this.priceSi.Width = 115;
            // 
            // thanhTienSi
            // 
            this.thanhTienSi.HeaderText = "Thành tiền";
            this.thanhTienSi.Name = "thanhTienSi";
            this.thanhTienSi.Width = 118;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btthem);
            this.groupBox5.Controls.Add(this.btsua);
            this.groupBox5.Controls.Add(this.btxoa);
            this.groupBox5.Controls.Add(this.bthuy);
            this.groupBox5.Controls.Add(this.btluu);
            this.groupBox5.Location = new System.Drawing.Point(15, 500);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1273, 83);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.Control;
            this.btthem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Black;
            this.btthem.Location = new System.Drawing.Point(18, 22);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(106, 41);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm mới";
            this.btthem.UseVisualStyleBackColor = false;
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.SystemColors.Control;
            this.btsua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Black;
            this.btsua.Location = new System.Drawing.Point(301, 22);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(106, 41);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.Control;
            this.btxoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Black;
            this.btxoa.Location = new System.Drawing.Point(1153, 22);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(106, 41);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            // 
            // bthuy
            // 
            this.bthuy.BackColor = System.Drawing.SystemColors.Control;
            this.bthuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Black;
            this.bthuy.Location = new System.Drawing.Point(879, 22);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(106, 41);
            this.bthuy.TabIndex = 5;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            // 
            // btluu
            // 
            this.btluu.BackColor = System.Drawing.SystemColors.Control;
            this.btluu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.Color.Black;
            this.btluu.Location = new System.Drawing.Point(582, 22);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(106, 41);
            this.btluu.TabIndex = 5;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            // 
            // UCHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCHoadon";
            this.Size = new System.Drawing.Size(1326, 655);
            this.Load += new System.EventHandler(this.UCHoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dghoadon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaBanSi)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbmakh;
        private System.Windows.Forms.DateTimePicker dtngaylap;
        private System.Windows.Forms.TextBox tbtennv;
        private System.Windows.Forms.TextBox tbtenkh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmaloaihd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dghoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.Label lblTongTienLe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.CheckBox ckbGhiNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvGiaBanSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienSi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;

    }
}
