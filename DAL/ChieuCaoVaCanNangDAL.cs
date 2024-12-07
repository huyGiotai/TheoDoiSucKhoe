using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChieuCaoVaCanNangDAL
    {
        private readonly string connectionString = "Data Source=NGUYENMSI\\SQLEXPRESS;Initial Catalog=QuanLySucKhoe;Integrated Security=True;";

        // Lấy tất cả dữ liệu từ bảng ChieuCaoVaCanNang
        public List<ChieuCaoVaCanNangDTO> GetAll()
        {
            List<ChieuCaoVaCanNangDTO> list = new List<ChieuCaoVaCanNangDTO>();
            string query = "SELECT * FROM ChieuCaoVaCanNang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var target = new ChieuCaoVaCanNangDTO
                    {
                        Id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0,
                        MaPhieu = reader["MaPhieu"] != DBNull.Value ? Convert.ToInt32(reader["MaPhieu"]) : 0,
                        ThoiGian = reader["thoiGian"] != DBNull.Value ? reader["thoiGian"].ToString() : string.Empty,
                        ChieuCao = reader["chieuCao"] != DBNull.Value ? Convert.ToSingle(reader["chieuCao"]) : 0f,
                        CanNang = reader["canNang"] != DBNull.Value ? Convert.ToSingle(reader["canNang"]) : 0f
                    };
                    list.Add(target);
                }
            }

            return list;
        }

        // Thêm mới một mục tiêu vào bảng ChieuCaoVaCanNang
        public bool Add(ChieuCaoVaCanNangDTO target)
        {
            string query = @"INSERT INTO ChieuCaoVaCanNang (thoiGian, chieuCao, canNang) VALUES (@ThoiGian, @ChieuCao, @CanNang)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                // Đảm bảo các tham số được truyền vào đúng
                //cmd.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = target.MaPhieu;
                cmd.Parameters.Add("@ThoiGian", SqlDbType.Int).Value = int.TryParse(target.ThoiGian, out int soNgay) ? soNgay : 0;
                cmd.Parameters.Add("@ChieuCao", SqlDbType.Float).Value = target.ChieuCao;
                cmd.Parameters.Add("@CanNang", SqlDbType.Float).Value = target.CanNang;

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Thêm mục tiêu thành công.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Không có mục tiêu nào được thêm.");
                        return false;
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Ghi log lỗi SQL để dễ dàng theo dõi
                    Console.WriteLine($"Lỗi SQL: {sqlEx.Message}, Stack Trace: {sqlEx.StackTrace}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Ghi log lỗi hệ thống để dễ dàng theo dõi
                    Console.WriteLine($"Lỗi hệ thống: {ex.Message}, Stack Trace: {ex.StackTrace}");
                    return false;
                }
            }
        }

        // Xóa một mục tiêu khỏi bảng ChieuCaoVaCanNang
        public bool Delete(int id)
        {
            string query = "DELETE FROM ChieuCaoVaCanNang WHERE id = @Id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi xóa mục tiêu: {ex.Message}");
                    return false;
                }
            }
        }

        // Cập nhật mục tiêu trong bảng ChieuCaoVaCanNang
        public bool Update(ChieuCaoVaCanNangDTO target)
        {
            string query = "UPDATE ChieuCaoVaCanNang SET thoiGian = @ThoiGian, chieuCao = @ChieuCao, canNang = @CanNang WHERE id = @Id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@ThoiGian", SqlDbType.NVarChar).Value = target.ThoiGian;
                cmd.Parameters.Add("@ChieuCao", SqlDbType.Float).Value = target.ChieuCao;
                cmd.Parameters.Add("@CanNang", SqlDbType.Float).Value = target.CanNang;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = target.Id;

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi cập nhật mục tiêu: {ex.Message}");
                    return false;
                }
            }
        }

        // Xóa tất cả mục tiêu trong bảng ChieuCaoVaCanNang
        public bool ClearAll()
        {
            string query = "DELETE FROM ChieuCaoVaCanNang"; // Xóa tất cả dữ liệu trong bảng
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi xóa tất cả mục tiêu: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
