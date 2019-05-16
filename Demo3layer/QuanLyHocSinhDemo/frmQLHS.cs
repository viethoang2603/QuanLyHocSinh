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
    public partial class frmQLHS : Form
    {
        public frmQLHS()
        {
            InitializeComponent();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            try
            {
                HOCSINH hs = new HOCSINH();
                hs.MAHS = txtMaHS.Text;
                hs.HOTEN = txtHoTen.Text;
                hs.GIOITINH = cboGioiTinh.Text;
                hs.NGAYSINH = DateTime.Parse(mskNgaySinh.Text);
                hs.EMAIL = txtEmail.Text;
                hs.DIACHI = txtDiaChi.Text;
                HOCSINH_BUS.AddNewHocSinh(hs);
                frmQLHS_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!","Error");
            }
        }

        private void frmQLHS_Load(object sender, EventArgs e)
        {
            SQL_QUANLYHOCSINHDataContext db = new SQL_QUANLYHOCSINHDataContext();
            var Lst = (from s in db.HOCSINHs select s).ToList();
            dgrThongTinHocSinh.DataSource = Lst;
        }


        private void dgrThongTinHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgrThongTinHocSinh.CurrentCell.RowIndex;
            DataGridViewRow row = dgrThongTinHocSinh.Rows[rowIndex];
            txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
            txtMaHS.Text = row.Cells["MAHS"].Value.ToString();
            txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
            txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            cboGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();
            mskNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();
        }

        private void dgrThongTinHocSinh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgrThongTinHocSinh.CurrentCell.RowIndex;
            DataGridViewRow row = dgrThongTinHocSinh.Rows[rowIndex];
            txtHoTen.Text = row.Cells["HOTEN"].Value.ToString();
            txtMaHS.Text = row.Cells["MAHS"].Value.ToString();
            txtEmail.Text = row.Cells["EMAIL"].Value.ToString();
            txtDiaChi.Text = row.Cells["DIACHI"].Value.ToString();
            cboGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString();
            mskNgaySinh.Text = row.Cells["NGAYSINH"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SQL_QUANLYHOCSINHDataContext db = new SQL_QUANLYHOCSINHDataContext();
            HOCSINH hs = new HOCSINH();
            hs.MAHS = txtMaHS.Text;
            hs.HOTEN = txtHoTen.Text;
            hs.GIOITINH = cboGioiTinh.Text;
            hs.NGAYSINH = DateTime.Parse(mskNgaySinh.Text);
            hs.EMAIL = txtEmail.Text;
            hs.DIACHI = txtDiaChi.Text;
            db.HOCSINHs.Attach(hs);
            db.HOCSINHs.DeleteOnSubmit(hs);
            db.SubmitChanges();
            frmQLHS_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }
    }
}
