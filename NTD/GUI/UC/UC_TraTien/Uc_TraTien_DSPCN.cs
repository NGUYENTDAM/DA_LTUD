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
using NTD.DTO;
using NTD.GUI.frmChucNang;
using DevExpress.XtraEditors;

namespace NTD.GUI.UC
{
    public partial class Uc_TraTien_DSPCN : UserControl
    {
        public Uc_TraTien_DSPCN()
        {
            InitializeComponent();
        }
        HoaDonNhap_BUS hdn = new HoaDonNhap_BUS();
        private void LoadData()
        {
            var dt = hdn.DSPCN_TraTien();

            gcDSPCN.DataSource = dt;
        }
        private void LoadTheoTime()
        {
            DateTime tu, den;



            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = hdn.DSPCNTime_TraTien(sqlFormattedDate, sqlFormattedDate1);

            gcDSPCN.DataSource = dt;
        }
        private void Uc_TraTien_DSPCN_Load(object sender, EventArgs e)
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
            PhieuChi kh = new PhieuChi()
            {
                TenKH = gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "Ten").ToString(),
                MaCT = gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "MaHD").ToString(),
                Ngay = DateTime.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "NgayNhap").ToString()),
                SoTien = float.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "TongTien").ToString()),
                ConNo = float.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "ConLai").ToString()),
                DaTra = float.Parse(gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "DaTra").ToString()),
                NhanVien = gvDSCN.GetRowCellValue(gvDSCN.FocusedRowHandle, "MaNV").ToString()


            };
            frmLapPhieuChi lp = new frmLapPhieuChi(kh);
            lp.ShowDialog();
            LoadData();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gcDSPCN.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}
