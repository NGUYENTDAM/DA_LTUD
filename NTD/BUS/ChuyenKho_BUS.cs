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
    public class ChuyenKho_BUS
    {
        DAO_ChuyenKho ck_dao = new DAO_ChuyenKho();
        public int ThemDV(ChuyenKho ck)
        {
            return ck_dao.ThemPhieuChuyenKho(ck);
        }
        public int Update(string k1,string k2)
        {
            return ck_dao.Update(k1,k2);
        }
        public int DeleteById(string ma)
        {
            return ck_dao.DeleteById(ma);
        }
        public DataTable LoadAll()
        {
            return ck_dao.LoadAll();
        }
        public DataTable DSCKTime(string tu, string den)
        {
            return ck_dao.DSCKTime(tu, den);
        }
    }
}
