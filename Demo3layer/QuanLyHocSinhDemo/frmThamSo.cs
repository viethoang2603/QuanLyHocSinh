using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyHocSinhDemo
{
    public partial class frmThamSo : Form
    {
        public frmThamSo()
        {
            InitializeComponent();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            SQL_QUANLYHOCSINHDataContext db = new SQL_QUANLYHOCSINHDataContext();
        }
    }
}
