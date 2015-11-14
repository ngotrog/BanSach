using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.TacGia
{
    class SQLData
    {
        static Controller db1 = new Controller();
        public static void TacGia_Insert(Info sv)
        {
            db1.TacGia_Insert(sv);
        }
       
        public static void TacGia_Delete(String MaTG)
        {
            db1.TacGia_Delete(MaTG);
        }
        public static DataTable TacGia_GetByAll()
        {
            return db1.TacGia_GetByAll();

        }
        //public static DataTable SinhVien_GetByID(String MaSV)
        //{
        //    return db1.SinhVien_GetByID(MaSV);

        //}
    }
}
