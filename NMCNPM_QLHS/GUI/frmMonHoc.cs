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
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {   
        List<string> lst = new List<string>();
        public frmMonHoc()
        {
            InitializeComponent();
        }

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
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVien();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }



        #endregion -Phân quyền-

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            bindingSourceMonHoc.DataSource = MONHOC_BUS.LayTatCaMonHoc();
            lst = null;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string maMonHoc = MONHOC_BUS.maxID(dgvMonHoc);
            dgvMonHoc.AddNewRow();
            int rowHandle = dgvMonHoc.GetRowHandle(dgvMonHoc.DataRowCount);
            if (dgvMonHoc.IsNewItemRow(rowHandle))
            {
                dgvMonHoc.SetRowCellValue(rowHandle, col_maMonHoc, maMonHoc);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa lớp này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maMonHoc = dgvMonHoc.GetFocusedRowCellDisplayText(col_maMonHoc);
                dgvMonHoc.DeleteSelectedRows();
                lst.Add(maMonHoc);
            }
        }

        private void dgvMonHoc_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //col_tenMonHoc.OptionsColumn.AllowEdit = false;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maMonHoc, tenMonHoc;
            bindingNavigatorMonHoc.BindingSource.MoveFirst();
            // Thêm, sửa môn học
            for (int i = 0; i < dgvMonHoc.RowCount; i++)
            {
                maMonHoc = dgvMonHoc.GetFocusedRowCellDisplayText(col_maMonHoc);
                tenMonHoc = dgvMonHoc.GetFocusedRowCellDisplayText(col_tenMonHoc);
                if (MONHOC_BUS.LayTatCaMonHoc().Any(a => a.MAMONHOC == maMonHoc) == true)
                    MONHOC_BUS.update(maMonHoc, tenMonHoc);
                else
                    MONHOC_BUS.insert(maMonHoc, tenMonHoc);
                bindingNavigatorMonHoc.BindingSource.MoveNext();
            }
            // Xóa môn học
            if (lst != null)
            {
                for (int i = 0; i < lst.Count; i++)
                    MONHOC_BUS.delete(lst[i]);
            }
        }
    }
}