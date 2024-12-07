using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BaoCaoBLL
    {
        private BaoCaoDAL dal = new BaoCaoDAL();

        public DataTable GetAll()
        {
            return dal.GetAll();  // Calls DAL to get all reports
        }

        public List<BaoCaoDTO> GetBaoCaoByDate(string selectedDate)
        {
            return dal.GetBaoCaoByDate(selectedDate);  // Calls DAL to filter by date
        }
    }
}
