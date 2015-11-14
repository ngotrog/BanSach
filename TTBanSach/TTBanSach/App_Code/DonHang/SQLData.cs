using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.DonHang
{
    class SQLData
    {
        static Controller db1 = new Controller();
        public static void DonHang_Insert(Info sv)
        {
            db1.DonHang_Insert(sv);
        }
        public static void DonHang_Update(Info sv)
        {
            db1.DonHang_Update(sv);
        }
       
        public static void DonHang_Delete(String MaDH)
        {
            db1.DonHang_Delete(MaDH);
        }
        public static DataTable DonHang_GetByAll()
        {
            return db1.DonHang_GetByAll();

        }
       
        //public static DataTable SinhVien_GetByID(String MaSV)
        //{
        //    return db1.SinhVien_GetByID(MaSV);

        //}
    }
}
