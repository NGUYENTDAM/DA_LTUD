using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTD.BUS;

namespace NTD.GUI.UC
{
    public partial class UcTheoChungTuMuaHang : UserControl
    {
        public UcTheoChungTuMuaHang()
        {
            InitializeComponent();
        }

        ChungTuMua_BUS chungTu = new ChungTuMua_BUS();
        ChiTietChungTuNhap_BUS chiTietChungTu = new ChiTietChungTuNhap_BUS();

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt1 = chungTu.GetAllData();

            //DataTable dt2 = chiTietChungTu.();

            grvMain.GridControl.DataSource = dt1;
            //grvDetail.GridControl.DataSource = dt1;
        }

        private void grvMain_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            DataTable dt1 = chungTu.GetAllData();
            grvDetail.GridControl.DataSource = dt1;

        }

        private void grvMain_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
    }
}
