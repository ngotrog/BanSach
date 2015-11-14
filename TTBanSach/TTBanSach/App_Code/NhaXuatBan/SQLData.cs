using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.NhaXuatBan
{
    class SQLData
    {
        static Controller db1 = new Controller();
        public static void NhaXuatBan_Insert(Info sv)
        {
            db1.NhaXuatBan_Insert(sv);
        }
       
        public static void NhaXuatBan_Delete(String MaCD)
        {
            db1.NhaXuatBan_Delete(MaCD);
        }
        public static DataTable NhaXuatBan_GetByAll()
        {
            return db1.NhaXuatBan_GetByAll();

        }
        //public static DataTable SinhVien_GetByID(String MaSV)
        //{
        //    return db1.SinhVien_GetByID(MaSV);

        //}
    }
}
