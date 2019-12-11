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
using NTD.DAO;
using DevExpress.XtraEditors.Controls;

namespace NTD.GUI.UC
{
    public partial class UcChuyenKho : UserControl
    {
        public UcChuyenKho()
        {
            InitializeComponent();
        }

        NhaCC_BUS ncc = new NhaCC_BUS();
        ThemNguoiDung_BUS tnd = new ThemNguoiDung_BUS();
        KhoHang_BUS khohang = new KhoHang_BUS();
        db db = new db();
        HangHoa_BUS hh = new HangHoa_BUS();
        ChiTietHoaDonNhap_BUS hdn = new ChiTietHoaDonNhap_BUS();
        DonVi_BUS dv = new DonVi_BUS();
        KhachHang_BUS khachHang = new KhachHang_BUS();

        private void groupControl1_Paint(object sender, EventArgs e)
        {
            var dataTable2 = khohang.GetAllData();

            cbKhoXuat.Properties.DataSource = dataTable2;
            cbKhoXuat.Properties.DisplayMember = "Tên";
            cbKhoXuat.Properties.ValueMember = "Mã Mã";

            cbKhoNhan.Properties.DataSource = dataTable2;
            cbKhoNhan.Properties.DisplayMember = "Tên";
            cbKhoNhan.Properties.ValueMember = "Mã Mã";

            var dataTable1 = tnd.GetAllDataNV();
            cbNguoiChuyen.Properties.DataSource = dataTable1;
            cbNguoiChuyen.Properties.DisplayMember = "HoTen";
            cbNguoiChuyen.Properties.ValueMember = "MaNV";

            cbNguoiChuyen.EditValue = dataTable1.Rows[0][0];

            cbNguoiNhan.Properties.DataSource = dataTable1;
            cbNguoiNhan.Properties.DisplayMember = "HoTen";
            cbNguoiNhan.Properties.ValueMember = "MaNV";

            cbNguoiNhan.EditValue = dataTable1.Rows[1][0];

            DateTime today = DateTime.UtcNow.Date;
            cbNgay.DateTime = today;

           

            int sl = db.GetSoLuong("PhieuChuyenKho") + 1;

            string mhd;
            if (sl < 10)
            {
                mhd = "HD00" + sl;
            }
            else
            {
                mhd = "HD0" + sl;
            }
            txtPhieuCK.Text = mhd;

            LookUpMaHang.NullText = @"Chọn mã sản phẩm";
            LookUpEditDonVi.NullText = @"Chọn đơn vị";
            TextEditTenHang.NullText = @"(Click vào đây)";


            var dt = hdn.GetDataSource();

            gridControl1.DataSource = dt;

            loadSP();
            loadDonVi();

            LookUpEditDonVi.BestFitMode = BestFitMode.BestFitResizePopup;
            LookUpMaHang.BestFitMode = BestFitMode.BestFitResizePopup;

        }

        private void loadSP()
        {
            var dt = hh.GetDataSP();
            LookUpMaHang.DataSource = dt;

            LookUpMaHang.ValueMember = "MaSP";
            LookUpMaHang.DisplayMember = "MaSP";

            colMaHang.ColumnEdit = LookUpMaHang;
        }

        private void loadDonVi()
        {
            var dt = dv.GetData();
            LookUpEditDonVi.DataSource = dt;

            LookUpEditDonVi.ValueMember = "MaDonVi";
            LookUpEditDonVi.DisplayMember = "TenDonVi";

            colDonVi.ColumnEdit = LookUpEditDonVi;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaSP")
            {
                var value = gridView1.GetRowCellValue(e.RowHandle, e.Column);
                var dt = hh.GetSPTheoMaHang((string)value);
                if (dt != null)
                {
                    string tenSP = (string)dt.Rows[0]["TenSP"];
                    gridView1.SetRowCellValue(e.RowHandle, "TenSP", tenSP);
                    gridView1.SetRowCellValue(e.RowHandle, "DonVi", dt.Rows[0]["DonVi"]);
                    gridView1.SetRowCellValue(e.RowHandle, "DonGia", dt.Rows[0]["GiaMua"]);
                }
            }
        }
    }
}
