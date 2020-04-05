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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbMaTP = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaTP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(678, 24);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(513, 362);
            this.dgvPhongBan.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Appearance.BackColor = System.Drawing.Color.Aqua;
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Location = new System.Drawing.Point(201, 425);
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
            this.btnTimKiem.Location = new System.Drawing.Point(353, 425);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(59, 46);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(176, 92);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaPB.Properties.Appearance.Options.UseFont = true;
            this.txtMaPB.Size = new System.Drawing.Size(181, 22);
            this.txtMaPB.TabIndex = 5;
            // 
            // txtDD
            // 
            this.txtDD.Location = new System.Drawing.Point(176, 251);
            this.txtDD.Name = "txtDD";
            this.txtDD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDD.Properties.Appearance.Options.UseFont = true;
            this.txtDD.Size = new System.Drawing.Size(181, 22);
            this.txtDD.TabIndex = 6;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(176, 173);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenPB.Properties.Appearance.Options.UseFont = true;
            this.txtTenPB.Size = new System.Drawing.Size(181, 22);
            this.txtTenPB.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(203, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 24);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Mã Phòng Ban";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(195, 131);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 24);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Tên Phòng Ban";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(218, 210);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 24);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Địa Điểm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(271, 425);
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
            this.btnThem.Location = new System.Drawing.Point(110, 425);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 46);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(176, 298);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(157, 24);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Mã Trưởng Phòng";
            // 
            // tbMaTP
            // 
            this.tbMaTP.Location = new System.Drawing.Point(176, 340);
            this.tbMaTP.Name = "tbMaTP";
            this.tbMaTP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbMaTP.Properties.Appearance.Options.UseFont = true;
            this.tbMaTP.Size = new System.Drawing.Size(181, 22);
            this.tbMaTP.TabIndex = 11;
            // 
            // uctPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tbMaTP);
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
            this.Size = new System.Drawing.Size(1338, 520);
            this.Load += new System.EventHandler(this.uctPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenPB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaTP.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbMaTP;
    }
}
