namespace QuanLyNhanSu.Views
{
    partial class uctThongKe
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
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.comboBoxThang = new System.Windows.Forms.ComboBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.Location = new System.Drawing.Point(651, 21);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(159, 36);
            this.buttonThongKe.TabIndex = 0;
            this.buttonThongKe.Text = "Thống Kê";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            this.buttonThongKe.Click += new System.EventHandler(this.ButtonThongKe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBoxNam.Location = new System.Drawing.Point(528, 32);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(79, 21);
            this.comboBoxNam.TabIndex = 4;
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(360, 31);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(84, 21);
            this.comboBoxThang.TabIndex = 5;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(109, 31);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(168, 21);
            this.txbHoTen.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 300);
            this.dataGridView1.TabIndex = 7;
            // 
            // uctThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.comboBoxThang);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonThongKe);
            this.Name = "uctThongKe";
            this.Size = new System.Drawing.Size(849, 409);
            this.Load += new System.EventHandler(this.uctThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.ComboBox comboBoxThang;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
