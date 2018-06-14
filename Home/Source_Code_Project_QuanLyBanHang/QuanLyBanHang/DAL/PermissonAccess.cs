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
    public class PermissonAccess:DataConnect
    {
        public bool InsertPermissonInfo(Permission pms)
        {
            try
            {
                bool isCheck = false;

                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_Insert_PHANQUYEN";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MAQH", SqlDbType.NChar).Value = pms.idPermission;
                sqlCommand.Parameters.Add("@TENQH", SqlDbType.NVarChar).Value = pms.namePermisson;
                sqlCommand.Parameters.Add("@GHICHU", SqlDbType.NVarChar).Value = pms.notePermisson;

                int result = sqlCommand.ExecuteNonQuery();

                if (result > 0)
                {
                    isCheck = true;
                }
                return isCheck;
            }
            catch
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }

        }

    }
}
