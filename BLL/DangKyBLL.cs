using DAL;

namespace BLL
{
    public class DangKyBLL
    {
        private DangKyDAL dangKyDAL;

        public DangKyBLL()
        {
            dangKyDAL = new DangKyDAL();
        }

        public bool CheckIfUserExists(string taiKhoan)
        {
            return dangKyDAL.CheckIfUserExists(taiKhoan);
        }

        public bool RegisterUser(string taiKhoan, string matKhau)
        {
            return dangKyDAL.InsertUser(taiKhoan, matKhau);
        }
    }
}
