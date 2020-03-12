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
    public partial class uctThemNV : DevExpress.XtraEditors.XtraUserControl
    {
        AccessDataBase nhanvien = new AccessDataBase();
        
        public uctThemNV()
        {
            InitializeComponent();
        }
        public static uctThemNV themnv = new uctThemNV();

        private void Button1_Click(object sender, EventArgs e)
        {
            string sqlconnectStr = "Data Source=DESKTOP-PGQHHD3\\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
            SqlConnection connection = new SqlConnection(sqlconnectStr);
            connection.Open();
            string gioiTinh,maphongBan,maloaiHopDong,machucVu,maNhanVien,maLuong,maTrinhDo;
            //Mã nhân viên
            maNhanVien = "BA" + txbCMND.Text;


            //phòng ban
            if (comboBoxPhongBan.Text.Equals("Phòng Kỹ Thuật") == true)
                maphongBan = "PB02";
            else 
                maphongBan = "PB03";

            //chức vụ

            if (comboBoxChuVu.Text.Equals("Ban Giám Đốc") == true)
                machucVu = "GD";
            else if (comboBoxChuVu.Text.Equals("Trưởng phòng") == true)
                machucVu = "TP";
            else 
                machucVu = "NV";

            //Loại hợp đồng

            if (comboBoxLoaiHD.Text.Equals("Hợp đồng CTV") == true)
                maloaiHopDong = "CTV";
            else
                maloaiHopDong = "HDLD";

            //giới tính
            if (radioButtonNam.Checked == true) gioiTinh = "Nam"; else gioiTinh = "Nữ";

            //trình độ
            if (comboBoxTrinhDo.Text.Equals("Manager") == true)
                maTrinhDo = "1";
            else if (comboBoxTrinhDo.Text.Equals("Development") == true)
                maTrinhDo = "2";
            else
                maTrinhDo = "3";
            int dem = 0;
            SqlCommand query_name = new SqlCommand("SELECT CMTND FROM NhanVien WHERE CMTND LIKE '" + txbCMND.Text + "'", connection);
            using (SqlDataReader reader = query_name.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Đọc kết quả
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}", reader[0].ToString());
                        if (reader[0].ToString().Equals(txbCMND.Text))
                            dem = 1;

                    }
                }
            }
            if (dem==1)
                XtraMessageBox.Show("Nhân viên đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //lương
                int luong = Convert.ToInt32(txbLuong.Text);
                if (luong <= 1000000)
                    maLuong = "LuongCTV" + txbCMND.Text;
                else
                    maLuong = "LuongHDLD" + txbCMND.Text;

                //chạy lệnh update Lương
                SqlCommand query0 = new SqlCommand("INSERT Luong values ('" + maLuong + "','1','" + txbLuong.Text + "')");
                nhanvien.executeQuery(query0);
                ////chạy lệnh update nhân viên
                SqlCommand query = new SqlCommand("INSERT NhanVien values('" + maNhanVien + "','" + txbhoTen.Text + "', '" + ngaySinh.Value.ToString() + "'," +
                    " '" + gioiTinh + "', '" + txbDanToc.Text + "', '" + txbCMND.Text + "','" + txbSDT.Text + "', '"
                    + txbDiaChi.Text + "', '" + maphongBan + "', '" + machucVu + "', '" + maloaiHopDong + "', '" + maTrinhDo + "', '" + maLuong + "')");
                nhanvien.executeQuery(query);
                XtraMessageBox.Show("Thêm mới nhân viên thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gboxthemmoi_Enter(object sender, EventArgs e)
        {

        }
    }
}
