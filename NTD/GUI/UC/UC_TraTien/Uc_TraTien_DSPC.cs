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
    public partial class Uc_TraTien_DSPC : UserControl
    {
        public Uc_TraTien_DSPC()
        {
            InitializeComponent();
        }
        DanhSachPhieuChi_BUS pc_bus = new DanhSachPhieuChi_BUS();
        private void LoadData()
        {
            var dt = pc_bus.GetAllData();

            gcDSPC.DataSource = dt;
        }
        private void Uc_TraTien_DSPC_Load(object sender, EventArgs e)
        {
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

            var dt = pc_bus.DSPPCTime_TraTien(sqlFormattedDate, sqlFormattedDate1);

            gcDSPC.DataSource = dt;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadTheoTime();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = gvDSPC.GetRowCellValue(gvDSPC.FocusedRowHandle, "MaCT").ToString();
            string phieu = gvDSPC.GetRowCellValue(gvDSPC.FocusedRowHandle, "Phieu").ToString();

            if (gvDSPC.GetRowCellValue(gvDSPC.FocusedRowHandle, "Phieu").ToString() != null)
            {
                if (gvDSPC.GetRowCellValue(gvDSPC.FocusedRowHandle, "MaCT").ToString() != null)
                {
                    var rs = pc_bus.DeleteBy_DSPC(ma);
                    pc_bus.XoaDSPC(phieu);
                    if (rs > 0)
                    {
                        LoadData();
                        MessageBox.Show("Delete Successfully!!!!!!!!");
                    }
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gcDSPC.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}
