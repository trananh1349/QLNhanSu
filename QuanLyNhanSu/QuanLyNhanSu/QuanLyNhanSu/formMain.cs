using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace QuanLyNhanSu
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formMain()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void AddTabPages(XtraUserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < tabHienThi.TabPages.Count; i++)
            {
                if (tabHienThi.TabPages[i].Contains(uct))
                {
                    tabHienThi.SelectedTabPage = tabHienThi.TabPages[i];
                    return;
                }
            }
            XtraTabPage tab = new XtraTabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTab;
            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTabPage = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        public void DongTabHienTai()
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTabPage);
        }
        public void DongTatCaTab()
        {
            while(tabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        public void Skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel thems = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            thems.LookAndFeel.SkinName = "Blue";
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            Skin();
            btnThongTin.Enabled = false;
            btnChangePassword.Enabled = false;
            btnLogout.Enabled = false;
            btnAddNV.Enabled = false;
            btnEditNV.Enabled = false;
            btnDeleteNV.Enabled = false;
            btnSearchNV.Enabled = false;
        }
        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
                e.Cancel = true;  
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.uctDangNhap.login, 4, "Đăng Nhập");
            if (Views.uctDangNhap.isLogin)
                btnDangNhap.Enabled = false;
        }

        private void đóngTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngTấtCảTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTatCaTab();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.uctTimKiemNV.timkiemnv, 4, "Tìm kiếm nhân viên");
        }

        private void btnSignup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.uctDangKy.signup, 4, "Đăng Ký");
        }

        private void btnAddNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.uctThemNV.themnv, 4, "Thêm nhân viên");
        }

        private void btnEditNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.uctSuaNV.suanv, 4, "Sửa nhân viên");
        }

        private void btnDeleteNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.uctXoaNV.xoanv, 4, "Xóa nhân viên");
        }
    }
}
