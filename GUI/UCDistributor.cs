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
    public partial class UCDistributor : UserControl
    {
        public UCDistributor()
        {
            InitializeComponent();
        }
        //-------------------------------------BIẾN--------------------------------------
        BUS_Distributor busDistributor = new BUS_Distributor();
        Boolean them;
        BUS_Chuanhoaxau buschx = new BUS_Chuanhoaxau();
        //-------------------------------------HÀM---------------------------------------
        private void LoadData()
        {
            //dgloainl.DataSource = busloainl.Danhsach();
            //dgloainl.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgloainl.Columns["Maloainl"].HeaderText = "Mã loại nguyên liệu";
            //dgloainl.Columns["Maloainl"].Width = 150;
            //dgloainl.Columns["Tenloai"].HeaderText = "Tên loại nguyên liệu";
            //dgloainl.Columns["Mota"].HeaderText = "Mô tả";
        }

        private void Nut(Boolean a)
        {

            btthem.Enabled = a;
            btsua.Enabled = a;
            btxoa.Enabled = a;
            //dgloainl.Enabled = a;
            //tbmaloainl.Enabled = a;

            bthuy.Enabled = !a;
            btluu.Enabled = !a;
        }
        private void TextBNull()
        {
            //tbmaloainl.Text = "";
            //tbmota.Text = "";
            //tbtenloainl.Text = "";
        }
        private Boolean Kiemtrathem()
        {/*
            if (tbtenloainl.Text == "")
            {
                MessageBox.Show("Điền vào tên loại nguyên liệu!", "Thông báo");
                tbtenloainl.Focus();
                return false;
            }
            else
                if (tbmota.Text == "")
                {
                    MessageBox.Show("Điền vào mô tả cho loại nguyên liệu này!", "Thông báo");
                    tbmota.Focus();
                    return false;
                }
                else
                {
                    tbtenloainl.Text = buschx.Ten(tbtenloainl.Text);
                    tbmota.Text = buschx.DoanVan(tbmota.Text);
                    return true;
                }*/
            return true;
        }
        //-------------------------------------------MAIN------------------------------------------
        private void UCLoainguyenlieu_Load(object sender, EventArgs e)
        {
            LoadData();
            Nut(true);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            Nut(false);
            them = true;
            TextBNull();
            //tbmaloainl.Text = busloainl.SinhMaLoainl();
        }
        
        private void btsua_Click(object sender, EventArgs e)
        {/*
            if (tbmaloainl.Text == "")
            {
                MessageBox.Show("Điền vào mã loại nguyên liệu cần sửa!", "Thông báo");
                tbmaloainl.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = busloainl.KiemTraSua(tbmaloainl.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã loại nguyên liệu không tồn tại!", "Thông báo");
                    tbmaloainl.Focus();
                }
                else
                {
                    tbmaloainl.Text = dt.Rows[0]["Maloainl"].ToString();
                    tbtenloainl.Text = dt.Rows[0]["Tenloai"].ToString();
                    tbmota.Text = dt.Rows[0]["Mota"].ToString();
                    them = false;
                    Nut(false);
                }
                
            }*/
        }

        private void btluu_Click(object sender, EventArgs e)
        {/*
            if (them == true)
            {
                if (Kiemtrathem())
                {
                    Loainguyenlieu lnl = new Loainguyenlieu(tbmaloainl.Text, tbtenloainl.Text, tbmota.Text);
                    if (busloainl.Them(lnl) == false)
                        MessageBox.Show("Thêm loại nguyên liệu thất bại!", "Thông báo");
                    else
                    {
                        MessageBox.Show("Thêm loại nguyên liệu thành công!", "Thông báo");
                        Nut(true);
                        LoadData();
                        TextBNull();
                    }
                }
            }
            else
                if (Kiemtrathem())
                {
                    Loainguyenlieu lnl = new Loainguyenlieu(tbmaloainl.Text, tbtenloainl.Text, tbmota.Text);
                    if (busloainl.Sua(lnl) == false)
                        MessageBox.Show("Sửa loại nguyên liệu thất bại!", "Thông báo");
                    else
                    {
                        MessageBox.Show("Sửa loại nguyên liệu thành công!", "Thông báo");
                        Nut(true);
                        LoadData();
                        TextBNull();
                    }
                }*/
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            Nut(true);
            TextBNull();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {/*
            if (tbmaloainl.Text == "")
            {
                MessageBox.Show("Điền vào mã loại nguyên liệu cần xóa!", "Thông báo");
                tbmaloainl.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                dt = busloainl.KiemTraSua(tbmaloainl.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã loại nguyên liệu không tồn tại!", "Thông báo");
                    tbmaloainl.Focus();
                }
                else
                    if(DialogResult.OK==MessageBox.Show("Bạn có muốn xóa loại nguyên liệu có mã "+tbmaloainl.Text+" không","Thông báo",MessageBoxButtons.OKCancel))
                        if (busloainl.Xoa(tbmaloainl.Text) == false)
                            MessageBox.Show("Xóa loại nguyên liệu thất bại!", "Thông báo");
                        else
                        {
                            MessageBox.Show("Xóa loại nguyên liệu thành công!", "Thông báo");
                            TextBNull();
                            LoadData();
                        }

            }
            */
        }

        private void dgloainl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataTable dt;

            dt = busDistributor.getAllData();
            try
            {
                //tbmaloainl.Text = dt.Rows[i]["Maloainl"].ToString();
                //tbmota.Text = dt.Rows[i]["Mota"].ToString();
                //tbtenloainl.Text = dt.Rows[i]["Tenloai"].ToString();
            }
            catch
            {
                TextBNull();
            }
        }

        
    }
}
