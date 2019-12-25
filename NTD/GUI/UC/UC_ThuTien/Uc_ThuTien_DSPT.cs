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
    public partial class Uc_ThuTien_DSPT : UserControl
    {
        public Uc_ThuTien_DSPT()
        {
            InitializeComponent();
        }
        DanhSachPhieuThu_BUS pt_bus = new DanhSachPhieuThu_BUS();
        private void LoadData()
        {
            var Dt = pt_bus.GetAllData();
            gcDSPT.DataSource = Dt;

        }
        private void LoadTheoTime()
        {
            DateTime tu, den;

            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = pt_bus.DSPTTime_TraTien(sqlFormattedDate, sqlFormattedDate1);

            gcDSPT.DataSource = dt;
        }
        private void Uc_ThuTien_DSPT_Load(object sender, EventArgs e)
        {
            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";
            LoadData();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadTheoTime();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gcDSPT.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = gvDSPT.GetRowCellValue(gvDSPT.FocusedRowHandle, "MaCT").ToString();
            string phieu = gvDSPT.GetRowCellValue(gvDSPT.FocusedRowHandle, "Phieu").ToString();

            if (gvDSPT.GetRowCellValue(gvDSPT.FocusedRowHandle, "Phieu").ToString() != null)
            {
                if (gvDSPT.GetRowCellValue(gvDSPT.FocusedRowHandle, "MaCT").ToString() != null)
                {
                    var rs = pt_bus.DeleteBy_DSPC(ma);
                    pt_bus.XoaDSPC(phieu);
                    if (rs > 0)
                    {
                        LoadData();
                        MessageBox.Show("Delete Successfully!!!!!!!!");
                    }
                }
            }
        }
    }
}
