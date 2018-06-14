using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataConnect
    {
        public SqlConnection conn = null;
        string sqlConn = "Data Source=DESKTOP-KM5FA0O;Initial Catalog=QLBANHANG;Integrated Security=True";
        //string sqlConn = @"Data Source=DESKTOP-DGOOVFL;Initial Catalog=TESTING;Integrated Security=True";

        //string sqlConn = @"Data Source=DESKTOP-KM5FA0O;Initial Catalog=QL_BANHANG;Integrated Security=True";

        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if(conn!=null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if(conn!=null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

