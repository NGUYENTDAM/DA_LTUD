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
using NTD.GUI.UC.UC_ChuyenKho;

namespace NTD.GUI
{
    public partial class frmChuyenKho : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenKho()
        {
            InitializeComponent();
        }

        private void frmChuyenKho_Load(object sender, EventArgs e)
        {
            LoadPhieuChuyenKho();
        }
        private void LoadPhieuChuyenKho()
        {
            UcChuyenKho pbh = new UcChuyenKho();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;
        }
        private void LoadTheoChungTu()
        {
            UcChuyenKhoTheoChungTu pbh = new UcChuyenKhoTheoChungTu();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;

        }
        private void LoadTheoHangHoa()
        {

            UcTheoHangHoaMuaHang pbh = new UcTheoHangHoaMuaHang();
            pbh.Dock = DockStyle.Fill;
            ucControl.Controls.Clear();
            ucControl.Controls.Add(pbh);
            ucControl.Dock = DockStyle.Fill;

        }
        private void nbPhieuChuyenKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadPhieuChuyenKho();
        }

        private void nbTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LoadTheoChungTu();
        }

        //private void nbTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        //{
        //    LoadTheoHangHoa();
        //}

        private void nbHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemHangHoa hh = new frmThemHangHoa();
            hh.ShowDialog();
        }

        private void nbKhoHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemKhoHang kh = new frmThemKhoHang();
            kh.ShowDialog();
        }

        private void nbNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemNhanVien nv = new frmThemNhanVien();
            nv.ShowDialog();
        }
    }
}