using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút "Đăng nhập"
        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            // Thực hiện đăng nhập tại đây
            this.Hide();
            DangNhap mainForm = new DangNhap();
            mainForm.Show();
        }

        // Sự kiện khi nhấn nút "Đăng ký"
        private void button_Dangky_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string taiKhoan = textBox_taikhoan.Text.Trim();
            string matKhau = textBox_matkhau.Text.Trim();
            string nhapLaiMatKhau = text_Nhaplainmk.Text.Trim();

            // Kiểm tra nếu mật khẩu và nhập lại mật khẩu giống nhau
            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu và nhập lại mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sử dụng lớp BLL để đăng ký
            DangKyBLL dangKyBLL = new DangKyBLL();
            bool isUserExist = dangKyBLL.CheckIfUserExists(taiKhoan);

            if (isUserExist)
            {
                MessageBox.Show("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Nếu tài khoản chưa tồn tại, tiến hành đăng ký
            bool isSuccess = dangKyBLL.RegisterUser(taiKhoan, matKhau);
            if (isSuccess)
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    // Sự kiện khi thay đổi nội dung ô nhập tài khoản
    private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra tài khoản nhập vào
        }

        // Sự kiện khi thay đổi nội dung ô nhập mật khẩu
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu nhập vào
        }

        // Sự kiện khi thay đổi trạng thái checkbox "Hiển thị mật khẩu"
        private void checkBox_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hienthi.Checked)
            {
                // Hiển thị mật khẩu
                textBox_matkhau.PasswordChar = '\0';
                text_Nhaplainmk.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu
                textBox_matkhau.PasswordChar = '*';
                text_Nhaplainmk.PasswordChar = '*';
            }
        }

        // Sự kiện khi nhấn vào label tài khoản
        private void label_taikhoan_Click(object sender, EventArgs e)
        {
            // Thực hiện hành động khi click vào label tài khoản
        }

        // Sự kiện khi nhấn vào label mật khẩu
        private void label_matkhau_Click(object sender, EventArgs e)
        {
            // Thực hiện hành động khi click vào label mật khẩu
        }

        // Sự kiện khi nhấn vào label nhập lại mật khẩu
        private void label1_Click(object sender, EventArgs e)
        {
            // Thực hiện hành động khi click vào label nhập lại mật khẩu
        }

        // Sự kiện khi nhấn vào hình ảnh
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Thực hiện hành động khi click vào hình ảnh
        }

        // Sự kiện khi groupBox2 được focus
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Thực hiện hành động khi groupBox2 được focus
        }
    }
}
