using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DAL_SellBill:DBConnect
    {
        public DataTable getAllData()
        {
            try
            {
                string sqlString = "Select * from tblSellBill";
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

        public DataTable getDataWithBillId(string billId)
        {
            try
            {
                string sqlString = "Select * from tblSellBill where SellBill_Id = '" + billId + "'";
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

        public DataTable getDataWithContributor(string contributorName)
        {
            try
            {
                string sqlString = "Select * from tblSellBill where Customer_Id = '" + contributorName + "'";
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

        public DataTable getDataWithDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                string sqlString = "Select * from tblSellBill where SellBill_Date Between '" + startDate + "' And '" + endDate + "'";
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

        public DataTable getFilterData(DateTime startDate, DateTime endDate, string customerId)
        {
            try
            {
                string sqlString = "Select * from tblSellBill where SellBill_Date Between '" + startDate + "' And '" + endDate
                                                                    + "' AND Customer_Id = '" + customerId + "'";
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

        public DataTable getFilterData(DateTime startDate, DateTime endDate, string customerId, string billId)
        {
            try
            {
                string sqlString = "Select * from tblSellBill where SellBill_Date Between '" + startDate + "' And '" + endDate
                                                                    + "' AND Customer_Id = '" + customerId
                                                                    + "' AND SellBill_Id = " + billId + "'";
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

        public Boolean add (SellBillModel billItem)
        {
            try
            {
                if (billItem == null)
                {
                    billItem = new SellBillModel();
                }
                string sqlString = "Insert into tblSellBill Values('" + billItem.billId + "','" 
                    + billItem.productId + "','" 
                    + billItem.date + "','" 
                    + billItem.customerId + "','" 
                    + billItem.employId + "','"
                    + billItem .billAmount + "','" 
                    + billItem.billPrice +"','"
                    + billItem.billStatus + "','" 
                    + billItem.billNotice + "','"
                    + billItem.billUnit +"')";

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

        public Boolean edit(SellBillModel billItem)
        {
            if (billItem == null)
            {
                billItem = new SellBillModel();
            }
            try
            {
                string sqlString = "Update tblSellBill Set Product_Id = '"+ billItem.productId
                                                + "', SellBill_Date = '" + billItem.date
                                                + "', SellBill_Date = '" + billItem.customerId
                                                + "', Employ_Id = '" + billItem.employId
                                                + "', SellBill_Amount = '" + billItem.billAmount
                                                + "', SellBill_Price = '" + billItem.billPrice
                                                + "', SellBill_Status = '" + billItem.billStatus
                                                + "', SellBill_Notice = '" + billItem.billNotice
                                                + "', SellBill_Unit = '" + billItem.billUnit 
                                                + "' Where SellBill_Id = '" + billItem.billId + "')";
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

        public Boolean delete(string billId)
        {
            try
            {
                string sqlString = "Delete tblSellBill  where SellBill_Id='" + billId + "'";
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

        public Boolean delete(List<SellBillModel> billList)
        {
            try
            {
                foreach (SellBillModel sellBillItem in billList)
                {
                    if (sellBillItem != null)
                    {
                        string sqlString = "Delete tblSellBill  where SellBill_Id='" + sellBillItem.billId + "'";
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    else
                    {
                        return false;
                    }
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
