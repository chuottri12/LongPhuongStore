using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient ;


namespace DAL
{
   public  class DBConnect
    {
       protected SqlConnection sqlConnection = new SqlConnection(@"Data Source=HP-PC\SQLEXPRESS;Initial Catalog=LongPhuong;Integrated Security=True");
    }
}
