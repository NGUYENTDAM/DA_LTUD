using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_ChuyenKho
    {
        public db db = new db();
        public int ThemPhieuChuyenKho(ChuyenKho ck)
        {
            string sql = string.Format("insert into [PhieuChuyenKho] Values('{0}', '{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", ck.Phieu,ck.Ngay,ck.KhoXuat,ck.KhoNhan,ck.NguoiNhan,ck.NguoiGui,ck.GhiChu);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int Update(string k1,string k2)
        {
            string sql =
 string.Format("exec ChuyenKho '{0}','{1}'",k1,k2);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string ma)
        {
            string sql = string.Format("Delete PhieuChuyenKho where MaPhieu='{0}'",ma);
            var rs = db.ExecuteSQL(sql);
            return rs;
        }
        public DataTable LoadAll()
        {
            string sql = "select MaPhieu,Ngay,KhoXuatHang,KhoNhapHang,NguoiNhan,NguoiGui,GhiChu from PhieuChuyenKho";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable DSCKTime(string tu,string den)
        {
            string sql = string.Format("select MaPhieu,Ngay,KhoXuatHang,KhoNhapHang,NguoiNhan,NguoiGui,GhiChu from PhieuChuyenKho where Ngay between '{0}' and '{1}'", tu, den);
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
