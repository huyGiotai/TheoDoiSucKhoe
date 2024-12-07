using System;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class BaoCaoDAL
    {
        private string connectionString = "Data Source=NGUYENMSI\\SQLEXPRESS.;Initial Catalog=QuanLySucKhoe;Integrated Security=True";

        public BaoCaoDTO GetBaoCaoByDate(DateTime ngay)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ChiSoSucKhoe WHERE Ngay = @Ngay";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ngay", ngay.ToString("yyyy-MM-dd"));
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Tạo và trả về đối tượng BaoCaoDTO
                                return new BaoCaoDTO
                                {
                                    MaPhieu = reader.GetInt32(reader.GetOrdinal("MaPhieu")),
                                    Ngay = reader.GetString(reader.GetOrdinal("Ngay")),
                                    TinhTrangCoThe = reader.GetString(reader.GetOrdinal("TinhTrangCoThe")),
                                    ChieuCao = reader.GetDouble(reader.GetOrdinal("ChieuCao")),
                                    CanNang = reader.GetDouble(reader.GetOrdinal("CanNang")),
                                    HuyetAp = reader.GetString(reader.GetOrdinal("HuyetAp")),
                                    NhipTim = reader.GetInt32(reader.GetOrdinal("NhipTim")),
                                    NhietDoCoThe = reader.GetDouble(reader.GetOrdinal("NhietDoCoThe"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi (tùy theo hệ thống log bạn dùng)
                Console.WriteLine($"Lỗi khi lấy báo cáo: {ex.Message}");
            }
            return null;
        }
    }
}
