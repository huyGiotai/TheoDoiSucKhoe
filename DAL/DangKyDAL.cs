using System;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class DangKyDAL
    {
        // Chuỗi kết nối tới cơ sở dữ liệu
        private string connectionString = @"Data Source=NGUYENMSI\SQLEXPRESS;Initial Catalog=QuanLySucKhoe;Integrated Security=True";

        // Phương thức kiểm tra người dùng có tồn tại trong cơ sở dữ liệu không
        public bool CheckIfUserExists(string taiKhoan)
        {
            bool userExists = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sửa lại câu truy vấn để sử dụng cột 'username' thay vì 'TaiKhoan'
                    string query = "SELECT COUNT(*) FROM [user] WHERE username = @TaiKhoan";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        int count = (int)cmd.ExecuteScalar();
                        userExists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi vào file log
                LogError(ex);
                // Ném lại ngoại lệ với thông tin chi tiết hơn
                throw new Exception("Có lỗi khi kiểm tra người dùng: " + ex.Message + "\n" + ex.StackTrace, ex);
            }

            return userExists;
        }

        // Phương thức để thêm người dùng mới vào cơ sở dữ liệu
        public bool InsertUser(string taiKhoan, string matKhau)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Sửa lại câu truy vấn để sử dụng cột 'username' và 'password'
                    string query = "INSERT INTO [user] (username, password) VALUES (@TaiKhoan, @MatKhau)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi vào file log
                LogError(ex);
                // Ném lại ngoại lệ với thông tin chi tiết hơn
                throw new Exception("Có lỗi khi đăng ký người dùng: " + ex.Message + "\n" + ex.StackTrace, ex);
            }
        }

        // Phương thức ghi log lỗi vào file
        private void LogError(Exception ex)
        {
            try
            {
                string logFilePath = @"C:\Logs\error_log.txt";  // Đường dẫn file log
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine("Time: " + DateTime.Now);
                    writer.WriteLine("Error Message: " + ex.Message);
                    writer.WriteLine("Stack Trace: " + ex.StackTrace);
                    writer.WriteLine("--------------------------------------------------");
                }
            }
            catch (Exception logEx)
            {
                // Nếu có lỗi khi ghi log, bạn có thể xử lý lỗi này ở đây (ví dụ, ghi vào EventLog hoặc ghi vào một file khác)
                Console.WriteLine("Error logging the exception: " + logEx.Message);
            }
        }
    }
}
