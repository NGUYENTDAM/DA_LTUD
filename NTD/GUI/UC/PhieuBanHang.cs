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
using System.Globalization;
using NTD.DTO;

namespace NTD.GUI
{
    public partial class PhieuBanHang : UserControl
    {
        public PhieuBanHang()
        {
            InitializeComponent();
        }

        NhaCC_BUS ncc = new NhaCC_BUS();
        ThemNguoiDung_BUS tnd = new ThemNguoiDung_BUS();
        KhoHang_BUS khohang = new KhoHang_BUS();
        db db = new db();
        HangHoa_BUS hh = new HangHoa_BUS();
        ChiTietHoaDonBan_BUS cthdb_bus = new ChiTietHoaDonBan_BUS();
        DonVi_BUS dv = new DonVi_BUS();
        KhachHang_BUS khachHang = new KhachHang_BUS();
        DieuKhoan_BUS dieukhoan = new DieuKhoan_BUS();
        HinhThuc_BUS hinhthuc = new HinhThuc_BUS();
        HoaDonBan_BUS hoaDonBan_BUS = new HoaDonBan_BUS();
        ChungTuBan_BUS chungTuBan = new ChungTuBan_BUS();
        ChiTietChungTuBan_BUS chiTietChungTu = new ChiTietChungTuBan_BUS();

        int sl = 0;
        decimal soluong = 0;
        decimal thanhtien = 0;
        decimal dongia = 0;
        decimal ck = 0;
        decimal vat = 0;


        private void groupControl1_Paint(object sender, EventArgs e)
        {
            var table = khachHang.GetAllData();

            cbTenKH.Properties.DataSource = table;
            cbTenKH.Properties.DisplayMember = "Tên khách hàng";
            cbTenKH.Properties.ValueMember = "Mã KH";

            var dataTable1 = tnd.GetAllDataNV();
            cbNhanVien.Properties.DataSource = dataTable1;
            cbNhanVien.Properties.DisplayMember = "HoTen";
            cbNhanVien.Properties.ValueMember = "MaNV";

            cbNhanVien.EditValue = dataTable1.Rows[0][0];

            DateTime today = DateTime.UtcNow.Date;
            cbNgay.DateTime = today;

            var dataTable2 = khohang.GetAllData();
            cbKhoHang.Properties.DataSource = dataTable2;
            cbKhoHang.Properties.DisplayMember = "Tên";
            cbKhoHang.Properties.ValueMember = "Mã";

            cbKhoHang.EditValue = dataTable2.Rows[0][0];

            int sl = db.GetSoLuong("HoaDonBan") + 1;

            string mhd;
            if (sl < 10)
            {
                mhd = "HDB00" + sl;
            }
            else
            {
                mhd = "HDB0" + sl;
            }
            txtMaPhieu.Text = mhd;

            LookupEditMaHang.NullText = @"Chọn mã sản phẩm";
            LookUpDonVi.NullText = @"Chọn đơn vị";
            TextEditTenSP.NullText = @"(Click vào đây)";


            var dt = cthdb_bus.GetDataSource();

            gridControl1.DataSource = dt;

            loadSP();
            loadDonVi();

            LookUpDonVi.BestFitMode = BestFitMode.BestFitResizePopup;
            LookupEditMaHang.BestFitMode = BestFitMode.BestFitResizePopup;

            txtVAT.EditValue = 10;
            txtCK.EditValue = 0;

            DataTable dt2 = dieukhoan.GetAllData();
            cbDieuKhoan.Properties.DataSource = dt2;
            cbDieuKhoan.Properties.DisplayMember = "MoTa";
            cbDieuKhoan.Properties.ValueMember = "MaDieuKhoan";
            cbDieuKhoan.EditValue = dt2.Rows[0][0];

            DataTable dt3 = hinhthuc.GetAllData();
            cbHinhThuc.Properties.DataSource = dt3;
            cbHinhThuc.Properties.DisplayMember = "MoTa";
            cbHinhThuc.Properties.ValueMember = "MaHinhThuc";
            cbHinhThuc.EditValue = dt3.Rows[0][0];
        }

        private void loadSP()
        {
            var dt = hh.GetDataSP();
            LookupEditMaHang.DataSource = dt;

            LookupEditMaHang.ValueMember = "MaSP";
            LookupEditMaHang.DisplayMember = "MaSP";

            colMaHang.ColumnEdit = LookupEditMaHang;
        }

        private void loadDonVi()
        {
            var dt = dv.GetData();
            LookUpDonVi.DataSource = dt;

            LookUpDonVi.ValueMember = "MaDonVi";
            LookUpDonVi.DisplayMember = "TenDonVi";

            colDonVi.ColumnEdit = LookUpDonVi;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaSP" )
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

            if (e.Column.FieldName == "SoLuong")
            {              
                ck = Convert.ToDecimal(txtCK.EditValue) / 100;
                vat = Convert.ToDecimal(txtVAT.EditValue) / 100;

                soluong = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colSoLuong));
                dongia = Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colDonGia));
                thanhtien = soluong * dongia;

                if (ck != 0 && vat != 0)
                {
                    thanhtien = (thanhtien + (thanhtien * vat)) - (thanhtien * ck);
                }
                else if (ck == 0 && vat != 0)
                {
                    thanhtien = thanhtien + (thanhtien * vat);
                }

                int tt = (int)thanhtien;

                gridView1.SetFocusedRowCellValue(colThanhTien, thanhtien);

                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    tt += Convert.ToInt32(gridView1.GetRowCellValue(i, "ThanhTien"));
                }

                txtThanhToan.EditValue = tt.ToString();
            }   
        }

        private void cbTenKH_EditValueChanged_1(object sender, EventArgs e)
        {
            txtMaKH.Text = cbTenKH.EditValue.ToString();
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tạo Mới")
            {
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
                gridView1.DeleteSelectedRows();
                txtThanhToan.Text = "";
                txtDiaChi.Text = "";
            }

            if (e.Button.Properties.Caption == "Lưu & Thêm")
            {
                string MaHD = txtMaPhieu.Text;
                //Lưu Chi Tiết Hóa Đơn
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    string MaSP = gridView1.GetRowCellValue(i, "MaSP").ToString();
                    string TenSP = gridView1.GetRowCellValue(i, "TenSP").ToString();
                    string DonVi = gridView1.GetRowCellValue(i, "DonVi").ToString();
                    int SoLuong = Convert.ToInt32(gridView1.GetRowCellValue(i, "SoLuong"));
                    string dongia = gridView1.GetRowCellValue(i, "DonGia").ToString();
                    float DonGia = float.Parse(dongia, NumberStyles.Any);
                    string thanhtien = gridView1.GetRowCellValue(i, "ThanhTien").ToString();
                    float ThanhTien = float.Parse(thanhtien, NumberStyles.Any);
                    string GhiChu = gridView1.GetRowCellValue(i, "GhiChu").ToString();

                    ChiTietHoaDonBan cthdb = new ChiTietHoaDonBan()
                    {
                        MaHoaDon = MaHD,
                        MaSanPham = MaSP,
                        TenSanPham = TenSP,
                        DonVi = DonVi,
                        SoLuong = SoLuong,
                        DonGia = DonGia,
                        ThanhTien = ThanhTien,
                        GhiChu = GhiChu
                    };

                    cthdb_bus.ThemChiTietHoaDonBan(cthdb);

                    //Lưu Chi Tiết Chứng Từ

                    ChiTietChungTuBan ctctb = new ChiTietChungTuBan()
                    {
                        MaCT = MaHD,
                        MaHang = MaSP,
                        TenHang = TenSP,
                        KhoHang = cbKhoHang.Text.ToString(),
                        DVT = DonVi,
                        SoLuong = SoLuong,
                        DonGia = DonGia,
                        ThanhTien = ThanhTien
                    };

                    chiTietChungTu.ThemChiTietChungTu(ctctb);

                    // Cập nhật lại số lượng khi mua 
                    hh.CapNhatMuaBan(MaSP, SoLuong);
                }

                //Lưu Hóa Đơn

                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("yyyy - MM - dd HH: mm:ss.fff");

                HoaDonBan hoaDonBan = new HoaDonBan()
                {
                    MaHoaDon = MaHD,
                    MaKhachHang = txtMaKH.Text,
                    TenKhachHang = cbTenKH.Text,
                    MaNhanVien = cbNhanVien.EditValue.ToString(),
                    NgayBan = sqlFormattedDate,
                    TongTien = float.Parse(txtThanhToan.Text, NumberStyles.Any),
                    DaTra = 0,
                    ConLai = float.Parse(txtThanhToan.Text, NumberStyles.Any),
                    DieuKhoan = cbDieuKhoan.EditValue.ToString(),
                    HinhThuc = cbHinhThuc.EditValue.ToString(),
                    DienGiai = ""
                };

                hoaDonBan_BUS.ThemHoaDonBan(hoaDonBan);

                //Lưu Chứng Từ

                ck = ck * 100;
                vat = vat * 100;

                ChungTuBan ctb = new ChungTuBan()
                {
                    MaCT = MaHD,
                    Ngay = sqlFormattedDate,
                    PhieuVietTay = txtSoPhieu.Text,
                    HoaDonVietTay = txtSoHoaDon.Text,
                    NhaCungCap = cbTenKH.Text,
                    CK = (float)ck,
                    VAT = (float)vat,
                    ThanhToan = float.Parse(txtThanhToan.Text, NumberStyles.Any),
                    GhiChu = txtGhiChu.Text
                };

                chungTuBan.ThemChungTu(ctb);

                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.SelectAll();
                gridView1.DeleteSelectedRows();
                txtThanhToan.Text = "";
                txtDiaChi.Text = "";

                sl += 1;
                if (sl < 10)
                {
                    txtMaPhieu.Text = "HDB00" + sl;
                }
                else
                {
                    txtMaPhieu.Text = "HDB0" + sl;
                }
            }

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

