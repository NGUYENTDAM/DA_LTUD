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
using NTD.DTO;
using NTD.GUI.frmChucNang;

namespace NTD.GUI.UC
{
    public partial class Uc_ThuTien_DSPCN : UserControl
    {
        public Uc_ThuTien_DSPCN()
        {
            InitializeComponent();
        }
        HoaDonBan_BUS hdb = new HoaDonBan_BUS();
        private void LoadData()
        {
            var dt = hdb.DSPCN_ThuTien();
            gcDSPCN.DataSource = dt;
        }
        private void LoadTheoTime()
        {
            DateTime tu, den;

            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = hdb.DSPCNTime_TraTien(sqlFormattedDate, sqlFormattedDate1);

            gcDSPCN.DataSource = dt;
        }
        private void Uc_ThuTien_DSPCN_Load(object sender, EventArgs e)
        {
            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";
            LoadData();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadTheoTime();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            PhieuThu pt = new PhieuThu()
            {
                TenKH = gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "TenKH").ToString(),
                MaCT = gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "MaHD").ToString(),
                Ngay = DateTime.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "NgayBan").ToString()),
                SoTien = float.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "TongTien").ToString()),
                ConNo = float.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "ConLai").ToString()),
                DaTra = float.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "DaTra").ToString()),
                NhanVien = gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "MaNV").ToString()


            };
            frmLapPhieuThu lp = new frmLapPhieuThu(pt);
            lp.ShowDialog();
            LoadData();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gvDSCN.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}
