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
    public partial class uctLogin : DevExpress.XtraEditors.XtraUserControl
    {
        public uctLogin()
        {
            InitializeComponent();
        }
        public static uctLogin login = new uctLogin();
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
