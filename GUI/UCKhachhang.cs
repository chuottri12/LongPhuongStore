using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;  
using BUS;
using DTO;
namespace GUI
{
    public partial class UCKhachhang : UserControl
    {
        public UCKhachhang()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------

        BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
        Boolean them;
        BUS_Customer buskh = new BUS_Customer();
        //-----------------------------------------------------------------------
        public void LoadData()
        {
            //dgkhachhang.DataSource = buskh.Danhsach();
            //dgkhachhang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgkhachhang.Columns["Makh"].HeaderText = "Mã khách hàng";
            //dgkhachhang.Columns["Makh"].Width = 90;
            //dgkhachhang.Columns["Tenkh"].HeaderText = "Tên khách hàng";
            //dgkhachhang.Columns["Tenkh"].Width = 130;
            //dgkhachhang.Columns["Maloaikh"].HeaderText = "Mã loại khách hàng";
            //dgkhachhang.Columns["Maloaikh"].Width = 90;
            //dgkhachhang.Columns["Ngaysinh"].HeaderText = "Ngày sinh";
            //dgkhachhang.Columns["Gioitinh"].HeaderText = "Giới tính";
            //dgkhachhang.Columns["Sdt"].HeaderText = "Số điện thoại";
            //dgkhachhang.Columns["Email"].HeaderText = "Địa chỉ Email";
            //dgkhachhang.Columns["Diachi"].HeaderText = "Lương cơ bản";
        }
        private void Nut(Boolean a)
        {
            btthem.Enabled = a;
            btsua.Enabled = a;
            btxoa.Enabled = a;
            //dgkhachhang.Enabled = a;
            tbmakh.Enabled = a;
            
            rbnam.Enabled = !a;
            rbnu.Enabled = !a;
            
            bthuy.Enabled = !a;
            btluu.Enabled = !a;
        }
        private void TextBNull()
        {
            tbmakh.Text = "";
            tbtenkh.Text = "";
            //cbloaikh.Text = "";
            //tbtenloai.Text = "";
            rbnam.Checked = false;
            rbnu.Checked = false;
            tbsdt.Text = "";
            tbemail.Text = "";
            tbdiachi.Text = "";
        }
        
        private Boolean KiemTraThem()
        {/*
            if (tbtenkh.Text == "")
            {
                MessageBox.Show("Điền vào tên khách hàng!", "Thông báo");
                tbtenkh.Focus();
                return false;
            }
            else
                if (cbloaikh.Text == "")
                {
                    MessageBox.Show("Điền vào mã loại khách hàng!", "Thông báo");
                    cbloaikh.Focus();
                    return false;
                }
                else
                    if (tbtenloai.Text == "")
                    {
                        MessageBox.Show("Mã loại khách hàng không tồn tại!", "Thông báo");
                        tbmakh.Focus();
                        return false;
                    }
                    else
                        if (rbnam.Checked == false && rbnu.Checked == false)
                        {
                            MessageBox.Show("Xác nhận giới tính cho khách hàng!", "Thông báo");
                            return false;
                        }
                        else
                            if (tbsdt.Text == "")
                            {
                                MessageBox.Show("Điền vào số điện thoại!", "Thông báo");
                                tbsdt.Focus();
                                return false;
                            }
                            else
                                if (buschuanhoaxau.SoNguyen(tbsdt.Text) == false || tbsdt.TextLength > 11 || tbsdt.TextLength < 10) //kt dãy ký tự nhập vào có chữ cái thì...
                                {
                                    MessageBox.Show("Số điện thoại nhập vào không hợp lệ!", "Thông báo");
                                    tbsdt.Focus();
                                    return false;
                                }
                                else
                                    if (tbemail.Text == "")
                                    {
                                        MessageBox.Show("Nhập vào Email!", "Thông báo");
                                        tbemail.Focus();
                                        return false;
                                    }
                                    else
                                    {
                                        string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                                        Regex reg = new Regex(match);
                                        if (reg.IsMatch(tbemail.Text) == false)
                                        {
                                            MessageBox.Show("Email không hợp lệ!", "Thông báo");
                                            tbemail.Focus();
                                            return false;
                                        }
                                        else
                                            if (tbdiachi.Text == "")
                                            {
                                                MessageBox.Show("Điền vào địa chỉ!", "Thông báo");
                                                tbdiachi.Focus();
                                                return false;
                                            }
                                            else
                                                if (dtpngaysinh.Value.Year > DateTime.Now.Year - 1)
                                                {
                                                    MessageBox.Show("Năm sinh không hợp lệ!", "Thông báo");
                                                    tbdiachi.Focus();
                                                    return false;
                                                }
                                                else
                                                {
                                                    tbtenkh.Text = buschuanhoaxau.Ten(tbtenkh.Text);
                                                    tbdiachi.Text = buschuanhoaxau.Ten(tbdiachi.Text);
                                                    return true;
                                                }
                                        

                                    }
            */
            return true;
        }
        //------------------------------------------MAIN------------------------------------------------
        private void UCKhachhang_Load(object sender, EventArgs e)
        {
            LoadData();
            //cbloaikh.DataSource = buskh.GetLoaiKH();
            //cbloaikh.DisplayMember = "Maloaikh";
            //cbloaikh.ValueMember = "Maloaikh";
            Nut(true);
        }

        private void dgkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataTable a;
            try
            {
                a = buskh.getAllData();
                tbmakh.Text = a.Rows[i]["makh"].ToString();
                tbtenkh.Text = a.Rows[i]["tenkh"].ToString();
                //cbloaikh.Text = a.Rows[i]["maloaikh"].ToString();
                tbemail.Text = a.Rows[i]["email"].ToString();
                tbdiachi.Text = a.Rows[i]["diachi"].ToString();
                tbsdt.Text = a.Rows[i]["Sdt"].ToString();
                dtpngaysinh.Text = a.Rows[i]["Ngaysinh"].ToString();
                if (a.Rows[i]["Gioitinh"].ToString() == "Nam")
                {
                    rbnam.Checked = true;
                }
                else
                    rbnu.Checked = true;
                
            }
            catch
            {
                TextBNull();
            }
        }

        private void cbloaikh_TextChanged(object sender, EventArgs e)
        {/*
            DataTable dt = new DataTable();
            dt = buskh.GetLoaiKH(cbloaikh.Text);
            if (dt.Rows.Count == 0)
                tbtenloai.Text = "";
            else
                tbtenloai.Text = dt.Rows[0]["Tenloai"].ToString();
          * */
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Nut(false);
            them = true;
            TextBNull();
            tbmakh.Text = buskh.SinhMakh();

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (tbmakh.Text == "")
                MessageBox.Show("Bạn phải điền vào mã khách hàng cần sửa!", "Thông báo");
            else
            {
                DataTable dt = new DataTable();
                dt = buskh.getDataWithId(tbmakh.Text);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Mã khách hàng điền vào không tồn tại!", "Thông báo");
                else
                {
                    Nut(false);
                    them = false;
                    tbtenkh.Text = dt.Rows[0]["tenkh"].ToString();
                    //cbloaikh.Text = dt.Rows[0]["maloaikh"].ToString();
                    tbemail.Text = dt.Rows[0]["email"].ToString();
                    tbdiachi.Text = dt.Rows[0]["diachi"].ToString();
                    dtpngaysinh.Text = dt.Rows[0]["Ngaysinh"].ToString();
                    if (String.Compare(dt.Rows[0]["Gioitinh"].ToString(), "Nam", true) == 0)
                        rbnam.Checked = true;
                    else
                        rbnu.Checked = true;
                    tbsdt.Text = dt.Rows[0]["Sdt"].ToString();
                }

            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {/*
            string gioitinh;
            if (them == true)
            {
                if (KiemTraThem() == true)
                {
                    if (rbnam.Checked == true)
                        gioitinh = "Nam";
                    else
                        gioitinh = "Nữ";
                    //Khachhang kh = new Khachhang(tbmakh.Text, tbtenkh.Text, cbloaikh.Text, dtpngaysinh.Value, gioitinh,tbsdt.Text, tbemail.Text, tbdiachi.Text);
                    if (buskh.Them(kh) == false)
                        MessageBox.Show("Thêm mới thất bại","Thông báo");
                    else
                    {
                        MessageBox.Show("Thêm mới thành công", "Thông báo");
                        Nut(true);
                        LoadData();
                        TextBNull();

                    }
                }
            }
            else
            {
                if (KiemTraThem() == true)
                {
                    if (rbnam.Checked == true)
                        gioitinh = "Nam";
                    else
                        gioitinh = "Nữ";
                    //Khachhang kh = new Khachhang(tbmakh.Text, tbtenkh.Text, cbloaikh.Text, dtpngaysinh.Value, gioitinh, tbsdt.Text, tbemail.Text, tbdiachi.Text);
                    if (buskh.Sua(kh) == false)
                        MessageBox.Show("Sửa thông tin Khách hàng  thất bại", "Thông báo");
                    else
                    {
                        MessageBox.Show("Sửa thông tin Khách hàng thành công", "Thông báo");
                        LoadData();
                        Nut(true);
                        TextBNull();
                    }
                }
            }*/
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            Nut(true);
            TextBNull();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (tbmakh.Text == "")
                MessageBox.Show("Bạn phải điền vào mã nhân viên cần xóa!", "Thông báo");
            else
            {
                DataTable dt = new DataTable();
                dt = buskh.getDataWithId(tbmakh.Text);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Mã nhân viên " + tbmakh.Text + " không tồn tại!", "Thông báo");
                else
                {
                    if (DialogResult.OK == MessageBox.Show("Bạn có muốn xóa nhân viên có mã " + tbmakh.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel))
                        if (buskh.delete(tbmakh.Text))
                        {
                            MessageBox.Show("Xóa nhân viên có mã " + tbmakh.Text + " thành công!", "Thông báo");
                            LoadData(); 
                            TextBNull();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên có mã " + tbmakh.Text + " thất bại!", "Thông báo");
                        }
                }
            }
        }
    }
}
