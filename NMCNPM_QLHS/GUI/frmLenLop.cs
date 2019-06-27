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
using System.Collections;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmLenLop : DevExpress.XtraEditors.XtraForm
    {

        #region -Fields-

        bool state = false; // Đã thay đổi dữ liệu hay chưa

        #endregion -Fields-

        #region -Constructor-

        public frmLenLop()
        {
            InitializeComponent();
        }

        #endregion -Constructor-

        #region -Methods-

        #region -Load-

        #region -Load DSHS-

        private void load_DSHSCu()
        {
            if (cboNamHocCu.Text != "" && cboKhoiCu.Text != "" && cboLopCu.Text != "")
            {
                string maLop = cboLopCu.EditValue.ToString();
                string maNamHoc = cboNamHocCu.EditValue.ToString();
                if (rbtnLenLop.Checked == true)
                {
                    lstvDSHSCu.Items.Clear();
                    var lst = HOCSINH_BUS.LayDSHocSinhDuocLenLop(maLop, maNamHoc);
                    foreach (var i in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = i.MAHS;
                        item.SubItems.Add(i.HOTEN);
                        lstvDSHSCu.Items.Add(item);
                    }
                }
                else
                {
                    lstvDSHSCu.Items.Clear();
                    var lst = HOCSINH_BUS.LayDSHocSinhKhongDuocLenLop(maLop, maNamHoc);
                    foreach (var i in lst)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = i.MAHS;
                        item.SubItems.Add(i.HOTEN);
                        lstvDSHSCu.Items.Add(item);
                    }
                }
            }
            else
                lstvDSHSCu.Items.Clear();
        }

        private void load_DSHSMoi()
        {
            if (cboNamHocMoi.Text != "" && cboKhoiMoi.Text != "" && cboLopMoi.Text != "")
            {
                lstvDSHSMoi.Items.Clear();
                var lst = HOCSINH_BUS.LayHocSinhTheoLop(cboLopMoi.EditValue.ToString(), "HK01");
                foreach (var i in lst)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = i.MAHS;
                    item.SubItems.Add(i.HOTEN);
                    lstvDSHSMoi.Items.Add(item);
                }
                btnChuyen.Enabled = true;
            }
            else
                lstvDSHSMoi.Items.Clear();
        }

        #endregion -Load DSHS-

        #region -Load ComBoBox-

        #region -Lên lớp-

        #region -Năm học cũ-

        private void load_cboNamHocCu()
        {
            cboNamHocCu.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHocCu.Properties.DisplayMember = "TENNAMHOC";
            cboNamHocCu.Properties.ValueMember = "MANAMHOC";
        }

        private void load_cboKhoiLopCu()
        {
            if (cboNamHocCu.Text != "")
            {
                string maNamHoc = cboNamHocCu.EditValue.ToString();
                cboKhoiCu.Properties.DataSource = KHOILOP_BUS.LayKhoi1011(maNamHoc);
                cboKhoiCu.Properties.DisplayMember = "TENKHOI";
                cboKhoiCu.Properties.ValueMember = "MAKHOI";
                //cboKhoiCu.EditValue = null;
            }
            else
                cboKhoiCu.Properties.DataSource = null;
            cboKhoiCu.EditValue = null;
        }

        private void load_cboLopCu()
        {
            if (cboKhoiCu.Text != "")
            {
                string maKhoi = cboKhoiCu.EditValue.ToString();
                cboLopCu.Properties.DataSource = LOP_BUS.LayLopTheoKhoi(maKhoi);
                cboLopCu.Properties.DisplayMember = "TENLOP";
                cboLopCu.Properties.ValueMember = "MALOP";
                //cboLopCu.EditValue = null;
            }
            else
                cboLopCu.Properties.DataSource = null;
            cboLopCu.EditValue = null;
        }

        #endregion - Năm học cũ-

        #region -Năm học mới-

        private void load_cboNamHocMoi()
        {
            if (cboNamHocCu.Text != "")
            {
                string maNamHocCu = cboNamHocCu.EditValue.ToString();
                cboNamHocMoi.Properties.DataSource = NAMHOC_BUS.LayNamHocTiepTheo(maNamHocCu);
                cboNamHocMoi.Properties.DisplayMember = "TENNAMHOC";
                cboNamHocMoi.Properties.ValueMember = "MANAMHOC";
                //cboNamHocMoi.EditValue = null;
            }
            else
                cboNamHocMoi.Properties.DataSource = null;
            cboNamHocMoi.EditValue = null;
        }

        private void load_cboKhoiLopMoi()
        {
            if (cboNamHocMoi.Text != "" && cboKhoiCu.Text != "")
            {
                string maNamHoc = cboNamHocMoi.EditValue.ToString();
                cboKhoiMoi.Properties.DataSource = KHOILOP_BUS.LayKhoiLopTiepTheo(cboKhoiCu.Text, maNamHoc);
                cboKhoiMoi.Properties.DisplayMember = "TENKHOI";
                cboKhoiMoi.Properties.ValueMember = "MAKHOI";
                //cboKhoiMoi.EditValue = null;
            }
            else
                cboKhoiMoi.Properties.DataSource = null;

            cboKhoiMoi.EditValue = null;
        }

        private void load_cboLopMoi()
        {
            if (cboKhoiMoi.Text != "")
            {
                string maKhoi = cboKhoiMoi.EditValue.ToString();
                cboLopMoi.Properties.DataSource = LOP_BUS.LayLopTheoKhoi(maKhoi);
                cboLopMoi.Properties.DisplayMember = "TENLOP";
                cboLopMoi.Properties.ValueMember = "MALOP";
                //cboLopMoi.EditValue = null;
            }
            else
                cboLopMoi.Properties.DataSource = null;
            cboLopMoi.EditValue = null;
        }

        #endregion - Năm học mới-

        #endregion -Lên lớp-

        #region -Học lại-

        #region -Năm học cũ-

        //load_cboNamHocCu

        private void load_cboKhoiLopCu1()
        {
            if (cboNamHocCu.Text != "")
            {
                string maNamHoc = cboNamHocCu.EditValue.ToString();
                cboKhoiCu.Properties.DataSource = KHOILOP_BUS.LayKhoiTheoNamHoc(maNamHoc);
                cboKhoiCu.Properties.DisplayMember = "TENKHOI";
                cboKhoiCu.Properties.ValueMember = "MAKHOI";
                //cboKhoiCu.EditValue = null;
            }
            else
                cboKhoiCu.Properties.DataSource = null;
            cboKhoiCu.EditValue = null;
        }

        //load_cboLopCu

        #endregion -Năm học cũ-

        #region -Năm học mới-

        //load_cboNamHocMoi

        private void load_cboKhoiLopMoi1()
        {
            if (cboNamHocMoi.Text != "" && cboKhoiCu.Text != "")
            {
                string maNamHoc = cboNamHocMoi.EditValue.ToString();
                cboKhoiMoi.Properties.DataSource = KHOILOP_BUS.LayCungKhoiLopNamSau(cboKhoiCu.Text, maNamHoc);
                cboKhoiMoi.Properties.DisplayMember = "TENKHOI";
                cboKhoiMoi.Properties.ValueMember = "MAKHOI";
                //cboKhoiMoi.EditValue = null;
            }
            else
                cboKhoiMoi.Properties.DataSource = null;
            cboKhoiMoi.EditValue = null;
        }

        //load_cboLopMoi()

        #endregion -Năm học mới-

        #region - Học lại-

        #endregion -Load ComBoBox-

        #endregion -Methods-

        #endregion -Load ComBoBox-

        #endregion -Load-

        #endregion -Methods-

        #region -Events-

        #region -Form-

        private void frmLenLop_Load(object sender, EventArgs e)
        {
            load_cboNamHocCu();
            btnChuyen.Enabled = false;
        }

        private void frmLenLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    btnLuu.PerformClick();
            }
        }
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

        private void btnThemKhoi_Click(object sender, EventArgs e)
        {
            var frm = new frmKhoilop();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            var frm = new frmLop();
            if (Application.OpenForms[frm.Name] == null)
            {
                frm.Show();
            }
            else
            {
                Application.OpenForms[frm.Name].Focus();
            }
        }
        #endregion -Form-

        #region -ComBoBox_editValueChanged-

        #region -Năm học cũ-

        private void cboNamHocCu_EditValueChanged(object sender, EventArgs e)
        {
            load_cboNamHocMoi();
            if (rbtnLenLop.Checked == true)
                load_cboKhoiLopCu();
            else
                load_cboKhoiLopCu1();
            //load_cboLopCu();
            load_DSHSCu();
        }

        private void cboKhoiCu_EditValueChanged(object sender, EventArgs e)
        {
            if (rbtnLenLop.Checked == true)
                load_cboKhoiLopMoi();
            else
                load_cboKhoiLopMoi1();
            load_cboLopCu();
            load_DSHSCu();
        }

        private void cboLopCu_EditValueChanged(object sender, EventArgs e)
        {
            load_DSHSCu();
        }

        #endregion -Năm học cũ-

        #region -Năm học mới-

        private void cboNamHocMoi_EditValueChanged(object sender, EventArgs e)
        {
            if (rbtnLenLop.Checked == true)
                load_cboKhoiLopMoi();
            else
                load_cboKhoiLopMoi1();
            load_cboLopMoi();
            load_DSHSMoi();
        }

        private void cboKhoiMoi_EditValueChanged(object sender, EventArgs e)
        {
            load_cboLopMoi();
            load_DSHSMoi();
        }

        private void cboLopMoi_EditValueChanged(object sender, EventArgs e)
        {
            load_DSHSMoi();
        }

        #endregion -Năm học mới-

        #endregion -ComBoBox_editValueChanged-

        #region -radioButton_CheckedChanged-

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (state == true)
            {
                if (MessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    btnLuu.PerformClick();
                else
                {
                    state = false;
                }
            }
            cboNamHocCu.EditValue = null;
            load_cboNamHocCu();
        }

        #endregion -radioButton_CheckedChanged-

        #region -Button_Click-

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (QUATRINHHOC_BUS.KiemTraSiSo(cboLopMoi.EditValue.ToString(), lstvDSHSMoi.SelectedItems.Count) == true)
            {
                IEnumerator ie = lstvDSHSCu.SelectedItems.GetEnumerator();
                if (lstvDSHSCu.SelectedItems.Count != 0)
                    state = true;
                while (ie.MoveNext())
                {
                    ListViewItem olditem = (ListViewItem)ie.Current;
                    ListViewItem newitem = new ListViewItem();

                    //Trạng thái học sinh đã được phân lớp hay chưa?
                    bool stateHS = false;

                    foreach (ListViewItem item in lstvDSHSMoi.Items)
                    {
                        if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                        {
                            MessageBox.Show("Học sinh " + olditem.SubItems[1].Text + " hiện đã được phân vào lớp " + cboLopMoi.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            stateHS = true;
                            goto Cont;
                        }
                    }

                    newitem = olditem;
                    lstvDSHSCu.Items.Remove(olditem);
                    lstvDSHSMoi.Items.Add(newitem);

                Cont:
                    if (stateHS == true)
                        break;
                }
            }
            else
                MessageBox.Show("Vượt quá sĩ số tối đa", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (state == true)
            {
                string maLop = cboLopMoi.EditValue.ToString();
                QUATRINHHOC_BUS.LuuPhanLopHS(lstvDSHSMoi, maLop, "HK01");
                MessageBox.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                state = false;
            }
        }


        #endregion -Button_Click-

        #endregion -Events-

        private void btnHuy_Click(object sender, EventArgs e)
        {
            load_DSHSCu();
            load_DSHSMoi();
            state = false;
        }
    }
}