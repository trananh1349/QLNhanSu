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
        public static formLogin uctLogin = new formLogin();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formSignUp formSignUp = new formSignUp();
            formSignUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}