﻿using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class ChiTietHoaDonNhap_BUS
    {
        DAO_ChiTietHoaDonNhap cthdn = new DAO_ChiTietHoaDonNhap();
        public DataTable GetDataSource()
        {
            return cthdn.GetDataSource();
        }

        public int ThemChiTietHoaDonNhap(ChiTietHoaDonNhap hdn)
        {
            return cthdn.ThemChiTietHoaDonNhap(hdn);
        }

        public DataTable GetDataByMaHD(string maHD)
        {
            return cthdn.GetDataByMaHD(maHD);
        }
    }
}
