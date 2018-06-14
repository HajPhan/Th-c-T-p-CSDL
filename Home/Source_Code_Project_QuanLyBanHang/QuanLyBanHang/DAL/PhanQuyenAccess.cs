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
    public class PhanQuyenAccess : DataConnect
    {
        // Hiển Thi danh sách nhóm quyền hạn
        public DataTable HienThiNhomQuyen()
        {
            OpenConnection();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT *FROM PHANQUYEN", conn);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            return (dt);
        }

        // Hiển Thi Danh Sách Chức Năng Trong Bảng Nhân Viên
        public List<PhanQuyen> HienThiDanhSachChucNang(PhanQuyen pq)
        {
            try
            {
                OpenConnection();
                List<PhanQuyen> pqlist = new List<PhanQuyen>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_SELECT_CHUCNANG";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MACN", SqlDbType.NChar).Value = pq.idChucNang;
                sqlCommand.Parameters.Add("@TENCHUCNANG", SqlDbType.NChar).Value = pq.nameChucNang;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhanQuyen pqs = new PhanQuyen();
                    pqs.Inserts = int.Parse(dt.Rows[i][0].ToString());
                    pqs.Updates = int.Parse(dt.Rows[i][0].ToString());
                    pqs.Deletes = int.Parse(dt.Rows[i][0].ToString());
                    pqs.In = int.Parse(dt.Rows[i][0].ToString());
                    pqs.Searchs = int.Parse(dt.Rows[i][0].ToString());

                    pqlist.Add(pqs);
                }
                sqlReader.Close();

                return pqlist;
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


        // Phân Quyền Nhân Viên
        public DataTable PhanQuyenNhanVien(PhanQuyen pq)
        {

            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "sp_INSERT_CTCN_UPDATE_CHUCNANG";
            sqlCommand.Connection = conn;

            sqlCommand.Parameters.Add("@MAQH", SqlDbType.NChar).Value = pq.idPermission;
            sqlCommand.Parameters.Add("@DANHMUC", SqlDbType.Bit).Value = pq.DanhMuc;
            sqlCommand.Parameters.Add("@QUANLYBANHANG", SqlDbType.Bit).Value = pq.QuanLyBanHang;
            sqlCommand.Parameters.Add("@THONGKE", SqlDbType.Bit).Value = pq.ThongKe;
            sqlCommand.Parameters.Add("@SAOLUU", SqlDbType.Bit).Value = pq.SaoLuu;
            sqlCommand.Parameters.Add("@HELP", SqlDbType.Bit).Value = pq.Help;
            sqlCommand.Parameters.Add("@MACN", SqlDbType.NChar).Value = pq.idChucNang;
            sqlCommand.Parameters.Add("@TENCHUCNANG", SqlDbType.NChar).Value = pq.nameChucNang;
            sqlCommand.Parameters.Add("@INSERTS", SqlDbType.Bit).Value = pq.Inserts;
            sqlCommand.Parameters.Add("@UPDATES", SqlDbType.Bit).Value = pq.Updates;
            sqlCommand.Parameters.Add("@DELETES", SqlDbType.Bit).Value = pq.Deletes;
            sqlCommand.Parameters.Add("@SEARCH", SqlDbType.Bit).Value = pq.Searchs;
            sqlCommand.Parameters.Add("@PRINTS", SqlDbType.Bit).Value = pq.In;

            SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();

            sqlAdapter.Fill(dt);

            return dt;
        } 



    }
}
