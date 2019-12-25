using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_DanhSachPhieuChi
    {
        public db db = new db();
        public int ThemDSPC(PhieuChi pc)
        {
            string sql = string.Format(" insert into [DanhSachPhieuChi] Values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}','{8}')"
                , pc.Phieu,pc.MaCT,pc.Ngay,pc.TenKH,pc.SoTien,pc.ConNo,pc.DaTra,pc.NhanVien,pc.GhiChu);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteById(string ma)
        {
            string sql = string.Format("update HoaDonNhap set IsCheck = 0 where MaHD = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int DeleteBy_DSPC(string ma)
        {
            string sql = string.Format("update HoaDonNhap set IsCheck = 1 where MaHD = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public int XoaDSPC(string ma)
        {
            string sql = string.Format("delete DanhSachPhieuChi where Phieu = '{0}'", ma);
            var rs = db.ExecuteSQL(sql);

            return rs;
        }
        public DataTable GetAllData()
        {
            string sql = "select Phieu,MaCT,Ngay,KhachHang,SoTien,GhiChu from DanhSachPhieuChi";
            var rs = db.GetData(sql);

            return rs;
        }
        public DataTable DSPPCTime_TraTien(string tu,string den)
        {
            string sql = string.Format("select Phieu,MaCT,Ngay,KhachHang,SoTien,GhiChu from DanhSachPhieuChi where Ngay between '{0}' and '{1}'",tu,den);
            var rs = db.GetData(sql);

            return rs;
        }
        
    }
}
