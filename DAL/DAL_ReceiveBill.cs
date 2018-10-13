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
    public class DAL_ReceiveBill : DBConnect
    {
        public DataTable getAllData()
        {
            try
            {
                string sqlString = "Select * from tblReceiveBill";
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
                string sqlString = "Select * from tblReceiveBill where ReceiveBill_Id = '"+ billId +"'";
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
                string sqlString = "Select * from tblReceiveBill where Contributor_Id = '" + contributorName + "'";
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
                string sqlString = "Select * from tblReceiveBill where ReceiveBill_Date Between '" + startDate + "' And '" + endDate +"'";
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

        public DataTable getFilterData(DateTime startDate, DateTime endDate, string contributorName)
        {
            try
            {
                string sqlString = "Select * from tblReceiveBill where ReceiveBill_Date Between '" + startDate + "' And '" + endDate 
                                                                    + "' AND Contributor_Id = '" + contributorName + "'";
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

        public DataTable getFilterData(DateTime startDate, DateTime endDate, string contributorName, string billId)
        {
            try
            {
                string sqlString = "Select * from tblReceiveBill where ReceiveBill_Date Between '" + startDate + "' And '" + endDate
                                                                    + "' AND Contributor_Id = '" + contributorName
                                                                    + "' AND ReceiveBill_Id = " + billId + "'";
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

        public Boolean add(ReceiveBillModel billItem)
        {
            try
            {
                if (billItem == null)
                {
                    billItem = new ReceiveBillModel();
                }
                string sqlString = "Insert into tblReceiveBill Values('" + billItem.billId + "','"
                    + billItem.productId + "','"
                    + billItem.date + "','"
                    + billItem.contributorId + "','"
                    + billItem.employId + "','"
                    + billItem.billAmount + "','"
                    + billItem.billPrice + "','"
                    + billItem.billStatus + "','"
                    + billItem.billNotice + "','"
                    + billItem.billUnit + "')";

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

        public Boolean edit(ReceiveBillModel billItem)
        {
            if (billItem == null)
            {
                billItem = new ReceiveBillModel();
            }
            try
            {
                string sqlString = "Update tblReceiveBill Set Product_Id = '" + billItem.productId
                                                + "', ReceiveBill_Date = '" + billItem.date
                                                + "', ReceiveBill_Date = '" + billItem.contributorId
                                                + "', Employ_Id = '" + billItem.employId
                                                + "', ReceiveBill_Amount = '" + billItem.billAmount
                                                + "', ReceiveBill_Price = '" + billItem.billPrice
                                                + "', ReceiveBill_Status = '" + billItem.billStatus
                                                + "', ReceiveBill_Notice = '" + billItem.billNotice
                                                + "', ReceiveBill_Unit = '" + billItem.billUnit 
                                                + "', ReceiveBill_Unit = '" + billItem.billUnit
                                                + "' Where ReceiveBill_Id = '" + billItem.billId + "')";
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

        public Boolean delete(ReceiveBillModel billItem)
        {
            if (billItem == null)
            {
                billItem = new ReceiveBillModel();
            }
            try
            {
                string sqlString = "Delete tblReceiveBill  where ReceiveBill_Id='" + billItem.billId + "'";
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

        public Boolean delete(List<ReceiveBillModel> billList)
        {
            try
            {
                foreach (ReceiveBillModel receiveBillItem in billList)
                {
                    if (receiveBillItem != null)
                    {
                        string sqlString = "Delete tblReceiveBill  where ReceiveBill_Id='" + receiveBillItem.billId + "'";
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
