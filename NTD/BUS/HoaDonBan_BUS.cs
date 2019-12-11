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
    public class HoaDonBan_BUS
    {
        DAO_HoaDonBan hoaDonBan = new DAO_HoaDonBan();
        public DataTable GetAllData()
        {
            return hoaDonBan.GetAllData();
        }

        public DataTable GetDataScource()
        {
            return hoaDonBan.GetDataScource();
        }

        public int ThemHoaDonBan(HoaDonBan hdb)
        {
            return hoaDonBan.ThemHoaDonBan(hdb);
        }
    }
}
