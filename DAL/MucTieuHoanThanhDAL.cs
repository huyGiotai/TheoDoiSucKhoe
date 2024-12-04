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
        private readonly string connectionString = "Data Source=HUY\\MSSQLSERVER10;Initial Catalog=QuanLySucKhoe;Integrated Security=True;";

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
                        ThoiGianHoanThanh = reader["ThoiGianHoanThanh"].ToString(),
                        ChieuCaoHoanThanh = Convert.ToSingle(reader["ChieuCaoHoanThanh"]),
                        CanNangHoanThanh = Convert.ToSingle(reader["CanNangHoanThanh"])
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
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Xóa mục tiêu đã hoàn thành khỏi bảng MucTieuHoanThanh
        public bool Delete(int id)
        {
            string query = "DELETE FROM MucTieuHoanThanh WHERE id = @Id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
