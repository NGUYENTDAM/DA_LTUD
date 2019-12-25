using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_DanhSachPhieuThu
    {
        public db db = new db();
        public int ThemDSPT(PhieuThu pc)
        {
            string sql = string.Format(" insert into [DanhSachPhieuThu] Values('{0}','{1}','{2}',N'{3}',{4},{5},{6},'{7}','{8}')"
                , pc.Phieu,  pc.Ngay ,pc.MaCT, pc.TenKH, pc.SoTien, pc.ConNo, pc.DaTra, pc.NhanVien, pc.GhiChu);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteByMaHD(string ma)
        {
            string sql = string.Format("update HoaDonBan set IsCheck = 0 where MaHD = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteBy_DSPT(string ma)
        {
            string sql = string.Format("update HoaDonBan set IsCheck = 1 where MaHD = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int XoaDSPC(string ma)
        {
            string sql = string.Format("delete DanhSachPhieuThu where Phieu = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public DataTable GetAllData()
        {
            string sql = "select Phieu,MaCT,Ngay,KhachHang,SoTien,GhiChu from DanhSachPhieuThu";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable DSPTTime_TraTien(string tu,string den)
        {
            string sql = string.Format("select Phieu,MaCT,Ngay,KhachHang,SoTien,GhiChu from DanhSachPhieuThu where Ngay between '{0}' and '{1}'", tu,den);
            var rs = db.GetData(sql);

            return rs;
        }
    }
}
