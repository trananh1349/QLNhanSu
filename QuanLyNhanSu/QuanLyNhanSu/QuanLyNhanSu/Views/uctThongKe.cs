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
        AccessDataBase db = new AccessDataBase();
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
                //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'", AccessDataBase.connection);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;

                DataTable dttbLoad = new DataTable();
                string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'";
                db.readDatathroughAdapter(query, dttbLoad);
                dataGridView1.DataSource = dttbLoad;
            }
            else if (ten.Trim().Equals("") == true && comboBoxThang.Text.Equals("") == true && comboBoxNam.Text.Equals("") == true)
            {
                //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong ", AccessDataBase.connection);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;

                DataTable dttbLoad = new DataTable();
                string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong ";
                db.readDatathroughAdapter(query, dttbLoad);
                dataGridView1.DataSource = dttbLoad;
            }
            else if (ten.Trim().Equals("") != true && comboBoxThang.Text.Equals("") == true && comboBoxNam.Text.Equals("") == true)
            {
                //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE HoTen like N'%" + ten + "%'", AccessDataBase.connection);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;


                DataTable dttbLoad = new DataTable();
                string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE HoTen like N'%" + ten + "%'";
                db.readDatathroughAdapter(query, dttbLoad);
                dataGridView1.DataSource = dttbLoad;
            }
            else
            {
                //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'", AccessDataBase.connection);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;

                DataTable dttbLoad = new DataTable();
                string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'";
                db.readDatathroughAdapter(query, dttbLoad);
                dataGridView1.DataSource = dttbLoad;
            }
        }
    }
}

