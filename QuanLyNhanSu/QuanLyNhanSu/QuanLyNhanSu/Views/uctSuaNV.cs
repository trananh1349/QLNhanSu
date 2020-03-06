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
    public partial class uctSuaNV : DevExpress.XtraEditors.XtraUserControl
    {
        public uctSuaNV()
        {
            InitializeComponent();
        }
        public static uctSuaNV suanv = new uctSuaNV();
    }
}
