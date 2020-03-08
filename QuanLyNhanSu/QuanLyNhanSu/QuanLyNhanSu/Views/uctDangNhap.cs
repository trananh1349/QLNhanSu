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

namespace QuanLyNhanSu.Views
{
    public partial class uctDangNhap : DevExpress.XtraEditors.XtraUserControl
    {
        public uctDangNhap()
        {
            InitializeComponent();
        }
        public static uctDangNhap login = new uctDangNhap();
        Models.AccessDataBase dbAccess = new Models.AccessDataBase();
        DataTable dtUsers = new DataTable();
        public static string id, name, email, password, country;
        public static bool isLogin = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string query = "select * from DangNhap DN, NhanVien NV where DN.MaNV=NV.MaNV and username = '" +
                username + "' and password = '" + password + "'";

            dbAccess.readDatathroughAdapter(query, dtUsers);
            if (dtUsers.Rows.Count != 0)
            {
                //id = dtUsers.Rows[0]["ID"].ToString();
                //name = dtUsers.Rows[0]["Name"].ToString();
                //email = dtUsers.Rows[0]["Email"].ToString();
                //password = dtUsers.Rows[0]["Password"].ToString();
                //country = dtUsers.Rows[0]["Country"].ToString();

                isLogin = true;
                XtraMessageBox.Show("Đăng nhập thành công !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                formMain form = new formMain();
                form.btn
            }
            else
            {
                XtraMessageBox.Show("Vui lòng nhập lại thông tin tài khoản !","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
