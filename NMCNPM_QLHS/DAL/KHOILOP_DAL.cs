﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class KHOILOP_DAL
    {
        // Lấy tất cả các khối
        public static List<KHOILOP> LayTatCaKhoi()
        {
            List<KHOILOP> lst = new List<KHOILOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.KHOILOPs.ToList();
                foreach (var x in ds)
                {
                    KHOILOP kl = new KHOILOP();
                    {
                        kl.MAKHOI = x.MAKHOI;
                        kl.TENKHOI = x.TENKHOI;
                        kl.SOLOP = x.SOLOP;
                        kl.MANAM = x.MANAM;
                        lst.Add(kl);
                    }
                }
            }
            return lst;
        }

        // Lấy khối theo năm học
        public static List<KHOILOP> LayKhoiTheoNamHoc(string maNamHoc)
        {
            List<KHOILOP> lst = new List<KHOILOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.KHOILOPs.Where(a => a.MANAM == maNamHoc).ToList();
                foreach (var x in ds)
                {
                    KHOILOP khoiLop = new KHOILOP();
                    khoiLop.MAKHOI = x.MAKHOI;
                    khoiLop.TENKHOI = x.TENKHOI;
                    khoiLop.MANAM = x.MANAM;
                    khoiLop.SOLOP = x.SOLOP;
                    lst.Add(khoiLop);
                }
            }
            return lst;
        }

        // Lấy khối 10 & 11 theo năm học
        public static List<KHOILOP> LayKhoi1011(string maNamHoc)
        {
            List<KHOILOP> lst = new List<KHOILOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.KHOILOPs.Where(a => (a.MANAM == maNamHoc) && (a.TENKHOI == "10" || a.TENKHOI == "11")).ToList();
                foreach (var x in ds)
                {
                    KHOILOP khoiLop = new KHOILOP();
                    {
                        khoiLop.MAKHOI = x.MAKHOI;
                        khoiLop.TENKHOI = x.TENKHOI;
                        lst.Add(khoiLop);
                    }
                }
            }
            return lst;
        }

        // Lấy khối lớp theo mã khối mã năm
        public static List<KHOILOP> LayKhoiTheoMaKhoiMaNam(string tenKhoiLop, string maNamHoc)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                return db.KHOILOPs.Where(a => a.MANAM == maNamHoc && a.TENKHOI == tenKhoiLop).ToList();
            }
        }
    }
}
