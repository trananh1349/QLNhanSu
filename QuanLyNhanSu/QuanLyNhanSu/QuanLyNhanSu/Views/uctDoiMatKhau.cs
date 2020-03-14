using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Views
{
    public partial class uctDoiMatKhau : DevExpress.XtraEditors.XtraUserControl
    {
        public uctDoiMatKhau()
        {
            InitializeComponent();
        }

        Models.AccessDataBase dbAccess = new Models.AccessDataBase();
        public static uctDoiMatKhau uctChangePassword = new uctDoiMatKhau();

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            string newPassword = tbNewPassword.Text;
            string cfPassword = tbConfirmPassword.Text;
            SqlCommand command = new SqlCommand();
            if (newPassword == "" || password == "" || cfPassword == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "select * from DangNhap where password = '" + password + "'";
            string result = (string)dbAccess.executeSelectQuery(command);
            if (result != "")
            {
                XtraMessageBox.Show("Đã tồn tại username ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != cfPassword)
            {
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "update DangNhap set password = '" + newPassword + "' where password = '" + password + "'";
            int rs = dbAccess.executeQuery(command);
            if (rs != 0)
            {
                DialogResult log = XtraMessageBox.Show("Đổi mật khẩu tài khoản thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (log == DialogResult.OK)
                {
                    Hide();
                }
            }
        }
    }
}
