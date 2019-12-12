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
        private void UcTheoHangHoa_Load(object sender, EventArgs e)
        {
            ucChungNang.Controls["btnXem"].Click += Xem;
            ucChungNang.Controls["btnTaoMoi"].Click += TaoMoi;
            ucChungNang.Controls["btnDong"].Click += Dong;
            ucChungNang.Controls["btnXoa"].Click += Xoa;
            ucChungNang.Controls["btnXuat"].Click += Xuat;

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
            
        }

        private void TaoMoi(object sender, EventArgs e)
        {
            //PhieuNhapHang pbh = new PhieuNhapHang();
            //frmMuaHang mh = new frmMuaHang();
       
            //pbh.Dock = DockStyle.Fill;
            //ucBanHang1.Controls.Clear();
            //ucBanHang1.Controls.Add(pbh);
            //ucBanHang1.Dock = DockStyle.Fill;

        }

        private void Xem(object sender, EventArgs e)
        {
            LoadData();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
