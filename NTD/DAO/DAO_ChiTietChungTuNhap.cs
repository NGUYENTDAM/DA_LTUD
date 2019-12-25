using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_ChiTietChungTuNhap
    {
        db db = new db();
        public DataTable GetDataByMaHD(string maHD)
        {
            string sql = "select * from ChiTietChungTuNhap hd where hd.MaHD = '" + maHD + "'";
            var rs = db.GetData(sql);

            return rs;
            
        }
        public DataTable TheoHangHoa()
        {
            string sql = "select ct.MaCT,ctm.Ngay,ctm.NhaCungCap,ct.MaHang,ct.TenHang,ct.DVT,ct.KhoHang,ct.SoLuong,ct.DonGia ,ct.ThanhTien from ChiTietChungTuMua ct , ChungTuMua ctm where ct.MaCT = ctm.MaCT";
            var rs = db.GetData(sql);

            return rs;
        }
        //Time
        public DataTable TheoHangHoaTime(string tu,string den)
        {
            string sql = string.Format("select ct.MaCT,ctm.Ngay,ctm.NhaCungCap,ct.MaHang,ct.TenHang,ct.DVT,ct.KhoHang,ct.SoLuong,ct.DonGia ,ct.ThanhTien from ChiTietChungTuMua ct , ChungTuMua ctm where ct.MaCT = ctm.MaCT and ctm.Ngay between '{0}' and '{1}'", tu, den);
            var rs = db.GetData(sql);

            return rs;
        }
        public int DeleteById(string ma)
        {
            string sql = string.Format("Delete from ChiTietChungTuMua Where MaCT = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }

        public int ThemChiTietChungTu(ChiTietChungTuNhap chungtu)
        {
            string sql = string.Format("insert into [ChiTietChungTuMua](MaCT,MaHang,TenHang,KhoHang,DVT,SoLuong,DonGia,ThanhTien) Values('{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')"
                , chungtu.MaCT, chungtu.MaHang, chungtu.TenHang, chungtu.KhoHang, chungtu.DVT, chungtu.SoLuong, chungtu.DonGia, chungtu.ThanhTien);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
