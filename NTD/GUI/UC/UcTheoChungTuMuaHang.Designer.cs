namespace NTD.GUI.UC
{
    partial class UcTheoChungTuMuaHang
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.grvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaChungTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhieuVietTay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoaDonVietTay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtDen = new DevExpress.XtraEditors.DateEdit();
            this.dtTu = new DevExpress.XtraEditors.DateEdit();
            this.ucChucNang = new NTD.GUI.UC.UcChucNangBan();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDetail
            // 
            this.grvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHang,
            this.colTenHang,
            this.colKhoHang,
            this.colDVT,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.grvDetail.GridControl = this.gridControl1;
            this.grvDetail.Name = "grvDetail";
            // 
            // colMaHang
            // 
            this.colMaHang.Caption = "Mã Hàng";
            this.colMaHang.FieldName = "MaSP";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.OptionsColumn.AllowEdit = false;
            this.colMaHang.Visible = true;
            this.colMaHang.VisibleIndex = 0;
            this.colMaHang.Width = 115;
            // 
            // colTenHang
            // 
            this.colTenHang.Caption = "Tên Hàng";
            this.colTenHang.FieldName = "TenSP";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.OptionsColumn.AllowEdit = false;
            this.colTenHang.Visible = true;
            this.colTenHang.VisibleIndex = 1;
            this.colTenHang.Width = 357;
            // 
            // colKhoHang
            // 
            this.colKhoHang.Caption = "Kho Hàng";
            this.colKhoHang.FieldName = "KhoHang";
            this.colKhoHang.Name = "colKhoHang";
            this.colKhoHang.OptionsColumn.AllowEdit = false;
            this.colKhoHang.Visible = true;
            this.colKhoHang.VisibleIndex = 2;
            this.colKhoHang.Width = 136;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn Vị Tính";
            this.colDVT.FieldName = "DonVi";
            this.colDVT.Name = "colDVT";
            this.colDVT.OptionsColumn.AllowEdit = false;
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 3;
            this.colDVT.Width = 78;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowEdit = false;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            this.colSoLuong.Width = 54;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn Giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.OptionsColumn.AllowEdit = false;
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 5;
            this.colDonGia.Width = 115;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành Tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.OptionsColumn.AllowEdit = false;
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 6;
            this.colThanhTien.Width = 260;
            // 
            // gridControl1
            // 
            gridLevelNode1.LevelTemplate = this.grvDetail;
            gridLevelNode1.RelationName = "Detail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 86);
            this.gridControl1.MainView = this.grvMain;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1140, 312);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMain,
            this.grvDetail});
            // 
            // grvMain
            // 
            this.grvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaChungTu,
            this.colNgay,
            this.colPhieuVietTay,
            this.colHoaDonVietTay,
            this.colNhaCungCap,
            this.colCK,
            this.colVAT,
            this.colThanhToan,
            this.colGhiChu});
            this.grvMain.GridControl = this.gridControl1;
            this.grvMain.Name = "grvMain";
            this.grvMain.OptionsDetail.ShowDetailTabs = false;
            this.grvMain.OptionsView.ShowGroupPanel = false;
            this.grvMain.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.grvMain_MasterRowEmpty);
            this.grvMain.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grvMain_MasterRowGetChildList);
            this.grvMain.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grvMain_MasterRowGetRelationName);
            this.grvMain.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grvMain_MasterRowGetRelationCount);
            // 
            // colMaChungTu
            // 
            this.colMaChungTu.Caption = "Chứng Từ";
            this.colMaChungTu.FieldName = "MaCT";
            this.colMaChungTu.Name = "colMaChungTu";
            this.colMaChungTu.Visible = true;
            this.colMaChungTu.VisibleIndex = 0;
            this.colMaChungTu.Width = 127;
            // 
            // colNgay
            // 
            this.colNgay.Caption = "Ngày";
            this.colNgay.FieldName = "Ngay";
            this.colNgay.Name = "colNgay";
            this.colNgay.Visible = true;
            this.colNgay.VisibleIndex = 1;
            this.colNgay.Width = 104;
            // 
            // colPhieuVietTay
            // 
            this.colPhieuVietTay.Caption = "Số Phiếu Viết Tay";
            this.colPhieuVietTay.FieldName = "PhieuVietTay";
            this.colPhieuVietTay.Name = "colPhieuVietTay";
            this.colPhieuVietTay.Visible = true;
            this.colPhieuVietTay.VisibleIndex = 2;
            this.colPhieuVietTay.Width = 108;
            // 
            // colHoaDonVietTay
            // 
            this.colHoaDonVietTay.Caption = "Số Hóa Đơn Viết Tay";
            this.colHoaDonVietTay.FieldName = "HoaDonVietTay";
            this.colHoaDonVietTay.Name = "colHoaDonVietTay";
            this.colHoaDonVietTay.Visible = true;
            this.colHoaDonVietTay.VisibleIndex = 3;
            this.colHoaDonVietTay.Width = 104;
            // 
            // colNhaCungCap
            // 
            this.colNhaCungCap.Caption = "Nhà Cung Cấp";
            this.colNhaCungCap.FieldName = "NhaCungCap";
            this.colNhaCungCap.Name = "colNhaCungCap";
            this.colNhaCungCap.Visible = true;
            this.colNhaCungCap.VisibleIndex = 4;
            this.colNhaCungCap.Width = 279;
            // 
            // colCK
            // 
            this.colCK.Caption = "CK %";
            this.colCK.FieldName = "CK";
            this.colCK.Name = "colCK";
            this.colCK.Visible = true;
            this.colCK.VisibleIndex = 5;
            this.colCK.Width = 56;
            // 
            // colVAT
            // 
            this.colVAT.Caption = "VAT %";
            this.colVAT.FieldName = "VAT";
            this.colVAT.Name = "colVAT";
            this.colVAT.Visible = true;
            this.colVAT.VisibleIndex = 6;
            this.colVAT.Width = 61;
            // 
            // colThanhToan
            // 
            this.colThanhToan.Caption = "Thanh Toán";
            this.colThanhToan.FieldName = "ThanhToan";
            this.colThanhToan.Name = "colThanhToan";
            this.colThanhToan.Visible = true;
            this.colThanhToan.VisibleIndex = 7;
            this.colThanhToan.Width = 133;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 8;
            this.colGhiChu.Width = 143;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1168, 435);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.groupControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1164, 410);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtDen);
            this.groupControl2.Controls.Add(this.dtTu);
            this.groupControl2.Controls.Add(this.ucChucNang);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1140, 70);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Bảng Kê Tổng Hợp";
            // 
            // dtDen
            // 
            this.dtDen.EditValue = null;
            this.dtDen.Location = new System.Drawing.Point(205, 37);
            this.dtDen.Name = "dtDen";
            this.dtDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDen.Size = new System.Drawing.Size(113, 20);
            this.dtDen.TabIndex = 9;
            // 
            // dtTu
            // 
            this.dtTu.EditValue = null;
            this.dtTu.Location = new System.Drawing.Point(52, 37);
            this.dtTu.Name = "dtTu";
            this.dtTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTu.Size = new System.Drawing.Size(110, 20);
            this.dtTu.TabIndex = 8;
            // 
            // ucChucNang
            // 
            this.ucChucNang.Location = new System.Drawing.Point(341, 25);
            this.ucChucNang.Name = "ucChucNang";
            this.ucChucNang.Size = new System.Drawing.Size(589, 40);
            this.ucChucNang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1164, 410);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 74);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(5, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1144, 74);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1144, 316);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // UcTheoChungTuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UcTheoChungTuMuaHang";
            this.Size = new System.Drawing.Size(1168, 435);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
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

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMain;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UcChucNangBan ucChucNang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DateEdit dtDen;
        private DevExpress.XtraEditors.DateEdit dtTu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChungTu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgay;
        private DevExpress.XtraGrid.Columns.GridColumn colPhieuVietTay;
        private DevExpress.XtraGrid.Columns.GridColumn colHoaDonVietTay;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn colCK;
        private DevExpress.XtraGrid.Columns.GridColumn colVAT;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
    }
}
