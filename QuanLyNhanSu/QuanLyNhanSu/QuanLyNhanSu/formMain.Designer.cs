namespace QuanLyNhanSu
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnDangKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSearchNV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tabHienThi = new DevExpress.XtraTab.XtraTabControl();
            this.ctMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đóngTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngTấtCảTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHienThi)).BeginInit();
            this.ctMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.imageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.btnDangNhap,
            this.btnChangePassword,
            this.btnLogout,
            this.skinRibbonGalleryBarItem1,
            this.btnDangKy,
            this.btnThongTin,
            this.btnAddNV,
            this.btnEditNV,
            this.btnDeleteNV,
            this.btnSearchNV,
            this.barButtonItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 12;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl.Size = new System.Drawing.Size(883, 143);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.Images.SetKeyName(0, "change_password.png");
            this.imageCollection.Images.SetKeyName(1, "inside-logout-icon.png");
            this.imageCollection.Images.SetKeyName(2, "user.png");
            this.imageCollection.Images.SetKeyName(3, "software.png");
            this.imageCollection.Images.SetKeyName(4, "login.png");
            this.imageCollection.Images.SetKeyName(5, "add_user.png");
            this.imageCollection.Images.SetKeyName(6, "delete_user.png");
            this.imageCollection.Images.SetKeyName(7, "edit_user.png");
            this.imageCollection.Images.SetKeyName(8, "Search_user.png");
            this.imageCollection.Images.SetKeyName(9, "Info-icon.png");
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.ImageIndex = 2;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi Mật Khẩu";
            this.btnChangePassword.Id = 2;
            this.btnChangePassword.ImageOptions.ImageIndex = 0;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng Xuất";
            this.btnLogout.Id = 3;
            this.btnLogout.ImageOptions.ImageIndex = 1;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 4;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Caption = "Đăng Ký";
            this.btnDangKy.Id = 5;
            this.btnDangKy.ImageOptions.ImageIndex = 4;
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangKy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSignup_ItemClick);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Caption = "Thôngtin";
            this.btnThongTin.Id = 6;
            this.btnThongTin.ImageOptions.ImageIndex = 3;
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnAddNV
            // 
            this.btnAddNV.Caption = "Thêm Nhân Viên";
            this.btnAddNV.Id = 7;
            this.btnAddNV.ImageOptions.ImageIndex = 5;
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnAddNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNV_ItemClick);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Caption = "Sửa Nhân Viên";
            this.btnEditNV.Id = 8;
            this.btnEditNV.ImageOptions.ImageIndex = 7;
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnEditNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditNV_ItemClick);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Caption = "Xóa Nhân Viên";
            this.btnDeleteNV.Id = 9;
            this.btnDeleteNV.ImageOptions.ImageIndex = 6;
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDeleteNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteNV_ItemClick);
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Caption = "Tìm Kiếm Nhân Viên";
            this.btnSearchNV.Id = 10;
            this.btnSearchNV.ImageOptions.ImageIndex = 8;
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnSearchNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thông tin phần mềm";
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.ImageIndex = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ Thống";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThongTin);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Hệ Thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Giao Diện";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddNV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEditNV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDeleteNV);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSearchNV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản Lý Nhân Viên";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Trợ Giúp";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thông tin phần mềm";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // tabHienThi
            // 
            this.tabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHienThi.Location = new System.Drawing.Point(0, 143);
            this.tabHienThi.Name = "tabHienThi";
            this.tabHienThi.Size = new System.Drawing.Size(883, 409);
            this.tabHienThi.TabIndex = 6;
            // 
            // ctMenuStrip
            // 
            this.ctMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngTrangToolStripMenuItem,
            this.đóngTấtCảTrangToolStripMenuItem});
            this.ctMenuStrip.Name = "contextMenuStrip1";
            this.ctMenuStrip.Size = new System.Drawing.Size(167, 48);
            // 
            // đóngTrangToolStripMenuItem
            // 
            this.đóngTrangToolStripMenuItem.Name = "đóngTrangToolStripMenuItem";
            this.đóngTrangToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.đóngTrangToolStripMenuItem.Text = "Đóng trang";
            this.đóngTrangToolStripMenuItem.Click += new System.EventHandler(this.đóngTrangToolStripMenuItem_Click);
            // 
            // đóngTấtCảTrangToolStripMenuItem
            // 
            this.đóngTấtCảTrangToolStripMenuItem.Name = "đóngTấtCảTrangToolStripMenuItem";
            this.đóngTấtCảTrangToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.đóngTấtCảTrangToolStripMenuItem.Text = "Đóng tất cả trang";
            this.đóngTấtCảTrangToolStripMenuItem.Click += new System.EventHandler(this.đóngTấtCảTrangToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 552);
            this.ContextMenuStrip = this.ctMenuStrip;
            this.Controls.Add(this.tabHienThi);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabHienThi)).EndInit();
            this.ctMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraTab.XtraTabControl tabHienThi;
        private DevExpress.XtraBars.BarButtonItem btnDangKy;
        private DevExpress.XtraBars.BarButtonItem btnThongTin;
        private System.Windows.Forms.ContextMenuStrip ctMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem đóngTrangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngTấtCảTrangToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem btnAddNV;
        private DevExpress.XtraBars.BarButtonItem btnEditNV;
        private DevExpress.XtraBars.BarButtonItem btnDeleteNV;
        private DevExpress.XtraBars.BarButtonItem btnSearchNV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

