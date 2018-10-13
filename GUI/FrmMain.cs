using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.IO;
namespace GUI
{
    public partial class FrmMain : Form
    {
        public static byte FLAG_BILL;
        public static byte FLAG_DANH_SACH_NGUYEN_LIEU;
        public static byte FLAG_PRODUCT;
        public static byte FLAG_CONG_THUC_BANH;
        public static byte FLAG_DOI_MAT_KHAU;
        public static byte FLAG_SELL_BILL;
        public static byte FLAG_CUSTOMER;
        public static byte FLAG_PRODUCT_TYPE;
        public static byte FLAG_LOAI_HOA_DON;
        public static byte FLAG_LOAI_NGUYEN_LIEU;
        public static byte FLAG_QUARTER;
        public static byte FLAG_LUONG;
        public static byte FLAG_NGUYEN_LIEU;
        public static byte FLAG_EMPLOY;
        public static byte FLAG_DISTRIBUTOR;
        public static byte FLAG_DANH_SACH_KHACH_HANG;

        public static byte USER_ON = 0x01;
        public static byte USER_OFF = 0x00;
        FrmHienThiChinh frmChinh;

        //------------------------các hàm-----------------------

        /**
         * @name    LoadUser
         * 
         * @param   UserControl
         * 
         * @author  TriCV
         * 
         * @note    Load user control to FrmHienThiChinh
         * 
         * @date    2018/Jun/16
         */

        public void LoadUser(UserControl n)
        {/*
            bttrove.Enabled = true;
            gbchucnang.Hide();
            gbchitiet.Show();
            gbchitiet.Controls.Clear();
            gbchitiet.Controls.Add(n);
            n.Width = this.gbchitiet.Width;
            n.Height = this.gbchitiet.Height;
           */
            frmChinh = new FrmHienThiChinh(n);
            //if (checkExistFlag())
            //{
            //    frmChinh.Activate();
            //}
            //else
            //{
            frmChinh.Show();
        }

        /**
         * @name    Add
         * 
         * @param   byte, byte
         * 
         * @author  TriCV
         * 
         * @note    Add value to a byte array
         * 
         * @date    2018/Jun/16
         */
        /*
                byte[] Add(byte[] array, byte newValue)
                {
                    int newLength = array.Length + 1;

                    byte[] result = new byte[newLength];

                    for (int i = 0; i < array.Length; i++)
                        result[i] = array[i];

                    result[newLength - 1] = newValue;

                    return result;
                }
        */
        /**
        * @name    setFlagUserControl
        * 
        * @param byte
        * 
        * @author  TriCV
        * 
        * @note    Set value to flag
        * 
        * @date    2018/Jun/16
        */

        private void setFlagUserControl(byte flag, byte value)
        {
            flag = value;
        }

        /**
        * @name    getFlagUserControl
        * 
        * @return  byte
        * 
        * @param   byte, byte
        * 
        * @author  TriCV
        * 
        * @note    Set value to flag
        * 
        * @date    2018/Jun/16
        */

        private byte getFlagUserControl(byte flag)
        {
            return flag;
        }

        /**
        * @name    checkExistFlag
        * 
        * @return  boolean
        * 
        * @param   void 
        * 
        * @author  TriCV
        * 
        * @note    Add value to a byte array
        * 
        * @date    2018/Jun/16
        */
        /*
                private bool checkExistFlag(byte flag)
                {
                    for (int i = 0; i < USER_CONTROL.Length; i++)
                        if (USER_CONTROL[i] == flag)
                        {
                            return true;
                        }
    
                    return false;
                }
        */
        private Image ChuyenAnh(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        //------------------------Main-----------------------

        public FrmMain()
        {
            InitializeComponent();

        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) //khi dóng form thì trở về form đăng nhập
        {

            Form1 f1 = new Form1();
            f1.Show();

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            bttrove.Enabled = false;
            gbchitiet.Hide();
            gbchitiet.Width = this.Width;
            gbchitiet.Height = this.Height;
            gbchucnang.Width = this.Width;
            gbchucnang.Height = this.Height;
            //ucdoimatkhau.pbanh.BackgroundImage = Image.FromFile(@"F:\Backup\HieubanhDatai\HieubanhDatai\images\default-image.png", true);
            //
            //USER_CONTROL = new byte[20];
        }
        //------------------------các button----------------------

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn đã hoàn thành hết công việc của mình rồi chứ! Nhấn Ok để trở về, Cancel để hủy.", "Thông báo!", MessageBoxButtons.OKCancel))
            {
                gbchucnang.Show();
                gbchitiet.Hide();
                bttrove.Enabled = false;
                user.Enabled = true;
            }

        }

        private void btnhanvien_Click(object sender, EventArgs e)
        {
            UCNhanvien ucEmploy = new UCNhanvien();
            if (getFlagUserControl(FLAG_EMPLOY) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }             
            FLAG_EMPLOY = USER_ON;
            LoadUser(ucEmploy);
        }

        private void btbophan_Click(object sender, EventArgs e)
        {
            UCLoainv ucloainv = new UCLoainv();
            if (getFlagUserControl(FLAG_QUARTER) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_QUARTER = USER_ON;
            LoadUser(ucloainv);
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            gbchitiet.Width = this.Width;
            gbchitiet.Height = this.Height;
            gbchucnang.Width = this.Width;
            gbchucnang.Height = this.Height;
        }

        private void gbchitiet_SizeChanged(object sender, EventArgs e)
        {

        }

        private void user_Click(object sender, EventArgs e)
        {
            if (bttrove.Enabled == true)
            {
                MessageBox.Show("Hãy hoàn thành công viêc hiện tại trước khi đăng xuất hoặc thay đổi mật khẩu của bạn!");
            }
            else
            {
                //gbchucnang.Hide();
                //gbchitiet.Show();
                //UCDoimatkhau ucdoimatkhau = new UCDoimatkhau();
                //BUS_Employ busnhanvien = new BUS_Employ();
                //DataTable dt;
                //dt = busnhanvien.Doimatkhau(this.manhanvien.Text);
                //ucdoimatkhau.tbmanv.Text = dt.Rows[0]["Manv"].ToString();
                //ucdoimatkhau.tbtennhanvien.Text = dt.Rows[0]["Tennv"].ToString();
                //ucdoimatkhau.tbbophan.Text = dt.Rows[0]["Maloainv"].ToString();
                //ucdoimatkhau.dtpngaysinh.Text = dt.Rows[0]["Ngaysinh"].ToString();
                //ucdoimatkhau.tbsdt.Text = dt.Rows[0]["Sdt"].ToString();
                //ucdoimatkhau.tbquequan.Text = dt.Rows[0]["Quequan"].ToString();
                //ucdoimatkhau.tbluongcoban.Text = dt.Rows[0]["Luongcoban"].ToString();
                //ucdoimatkhau.tbgioitinh.Text = dt.Rows[0]["Gioitinh"].ToString();
                //try
                //{
                //    Image anh = ChuyenAnh((byte[])dt.Rows[0]["Anh"]);
                //    ucdoimatkhau.pbanh.Image = anh;
                //}
                //catch (InvalidCastException ex)
                //{
                   
                //}
                //LoadUser(ucdoimatkhau);
                //user.Enabled = false;
            }
        }

        private void btnhanvien_MouseHover(object sender, EventArgs e)
        {
            btnhanvien.BackColor = Color.White;
        }

        private void btnhanvien_MouseLeave(object sender, EventArgs e)
        {
            btnhanvien.BackColor = Color.Transparent;
        }
        
        private void btbanh_Click(object sender, EventArgs e)
        {
            UCMatHang ucProduct = new UCMatHang();

            if (getFlagUserControl(FLAG_PRODUCT) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_PRODUCT = USER_ON;
            LoadUser(ucProduct);
        }

        private void btloaibanh_Click(object sender, EventArgs e)
        {
            UCLoaiMatHang ucProductType = new UCLoaiMatHang();
            if (getFlagUserControl(FLAG_PRODUCT_TYPE) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_PRODUCT_TYPE = USER_ON;
            LoadUser(ucProductType);
        }

        private void btluong_Click(object sender, EventArgs e)
        {/*
            UCLuong ucluong = new UCLuong();
            if (getFlagUserControl(FLAG_LUONG) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_LUONG = USER_ON;
            LoadUser(ucluong);*/
        }

        private void btloainguyenlieu_Click(object sender, EventArgs e)
        {
            UCDistributor ucloaingl = new UCDistributor();
            if (getFlagUserControl(FLAG_LOAI_NGUYEN_LIEU) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_LOAI_NGUYEN_LIEU = USER_ON;
            LoadUser(ucloaingl);
        }

        private void btnguyenlieu_Click(object sender, EventArgs e)
        {
            //UCNguyenlieu ucnguyenlieu = new UCNguyenlieu();
            //if (getFlagUserControl(FLAG_NGUYEN_LIEU) == USER_ON)
            //{
            //    frmChinh.Activate();
            //    return;
            //}
            //FLAG_NGUYEN_LIEU = USER_ON;
            //LoadUser(ucnguyenlieu);

        }

        private void btkhonguyenlieu_Click(object sender, EventArgs e)
        {/*
            UC_Dsnguyenlieu ucdsnl = new UC_Dsnguyenlieu();
            if (getFlagUserControl(FLAG_DANH_SACH_NGUYEN_LIEU) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_DANH_SACH_NGUYEN_LIEU = USER_ON;
            LoadUser(ucdsnl);*/
        }

        private void tbcongthucbanh_Click(object sender, EventArgs e)
        {/*
            UCCongthucbanh a = new UCCongthucbanh();
            if (getFlagUserControl(FLAG_CONG_THUC_BANH) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_CONG_THUC_BANH = USER_ON;
            LoadUser(a);
          * */
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCQLHoaDon uccthd = new UCQLHoaDon();
            LoadUser(uccthd);
        }

        //private void btbophan_MouseHover(object sender, EventArgs e)
        //{
        //    btbophan.BackColor = Color.White;
        //}

        //private void btluong_MouseHover(object sender, EventArgs e)
        //{
        //    btluong.BackColor = Color.White;

        //}

        private void btloaibanh_MouseHover(object sender, EventArgs e)
        {
            btloaibanh.BackColor = Color.White;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrBCDanhsachnhanvien frbc = new FrBCDanhsachnhanvien();
            frbc.Show();
        }

        //private void btbophan_MouseLeave(object sender, EventArgs e)
        //{
        //    btbophan.BackColor = Color.Transparent;
        //}

        //private void btluong_MouseLeave(object sender, EventArgs e)
        //{

        //    btluong.BackColor = Color.Transparent;
        //}

        private void btloaibanh_MouseLeave(object sender, EventArgs e)
        {

            btloaibanh.BackColor = Color.Transparent;
        }

        private void btbanh_MouseHover(object sender, EventArgs e)
        {
            btnProduct_Mng.BackColor = Color.White;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrBCDanhsachkhachhang fr = new FrBCDanhsachkhachhang();
            if (getFlagUserControl(FLAG_DANH_SACH_KHACH_HANG) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_DANH_SACH_KHACH_HANG = USER_ON;
            fr.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrBCLuongthangnv fr = new FrBCLuongthangnv();
            fr.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrInHoadon fr = new FrInHoadon();
            fr.Show();
        }

        private void btbDistributor_Mng_Click(object sender, EventArgs e)
        {
            UCDistributor ucDistributor = new UCDistributor();
            if (getFlagUserControl(FLAG_DISTRIBUTOR) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_DISTRIBUTOR = USER_ON;
            LoadUser(ucDistributor);
        }

        private void btnQuarter_Click(object sender, EventArgs e)
        {

            UCQuarter ucQuarter = new UCQuarter();
            if (getFlagUserControl(FLAG_QUARTER) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_QUARTER = USER_ON;
            LoadUser(ucQuarter);
        }

        private void btCustomer_Mng_Click(object sender, EventArgs e)
        {
            UCKhachhang ucCustomer = new UCKhachhang();
            if (getFlagUserControl(FLAG_CUSTOMER) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_CUSTOMER = USER_ON;
            LoadUser(ucCustomer);
        }

        private void btnBill_Mng_Click(object sender, EventArgs e)
        {
            UCQLHoaDon ucBill = new UCQLHoaDon();
            if (getFlagUserControl(FLAG_BILL) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_BILL = USER_ON;
            LoadUser(ucBill);
        }

        private void btnSellBill_Click(object sender, EventArgs e)
        {
            UCHoadonBan ucSellBill = new UCHoadonBan();
            if (getFlagUserControl(FLAG_SELL_BILL) == USER_ON)
            {
                frmChinh.Activate();
                return;
            }
            FLAG_SELL_BILL = USER_ON;
            LoadUser(ucSellBill);
        }
    }
}
