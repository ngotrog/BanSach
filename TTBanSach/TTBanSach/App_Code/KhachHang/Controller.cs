using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.KhachHang
{
    class Controller : Data
    {
        public void KhachHang_Insert(Info sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblKhachHang_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@HoTen", sv.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", sv.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", sv.GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@DienThoai", sv.DienThoai));
            cmd.Parameters.Add(new SqlParameter("@Email", sv.Email));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", sv.DiaChi));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void KhachHang_Update(Info sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblKhachHang_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
        
            cmd.Parameters.Add(new SqlParameter("@MaKH", sv.MaKH));
            cmd.Parameters.Add(new SqlParameter("@HoTen", sv.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NgaySinh", sv.NgaySinh));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", sv.GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@DienThoai", sv.DienThoai));
            cmd.Parameters.Add(new SqlParameter("@Email", sv.Email));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", sv.DiaChi));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void KhachHang_Delete(String MaKH)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblKhachHang_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaKH", MaKH));

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable KhachHang_GetByAll()
        {
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand("tblKhachHang_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public  DataTable KhachHang_Search(String Key)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblKhachHang_Search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Key", Key));
            cmd.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
           
        }
        //public DataTable SinhVien_GetByID(String MaSV)
        //{
        //    SqlConnection con = GetConnection();

        //    SqlCommand cmd = new SqlCommand("KhachHang_GetByID", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@MaSV", MaSV));
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        //}
    }
}

