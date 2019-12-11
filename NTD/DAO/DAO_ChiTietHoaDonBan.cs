using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_ChiTietHoaDonBan
    {
        public db db = new db();

        public DataTable GetDataSource()
        {
            string mahd = "HD00";
            string sql = "select hdn.MaSP, hdn.TenSP, hdn.DonVi, hdn.SoLuong, hdn.DonGia, hdn.ThanhTien, hdn.GhiChu from ChiTietHoaDonBan hdn where hdn.MaHD = '" + mahd + "'";
            var rs = db.GetData(sql);

            return rs;
        }

        public int ThemChiTietHoaDonBan(ChiTietHoaDonBan hdb)
        {
            string sql = string.Format("insert into [ChiTietHoaDonBan](MaHD,MaSP,TenSP,DonVi,SoLuong,DonGia,ThanhTien,GhiChu) Values('{0}', N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}',N'{7}')"
                , hdb.MaHoaDon, hdb.MaSanPham, hdb.TenSanPham, hdb.DonVi, hdb.SoLuong, hdb.DonGia, hdb.ThanhTien, hdb.GhiChu);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public DataTable GetDataByMaHD(string maHD)
        {
            string sql = "select hd.MaSP, hd.TenSP, hd.DonVi, hd.SoLuong, hd.DonGia, hd.ThanhTien, hd.GhiChu from ChiTietHoaDonBan hd where hd.MaHD = '" + maHD + "'";
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
