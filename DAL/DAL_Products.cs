using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Products:DBConnect
    {
        public DataTable getAllData()
        {
            try
            {
                string sqlString = "Select * from tblProducts";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlString, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getDataWithId(string productId)
        {
            try
            {
                string sqlString = "Select * from tblProducts where = Product_Id'" + productId + "'";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlString, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getDataWithType(string productType)
        {
            try
            {
                string sqlString = "Select * from tblProducts where = ProductType_Id'" + productType + "'";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlString, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getDataWithName(string productName)
        {
            try
            {
                string sqlString = "Select * from tblProducts where = Product_Name'" + productName + "'";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlString, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public Boolean add(ProductsModel product)
        {
            try
            {
                string sqlString = "Insert into tblProducts Values('" + product.productId + "','" 
                                                                + product.productName + "','"
                                                                + product.productTypeId + "','"
                                                                + product.productPurchasePrice + "','"
                                                                + product.productWholePrice + "','"
                                                                + product.productRetailPrice + "','"
                                                                + product.productUnit + "','"
                                                                + product.productNotice + "','"
                                                                + product.productAmount + "')";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Boolean edit(ProductsModel product)
        {
            try
            {
                string sqlString = "update tblProducts set Product_Name='" + product.productName +
                                                    "',Product_Unit='" + product.productUnit +
                                                    "',Product_Purchase_Price='" + product.productPurchasePrice +
                                                    "',Product_Whole_Price='" + product.productWholePrice +
                                                    "',Product_Retail_Price='" + product.productRetailPrice +
                                                    "',Product_Notice='" + product.productNotice +
                                                    "',ProductType_Id='" + product.productTypeId +
                                                    "',Product_Amount='" + product.productAmount +
                                                    "' where Product_Id='" + product.productId + "'";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Boolean delete(string productId)
        {
            try
            {
                string sqlString = "Delete tblProducts  where Product_Id='" + productId + "'";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Boolean delete(List<ProductsModel> productList)
        {
            try
            {
                foreach (ProductsModel productItem in productList)
                {
                    string sqlString = "Delete tblProducts  where Product_Id='" + productItem.productId + "'";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
