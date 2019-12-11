using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.DAO
{
    public class DAO_ChungTuMua
    {
        public db db = new db();
        public DataTable GetAllData()
        {
            string sql = "select * from ChungTuMua";
            var rs = db.GetData(sql);

            return rs;
        }

        public int ThemChungTu(ChungTuNhap chungtu)
        {
            string sql = string.Format("insert into [ChungTuMua](MaCT,Ngay,PhieuVietTay,HoaDonVietTay,NhaCungCap,CK,VAT,ThanhToan,GhiChu) Values('{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')"
                , chungtu.MaCT, chungtu.Ngay, chungtu.PhieuVietTay, chungtu.HoaDonVietTay, chungtu.NhaCungCap, chungtu.CK, chungtu.VAT, chungtu.ThanhToan, chungtu.GhiChu);

            var rs = db.ExecuteSQL(sql);

            return rs;
        }
    }
}
