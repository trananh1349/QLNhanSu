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

        string wageID, day, wage;

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
        private void dataGridViewWage_Click(object sender, EventArgs e)
        {
            //Lấy danh sách thông tin lương vào bảng bên cạnh
            SqlDataAdapter da = new SqlDataAdapter("select top 1000 MaLuong, NgayCong, LuongCB from Luong", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridViewWage.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (cbbCateAdd.Text != "" && tbID.Text != "" && tbDayAdd.Text != "" && tbWageAdd.Text != "")
            {
                if (cbbCateAdd.Text == "Hop dong lao dong")
                {
                    wageID = "LuongHDLD" + tbID.Text;
                }
                else if (cbbCateAdd.Text == "Hop dong CTV")
                {
                    wageID = "LuongCTV" + tbID.Text;
                }

                day = tbDayAdd.Text;
                wage = tbWageAdd.Text;

                MessageBox.Show("Thêm thành công. Vui lòng click vào bảng Lương bên dưới để cập nhật!!!", "Thông báo.");
                SqlCommand add = new SqlCommand("INSERT Luong values('" + wageID + "','" + day + "', '" + wage + "')");
                nhanvien.executeQuery(add);
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Vui lòng kiểm tra lại!!!", "Lỗi.");
            }
            
        }
        
        private void tbWageID_TextChanged(object sender, EventArgs e)
        {
            tbDayEdit.Clear();
            tbWageEdit.Clear();
            dtLuong.Clear();
        }
                
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //ấn nút tìm kiếm để lấy thông tin lương theo mã
            string search = "select * from Luong where MaLuong = '" + tbWageID.Text + "'";
            nhanvien.readDatathroughAdapter(search, dtLuong);
            if (dtLuong.Rows.Count != 0 && tbDayEdit.Text == "" && tbWageEdit.Text == "")
            {
                MessageBox.Show("Tìm kiếm thành công!!", "Thông báo.");
                //lấy thông tin Lương từ dtb
                day = dtLuong.Rows[0]["NgayCong"].ToString();
                wage = dtLuong.Rows[0]["LuongCB"].ToString();

                //hiện thông tin Lương
                tbDayEdit.Text = day;
                tbWageEdit.Text = wage;
            }
            else
            {
                MessageBox.Show("Tìm kiếm thất bại. Vui lòng kiểm tra lại!!", "Lỗi.");
            }
        }

        private void cbbCateAdd_TextChanged(object sender, EventArgs e)
        {
            tbID.Clear();
            tbDayAdd.Clear();
            tbWageAdd.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (tbWageEdit.Text != "" && tbDayEdit.Text != "")
            {
                //
                day = tbDayEdit.Text;
                wage = tbWageEdit.Text;

                SqlCommand edit = new SqlCommand("Update Luong set NgayCong = '" + @day + "', LuongCB = '" + @wage + "' where MaLuong = '" + tbWageID.Text + "'");
                if (nhanvien.executeQuery(edit) != 0)
                    MessageBox.Show("Chỉnh sửa thành công. Vui lòng click vào bảng Lương bên dưới để cập nhật!!! ", "Thông báo.");
                else
                    MessageBox.Show("Chỉnh sửa thất bại. Vui lòng kiểm tra lại!!!", "Lỗi.");
            }
            else
                MessageBox.Show("Chỉnh sửa thất bại. Vui lòng kiểm tra lại!!!", "Lỗi.");

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("delete from Luong where MaLuong = '" + tbWageID.Text + "'");
            if (tbWageID.Text != "" && tbDayEdit.Text != "" && tbWageEdit.Text != "")
            {
                MessageBox.Show("Xóa thành công. Vui lòng click vào bảng Lương bên dưới để cập nhật!!! ", "Thông báo.");
                nhanvien.executeQuery(delete);
            }
            else
                MessageBox.Show("Xóa thất bại. Vui lòng kiểm tra lại!!!", "Lỗi.");
        }
    }
}
