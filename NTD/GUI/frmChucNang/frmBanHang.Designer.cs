namespace NTD.GUI
{
    partial class frmBanHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbPhieuBanHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbTheoChungTu = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.khKhachHang = new DevExpress.XtraNavBar.NavBarItem();
            this.nbKhoHang = new DevExpress.XtraNavBar.NavBarItem();
            this.userControl1 = new NTD.GUI.UC.UcBanHang();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("04828387-3149-440a-9103-e335e8ca9f8c");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 420);
            this.dockPanel1.Text = "Chức Năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 391);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbPhieuBanHang,
            this.nbTheoChungTu,
            this.nbTheoHangHoa,
            this.nbHangHoa,
            this.khKhachHang,
            this.nbKhoHang});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 193;
            this.navBarControl1.Size = new System.Drawing.Size(193, 391);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Bán Hàng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPhieuBanHang)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // nbPhieuBanHang
            // 
            this.nbPhieuBanHang.Caption = "Phiếu Bán Hàng";
            this.nbPhieuBanHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbPhieuBanHang.ImageOptions.LargeImage")));
            this.nbPhieuBanHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbPhieuBanHang.ImageOptions.SmallImage")));
            this.nbPhieuBanHang.Name = "nbPhieuBanHang";
            this.nbPhieuBanHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbPhieuBanHang_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Bảng Kê";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTheoChungTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTheoHangHoa)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // nbTheoChungTu
            // 
            this.nbTheoChungTu.Caption = "Theo Chứng Từ";
            this.nbTheoChungTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbTheoChungTu.ImageOptions.LargeImage")));
            this.nbTheoChungTu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbTheoChungTu.ImageOptions.SmallImage")));
            this.nbTheoChungTu.Name = "nbTheoChungTu";
            this.nbTheoChungTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTheoChungTu_LinkClicked);
            // 
            // nbTheoHangHoa
            // 
            this.nbTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.nbTheoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbTheoHangHoa.ImageOptions.LargeImage")));
            this.nbTheoHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbTheoHangHoa.ImageOptions.SmallImage")));
            this.nbTheoHangHoa.Name = "nbTheoHangHoa";
            this.nbTheoHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTheoHangHoa_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Thêm Danh Mục";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbHangHoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.khKhachHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbKhoHang)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // nbHangHoa
            // 
            this.nbHangHoa.Caption = "Hàng Hóa";
            this.nbHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.LargeImage")));
            this.nbHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.nbHangHoa.Name = "nbHangHoa";
            this.nbHangHoa.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbHangHoa_LinkClicked);
            // 
            // khKhachHang
            // 
            this.khKhachHang.Caption = "Khách Hàng";
            this.khKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.LargeImage")));
            this.khKhachHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem5.ImageOptions.SmallImage")));
            this.khKhachHang.Name = "khKhachHang";
            this.khKhachHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.khKhachHang_LinkClicked);
            // 
            // nbKhoHang
            // 
            this.nbKhoHang.Caption = "Kho Hàng";
            this.nbKhoHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.ImageOptions.LargeImage")));
            this.nbKhoHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem6.ImageOptions.SmallImage")));
            this.nbKhoHang.Name = "nbKhoHang";
            this.nbKhoHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbKhoHang_LinkClicked);
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(201, 0);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(1059, 408);
            this.userControl1.TabIndex = 1;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 420);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frmBanHang";
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbPhieuBanHang;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem nbTheoChungTu;
        private DevExpress.XtraNavBar.NavBarItem nbTheoHangHoa;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem nbHangHoa;
        private DevExpress.XtraNavBar.NavBarItem khKhachHang;
        private DevExpress.XtraNavBar.NavBarItem nbKhoHang;
        private UC.UcBanHang userControl1;
    }
}