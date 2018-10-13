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
    public class DAL_Quarter : DBConnect 
    {
        private Dictionary<string, QuarterModel> quarterDict;
        QuarterModel quarterModel;

        public DataTable getAllData()
        {
            try
            {
                string sqlString = "Select * from tblQuarter";
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

        public DataTable getDataWithQuarterId(string quarterId)
        {
            try
            {
                string sqlString = "Select * from tblQuarter where Quarter_Id = '" + quarterId + "'";
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

        public DataTable getDataWithQuarterName(string quarterName)
        {
            try
            {
                string sqlString = "Select * from tblQuarter where Contributor_Id = '" + quarterName + "'";
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

        public Boolean add(QuarterModel quarterItem)
        {
            try
            {
                string sqlString = "Insert into tblQuarter Values('" + quarterItem.quarterId + "','" 
                                                               + quarterItem.quarterName + "','" 
                                                               + quarterItem.quarterAgency + "')";
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

        public Boolean edit(QuarterModel quarterItem)
        {
            try
            {
                string sqlString = "update tblQuarter set Quarter_Name ='" + quarterItem.quarterName
                                                + "',Quarter_Agency =N'" + quarterItem.quarterAgency 
                                                + "' where Quarter_Id ='" + quarterItem.quarterId + "'";
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

        public Boolean delete(QuarterModel quarterItem)
        {
            try
            {
                string sqlString = "delete tblQuarter  where Quarter_Id='" + quarterItem.quarterId + "'";
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

        public Dictionary<string, QuarterModel> convertDatatable2Dict(DataTable dataTable)
        {
            quarterDict = new Dictionary<string, QuarterModel>();
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    //Init quarter data
                    quarterModel = new QuarterModel();
                    quarterModel.quarterId = dataTable.Rows[i]["Quarter_Id"].ToString();
                    quarterModel.quarterName = dataTable.Rows[i]["Quarter_Name"].ToString();
                    quarterModel.quarterAgency = dataTable.Rows[i]["Quarter_Agency"].ToString();
                    //Add quarter object to dictionary
                    quarterDict.Add(quarterModel.quarterId, quarterModel);
                }
            }
            return quarterDict;
        }
    }
}
