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
    public partial class UcTheoHangHoaBanHang : UserControl
    {
        public UcTheoHangHoaBanHang()
        {
            InitializeComponent();
        }     
        ChiTietChungTuBan_BUS ctb = new ChiTietChungTuBan_BUS();
        private void LoadData()
        {
            DataTable dt = ctb.TheoHangHoa();
            gcTheoHangHoa.DataSource = dt;
        }
      

        private void Xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gvTheoHangHoa.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void Xoa(object sender, EventArgs e)
        {
            //string ma = gvTheoHangHoa.GetRowCellValue(gvTheoHangHoa.FocusedRowHandle, "MaCT").ToString();

            //if (gvTheoHangHoa.GetRowCellValue(gvTheoHangHoa.FocusedRowHandle, "MaCT").ToString() != null)
            //{
            //    var rs = ctb.DeleteById(ma);

            //    if (rs > 0)
            //    {
            //        LoadData();
            //        MessageBox.Show("Delete Successfully!!!!!!!!");
            //    }
            //}
        }

        private void Dong(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void TaoMoi(object sender, EventArgs e)
        {
            frmBanHang banHang = new frmBanHang();
            banHang.ShowDialog();
            banHang.MdiParent = this.ParentForm.ParentForm.ParentForm;

        }
        private void LoadTheoTime()
        {
            DateTime tu, den;

            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = ctb.TheoHangHoaBan(sqlFormattedDate, sqlFormattedDate1);

            gcTheoHangHoa.DataSource = dt;
        }
        private void Xem(object sender, EventArgs e)
        {
            LoadTheoTime();
        }

        private void UcTheoHangHoaBanHang_Load(object sender, EventArgs e)
        {
            ucChucNang.Controls["btnXem"].Click += Xem;
            ucChucNang.Controls["btnTaoMoi"].Click += TaoMoi;
            ucChucNang.Controls["btnDong"].Click += Dong;
            ucChucNang.Controls["btnXoa"].Click += Xoa;
            ucChucNang.Controls["btnXuat"].Click += Xuat;

            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";

            LoadData();
        }
    }
}
