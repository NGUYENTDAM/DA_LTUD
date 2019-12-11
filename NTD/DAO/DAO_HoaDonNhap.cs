﻿using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_HoaDonNhap
    {
        public db db = new db();

        public DataTable GetAllData()
        {
            string sql = "select * from HoaDonNhap hdn";
            var rs = db.GetData(sql);

            return rs;
        }

        public DataTable GetDataScource()
        {
            string sql = "select hdn.MaHD ,hdn.NgayNhap, hdn.MaNCC, hdn.TenNCC, hdn.TongTien, hdn.DaTra, hdn.ConLai, hdn.DienGiai from HoaDonNhap hdn where hdn.MaHD = 0";
            var rs = db.GetData(sql);

            return rs;
        }

        public int ThemHoaDonNhap(HoaDonNhap hdn)
        {
            string sql = string.Format("insert into [HoaDonNhap](MaHD,MaNCC,TenNCC,MaNV,NgayNhap,TongTien,DaTra,ConLai,DieuKhoan,HinhThuc,DienGiai) Values('{0}', N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')"
                , hdn.MaHoaDon, hdn.MaNCC, hdn.TenNCC, hdn.MaNhanVien, hdn.NgayMua, hdn.TongTien, hdn.DaTra, hdn.ConLai, hdn.DieuKhoan, hdn.HinhThuc, hdn.DienGiai);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
