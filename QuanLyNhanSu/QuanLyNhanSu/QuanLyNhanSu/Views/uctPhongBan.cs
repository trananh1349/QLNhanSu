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
    public partial class uctPhongBan : DevExpress.XtraEditors.XtraUserControl
    {
        public static uctPhongBan phongban = new uctPhongBan();
        public uctPhongBan()
        {
            InitializeComponent();
        }
    }
}
