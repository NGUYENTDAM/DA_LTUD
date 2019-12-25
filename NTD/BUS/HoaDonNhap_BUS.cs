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
    public class HoaDonNhap_BUS
    {
        DAO_HoaDonNhap hoaDonNhap = new DAO_HoaDonNhap();
        public int ThemHoaDonNhap(HoaDonNhap hdn)
        {
            return hoaDonNhap.ThemHoaDonNhap(hdn);
        }
        public DataTable GetAllData ()
        {
            return hoaDonNhap.GetAllData();

        }
        public DataTable DSPTN_TraTien()
        {
            return hoaDonNhap.DSPTN_TraTien();
        }
        public DataTable DSPTNTime_TraTien(string tu, string den)
        {
            return hoaDonNhap.DSPTNTime_TraTien(tu,den);
        }
        public DataTable DSPCNTime_TraTien(string tu, string den)
        {
            return hoaDonNhap.DSPCNTime_TraTien(tu, den);
        }
        public DataTable DSPCN_TraTien()
        {
            return hoaDonNhap.DSPCN_TraTien();
        }

    }
}
