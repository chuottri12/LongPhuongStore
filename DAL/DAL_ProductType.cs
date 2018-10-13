using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class DAL_ProductType:DBConnect
    {
        public DataTable getAllData()
        {
            try
            {
                string sqlString = "Select * from tblProductType";
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

        public Boolean add(ProductTypeModel productTypeItem)
        {
            try
            {
                string sqlString = "Insert into tblProductType Values('" + productTypeItem.productTypeId + "','" 
                                                                         + productTypeItem.productTypeName + "','"
                                                                         + productTypeItem.productNotice + "')";
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

        public Boolean edit(ProductTypeModel productTypeItem)
        {
            try
            {
                string sqlString = "Update tblProductType set ProductType_Name = '" + productTypeItem.productTypeName
                                                        + "', ProductType_Notice = '" + productTypeItem.productNotice
                                                        + "' where ProductType_Id='" + productTypeItem.productTypeId + "'";
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

        public Boolean delete(string productTypeId)
        {
            try
            {
                string sqlString = "Delete tblProductType  where ProductType_Id = '" + productTypeId + "'";
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

        public Boolean delete(List<ProductTypeModel> productTypeList)
        {
            try
            {
                foreach (ProductTypeModel productTypeItem in productTypeList)
                {
                    string sqlString = "Delete tblProductType  where ProductType_Id = '" + productTypeItem.productTypeId + "'";
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
