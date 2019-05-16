namespace QuanLyHocSinhDemo
{
    partial class frmDanhSachLop
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbnNamHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbnHocKy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbnLop = new System.Windows.Forms.ComboBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrDanhSachLop = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbnNamHoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbnHocKy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbnLop);
            this.groupBox1.Controls.Add(this.txtSiSo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cbnNamHoc
            // 
            this.cbnNamHoc.FormattingEnabled = true;
            this.cbnNamHoc.Location = new System.Drawing.Point(396, 32);
            this.cbnNamHoc.Name = "cbnNamHoc";
            this.cbnNamHoc.Size = new System.Drawing.Size(68, 21);
            this.cbnNamHoc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Năm Học";
            // 
            // cbnHocKy
            // 
            this.cbnHocKy.FormattingEnabled = true;
            this.cbnHocKy.Location = new System.Drawing.Point(223, 34);
            this.cbnHocKy.Name = "cbnHocKy";
            this.cbnHocKy.Size = new System.Drawing.Size(68, 21);
            this.cbnHocKy.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Học kỳ";
            // 
            // cbnLop
            // 
            this.cbnLop.FormattingEnabled = true;
            this.cbnLop.Location = new System.Drawing.Point(54, 34);
            this.cbnLop.Name = "cbnLop";
            this.cbnLop.Size = new System.Drawing.Size(68, 21);
            this.cbnLop.TabIndex = 6;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiSo.Location = new System.Drawing.Point(564, 31);
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.ReadOnly = true;
            this.txtSiSo.Size = new System.Drawing.Size(68, 22);
            this.txtSiSo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sĩ số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrDanhSachLop);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Lớp";
            // 
            // dgrDanhSachLop
            // 
            this.dgrDanhSachLop.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgrDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrDanhSachLop.Location = new System.Drawing.Point(3, 16);
            this.dgrDanhSachLop.Name = "dgrDanhSachLop";
            this.dgrDanhSachLop.Size = new System.Drawing.Size(678, 265);
            this.dgrDanhSachLop.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(247, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(242, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 26);
            this.label3.TabIndex = 29;
            this.label3.Text = "DANH SÁCH LỚP";
            // 
            // frmDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 484);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDanhSachLop";
            this.Text = "Danh Sách Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrDanhSachLop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbnNamHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbnHocKy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbnLop;
    }
}