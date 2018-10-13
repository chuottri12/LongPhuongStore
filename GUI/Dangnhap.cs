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
using DTO;
using System.IO;
namespace GUI
{
    public partial class Form1 : Form
    {
        BUS_Employ bus_nhanvien = new BUS_Employ();
        public Form1()
        {
            InitializeComponent();
        }

        private Image ByteThanhAnh(byte[] byteArrayIn)
        {
            MemoryStream ss = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ss);
            return returnImage;
        }

        private Boolean ktthongtin()
        {
            if (tendangnhap.Text == "" && matkhau.Text == "")
            {
                tendangnhap.Focus();
                thongbao.Text = "Điền tên đăng nhập và mật khẩu";
                return false;
            }
            else
            {
                if (tendangnhap.Text == "")
                {
                    tendangnhap.Focus();
                    thongbao.Text = "Điền tên đăng nhập";
                    return false;
                }
                else
                {
                    if (matkhau.Text == "")
                    {
                        matkhau.Focus();
                        thongbao.Text = "Điền vào mật khẩu";
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dang_nhap();
        }

        private void dang_nhap()
        {
            if (ktthongtin() == true)
            {
                DataTable dn = new DataTable();
                dn = bus_nhanvien.login(tendangnhap.Text, matkhau.Text);

                if (dn.Rows.Count == 0)
                {
                    thongbao.Text = "Sai mật khẩu hoặc tên đăng nhập";
                    tendangnhap.Focus();
                    matkhau.Text = "";
                }
                else
                {
                    this.Hide();
                    FrmMain a = new FrmMain();
                    a.Show();
                    a.tennguoidung.Text = dn.Rows[0]["Employ_Name"].ToString();
                    a.manhanvien.Text = dn.Rows[0]["Employ_Id"].ToString();

                    try
                    {
                        Image anh = ByteThanhAnh((byte[])dn.Rows[0]["Employ_Image"]);
                        a.user.Image = anh;
                    }
                    catch (Exception ex) {
                        //a.user.Image = Image.FromFile(@"F:\Backup\HieubanhDatai\HieubanhDatai\images\default-user.png", true);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                matkhau.PasswordChar = (char)0;
            }
            else
            {
                matkhau.PasswordChar = '*';
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tendangnhap.Text = "";
            matkhau.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tendangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                matkhau.Focus();
            }
        }

        private void matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dang_nhap();
            }
        }
    }
}
