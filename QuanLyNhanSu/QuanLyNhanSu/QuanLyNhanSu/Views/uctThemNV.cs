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
    public partial class uctThemNV : DevExpress.XtraEditors.XtraUserControl
    {
        public uctThemNV()
        {
            InitializeComponent();
        }
        public static uctThemNV themnv = new uctThemNV();
    }
}
