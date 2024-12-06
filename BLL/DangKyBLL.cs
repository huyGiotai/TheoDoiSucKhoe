using System;
using DAL;
using DTO;

namespace BLL
{
    public class DangKyBLL
    {
        private readonly DangKyDAL _userDal = new DangKyDAL();

        // Kiểm tra tài khoản đã tồn tại
        public bool IsUsernameTaken(string username)
        {
            return _userDal.IsUserExists(username);
        }

        // Kiểm tra tính hợp lệ của tài khoản
        public bool IsValidUsername(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < 4) return false;
            if (!System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z0-9]*$")) return false;
            if (System.Text.RegularExpressions.Regex.IsMatch(username, "^[0-9]*$")) return false;
            return true;
        }

        // Kiểm tra tính hợp lệ của mật khẩu
        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6) return false;
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]")) return false; // Ít nhất 1 chữ in hoa
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]")) return false; // Ít nhất 1 số
            if (System.Text.RegularExpressions.Regex.IsMatch(password, "[^a-zA-Z0-9]")) return false; // Không chứa ký tự đặc biệt
            return true;
        }

        // Thêm tài khoản mới
        public bool RegisterUser(string username, string password)
        {
            if (IsUsernameTaken(username)) throw new Exception("Tài khoản đã tồn tại");
            if (!IsValidUsername(username)) throw new Exception("Tên tài khoản không hợp lệ");
            if (!IsValidPassword(password)) throw new Exception("Mật khẩu không hợp lệ");

            var user = new UserDTO { Username = username, Password = password };
            return _userDal.AddUser(user);
        }
    }
}
