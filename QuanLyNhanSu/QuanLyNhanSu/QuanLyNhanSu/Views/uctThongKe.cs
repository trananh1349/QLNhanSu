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
using DevExpress.CodeParser;

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
            try
            {
                string query = "";
                DataTable dttbLoad = new DataTable();

                if (comboBoxThang.Text.Equals("") == true && comboBoxNam.Text.Equals("") == true)
                    throw new Exception("Vui lòng nhập lại !");

                if (comboBoxThang.Text.Equals("") != true)
                    query = "SELECT Thang, SUM(CAST(LuongCB as INT) * CAST(NgayCong as INT)) N'Tổng Tiền' FROM Luong group by Thang having Thang = '" + comboBoxThang.Text + "'";
                if (comboBoxNam.Text.Equals("") != true)
                    query = "SELECT Nam, SUM(CAST(LuongCB as INT) * CAST(NgayCong as INT)) N'Tổng Tiền' FROM Luong group by Nam having Nam = '" + comboBoxNam.Text + "'";
                if (comboBoxNam.Text.Equals("") != true && comboBoxThang.Text.Equals("") != true)
                    query = "SELECT Thang, Nam, SUM(CAST(LuongCB as INT) * CAST(NgayCong as INT)) N'Tổng Tiền' FROM Luong group by Thang,Nam having Thang = '" + comboBoxThang.Text + "' and Nam = '" +comboBoxNam.Text+"'";
                db.readDatathroughAdapter(query, dttbLoad);
                dataGridView1.DataSource = dttbLoad;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Vui lòng chọn cách thức thống kê !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (ten.Trim().Equals("") != true && comboBoxThang.Text.Equals("") != true && comboBoxNam.Text.Equals("") != true)
            //{
            //    //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'", AccessDataBase.connection);
            //    //DataTable dt = new DataTable();
            //    //da.Fill(dt);
            //    //dataGridView1.DataSource = dt;

            //    DataTable dttbLoad = new DataTable();
            //    string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'";
            //    db.readDatathroughAdapter(query, dttbLoad);
            //    dataGridView1.DataSource = dttbLoad;
            //}
            //else if (ten.Trim().Equals("") == true && comboBoxThang.Text.Equals("") == true && comboBoxNam.Text.Equals("") == true)
            //{
            //    //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong ", AccessDataBase.connection);
            //    //DataTable dt = new DataTable();
            //    //da.Fill(dt);
            //    //dataGridView1.DataSource = dt;

            //    DataTable dttbLoad = new DataTable();
            //    string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong ";
            //    db.readDatathroughAdapter(query, dttbLoad);
            //    dataGridView1.DataSource = dttbLoad;
            //}
            //else if (ten.Trim().Equals("") != true && comboBoxThang.Text.Equals("") == true && comboBoxNam.Text.Equals("") == true)
            //{
            //    //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE HoTen like N'%" + ten + "%'", AccessDataBase.connection);
            //    //DataTable dt = new DataTable();
            //    //da.Fill(dt);
            //    //dataGridView1.DataSource = dt;


            //    DataTable dttbLoad = new DataTable();
            //    string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE HoTen like N'%" + ten + "%'";
            //    db.readDatathroughAdapter(query, dttbLoad);
            //    dataGridView1.DataSource = dttbLoad;
            //}
            //else
            //{
            //    //SqlDataAdapter da = new SqlDataAdapter("SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'", AccessDataBase.connection);
            //    //DataTable dt = new DataTable();
            //    //da.Fill(dt);
            //    //dataGridView1.DataSource = dt;

            //    DataTable dttbLoad = new DataTable();
            //    string query = "SELECT HoTen N'Họ và tên',Thang N'Tháng' ,Nam N'Năm',LuongCB N'Lương' FROM NhanVien, Luong WHERE Luong.MaLuong like  '%" + ngaythang + "%' AND HoTen like N'%" + ten + "%'";
            //    db.readDatathroughAdapter(query, dttbLoad);
            //    dataGridView1.DataSource = dttbLoad;
            //}
        }
    }
}

