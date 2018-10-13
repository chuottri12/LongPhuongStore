namespace GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tennguoidung = new System.Windows.Forms.Label();
            this.manhanvien = new System.Windows.Forms.Label();
            this.gbchitiet = new System.Windows.Forms.GroupBox();
            this.bttrove = new System.Windows.Forms.Button();
            this.gbchucnang = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnQuarter = new System.Windows.Forms.PictureBox();
            this.btnBill_Mng = new System.Windows.Forms.PictureBox();
            this.btnSellBill = new System.Windows.Forms.PictureBox();
            this.btCustomer_Mng = new System.Windows.Forms.PictureBox();
            this.btbDistributor_Mng = new System.Windows.Forms.PictureBox();
            this.btnProduct_Mng = new System.Windows.Forms.PictureBox();
            this.btloaibanh = new System.Windows.Forms.PictureBox();
            this.btnhanvien = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.PictureBox();
            this.gbchucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBill_Mng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSellBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCustomer_Mng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbDistributor_Mng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct_Mng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btloaibanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.SuspendLayout();
            // 
            // tennguoidung
            // 
            this.tennguoidung.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tennguoidung.Location = new System.Drawing.Point(1129, 11);
            this.tennguoidung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tennguoidung.Name = "tennguoidung";
            this.tennguoidung.Size = new System.Drawing.Size(145, 22);
            this.tennguoidung.TabIndex = 3;
            this.tennguoidung.Text = "Tên nhân viên";
            this.tennguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // manhanvien
            // 
            this.manhanvien.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manhanvien.Location = new System.Drawing.Point(1129, 30);
            this.manhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.Size = new System.Drawing.Size(145, 22);
            this.manhanvien.TabIndex = 3;
            this.manhanvien.Text = "Mã nhân viên";
            this.manhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbchitiet
            // 
            this.gbchitiet.Location = new System.Drawing.Point(6, 65);
            this.gbchitiet.Name = "gbchitiet";
            this.gbchitiet.Size = new System.Drawing.Size(1075, 441);
            this.gbchitiet.TabIndex = 5;
            this.gbchitiet.TabStop = false;
            this.gbchitiet.SizeChanged += new System.EventHandler(this.gbchitiet_SizeChanged);
            // 
            // bttrove
            // 
            this.bttrove.Location = new System.Drawing.Point(21, 18);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(110, 41);
            this.bttrove.TabIndex = 6;
            this.bttrove.Text = "Trở về";
            this.bttrove.UseVisualStyleBackColor = true;
            this.bttrove.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbchucnang
            // 
            this.gbchucnang.BackColor = System.Drawing.SystemColors.Control;
            this.gbchucnang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbchucnang.BackgroundImage")));
            this.gbchucnang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbchucnang.Controls.Add(this.label14);
            this.gbchucnang.Controls.Add(this.label13);
            this.gbchucnang.Controls.Add(this.btnQuarter);
            this.gbchucnang.Controls.Add(this.btnBill_Mng);
            this.gbchucnang.Controls.Add(this.btnSellBill);
            this.gbchucnang.Controls.Add(this.btCustomer_Mng);
            this.gbchucnang.Controls.Add(this.btbDistributor_Mng);
            this.gbchucnang.Controls.Add(this.btnProduct_Mng);
            this.gbchucnang.Controls.Add(this.btloaibanh);
            this.gbchucnang.Controls.Add(this.btnhanvien);
            this.gbchucnang.Controls.Add(this.label12);
            this.gbchucnang.Controls.Add(this.label11);
            this.gbchucnang.Controls.Add(this.label6);
            this.gbchucnang.Controls.Add(this.label5);
            this.gbchucnang.Controls.Add(this.label4);
            this.gbchucnang.Controls.Add(this.label1);
            this.gbchucnang.Location = new System.Drawing.Point(-3, 64);
            this.gbchucnang.Name = "gbchucnang";
            this.gbchucnang.Size = new System.Drawing.Size(1100, 614);
            this.gbchucnang.TabIndex = 7;
            this.gbchucnang.TabStop = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(913, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 31);
            this.label14.TabIndex = 17;
            this.label14.Text = "Bán hàng";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(646, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 31);
            this.label13.TabIndex = 16;
            this.label13.Text = "Quản lý hóa đơn";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuarter
            // 
            this.btnQuarter.BackColor = System.Drawing.Color.Transparent;
            this.btnQuarter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuarter.BackgroundImage")));
            this.btnQuarter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuarter.Location = new System.Drawing.Point(79, 292);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(98, 94);
            this.btnQuarter.TabIndex = 15;
            this.btnQuarter.TabStop = false;
            this.btnQuarter.Click += new System.EventHandler(this.btnQuarter_Click);
            // 
            // btnBill_Mng
            // 
            this.btnBill_Mng.BackColor = System.Drawing.Color.Transparent;
            this.btnBill_Mng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBill_Mng.BackgroundImage")));
            this.btnBill_Mng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBill_Mng.Location = new System.Drawing.Point(653, 292);
            this.btnBill_Mng.Name = "btnBill_Mng";
            this.btnBill_Mng.Size = new System.Drawing.Size(109, 94);
            this.btnBill_Mng.TabIndex = 14;
            this.btnBill_Mng.TabStop = false;
            this.btnBill_Mng.Click += new System.EventHandler(this.btnBill_Mng_Click);
            // 
            // btnSellBill
            // 
            this.btnSellBill.BackColor = System.Drawing.Color.Transparent;
            this.btnSellBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSellBill.BackgroundImage")));
            this.btnSellBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSellBill.Location = new System.Drawing.Point(900, 292);
            this.btnSellBill.Name = "btnSellBill";
            this.btnSellBill.Size = new System.Drawing.Size(104, 94);
            this.btnSellBill.TabIndex = 12;
            this.btnSellBill.TabStop = false;
            this.btnSellBill.Click += new System.EventHandler(this.btnSellBill_Click);
            // 
            // btCustomer_Mng
            // 
            this.btCustomer_Mng.BackColor = System.Drawing.Color.Transparent;
            this.btCustomer_Mng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCustomer_Mng.BackgroundImage")));
            this.btCustomer_Mng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCustomer_Mng.Location = new System.Drawing.Point(361, 292);
            this.btCustomer_Mng.Name = "btCustomer_Mng";
            this.btCustomer_Mng.Size = new System.Drawing.Size(108, 94);
            this.btCustomer_Mng.TabIndex = 11;
            this.btCustomer_Mng.TabStop = false;
            this.btCustomer_Mng.Click += new System.EventHandler(this.btCustomer_Mng_Click);
            // 
            // btbDistributor_Mng
            // 
            this.btbDistributor_Mng.BackColor = System.Drawing.Color.Transparent;
            this.btbDistributor_Mng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbDistributor_Mng.BackgroundImage")));
            this.btbDistributor_Mng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbDistributor_Mng.Location = new System.Drawing.Point(898, 79);
            this.btbDistributor_Mng.Name = "btbDistributor_Mng";
            this.btbDistributor_Mng.Size = new System.Drawing.Size(106, 95);
            this.btbDistributor_Mng.TabIndex = 6;
            this.btbDistributor_Mng.TabStop = false;
            this.btbDistributor_Mng.Click += new System.EventHandler(this.btbDistributor_Mng_Click);
            // 
            // btnProduct_Mng
            // 
            this.btnProduct_Mng.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct_Mng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProduct_Mng.BackgroundImage")));
            this.btnProduct_Mng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProduct_Mng.Location = new System.Drawing.Point(653, 79);
            this.btnProduct_Mng.Name = "btnProduct_Mng";
            this.btnProduct_Mng.Size = new System.Drawing.Size(109, 95);
            this.btnProduct_Mng.TabIndex = 5;
            this.btnProduct_Mng.TabStop = false;
            this.btnProduct_Mng.Click += new System.EventHandler(this.btbanh_Click);
            this.btnProduct_Mng.MouseHover += new System.EventHandler(this.btbanh_MouseHover);
            // 
            // btloaibanh
            // 
            this.btloaibanh.BackColor = System.Drawing.Color.Transparent;
            this.btloaibanh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btloaibanh.BackgroundImage")));
            this.btloaibanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btloaibanh.Location = new System.Drawing.Point(361, 79);
            this.btloaibanh.Name = "btloaibanh";
            this.btloaibanh.Size = new System.Drawing.Size(106, 96);
            this.btloaibanh.TabIndex = 4;
            this.btloaibanh.TabStop = false;
            this.btloaibanh.Click += new System.EventHandler(this.btloaibanh_Click);
            this.btloaibanh.MouseLeave += new System.EventHandler(this.btloaibanh_MouseLeave);
            this.btloaibanh.MouseHover += new System.EventHandler(this.btloaibanh_MouseHover);
            // 
            // btnhanvien
            // 
            this.btnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btnhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnhanvien.Image")));
            this.btnhanvien.Location = new System.Drawing.Point(79, 79);
            this.btnhanvien.Name = "btnhanvien";
            this.btnhanvien.Size = new System.Drawing.Size(98, 95);
            this.btnhanvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnhanvien.TabIndex = 2;
            this.btnhanvien.TabStop = false;
            this.btnhanvien.Click += new System.EventHandler(this.btnhanvien_Click);
            this.btnhanvien.MouseLeave += new System.EventHandler(this.btnhanvien_MouseLeave);
            this.btnhanvien.MouseHover += new System.EventHandler(this.btnhanvien_MouseHover);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(333, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 59);
            this.label12.TabIndex = 1;
            this.label12.Text = "Danh sách khách hàng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(64, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bộ phận";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(888, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nhà phân phối";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(635, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quản lý sản phẩm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(344, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mặt hàng đang kinh doanh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(88, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Image = global::GUI.Properties.Resources.default_user;
            this.user.InitialImage = null;
            this.user.Location = new System.Drawing.Point(1280, 11);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(48, 48);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user.TabIndex = 4;
            this.user.TabStop = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1339, 680);
            this.Controls.Add(this.gbchucnang);
            this.Controls.Add(this.bttrove);
            this.Controls.Add(this.gbchitiet);
            this.Controls.Add(this.user);
            this.Controls.Add(this.manhanvien);
            this.Controls.Add(this.tennguoidung);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 718);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng Long Phượng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.gbchucnang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBill_Mng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSellBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCustomer_Mng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbDistributor_Mng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct_Mng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btloaibanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label tennguoidung;
        public System.Windows.Forms.PictureBox user;
        public System.Windows.Forms.Label manhanvien;
        private System.Windows.Forms.GroupBox gbchitiet;
        public System.Windows.Forms.Button bttrove;
        private System.Windows.Forms.GroupBox gbchucnang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnhanvien;
        private System.Windows.Forms.PictureBox btloaibanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnProduct_Mng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btbDistributor_Mng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox btCustomer_Mng;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox btnQuarter;
        private System.Windows.Forms.PictureBox btnBill_Mng;
        private System.Windows.Forms.PictureBox btnSellBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}