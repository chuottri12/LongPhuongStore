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
    public partial class UCHoadonBan : UserControl
    {
        public UCHoadonBan()
        {
            InitializeComponent();
        }
        //-------------------------------------------BIẾN------------------------------------------
        Boolean them;
        BUS_ReceiveBill bushd = new BUS_ReceiveBill();
        BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
        BUS_Customer buskh = new BUS_Customer();
        //BUS_Loaihoadon busloaihd = new BUS_Loaihoadon();
        BUS_Employ busnhanvien = new BUS_Employ();
        //-------------------------------------------HÀM-------------------------------------------
        private void LoadData()
        {/*
            DataTable dt = new DataTable();
            dt = bushd.Danhsach();
            dghoadon.DataSource = dt;
            dghoadon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dghoadon.Columns["mahd"].HeaderText = "Mã hóa đơn";
            dghoadon.Columns["tenhd"].HeaderText = "Tên hóa đơn";
            dghoadon.Columns["maloaihd"].HeaderText = "Mã loại hóa đơn";
            dghoadon.Columns["manv"].HeaderText = "Mã nhân viên";
            dghoadon.Columns["ngaylap"].HeaderText = "Ngày lập";
            dghoadon.Columns["ngaylay"].HeaderText = "Ngày lấy";
            dghoadon.Columns["tienbanh"].HeaderText = "Tiền bánh";
            dghoadon.Columns["tiencoc"].HeaderText = "Tiền cọc";
            dghoadon.Columns["thanhtoan"].HeaderText = "Thanh toán";
            */
        }
        private void Nut(Boolean a)
        {

            btthem.Enabled = a;
            btsua.Enabled = a;
            btxoa.Enabled = a;
            dghoadon.Enabled = a;
            //tbmahd.Enabled = a;

            cbmakh.Enabled = !a;
            cbmaloaihd.Enabled = !a;
            //cbmanv.Enabled = !a;
            bthuy.Enabled = !a;
            btluu.Enabled = !a;
        }
        private void TextBNull()
        {
            //tbmahd.Text = "";
            //tbtenhd.Text = "";
            cbmakh.Text = "";
            cbmaloaihd.Text = "";
            //cbmanv.Text = "";
            //tbtienbanh.Text = "";
            //tbtiencoc.Text = "";
            //tbthanhtoan.Text = "";
        }
        private Boolean KiemTraThem()
        {
            /*
            if(tbtenhd.Text=="")
            {
                MessageBox.Show("Điền vào tên hóa đơn!", "Thông báo");
                tbtenhd.Focus();
                return false;
            }
            else
                if(tbtenkh.Text=="")
                {
                    MessageBox.Show("Mã khách hàng không hợp lệ!", "Thông báo");
                    cbmakh.Focus();
                    return false;
                }
                else
                    if(tbtenloaihd.Text=="")
                    {
                        MessageBox.Show("Mã loại hóa đơn không hợp lệ!", "Thông báo");
                        cbmaloaihd.Focus();
                        return false;
                    }
                    else
                        if(tbtennv.Text=="")
                        {
                            MessageBox.Show("Mã nhân viên không hợp lệ!", "Thông báo");
                            cbmanv.Focus();
                            return false;
                        }
                        else
                            if(dtngaylap.Value.Date>DateTime.Now.Date)
                            {
                                MessageBox.Show("Ngày lập hóa đơn không hợp lệ!", "Thông báo");
                                dtngaylap.Focus();
                                return false;
                            }
                            else
                                if(dtngaylay.Value.Date>dtngaylap.Value.Date)
                                {
                                    MessageBox.Show("Ngày lấy hóa đơn không hợp lệ!", "Thông báo");
                                    dtngaylay.Focus();
                                    return false;
                                }   
                                else
                                    if(tbtiencoc.Text=="")
                                    {
                                        MessageBox.Show("Điền vào tiền cọc!", "Thông báo");
                                        tbtiencoc.Focus();
                                        return false;
                                    } 
                                    else
                                        if(buschuanhoaxau.SoNguyen(tbtiencoc.Text)==false)
                                        {
                                            MessageBox.Show("Tiền cọc không hợp lệ!", "Thông báo");
                                            tbtiencoc.Focus();
                                            return false;
                                        }
                                        else
                                            if(tbthanhtoan.Text=="")
                                                {
                                                    MessageBox.Show("Điền vào tiền thanh toán!", "Thông báo");
                                                    tbthanhtoan.Focus();
                                                    return false;
                                                } 
                                                else
                                                    if (buschuanhoaxau.SoNguyen(tbthanhtoan.Text) == false)
                                                    {
                                                        MessageBox.Show("Tiền thanh toán không hợp lệ!", "Thông báo");
                                                        tbthanhtoan.Focus();
                                                        return false;
                                                    }
                                                    else
                                                       if(tbtienbanh.Text=="")
                                                        {
                                                            tbtienbanh.Text="0";
                                                           tbtenhd.Text=buschuanhoaxau.Ten(tbtenhd.Text);
                                                            return true;
                                                        } 
                                                        else
                                                           if (buschuanhoaxau.SoNguyen(tbtienbanh.Text) == false)
                                                           {
                                                               MessageBox.Show("Tiền bánh không hợp lệ!", "Thông báo");
                                                               tbtienbanh.Focus();
                                                               return false;
                                                           }
                                                           else
                                                           {
                                                               tbtenhd.Text = buschuanhoaxau.Ten(tbtenhd.Text);
                                                               return true;
                                                           }*/
            return true;
            
        }

        private void UCHoadon_Load(object sender, EventArgs e)
        {
            Nut(true);
            LoadData();
            //cbmakh.DataSource = buskh.getAllData();
            //cbmakh.DisplayMember = "Makh";
            //cbmakh.ValueMember = "Makh";

            //cbmaloaihd.DataSource = busloaihd.Danhsach();
            //cbmaloaihd.DisplayMember = "Maloaihd";
            //cbmaloaihd.ValueMember = "Maloaihd";

            //cbmanv.DataSource = busnhanvien.DanhSach();
            //cbmanv.DisplayMember = "Manv";
            //cbmanv.ValueMember = "Manv";

            TextBNull();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            TextBNull();
            //tbmahd.Text = bushd.SinhMaHd();
            //tbtienbanh.Text = "0";
            Nut(false);
            them = true;
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            Nut(true);
            TextBNull();
        }

        private void cbmakh_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = buskh.getDataWithId(cbmakh.Text);
            if (dt.Rows.Count == 0)
                tbtenkh.Text = "";
            else
            {
                tbtenkh.Text = dt.Rows[0]["tenkh"].ToString();
            }
        }

        private void cbmaloaihd_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //dt = busloaihd.Danhsach(cbmaloaihd.Text);
            //if (dt.Rows.Count == 0)
            //{
            //}
            //tbtenloaihd.Text = "";
            //else
            //{
            //    //tbtenloaihd.Text = dt.Rows[0]["Tenloai"].ToString();
            //}
        }

        private void cbmanv_TextChanged(object sender, EventArgs e)
        {/*
            DataTable dt = new DataTable();
            dt = busnhanvien.DanhSach(cbmanv.Text);
            if (dt.Rows.Count == 0)
                tbtennv.Text="";
            else
            {
                tbtennv.Text = dt.Rows[0]["Tennv"].ToString();
            }*/
        }

        private void dghoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataTable dt;
            dt = bushd.Danhsach();
            try
            {
                //tbmahd.Text = dt.Rows[i]["mahd"].ToString();
                //tbtenhd.Text = dt.Rows[i]["tenhd"].ToString();
                cbmakh.Text = dt.Rows[i]["makh"].ToString();
                cbmaloaihd.Text = dt.Rows[i]["maloaihd"].ToString();
                //cbmanv.Text = dt.Rows[i]["manv"].ToString();
                dtngaylap.Text = dt.Rows[i]["ngaylap"].ToString();
                //dtngaylay.Text = dt.Rows[i]["ngaylay"].ToString();
                //tbtienbanh.Text = dt.Rows[i]["tienbanh"].ToString();
                //tbtiencoc.Text = dt.Rows[i]["tiencoc"].ToString();
                //tbthanhtoan.Text = dt.Rows[i]["thanhtoan"].ToString();
                
            }
            catch
            {
                TextBNull();
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {/*
            if ( tbmahd.Text == "")
            {
                MessageBox.Show("Điền vào mã hóa đơn cần sửa!", "Thông báo");
                tbmahd.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = bushd.Danhsach(tbmahd.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại!", "Thông báo");
                    tbmahd.Focus();
                }
                else
                {
                    Nut(false);
                    them = false;
                    tbmahd.Text = dt.Rows[0]["mahd"].ToString();
                    tbtenhd.Text = dt.Rows[0]["tenhd"].ToString();
                    cbmakh.Text = dt.Rows[0]["makh"].ToString();
                    cbmaloaihd.Text = dt.Rows[0]["maloaihd"].ToString();
                    cbmanv.Text = dt.Rows[0]["manv"].ToString();
                    dtngaylap.Text = dt.Rows[0]["ngaylap"].ToString();
                    dtngaylay.Text = dt.Rows[0]["ngaylay"].ToString();
                    tbtienbanh.Text = dt.Rows[0]["tienbanh"].ToString();
                    tbtiencoc.Text = dt.Rows[0]["tiencoc"].ToString();
                    tbthanhtoan.Text = dt.Rows[0]["thanhtoan"].ToString();
                }
            }*/
        }

        private void btluu_Click(object sender, EventArgs e)
        {/*
            if (them == true)
            {
                if (KiemTraThem())
                {
                    Hoadon hd = new Hoadon(tbmahd.Text, tbtenhd.Text, cbmakh.Text, cbmaloaihd.Text, cbmanv.Text, dtngaylap.Value, dtngaylay.Value, 0, float.Parse(tbtiencoc.Text), float.Parse(tbthanhtoan.Text));
                    if (bushd.Them(hd))
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
                    Hoadon hd = new Hoadon(tbmahd.Text, tbtenhd.Text, cbmakh.Text, cbmaloaihd.Text, cbmanv.Text, dtngaylap.Value, dtngaylay.Value, float.Parse(tbtienbanh.Text), float.Parse(tbtiencoc.Text), float.Parse(tbthanhtoan.Text));
                    if (bushd.Sua(hd))
                    {
                        MessageBox.Show("Sửa thông tin hóa đơn thành công!", "Thông báo");
                        LoadData();
                        TextBNull();
                        Nut(true);
                    }
                    else
                        MessageBox.Show("Sửa thông tin hóa đơn thất bại", "Thông báo");
                }
            }*/
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            /*
            if (tbmahd.Text == "")
            {
                MessageBox.Show("Điền vào mã hóa đơn cần xóa!", "Thông báo");
                tbmahd.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = bushd.Danhsach(tbmahd.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã hóa đơn cần xóa không tồn tại!", "Thông báo");
                    tbmahd.Focus();
                }
                else
                    if (DialogResult.OK == MessageBox.Show("Bạn có muốn xóa bánh có mã " + tbmahd.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel))
                    {
                        if (bushd.Xoa(tbmahd.Text) == true)
                        {
                            TextBNull();
                            MessageBox.Show("Xoá thành công!", "Thông báo");
                            LoadData();
                        }
                        else
                            MessageBox.Show("Xóa thất bại!", "Thông báo");
                    }
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
