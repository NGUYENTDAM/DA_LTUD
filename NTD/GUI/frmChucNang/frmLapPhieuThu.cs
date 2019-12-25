using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NTD.DTO;
using NTD.BUS;
using NTD.DAO;

namespace NTD.GUI.frmChucNang
{
    public partial class frmLapPhieuThu : DevExpress.XtraEditors.XtraForm
    {
        public frmLapPhieuThu(PhieuThu pc)
        {

            InitializeComponent();
            DateTime now = DateTime.Now;


            txtKhachHang.Enabled = false;
            txtTheoChungTu.Enabled = false;
            txtConNo.Enabled = false;
            txtKhachHang.Enabled = false;
            txtSoTien.Enabled = false;
            txtMaNV.Enabled = false;
            date.Enabled = false;


            txtKhachHang.Text = pc.TenKH;
            txtTheoChungTu.Text = pc.MaCT;
            date.Text = pc.Ngay.ToString();
            txtSoTien.Text = pc.SoTien.ToString();
            txtConNo.Text = pc.ConNo.ToString();
            txtSoTienTra.Text = pc.DaTra.ToString();
            txtMaNV.Text = pc.NhanVien;
            dateHT.Text = now.ToString();

        }

        db db = new db();
        private void frmLapPhieuThu_Load(object sender, EventArgs e)
        {
            int stt = db.GetSoLuong("DanhSachPhieuThu") + 1;
            string maMacDinh;
            if (stt < 10)
            {
                maMacDinh = "PT00" + stt;
            }
            else
            {
                maMacDinh = "PT0" + stt;
            }
            txtPhieu.Text = maMacDinh;
        }
        DanhSachPhieuThu_BUS pt_bus = new DanhSachPhieuThu_BUS();

        private void XoaPT()
        {
            string ma = txtTheoChungTu.Text;

            if (ma != null)
            {
                var rs = pt_bus.DeleteByMaHD(ma);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            float CNo = 0;

            CNo = (float.Parse(txtSoTien.Text)) - (float.Parse(txtSoTienTra.Text));

            PhieuThu pt = new PhieuThu()
            {

                TenKH = txtKhachHang.Text,
                MaCT = txtTheoChungTu.Text,
                Ngay = DateTime.Parse(dateHT.Text),
                SoTien = float.Parse(txtSoTien.Text),
                ConNo = CNo,
                DaTra = float.Parse(txtSoTienTra.Text),
                NhanVien = txtMaNV.Text,
                GhiChu = mmGhiChu.Text,
                Phieu = txtPhieu.Text


            };
            if (pt_bus.ThemPT(pt) > 0)
            {
                MessageBox.Show("Lập phiếu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaPT();
                this.Close();
            }
        }
    }
}