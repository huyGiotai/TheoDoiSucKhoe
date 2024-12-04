using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine("Mục tiêu không hợp lệ.");
                return false;
            }

            try
            {
                return chieuCaoVaCanNangDAL.Add(target);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm mục tiêu: {ex.Message}");
                // Có thể ghi log và ném lại lỗi
                throw new Exception("Lỗi khi thêm mục tiêu.", ex);
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
                return false;
            }

            try
            {
                bool isAdded = mucTieuHoanThanhDAL.Add(completedTarget);
                if (isAdded)
                {
                    bool isDeleted = chieuCaoVaCanNangDAL.Delete(targetId);
                    return isDeleted;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi hoàn thành mục tiêu: {ex.Message}");
                throw new Exception("Lỗi khi hoàn thành mục tiêu.", ex);
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
