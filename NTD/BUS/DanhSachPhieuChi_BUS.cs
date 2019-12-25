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
    public class DanhSachPhieuChi_BUS
    {
        DAO_DanhSachPhieuChi dspc = new DAO_DanhSachPhieuChi();

        public int ThemPC(PhieuChi pc)
        {
            return dspc.ThemDSPC(pc);
        }
        public int DeleteById(string ma)
        {
            return dspc.DeleteById(ma);
        }
        public int DeleteBy_DSPC(string ma)
        {
            return dspc.DeleteBy_DSPC(ma);
        }
        public int XoaDSPC(string ma)
        {
            return dspc.XoaDSPC(ma);
        }
        public DataTable GetAllData()
        {
            return dspc.GetAllData();
        }
        public DataTable DSPPCTime_TraTien(string tu, string den)
        {
            return dspc.DSPPCTime_TraTien(tu, den);
        }
        

    }
}
