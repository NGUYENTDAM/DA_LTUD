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
    public class ChiTietChungTuNhap_BUS
    {
        DAO_ChiTietChungTuNhap ctn = new DAO_ChiTietChungTuNhap();

        public DataTable GetDataByMaHD(string maHD)
        {
            return ctn.GetDataByMaHD(maHD);
        }

        public int ThemChiTietChungTu(ChiTietChungTuNhap chungtu)
        {
            return ctn.ThemChiTietChungTu(chungtu);
        }

        public DataTable TheoHangHoa()
        {
            return ctn.TheoHangHoa();
        }
        public int DeleteById(string ma)
        {
            return ctn.DeleteById(ma);
        }
        public DataTable TheoHangHoaTime(string tu, string den)
        {
            return ctn.TheoHangHoaTime(tu, den);
        }
    }
}
