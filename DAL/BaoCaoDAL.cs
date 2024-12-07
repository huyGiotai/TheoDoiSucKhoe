using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BaoCaoDAL
    {
        private string connectionString = "Data Source=NGUYENMSI\\SQLEXPRESS;Initial Catalog=QuanLySucKhoe;Integrated Security=True;";

        // Method to fetch all reports
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
                throw new Exception("Error fetching data: " + ex.Message);
            }
        }

        // Method to fetch reports filtered by date
        public List<BaoCaoDTO> GetBaoCaoByDate(string selectedDate)
        {
            List<BaoCaoDTO> baoCaoList = new List<BaoCaoDTO>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ChiSoSucKhoe WHERE Ngay = @SelectedDate";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        BaoCaoDTO baoCao = new BaoCaoDTO
                        {
                            MaPhieu = Convert.ToInt32(reader["MaPhieu"]),
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Ngay = reader["Ngay"].ToString(),
                            TinhTrangCoThe = reader["TinhTrangCoThe"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            ChieuCao = Convert.ToSingle(reader["ChieuCao"]),
                            CanNang = Convert.ToSingle(reader["CanNang"]),
                            HuyetAp = reader["HuyetAp"].ToString(),
                            NhipTim = Convert.ToInt32(reader["NhipTim"]),
                            LuongDuongMau = Convert.ToSingle(reader["LuongDuongMau"]),
                            NhietDoCoThe = Convert.ToSingle(reader["NhietDoCoThe"])
                        };
                        baoCaoList.Add(baoCao);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching reports by date: " + ex.Message);
            }

            return baoCaoList;
        }
    }
}
