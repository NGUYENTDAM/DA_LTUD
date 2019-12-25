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
using NTD.GUI.UC;

namespace NTD.GUI
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadPhieuNhapHang();
        }
        
        private void LoadPhieuNhapHang()
        {
            
            PhieuBanHang pbh = new PhieuBanHang();
            pbh.Dock = DockStyle.Fill;
            userControl1.Controls.Clear();
            userControl1.Controls.Add(pbh);
            userControl1.Dock = DockStyle.Fill;        
            
        }

        private void LoadTheoChungTu()
        {
            UcTheoChungTuBanhang pbh = new UcTheoChungTuBanhang();
            pbh.Dock = DockStyle.Fill;
            userControl1.Controls.Clear();
            userControl1.Controls.Add(pbh);
            userControl1.Dock = DockStyle.Fill;

        }
        private void LoadTheoHangHoa()
        {

            UcTheoHangHoaBanHang pbh = new UcTheoHangHoaBanHang();
            pbh.Dock = DockStyle.Fill;
            userControl1.Controls.Clear();
            userControl1.Controls.Add(pbh);
            userControl1.Dock = DockStyle.Fill;

        }
        private void nbPhieuBanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadPhieuNhapHang();
        }

        private void nbTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadTheoChungTu();
        }

        private void nbTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadTheoHangHoa();
        }

        private void nbHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemHangHoa thh = new frmThemHangHoa();
            thh.ShowDialog();
        }

        private void khKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemKhachHang thh = new frmThemKhachHang();
            thh.ShowDialog();
        }

        private void nbKhoHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemKhoHang thh = new frmThemKhoHang();
            thh.ShowDialog();
        }
    }
}