using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.ChiTietDonHang
{
    class SQLDataCT
    {
        static ControllerCT db1 = new ControllerCT();
        public static void ChiTietDonHang_Insert(InfoCT sv)
        {
            db1.ChiTietDonHang_Insert(sv);
        }
        public static void ChiTietChiTietDonHang_Update(InfoCT sv)
        {
            db1.ChiTietDonHang_Update(sv);
        }
       
        public static void ChiTietDonHang_Delete(String MaDonHang,String MaSach)
        {
            db1.ChiTietDonHang_Delete(MaDonHang,MaSach);
        }
        public static DataTable ChiTietDonHang_GetByAll()
        {
            return db1.ChiTietDonHang_GetByAll();

        }
         public static DataTable ListByMaDH(string MaHD)
        {
            return db1.ListByMaDH(MaHD);
        }
        //public static DataTable SinhVien_GetByID(String MaSV)
        //{
        //    return db1.SinhVien_GetByID(MaSV);

        //}
    }
}
