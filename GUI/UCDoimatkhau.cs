using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUS;
using DTO;
using System.Drawing.Imaging;

namespace GUI
{
    public partial class UCDoimatkhau : UserControl
    {
        public UCDoimatkhau()
        {
            InitializeComponent();
        }
        //-----------------------------------Bien-----------------------------

        //----------------------------------------cac ham-------------------

        //ảnh -> byte[]
        private byte[] AnhThanhByte(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Png);
            return (byte[])ms.ToArray();
        }
        //----------------------------------------Main--------------------------
        private void UserAdmin_Load(object sender, EventArgs e)
        {
            gbdoimatkhau.Hide();
        }

        private void btdoimatkhau_Click(object sender, EventArgs e)
        {
            gbdoimatkhau.Show();
            btdangxuat.Enabled = false;
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (tbmatkhaucu.Text == "")
            {
                MessageBox.Show("Bạn hãy điền vào mật khẩu cũ!", "Thông báo");
                tbmatkhaucu.Focus();
            }
            else
                if (tbmatkhaumoi.Text == "")
                {
                    MessageBox.Show("Bạn phải điền vào mật khẩu mới!", "Thông báo");
                    tbmatkhaumoi.Focus();
                }
                else
                    if (tbnhaclaimatkhau.Text == "")
                    {
                        MessageBox.Show("Bạn phải nhắc lại mật khẩu mới!", "Thông báo");
                        tbnhaclaimatkhau.Focus();
                    }
                    else
                    {
                        BUS_Employ busEmploy = new BUS_Employ();
                        DataTable dataTable;
                        dataTable = busEmploy.login(tbmanv.Text, tbmatkhaucu.Text);
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Mật khẩu cũ điền vào không đúng!", "Thông báo");
                            tbmatkhaucu.Text = "";
                            tbmatkhaucu.Focus();
                        }
                        else
                        {
                            if (String.Compare(tbmatkhaumoi.Text, tbnhaclaimatkhau.Text, false) == 0)
                            {
                                //thực hiện đổi mật khẩu
                                EmployeeModel employ = new EmployeeModel();
                                if (busEmploy.edit(employ))
                                {
                                    MessageBox.Show("Đổi mật khẩu thành công, bạn phải đăng nhập lại để tiếp tục!", "Thông báo");
                                    this.FindForm().Close();
                                }
                                else
                                    MessageBox.Show("Thất bại!", "Thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu mới điền vào không khớp nhau!", "Thông báo");
                                tbmatkhaumoi.Text = "";
                                tbmatkhaumoi.Focus();
                                tbnhaclaimatkhau.Text = "";
                            }
                        }

                    }
        }

        private void chhienmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chhienmatkhau.Checked == true)
            {
                tbmatkhaucu.PasswordChar = (char)0;
                tbmatkhaumoi.PasswordChar = (char)0;
                tbnhaclaimatkhau.PasswordChar = (char)0;
            }
            else
            {
                tbmatkhaucu.PasswordChar = '*';
                tbmatkhaumoi.PasswordChar = '*';
                tbnhaclaimatkhau.PasswordChar = '*';
            }
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK==MessageBox.Show("Bạn có thực sự muốn đăng xuất khỏi hệ thống không!","Thông báo",MessageBoxButtons.OKCancel))
                this.FindForm().Close();
        }

        private void bthuydoimatkhau_Click(object sender, EventArgs e)
        {
            gbdoimatkhau.Hide();
            btdangxuat.Enabled = true;
        }
    }
}
