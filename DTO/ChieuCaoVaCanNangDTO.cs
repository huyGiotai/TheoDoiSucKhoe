using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChieuCaoVaCanNangDTO
    {
        public int Id { get; set; }
        public int MaPhieu { get; set; }
        public string ThoiGian { get; set; }
        public float ChieuCao { get; set; }
        public float CanNang { get; set; }
    }
}
