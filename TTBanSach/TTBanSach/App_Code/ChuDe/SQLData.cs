using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.ChuDe
{
    class SQLData
    {
        static Controller db1 = new Controller();
        public static void ChuDe_Insert(Info sv)
        {
            db1.ChuDe_Insert(sv);
        }
       
        public static void ChuDe_Delete(String MaCD)
        {
            db1.ChuDe_Delete(MaCD);
        }
        public static DataTable ChuDe_GetByAll()
        {
            return db1.ChuDe_GetByAll();

        }
        //public static DataTable SinhVien_GetByID(String MaSV)
        //{
        //    return db1.SinhVien_GetByID(MaSV);

        //}
    }
}
