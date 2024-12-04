using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiSoSucKhoeDTO
    {
        public int MaPhieu { get; set; }
        public int UserID { get; set; }
        public string Ngay { get; set; } // Sử dụng string thay vì DateTime
        public string TinhTrangCoThe { get; set; }
        public string GioiTinh { get; set; }
        public float ChieuCao { get; set; }
        public float CanNang { get; set; }
        public string HuyetAp { get; set; }
        public int NhipTim { get; set; }
        public float LuongDuongMau { get; set; }
        public float NhietDoCoThe { get; set; }
    }
}
