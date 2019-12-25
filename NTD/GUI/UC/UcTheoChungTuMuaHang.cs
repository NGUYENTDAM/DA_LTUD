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
using DevExpress.XtraEditors;

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

        private void LoadData()
        {
            DataTable dt1 = chungTu.GetAllData();

            grvMain.GridControl.DataSource = dt1;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            ucChucNang.Controls["btnXem"].Click += Xem;
            ucChucNang.Controls["btnXoa"].Click += Xoa;
            ucChucNang.Controls["btnXuat"].Click += Xuat;
            ucChucNang.Controls["btnDong"].Click += Dong;

            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";


            LoadData();
           
        }
        private void LoadTheoTime()
        {
            DateTime tu, den;

            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = chungTu.TheoChungTuTime(sqlFormattedDate, sqlFormattedDate1);

            gridControl1.DataSource = dt;
        }


        private void Dong(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void Xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            grvMain.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void Xoa(object sender, EventArgs e)
        {
            string ma = grvMain.GetRowCellValue(grvMain.FocusedRowHandle, "MaCT").ToString();

            if (grvMain.GetRowCellValue(grvMain.FocusedRowHandle, "MaCT").ToString() != null)
            {
                var rs = chungTu.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void Xem(object sender, EventArgs e)
        {
            LoadTheoTime();
        }

        private void grvMain_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {

        }
        private void grvMain_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {

            DataTable dt2 = chungTu.ChiTietPhieuTheoChungTu();

            grvDetail.GridControl.DataSource = dt2;

            //e.ChildList =grvDetail.

        }

        private void grvMain_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }

        private void grvMain_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

       
    }
}
