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
    public class ThongKeAccess : DataConnect
    {
        #region Thong Ke Don Dat Hang
        public List<ThongKe> ThongKeDonDatHangTheoNgayThang(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKeDonDatHangTheoNgayThang";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@DateTimesOne", SqlDbType.DateTime).Value = tk.DateOne;
                sqlCommand.Parameters.Add("@DateTimesTwo", SqlDbType.DateTime).Value = tk.DateTwo;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][4].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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


        public List<ThongKe> ThongKeDonDatHang()
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKeDonDatHang";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tk = new ThongKe();
                    tk.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tk.TenSp = dt.Rows[i][1].ToString();
                    tk.TenLoai = dt.Rows[i][2].ToString();
                    tk.TenSx = dt.Rows[i][3].ToString();
                    tk.Sld = int.Parse(dt.Rows[i][4].ToString());


                    tklist.Add(tk);
                }

                sqlReader.Close();
                return tklist;
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


        // Tong so lương Đơn Đặt Hàng
        public DataTable TongSldh()
        {
            try
            {
                OpenConnection();

                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT SUM(ct.SLDH) AS SLDH FROM dbo.CTDH AS ct", conn);

                DataTable dt = new DataTable();

                sqlData.Fill(dt);

                return dt;
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


        // Tinh Tong So Don Dat Hang Theo Ma San Pham
        public DataTable TonSldhTheoMaSp(ThongKe tk)
        {
            try
            {
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKeTongSoDoDhTheoMaSp";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@Masp", SqlDbType.Int).Value = tk.MaSp;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                return dt;

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

        // Hien Thi Ten Loai San Pham
        public List<ThongKe> HienThiTenLoaiSanPham()
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TENLOAI FROM dbo.LOAISP";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tk = new ThongKe();
                    tk.TenLoai = dt.Rows[i][0].ToString();

                    tklist.Add(tk);
                }
                sqlReader.Close();
                return tklist;
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

        // Hien thi ten Nha San Xuat
        public List<ThongKe> HienThiTenNhaSanXuat()
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT TENSX FROM dbo.NHASX";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tk = new ThongKe();
                    tk.TenSx = dt.Rows[i][0].ToString();

                    tklist.Add(tk);
                }
                sqlReader.Close();
                return tklist;
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

        // Thong Ke Don Hang Theo Ten Loai San Pham
        public List<ThongKe> ThongKeDonDatHangTheoLoaiSp(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKeDonHangTheoTenLoai";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@TenLoai", SqlDbType.NVarChar).Value = tk.TenLoai;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][4].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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


        // THon Ke Theo Nha San Xuat
        public List<ThongKe> ThongKeDonDatHangTheoNhaSx(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKeDonHangTheoNhaSx";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@TenSx", SqlDbType.NVarChar).Value = tk.TenLoai;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][4].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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
        #endregion

        #region Thong Ke Ton Kho
        public List<ThongKe> ThongKeTonKho()
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_DanhSachTonKho";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tk = new ThongKe();
                    tk.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tk.TenSp = dt.Rows[i][1].ToString();
                    tk.Sld = int.Parse(dt.Rows[i][2].ToString());
                    tk.Sln = int.Parse(dt.Rows[i][3].ToString());
                    tk.Slx = int.Parse(dt.Rows[i][4].ToString());
                    tk.Slcl = int.Parse(dt.Rows[i][5].ToString());

                    tklist.Add(tk);

                }
                sqlReader.Close();

                return tklist;
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


        public List<ThongKe> ThongKeTonKhoTheoNgayThang(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKeTonKhoTheoNgayThang";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@DateTimesOne", SqlDbType.DateTime).Value = tk.DateOne;
                sqlCommand.Parameters.Add("@DateTimesTwo", SqlDbType.DateTime).Value = tk.DateTwo;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][2].ToString());
                    tks.Sln = int.Parse(dt.Rows[i][3].ToString());
                    tks.Slx = int.Parse(dt.Rows[i][4].ToString());
                    tks.Slcl = int.Parse(dt.Rows[i][5].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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


        public bool UpdateTongSldTonKho(ThongKe tk)
        {
            try
            {
                bool isCheck = false;
                OpenConnection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_UPDATE_TONKHO";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@MASP", SqlDbType.Int).Value = tk.MaSp;
                sqlCommand.Parameters.Add("@TONGSLD", SqlDbType.Int).Value = tk.Sld;

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
        #endregion


        #region Thong Ke Phieu Nhap

        // Thong Ke Phieu Nhap
        public List<ThongKe> ThongKePhieuNhap()
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuNhap";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][4].ToString());
                    tks.Sln = int.Parse(dt.Rows[i][5].ToString());
                    tks.Slcl = int.Parse(dt.Rows[i][6].ToString());
                    tks.DonGia = double.Parse(dt.Rows[i][7].ToString());
                    tks.ThanhTien = double.Parse(dt.Rows[i][8].ToString());


                    tklist.Add(tks);
                }
                sqlReader.Close();

                return tklist;
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

        // Hien thi ten Nha Cung Cap
        public List<ThongKe> HienThiTenNhaCungCap()
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "SELECT DISTINCT TENCC FROM dbo.NHACC";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tk = new ThongKe();
                    tk.TenCc = dt.Rows[i][0].ToString();

                    tklist.Add(tk);
                }
                sqlReader.Close();
                return tklist;
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

        // Thong Ke Phieu Nhap Theo Ngay Thang
        public List<ThongKe> ThongKePhieuNhapTheoNgayThang(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuNhapTheoNgayThang";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@DateTimesOne", SqlDbType.DateTime).Value = tk.DateOne;
                sqlCommand.Parameters.Add("@DateTimesTwo", SqlDbType.DateTime).Value = tk.DateTwo;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][4].ToString());
                    tks.Sln = int.Parse(dt.Rows[i][5].ToString());
                    tks.Slcl = int.Parse(dt.Rows[i][6].ToString());
                    tks.DonGia = double.Parse(dt.Rows[i][7].ToString());
                    tks.ThanhTien = double.Parse(dt.Rows[i][8].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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

        // THong KE phieu Nhap Theo Nha Cung Cap
        public List<ThongKe> ThongKePhieuNhapTheoNhaCungCap(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuNhapTheoNhaCungCap";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@TenCc", SqlDbType.NVarChar).Value = tk.TenCc;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][4].ToString());
                    tks.Sln = int.Parse(dt.Rows[i][5].ToString());
                    tks.Slcl = int.Parse(dt.Rows[i][6].ToString());
                    tks.DonGia = double.Parse(dt.Rows[i][7].ToString());
                    tks.ThanhTien = double.Parse(dt.Rows[i][8].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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

        // THong KE phieu Nhap Theo Loai San Pham
        public List<ThongKe> ThongKePhieuNhapLoaiSp(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuNhapTheoLoaiSp";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@LoaiSp", SqlDbType.NVarChar).Value = tk.TenLoai;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.Sld = int.Parse(dt.Rows[i][4].ToString());
                    tks.Sln = int.Parse(dt.Rows[i][5].ToString());
                    tks.Slcl = int.Parse(dt.Rows[i][6].ToString());
                    tks.DonGia = double.Parse(dt.Rows[i][7].ToString());
                    tks.ThanhTien = double.Parse(dt.Rows[i][8].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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

        #endregion

        #region Thong Ke Phieu Xuat

        // Danh Sach THong Ke
        public List<ThongKe> ThongKePhieuXuat()
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuXuat";
                sqlCommand.Connection = conn;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tk = new ThongKe();
                    tk.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tk.TenSp = dt.Rows[i][1].ToString();
                    tk.TenLoai = dt.Rows[i][2].ToString();
                    tk.TenSx = dt.Rows[i][3].ToString();
                    tk.TenKh = dt.Rows[i][4].ToString();
                    tk.Slx = int.Parse(dt.Rows[i][5].ToString());
                    tk.TongTien = double.Parse(dt.Rows[i][6].ToString());
                    tk.PhanTram = float.Parse(dt.Rows[i][7].ToString());
                    tk.ThanhTien = double.Parse(dt.Rows[i][8].ToString());



                    tklist.Add(tk);
                }

                sqlReader.Close();

                return tklist;
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

        // Thong KE pHieu Xuat THeo San Pham
        public List<ThongKe> ThongKePHieuXuatTHeoLoaiSp(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuXuatTtheoLoaiSp";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@LoaiSp", SqlDbType.NVarChar).Value = tk.TenLoai;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();

                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.TenKh = dt.Rows[i][4].ToString();
                    tks.Slx = int.Parse(dt.Rows[i][5].ToString());
                    tks.TongTien = double.Parse(dt.Rows[i][6].ToString());
                    tks.PhanTram = float.Parse(dt.Rows[i][7].ToString());
                    tks.ThanhTien = double.Parse(dt.Rows[i][8].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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

        // Thong KE pHieu Xuat THeo San Pham
        public List<ThongKe> ThongKePHieuXuatTHeoSanPham(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuXuatTtheoTenSp";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@TenSp", SqlDbType.NVarChar).Value = tk.TenSp;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();

                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.TenKh = dt.Rows[i][4].ToString();
                    tks.Slx = int.Parse(dt.Rows[i][5].ToString());
                    tks.TongTien = double.Parse(dt.Rows[i][6].ToString());
                    tks.PhanTram = float.Parse(dt.Rows[i][7].ToString());
                    tks.ThanhTien = double.Parse(dt.Rows[i][8].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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

        // Thong Ke Phieu Xuat Theo Ngay Thang
        public List<ThongKe> ThongKePhieuXuatTheoNgayThang(ThongKe tk)
        {
            try
            {
                OpenConnection();
                List<ThongKe> tklist = new List<ThongKe>();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "sp_ThongKePhieuXuatTtheoNgayThang";
                sqlCommand.Connection = conn;

                sqlCommand.Parameters.Add("@DateTimesOne", SqlDbType.DateTime).Value = tk.DateOne;
                sqlCommand.Parameters.Add("@DateTimesTwo", SqlDbType.DateTime).Value = tk.DateTwo;

                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(sqlReader);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ThongKe tks = new ThongKe();
                    tks.MaSp = int.Parse(dt.Rows[i][0].ToString());
                    tks.TenSp = dt.Rows[i][1].ToString();
                    tks.TenLoai = dt.Rows[i][2].ToString();
                    tks.TenSx = dt.Rows[i][3].ToString();
                    tks.TenKh = dt.Rows[i][4].ToString();
                    tks.Slx = int.Parse(dt.Rows[i][5].ToString());
                    tks.TongTien = double.Parse(dt.Rows[i][6].ToString());
                    tks.PhanTram = float.Parse(dt.Rows[i][7].ToString());
                    tks.ThanhTien = double.Parse(dt.Rows[i][8].ToString());

                    tklist.Add(tks);
                }

                sqlReader.Close();
                return tklist;
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
            
            #endregion
        
    }
}
