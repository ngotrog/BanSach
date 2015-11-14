using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.KhachHang
{
    class SQLData
    {
        static Controller db1 = new Controller();
        public static void KhachHang_Insert(Info sv)
        {
            db1.KhachHang_Insert(sv);
        }
        public static void KhachHang_Update(Info sv)
        {
            db1.KhachHang_Update(sv);
        }
        public static void KhachHang_Delete(String MaKH)
        {
            db1.KhachHang_Delete(MaKH);
        }
        public static DataTable KhachHang_Search(String Key)
        {
            return db1.KhachHang_Search(Key);
        }
        public static DataTable KhachHang_GetByAll()
        {
            return db1.KhachHang_GetByAll();

        }
        //public static DataTable SinhVien_GetByID(String MaSV)
        //{
        //    return db1.SinhVien_GetByID(MaSV);

        //}
    }
}
