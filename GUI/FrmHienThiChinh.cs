using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmHienThiChinh : Form
    {
        private string userControlName = "";
        //private FrmMain frmMain = new FrmMain();

        public FrmHienThiChinh(UserControl controls)
        {
            InitializeComponent();
            //Add user controls

            this.Text = "Tạp hóa Long Phượng";
            groupBox2.Controls.Add(controls);
            controls.Location = new Point(5, 15);

            this.userControlName = controls.Name;
            // control no small than screen size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // control no larger than screen size
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void FrmHienThiChinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (userControlName)
            {
                case "UCNhanvien":
                    FrmMain.FLAG_EMPLOY = FrmMain.USER_OFF;
                    break;
                case "UCNguyenlieu":
                    FrmMain.FLAG_NGUYEN_LIEU = FrmMain.USER_OFF;
                    break;
                case "UCLuong":
                    FrmMain.FLAG_LUONG = FrmMain.USER_OFF;
                    break;
                case "UCLoainv":
                    FrmMain.FLAG_QUARTER = FrmMain.USER_OFF;
                    break;
                case "UCLoainguyenlieu":
                    FrmMain.FLAG_LOAI_NGUYEN_LIEU = FrmMain.USER_OFF;
                    break;
                case "UCLoaihoadon":
                    FrmMain.FLAG_LOAI_HOA_DON = FrmMain.USER_OFF;
                    break;
                case "UCLoaibanh":
                    FrmMain.FLAG_PRODUCT_TYPE = FrmMain.USER_OFF;
                    break;
                case "UCKhachhang":
                    FrmMain.FLAG_CUSTOMER = FrmMain.USER_OFF;
                    break;
                case "UCDoimatkhau":
                    FrmMain.FLAG_DOI_MAT_KHAU = FrmMain.USER_OFF;
                    break;
                case "UCDanhsachbanh":
                    FrmMain.FLAG_DISTRIBUTOR = FrmMain.USER_OFF;
                    break;
                case "UCCongthucbanh":
                    FrmMain.FLAG_CONG_THUC_BANH = FrmMain.USER_OFF;
                    break;
                case "UCChitiethoadon":
                    FrmMain.FLAG_BILL = FrmMain.USER_OFF;
                    break;
                case "UCBanh":
                    FrmMain.FLAG_PRODUCT = FrmMain.USER_OFF;
                    break;
                case "UCDsnguyenlieu":
                    FrmMain.FLAG_DANH_SACH_NGUYEN_LIEU = FrmMain.USER_OFF;
                    break;
                default:
                    break;
            }
            //this.Close();
        }
    }
}
