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
using NTD.BUS;

namespace NTD.GUI.frmHeThong
{
    public partial class frmThongTin : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        NhanVien_BUS nv = new NhanVien_BUS();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            DataTable dt = nv.GetAllDataTheoMaNV(GlobalVar.maVN);
            txtTen.Text = dt.Rows[0]["Họ Tên"].ToString();
            txtDiaChi.Text = dt.Rows[0]["Địa Chỉ"].ToString();
            txtDienThoai.Text = dt.Rows[0]["Điện Thoại"].ToString();
        }
    }
}