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

        string wageID, day, wage, month, year;

        public static uctLuong luong = new uctLuong();
        
        public uctLuong()
        {
            InitializeComponent();
        }

        private void uctLuong_Load(object sender, EventArgs e)
        {
            monthYPicker1.CustomFormat = "MM - yyyy";
            monthYPicker2.CustomFormat = "MM - yyyy";

            //Lấy danh sách thông tin lương vào bảng bên cạnh
            SqlDataAdapter da = new SqlDataAdapter("select top 1000 MaLuong, NgayCong, Thang, Nam, LuongCB from Luong", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridViewWage.DataSource = dt;
        }
        private void dataGridViewWage_Click(object sender, EventArgs e)
        {
            //Lấy danh sách thông tin lương vào bảng bên cạnh
            SqlDataAdapter da = new SqlDataAdapter("select top 1000 MaLuong, NgayCong, Thang, Nam, LuongCB from Luong", AccessDataBase.connection);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridViewWage.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void gboxAdd_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (cbbCateAdd.Text != "" && tbStaffID.Text != "" && tbDayAdd.Text != "" && tbWageAdd.Text != "")
            {
                day = tbDayAdd.Text;
                wage = tbWageAdd.Text;
                month = monthYPicker1.Value.Month.ToString();
                if (Int32.Parse(month) < 10)
                {
                    month = "0" + month;
                }
                year = monthYPicker1.Value.Year.ToString();

                if (cbbCateAdd.Text == "Hop dong lao dong")
                {
                    wageID = "LuongHDLD" + tbStaffID.Text + month + year;
                }
                else if (cbbCateAdd.Text == "Hop dong CTV")
                {
                    wageID = "LuongCTV" + tbStaffID.Text + month + year;
                }

                XtraMessageBox.Show("Thêm thành công. Vui lòng click vào bảng Lương bên dưới để cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand add = new SqlCommand("INSERT Luong values('" + wageID + "','" + day + "', '" + wage + "', '" + month + "', '" + year + "')");
                nhanvien.executeQuery(add);
            }
            else
            {
                XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbWageID_TextChanged(object sender, EventArgs e)
        {
            tbDayEdit.Clear();
            tbWageEdit.Clear();
            dtLuong.Clear();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (tbWageEdit.Text != "" && tbDayEdit.Text != "")
            {
                //
                day = tbDayEdit.Text;
                wage = tbWageEdit.Text;
                month = monthYPicker2.Value.Month.ToString();
                if (Int32.Parse(month) < 10)
                {
                    month = "0" + month;
                }
                year = monthYPicker2.Value.Year.ToString();

                SqlCommand edit = new SqlCommand("Update Luong set NgayCong = '" + @day + "', LuongCB = '" + @wage + "', Thang = '" + @month + "', Nam = '" + @year + "' where MaLuong = '" + tbWageID.Text + "'");
                if (nhanvien.executeQuery(edit) != 0)
                    XtraMessageBox.Show("Chỉnh sửa thành công. Vui lòng click vào bảng Lương bên dưới để cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("delete from Luong where MaLuong = '" + tbWageID.Text + "'");
            if (tbWageID.Text != "" && tbDayEdit.Text != "" && tbWageEdit.Text != "")
            {
                XtraMessageBox.Show("Xóa thành công. Vui lòng click vào bảng Lương bên dưới để cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nhanvien.executeQuery(delete);
            }
            else
                XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            //ấn nút tìm kiếm để lấy thông tin lương theo mã
            string search = "select * from Luong where MaLuong = '" + tbWageID.Text + "'";
            nhanvien.readDatathroughAdapter(search, dtLuong);
            if (dtLuong.Rows.Count != 0 && tbDayEdit.Text == "" && tbWageEdit.Text == "")
            {
                XtraMessageBox.Show("Tìm kiếm thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lấy thông tin Lương từ dtb
                day = dtLuong.Rows[0]["NgayCong"].ToString();
                wage = dtLuong.Rows[0]["LuongCB"].ToString();
                month = dtLuong.Rows[0]["Thang"].ToString();
                if (Int32.Parse(month) < 10)
                {
                    month = "0" + month;
                }
                year = dtLuong.Rows[0]["Nam"].ToString();

                //hiện thông tin Lương
                tbDayEdit.Text = day;
                tbWageEdit.Text = wage;
                monthYPicker2.Value.Month.ToString(month);
                monthYPicker2.Value.Year.ToString(year);
                //monthYPicker2.Value.Year.ToString(year);
            }
            else
            {
                XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void cbbCateAdd_TextChanged(object sender, EventArgs e)
        {
            tbStaffID.Clear();
            tbDayAdd.Clear();
            tbWageAdd.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("delete from Luong where MaLuong = '" + tbWageID.Text + "'");
            if (tbWageID.Text != "" && tbDayEdit.Text != "" && tbWageEdit.Text != "")
            {
                XtraMessageBox.Show("Xóa thành công. Vui lòng click vào bảng Lương bên dưới để cập nhật", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nhanvien.executeQuery(delete);
            }
            else
                XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
