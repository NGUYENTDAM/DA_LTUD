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
        public DataTable DSPCN_ThuTien()
        {
            return hoaDonBan.DSPCN_ThuTien();
        }
        public DataTable DSPTN_ThuTien()
        {
            return hoaDonBan.DSPTN_ThuTien();
        }
        public DataTable GetDataScource()
        {
            return hoaDonBan.GetDataScource();
        }

        public int ThemHoaDonBan(HoaDonBan hdb)
        {
            return hoaDonBan.ThemHoaDonBan(hdb);
        }
        
        public DataTable DSPTNTime_TraTien(string tu, string den)
        {
            return hoaDonBan.DSPTNTime_TraTien(tu, den);
        }
        public DataTable DSPCNTime_TraTien(string tu, string den)
        {
            return hoaDonBan.DSPCNTime_TraTien(tu, den);
        }
    }
}
