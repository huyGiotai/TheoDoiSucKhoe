using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaoCaoBLL
    {
        private BaoCaoDAL _baoCaoDAL;

        public BaoCaoBLL()
        {
            _baoCaoDAL = new BaoCaoDAL();
        }

        public BaoCaoDTO GetBaoCaoData(DateTime date)
        {
            return _baoCaoDAL.GetBaoCaoDataByDate(date);
        }

        public float CalculateBMI(float height, float weight)
        {
            return weight / (height * height);
        }

        public string GetBMIStatus(float bmi)
        {
            if (bmi < 18.5) return "Underweight";
            if (bmi < 24.9) return "Normal weight";
            if (bmi < 29.9) return "Overweight";
            return "Obesity";
        }

        public string GetBloodPressureStatus(float bloodPressure)
        {
            if (bloodPressure < 120) return "Normal";
            if (bloodPressure < 130) return "Elevated";
            if (bloodPressure < 140) return "Hypertension Stage 1";
            return "Hypertension Stage 2";
        }

        public string GetHeartRateStatus(int heartRate)
        {
            if (heartRate < 60) return "Low";
            if (heartRate <= 100) return "Normal";
            return "High";
        }

        public string GetTemperatureStatus(float temperature)
        {
            if (temperature < 36) return "Hypothermia";
            if (temperature < 37.5) return "Normal";
            return "Fever";
        }
    }

}
