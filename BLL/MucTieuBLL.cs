using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BLL
{
    public class MucTieuBLL
    {
        private readonly ChieuCaoVaCanNangDAL chieuCaoVaCanNangDAL;
        private readonly MucTieuHoanThanhDAL mucTieuHoanThanhDAL;

        public MucTieuBLL()
        {
            chieuCaoVaCanNangDAL = new ChieuCaoVaCanNangDAL();
            mucTieuHoanThanhDAL = new MucTieuHoanThanhDAL();
        }

        // Lấy danh sách mục tiêu
        public List<ChieuCaoVaCanNangDTO> GetAllMucTieu()
        {
            try
            {
                return chieuCaoVaCanNangDAL.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách mục tiêu: {ex.Message}");
                // Có thể ném lại lỗi hoặc ghi log để dễ dàng xử lý vấn đề
                throw new Exception("Lỗi khi lấy danh sách mục tiêu.", ex);
            }
        }

        // Thêm mới một mục tiêu
        public bool AddMucTieu(ChieuCaoVaCanNangDTO target)
        {
            if (target == null)
            {
                Console.WriteLine("Mục tiêu không hợp lệ. Đối tượng null.");
                MessageBox.Show("Mục tiêu không hợp lệ. Vui lòng thử lại.");
                return false;
            }

            try
            {
                bool result = chieuCaoVaCanNangDAL.Add(target);
                if (result)
                {
                    MessageBox.Show("Thêm mục tiêu thành công.");
                    Console.WriteLine("Thêm mục tiêu thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm mục tiêu thất bại. Không có bản ghi nào được thêm.");
                    Console.WriteLine("Thêm mục tiêu thất bại. Không có bản ghi nào được thêm.");
                }
                return result;
            }
            catch (SqlException sqlEx)
            {
                string errorMessage = $"Lỗi cơ sở dữ liệu: {sqlEx.Message}.";
                MessageBox.Show(errorMessage);
                Console.WriteLine(errorMessage);
                // Bạn có thể ghi lại lỗi này vào file log hoặc database để theo dõi.
                throw new Exception("Lỗi khi thêm mục tiêu vào cơ sở dữ liệu.", sqlEx);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Lỗi hệ thống: {ex.Message}.";
                MessageBox.Show(errorMessage);
                Console.WriteLine(errorMessage);
                // Ghi lại lỗi vào log file nếu cần.
                throw new Exception("Đã xảy ra lỗi khi thêm mục tiêu.", ex);
            }
        }

        // Cập nhật mục tiêu
        public bool UpdateMucTieu(ChieuCaoVaCanNangDTO target)
        {
            if (target == null)
            {
                Console.WriteLine("Mục tiêu không hợp lệ.");
                return false;
            }

            try
            {
                return chieuCaoVaCanNangDAL.Update(target);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật mục tiêu: {ex.Message}");
                // Ghi log và ném lại lỗi nếu cần
                throw new Exception("Lỗi khi cập nhật mục tiêu.", ex);
            }
        }

        // Xóa mục tiêu
        public bool DeleteMucTieu(int id)
        {
            try
            {
                return chieuCaoVaCanNangDAL.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa mục tiêu: {ex.Message}");
                throw new Exception("Lỗi khi xóa mục tiêu.", ex);
            }
        }

        // Hoàn thành mục tiêu và chuyển sang bảng hoàn thành
        public bool CompleteMucTieu(MucTieuHoanThanhDTO completedTarget, int targetId)
        {
            if (completedTarget == null)
            {
                Console.WriteLine("Mục tiêu hoàn thành không hợp lệ.");
                MessageBox.Show("Mục tiêu hoàn thành không hợp lệ.");
                return false;
            }

            try
            {
                // Thêm vào bảng MucTieuHoanThanh mà không xóa mục tiêu
                bool isAdded = mucTieuHoanThanhDAL.Add(completedTarget);
                if (isAdded)
                {
                    Console.WriteLine("Mục tiêu đã hoàn thành.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Lỗi khi thêm mục tiêu hoàn thành.");
                    MessageBox.Show("Lỗi khi thêm mục tiêu hoàn thành.");
                    return false;
                }
            }
            catch (SqlException sqlEx)
            {
                // Ghi log lỗi SQL
                string errorMessage = $"Lỗi cơ sở dữ liệu: {sqlEx.Message}, Stack Trace: {sqlEx.StackTrace}";
                Console.WriteLine(errorMessage);
                MessageBox.Show($"Lỗi cơ sở dữ liệu: {sqlEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Ghi log lỗi hệ thống
                string errorMessage = $"Lỗi hệ thống: {ex.Message}, Stack Trace: {ex.StackTrace}";
                Console.WriteLine(errorMessage);
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}");
                return false;
            }
        }

        // Xóa tất cả mục tiêu
        public bool ClearAllMucTieu()
        {
            try
            {
                return chieuCaoVaCanNangDAL.ClearAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa tất cả mục tiêu: {ex.Message}");
                throw new Exception("Lỗi khi xóa tất cả mục tiêu.", ex);
            }
        }

        // Lấy danh sách mục tiêu hoàn thành
        public List<MucTieuHoanThanhDTO> GetAllMucTieuHoanThanh()
        {
            try
            {
                return mucTieuHoanThanhDAL.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi lấy danh sách mục tiêu hoàn thành: {ex.Message}");
                throw new Exception("Lỗi khi lấy danh sách mục tiêu hoàn thành.", ex);
            }
        }
    }
}
