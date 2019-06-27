using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.BUS
{
    class QUATRINHHOC_BUS
    {
        // Tìm quá trình học của học sinh
        public static DataTable LayQuaTrinhHocCuaHocSinh(string maHS)
        {
            return QUATRINHHOC_DAL.LayQuaTrinhHocCuaHocSinh(maHS);
        }

        // Lưu phân lớp
        public static void LuuPhanLopHS(ListView hocSinh, string maLop, string maHocKy)
        {
            
                foreach (ListViewItem item in hocSinh.Items)
                {
                    QUATRINHHOC_DAL.LuuPhanLopHS(item.SubItems[0].Text.ToString(), maLop, maHocKy);
                }
            
        }

        // Kiểm tra sĩ số
        public static bool KiemTraSiSo(string maLop, int soHS)
        {
            int siSoHienTai = LOP_DAL.LaySiSoLop(maLop);
            double siSoToiDa = THAMSO_BUS.LayThamSo("SISOTOIDA");
            if (siSoHienTai + soHS > siSoToiDa)
                return false;
            return true;
        }
    }
}
