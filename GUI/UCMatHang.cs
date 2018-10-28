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

        BUS_Products busProduct = new BUS_Products();
        BUS_ProductType busProductType = new BUS_ProductType();
        BUS_Chuanhoaxau buschuanhoaxau = new BUS_Chuanhoaxau();
        List<string> productTypeNameList = new List<string>();

        private void UCBanh_Load(object sender, EventArgs e)
        {
            this.setDataForProductId("All");
            this.setDataForProductName("All");
            this.setData2ProductTypeText();
            this.loadData2DatagridView();
            this.setData2ProductTypeCombobox(productTypeNameList);
            searchProductId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchProductId.AutoCompleteSource = AutoCompleteSource.CustomSource;

            searchProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            productSummaryLabel.Text = busProduct.getTotalProduct().ToString();
        }

        private void loadData2DatagridView()
        {
            dgvProduct.Rows.Clear();
            dgvProduct.Refresh();
            productTypeNameList.Clear();
            if (busProduct.convertDatatable2Dict().Count > 0)
            {
                this.statusLabel.Visible = false;

                foreach (KeyValuePair<string, ProductsModel> product in busProduct.convertDatatable2Dict())
                {
                    ProductTypeModel productType = busProductType.convertDatatable2Dict()[product.Value.productTypeId];
                    dgvProduct.Rows.Add(product.Key, product.Value.productName, productType.productTypeName);
                    productTypeNameList.Add(productType.productTypeName);
                }
                setDataDetail(0);
            }
            else
            {
                this.statusLabel.Visible = true;
                setDataDetailNull();
            }
        }

        private void setData2ProductTypeCombobox(List<string> productTypeNameList)
        {
            for (int i = 0; i < productTypeNameList.Count; i++)
                this.productTypeCombobox.Items.Add(productTypeNameList.ElementAt(i));
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.setDataDetail(dgvProduct.CurrentCell.RowIndex);
        }

        private void setDataDetail(int index)
        {
            ProductsModel productModel          = busProduct.convertDatatable2Dict().ElementAt(index).Value;
            ProductTypeModel productType        = busProductType.convertDatatable2Dict()[productModel.productTypeId];
            this.productIdText.Text             = productModel.productId.Trim();
            this.productNameText.Text           = productModel.productName.Trim();
            this.productNoticeText.Text         = productModel.productNotice.Trim();
            this.productPurcharsePriceText.Text = productModel.productPurchasePrice.ToString().Trim();
            this.productRetailPriceText.Text    = productModel.productRetailPrice.ToString().Trim();
            this.productUnit.Text               = productModel.productUnit.ToString().Trim();
            this.productWholePriceText.Text     = productModel.productWholePrice.ToString().Trim();
            this.productAmount.Text             = productModel.productAmount.ToString().Trim();
            this.setDataProductTypeCombobox(productType.productTypeName);
        }

        private void setDataDetailWithProductTypeId(string productTypeId, int index)
        {
            ProductsModel productModel = busProduct.convertDatatableWithproductType2Dict(productTypeId).ElementAt(index).Value;
            ProductTypeModel productType = busProductType.convertDatatable2Dict()[productModel.productTypeId];
            this.productIdText.Text = productModel.productId.Trim();
            this.productNameText.Text = productModel.productName.Trim();
            this.productNoticeText.Text = productModel.productNotice.Trim();
            this.productPurcharsePriceText.Text = productModel.productPurchasePrice.ToString().Trim();
            this.productRetailPriceText.Text = productModel.productRetailPrice.ToString().Trim();
            this.productUnit.Text = productModel.productUnit.ToString().Trim();
            this.productWholePriceText.Text = productModel.productWholePrice.ToString().Trim();
            this.productAmount.Text = productModel.productAmount.ToString().Trim();
            this.setDataProductTypeCombobox(productType.productTypeName);
        }

        private void setDataProductTypeCombobox(string productType)
        {
            this.productTypeCombobox.Text = productType;
            this.productTypeCombobox.Enabled = false;
        }

        private void setDataDetailNull()
        {
            this.productIdText.Text             = "";
            this.productNameText.Text           = "";
            this.productNoticeText.Text         = "";
            this.productPurcharsePriceText.Text = "";
            this.productRetailPriceText.Text    = "";
            this.productUnit.Text               = "";
            this.productWholePriceText.Text     = "";
            this.productAmount.Text             = "";
        }

        private void setDataForProductId(string productType)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            if (productType.Equals("All"))
            {
                foreach (KeyValuePair<string, ProductsModel> product in busProduct.convertDatatable2Dict())
                {
                    string productId = product.Key.Trim();
                    data.Add(productId);
                }
            }
            else if (busProduct.convertDatatableWithproductType2Dict(productType).Count > 0)
            {
                foreach (KeyValuePair<string, ProductsModel> product in busProduct.convertDatatableWithproductType2Dict(productType))
                {
                    string employId = product.Key.Trim();
                    data.Add(employId);
                }
            }
            searchProductId.AutoCompleteCustomSource = data;
        }

        private void setDataForProductName(string productType)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            if (productType.Equals("All"))
            {
                foreach (KeyValuePair<string, ProductsModel> product in busProduct.convertDatatable2Dict())
                {
                    string productName = product.Value.productName.Trim();
                    data.Add(productName);
                }
            }
            else if (busProduct.convertDatatableWithproductType2Dict(productType).Count > 0)
            {
                foreach (KeyValuePair<string, ProductsModel> product in busProduct.convertDatatableWithproductType2Dict(productType))
                {
                    string employName = product.Value.productName.Trim();
                    data.Add(employName);
                }
            }
            searchProductName.AutoCompleteCustomSource = data;
        }

        public void setData2ProductTypeText()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            if (busProductType.convertDatatable2Dict().Count > 0)
            {
                this.searchProductType.Items.Add("All");
                data.Add("All");
                foreach (KeyValuePair<string, ProductTypeModel> productType in busProductType.convertDatatable2Dict())
                {
                    string quarterName = productType.Value.productTypeName.Trim();
                    this.searchProductType.Items.Add(quarterName);
                    this.searchProductType.SelectedIndex = 0;
                    data.Add(quarterName);
                }
                searchProductType.AutoCompleteCustomSource = data;
            }
        }

        private void searchProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchProductType.SelectedIndex > 0)
            {
                ProductTypeModel productType = busProductType.convertDatatable2Dict().ElementAt(searchProductType.SelectedIndex - 1).Value;
                setDataForProductName(productType.productTypeId);
                setDataForProductId(productType.productTypeId);
                loadDataWithProductType2DatagridView(productType.productTypeId);
            }
            else
            {
                loadData2DatagridView();
            }
            this.searchProductName.Text = "";
            this.searchProductId.Text = "";
        }

        private void loadDataWithProductType2DatagridView(string productTypeId)
        {
            dgvProduct.Rows.Clear();
            dgvProduct.Refresh();
            productTypeNameList.Clear();
            if (busProduct.convertDatatableWithproductType2Dict(productTypeId).Count > 0)
            {
                this.statusLabel.Visible = false;

                foreach (KeyValuePair<string, ProductsModel> product in busProduct.convertDatatableWithproductType2Dict(productTypeId))
                {
                    ProductTypeModel productType = busProductType.convertDatatable2Dict()[product.Value.productTypeId];
                    dgvProduct.Rows.Add(product.Key, product.Value.productName, productType.productTypeName);
                    productTypeNameList.Add(productType.productTypeName);
                }
                setDataDetailWithProductTypeId(productTypeId, 0);
            }
            else
            {
                this.statusLabel.Visible = true;
                setDataDetailNull();
            }
        }
    }
}
