using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
namespace BUS
{
    public  class BUS_Products
    {
        DAL_Products dalProduct = new DAL_Products();
        public DataTable getAllData()
        {
            return dalProduct.getAllData();
        }
        
        public DataTable getDataWithId(string productId)
        {
            return dalProduct.getDataWithId(productId);
        }

        public DataTable getDataWithProductType(string productType)
        {
            return dalProduct.getDataWithType(productType);
        }

        public DataTable getDataWithProductName(string productName)
        {
            return dalProduct.getDataWithName(productName);
        }

        public Boolean add(ProductsModel product)
        {
            return dalProduct.add(product);
        }

        public Boolean edit(ProductsModel product)
        {
            return dalProduct.edit(product);
        }

        public Boolean delete(string productId)
        {
            return dalProduct.delete(productId);
        }

        public Boolean delete(List<ProductsModel> productList)
        {
            return dalProduct.delete(productList);
        }

        public Dictionary<string, ProductsModel> convertDatatable2Dict()
        {
            return dalProduct.convertDatatable2Dict(getAllData());
        }

        public Dictionary<string, ProductsModel> convertDatatableWithproductType2Dict(string productId)
        {
            return dalProduct.convertDatatable2Dict(getDataWithProductType(productId));
        }

        public int getTotalProduct()
        {
            return getAllData().Rows.Count;
        }
    }
}
