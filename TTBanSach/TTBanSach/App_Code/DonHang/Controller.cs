using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.DonHang
{
    class Controller : Data
    {
        public void DonHang_Insert(Info sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblDonHang_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@NgayGiao",sv.NgayGiao));
            cmd.Parameters.Add(new SqlParameter("@NgayDat",sv.NgayDat));      
            cmd.Parameters.Add(new SqlParameter("@TongTien", sv.TongTien));
            cmd.Parameters.Add(new SqlParameter("@TinhTrangGiaoHang", sv.TinhTrangGiaoHang));
            cmd.Parameters.Add(new SqlParameter("@MaKH", sv.MaKH));
            
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DonHang_Update(Info sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblDonHang_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDonHang", sv.MaDonHang));
            cmd.Parameters.Add(new SqlParameter("@NgayGiao", sv.NgayGiao));
            cmd.Parameters.Add(new SqlParameter("@NgayDat", sv.NgayDat));
            cmd.Parameters.Add(new SqlParameter("@TongTien", sv.TongTien));
            cmd.Parameters.Add(new SqlParameter("@TinhTrangGiaoHang", sv.TinhTrangGiaoHang));
            cmd.Parameters.Add(new SqlParameter("@MaKH", sv.MaKH));

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DonHang_Delete(String MaDonHang)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblDonHang_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDonHang", MaDonHang));

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable DonHang_GetByAll()
        {
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand("tblDonHang_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
       
        //public DataTable SinhVien_GetByID(String MaSV)
        //{
        //    SqlConnection con = GetConnection();

        //    SqlCommand cmd = new SqlCommand("DonHang_GetByID", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@MaSV", MaSV));
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        //}
    }
}

