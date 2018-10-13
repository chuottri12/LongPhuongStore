namespace GUI
{
    partial class UCLoaiMatHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tblmaloaibanh = new System.Windows.Forms.TextBox();
            this.dgloaibanh = new System.Windows.Forms.DataGridView();
            this.tbltenloaibanh = new System.Windows.Forms.TextBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.btdanhsach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btluu = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbmaloaibanh = new System.Windows.Forms.TextBox();
            this.tbtenloaibanh = new System.Windows.Forms.TextBox();
            this.tbmota = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgloaibanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1285, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "MẶT HÀNG ĐANG KINH DOANH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(66, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã loại bánh";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(360, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên loại bánh";
            // 
            // tblmaloaibanh
            // 
            this.tblmaloaibanh.Location = new System.Drawing.Point(175, 40);
            this.tblmaloaibanh.Name = "tblmaloaibanh";
            this.tblmaloaibanh.Size = new System.Drawing.Size(138, 27);
            this.tblmaloaibanh.TabIndex = 2;
            // 
            // dgloaibanh
            // 
            this.dgloaibanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgloaibanh.Location = new System.Drawing.Point(37, 77);
            this.dgloaibanh.Name = "dgloaibanh";
            this.dgloaibanh.Size = new System.Drawing.Size(870, 177);
            this.dgloaibanh.TabIndex = 0;
            this.dgloaibanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgloaibanh_CellClick);
            // 
            // tbltenloaibanh
            // 
            this.tbltenloaibanh.Location = new System.Drawing.Point(476, 40);
            this.tbltenloaibanh.Name = "tbltenloaibanh";
            this.tbltenloaibanh.Size = new System.Drawing.Size(147, 27);
            this.tbltenloaibanh.TabIndex = 3;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(693, 35);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(87, 36);
            this.bttimkiem.TabIndex = 4;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // btdanhsach
            // 
            this.btdanhsach.Location = new System.Drawing.Point(805, 35);
            this.btdanhsach.Name = "btdanhsach";
            this.btdanhsach.Size = new System.Drawing.Size(82, 36);
            this.btdanhsach.TabIndex = 5;
            this.btdanhsach.Text = "Toàn bộ";
            this.btdanhsach.UseVisualStyleBackColor = true;
            this.btdanhsach.Click += new System.EventHandler(this.btdanhsach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btdanhsach);
            this.groupBox1.Controls.Add(this.bttimkiem);
            this.groupBox1.Controls.Add(this.tbltenloaibanh);
            this.groupBox1.Controls.Add(this.dgloaibanh);
            this.groupBox1.Controls.Add(this.tblmaloaibanh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các loại bánh";
            // 
            // btluu
            // 
            this.btluu.BackColor = System.Drawing.SystemColors.Control;
            this.btluu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.ForeColor = System.Drawing.Color.Black;
            this.btluu.Location = new System.Drawing.Point(65, 212);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(106, 41);
            this.btluu.TabIndex = 5;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = false;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bthuy
            // 
            this.bthuy.BackColor = System.Drawing.SystemColors.Control;
            this.bthuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.Color.Black;
            this.bthuy.Location = new System.Drawing.Point(65, 296);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(106, 41);
            this.bthuy.TabIndex = 5;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.Control;
            this.btxoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Black;
            this.btxoa.Location = new System.Drawing.Point(65, 379);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(106, 41);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.BackColor = System.Drawing.SystemColors.Control;
            this.btsua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Black;
            this.btsua.Location = new System.Drawing.Point(65, 136);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(106, 41);
            this.btsua.TabIndex = 6;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = false;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.SystemColors.Control;
            this.btthem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Black;
            this.btthem.Location = new System.Drawing.Point(65, 56);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(106, 41);
            this.btthem.TabIndex = 7;
            this.btthem.Text = "Thêm mới";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btthem);
            this.groupBox3.Controls.Add(this.btsua);
            this.groupBox3.Controls.Add(this.btxoa);
            this.groupBox3.Controls.Add(this.bthuy);
            this.groupBox3.Controls.Add(this.btluu);
            this.groupBox3.Location = new System.Drawing.Point(1046, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 459);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(74, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên loại bánh";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(424, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(74, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã loại bánh";
            // 
            // tbmaloaibanh
            // 
            this.tbmaloaibanh.Location = new System.Drawing.Point(185, 41);
            this.tbmaloaibanh.Name = "tbmaloaibanh";
            this.tbmaloaibanh.Size = new System.Drawing.Size(195, 26);
            this.tbmaloaibanh.TabIndex = 2;
            // 
            // tbtenloaibanh
            // 
            this.tbtenloaibanh.Location = new System.Drawing.Point(185, 103);
            this.tbtenloaibanh.Name = "tbtenloaibanh";
            this.tbtenloaibanh.Size = new System.Drawing.Size(195, 26);
            this.tbtenloaibanh.TabIndex = 3;
            // 
            // tbmota
            // 
            this.tbmota.Location = new System.Drawing.Point(476, 38);
            this.tbmota.Multiline = true;
            this.tbmota.Name = "tbmota";
            this.tbmota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbmota.Size = new System.Drawing.Size(431, 121);
            this.tbmota.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbmota);
            this.groupBox2.Controls.Add(this.tbtenloaibanh);
            this.groupBox2.Controls.Add(this.tbmaloaibanh);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(56, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết loại bánh";
            // 
            // UCLoaiMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCLoaiMatHang";
            this.Size = new System.Drawing.Size(1326, 655);
            this.Load += new System.EventHandler(this.UCLoaibanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgloaibanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tblmaloaibanh;
        private System.Windows.Forms.DataGridView dgloaibanh;
        private System.Windows.Forms.TextBox tbltenloaibanh;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Button btdanhsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbmaloaibanh;
        private System.Windows.Forms.TextBox tbtenloaibanh;
        private System.Windows.Forms.TextBox tbmota;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
