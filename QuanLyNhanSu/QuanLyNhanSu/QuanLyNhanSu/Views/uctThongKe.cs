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
    public partial class uctThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        public static uctThongKe thongke = new uctThongKe(); 
        public uctThongKe()
        {
            InitializeComponent();
        }

        private void uctThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
