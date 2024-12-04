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
    public class ChiSoSuckhoeBLL
    {
        private readonly ChiSoSucKhoeDAL dal = new ChiSoSucKhoeDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public bool AddChiSo(ChiSoSucKhoeDTO chiSo)
        {
            return dal.Insert(chiSo);
        }

        public bool UpdateChiSo(ChiSoSucKhoeDTO chiSo)
        {
            return dal.Update(chiSo);
        }

        public bool DeleteChiSo(int maPhieu)
        {
            return dal.Delete(maPhieu);
        }
    }
}
