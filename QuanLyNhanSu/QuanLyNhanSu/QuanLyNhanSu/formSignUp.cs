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
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class formSignUp : DevExpress.XtraEditors.XtraForm
    {
        public formSignUp()
        {
            InitializeComponent();
        }
        Models.AccessDataBase dbAccess = new Models.AccessDataBase();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string cfpassword = tbConfirmPassword.Text;
            SqlCommand command = new SqlCommand();
            if (username == "" || password == "" || cfpassword == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "select * from DangNhap where username = '" + username + "'";
            string result = (string)dbAccess.executeSelectQuery(command);
            if (result == username)
            {
                XtraMessageBox.Show("Đã tồn tại username ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != cfpassword)
            {
                XtraMessageBox.Show("Mật khẩu xác nhận không đúng ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            command.CommandText = "insert into DangNhap(username,password) values('" + username + "','" + password + "')";
            int rs = dbAccess.executeQuery(command);
            if (rs != 0)
            {
                DialogResult log = XtraMessageBox.Show("Đăng ký thông tin tài khoản thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(log == DialogResult.OK)
                {
                    Hide();
                    formLogin form = new formLogin();
                    form.Show();
                }
            }
        }

        private void btnCancelSignUp_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Close();
        }
    }
}