using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoDTO
    {
        public DateTime Date { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public float Temperature { get; set; }
        public string BodyStatus { get; set; }
        public float BloodPressure { get; set; }
        public int HeartRate { get; set; }
    }

}
