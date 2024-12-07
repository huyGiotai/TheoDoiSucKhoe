using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ChiSoSucKhoeDAL
    {
        private readonly string connectionString = "Data Source=NGUYENMSI\\SQLEXPRESS;Initial Catalog=QuanLySucKhoe;Integrated Security=True;";



        public DataTable GetAll()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChiSoSucKhoe", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }


        public DataTable GetByDate(string ngay)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ChiSoSucKhoe WHERE Ngay = @Ngay";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@Ngay", ngay);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm dữ liệu: " + ex.Message);
            }
        }

        public bool Insert(ChiSoSucKhoeDTO chiSo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO ChiSoSucKhoe 
                                     (UserID, Ngay, TinhTrangCoThe, GioiTinh, ChieuCao, CanNang, HuyetAp, NhipTim, LuongDuongMau, NhietDoCoThe) 
                                     VALUES (@UserID, @Ngay, @TinhTrangCoThe, @GioiTinh, @ChieuCao, @CanNang, @HuyetAp, @NhipTim, @LuongDuongMau, @NhietDoCoThe)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", chiSo.UserID);
                    cmd.Parameters.AddWithValue("@Ngay", chiSo.Ngay);
                    cmd.Parameters.AddWithValue("@TinhTrangCoThe", chiSo.TinhTrangCoThe);
                    cmd.Parameters.AddWithValue("@GioiTinh", chiSo.GioiTinh);
                    cmd.Parameters.AddWithValue("@ChieuCao", chiSo.ChieuCao);
                    cmd.Parameters.AddWithValue("@CanNang", chiSo.CanNang);
                    cmd.Parameters.AddWithValue("@HuyetAp", chiSo.HuyetAp);
                    cmd.Parameters.AddWithValue("@NhipTim", chiSo.NhipTim);
                    cmd.Parameters.AddWithValue("@LuongDuongMau", chiSo.LuongDuongMau);
                    cmd.Parameters.AddWithValue("@NhietDoCoThe", chiSo.NhietDoCoThe);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
        }

        public bool Update(ChiSoSucKhoeDTO chiSo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE ChiSoSucKhoe 
                                     SET Ngay=@Ngay, TinhTrangCoThe=@TinhTrangCoThe, GioiTinh=@GioiTinh, ChieuCao=@ChieuCao, 
                                         CanNang=@CanNang, HuyetAp=@HuyetAp, NhipTim=@NhipTim, LuongDuongMau=@LuongDuongMau, NhietDoCoThe=@NhietDoCoThe 
                                     WHERE MaPhieu=@MaPhieu";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhieu", chiSo.MaPhieu);
                    cmd.Parameters.AddWithValue("@Ngay", chiSo.Ngay);
                    cmd.Parameters.AddWithValue("@TinhTrangCoThe", chiSo.TinhTrangCoThe);
                    cmd.Parameters.AddWithValue("@GioiTinh", chiSo.GioiTinh);
                    cmd.Parameters.AddWithValue("@ChieuCao", chiSo.ChieuCao);
                    cmd.Parameters.AddWithValue("@CanNang", chiSo.CanNang);
                    cmd.Parameters.AddWithValue("@HuyetAp", chiSo.HuyetAp);
                    cmd.Parameters.AddWithValue("@NhipTim", chiSo.NhipTim);
                    cmd.Parameters.AddWithValue("@LuongDuongMau", chiSo.LuongDuongMau);
                    cmd.Parameters.AddWithValue("@NhietDoCoThe", chiSo.NhietDoCoThe);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật dữ liệu: " + ex.Message);
            }
        }

        public bool Delete(int maPhieu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ChiSoSucKhoe WHERE MaPhieu=@MaPhieu";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhieu", maPhieu);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa dữ liệu: " + ex.Message);
            }
        }
    }
}
