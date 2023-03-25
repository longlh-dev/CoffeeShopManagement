namespace project2
{
    partial class frmquanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquanly));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btdangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.btthaydoitaikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btsanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btnhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btphieuxuat = new DevExpress.XtraBars.BarButtonItem();
            this.bttksp = new DevExpress.XtraBars.BarButtonItem();
            this.bttkpx = new DevExpress.XtraBars.BarButtonItem();
            this.bttrogiup = new DevExpress.XtraBars.BarButtonItem();
            this.rbhethong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbquanly = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbthongke = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbtrogiup = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btdangnhap,
            this.btthaydoitaikhoan,
            this.btsanpham,
            this.btnhanvien,
            this.btphieuxuat,
            this.bttksp,
            this.bttkpx,
            this.bttrogiup,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbhethong,
            this.rbquanly,
            this.rbthongke,
            this.rbtrogiup});
            this.ribbon.Size = new System.Drawing.Size(786, 161);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.Caption = "Đăng Nhập";
            this.btdangnhap.Id = 1;
            this.btdangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdangnhap.ImageOptions.Image")));
            this.btdangnhap.ImageOptions.LargeImage = global::project2.Properties.Resources.thiet_ke_form_login1;
            this.btdangnhap.LargeWidth = 100;
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btthaydoitaikhoan
            // 
            this.btthaydoitaikhoan.Caption = "Thay Đổi Tài Khoản";
            this.btthaydoitaikhoan.Id = 2;
            this.btthaydoitaikhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthaydoitaikhoan.ImageOptions.Image")));
            this.btthaydoitaikhoan.ImageOptions.LargeImage = global::project2.Properties.Resources.images;
            this.btthaydoitaikhoan.LargeWidth = 100;
            this.btthaydoitaikhoan.Name = "btthaydoitaikhoan";
            this.btthaydoitaikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btsanpham
            // 
            this.btsanpham.Caption = "Quản Lý Sản Phẩm";
            this.btsanpham.Id = 3;
            this.btsanpham.ImageOptions.Image = global::project2.Properties.Resources.comment_form;
            this.btsanpham.ImageOptions.LargeImage = global::project2.Properties.Resources.comment_form;
            this.btsanpham.LargeWidth = 100;
            this.btsanpham.Name = "btsanpham";
            this.btsanpham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btsanpham_ItemClick);
            // 
            // btnhanvien
            // 
            this.btnhanvien.Caption = "Quản Lý Nhân Viên";
            this.btnhanvien.Id = 4;
            this.btnhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhanvien.ImageOptions.Image")));
            this.btnhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnhanvien.ImageOptions.LargeImage")));
            this.btnhanvien.LargeWidth = 100;
            this.btnhanvien.Name = "btnhanvien";
            this.btnhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btphieuxuat
            // 
            this.btphieuxuat.Caption = "Quản Lý Phiếu Xuất";
            this.btphieuxuat.Id = 5;
            this.btphieuxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btphieuxuat.ImageOptions.Image")));
            this.btphieuxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btphieuxuat.ImageOptions.LargeImage")));
            this.btphieuxuat.LargeWidth = 100;
            this.btphieuxuat.Name = "btphieuxuat";
            this.btphieuxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btphieuxuat_ItemClick);
            // 
            // bttksp
            // 
            this.bttksp.Caption = "Thống Kê Sản Phẩm";
            this.bttksp.Id = 6;
            this.bttksp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bttksp.ImageOptions.LargeImage")));
            this.bttksp.LargeWidth = 100;
            this.bttksp.Name = "bttksp";
            this.bttksp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bttksp_ItemClick);
            // 
            // bttkpx
            // 
            this.bttkpx.Caption = "Thống Kê Phiếu Xuất";
            this.bttkpx.Id = 7;
            this.bttkpx.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttkpx.ImageOptions.Image")));
            this.bttkpx.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bttkpx.ImageOptions.LargeImage")));
            this.bttkpx.LargeWidth = 100;
            this.bttkpx.Name = "bttkpx";
            this.bttkpx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bttkpx_ItemClick);
            // 
            // bttrogiup
            // 
            this.bttrogiup.Caption = "Trợ Giúp";
            this.bttrogiup.Id = 8;
            this.bttrogiup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttrogiup.ImageOptions.Image")));
            this.bttrogiup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bttrogiup.ImageOptions.LargeImage")));
            this.bttrogiup.LargeWidth = 100;
            this.bttrogiup.Name = "bttrogiup";
            this.bttrogiup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bttrogiup_ItemClick);
            // 
            // rbhethong
            // 
            this.rbhethong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.rbhethong.ImageOptions.Image = global::project2.Properties.Resources.access1;
            this.rbhethong.Name = "rbhethong";
            this.rbhethong.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btdangnhap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btthaydoitaikhoan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbquanly
            // 
            this.rbquanly.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.rbquanly.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbquanly.ImageOptions.Image")));
            this.rbquanly.Name = "rbquanly";
            this.rbquanly.Text = "Quản Lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnhanvien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btsanpham);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btphieuxuat);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // rbthongke
            // 
            this.rbthongke.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.rbthongke.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbthongke.ImageOptions.Image")));
            this.rbthongke.Name = "rbthongke";
            this.rbthongke.Text = "Thống Kê";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.bttksp);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.bttkpx);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // rbtrogiup
            // 
            this.rbtrogiup.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.rbtrogiup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtrogiup.ImageOptions.Image")));
            this.rbtrogiup.Name = "rbtrogiup";
            this.rbtrogiup.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.bttrogiup);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(786, 24);
            // 
            // frmquanly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::project2.Properties.Resources.images__1_2;
            this.ClientSize = new System.Drawing.Size(786, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmquanly.IconOptions.Icon")));
            this.Name = "frmquanly";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ QUÁN CAFE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmquanly_FormClosing);
            this.Load += new System.EventHandler(this.frmquanly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbhethong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btdangnhap;
        private DevExpress.XtraBars.BarButtonItem btthaydoitaikhoan;
        private DevExpress.XtraBars.BarButtonItem btsanpham;
        private DevExpress.XtraBars.BarButtonItem btnhanvien;
        private DevExpress.XtraBars.BarButtonItem btphieuxuat;
        private DevExpress.XtraBars.BarButtonItem bttksp;
        private DevExpress.XtraBars.BarButtonItem bttkpx;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbquanly;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbthongke;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbtrogiup;
        private DevExpress.XtraBars.BarButtonItem bttrogiup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
    }
}