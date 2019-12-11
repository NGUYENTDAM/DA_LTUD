using NTD.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class HinhThuc_BUS
    {
        DAO_HinhThuc ht = new DAO_HinhThuc();
        public DataTable GetAllData()
        {
            return ht.GetAllData();
        }
    }
}
