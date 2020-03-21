namespace QuanLyNhanSu.Views
{
    partial class uctTrinhDo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTrinhDo = new System.Windows.Forms.DataGridView();
            this.gbTrinhDo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID_TrinhDo = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbChuyenNganh = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).BeginInit();
            this.gbTrinhDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrinhDo
            // 
            this.dgvTrinhDo.AllowUserToAddRows = false;
            this.dgvTrinhDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrinhDo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrinhDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrinhDo.ColumnHeadersHeight = 26;
            this.dgvTrinhDo.Location = new System.Drawing.Point(298, 44);
            this.dgvTrinhDo.Name = "dgvTrinhDo";
            this.dgvTrinhDo.Size = new System.Drawing.Size(497, 424);
            this.dgvTrinhDo.TabIndex = 1;
            // 
            // gbTrinhDo
            // 
            this.gbTrinhDo.BackColor = System.Drawing.Color.Honeydew;
            this.gbTrinhDo.Controls.Add(this.btXoa);
            this.gbTrinhDo.Controls.Add(this.btAdd);
            this.gbTrinhDo.Controls.Add(this.btTimKiem);
            this.gbTrinhDo.Controls.Add(this.tbChuyenNganh);
            this.gbTrinhDo.Controls.Add(this.tbName);
            this.gbTrinhDo.Controls.Add(this.tbID_TrinhDo);
            this.gbTrinhDo.Controls.Add(this.label3);
            this.gbTrinhDo.Controls.Add(this.label2);
            this.gbTrinhDo.Controls.Add(this.label1);
            this.gbTrinhDo.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.gbTrinhDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTrinhDo.Location = new System.Drawing.Point(3, 3);
            this.gbTrinhDo.Name = "gbTrinhDo";
            this.gbTrinhDo.Size = new System.Drawing.Size(262, 468);
            this.gbTrinhDo.TabIndex = 2;
            this.gbTrinhDo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Trình Độ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Trình Độ : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chuyên ngành : ";
            // 
            // tbID_TrinhDo
            // 
            this.tbID_TrinhDo.Location = new System.Drawing.Point(38, 50);
            this.tbID_TrinhDo.Name = "tbID_TrinhDo";
            this.tbID_TrinhDo.Size = new System.Drawing.Size(144, 21);
            this.tbID_TrinhDo.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(38, 133);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(144, 21);
            this.tbName.TabIndex = 8;
            // 
            // tbChuyenNganh
            // 
            this.tbChuyenNganh.Location = new System.Drawing.Point(38, 212);
            this.tbChuyenNganh.Name = "tbChuyenNganh";
            this.tbChuyenNganh.Size = new System.Drawing.Size(144, 21);
            this.tbChuyenNganh.TabIndex = 9;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.SpringGreen;
            this.btTimKiem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(52, 269);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(121, 35);
            this.btTimKiem.TabIndex = 11;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Tomato;
            this.btXoa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(52, 337);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(121, 35);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa bản ghi";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(52, 407);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 35);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Thêm bản ghi";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(480, 3);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 35);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "Lưu thay đổi";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // uctTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.gbTrinhDo);
            this.Controls.Add(this.dgvTrinhDo);
            this.Name = "uctTrinhDo";
            this.Size = new System.Drawing.Size(798, 471);
            this.Load += new System.EventHandler(this.uctTrinhDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrinhDo)).EndInit();
            this.gbTrinhDo.ResumeLayout(false);
            this.gbTrinhDo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrinhDo;
        private System.Windows.Forms.GroupBox gbTrinhDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChuyenNganh;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID_TrinhDo;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSave;
    }
}
