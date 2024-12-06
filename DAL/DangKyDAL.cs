using System;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DangKyDAL
    {
        private readonly string _connectionString = @"Data Source=NGUYENMSI\SQLEXPRESS;Initial Catalog=QuanLySucKhoe;Integrated Security=True";

        // Kiểm tra xem tài khoản đã tồn tại
        public bool IsUserExists(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM [user] WHERE username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi kiểm tra tài khoản: " + ex.Message);
            }
        }

        // Thêm người dùng mới
        public bool AddUser(UserDTO user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [user] (username, password) VALUES (@Username, @Password)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi thêm người dùng: " + ex.Message);
            }
        }
    }
}
