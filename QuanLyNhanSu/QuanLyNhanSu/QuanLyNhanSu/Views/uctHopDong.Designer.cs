﻿namespace QuanLyNhanSu.Views
{
    partial class uctHopDong
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
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.Lưu = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.tbMaHopDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLoaiHopDong = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Location = new System.Drawing.Point(581, 216);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.Size = new System.Drawing.Size(546, 257);
            this.dgvHopDong.TabIndex = 0;
            // 
            // Lưu
            // 
            this.Lưu.Location = new System.Drawing.Point(1021, 128);
            this.Lưu.Name = "Lưu";
            this.Lưu.Size = new System.Drawing.Size(97, 41);
            this.Lưu.TabIndex = 1;
            this.Lưu.Text = "Lưu Thay Đổi";
            this.Lưu.Click += new System.EventHandler(this.Lưu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(581, 128);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 41);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(878, 128);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 41);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(731, 128);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 41);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tbMaHopDong
            // 
            this.tbMaHopDong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbMaHopDong.Location = new System.Drawing.Point(174, 97);
            this.tbMaHopDong.Name = "tbMaHopDong";
            this.tbMaHopDong.Size = new System.Drawing.Size(182, 27);
            this.tbMaHopDong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label1.Location = new System.Drawing.Point(203, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Hợp Đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(203, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loại Hợp Đồng";
            // 
            // tbLoaiHopDong
            // 
            this.tbLoaiHopDong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbLoaiHopDong.Location = new System.Drawing.Point(174, 194);
            this.tbLoaiHopDong.Name = "tbLoaiHopDong";
            this.tbLoaiHopDong.Size = new System.Drawing.Size(182, 27);
            this.tbLoaiHopDong.TabIndex = 7;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(174, 276);
            this.startTime.MinDate = new System.DateTime(2020, 3, 29, 20, 14, 13, 0);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 21);
            this.startTime.TabIndex = 9;
            this.startTime.Value = new System.DateTime(2020, 3, 29, 20, 14, 13, 0);
            this.startTime.ValueChanged += new System.EventHandler(this.startTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.Location = new System.Drawing.Point(203, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Từ Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label4.Location = new System.Drawing.Point(203, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đến Ngày";
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(174, 358);
            this.endTime.MinDate = new System.DateTime(2020, 3, 29, 20, 14, 36, 0);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 21);
            this.endTime.TabIndex = 11;
            this.endTime.Value = new System.DateTime(2020, 3, 29, 20, 14, 36, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.Location = new System.Drawing.Point(203, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ghi Chú";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tbGhiChu.Location = new System.Drawing.Point(174, 446);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(182, 27);
            this.tbGhiChu.TabIndex = 13;
            // 
            // uctHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLoaiHopDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaHopDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.Lưu);
            this.Controls.Add(this.dgvHopDong);
            this.Name = "uctHopDong";
            this.Size = new System.Drawing.Size(1200, 528);
            this.Load += new System.EventHandler(this.uctHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHopDong;
        private DevExpress.XtraEditors.SimpleButton Lưu;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox tbMaHopDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLoaiHopDong;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGhiChu;
    }
}
