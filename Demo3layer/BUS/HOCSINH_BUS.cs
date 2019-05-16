using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HOCSINH_BUS
    {
        public static void AddNewHocSinh(HOCSINH hs)
        {
            using (SQL_QUANLYHOCSINHDataContext db = new SQL_QUANLYHOCSINHDataContext())
            {
                db.HOCSINHs.InsertOnSubmit(hs);
                db.SubmitChanges();
            }
        }
    }
}
