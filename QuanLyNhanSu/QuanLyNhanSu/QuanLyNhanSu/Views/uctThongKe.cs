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
using System.Data.SqlClient;
using QuanLyNhanSu.Models;

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

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            string ten = txbHoTen.Text;
            string ngaythang = comboBoxThang.Text + comboBoxNam.Text;
            if (ten.Trim().Equals("") != true && comboBoxThang.Text.Equals("") != true && comboBoxNam.Text.Equals("") != true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen 'Họ và tên',Thang 'Tháng' ,Nam 'Năm',LuongCB 'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'", AccessDataBase.connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (ten.Trim().Equals("") == true && comboBoxThang.Text.Equals("") == true && comboBoxNam.Text.Equals("") == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen 'Họ và tên',Thang 'Tháng' ,Nam 'Năm',LuongCB 'Lương' FROM NhanVien, Luong ", AccessDataBase.connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (ten.Trim().Equals("") != true && comboBoxThang.Text.Equals("") == true && comboBoxNam.Text.Equals("") == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen 'Họ và tên',Thang 'Tháng' ,Nam 'Năm',LuongCB 'Lương' FROM NhanVien, Luong WHERE HoTen like N'%" + ten + "%'", AccessDataBase.connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen 'Họ và tên',Thang 'Tháng' ,Nam 'Năm',LuongCB 'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'", AccessDataBase.connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}

