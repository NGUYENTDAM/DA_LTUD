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
    public partial class frmLapPhieuChi : DevExpress.XtraEditors.XtraForm
    {
        //public frmLapPhieuChi()
        //{
        //    InitializeComponent();
        //}
        public frmLapPhieuChi( PhieuChi pc)
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
      

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DanhSachPhieuChi_BUS pc_bus = new DanhSachPhieuChi_BUS();


        List<string> a = new List<string>();
        private int KiemTra()
        {
            for (int i = 0; i < a.Count; i++)
            {
                if(a[i]==txtTheoChungTu.Text)
                {
                    return 1;
                }
            }

            return 0;
        }
        private void Xoa()
        {
            string ma = txtTheoChungTu.Text;

            if (ma != null)
            {
                var rs = pc_bus.DeleteById(ma);
            }
        }
       
        private void btnLuu_Click(object sender, EventArgs e)
        {
            float CNo=0;

            if (KiemTra() == 1)
            {
                MessageBox.Show("Phiếu đã lập !");
            }
            else
            {
                CNo = (float.Parse(txtSoTien.Text)) - (float.Parse(txtSoTienTra.Text));

                PhieuChi pc = new PhieuChi()
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
                if (pc_bus.ThemPC(pc) > 0)
                {
                    MessageBox.Show("Lập phiếu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    a.Add('"' + txtTheoChungTu.Text + '"');
                    Xoa();
                    this.Close();
                }
            }
           
        }
        db db = new db();
        private void frmLapPhieuChi_Load(object sender, EventArgs e)
        {
            int stt = db.GetSoLuong("DanhSachPhieuChi") + 1;
            string maMacDinh;
            if (stt < 10)
            {
                maMacDinh = "PC00" + stt;
            }
            else
            {
                maMacDinh = "PC0" + stt;
            }
            txtPhieu.Text = maMacDinh;
        }
    }
}