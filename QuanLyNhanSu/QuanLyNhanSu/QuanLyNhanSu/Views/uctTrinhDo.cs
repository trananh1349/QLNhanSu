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
    public partial class uctTrinhDo : DevExpress.XtraEditors.XtraUserControl
    {
        public static uctTrinhDo trinhdo = new uctTrinhDo();
        AccessDataBase db = new AccessDataBase();
        public uctTrinhDo()
        {
            InitializeComponent();
        }

        private void uctTrinhDo_Load(object sender, EventArgs e)
        {
            DataTable dttbLoad = new DataTable();
            string query = "Select * From TrinhDo";
            db.readDatathroughAdapter(query, dttbLoad);
            dgvTrinhDo.DataSource = dttbLoad;
        }
        private void RefeshList()
        {
            DataTable dttbLoad = new DataTable();
            string query = "Select * From TrinhDo";
            db.readDatathroughAdapter(query, dttbLoad);
            dgvTrinhDo.DataSource = dttbLoad;
        }
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TrinhDo Where MaTrinhDo Like N'%" 
                + tbID_TrinhDo.Text + "%' AND TenTrinhDo Like N'%" 
                + tbName.Text + "%' And ChuyenNghanh Like N'%" + tbChuyenNganh.Text +"%' ";
            DataTable dttb = new DataTable();
            db.readDatathroughAdapter(sql, dttb);
            dgvTrinhDo.DataSource = dttb;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvTrinhDo.RowCount == 0)
            {
                btXoa.Enabled = false;
            }
            else if (XtraMessageBox.Show("Bạn có chắc chắn xóa dòng này không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Chỉ mục hiện tại
                int selectIndex = dgvTrinhDo.SelectedRows[0].Index;
                string MaTrinhDo = Convert.ToString(dgvTrinhDo[0, selectIndex].Value);
                //query
                string sql = "DELETE FROM TrinhDo Where MaTrinhDo = '" + MaTrinhDo + "' ;";
                SqlCommand deteRow = new SqlCommand(sql);
                db.executeQuery(deteRow);
                //Remove khỏi datagird
                dgvTrinhDo.Rows.RemoveAt(selectIndex);
                //dgvXoaNV.DataSource = dttbLoad;
                this.RefeshList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TrinhDo Where MaTrinhDo = '" + tbID_TrinhDo.Text + "' ";
            DataTable dttb = new DataTable();
            db.readDatathroughAdapter(sql, dttb);
            if(dttb.Rows.Count > 0)
            {
                XtraMessageBox.Show("Mã Trình Độ đã tồn tại !!","Thông tin" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                string query = "Insert Into TrinhDo values ('" +
                    tbID_TrinhDo.Text + "', '" + tbName.Text + "', '" +
                    tbChuyenNganh.Text + "' )";
                SqlCommand insertCom = new SqlCommand(query);
                db.executeQuery(insertCom);

                this.RefeshList();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SqlCommand saveCom = new SqlCommand(@"UPDATE TrinhDo
                                       SET TenTrinhDo = @TTD , 
                                            ChuyenNghanh = @CN
                                        WHERE MaTrinhDo = @MTD");
            saveCom.Parameters.Add("@TTD", SqlDbType.NVarChar).Value = "";
            saveCom.Parameters.Add("@CN", SqlDbType.VarChar).Value = "";
            saveCom.Parameters.Add("@MTD", SqlDbType.VarChar).Value = "";
            
            foreach(DataGridViewRow row in dgvTrinhDo.Rows)
            {
                saveCom.Parameters["@MTD"].Value = row.Cells["MaTrinhDo"].Value.ToString();
                saveCom.Parameters["@TTD"].Value = row.Cells["TenTrinhDo"].Value.ToString();
                saveCom.Parameters["@CN"].Value = row.Cells["ChuyenNghanh"].Value.ToString();     
                db.executeQuery(saveCom);
            }
            XtraMessageBox.Show("Lưu thông tin thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.RefeshList();
        }
    }
}
