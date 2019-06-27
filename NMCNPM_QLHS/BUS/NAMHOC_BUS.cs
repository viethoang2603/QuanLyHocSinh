using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class NAMHOC_BUS
    {
        // Thêm năm học
        public static void Insert()
        {
            NAMHOC_DAL.Insert();
        }

        // Xóa năm học
        public static void Delete(string maNamHoc)
        {
            NAMHOC_DAL.Delete(maNamHoc);
        }

        // Lấy tất cả các năm học
        public static List<NAMHOC> LayTatCaNamHoc()
        {
            return NAMHOC_DAL.LayTatCaNamHoc();
        }

        // Lấy năm học theo Mã HS
        public static List<NAMHOC> LayNamHocTheoMaHS(string maHS)
        {
            return NAMHOC_DAL.LayNamHocTheoMaHS(maHS);
        }

        // Lấy năm học tiếp theo
        public static List<NAMHOC> LayNamHocTiepTheo(string maNamHocCu)
        {
            List<NAMHOC> namHoc = new List<NAMHOC>();
            namHoc = NAMHOC_DAL.LayNamHocTiepTheo(maNamHocCu);
            if (namHoc != null)
                return namHoc;
            else
                return null;

        }

        // Lấy năm học hiện tại
        public static NAMHOC LayNamHocHienTai()
        {
            return NAMHOC_DAL.LayNamHocHienTai();
        }
    }
}
