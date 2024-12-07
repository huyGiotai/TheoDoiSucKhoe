using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaoCaoDAL
    {
        public BaoCaoDTO GetBaoCaoDataByDate(DateTime date)
        {
            // Giả lập truy vấn CSDL và trả về dữ liệu
            BaoCaoDTO data = new BaoCaoDTO();

            data.Date = date;
            data.Height = 1.75f;
            data.Weight = 70.5f;
            data.Temperature = 36.6f;
            data.BodyStatus = "Normal";
            data.BloodPressure = 120.8f;
            data.HeartRate = 72;

            return data;
        }
    }

}
