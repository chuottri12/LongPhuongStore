namespace GUI
{
    partial class UCDistributor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.grpBasicInfo = new System.Windows.Forms.GroupBox();
            this.tbTienThieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiaChi_NPP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail_NPP = new System.Windows.Forms.TextBox();
            this.tbSdt_NPP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbNPP_Name = new System.Windows.Forms.TextBox();
            this.tbNPP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpAdvanceSearch = new System.Windows.Forms.GroupBox();
            this.tbNPP_Name_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaNPP_Search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.maNPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNotice = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpFunction.SuspendLayout();
            this.grpBasicInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpAdvanceSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1320, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÀ PHÂN PHỐI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(2, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1336, 537);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhà phân phối";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpFunction);
            this.groupBox2.Controls.Add(this.grpBasicInfo);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(390, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 484);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhà phân phối";
            // 
            // grpFunction
            // 
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
            this.grpBasicInfo.Controls.Add(this.label7);
            this.grpBasicInfo.Controls.Add(this.tbNotice);
            this.grpBasicInfo.Controls.Add(this.textBox1);
            this.grpBasicInfo.Controls.Add(this.label4);
            this.grpBasicInfo.Controls.Add(this.tbTienThieu);
            this.grpBasicInfo.Controls.Add(this.label3);
            this.grpBasicInfo.Controls.Add(this.tbDiaChi_NPP);
            this.grpBasicInfo.Controls.Add(this.label8);
            this.grpBasicInfo.Controls.Add(this.tbEmail_NPP);
            this.grpBasicInfo.Controls.Add(this.tbSdt_NPP);
            this.grpBasicInfo.Controls.Add(this.label5);
            this.grpBasicInfo.Controls.Add(this.label14);
            this.grpBasicInfo.Controls.Add(this.tbNPP_Name);
            this.grpBasicInfo.Controls.Add(this.tbNPP);
            this.grpBasicInfo.Controls.Add(this.label12);
            this.grpBasicInfo.Controls.Add(this.label13);
            this.grpBasicInfo.Location = new System.Drawing.Point(10, 31);
            this.grpBasicInfo.Name = "grpBasicInfo";
            this.grpBasicInfo.Size = new System.Drawing.Size(910, 322);
            this.grpBasicInfo.TabIndex = 18;
            this.grpBasicInfo.TabStop = false;
            this.grpBasicInfo.Text = "Basic Information";
            // 
            // tbTienThieu
            // 
            this.tbTienThieu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienThieu.Location = new System.Drawing.Point(150, 191);
            this.tbTienThieu.Name = "tbTienThieu";
            this.tbTienThieu.Size = new System.Drawing.Size(169, 23);
            this.tbTienThieu.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Số tiền còn thiếu";
            // 
            // tbDiaChi_NPP
            // 
            this.tbDiaChi_NPP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi_NPP.Location = new System.Drawing.Point(150, 148);
            this.tbDiaChi_NPP.Name = "tbDiaChi_NPP";
            this.tbDiaChi_NPP.Size = new System.Drawing.Size(741, 23);
            this.tbDiaChi_NPP.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Địa chỉ";
            // 
            // tbEmail_NPP
            // 
            this.tbEmail_NPP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail_NPP.Location = new System.Drawing.Point(602, 106);
            this.tbEmail_NPP.Name = "tbEmail_NPP";
            this.tbEmail_NPP.Size = new System.Drawing.Size(289, 23);
            this.tbEmail_NPP.TabIndex = 51;
            // 
            // tbSdt_NPP
            // 
            this.tbSdt_NPP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdt_NPP.Location = new System.Drawing.Point(603, 29);
            this.tbSdt_NPP.Name = "tbSdt_NPP";
            this.tbSdt_NPP.Size = new System.Drawing.Size(289, 23);
            this.tbSdt_NPP.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(506, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "Email";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(507, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 22);
            this.label14.TabIndex = 49;
            this.label14.Text = "Số điện thoại";
            // 
            // tbNPP_Name
            // 
            this.tbNPP_Name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNPP_Name.Location = new System.Drawing.Point(150, 67);
            this.tbNPP_Name.Name = "tbNPP_Name";
            this.tbNPP_Name.Size = new System.Drawing.Size(741, 23);
            this.tbNPP_Name.TabIndex = 44;
            // 
            // tbNPP
            // 
            this.tbNPP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNPP.Location = new System.Drawing.Point(150, 29);
            this.tbNPP.Name = "tbNPP";
            this.tbNPP.Size = new System.Drawing.Size(276, 23);
            this.tbNPP.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 22);
            this.label12.TabIndex = 41;
            this.label12.Text = "Tên nhà phân phối";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 22);
            this.label13.TabIndex = 42;
            this.label13.Text = "Mã nhà phân phối";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(9, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 495);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.grpAdvanceSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "                           Danh sách nhà phân phối                              ";
            // 
            // grpAdvanceSearch
            // 
            this.grpAdvanceSearch.BackColor = System.Drawing.Color.White;
            this.grpAdvanceSearch.Controls.Add(this.tbNPP_Name_Search);
            this.grpAdvanceSearch.Controls.Add(this.label2);
            this.grpAdvanceSearch.Controls.Add(this.tbMaNPP_Search);
            this.grpAdvanceSearch.Controls.Add(this.label6);
            this.grpAdvanceSearch.Controls.Add(this.lblTong);
            this.grpAdvanceSearch.Controls.Add(this.label16);
            this.grpAdvanceSearch.Controls.Add(this.btnSearch);
            this.grpAdvanceSearch.Controls.Add(this.dgvKhachHang);
            this.grpAdvanceSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdvanceSearch.Location = new System.Drawing.Point(3, 31);
            this.grpAdvanceSearch.Name = "grpAdvanceSearch";
            this.grpAdvanceSearch.Size = new System.Drawing.Size(360, 432);
            this.grpAdvanceSearch.TabIndex = 7;
            this.grpAdvanceSearch.TabStop = false;
            this.grpAdvanceSearch.Text = "Advance Search";
            // 
            // tbNPP_Name_Search
            // 
            this.tbNPP_Name_Search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNPP_Name_Search.Location = new System.Drawing.Point(120, 65);
            this.tbNPP_Name_Search.Name = "tbNPP_Name_Search";
            this.tbNPP_Name_Search.Size = new System.Drawing.Size(169, 23);
            this.tbNPP_Name_Search.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tên nhà phân phối";
            // 
            // tbMaNPP_Search
            // 
            this.tbMaNPP_Search.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNPP_Search.Location = new System.Drawing.Point(120, 28);
            this.tbMaNPP_Search.Name = "tbMaNPP_Search";
            this.tbMaNPP_Search.Size = new System.Drawing.Size(169, 23);
            this.tbMaNPP_Search.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mã nhà phân phối";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(152, 378);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(22, 16);
            this.lblTong.TabIndex = 35;
            this.lblTong.Text = "10";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Tổng số nhà phân phối:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNPP,
            this.tenNPP});
            this.dgvKhachHang.Location = new System.Drawing.Point(4, 113);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.Size = new System.Drawing.Size(355, 245);
            this.dgvKhachHang.TabIndex = 0;
            // 
            // maNPP
            // 
            this.maNPP.Frozen = true;
            this.maNPP.HeaderText = "Mã nhà phân phối";
            this.maNPP.Name = "maNPP";
            this.maNPP.ReadOnly = true;
            this.maNPP.Width = 176;
            // 
            // tenNPP
            // 
            this.tenNPP.Frozen = true;
            this.tenNPP.HeaderText = "Tên nhà phân phối";
            this.tenNPP.Name = "tenNPP";
            this.tenNPP.ReadOnly = true;
            this.tenNPP.Width = 176;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(150, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 23);
            this.textBox1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tên người chủ quản";
            // 
            // tbNotice
            // 
            this.tbNotice.Location = new System.Drawing.Point(150, 235);
            this.tbNotice.Name = "tbNotice";
            this.tbNotice.Size = new System.Drawing.Size(737, 81);
            this.tbNotice.TabIndex = 58;
            this.tbNotice.Text = "";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ghi chú";
            // 
            // UCNhaPP
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCNhaPP";
            this.Size = new System.Drawing.Size(1341, 655);
            this.Load += new System.EventHandler(this.UCLoainguyenlieu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpFunction.ResumeLayout(false);
            this.grpBasicInfo.ResumeLayout(false);
            this.grpBasicInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpAdvanceSearch.ResumeLayout(false);
            this.grpAdvanceSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.GroupBox grpBasicInfo;
        private System.Windows.Forms.TextBox tbTienThieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDiaChi_NPP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail_NPP;
        private System.Windows.Forms.TextBox tbSdt_NPP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbNPP_Name;
        private System.Windows.Forms.TextBox tbNPP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpAdvanceSearch;
        private System.Windows.Forms.TextBox tbNPP_Name_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaNPP_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNPP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbNotice;
    }
}
