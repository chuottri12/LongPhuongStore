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
    public class DAL_Distributor : DBConnect
    {
        public DataTable getAllData()
        {
            try
            {
                string sqlString = "Select * from tblDistributor";
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

        public DataTable getDataWithId(string distributorId)
        {
            try
            {
                string sqlString = "Select * from tblDistributor where Distributor_Id = '" + distributorId + "'";
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

        public Boolean add(DistributorModel distributorModel)
        {
            try
            {
                string sqlString = "Insert into tblDistributor Values('" + distributorModel.distributorId + "','"
                                                                         + distributorModel.distributorName + "','"
                                                                         + distributorModel.distributorNumberPhone + "','"
                                                                         + distributorModel.distributorManager + "','"
                                                                         + distributorModel.distributorEmail + "','"
                                                                         + distributorModel.distributorAddress + "','"
                                                                         + distributorModel.distributorNotice + "')";
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(sqlString, sqlConnection);
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean edit(DistributorModel distributorModel)
        {
            try
            {
                string sqlString = "update tblDistributor set Distributor_Name = '" + distributorModel.distributorName +
                                                    "',Distributor_NumberPhone = '" + distributorModel.distributorNumberPhone +
                                                    "',Distributor_Manager = '" + distributorModel.distributorManager +
                                                    "',Distributor_Email = '" + distributorModel.distributorEmail +
                                                    "',Distributor_Address = '" + distributorModel.distributorAddress +
                                                    "',Distributor_Amount_Of_Debt = '" + distributorModel.distributorNotice +
                                                    "' where Distributor_Id ='" + distributorModel.distributorId + "'";
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

        public Boolean delete(string distributorId)
        {
            try
            {
                string sqlString = "delete tblDistributor  where Distributor_Id='" + distributorId + "'";
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

        public Boolean delete(List<DistributorModel> distributorList)
        {
            try
            {
                sqlConnection.Open();
                foreach (DistributorModel distributorItem in distributorList)
                {
                    string sqlString = "delete tblDistributor  where Distributor_Id='" + distributorItem.distributorId + "'";
                    SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                }
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
