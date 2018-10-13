using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DTO;

namespace DAL
{
    public class DAL_Employee : DBConnect
    {
        private Dictionary<string, EmployeeModel> employDict;
        private EmployeeModel employModel;
        public const bool MALE = true;
        public const bool FEMALE = true;

        public DataTable getAllEmploy()
        {
            try
            {
                string sqlString = "SELECT * FROM [LongPhuong].[dbo].[tblEmployee]";
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

        public DataTable getEmployDataWithSqlCmd(string sql)
        {
            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
                return dataTable;
            }
            catch
            {
                return null;
            }
        }

        public DataTable getEmployWithAccount(string account)
        {
            try
            {
                string sqlString = "select * from tblEmployee where Employ_Account = '" + account + "'";
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

        public DataTable getEmployWithId(string emPloyId)
        {
            try
            {
                string sqlString = "select * from tblEmployee where Employ_Id = '" + emPloyId + "'";
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

        public DataTable getEmployWithQuarter(string quarterId)
        {
            try
            {
                string sqlString = "select * from tblEmployee where Quarter_Id = '" + quarterId + "'";
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

        public DataTable getDataToLogin(string account, string password)
        {
            try
            {
                string sqlString = "select * from tblEmployee where Employ_Account = '" + account + "' and Employ_Password='" + password + "'";
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

        public Boolean add(EmployeeModel emPloy)
        {
            try
            {
                string sqlString = "Insert into  tblEmployee Values('" + emPloy.emPloyId + "','"
                                                    + emPloy.emPloyName + "','"
                                                    + emPloy.emPloyAccount + "','"
                                                    + emPloy.quarterId + "','"
                                                    + emPloy.emPloyDOB + "','"
                                                    + emPloy.emPloySex + "','"
                                                    + emPloy.emPloyNumberPhone + "','"
                                                    + emPloy.emPloyAddress + "','"
                                                    + emPloy.emPloySalary + "','"
                                                    + emPloy.emPloyPassword + "',@image)";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlString, sqlConnection);
                sqlCommand.Parameters.Add("@image", SqlDbType.Image);
                sqlCommand.Parameters["@image"].Direction = ParameterDirection.Input;
                sqlCommand.Parameters["@image"].Value = emPloy.emPloyImage;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean updateWithId(EmployeeModel employ)
        {
            try
            {
                string sqlString = "Update tblEmployee set Employ_Name = '" + employ.emPloyName +
                                                    "',Quarter_Id = '" + employ.quarterId +
                                                    "',Employ_DOB = '" + employ.emPloyDOB +
                                                    "',Employ_Sex = '" + employ.emPloySex +
                                                    "',Employ_NumberPhone = '" + employ.emPloyNumberPhone +
                                                    "',Employ_Address = '" + employ.emPloyAddress +
                                                    "',Employ_Salary='" + employ.emPloySalary +
                                                    "',Employ_Password='" + employ.emPloyPassword +
                                                    "' where Employ_Id='" + employ.emPloyId + "'";
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

        public Boolean updateWithAccount(EmployeeModel employ)
        {
            try
            {
                string sqlString = "Update tblEmployee set Employ_Name = '" + employ.emPloyName +
                                                    "',Quarter_Id = '" + employ.quarterId +
                                                    "',Employ_DOB = '" + employ.emPloyDOB +
                                                    "',Employ_Sex = '" + employ.emPloySex +
                                                    "',Employ_NumberPhone = '" + employ.emPloyNumberPhone +
                                                    "',Employ_Address = '" + employ.emPloyAddress +
                                                    "',Employ_Salary='" + employ.emPloySalary +
                                                    "',Employ_Password='" + employ.emPloyPassword +
                                                    "' where Employ_Id='" + employ.emPloyAccount + "'";
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

        public Boolean deleteWithId(string employId)
        {
            try
            {
                string sqlString = "Delete tblEmployee  where Employ_Id='" + employId + "'";
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

        public Boolean deleteWithAccount(string account)
        {
            try
            {
                string sqlString = "Delete tblEmployee where Employ_Account='" + account + "'";
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

        public Boolean delete(List<EmployeeModel> employList)
        {
            try
            {
                foreach (EmployeeModel employItem in employList)
                {
                    string sqlString = "Delete tblEmployee where Employ_Account='" + employItem.emPloyAccount + "'";
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

        public string SinhManv()
        {
            /*
            int i, n, m = 0;
            string a, b;
            string sql = "select Manv from Nhanvien";
            DataTable dt = new DataTable();
            dt = this.DanhsachNhanvien(sql);
            if (dt.Rows.Count == 1)
                m = 1;
            else
            {
                for (i = 0; i <= dt.Rows.Count - 2; i++)
                {
                    a = dt.Rows[i]["Manv"].ToString();
                    a = a.Substring(2, 3);
                    n = Int32.Parse(a);

                    b = dt.Rows[i + 1]["Manv"].ToString();
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
                return "NV00" + Convert.ToString(m);
            else
                if(m<100)
                    return "NV0" + Convert.ToString(m);
                else
                    return "NV" + Convert.ToString(m);
        }*/
            return "";
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
           using (var ms = new System.IO.MemoryStream())
           {
              imageIn.Save(ms,imageIn.RawFormat);
              return  ms.ToArray();
           }
        }

        public Dictionary<string, EmployeeModel> convertDatatable2Dict(DataTable dataTable)
        {
            employDict = new Dictionary<string, EmployeeModel>();
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    //Init employ data
                    employModel = new EmployeeModel();
                    employModel.emPloyId = dataTable.Rows[i]["Employ_Id"].ToString();
                    employModel.emPloyAccount = dataTable.Rows[i]["Employ_Account"].ToString();
                    employModel.emPloyName = dataTable.Rows[i]["Employ_Name"].ToString();
                    employModel.emPloyDOB = Convert.ToDateTime(dataTable.Rows[i]["Employ_DOB"].ToString());
                    employModel.emPloyNumberPhone = dataTable.Rows[i]["Employ_NumberPhone"].ToString();
                    employModel.emPloyAddress = dataTable.Rows[i]["Employ_Address"].ToString();
                    employModel.emPloySalary = float.Parse(dataTable.Rows[i]["Employ_Salary"].ToString());

                    if (!dataTable.Rows[i]["Employ_Image"].ToString().Equals(""))
                    {
                        employModel.emPloyImage = ImageToByteArray((Image)dataTable.Rows[i]["Employ_Image"]);
                    }

                    employModel.emPloyPassword = dataTable.Rows[i]["Employ_Password"].ToString();
                    employModel.quarterId = dataTable.Rows[i]["Quarter_Id"].ToString();
                    employModel.emPloySex = getEmploySex(dataTable.Rows[i]["Employ_Sex"].ToString());
                    //Add employ object to dictionary
                    employDict.Add(employModel.emPloyId, employModel);
                }
            }
            return employDict;
        }

        public bool getEmploySex(string employSex)
        {
            if (employSex.Equals("1"))
            {
                return MALE;
            }
            return FEMALE;
        }
    }
 }
