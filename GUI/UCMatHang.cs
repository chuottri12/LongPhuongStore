using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
namespace GUI
{
    public partial class UCMatHang : UserControl
    {
        public UCMatHang()
        {
            InitializeComponent();
        }
        //-------------------------------------------BIẾN------------------------------------------
        Boolean them;
        BUS_Products busbanh = new BUS_Products();
        BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
        //-------------------------------------------HÀM-------------------------------------------
        private void LoadData()
        {/*
            DataTable dt = new DataTable();
            dt = busbanh.Danhsach();
            dgbanh.DataSource = dt;
            dgbanh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgbanh.Columns["Mabanh"].HeaderText = "Mã bánh";
            dgbanh.Columns["Mabanh"].Width = 150;
            dgbanh.Columns["Tenbanh"].HeaderText = "Tên bánh";
            dgbanh.Columns["Tenbanh"].Width = 150;
            dgbanh.Columns["Maloaibanh"].HeaderText = "Mã loại bánh";
            dgbanh.Columns["Maloaibanh"].Width = 150;
            dgbanh.Columns["Tenloai"].HeaderText = "Tên loại bánh";
            dgbanh.Columns["Tenloai"].Width = 150;
            dgbanh.Columns["Hansudung"].HeaderText = "Hạn dùng";
            dgbanh.Columns["Hansudung"].Width = 150;
            dgbanh.Columns["Gia"].HeaderText = "Giá";
            dgbanh.Columns["Gia"].Width = 200;
            */
        }
        private void Nut(Boolean a)
        {
            
            btthem.Enabled = a;
            btsua.Enabled = a;
            btxoa.Enabled = a;
            dgbanh.Enabled = a;
            tbmabanh.Enabled = a;

            cbmaloaibanh.Enabled = !a;
            bthuy.Enabled = !a;
            btluu.Enabled = !a;
        }
        private void TextBNull()
        {
            tbmabanh.Text = "";
            tbtenbanh.Text = "";
            //tbtenloaibanh.Text = "";
            cbmaloaibanh.Text = "";
            tbGiaNhap.Text = "";
            //tbhandung.Text = "";
        }
        private Boolean KiemTraThem()
        {/*
            if (tbtenbanh.Text == "")
            {
                MessageBox.Show("Điền vào tên bánh!", "Thông báo");
                tbtenbanh.Focus();
                return false;
            }
            else
                if (cbmaloaibanh.Text == "")
                {
                    MessageBox.Show("Điền vào mã loại bánh!", "Thông báo");
                    cbmaloaibanh.Focus();
                    return false;
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt = busbanh.KiemtraMaloai(cbmaloaibanh.Text);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Mã loại bánh không tồn tại!", "Thông báo");
                        cbmaloaibanh.Focus();
                        return false;
                    }
                    else
                    {
                        if (tbhandung.Text == "")
                        {
                            MessageBox.Show("Điền vào hạn dùng cho bánh!", "Thông báo");
                            tbhandung.Focus();
                            return false;
                        }
                        else
                            if (buschuanhoaxau.SoNguyen(tbhandung.Text) == false)
                            {
                                MessageBox.Show("Hạn dùng không hợp lệ!", "Thông báo");
                                tbhandung.Focus();
                                return false;
                            }
                            else
                                if (int.Parse(tbhandung.Text) <=0)
                                {
                                    MessageBox.Show("Hạn dùng không hợp lệ!", "Thông báo");
                                    tbhandung.Focus();
                                    return false;
                                }
                                else
                                    if (tbGiaNhap.Text == "")
                                    {
                                        MessageBox.Show("Điền vào giá của bánh!", "Thông báo");
                                        tbGiaNhap.Focus();
                                        return false;
                                    }
                                    else
                                        if (buschuanhoaxau.SoLe(tbGiaNhap.Text) == false)
                                        {
                                            MessageBox.Show("Giá không hợp lệ!", "Thông báo");
                                            tbGiaNhap.Focus();
                                            return false;
                                        }
                                        else
                                            if (float.Parse(tbGiaNhap.Text) <= 0)
                                            {
                                                MessageBox.Show("Giá không hợp lệ!", "Thông báo");
                                                tbGiaNhap.Focus();
                                                return false;
                                            }
                                            else
                                            {
                                                tbtenbanh.Text = buschuanhoaxau.Ten(tbtenbanh.Text);
                                                return true;
                                            }
                    }
                }*/
            return true;
        }
        //-------------------------------------------MAIN------------------------------------------

        private void UCBanh_Load(object sender, EventArgs e)
        {
            Nut(true);
            LoadData();
            cbmaloaibanh.DataSource = busbanh.getAllData();
            cbmaloaibanh.DisplayMember = "Maloaibanh";
            cbmaloaibanh.ValueMember = "Maloaibanh";
            cbmaloaibanh.Text = "";
            TextBNull();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            //dgbanh.DataSource = busbanh.TimKiem(tkmabanh.Text, tktenbanh.Text, tkmaloai.Text, tktenloaibanh.Text);
        }

        private void btdanhsach_Click(object sender, EventArgs e)
        {
            //LoadData();
            //tktenloaibanh.Text = "";
            //tktenbanh.Text = "";
            //tkmaloai.Text = "";
            //tkmabanh.Text = "";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            TextBNull();
            //tbmabanh.Text = busbanh.SinhMaBanh();
            Nut(false);
            them = true;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (tbmabanh.Text == "")
            {
                MessageBox.Show("Điền vào mã bánh cần sửa!", "Thông báo");
                tbmabanh.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                //dt = busbanh.KiemtraMabanh(tbmabanh.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã bánh không tồn tại!", "Thông báo");
                    tbmabanh.Focus();
                }
                else
                {
                    Nut(false);
                    them = false;
                    tbmabanh.Text = dt.Rows[0]["Mabanh"].ToString();
                    tbtenbanh.Text = dt.Rows[0]["Tenbanh"].ToString();
                    cbmaloaibanh.Text = dt.Rows[0]["Maloaibanh"].ToString();
                    //tbhandung.Text = dt.Rows[0]["Hansudung"].ToString();
                    tbGiaNhap.Text = dt.Rows[0]["Gia"].ToString();
                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {/*
            if (them == true)
            {
                if (KiemTraThem())
                {
                    Banh banh = new Banh(tbmabanh.Text, tbtenbanh.Text, cbmaloaibanh.Text, int.Parse(tbhandung.Text), float.Parse(tbGiaNhap.Text));
                    if (busbanh.Them(banh))
                    {
                        MessageBox.Show("Thêm mới thành công!", "Thông báo");
                        LoadData();
                        TextBNull();
                        Nut(true);
                    }
                    else
                        MessageBox.Show("Thêm mới thất bại", "Thông báo");
                }
            }
            else
            {
                if (KiemTraThem())
                {
                    Banh banh = new Banh(tbmabanh.Text, tbtenbanh.Text, cbmaloaibanh.Text, int.Parse(tbhandung.Text), float.Parse(tbGiaNhap.Text));
                    if (busbanh.Sua(banh))
                    {
                        MessageBox.Show("Sửa thông tin bánh thành công!", "Thông báo");
                        LoadData();
                        TextBNull();
                        Nut(true);
                    }
                    else
                        MessageBox.Show("Sửa thông tin bánh thất bại", "Thông báo");
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
            if (tbmabanh.Text == "")
            {
                MessageBox.Show("Điền vào mã bánh cần xóa!", "Thông báo");
                tbmabanh.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                //dt = busbanh.KiemtraMabanh(tbmabanh.Text);
                if(dt.Rows.Count==0)
                {
                    MessageBox.Show("Mã bánh cần xóa không tồn tại!", "Thông báo");
                    tbmabanh.Focus();
                }
                else
                    if (DialogResult.OK == MessageBox.Show("Bạn có muốn xóa bánh có mã " + tbmabanh.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel))
                    {
                        if (busbanh.delete(tbmabanh.Text) == true)
                        {
                            TextBNull();
                            MessageBox.Show("Xoá thành công!", "Thông báo");
                            LoadData();
                        }
                        else
                            MessageBox.Show("Xóa thất bại!", "Thông báo");
                    }
            }
        }

        private void cbmaloaibanh_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = busbanh.KiemtraMaloai(cbmaloaibanh.Text);
            //if (dt.Rows.Count == 0)
            //{
            //}
            //else
            //{
            //    //tbtenloaibanh.Text = dt.Rows[0]["Tenloai"].ToString();
            //}
        }

        private void dgbanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataTable dt;
            dt = busbanh.getAllData();
            try
            {
                tbmabanh.Text = dt.Rows[i]["Mabanh"].ToString();
                tbtenbanh.Text = dt.Rows[i]["Tenbanh"].ToString();
                //tbtenloaibanh.Text = dt.Rows[i]["Tenloai"].ToString();
                cbmaloaibanh.Text = dt.Rows[i]["Maloaibanh"].ToString();
                tbGiaNhap.Text = dt.Rows[i]["Gia"].ToString();
                //tbhandung.Text = dt.Rows[i]["Hansudung"].ToString();
            }
            catch
            {
                TextBNull();
            }
        }

    }
}
