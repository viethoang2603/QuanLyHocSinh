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
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string maND = dgvNguoiDung.GetFocusedRowCellDisplayText(col_maNguoiDung);
            NGUOIDUNG_BUS.ResetMK(maND);
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            load_colNguoiDung();
            load_DSNguoiDung();
        }

        private void load_DSNguoiDung()
        {
            bindingSourceNguoiDung.DataSource = NGUOIDUNG_BUS.LayTatCaNguoiDung();
        }

        void load_colNguoiDung()
        {
            col_loaiNguoiDung_edit.DataSource = LOAINGUOIDUNG_BUS.LayTatCaLoaiNguoiDung();
        }

        private void dgvNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MessageBox.Show(dgvNguoiDung.GetRowCellDisplayText(0,col_LoaiNguoiDung).ToString());
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string maND = MONHOC_BUS.maxID(dgvMonHoc);
            dgvMonHoc.AddNewRow();
            int rowHandle = dgvMonHoc.GetRowHandle(dgvMonHoc.DataRowCount);
            if (dgvMonHoc.IsNewItemRow(rowHandle))
            {
                dgvMonHoc.SetRowCellValue(rowHandle, col_maMonHoc, maND);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

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