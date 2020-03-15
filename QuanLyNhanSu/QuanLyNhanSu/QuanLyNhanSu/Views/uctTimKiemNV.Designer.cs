namespace QuanLyNhanSu.Views
{
    partial class uctTimKiemNV
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPhongBan = new System.Windows.Forms.ComboBox();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.dataGridViewTimKiem = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(76, 59);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(111, 21);
            this.txtTen.TabIndex = 0;
            this.txtTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên";
            // 
            // cbxPhongBan
            // 
            this.cbxPhongBan.FormattingEnabled = true;
            this.cbxPhongBan.Location = new System.Drawing.Point(76, 110);
            this.cbxPhongBan.Name = "cbxPhongBan";
            this.cbxPhongBan.Size = new System.Drawing.Size(111, 21);
            this.cbxPhongBan.TabIndex = 2;
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Location = new System.Drawing.Point(76, 157);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(111, 21);
            this.cbxChucVu.TabIndex = 3;
            // 
            // dataGridViewTimKiem
            // 
            this.dataGridViewTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiem.Location = new System.Drawing.Point(265, 0);
            this.dataGridViewTimKiem.Name = "dataGridViewTimKiem";
            this.dataGridViewTimKiem.Size = new System.Drawing.Size(550, 356);
            this.dataGridViewTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(76, 212);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(74, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chức vụ";
            // 
            // uctTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridViewTimKiem);
            this.Controls.Add(this.cbxChucVu);
            this.Controls.Add(this.cbxPhongBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Name = "uctTimKiemNV";
            this.Size = new System.Drawing.Size(846, 406);
            this.Load += new System.EventHandler(this.uctTimKiemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPhongBan;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.DataGridView dataGridViewTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
