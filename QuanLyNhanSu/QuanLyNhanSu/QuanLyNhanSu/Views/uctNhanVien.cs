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
    public partial class uctNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        Models.AccessDataBase db = new Models.AccessDataBase();
        public uctNhanVien()
        {
            InitializeComponent();
            string sql = "SELECT  * from NhanVien";
            DataTable dttb = new DataTable();
            db.readDatathroughAdapter(sql, dttb);
            dgvNhanVien.DataSource = dttb;
        }
        public static uctNhanVien NhanVien = new uctNhanVien();
    }
}
