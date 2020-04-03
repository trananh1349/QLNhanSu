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

namespace QuanLyNhanSu.Views
{
    public partial class uctHopDong : DevExpress.XtraEditors.XtraUserControl
    {
        public static uctHopDong hopdong = new uctHopDong();
        Models.AccessDataBase db = new Models.AccessDataBase();
        public uctHopDong()
        {
            InitializeComponent();
        }

        private void uctHopDong_Load(object sender, EventArgs e)
        {
            DataTable dttbLoad = new DataTable();
            string query = "Select * From HopDong";
            db.readDatathroughAdapter(query, dttbLoad);
            dgvHopDong.DataSource = dttbLoad;
        }
        private void RefeshList()
        {
            DataTable dttbLoad = new DataTable();
            string query = "Select * From HopDong";
            db.readDatathroughAdapter(query, dttbLoad);
            dgvHopDong.DataSource = dttbLoad;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string startDate = startTime.Value.ToString().Split(' ')[0].Replace("/", "-");
                string endDate = endTime.Value.ToString().Split(' ')[0].Replace("/", "-");
                string query = "Select * From HopDong where MaHD LIKE N'%" + tbMaHopDong.Text + "%'" +
                " and LoaiHD LIKE N'%" + tbLoaiHopDong.Text + "%'" +
                " and TuNgay >= '" + startDate + "' and DenNgay <= '" + endDate + "'" +
                " and GhiChu LIKE N'%" + tbGhiChu.Text + "%'";
                DataTable dttb = new DataTable();
                db.readDatathroughAdapter(query, dttb);
                dgvHopDong.DataSource = dttb;
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Không tìm thấy thông tin hợp đồng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaHopDong.Text == "" || tbLoaiHopDong.Text == "")
                {
                    throw new Exception("Vui lòng điền đầy đủ thông tin !");
                }
                string startDate = startTime.Value.ToString().Split(' ')[0].Replace("/", "-");
                string endDate = endTime.Value.ToString().Split(' ')[0].Replace("/", "-");
                string sql = "SELECT * FROM HopDong Where MaHD = '" + tbMaHopDong.Text + "' ";
                DataTable dttb = new DataTable();
                db.readDatathroughAdapter(sql, dttb);
                if (dttb.Rows.Count > 0)
                {
                    XtraMessageBox.Show("Mã hợp đồng đã tồn tại !!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "Insert Into HopDong values ('" +
                        tbMaHopDong.Text + "', '" + tbLoaiHopDong.Text + "', '" +
                        startDate + "','" + endDate + "','" + tbGhiChu.Text + "' )";
                    SqlCommand insertCom = new SqlCommand(query);
                    db.executeQuery(insertCom);

                    this.RefeshList();
                }
            }
            catch (Exception err)
            {
                XtraMessageBox.Show(err.Message.ToString(), "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand saveCom = new SqlCommand(@"UPDATE HopDong
                                       SET LoaiHD = @LoaiHD , 
                                            TuNgay = @TuNgay,
                                            DenNgay = @DenNgay,
                                            GhiChu = @GhiChu
                                        WHERE MaHD = @MaHD");
                saveCom.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = "";
                saveCom.Parameters.Add("@LoaiHD", SqlDbType.NVarChar).Value = "";
                saveCom.Parameters.Add("@TuNgay", SqlDbType.VarChar).Value = "";
                saveCom.Parameters.Add("@DenNgay", SqlDbType.VarChar).Value = "";
                saveCom.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = "";

                foreach (DataGridViewRow row in dgvHopDong.Rows)
                {
                    if (row.Cells["MaHD"].Value != null)
                    {
                        saveCom.Parameters["@MaHD"].Value = row.Cells["MaHD"].Value.ToString();
                        saveCom.Parameters["@LoaiHD"].Value = row.Cells["LoaiHD"].Value.ToString();
                        string startDate = row.Cells["TuNgay"].Value.ToString().Split(' ')[0];
                        saveCom.Parameters["@TuNgay"].Value = startDate;
                        string endDate = row.Cells["DenNgay"].Value.ToString().Split(' ')[0];
                        saveCom.Parameters["@DenNgay"].Value = endDate;
                        saveCom.Parameters["@GhiChu"].Value = row.Cells["GhiChu"].Value.ToString();
                        db.executeQuery(saveCom);
                    }

                }
                XtraMessageBox.Show("Lưu thông tin thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.RefeshList();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHopDong.RowCount == 0)
                {
                    btnXoa.Enabled = false;
                }
                else if (XtraMessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Chỉ mục hiện tại
                    int selectIndex = dgvHopDong.SelectedRows[0].Index;
                    string MaHD = Convert.ToString(dgvHopDong[0, selectIndex].Value);
                    //query
                    string sql = "DELETE FROM HopDong Where MaHD = '" + MaHD + "' ;";
                    SqlCommand deteRow = new SqlCommand(sql);
                    db.executeQuery(deteRow);
                    //Remove khỏi datagird
                    dgvHopDong.Rows.RemoveAt(selectIndex);
                    //dgvXoaNV.DataSource = dttbLoad;
                    this.RefeshList();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
