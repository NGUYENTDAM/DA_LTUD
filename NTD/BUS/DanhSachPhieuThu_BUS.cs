using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class DanhSachPhieuThu_BUS
    {
        DAO_DanhSachPhieuThu dspc = new DAO_DanhSachPhieuThu();

        public int ThemPT(PhieuThu pc)
        {
            return dspc.ThemDSPT(pc);
        }
        public int DeleteByMaHD(string ma)
        {
            return dspc.DeleteByMaHD(ma);
        }
        public int DeleteBy_DSPC(string ma)
        {
            return dspc.DeleteBy_DSPT(ma);
        }
        public int XoaDSPC(string ma)
        {
            return dspc.XoaDSPC(ma);
        }
        public DataTable GetAllData()
        {
            return dspc.GetAllData();
        }
        public DataTable DSPTTime_TraTien(string tu, string den)
        {
            return dspc.DSPTTime_TraTien(tu, den);
        }
    }
}
