using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_HoaDonBan
    {
        public db db = new db();

        public DataTable GetAllData()
        {
            string sql = "select * from HoaDonBan hdn";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable DSPCN_ThuTien()
        {
            string sql = "select hd.MaHD,hd.NgayBan,dk.MoTa,hd.MaKH,hd.TenKH, hd.TongTien,hd.DaTra,hd.ConLai,hd.MaNV " +
                "from HoaDonBan hd ,DieuKhoan dk where hd.DieuKhoan = 'CN'  and dk.MaDieuKhoan = hd.DieuKhoan and hd.IsCheck =1";
            var rs = db.GetData(sql);

            return rs;
        }
        // Theo Time
        public DataTable DSPTNTime_TraTien(string tu,string den)
        {
            string sql = string.Format("select hd.MaHD,hd.NgayBan,dk.MoTa,hd.MaKH,hd.TenKH, hd.TongTien,hd.DaTra,hd.ConLai,hd.MaNV " +
                "from HoaDonBan hd ,DieuKhoan dk where hd.DieuKhoan = 'CN'  and dk.MaDieuKhoan = hd.DieuKhoan and hd.IsCheck =1 and hd.NgayBan between '{0}' and '{1}'", tu, den);
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable DSPTN_ThuTien()
        {
            string sql = "select hd.MaHD,hd.NgayBan,dk.MoTa,hd.MaKH,hd.TenKH,hd.MaNV, hd.TongTien,hd.ConLai,hd.DaTra " +
                "from HoaDonBan hd ,DieuKhoan dk where hd.DieuKhoan = 'TN'  and dk.MaDieuKhoan = hd.DieuKhoan and hd.IsCheck =1 ";
            var rs = db.GetData(sql);

            return rs;
        }
        // Theo time
        public DataTable DSPCNTime_TraTien(string tu,string den)
        {
            string sql = string.Format("select hd.MaHD,hd.NgayBan,dk.MoTa,hd.MaKH,hd.TenKH,hd.MaNV, hd.TongTien,hd.ConLai,hd.DaTra " +
                "from HoaDonBan hd ,DieuKhoan dk where hd.DieuKhoan = 'TN'  and dk.MaDieuKhoan = hd.DieuKhoan and hd.IsCheck =1 and hd.NgayBan between '{0}' and '{1}'", tu,den);
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable GetDataScource()
        {
            string sql = "select hdn.MaHD ,hdn.NgayNhap, hdn.MaNCC, hdn.TenNCC, hdn.TongTien, hdn.DaTra, hdn.ConLai, hdn.DienGiai from HoaDonNhap hdn where hdn.MaHD = 0";
            var rs = db.GetData(sql);

            return rs;
        }

        public int ThemHoaDonBan(HoaDonBan hdb)
        {
            string sql = string.Format("insert into [HoaDonBan](MaHD,MaKH,TenKH,MaNV,NgayBan,TongTien,DaTra,ConLai,DieuKhoan,HinhThuc,DienGiai) Values('{0}', N'{1}',N'{2}','{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')"
                , hdb.MaHoaDon, hdb.MaKhachHang, hdb.TenKhachHang, hdb.MaNhanVien, hdb.NgayBan, hdb.TongTien, hdb.DaTra, hdb.ConLai, hdb.DieuKhoan, hdb.HinhThuc, hdb.DienGiai);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }

    }
}
