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

namespace NMCNPM_QLHS.GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            PhanQuyen();
        }
        public void PhanQuyen() {

        }

        private void frmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frmManHinhChinh"].Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["frmManHinhChinh"].Enabled = true;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {

        }
    }
}