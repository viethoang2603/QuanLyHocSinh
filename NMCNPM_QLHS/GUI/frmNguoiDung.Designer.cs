namespace NMCNPM_QLHS.GUI
{
    partial class frmNguoiDung
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.groupControlNguoiDung = new DevExpress.XtraEditors.GroupControl();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceNguoiDung = new System.Windows.Forms.BindingSource(this.components);
            this.dgvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_maNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_maHS_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_TenNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hoTen_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_LoaiNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_loaiNguoiDung_edit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_TenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diaChi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_MatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReset = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_gioiTinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_ngaySinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.col_email_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.bindingNavigatorHocSinh = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNguoiDung)).BeginInit();
            this.groupControlNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_loaiNguoiDung_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).BeginInit();
            this.bindingNavigatorHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlNguoiDung
            // 
            this.groupControlNguoiDung.Controls.Add(this.gridControlHocSinh);
            this.groupControlNguoiDung.Controls.Add(this.bindingNavigatorHocSinh);
            this.groupControlNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.groupControlNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlNguoiDung.Name = "groupControlNguoiDung";
            this.groupControlNguoiDung.Size = new System.Drawing.Size(833, 443);
            this.groupControlNguoiDung.TabIndex = 2;
            this.groupControlNguoiDung.Text = "Danh sách người dùng";
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.DataSource = this.bindingSourceNguoiDung;
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlHocSinh.Location = new System.Drawing.Point(2, 56);
            this.gridControlHocSinh.MainView = this.dgvNguoiDung;
            this.gridControlHocSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maHS_edit,
            this.col_hoTen_edit,
            this.col_gioiTinh_edit,
            this.col_ngaySinh_edit,
            this.col_diaChi_edit,
            this.col_email_edit,
            this.btnReset,
            this.col_loaiNguoiDung_edit});
            this.gridControlHocSinh.Size = new System.Drawing.Size(829, 385);
            this.gridControlHocSinh.TabIndex = 2;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvNguoiDung});
            // 
            // bindingSourceNguoiDung
            // 
            this.bindingSourceNguoiDung.DataSource = typeof(NMCNPM_QLHS.DAL.NGUOIDUNG);
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.dgvNguoiDung.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.dgvNguoiDung.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvNguoiDung.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dgvNguoiDung.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvNguoiDung.Appearance.GroupPanel.Options.UseFont = true;
            this.dgvNguoiDung.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgvNguoiDung.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.dgvNguoiDung.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_maNguoiDung,
            this.col_TenNguoiDung,
            this.col_LoaiNguoiDung,
            this.col_TenDangNhap,
            this.col_MatKhau});
            this.dgvNguoiDung.DetailHeight = 431;
            this.dgvNguoiDung.GridControl = this.gridControlHocSinh;
            this.dgvNguoiDung.GroupPanelText = "DANH SÁCH NGƯỜI DÙNG";
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.OptionsView.ShowFooter = true;
            // 
            // col_maNguoiDung
            // 
            this.col_maNguoiDung.Caption = "Mã người dùng";
            this.col_maNguoiDung.ColumnEdit = this.col_maHS_edit;
            this.col_maNguoiDung.FieldName = "MAND";
            this.col_maNguoiDung.MinWidth = 24;
            this.col_maNguoiDung.Name = "col_maNguoiDung";
            this.col_maNguoiDung.OptionsColumn.AllowEdit = false;
            this.col_maNguoiDung.Visible = true;
            this.col_maNguoiDung.VisibleIndex = 0;
            this.col_maNguoiDung.Width = 161;
            // 
            // col_maHS_edit
            // 
            this.col_maHS_edit.AutoHeight = false;
            this.col_maHS_edit.Name = "col_maHS_edit";
            // 
            // col_TenNguoiDung
            // 
            this.col_TenNguoiDung.Caption = "Tên người dùng";
            this.col_TenNguoiDung.ColumnEdit = this.col_hoTen_edit;
            this.col_TenNguoiDung.FieldName = "TENNGUOIDUNG";
            this.col_TenNguoiDung.MinWidth = 24;
            this.col_TenNguoiDung.Name = "col_TenNguoiDung";
            this.col_TenNguoiDung.Visible = true;
            this.col_TenNguoiDung.VisibleIndex = 1;
            this.col_TenNguoiDung.Width = 161;
            // 
            // col_hoTen_edit
            // 
            this.col_hoTen_edit.AutoHeight = false;
            this.col_hoTen_edit.Name = "col_hoTen_edit";
            // 
            // col_LoaiNguoiDung
            // 
            this.col_LoaiNguoiDung.Caption = "Loại người dùng";
            this.col_LoaiNguoiDung.ColumnEdit = this.col_loaiNguoiDung_edit;
            this.col_LoaiNguoiDung.FieldName = "LOAINGUOIDUNG.MALND";
            this.col_LoaiNguoiDung.MinWidth = 24;
            this.col_LoaiNguoiDung.Name = "col_LoaiNguoiDung";
            this.col_LoaiNguoiDung.Visible = true;
            this.col_LoaiNguoiDung.VisibleIndex = 2;
            this.col_LoaiNguoiDung.Width = 161;
            // 
            // col_loaiNguoiDung_edit
            // 
            this.col_loaiNguoiDung_edit.AutoHeight = false;
            this.col_loaiNguoiDung_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_loaiNguoiDung_edit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOAIND", "")});
            this.col_loaiNguoiDung_edit.DisplayMember = "TENLOAIND";
            this.col_loaiNguoiDung_edit.Name = "col_loaiNguoiDung_edit";
            this.col_loaiNguoiDung_edit.NullText = "";
            this.col_loaiNguoiDung_edit.ValueMember = "MALND";
            // 
            // col_TenDangNhap
            // 
            this.col_TenDangNhap.Caption = "Tên tài khoản";
            this.col_TenDangNhap.ColumnEdit = this.col_diaChi_edit;
            this.col_TenDangNhap.FieldName = "TENDANGNHAP";
            this.col_TenDangNhap.MinWidth = 24;
            this.col_TenDangNhap.Name = "col_TenDangNhap";
            this.col_TenDangNhap.Visible = true;
            this.col_TenDangNhap.VisibleIndex = 3;
            this.col_TenDangNhap.Width = 248;
            // 
            // col_diaChi_edit
            // 
            this.col_diaChi_edit.AutoHeight = false;
            this.col_diaChi_edit.Name = "col_diaChi_edit";
            // 
            // col_MatKhau
            // 
            this.col_MatKhau.ColumnEdit = this.btnReset;
            this.col_MatKhau.MinWidth = 24;
            this.col_MatKhau.Name = "col_MatKhau";
            this.col_MatKhau.Visible = true;
            this.col_MatKhau.VisibleIndex = 4;
            this.col_MatKhau.Width = 78;
            // 
            // btnReset
            // 
            this.btnReset.AutoHeight = false;
            editorButtonImageOptions3.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Password_Reset_32px;
            this.btnReset.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Đặt lại mật khẩu", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnReset.Name = "btnReset";
            this.btnReset.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // col_gioiTinh_edit
            // 
            this.col_gioiTinh_edit.AutoHeight = false;
            this.col_gioiTinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_gioiTinh_edit.Name = "col_gioiTinh_edit";
            // 
            // col_ngaySinh_edit
            // 
            this.col_ngaySinh_edit.AutoHeight = false;
            this.col_ngaySinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.Name = "col_ngaySinh_edit";
            // 
            // col_email_edit
            // 
            this.col_email_edit.AutoHeight = false;
            this.col_email_edit.Name = "col_email_edit";
            this.col_email_edit.UseSystemPasswordChar = true;
            // 
            // bindingNavigatorHocSinh
            // 
            this.bindingNavigatorHocSinh.AddNewItem = null;
            this.bindingNavigatorHocSinh.BindingSource = this.bindingSourceNguoiDung;
            this.bindingNavigatorHocSinh.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocSinh.DeleteItem = null;
            this.bindingNavigatorHocSinh.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorHocSinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorEditItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorSearchItem});
            this.bindingNavigatorHocSinh.Location = new System.Drawing.Point(2, 25);
            this.bindingNavigatorHocSinh.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocSinh.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocSinh.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocSinh.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocSinh.Name = "bindingNavigatorHocSinh";
            this.bindingNavigatorHocSinh.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocSinh.Size = new System.Drawing.Size(829, 31);
            this.bindingNavigatorHocSinh.TabIndex = 0;
            this.bindingNavigatorHocSinh.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = global::NMCNPM_QLHS.Properties.Resources.Add_32px;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(74, 28);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::NMCNPM_QLHS.Properties.Resources.Delete_32px;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(63, 28);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorEditItem
            // 
            this.bindingNavigatorEditItem.Image = global::NMCNPM_QLHS.Properties.Resources.Edit_32px;
            this.bindingNavigatorEditItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditItem.Name = "bindingNavigatorEditItem";
            this.bindingNavigatorEditItem.Size = new System.Drawing.Size(62, 28);
            this.bindingNavigatorEditItem.Text = "Sửa";
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.Image = global::NMCNPM_QLHS.Properties.Resources.Save_32px;
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(61, 28);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorSearchItem
            // 
            this.bindingNavigatorSearchItem.Image = global::NMCNPM_QLHS.Properties.Resources.Search_32px;
            this.bindingNavigatorSearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchItem.Name = "bindingNavigatorSearchItem";
            this.bindingNavigatorSearchItem.Size = new System.Drawing.Size(98, 28);
            this.bindingNavigatorSearchItem.Text = "Tìm kiếm";
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 443);
            this.Controls.Add(this.groupControlNguoiDung);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNguoiDung";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlNguoiDung)).EndInit();
            this.groupControlNguoiDung.ResumeLayout(false);
            this.groupControlNguoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_loaiNguoiDung_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).EndInit();
            this.bindingNavigatorHocSinh.ResumeLayout(false);
            this.bindingNavigatorHocSinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlNguoiDung;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn col_maNguoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maHS_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenNguoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_hoTen_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_LoaiNguoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox col_gioiTinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenDangNhap;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diaChi_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_MatKhau;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_email_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit col_ngaySinh_edit;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocSinh;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearchItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnReset;
        private System.Windows.Forms.BindingSource bindingSourceNguoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit col_loaiNguoiDung_edit;
    }
}