using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {

        #region -Constructor-

        public frmLop()
        {
            InitializeComponent();
            Permissions();
        }

        #endregion -Constructor-

        #region -Phân quyền-

        public void Permissions()
        {
            switch (CurrentUser.Code)
            {
                case "LND002":      // Giao diện đăng nhập với quyền BGH
                    IsBGH();
                    break;
                case "LND003":      // Giao diện đăng nhập với quyền GiaoVu
                    IsGiaoVu();
                    break;
                case "LND004":      // Giao diện đăng nhập với quyền GiaoVien
                    IsGiaoVien();
                    break;
                default:
                    Default();
                    break;
            }
        }


        public void Default()
        {
            // True
            // Enable các button
            // False 
            // Disable các button
            navNhapLieu.PageVisible = true;
            navPanelChucNang.SelectedPage = navNhapLieu;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorEditItem.Enabled = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVien();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            navNhapLieu.PageVisible = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorEditItem.Enabled = false;
            navPanelChucNang.SelectedPage = navTimKiem;
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }


        #endregion -Phân quyền-


        #region -Methods-

        #region -Load-

        #region -Load_comBoBox

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }

        private void load_cboKhoiLop()
        {
            if (cboNamHoc.Text != "")
            {
                string maNamHoc = cboNamHoc.EditValue.ToString();
                cboKhoiLop.Properties.DataSource = KHOILOP_BUS.LayKhoiTheoNamHoc(maNamHoc);
                cboKhoiLop.Properties.DisplayMember = "TENKHOI";
                cboKhoiLop.Properties.ValueMember = "MAKHOI";
            }
        }

        #endregion -Load_comBoBox

        #region -Load_DSLop-

        private void load_DSLop()
        {
            string maNamHoc = cboNamHoc.EditValue.ToString();
            bindingSourceLop.DataSource = LOP_BUS.LayLopTheoNamHoc(maNamHoc);
        }

        #endregion -Load_DSLop-

        #endregion -Load-

        #endregion -Methods-

        #region -Events-

        #region -Form-

        private void frmLop_Load(object sender, EventArgs e)
        {
            load_cboNamHoc();
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            txtTenLop.ReadOnly = true;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_DSLop();
            load_cboKhoiLop();
        }

        #endregion -Form-

        #region -Button_click-

        private void btnThemNam_Click(object sender, EventArgs e)
        {
            var frm = new frmNamHoc();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }

        #endregion -Button_click-

        #region -BindingNavigatorItem_Click-

        private void bindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navNhapLieu;

            bindingNavigatorAddNewItem.Enabled = false;
            btnHoanTat.Visible = true;
            btnHuyBo.Visible = true;
            btnHoanTat.Text = "Lưu";
            txtMaLop.Text = LOP_BUS.autoMaLop();
            txtTenLop.Text = "";
            cboKhoiLop.EditValue = null;
            txtTenLop.ReadOnly = false;
            cboKhoiLop.ReadOnly = false;
            txtTenLop.Focus();
        }

        private void bindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa lớp này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maLop = txtMaLop.Text;
                LOP_BUS.Delete(maLop);
                load_DSLop();
            }
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            // Chuyển sang panel nhập liệu
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navNhapLieu;

            btnHoanTat.Text = "Hoàn tất";
            btnHoanTat.Visible = true;
            btnHuyBo.Visible = true;
            cboNamHoc.ReadOnly = true;
            txtTenLop.ReadOnly = false;
            txtTenLop.Focus();
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navTimKiem;
        }

        #endregion -BindingNavigatorItem_Click-

        #region -Nhập liệu-

        private void dgvDSLop_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            txtTenLop.ReadOnly = true;
            cboKhoiLop.ReadOnly = true;
            if (bindingSourceLop.DataSource != null)
            {
                DataRow dr = dgvDSLop.GetFocusedDataRow();

                txtMaLop.Text = dr.ItemArray[0].ToString();
                txtTenLop.Text = dr.ItemArray[1].ToString();
                cboKhoiLop.EditValue = dr.ItemArray[4].ToString();
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text;
            string tenLop = txtTenLop.Text;
            string maKhoi = cboKhoiLop.EditValue.ToString();
            try
            {
                if (btnHoanTat.Text == "Lưu")
                {
                    LOP_BUS.Insert(maLop, tenLop, maKhoi);
                    load_DSLop();
                    bindingNavigatorLop.BindingSource.MoveLast();
                }
                else
                {
                    LOP_BUS.Update(maLop, tenLop, maKhoi);
                    load_DSLop();
                }
                btnHoanTat.Visible = false;
                btnHuyBo.Visible = false;
                txtTenLop.ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bindingNavigatorAddNewItem.Enabled = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            btnHoanTat.Visible = false;
            btnHuyBo.Visible = false;
            txtTenLop.ReadOnly = true;
            bindingNavigatorAddNewItem.Enabled = true;
        }

        #endregion -Nhập liệu-

        #region -Tìm kiếm-

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {   
            if(rbtnMaLop.Checked == true)
                bindingSourceLop.DataSource = LOP_BUS.timLopTheoMaLop(txtTimKiem.Text);
            else
                bindingSourceLop.DataSource = LOP_BUS.timLopTheoTen(txtTimKiem.Text);
        }

        #endregion -Tìm kiếm-

        #endregion -Events-

    }
}