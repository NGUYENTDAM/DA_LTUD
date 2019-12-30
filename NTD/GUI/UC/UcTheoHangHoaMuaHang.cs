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
    public partial class UcTheoHangHoaMuaHang : UserControl
    {
        public UcTheoHangHoaMuaHang()
        {
            InitializeComponent();
        }
        ChiTietChungTuNhap_BUS ct = new ChiTietChungTuNhap_BUS();
        private void LoadData()
        {
            DataTable dt = ct.TheoHangHoa();
            gcTheoHangHoa.DataSource = dt;
        }

        private void LoadTheoTime()
        {
            DateTime tu, den;

            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = ct.TheoHangHoaTime(sqlFormattedDate, sqlFormattedDate1);

            gcTheoHangHoa.DataSource = dt;
        }
        private void UcTheoHangHoa_Load(object sender, EventArgs e)
        {
            ucChungNang.Controls["btnXem"].Click += Xem;
            ucChungNang.Controls["btnTaoMoi"].Click += TaoMoi;
            ucChungNang.Controls["btnDong"].Click += Dong;
            ucChungNang.Controls["btnXoa"].Click += Xoa;
            ucChungNang.Controls["btnXuat"].Click += Xuat;

            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";


            LoadData();
        }

        private void Xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gvTheoHangHoa.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void Xoa(object sender, EventArgs e)
        {
            string ma = gvTheoHangHoa.GetRowCellValue(gvTheoHangHoa.FocusedRowHandle, "MaCT").ToString();

            if (gvTheoHangHoa.GetRowCellValue(gvTheoHangHoa.FocusedRowHandle, "MaCT").ToString() != null)
            {
                var rs = ct.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void Dong(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void TaoMoi(object sender, EventArgs e)
        {
            frmMuaHang muaHang = new frmMuaHang();
            muaHang.ShowDialog();
            muaHang.MdiParent = this.ParentForm.ParentForm.ParentForm;
        }

        private void Xem(object sender, EventArgs e)
        {
            LoadTheoTime();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
