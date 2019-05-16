using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinhDemo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuMon_Click(object sender, EventArgs e)
        {
            frmMonHoc f = new frmMonHoc();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);


        }
        private void MDIMain_MdiChildActivate(Object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (this.ActiveMdiChild != f)
                    f.Close();
            }

        }
        private void btn_Click(object sender, EventArgs e)
        {
            frmMonHoc f = new frmMonHoc();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void mnuLopHoc_Click(object sender, EventArgs e)
        {
            frmDanhSachLop f = new frmDanhSachLop();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void mnuDiem_Click(object sender, EventArgs e)
        {
            frmQLDiem f = new frmQLDiem();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void mnuHS_Click(object sender, EventArgs e)
        {

        }

        private void btnQLHS_Click(object sender, EventArgs e)
        {
            frmQLHS f = new frmQLHS();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void mnuKhoi_Click(object sender, EventArgs e)
        {
            frmKhoi f = new frmKhoi();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void mnuDiemTK_Click(object sender, EventArgs e)
        {
            frmQLDiem f = new frmQLDiem();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void btnQLD_Click(object sender, EventArgs e)
        {
            frmQLDiem f = new frmQLDiem();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void btnQLL_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void btnQLKhoi_Click(object sender, EventArgs e)
        {
            frmKhoi f = new frmKhoi();
            f.MdiParent = this;
            f.Show();
            MDIMain_MdiChildActivate(sender, e);
        }

        private void quyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThamSo f = new frmThamSo();
            f.Show();
        }
    }
}
