﻿using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_ChiTietChungTuBan
    {
        db db = new db();
        public DataTable GetDataByMaHD(string maHD)
        {
            string sql = "select * from ChiTietChungTuBan hd where hd.MaHD = '" + maHD + "'";
            var rs = db.GetData(sql);

            return rs;
        }

        public int ThemChiTietChungTu(ChiTietChungTuBan chungtu)
        {
            string sql = string.Format("insert into [ChiTietChungTuBan](MaCT,MaHang,TenHang,KhoHang,DVT,SoLuong,DonGia,ThanhTien) Values('{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')"
                , chungtu.MaCT, chungtu.MaHang, chungtu.TenHang, chungtu.KhoHang, chungtu.DVT, chungtu.SoLuong, chungtu.DonGia, chungtu.ThanhTien);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}