namespace QuanLyNhanSu.Views
{
    partial class uctXoaNV
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvXoaNV = new System.Windows.Forms.DataGridView();
            this.bt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXoaNV
            // 
            this.dgvXoaNV.AllowUserToAddRows = false;
            this.dgvXoaNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXoaNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXoaNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXoaNV.ColumnHeadersHeight = 26;
            this.dgvXoaNV.Location = new System.Drawing.Point(181, 0);
            this.dgvXoaNV.Name = "dgvXoaNV";
            this.dgvXoaNV.Size = new System.Drawing.Size(699, 447);
            this.dgvXoaNV.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.AutoSize = true;
            this.bt1.BackColor = System.Drawing.Color.Tomato;
            this.bt1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(25, 332);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(121, 34);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Xóa bản ghi";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phòng ban : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chức vụ : ";
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(25, 26);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(121, 21);
            this.tbMaNV.TabIndex = 6;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(25, 80);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(121, 21);
            this.tbHoTen.TabIndex = 7;
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Items.AddRange(new object[] {
            "Phòng Kỹ Thuật",
            "Phòng Hành Chính"});
            this.cbPhongBan.Location = new System.Drawing.Point(25, 149);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(121, 21);
            this.cbPhongBan.TabIndex = 8;
            // 
            // cbChucVu
            // 
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Ban Giám Đốc",
            "Nhân viên",
            "Trưởng phòng"});
            this.cbChucVu.Location = new System.Drawing.Point(25, 211);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbChucVu.TabIndex = 9;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.SpringGreen;
            this.btTimKiem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(25, 267);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(121, 35);
            this.btTimKiem.TabIndex = 10;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // uctXoaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.cbPhongBan);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.dgvXoaNV);
            this.Name = "uctXoaNV";
            this.Size = new System.Drawing.Size(883, 447);
            this.Load += new System.EventHandler(this.uctXoaNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXoaNV;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Button btTimKiem;
    }
}
