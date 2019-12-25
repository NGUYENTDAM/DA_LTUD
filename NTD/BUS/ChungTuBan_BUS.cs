using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class ChungTuBan_BUS
    {
        DAO_ChungTuBan ctb = new DAO_ChungTuBan();
        public DataTable GetAllData()
        {
            return ctb.GetAllData();
        }

        public int ThemChungTu(ChungTuBan chungtu)
        {
            return ctb.ThemChungTu(chungtu);
        }
        public int DeleteById(string ma)
        {
            return ctb.DeleteById(ma);
        }

        public DataTable TheoChungTuTime(string tu, string den)
        {
            return ctb.TheoChungTuTime(tu, den);
        }
    }
}
