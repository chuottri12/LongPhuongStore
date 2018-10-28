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
        BUS_ProductType busProductType = new BUS_ProductType();
        BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
        //Boolean them;
        //--------------------------------------HÀM-----------------------------------------

        private void UCLoaibanh_Load(object sender, EventArgs e)
        {
            loadDataToTable();
        }

        private void loadDataToTable()
        {
            dgvProductType.Rows.Clear();
            dgvProductType.Refresh();
            if (busProductType.convertDatatable2Dict().Count > 0)
            {
                foreach (KeyValuePair<string, ProductTypeModel> productType in busProductType.convertDatatable2Dict())
                {
                    dgvProductType.Rows.Add(productType.Key, productType.Value.productTypeName, productType.Value.productNotice);
                }
            }
            else
            {
           
            }
        }
        private void Nut(Boolean a)
        {
            addButton.Enabled = a;
            editButton.Enabled = a;
            deleteButton.Enabled = a;
            dgvProductType.Enabled = a;
            //tbmaloaibanh.Enabled = a;
            
            cancelButton.Enabled = !a;
            saveButton.Enabled = !a;
        }
        private void TextBNull()
        {

        }
        private Boolean KiemTraThem()
        {
            //if (tbtenloaibanh.Text == "")
            //{
            //    MessageBox.Show("Điền vào tên loại bánh!", "Thông báo");
            //    tbtenloaibanh.Focus();
            //    return false;
            //}
            //else
            //{
            //    tbtenloaibanh.Text = buschuanhoaxau.Ten(tbtenloaibanh.Text);
            //    if (tbmota.Text == "")
            //    {
            //        MessageBox.Show("Hãy điền mô tả cho loại bánh!", "Thông báo");
            //        tbmota.Focus();
            //        return false;
            //    }
            //    else
            //    {
            //        tbmota.Text = buschuanhoaxau.DoanVan(tbmota.Text);
            //        return true;
            //    }
            //}
            return false;
        }
        //--------------------------------------MAIN----------------------------------------

        private void btthem_Click(object sender, EventArgs e)
        {

        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            //if (them == true)
            //{

            //}
            //else 
            //{ 
                
            //}
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            
        }

        private void dgloaibanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btdanhsach_Click(object sender, EventArgs e)
        {
           
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
