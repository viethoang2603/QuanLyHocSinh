namespace NMCNPM_QLHS.GUI
{
    partial class frmThongTinNguoiDung
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lbTenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            this.lbTenNgDung = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 65);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(103, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên người dùng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 111);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên tài khoản:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 158);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Chức vụ:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbChucVu);
            this.groupControl1.Controls.Add(this.lbTenTaiKhoan);
            this.groupControl1.Controls.Add(this.lbTenNgDung);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(362, 244);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // lbChucVu
            // 
            this.lbChucVu.Location = new System.Drawing.Point(152, 158);
            this.lbChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(0, 16);
            this.lbChucVu.TabIndex = 5;
            // 
            // lbTenTaiKhoan
            // 
            this.lbTenTaiKhoan.Location = new System.Drawing.Point(152, 111);
            this.lbTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTenTaiKhoan.Name = "lbTenTaiKhoan";
            this.lbTenTaiKhoan.Size = new System.Drawing.Size(0, 16);
            this.lbTenTaiKhoan.TabIndex = 4;
            // 
            // lbTenNgDung
            // 
            this.lbTenNgDung.Location = new System.Drawing.Point(152, 65);
            this.lbTenNgDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTenNgDung.Name = "lbTenNgDung";
            this.lbTenNgDung.Size = new System.Drawing.Size(0, 16);
            this.lbTenNgDung.TabIndex = 3;
            // 
            // frmThongTinNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 244);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongTinNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin người dùng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThongTinNguoiDung_FormClosed);
            this.Load += new System.EventHandler(this.frmThongTinNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbChucVu;
        private DevExpress.XtraEditors.LabelControl lbTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lbTenNgDung;
    }
}