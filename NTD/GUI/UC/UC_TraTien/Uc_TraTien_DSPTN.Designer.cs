namespace NTD.GUI.UC
{
    partial class Uc_TraTien_DSPTN
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_TraTien_DSPTN));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcDSPTN = new DevExpress.XtraGrid.GridControl();
            this.gvDSPTN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieuChi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.dtDen = new DevExpress.XtraEditors.DateEdit();
            this.dtTu = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSPTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSPTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDSPTN);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(982, 416);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcDSPTN
            // 
            this.gcDSPTN.Location = new System.Drawing.Point(12, 89);
            this.gcDSPTN.MainView = this.gvDSPTN;
            this.gcDSPTN.Name = "gcDSPTN";
            this.gcDSPTN.Size = new System.Drawing.Size(958, 315);
            this.gcDSPTN.TabIndex = 12;
            this.gcDSPTN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSPTN});
            // 
            // gvDSPTN
            // 
            this.gvDSPTN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvDSPTN.GridControl = this.gcDSPTN;
            this.gvDSPTN.GroupCount = 1;
            this.gvDSPTN.Name = "gvDSPTN";
            this.gvDSPTN.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Chứng Từ";
            this.gridColumn1.FieldName = "MaHD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ngày";
            this.gridColumn2.FieldName = "NgayNhap";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mô Tả";
            this.gridColumn3.FieldName = "MoTa";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mã KH";
            this.gridColumn4.FieldName = "MaNCC";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Khách hàng ";
            this.gridColumn5.FieldName = "Ten";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tổng Tiền";
            this.gridColumn6.FieldName = "TongTien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Đã Trả";
            this.gridColumn7.FieldName = "DaTra";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Còn Lại";
            this.gridColumn8.FieldName = "ConLai";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Nhân Viên";
            this.gridColumn9.FieldName = "MaNV";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btnDong);
            this.groupControl1.Controls.Add(this.btnXuat);
            this.groupControl1.Controls.Add(this.btnLapPhieuChi);
            this.groupControl1.Controls.Add(this.btnXem);
            this.groupControl1.Controls.Add(this.dtDen);
            this.groupControl1.Controls.Add(this.dtTu);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(958, 73);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Danh Sách Trả Ngay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đến";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(647, 36);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(554, 36);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnLapPhieuChi
            // 
            this.btnLapPhieuChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieuChi.ImageOptions.Image")));
            this.btnLapPhieuChi.Location = new System.Drawing.Point(443, 36);
            this.btnLapPhieuChi.Name = "btnLapPhieuChi";
            this.btnLapPhieuChi.Size = new System.Drawing.Size(93, 23);
            this.btnLapPhieuChi.TabIndex = 4;
            this.btnLapPhieuChi.Text = "Lập phiếu chi";
            this.btnLapPhieuChi.Click += new System.EventHandler(this.btnLapPhieuChi_Click);
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(350, 36);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtDen
            // 
            this.dtDen.EditValue = null;
            this.dtDen.Location = new System.Drawing.Point(198, 36);
            this.dtDen.Name = "dtDen";
            this.dtDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDen.Size = new System.Drawing.Size(100, 20);
            this.dtDen.TabIndex = 2;
            // 
            // dtTu
            // 
            this.dtTu.EditValue = null;
            this.dtTu.Location = new System.Drawing.Point(52, 36);
            this.dtTu.Name = "dtTu";
            this.dtTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTu.Size = new System.Drawing.Size(100, 20);
            this.dtTu.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(982, 416);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 77);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(5, 77);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(962, 77);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcDSPTN;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 77);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(962, 319);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Uc_TraTien_DSPTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Uc_TraTien_DSPTN";
            this.Size = new System.Drawing.Size(982, 416);
            this.Load += new System.EventHandler(this.Uc_TraTien_DSPTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSPTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSPTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcDSPTN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSPTN;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieuChi;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraEditors.DateEdit dtDen;
        private DevExpress.XtraEditors.DateEdit dtTu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}
