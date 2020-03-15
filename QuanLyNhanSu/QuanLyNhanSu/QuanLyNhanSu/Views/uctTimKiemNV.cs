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
    public partial class uctTimKiemNV : DevExpress.XtraEditors.XtraUserControl
    {
        AccessDataBase db = new AccessDataBase();
        public uctTimKiemNV()
        {
            InitializeComponent();
        }
        public static uctTimKiemNV timkiemnv = new uctTimKiemNV();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void uctTimKiemNV_Load(object sender, EventArgs e)
        {
            //string sqlconnectStr = "Data Source=DESKTOP-B6771TG;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            string sqlconnectStr = "Data Source=DESKTOP-8V08BMC\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection connection = new SqlConnection(sqlconnectStr);
            connection.Open();
            //Lay danh sach chuc vu
            SqlCommand cmd = new SqlCommand("select * from ChucVu", connection);
            SqlCommand _cmd = new SqlCommand("select * from PhongBan", connection);

            using (SqlDataReader result = cmd.ExecuteReader())
            {
                while (result.Read())
                {
                    cbxChucVu.Items.Add(result[1]);
                }
            }

            //Lay Danh sach phong ban
            using (SqlDataReader _result = _cmd.ExecuteReader())
            {
                while (_result.Read())
                {
                    cbxPhongBan.Items.Add(_result[1]);
                }
            }


            connection.Close();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridViewTimKiem.DataSource = null;
            //string sqlconnectStr = "Data Source=DESKTOP-B6771TG;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            string sqlconnectStr = "Data Source=DESKTOP-8V08BMC\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection connection = new SqlConnection(sqlconnectStr);
            connection.Open();
            //Tim kiem theo yeu cau
            SqlDataAdapter da = new SqlDataAdapter("select * from NhanVien nv,PhongBan pb,ChucVu cv where nv.MaPhongBan = pb.MaPhongBan and " +
                "nv.MaCV = cv.MaCV and nv.HoTen like N'%" + txtTen.Text + "%' and pb.TenPhongBan like N'%" + cbxPhongBan.Text + "%' and cv.TenCV like N'%" + cbxChucVu.Text + "%'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewTimKiem.DataSource = dt;
            connection.Close();

            txtTen.Clear();
            cbxPhongBan.SelectedIndex = -1;
            cbxChucVu.SelectedIndex = -1;
        }
    }
}
