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
    public partial class frmKhoilop : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoilop()
        {
            InitializeComponent();
            Permissions();
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

        }

        public void IsBGH()
        {
            // Enable, Disable các button
            IsGiaoVien();
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }



        #endregion -Phân quyền-

        private void frmKhoilop_Load(object sender, EventArgs e)
        {
            bindingSourceKhoiLop.DataSource = KHOILOP_BUS.LayTatCaKhoi();
            load_colNamHoc();
        }

        private void load_colNamHoc()
        {
            col_namHoc_edit.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
        }
    }
}