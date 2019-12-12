﻿using NTD.DAO;
using NTD.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTD.BUS
{
    public class ChungTuMua_BUS
    {
        DAO_ChungTuMua ctm = new DAO_ChungTuMua();
        public DataTable GetAllData()
        {
            return ctm.GetAllData();
        }
        public int ThemChungTu(ChungTuNhap chungtu)
        {
            return ctm.ThemChungTu(chungtu);
        }
    }
}