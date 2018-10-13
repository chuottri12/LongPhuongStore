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
    public partial class UCQLHoaDon : UserControl
    {
        public UCQLHoaDon()
        {
            InitializeComponent();
        }

        //-------------------------------------------BIẾN------------------------------------------
        //Boolean them;
        BUS_SellBill busSellBill = new BUS_SellBill();
        BUS_ReceiveBill busReceiveBill = new BUS_ReceiveBill();
        BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
        BUS_ReceiveBill bushd = new BUS_ReceiveBill();
        BUS_Products busbanh = new BUS_Products();
        //-------------------------------------------HÀM-------------------------------------------
        private void LoadData()
        {
            /*
            DataTable dt = new DataTable();
            dt = buscthd.Danhsach();

            dgcthd.DataSource = dt;
            dgcthd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgcthd.Columns["stt"].HeaderText = "Số thứ tự";
            dgcthd.Columns["mahd"].HeaderText = "Mã hóa đơn";
            dgcthd.Columns["mabanh"].HeaderText = "Mã bánh";
            dgcthd.Columns["soluong"].HeaderText = "Số lượng";
            dgcthd.Columns["dongia"].HeaderText = "Đơn giá";
            */
        }  
       
        private void Nut(Boolean a)
        {
            btthem.Enabled = a;
            btsua.Enabled = a;
            btxoa.Enabled = a;
            dgcthd.Enabled = a;
            tbstt.Enabled = a;
            //cbmabanh.Enabled = !a;
            cbmahd.Enabled = !a;
            bthuy.Enabled = !a;
            btluu.Enabled = !a;
        }

        private void TextBNull()
        {
            tbstt.Text = "";
            cbmahd.Text = ""; ;
          /*TriCV comment 18/6/2018 BEGIN*/
            //cbmabanh.Text = "";
            //tbsoluong.Text = "";
            //tbdongia.Text = "";
          /*TriCV comment 18/6/2018 END*/
        }

        private Boolean KiemTraThem()
        {
        /*TriCV comment 18/6/2018 BEGIN*/
            /*
            if (tbtenhd.Text == "")
            {
                MessageBox.Show("Mã hóa đơn không hợp lệ!", "Thông báo");
                cbmahd.Focus();
                return false;
            }
            else
                if (tbtebanh.Text == "")
                {
                    MessageBox.Show("Mã bánh không hợp lệ!", "Thông báo");
                    cbmabanh.Focus();
                    return false;
                }
                else
                    if (tbsoluong.Text == "")
                    {
                        MessageBox.Show("Điền vào số lượng!", "Thông báo");
                        tbsoluong.Focus();
                        return false;
                    }
                    else
                        if (buschuanhoaxau.SoNguyen(tbsoluong.Text) == false)
                        {
                            MessageBox.Show("Số lượng không hợp lệ!", "Thông báo");
                            tbsoluong.Focus();
                            return false;
                        }
                        else
                            if (tbdongia.Text == "")
                            {
                                MessageBox.Show("Điền vào đơn giá!", "Thông báo");
                                tbdongia.Focus();
                                return false;
                            }
                            else
                                if (buschuanhoaxau.SoNguyen(tbdongia.Text) == false)
                                {
                                    MessageBox.Show("Đơn giá không hợp lệ!", "Thông báo");
                                    tbdongia.Focus();
                                    return false;
                                }
                                else
                                    return true;
             * /
             /*TriCV comment 18/6/2018 END*/
            return true;
        }

        private void UCChitiethoadon_Load(object sender, EventArgs e)
        {
            Nut(true);
            LoadData();

            cbmahd.DataSource = bushd.Danhsach();
            cbmahd.DisplayMember = "mahd";
            cbmahd.ValueMember = "mahd";
            /*TriCV comment 18/6/2018 BEGIN*/
            /*
            cbmabanh.DataSource = busbanh.Danhsach();
            cbmabanh.DisplayMember = "Mabanh";
            cbmabanh.ValueMember = "Mabanh";
             */
            /*TriCV comment 18/6/2018 END*/
            
            TextBNull();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            //TextBNull();
            //tbstt.Text =Convert.ToString( buscthd.Sinhstt());
            //Nut(false);
            //them = true;
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            Nut(true);
            TextBNull();
        }

        private void cbmahd_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = bushd.Danhsach(cbmahd.Text);
            if (dt.Rows.Count == 0) 
            {
            }
            //tbtenhd.Text="";
            else
            {
                //tbtenhd.Text = dt.Rows[0]["Tenhd"].ToString();
            }
        }

        private void cbmabanh_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = busbanh.KiemtraMabanh(cbmabanh.Text);
            //if (dt.Rows.Count == 0)
            //    tbtebanh.Text = "";
            //else
            //{
            //    tbtebanh.Text = dt.Rows[0]["tenbanh"].ToString();
            //}
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            //if (tbstt.Text == "")
            //{
            //    MessageBox.Show("Điền vào số thứ tự của dòng cần sửa!", "Thông báo");
            //    tbstt.Focus();
            //}
            //else
            //{
            //    DataTable dt = new DataTable();
            //    dt = buscthd.Danhsach(tbstt.Text);
            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Số thự bản ghi không tồn tại!", "Thông báo");
            //        tbstt.Focus();
            //    }
            //    else
            //    {
            //        Nut(false);
            //        //them = false;
            //        cbmahd.Text = dt.Rows[0]["mahd"].ToString();
            //        //cbmabanh.Text = dt.Rows[0]["mabanh"].ToString();
            //        //tbsoluong.Text = dt.Rows[0]["soluong"].ToString();
            //        //tbdongia.Text = dt.Rows[0]["dongia"].ToString();
            //    }
            //}
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            /*
            if (them == true) //nế là thêm vào 
            {
                if (KiemTraThem())
                {
                    //Chitiethoadon cthd = new Chitiethoadon(int.Parse(tbstt.Text), cbmahd.Text, cbmabanh.Text, int.Parse(tbsoluong.Text), float.Parse(tbdongia.Text));
                    DataTable dt = new DataTable();
                    //dt = bushd.Danhsach(cthd.Mahoadon);
                    //kiểm tra xem việc thêm mới chi tiết hóa đơn và việc tăng tiền bánh trong hóa đơn có thực hiện được hay k
                    if (buscthd.Them(cthd) && bushd.Capnhattien(cthd.Soluong * cthd.Dongia + float.Parse(dt.Rows[0]["Tienbanh"].ToString()), cthd.Mahoadon)) 
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
            else //nếu là sửa thông tin chi tiết hóa đơn
            {
                if (KiemTraThem())
                {
                    //Chitiethoadon cthd = new Chitiethoadon(int.Parse(tbstt.Text), cbmahd.Text, cbmabanh.Text, int.Parse(tbsoluong.Text), float.Parse(tbdongia.Text));
                    
                    DataTable dt = new DataTable();
                    dt = buscthd.Danhsach(tbstt.Text); 
                    DataTable dt2 = new DataTable();
                    dt2 =bushd.Danhsach(cthd.Mahoadon);

                    float tichmoi = cthd.Dongia * cthd.Soluong;
                    float tichcu = float.Parse(dt.Rows[0]["dongia"].ToString()) * float.Parse(dt.Rows[0]["soluong"].ToString());
                    float tientl = tichmoi - tichcu;
                    float tien =float.Parse( dt2.Rows[0]["Tienbanh"].ToString());
                    if (bushd.Capnhattien(tien+tientl,cthd.Mahoadon) && buscthd.Sua(cthd) )
                    {
                        MessageBox.Show("Sửa thông tin bánh thành công!", "Thông báo");
                        LoadData();
                        TextBNull();
                        Nut(true);
                    }
                    else
                        MessageBox.Show("Sửa thông tin bánh thất bại", "Thông báo");
                }
            }
             */
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            //if (tbstt.Text == "")
            //{
            //    MessageBox.Show("Điền vào số thứ tự bản ghi cần xóa!", "Thông báo");
            //    tbstt.Focus();
            //}
            //else
            //{
            //    DataTable dt = new DataTable();
            //    dt = buscthd.Danhsach(tbstt.Text);
            //    if (dt.Rows.Count == 0)
            //    {
            //        MessageBox.Show("Số thứ tự bản ghi cần xóa không tồn tại!", "Thông báo");
            //        tbstt.Focus();
            //    }
            //    else
            //        if (DialogResult.OK == MessageBox.Show("Bạn có muốn xóa bánh có mã " + tbstt.Text + " không!", "Thông báo", MessageBoxButtons.OKCancel))
            //        {
            //            DataTable dt2 = new DataTable();
            //            dt2 = bushd.Danhsach(dt.Rows[0]["mahd"].ToString());
            //            float tiencu =float.Parse( dt2.Rows[0]["Tienbanh"].ToString());
            //            float tiengiam = float.Parse(dt.Rows[0]["dongia"].ToString()) * float.Parse(dt.Rows[0]["soluong"].ToString());
                        
                        
            //            if (bushd.Capnhattien(tiencu-tiengiam, dt.Rows[0]["mahd"].ToString()) && buscthd.Delete(tbstt.Text) )
            //            {
            //                TextBNull();
            //                MessageBox.Show("Xoá thành công!", "Thông báo");
            //                LoadData();
            //            }
            //            else
            //                MessageBox.Show("Xóa thất bại!", "Thông báo");
            //        }
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
