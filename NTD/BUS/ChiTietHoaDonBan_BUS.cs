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
    public class ChiTietHoaDonBan_BUS
    {
        DAO_ChiTietHoaDonBan chiTietHoaDonBan = new DAO_ChiTietHoaDonBan();
        public DataTable GetDataSource()
        {
            return chiTietHoaDonBan.GetDataSource();
        }

        public int ThemChiTietHoaDonBan(ChiTietHoaDonBan hdb)
        {
            return chiTietHoaDonBan.ThemChiTietHoaDonBan(hdb);
        }

        public DataTable GetDataByMaHD(string maHD)
        {
            return chiTietHoaDonBan.GetDataByMaHD(maHD);
        }
    }
}
