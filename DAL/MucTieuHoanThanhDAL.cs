using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class MucTieuHoanThanhDAL
    {
        private readonly string connectionString = "Data Source=NGUYENMSI\\SQLEXPRESS;Initial Catalog=QuanLySucKhoe;Integrated Security=True;";

        // Lấy tất cả dữ liệu từ bảng MucTieuHoanThanh
        public List<MucTieuHoanThanhDTO> GetAll()
        {
            List<MucTieuHoanThanhDTO> list = new List<MucTieuHoanThanhDTO>();
            string query = "SELECT * FROM MucTieuHoanThanh"; // Lấy tất cả dữ liệu từ bảng

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new MucTieuHoanThanhDTO
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        ThoiGianHoanThanh = reader["ThoiGianHoanThanh"].ToString(), // Thời gian hoàn thành dạng chuỗi
                        ChieuCaoHoanThanh = reader["ChieuCaoHoanThanh"] != DBNull.Value ? Convert.ToSingle(reader["ChieuCaoHoanThanh"]) : 0f,
                        CanNangHoanThanh = reader["CanNangHoanThanh"] != DBNull.Value ? Convert.ToSingle(reader["CanNangHoanThanh"]) : 0f
                    });
                }
            }
            return list;
        }

        // Thêm một mục tiêu đã hoàn thành vào bảng MucTieuHoanThanh
        public bool Add(MucTieuHoanThanhDTO completedTarget)
        {
            string query = "INSERT INTO MucTieuHoanThanh (ThoiGianHoanThanh, ChieuCaoHoanThanh, CanNangHoanThanh) VALUES (@ThoiGianHoanThanh, @ChieuCaoHoanThanh, @CanNangHoanThanh)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ThoiGianHoanThanh", completedTarget.ThoiGianHoanThanh);
                cmd.Parameters.AddWithValue("@ChieuCaoHoanThanh", completedTarget.ChieuCaoHoanThanh);
                cmd.Parameters.AddWithValue("@CanNangHoanThanh", completedTarget.CanNangHoanThanh);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        // Thêm log nếu không có bản ghi nào bị ảnh hưởng
                        Console.WriteLine("Không có bản ghi nào bị ảnh hưởng.");
                        return false;
                    }
                }
                catch (SqlException sqlEx)
                {
                    // Ghi lại chi tiết lỗi SQL
                    Console.WriteLine($"Lỗi SQL khi thêm mục tiêu hoàn thành: {sqlEx.Message}, Stack Trace: {sqlEx.StackTrace}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Ghi lại chi tiết lỗi hệ thống
                    Console.WriteLine($"Lỗi hệ thống khi thêm mục tiêu hoàn thành: {ex.Message}, Stack Trace: {ex.StackTrace}");
                    return false;
                }
            }
        }

        
        
    }
}
