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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvXoaNV = new System.Windows.Forms.DataGridView();
            this.bt1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXoaNV
            // 
            this.dgvXoaNV.AllowUserToAddRows = false;
            this.dgvXoaNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXoaNV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXoaNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXoaNV.ColumnHeadersHeight = 26;
            this.dgvXoaNV.Location = new System.Drawing.Point(3, 73);
            this.dgvXoaNV.Name = "dgvXoaNV";
            this.dgvXoaNV.Size = new System.Drawing.Size(880, 299);
            this.dgvXoaNV.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Tomato;
            this.bt1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(324, 14);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(148, 43);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Xóa bản ghi";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // uctXoaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.dgvXoaNV);
            this.Name = "uctXoaNV";
            this.Size = new System.Drawing.Size(883, 476);
            this.Load += new System.EventHandler(this.uctXoaNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXoaNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXoaNV;
        private System.Windows.Forms.Button bt1;
    }
}
