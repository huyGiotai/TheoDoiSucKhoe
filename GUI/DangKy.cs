using System;
using System.Windows.Forms;
using System.Data.SqlClient; // Dùng để kết nối SQL
using DTO;  // Thêm namespace chứa các lớp DTO
using BLL;

namespace GUI
{
    public partial class DangKy : Form
    {
        private readonly DangKyBLL _DangKyBLL = new DangKyBLL();
        public DangKy()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_matkhau_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_dangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button_Dangky_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBox_taikhoan.Text.Trim();
            string matKhau = textBox_matkhau.Text.Trim();
            string nhapLaiMatKhau = text_Nhaplainmk.Text.Trim();

            // Kiểm tra các trường hợp
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(nhapLaiMatKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Chuỗi kết nối tới cơ sở dữ liệu
                string connectionString = @"Data Source=NGUYENMSI\SQLEXPRESS;Initial Catalog=QuanLySucKhoe;Integrated Security=True";

                // Tạo kết nối
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra xem tài khoản đã tồn tại chưa
                    string checkUserQuery = "SELECT COUNT(*) FROM [User] WHERE TaiKhoan = @TaiKhoan";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, connection))
                    {
                        checkUserCmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        int userExists = (int)checkUserCmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Thêm tài khoản mới vào bảng User
                    string insertQuery = "INSERT INTO [User] (TaiKhoan, MatKhau) VALUES (@TaiKhoan, @MatKhau)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        insertCmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Xóa các ô nhập
                            textBox_taikhoan.Clear();
                            textBox_matkhau.Clear();
                            text_Nhaplainmk.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label_taikhoan_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hienthi.Checked)
            {
                textBox_matkhau.PasswordChar = '\0'; // Hiển thị mật khẩu
                text_Nhaplainmk.PasswordChar = '\0';
            }
            else
            {
                textBox_matkhau.PasswordChar = '*'; // Ẩn mật khẩu
                text_Nhaplainmk.PasswordChar = '*';
            }
        }


        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            // Tạo một đối tượng của form DangNhap
            DangNhap formDangNhap = new DangNhap();

            // Ẩn form hiện tại nếu bạn muốn chỉ hiển thị form đăng nhập
            this.Hide(); // Ẩn form hiện tại

            // Hiển thị form DangNhap
            formDangNhap.ShowDialog();  // Dùng ShowDialog để mở form đăng nhập dưới dạng modal (chờ người dùng đóng form đăng nhập)

            // Hoặc nếu bạn muốn mở form đăng nhập mà không đóng form hiện tại:
            // formDangNhap.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void DangKy_Load_1(object sender, EventArgs e)
        {

        }
    }
}