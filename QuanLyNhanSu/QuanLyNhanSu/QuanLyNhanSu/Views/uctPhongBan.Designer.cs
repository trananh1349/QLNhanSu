namespace QuanLyNhanSu.Views
{
    partial class uctPhongBan
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
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPB = new DevExpress.XtraEditors.TextEdit();
            this.txtDD = new DevExpress.XtraEditors.TextEdit();
            this.txtTenPB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(349, 23);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(574, 364);
            this.dgvPhongBan.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Location = new System.Drawing.Point(105, 314);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(45, 46);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Appearance.Options.UseBackColor = true;
            this.btnTimKiem.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiem.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.AppearancePressed.Options.UseBackColor = true;
            this.btnTimKiem.Location = new System.Drawing.Point(257, 314);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(59, 46);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(64, 76);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(181, 20);
            this.txtMaPB.TabIndex = 5;
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(64, 235);
            this.txtDD.Name = "txtDD";
            this.txtDD.Size = new System.Drawing.Size(181, 20);
            this.txtDD.TabIndex = 6;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(64, 157);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(181, 20);
            this.txtTenPB.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(105, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 20);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã Phòng Ban";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(105, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 20);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Tên Phòng Ban";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Bradley Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(120, 197);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 20);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Địa Điểm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(175, 314);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Location = new System.Drawing.Point(14, 314);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 46);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // uctPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtDD);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhongBan);
            this.Name = "uctPhongBan";
            this.Size = new System.Drawing.Size(938, 489);
            this.Load += new System.EventHandler(this.uctPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhongBan;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.TextEdit txtMaPB;
        private DevExpress.XtraEditors.TextEdit txtDD;
        private DevExpress.XtraEditors.TextEdit txtTenPB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
