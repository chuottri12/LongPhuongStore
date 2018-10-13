using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DAL;
using DTO;
namespace BUS
{
    public class BUS_Employ
    {
        DAL_Employee dalEmploy = new DAL_Employee();

        public DataTable login(string username, string password)
        {
            return dalEmploy.getDataToLogin(username, password);
        }

        public DataTable getAllEmployList()
        {
            return dalEmploy.getAllEmploy();
        }

        public DataTable getEmployDataWithSqlCmd(string sqlString)
        {
            return dalEmploy.getEmployDataWithSqlCmd(sqlString);
        }

        public DataTable getEmployWithAccount(string account)
        {
            return dalEmploy.getEmployWithAccount(account);
        }

        public DataTable getEmployWithId(string emPloyId)
        {
            return dalEmploy.getEmployWithAccount(emPloyId);
        }

        public DataTable getEmployWithQuarterId(string quarterId)
        {
            return dalEmploy.getEmployWithQuarter(quarterId);
        }

        public DataTable Doimatkhau(string manv)
        {
            //string sql = "select * from tblEmployee where Employ_Id='" + manv + "'";
            return dalEmploy.getAllEmploy();
        }

        public Boolean add(EmployeeModel employModel)
        {
            return dalEmploy.add(employModel);
        }

        public Boolean edit(EmployeeModel employModel)
        {
            return dalEmploy.updateWithId(employModel);
        }

        public Boolean deleteWithId(string employId)
        {
            return dalEmploy.deleteWithId(employId);
        }

        public Boolean deleteWithAccount(string account)
        {
            return dalEmploy.deleteWithAccount(account);
        }

        public string SinhManv()
        {
          return  dalEmploy.SinhManv();
        }

        public Dictionary<string, EmployeeModel> convertDatatable2Dict()
        {
            return dalEmploy.convertDatatable2Dict(getAllEmployList());
        }

        public Dictionary<string, EmployeeModel> convertDatatableWithQuartId2Dict(string quarterId)
        {
            return dalEmploy.convertDatatable2Dict(getEmployWithQuarterId(quarterId));
        }

        public Dictionary<string, EmployeeModel> convertDatatableWithSearch2Dict(string sqlString)
        {
            return dalEmploy.convertDatatable2Dict(getEmployDataWithSqlCmd(sqlString));
        }
        
        public int getTotalEmploy()
        {
            return getAllEmployList().Rows.Count;
        }
    }
}
