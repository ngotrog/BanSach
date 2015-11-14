using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.Sach
{
    class SQLData
    {
        static Controller db1 = new Controller();
        public static void Sach_Insert(Info sv)
        {
            db1.Sach_Insert(sv);
        }
        public static void Sach_Update(Info sv)
        {
            db1.Sach_Update(sv);
        }
        public static void Sach_Delete(String MaSach)
        {
            db1.Sach_Delete(MaSach);
        }
        public static DataTable Sach_Search(String Key)
        {
            return db1.Sach_Search(Key);
        }
        public static DataTable Sach_GetByAll()
        {
            return db1.Sach_GetByAll();

        }
        public static DataTable TopSach()
        {
            return db1.TopSach();

        }
        public static DataTable NewSach()
        {
            return db1.NewSach();

        }
       
    }
}
