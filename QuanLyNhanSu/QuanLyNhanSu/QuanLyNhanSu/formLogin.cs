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

namespace QuanLyNhanSu
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        public formLogin()
        {
            InitializeComponent();
        }
        //public static formLogin uctLogin = new formLogin();
        Models.AccessDataBase dbAccess = new Models.AccessDataBase();
        DataTable dtUsers = new DataTable();
        public static string maNV, hoTen, gioiTinh, danToc,
            cmnd, soDt, diaChi, maPB, maCV, maTD, ngaySinh;

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
        }

        public static bool isLogin = false;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            formSignUp form = new formSignUp();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string query = "select * from DangNhap where username = '" +
                username + "' and password = '" + password + "'";

            dbAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count != 0)
            {
                isLogin = true;
                DialogResult log = XtraMessageBox.Show("Đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (log == DialogResult.OK)
                {
                    Hide();
                    formMain form = new formMain();
                    form.Show();
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập lại thông tin tài khoản !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}