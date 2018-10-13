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
    public class DAL_Customer: DBConnect
    {
        public DataTable getAllCustomer()
        {
            try
            {
                string sqlstring = "Select * from tblCustomer";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlstring, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getCustomerWithId(string customerId)
        {
            try
            {
                string sqlstring = "Select * from tblCustomer Where Customer_Id = '" + customerId  + "'";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlstring, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public Boolean add(CustomerModel customer)
        {
            try
            {
                string sqlString = "Insert into tblCustomer Values('" + customer.customerId + "','" 
                                                                + customer.customerName + "','"
                                                                + customer.customerDOB + "','" 
                                                                + customer.customerSex + "','"
                                                                + customer.customerAmountOfDebt + "','" 
                                                                + customer.customerNumberPhone + "','" 
                                                                + customer.customerEmail + "','"
                                                                + customer.customerAddress + "',@image)";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                sqlCommand.Parameters.Add("@image", SqlDbType.Image);
                sqlCommand.Parameters["@image"].Direction = ParameterDirection.Input;
                sqlCommand.Parameters["@image"].Value = customer.customerImage;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Boolean update(CustomerModel customer)
        {
            try
            {
                string sqlString = "Update tblCustomer set Customer_Name = '" + customer.customerName + 
                                                        "',Customer_DOB = '" + customer.customerDOB + 
                                                        "',Customer_Sex = '" + customer.customerSex + 
                                                        "',Customer_NumberPhone = '" + customer.customerNumberPhone + 
                                                        "',Customer_Email = '" + customer.customerEmail + 
                                                        "',Customer_Address = '" + customer.customerAddress +
                                                        "',Customer_AmountOfDebt '" + customer.customerAmountOfDebt +
                                                        "' Where Customer_Id='" + customer.customerId + "'";
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

        public Boolean delete(string customerId)
        {
            try
            {
                string sqlString = "Delete tblCustomer  where Customer_Id='" + customerId + "'";
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

        public Boolean delete(List<CustomerModel> customerList)
        {
            try
            {
                foreach (CustomerModel customer in customerList)
                {
                    string sqlString = "Delete tblCustomer  where Customer_Id='" + customer.customerId + "'";
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
        
        public string SinhMakh()
        {
            /*
            int i, n, m = 0;
            string a, b;
            string sql = "select Makh from Khachhang";
            DataTable dt = new DataTable();
            dt = this.getAllCustomer(sql);
            if (dt.Rows.Count == 0)
                m=0;
            else
                if (dt.Rows.Count == 1)
                    m = 1;
            else
            {
                for (i = 0; i <= dt.Rows.Count - 2; i++)
                {
                    a = dt.Rows[i]["makh"].ToString();
                    a = a.Substring(2, 3);
                    n = Int32.Parse(a);

                    b = dt.Rows[i + 1]["makh"].ToString();
                    b = b.Substring(2, 3);
                    m = Int32.Parse(b);

                    if (n + 1 < m)
                    {
                        m = n;
                        break;
                    }
                }
            }
            m = m + 1;
            if (m < 10)
                return "KH00" + Convert.ToString(m);
            else
                if (m < 100)
                    return "KH0" + Convert.ToString(m);
                else
                    return "Kh" + Convert.ToString(m);
             * */
            return "";
        }
    }
}
