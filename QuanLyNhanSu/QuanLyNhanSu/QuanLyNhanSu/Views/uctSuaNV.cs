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
    public partial class uctSuaNV : DevExpress.XtraEditors.XtraUserControl
    {
        AccessDataBase nhanvien = new AccessDataBase();
        DataTable dtNhanVien = new DataTable();

        public static string name, gender, address, teleNum, IDN, race, contract, level, department, position, wageID, dateOB;
        public static int wage;

        public uctSuaNV()
        {
            InitializeComponent();
        }
        public static uctSuaNV suanv = new uctSuaNV();

        private void uctSuaNV_Load(object sender, EventArgs e)
        {
            //Lấy danh sách mã Nhân Viên vào bảng bên cạnh
            //SqlDataAdapter da = new SqlDataAdapter("select MaNV, HoTen from NhanVien", AccessDataBase.connection);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridViewID.DataSource = dt;

            DataTable dttbLoad = new DataTable();
            string query = "Select MaNV, HoTen From NhanVien";
            nhanvien.readDatathroughAdapter(query, dttbLoad);
            dataGridViewID.DataSource = dttbLoad;
        }

        public void Appear()
        {
            //xuất hiện các thông tin của Nhân viên tương ứng
            txbName.Text = name;

            if (gender == "Nam")
                radiobM.Checked = true;
            else
                radiobF.Checked = true;

            txbAddress.Text = address;
            txbTeleNum.Text = teleNum;
            txbIDN.Text = IDN;
            date.Text = dateOB;
            txbRace.Text = race;

            if (contract == "HDLD")
                cbbContract.Text = "Hop dong lao dong";
            else if (contract == "CTV")
                cbbContract.Text = "Hop dong CTV";

            if (level == "1")
                cbbLevel.Text = "Manager";
            else if (level == "2")
                cbbLevel.Text = "Development";
            else if (level == "3")
                cbbLevel.Text = "Test";

            if (department == "PB02")
                cbbDepartment.Text = "Phong Ky Thuat";
            else if (department == "PB03")
                cbbDepartment.Text = "Phong Hanh Chinh";

            if (position == "GD")
                cbbPosition.Text = "Giam Doc";
            else if (position == "NV")
                cbbPosition.Text = "Nhan Vien";
            else if (position == "TP")
                cbbPosition.Text = "Truong Phong";

            if (wageID.Contains("LuongHDLD"))
            {
                wage = 5000000;
                txbWage.Text = "5000000";
            }
            else if (wageID.Contains("LuongCTV"))
            {
                wage = 1000000;
                txbWage.Text = "1000000";
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //ấn nút tìm kiếm để lấy thông tin Nhân viên
            string query1 = "select * from NhanVien where MaNV = '" + txtboxID.Text + "'";
            nhanvien.readDatathroughAdapter(query1, dtNhanVien);
            if (dtNhanVien.Rows.Count != 0)
            {
                //lấy thông tin nhân viên từ dtb
                name = dtNhanVien.Rows[0]["HoTen"].ToString();
                gender = dtNhanVien.Rows[0]["GioiTinh"].ToString();
                address = dtNhanVien.Rows[0]["DiaChi"].ToString();
                race = dtNhanVien.Rows[0]["DanToc"].ToString();
                teleNum = dtNhanVien.Rows[0]["SDT"].ToString();
                contract = dtNhanVien.Rows[0]["MaHD"].ToString();
                IDN = dtNhanVien.Rows[0]["CMTND"].ToString();
                level = dtNhanVien.Rows[0]["MaTrinhDo"].ToString();
                department = dtNhanVien.Rows[0]["MaPhongBan"].ToString();
                position = dtNhanVien.Rows[0]["MaCV"].ToString();
                wageID = dtNhanVien.Rows[0]["MaLuong"].ToString();
                dateOB = dtNhanVien.Rows[0]["NgaySinh"].ToString();
                //hiện thông tin nhân viên
                Appear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mã nhân viên!!", "Lỗi.");
            }
        }

        public void ClearAll()
        {
            //xóa nhanh toàn bộ thông tin có trên màn hình
            txtboxID.Clear();
            txbName.Clear();
            radiobM.Checked = false;
            radiobF.Checked = false;
            txbAddress.Clear();
            txbTeleNum.Clear();
            txbIDN.Clear();
            date.ResetText();
            txbRace.Clear();
            cbbContract.ResetText();
            cbbLevel.ResetText();
            cbbDepartment.ResetText();
            cbbPosition.ResetText();
            txbWage.Clear();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            //ấn nút reset để xóa nhanh và chỉnh sửa Nhân viên khác
            ClearAll();
            dtNhanVien.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //ấn nút Chỉnh sửa để thực hiện thao tác chỉnh sửa
                name = txbName.Text;

                if (radiobM.Checked == true)
                    gender = "Nam";
                else if (radiobF.Checked == true)
                    gender = "Nu";

                address = txbAddress.Text;
                teleNum = txbTeleNum.Text;
                IDN = txbIDN.Text;
                dateOB = date.Value.ToString();
                race = txbRace.Text;

                if (cbbContract.Text == "Hop dong lao dong")
                    contract = "HDLD";
                else if (cbbContract.Text == "Hop dong CTV")
                    contract = "CTV";

                if (cbbLevel.Text == "Manager")
                    level = "1";
                else if (cbbLevel.Text == "Development")
                    level = "2";
                else if (cbbLevel.Text == "Test")
                    level = "3";

                if (cbbDepartment.Text == "Phong Ky Thuat")
                    department = "PB02";
                else if (cbbDepartment.Text == "Phong Hanh Chinh")
                    department = "PB03";

                if (cbbPosition.Text == "Giam Doc")
                    position = "GD";
                else if (cbbPosition.Text == "Nhan Vien")
                    position = "NV";
                else if (cbbPosition.Text == "Truong Phong")
                    position = "TP";

                wage = Convert.ToInt32(txbWage.Text);
                if (wage <= 1000000)
                    wageID = "LuongCTV" + txbIDN.Text;
                else if (wage > 1000000)
                    wageID = "LuongHDLD" + txbIDN.Text;

                string query = "update NhanVien set HoTen = '" + @name + "', GioiTinh = '" + @gender + "', DiaChi = '" + @address + "', SDT = '" + @teleNum + "', CMTND = '" + @IDN + "', MaHD = '" + @contract
                    + "', MaTrinhDo = '" + @level + "', MaPhongBan = '" + @department + "', MaCV = '" + @position + "', MaLuong = '" + @wageID + "', NgaySinh = '" + @dateOB + "', DanToc = '" + @race
                    + "' where MaNV = '" + txtboxID.Text + "'";

                SqlCommand update = new SqlCommand(query);

                if (nhanvien.executeQuery(update) != 0)
                    MessageBox.Show("Chỉnh sửa thành công.", "Chúc mừng.");
                else
                    MessageBox.Show("Chỉnh sửa không thành công!!!", "Lỗi.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    //private static string strConnString = "Data Source=WIN7PROX64\\SQLEXPRESS;Initial Catalog = QuanLyNhanSu; Integrated Security = True"; 
    //string sqlconnectStr = "Data Source=WIN7PROX64\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security = True";
    //SqlConnection connection = new SqlConnection(sqlconnectStr);
    //connection.Open();
}
