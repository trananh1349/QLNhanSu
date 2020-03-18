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
using QuanLyNhanSu.Models;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Views
{
    public partial class uctLuong : DevExpress.XtraEditors.XtraUserControl
    {
        AccessDataBase nhanvien = new AccessDataBase();
        DataTable dtLuong = new DataTable();
        
        public static uctLuong luong = new uctLuong();
        public uctLuong()
        {
            InitializeComponent();
        }

        private void uctLuong_Load(object sender, EventArgs e)
        {
            //Lấy danh sách thông tin lương vào bảng bên cạnh
            SqlDataAdapter da = new SqlDataAdapter("select top 1000 MaLuong, NgayCong, LuongCB from Luong", AccessDataBase.connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewWage.DataSource = dt;
        }
    }
}
