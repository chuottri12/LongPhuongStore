using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
namespace GUI
{
    public partial class UCLoaiMatHang : UserControl
    {
        public UCLoaiMatHang()
        {
            InitializeComponent();
        }
        //--------------------------------------BIẾN----------------------------------------
        BUS_ProductType busloaibanh = new BUS_ProductType();
        BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
        Boolean them;
        //--------------------------------------HÀM-----------------------------------------
        private void LoadData()
        {
            DataTable dt = new DataTable();
            dt = busloaibanh.getAllData();
            dgloaibanh.DataSource = dt;
            dgloaibanh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgloaibanh.Columns["Maloaibanh"].HeaderText="Mã loại bánh";
            dgloaibanh.Columns["Tenloai"].HeaderText="Tên loại bánh";
            dgloaibanh.Columns["Tenloai"].Width = 150;
            dgloaibanh.Columns["Mota"].HeaderText="Mô tả";
            dgloaibanh.Columns["Mota"].Width = 900;

        }
        private void Nut(Boolean a)
        {
            btthem.Enabled = a;
            btsua.Enabled = a;
            btxoa.Enabled = a;
            dgloaibanh.Enabled = a;
            tbmaloaibanh.Enabled = a;
            
            bthuy.Enabled = !a;
            btluu.Enabled = !a;
        }
        private void TextBNull()
        {
            tbmaloaibanh.Text = "";
            tbmota.Text = "";
            tbtenloaibanh.Text = "";
        }
        private Boolean KiemTraThem()
        {
            if (tbtenloaibanh.Text == "")
            {
                MessageBox.Show("Điền vào tên loại bánh!", "Thông báo");
                tbtenloaibanh.Focus();
                return false;
            }
            else
            {
                tbtenloaibanh.Text = buschuanhoaxau.Ten(tbtenloaibanh.Text);
                if (tbmota.Text == "")
                {
                    MessageBox.Show("Hãy điền mô tả cho loại bánh!", "Thông báo");
                    tbmota.Focus();
                    return false;
                }
                else
                {
                    tbmota.Text = buschuanhoaxau.DoanVan(tbmota.Text);
                    return true;
                }
            }
        }
        //--------------------------------------MAIN----------------------------------------

        private void UCLoaibanh_Load(object sender, EventArgs e)
        {
            LoadData();
            Nut(true);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Nut(false);
            them = true;
            TextBNull();
            //tbmaloaibanh.Text = busloaibanh.SinhMaLoaibanh();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            Nut(true);
            TextBNull();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (tbmaloaibanh.Text == "")
            {
                MessageBox.Show("Điền vào mã loại bánh cần chỉnh sửa!", "Thông báo");
                tbmaloaibanh.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = busloaibanh.getAllData();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã loại bánh bạn điền vào không tồn tai!", "Thông báo");
                    tbmaloaibanh.Focus();
                }
                else
                {
                    tbmaloaibanh.Text=dt.Rows[0]["Maloaibanh"].ToString();
                    tbtenloaibanh.Text = dt.Rows[0]["Tenloai"].ToString();
                    tbmota.Text = dt.Rows[0]["Mota"].ToString();
                    Nut(false);
                    them = false;
                }
            }

        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                if (KiemTraThem() == true)
                {
                    ProductTypeModel loaibanh = new ProductTypeModel(tbmaloaibanh.Text, tbtenloaibanh.Text, tbmota.Text);
                    if (busloaibanh.add(loaibanh) == false)
                        MessageBox.Show("Thêm loại bánh thất bại", "Thông báo");
                    else
                    {
                        MessageBox.Show("Thêm loại bánh thành công", "Thông báo");
                        TextBNull();
                        Nut(true);
                        LoadData();
                    }
                }
            }
            else //Nếu là sửa
            { 
                if(tbtenloaibanh.Text=="")
                    MessageBox.Show("Điền vào tên loại bánh", "Thông báo");
                else
                    if (tbmota.Text == "")
                        MessageBox.Show("Điền vào mô tả cho loại bánh", "Thông báo");
                    else
                    {
                        tbtenloaibanh.Text = buschuanhoaxau.Ten(tbtenloaibanh.Text);
                        tbmota.Text = buschuanhoaxau.DoanVan(tbmota.Text);
                        ProductTypeModel loaibanh = new ProductTypeModel(tbmaloaibanh.Text, tbtenloaibanh.Text, tbmota.Text);
                        if(busloaibanh.edit(loaibanh)==false)
                            MessageBox.Show("Sửa loại bánh thất bại!","Thông báo");
                        else
                        {
                            MessageBox.Show("Sửa loại bánh thành công!","Thông báo");
                            TextBNull();
                            Nut(true);
                            LoadData();
                        }
                    }


            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            //if (tbmaloaibanh.Text == "")
            //{
            //    MessageBox.Show("Điền vào mã loại bánh cần xóa!", "Thông báo");
            //    tbmaloaibanh.Focus();
            //}
            //else
            //{
            //    DataTable dt = new DataTable();
            //    dt = busloaibanh.KiemTraSua(tbmaloaibanh.Text);
            //    if(dt.Rows.Count==0)
            //    {
            //        MessageBox.Show("Mã loại bánh không tồn tại!", "Thông báo");
            //        tbmaloaibanh.Text="";
            //        tbmaloaibanh.Focus();
            //    }
            //    else
            //        if (DialogResult.OK == MessageBox.Show("Bạn có muốn xóa Loại bánh có mã " + tbmaloaibanh.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel))
            //            if (busloaibanh.Xoa(tbmaloaibanh.Text) == false)
            //                MessageBox.Show("Xóa loại bánh thất bại!", "Thông báo");
            //            else
            //            {
            //                MessageBox.Show("Xóa loại bánh thành công!", "Thông báo");
            //                LoadData();
            //            }
            //}
        }

        private void dgloaibanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataTable a;
            try
            {

                a = busloaibanh.getAllData();
                 
                tbmaloaibanh.Text = a.Rows[i]["Maloaibanh"].ToString();
                tbtenloaibanh.Text = a.Rows[i]["Tenloai"].ToString();
                tbmota.Text = a.Rows[i]["Mota"].ToString();
            }
            catch
            {
                tbmaloaibanh.Text = "";
                tbtenloaibanh.Text = "";
                tbmota.Text = "";
            }
        }

        private void btdanhsach_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            //dgloaibanh.DataSource = busloaibanh.TimKiem(tblmaloaibanh.Text, tbltenloaibanh.Text);
        }
    }
}
