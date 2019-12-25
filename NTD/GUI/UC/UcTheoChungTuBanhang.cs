using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NTD.BUS;

namespace NTD.GUI.UC
{
    public partial class UcTheoChungTuBanhang : UserControl
    {
        public UcTheoChungTuBanhang()
        {
            InitializeComponent();
        }

        ChungTuBan_BUS ctb = new ChungTuBan_BUS();

        //ChiTietChungTuNhap_BUS chiTietChungTu = new ChiTietChungTuNhap_BUS();
        ChiTietChungTuBan_BUS chitiet = new ChiTietChungTuBan_BUS();

        private void LoadData()
        {
            DataTable dt1 = ctb.GetAllData();

            grvMain.GridControl.DataSource = dt1;
        }

        private void LoadTheoTime()
        {
            DateTime tu, den;

            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = ctb.TheoChungTuTime(sqlFormattedDate, sqlFormattedDate1);

            grvMain.GridControl.DataSource = dt;
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
                var rs = ctb.DeleteById(ma);

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

        private void UcTheoChungTuBanhang_Load(object sender, EventArgs e)
        {
            ucChucNang.Controls["btnXem"].Click += Xem;
            ucChucNang.Controls["btnXoa"].Click += Xoa;
            ucChucNang.Controls["btnXuat"].Click += Xuat;
            ucChucNang.Controls["btnDong"].Click += Dong;
            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";

            LoadData();
        }

        private void grvMain_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void grvMain_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
    }
}
