using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class UCLoainv : UserControl
    {
        
        //----------------------------BIẾN--------------------
        Boolean them;
        BUS_Quarter bus_loainv = new BUS_Quarter();
        BUS_Chuanhoaxau buschuanhoa = new BUS_Chuanhoaxau();
        public string name = "Loai nhân viên";

        //----------------------------HÀM--------------------
        private void Loadl()
        {
            DgvLoainv.DataSource = bus_loainv.getAllData();
            DgvLoainv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvLoainv.Columns[0].HeaderText = "Mã phân loại";
            DgvLoainv.Columns[0].Width = 170;
            DgvLoainv.Columns[1].HeaderText = "Tên phân loại";
            DgvLoainv.Columns[1].Width = 180;
            DgvLoainv.Columns[2].HeaderText = "Mô tả";
            DgvLoainv.Columns[2].Width = 600;
        }

       
        private void Nut(Boolean a)
        {
            btthem.Enabled = a;
            btsua.Enabled = a;
            btxoa.Enabled = a;
            DgvLoainv.Enabled = a;
            tbMaphanloai.Enabled = a;

            bthuy.Enabled = !a;
            btluu.Enabled = !a;
        }
        //----------------------------MAIN--------------------
        public UCLoainv()
        {
            InitializeComponent();
        }
        private void UCLoainv_Load(object sender, EventArgs e)
        {
            Loadl();
            btdanhsach.Enabled = false;
            btluu.Enabled = false;
            bthuy.Enabled = false;
        }

       
        private void sualoainv_Click(object sender, EventArgs e)
        {
            QuarterModel loainv = new QuarterModel();
            if (bus_loainv.edit(loainv))
            {
                MessageBox.Show("Sửa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                Loadl();
            }
            else
                MessageBox.Show("Sửa bản ghi thất bại", "Thông báo", MessageBoxButtons.OK);
               
        }
        private void DgvLoainv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataTable a;
            try
            {
                a = bus_loainv.getAllData();
                tbMaphanloai.Text = a.Rows[i]["Maloainv"].ToString();
                tbTenphanloai.Text = a.Rows[i]["Tenloai"].ToString();
                tbmota.Text = a.Rows[i]["Mota"].ToString();
            }
            catch
            {
                tbMaphanloai.Text = "";
                tbTenphanloai.Text = "";
                tbmota.Text = "";
            }
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            btdanhsach.Enabled = true;
            QuarterModel quarterModel = new QuarterModel(tkloainv.Text, tktenloainv.Text,"");
            DgvLoainv.DataSource = bus_loainv.getAllData();
        }

        private void themloainv_Click_1(object sender, EventArgs e)
        {
            //tbMaphanloai.Text = bus_loainv.SinhMaLoainv();
            //tbTenphanloai.Text = "";
            //tbmota.Text = "";
            //Nut(false);
            //them = true;
        }

        private void btdanhsach_Click(object sender, EventArgs e)
        {
            btdanhsach.Enabled = false;
            tkloainv.Text = "";
            tktenloainv.Text = "";
            Loadl();
        }

        private void sualoainv_Click_1(object sender, EventArgs e)
        {
            if (tbMaphanloai.Text == "")
            {
                MessageBox.Show("Bạn phải điền vào mã bộ phận cần sửa!", "Thông báo");
            }
            else
            {
                QuarterModel quarterModel = new QuarterModel(tbMaphanloai.Text, tbTenphanloai.Text, tbmota.Text);
                DataTable ds = new DataTable();
                ds = bus_loainv.getAllData();
                if (ds.Rows.Count == 1)
                {
                    Nut(false);
                    tbTenphanloai.Text = ds.Rows[0][1].ToString();
                    tbmota.Text = ds.Rows[0][2].ToString();
                }
                else
                {
                    MessageBox.Show("Mã bộ phận điền vào hiện không tồn tại!", "Thông báo");
                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            Nut(true);
            tbMaphanloai.Text = "";
            tbmota.Text = "";
            tbTenphanloai.Text = "";
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (tbMaphanloai.Text == "")
            {
                MessageBox.Show("Bạn phải điền vào mã bộ phận cần xóa!", "Thiếu thông tin");
            }
            else
            {
                QuarterModel loainv = new QuarterModel(tbMaphanloai.Text, tbTenphanloai.Text, tbmota.Text);
                DataTable ds = new DataTable();
                //ds = bus_loainv.SoSanh(loainv);
                //if (ds.Rows.Count > 0)
                //{
                //    if (bus_loainv.delete(loainv))
                //    {
                //        MessageBox.Show("Xóa bản ghi thành công", "Thông báo", MessageBoxButtons.OK);
                //        Loadl();
                //    }
                //    else
                //        MessageBox.Show("Xóa bản ghi thất bại", "Thông báo", MessageBoxButtons.OK);
                //}
                //else
                //{
                //    MessageBox.Show("Mã bộ phận bạn điền vào không tồn tại!", "Xóa thất bại");
                //}
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            
            if (them == true)
            {
                //Thêm nhân viên
                if (tbTenphanloai.Text == "")
                {
                    MessageBox.Show("Bạn phải điền vào tên bộ phận!", "Thông báo");
                    tbTenphanloai.Focus();
                }
                else
                {
                    if (tbmota.Text == "")
                    {
                        MessageBox.Show("Hãy điền vào mô tả cho bộ phận này!", "Thông báo");
                    }
                    else
                    {
                        tbTenphanloai.Text = buschuanhoa.Ten(tbTenphanloai.Text);
                        tbmota.Text = buschuanhoa.DoanVan(tbmota.Text);
                        QuarterModel loainv = new QuarterModel(tbMaphanloai.Text, tbTenphanloai.Text, tbmota.Text);
                        Boolean a = bus_loainv.add(loainv);
                        if (a == true)
                        {
                            MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK);
                            tbMaphanloai.Text = "";
                            tbmota.Text = "";
                            tbTenphanloai.Text = "";
                            Loadl();
                        }
                        else
                            MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK);
                        Nut(true);
                    }
                }
            }
            else //sửa thông tin bộ phận
            {
                if (tbTenphanloai.Text == "")
                {
                    MessageBox.Show("Bạn phải điền vào tên bộ phận!", "Thông báo");
                    tbTenphanloai.Focus();
                }
                else
                {
                    if (tbmota.Text == "")
                    {
                        MessageBox.Show("Hãy điền vào mô tả cho bộ phận này!", "Thông báo");
                    }
                    else
                    {
                        tbTenphanloai.Text = buschuanhoa.Ten(tbTenphanloai.Text);
                        tbmota.Text = buschuanhoa.DoanVan(tbmota.Text);
                        QuarterModel loainv = new QuarterModel(tbMaphanloai.Text, tbTenphanloai.Text, tbmota.Text);
                        Boolean a = bus_loainv.edit(loainv);
                        if (a == true)
                        {
                            MessageBox.Show("Sửa thông tin bộ phận thành công", "Thông báo", MessageBoxButtons.OK);
                            Loadl();
                            tbMaphanloai.Text = "";
                            tbmota.Text = "";
                            tbTenphanloai.Text = "";
                        }
                        else
                            MessageBox.Show("Sửa thông tin bộ phận thất bại", "Thông báo", MessageBoxButtons.OK);
                        Nut(true);
                    }
                }
            }
        }

    }
}
