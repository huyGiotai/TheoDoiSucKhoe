using System;
using DAL;
using DTO;


namespace BLL
{
    public class BaoCaoBLL
    {
        private BaoCaoDAL baoCaoDAL;

        public BaoCaoBLL()
        {
            baoCaoDAL = new BaoCaoDAL();
        }

        public BaoCaoDTO GetBaoCaoData(DateTime ngay)
        {
            return baoCaoDAL.GetBaoCaoByDate(ngay);
        }

        public float CalculateBMI(double height, double weight)
        {
            if (height <= 0) return 0;
            return (float)(weight / ((height / 100) * (height / 100))); // Chiều cao tính bằng cm -> m
        }

        public string GetBMIStatus(float bmi)
        {
            if (bmi < 18.5) return "Thiếu cân";
            else if (bmi >= 18.5 && bmi < 24.9) return "Bình thường";
            else if (bmi >= 25 && bmi < 29.9) return "Thừa cân";
            else return "Béo phì";
        }

        public string GetBloodPressureStatus(string bloodPressure)
        {
            // Giả sử định dạng "120/80"
            string[] parts = bloodPressure.Split('/');
            if (parts.Length != 2) return "Không xác định";

            int systolic = int.Parse(parts[0]);
            int diastolic = int.Parse(parts[1]);

            if (systolic < 90 || diastolic < 60) return "Huyết áp thấp";
            if (systolic > 140 || diastolic > 90) return "Huyết áp cao";
            return "Huyết áp bình thường";
        }

        public string GetHeartRateStatus(int heartRate)
        {
            if (heartRate < 60) return "Nhịp tim thấp";
            if (heartRate > 100) return "Nhịp tim cao";
            return "Nhịp tim bình thường";
        }

        public string GetTemperatureStatus(double temperature)
        {
            if (temperature < 36.0) return "Hạ thân nhiệt";
            if (temperature > 37.5) return "Sốt";
            return "Nhiệt độ bình thường";
        }
    }
}
