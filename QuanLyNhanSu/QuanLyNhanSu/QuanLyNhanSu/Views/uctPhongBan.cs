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
    public partial class uctPhongBan : DevExpress.XtraEditors.XtraUserControl
    {
        public static uctPhongBan phongban = new uctPhongBan();
        AccessDataBase db = new AccessDataBase();
        string queryAll = "Select * from PhongBan";
        public uctPhongBan()
        {
            InitializeComponent();
        }

        public void ShowList(string query)
        {

            DataTable dt = new DataTable();
            db.readDatathroughAdapter(query, dt);
            dgvPhongBan.DataSource = dt;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            //Nut Tim kiem
            string queryTimKiem = "Select * from PhongBan where TenPhongBan like N'%" + txtTenPB.Text + "%' and MaPhongBan like N'%" + txtMaPB.Text +
                "%' and DiaDiem like N'%" + txtDD.Text + "%'";
            ShowList(queryTimKiem);
            txtDD.Text = "";
            txtMaPB.Text = "PB";
            txtTenPB.Text = "";

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //Nut Xoa
            if (dgvPhongBan.Rows.Count == 0)
            {
                btnXoa.Enabled = false;
            }
            else
            {
                try
                {
                    DialogResult confirm = XtraMessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        int selectIndex = dgvPhongBan.SelectedRows[0].Index;
                        string MaPhongBan = Convert.ToString(dgvPhongBan[0, selectIndex].Value);
                        string sql = "DELETE FROM PhongBan Where MaPhongBan = '" + MaPhongBan + "' ;";
                        SqlCommand deteleRow = new SqlCommand(sql);
                        db.executeQuery(deteleRow);
                        //Remove khỏi datagird
                        dgvPhongBan.Rows.RemoveAt(selectIndex);
                        ShowList(queryAll);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error : " + ex.ToString());
                }


            }

        }

        private void uctPhongBan_Load(object sender, EventArgs e)
        {
            txtMaPB.Text = "PB";
            ShowList(queryAll);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDD.Text == "" || txtMaPB.Text == "" || txtTenPB.Text == "" || tbMaTP.Text == "")
                {
                    XtraMessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    string sql = "SELECT * FROM PhongBan Where MaPhongBan = '" + txtMaPB.Text + "' ";
                    DataTable dt = new DataTable();
                    db.readDatathroughAdapter(sql, dt);
                    if (dt.Rows.Count > 0)
                    {
                        XtraMessageBox.Show("Mã Phòng Ban đã tồn tại !!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string query = "Insert PhongBan values ('" +
                            txtMaPB.Text + "', '" + txtTenPB.Text + "', '" +
                            txtDD.Text + "','" + tbMaTP.Text + "')";
                        SqlCommand insertCom = new SqlCommand(query);
                        db.executeQuery(insertCom);
                        XtraMessageBox.Show("Thêm thông tin thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowList(queryAll);
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand saveCom = new SqlCommand(@"UPDATE PhongBan
                                       SET TenPhongBan = @TenPB , 
                                            DiaDiem = @DD ,MaTP = @MTP
                                        WHERE MaPhongBan = @MaPB");

                saveCom.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = "";
                saveCom.Parameters.Add("@DD", SqlDbType.VarChar).Value = "";
                saveCom.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = "";
                saveCom.Parameters.Add("@MTP", SqlDbType.VarChar).Value = "";

                int i = 0;
                foreach (DataGridViewRow row in dgvPhongBan.Rows)
                {
                    i++;
                    if (i <= dgvPhongBan.Rows.Count - 1)
                    {
                        saveCom.Parameters["@MaPB"].Value = row.Cells["MaPhongBan"].Value.ToString();
                        saveCom.Parameters["@TenPB"].Value = row.Cells["TenPhongBan"].Value.ToString();
                        saveCom.Parameters["@DD"].Value = row.Cells["DiaDiem"].Value.ToString();
                        saveCom.Parameters["@MTP"].Value = row.Cells["MaTP"].Value.ToString();
                        db.executeQuery(saveCom);
                    }


                }
                XtraMessageBox.Show("Lưu thành công");
                ShowList(queryAll);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Lỗi thao tác. Vui lòng thử lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
