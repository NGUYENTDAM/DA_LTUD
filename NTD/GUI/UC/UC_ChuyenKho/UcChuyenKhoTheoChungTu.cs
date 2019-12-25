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

namespace NTD.GUI.UC.UC_ChuyenKho
{
    public partial class UcChuyenKhoTheoChungTu : UserControl
    {
        public UcChuyenKhoTheoChungTu()
        {
            InitializeComponent();
        }
        ChuyenKho_BUS bus_ck = new ChuyenKho_BUS();

        private void LoadData()
        {
            var dt = bus_ck.LoadAll();

            gcChuyenKho.DataSource = dt;
        }
        private void LoadTheoTime()
        {
            DateTime tu, den;

            tu = DateTime.Parse(dtTu.Text);
            den = DateTime.Parse(dtDen.Text);
            string sqlFormattedDate = tu.ToString("yyyy - MM - dd HH: mm:ss.fff");
            string sqlFormattedDate1 = den.ToString("yyyy - MM - dd HH: mm:ss.fff");

            var dt = bus_ck.DSCKTime(sqlFormattedDate, sqlFormattedDate1);

            gcChuyenKho.DataSource = dt;
        }

        private void UcChuyenKhoTheoChungTu_Load(object sender, EventArgs e)
        {
            ucChucNang.Controls["btnXem"].Click += Xem;
            ucChucNang.Controls["btnXoa"].Click += Xoa;
            ucChucNang.Controls["btnXuat"].Click += Xuat;
            ucChucNang.Controls["btnDong"].Click += Dong;

            dtTu.Text = "12/1/2019";
            dtDen.Text = "12/30/2019";

            LoadData();
        }

        private void Dong(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void Xuat(object sender, EventArgs e)
        {
            XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
            SaveFileDialog.ShowDialog();

            gcChuyenKho.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
        }

        private void Xoa(object sender, EventArgs e)
        {
            string ma = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaPhieu").ToString();

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaPhieu").ToString() != null)
            {
                var rs = bus_ck.DeleteById(ma);

                if (rs > 0)
                {
                    LoadData();
                    MessageBox.Show("Delete Successfully!!!!!!!!");
                }
            }
        }

        private void Xem(object sender, EventArgs e)
        {
            LoadTheoTime();
        }
    }
}
