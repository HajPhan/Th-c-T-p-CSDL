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
    public class TestAccess:DataConnect
    {
        public DataTable HienThiLenDataGridView(Test test)
        {
            OpenConnection();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT *FROM TEST", conn);

            DataTable dt = new DataTable();

            sqlDataAdapter.Fill(dt);

            return (dt);
        }

        public List<Test> TestData()
        {
            OpenConnection();

            List<Test> testlist = new List<Test>();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT *FROM TEST";
            sqlCommand.Connection = conn;

            DataTable dt = new DataTable();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            dt.Load(reader);

            for(int i = 0; i<dt.Rows.Count; i++)
            {
                Test tes = new Test();
                tes.manv = int.Parse(dt.Rows[i][0].ToString());
                tes.hoten = dt.Rows[i][1].ToString();
                tes.ngaysinh = DateTime.Parse( dt.Rows[i][2].ToString());
                tes.gioitinh = dt.Rows[i][3].ToString();
                tes.sdt = int.Parse(dt.Rows[i][4].ToString());
                tes.diachi = dt.Rows[i][5].ToString();

                testlist.Add(tes);
            }
            reader.Close();
            return testlist;
        }

    }
}
