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
        
    }
}
