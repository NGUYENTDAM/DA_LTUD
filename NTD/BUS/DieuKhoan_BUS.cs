using NTD.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class DieuKhoan_BUS
    {
        DAO_DieuKhoan dk = new DAO_DieuKhoan();
        public DataTable GetAllData()
        {
            return dk.GetAllData();
        }
    }
}
