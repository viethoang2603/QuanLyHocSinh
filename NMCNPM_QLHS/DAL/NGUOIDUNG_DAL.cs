using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class NGUOIDUNG_DAL
    {
        public static bool KiemTraTonTai(string tendangnhap)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.TENDANGNHAP == tendangnhap))
                    return true;
                return false;
            }
        }
        public static bool DangNhap(string tendangnhap, string matkhau)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {

                if (db.NGUOIDUNGs.Any(u => u.TENDANGNHAP == tendangnhap && u.MATKHAU == matkhau))
                {
                    NGUOIDUNG user = db.NGUOIDUNGs.FirstOrDefault(u => u.TENDANGNHAP == tendangnhap && u.MATKHAU == matkhau);
                    CurrentUser.Code = user.MAND;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string LayTenNguoiDung(string code) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).TENNGUOIDUNG;
                }
                return "unknown";
            }
        }
        public static List<NGUOIDUNG> LayTatCaNguoiDung()
        {
            List<NGUOIDUNG> lst = new List<NGUOIDUNG>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.NGUOIDUNGs.ToList();
                foreach (var x in ds)
                {
                    NGUOIDUNG ngd = new NGUOIDUNG();
                    {
                        ngd.MAND = x.MAND;
                        ngd.TENDANGNHAP = x.TENDANGNHAP;
                        ngd.TENNGUOIDUNG = x.TENNGUOIDUNG;
                        ngd.MATKHAU = x.MATKHAU;
                        ngd.LOAINGUOIDUNG = x.LOAINGUOIDUNG;
                        lst.Add(ngd);
                    }
                }
            }
            return lst;
        }
        public static string LayTenDangNhap(string code) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).TENDANGNHAP;
                }
                return "unknown";
            }
        }
        public static string LayQuyen(string code)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).LOAINGUOIDUNG.TENLOAIND;
                }
                return "unknown";
            }
        }
        public static string LayMatKhau(string code)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).MATKHAU;
                }
                return "unknown";
            }
        }

        public static void ResetMK(string maND)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(a => a.MAND == maND).FirstOrDefault();
                nd.MATKHAU = "123456789";
                db.SubmitChanges();
            }
        }

        // Thêm người dùng
        public static void insert(string maND, string tenNguoiDung, string maLND, string tenDangNhap)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = new NGUOIDUNG();
                nd.MAND = maND;
                nd.TENNGUOIDUNG = tenNguoiDung;
                nd.MALND = maLND;
                nd.TENDANGNHAP = tenDangNhap;
                nd.MATKHAU = "123456789";

                db.NGUOIDUNGs.InsertOnSubmit(nd);
                db.SubmitChanges();
            }
        }

        // Sửa người dùng
        public static void update(string maND, string tenNguoiDung, string maLND)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(a => a.MAND == maND).FirstOrDefault();
                nd.TENNGUOIDUNG = tenNguoiDung;
                nd.MALND = maLND;
                db.SubmitChanges();
            }
        }

        // Xóa người dùng
        public static void delete(string maND)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Where(a => a.MAND == maND).FirstOrDefault();
                db.NGUOIDUNGs.DeleteOnSubmit(nd);
                db.SubmitChanges();
            }
        }
    }
}
