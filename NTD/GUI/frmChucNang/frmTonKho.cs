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

namespace NTD.GUI
{
    public partial class frmTonKho : DevExpress.XtraEditors.XtraForm
    {
        public frmTonKho()
        {
            InitializeComponent();
        }
        TonKho_BUS bus_tk = new TonKho_BUS();

        private void LoadData(string ma)
        { 

            var dataTable = bus_tk.GetDataMa(ma);

            gcTonKho.DataSource = dataTable;
        }
        private void LoadAllData()
        {

            var dataTable = bus_tk.GetAllData();

            gcTonKho.DataSource = dataTable;
        }
        private void frmTonKho_Load(object sender, EventArgs e)
        {
            var dataTable = bus_tk.GetAllDataKH();

            cbKhoHang.Properties.DataSource = dataTable;
            cbKhoHang.Properties.DisplayMember = "Kho Hàng";
            cbKhoHang.Properties.ValueMember = "Mã Kho";

            cbKhoHang.Text = "Tất Cả";

            LoadAllData();
        }

        private void cbKhoHang_EditValueChanged(object sender, EventArgs e)
        {
            string ma = cbKhoHang.EditValue.ToString();
            LoadData(ma);
        }

        private void groupControl2_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Xem")
            {
                LoadAllData();
            }
            if (e.Button.Properties.Caption == "Xuất")
            {
                XtraSaveFileDialog SaveFileDialog = new XtraSaveFileDialog();
                SaveFileDialog.ShowDialog();

                gcTonKho.ExportToXlsx(SaveFileDialog.FileName + ".xlsx");
            }
            if (e.Button.Properties.Caption == "Đóng")
            {
                this.Close();
            }
        }
    }
}