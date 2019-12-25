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
    public class ChiTietChungTuBan_BUS
    {
        DAO_ChiTietChungTuBan ctn = new DAO_ChiTietChungTuBan();

        public DataTable GetDataByMaHD(string maHD)
        {
            return ctn.GetDataByMaHD(maHD);
        }

        public int ThemChiTietChungTu(ChiTietChungTuBan chungtu)
        {
            return ctn.ThemChiTietChungTu(chungtu);
        }
        public DataTable TheoHangHoa()
        {
            return ctn.TheoHangHoa();
        }
        public DataTable TheoHangHoaBan(string tu, string den)
        {
            return ctn.TheoHangHoaBan(tu, den);
        }
    }
}
