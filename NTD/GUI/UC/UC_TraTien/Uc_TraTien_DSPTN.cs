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
using NTD.GUI.frmChucNang;
using NTD.DTO;
using DevExpress.XtraEditors;

namespace NTD.GUI.UC
{
    public partial class Uc_TraTien_DSPTN : UserControl
    {
        public Uc_TraTien_DSPTN()
        {
            InitializeComponent();
        }
        HoaDonNhap_BUS hdn = new HoaDonNhap_BUS();
        private void LoadData()
        {
            var dt = hdn.DSPTN_TraTien();

            gcDSPTN.DataSource = dt;
        }

        private void LoadTheoTime()
        {
            DateTime tu, den;

           

            tu = DateTime.Parse( dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = hdn.DSPTNTime_TraTien(sqlFormattedDate, sqlFormattedDate1);

            gcDSPTN.DataSource = dt;
        }
        private void Uc_TraTien_DSPTN_Load(object sender, EventArgs e)
        {
            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";
            LoadData();
            //LoadTheoTime();
        }

        private void btnLapPhieuChi_Click(object sender, EventArgs e)
        {
            PhieuChi kh = new PhieuChi()
            {
                TenKH = gvDSPTN.GetRowCellValue(gvDSPTN.FocusedRowHandle, "Ten").ToString(),
                MaCT = gvDSPTN.GetRowCellValue(gvDSPTN.FocusedRowHandle, "MaHD").ToString(),
                Ngay = DateTime.Parse( gvDSPTN.GetRowCellValue(gvDSPTN.FocusedRowHandle, "NgayNhap").ToString()),
                SoTien = float.Parse(gvDSPTN.GetRowCellValue(gvDSPTN.FocusedRowHandle, "TongTien").ToString()),
                ConNo = float.Parse(gvDSPTN.GetRowCellValue(gvDSPTN.FocusedRowHandle, "ConLai").ToString()),
                DaTra = float.Parse(gvDSPTN.GetRowCellValue(gvDSPTN.FocusedRowHandle, "DaTra").ToString()),
                NhanVien = gvDSPTN.GetRowCellValue(gvDSPTN.FocusedRowHandle, "MaNV").ToString()


            };
            frmLapPhieuChi lp = new frmLapPhieuChi(kh);
            lp.ShowDialog();
            LoadData();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadTheoTime();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gcDSPTN.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}
