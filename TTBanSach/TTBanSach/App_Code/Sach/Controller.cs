using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.Sach
{
    class Controller : Data
    {
        public void Sach_Insert(Info sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblSach_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TenSach", sv.TenSach));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", sv.GiaBan));
            cmd.Parameters.Add(new SqlParameter("@MoTa", sv.MoTa));
            cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", sv.NgayCapNhat));
            
            cmd.Parameters.Add(new SqlParameter("@SoLuongTon", sv.SoLuongTon));
            cmd.Parameters.Add(new SqlParameter("@TenChuDe", sv.TenChuDe));
            cmd.Parameters.Add(new SqlParameter("@TenNXB", sv.TenNXB));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Sach_Update(Info sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblSach_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
           
            cmd.Parameters.Add(new SqlParameter("@MaSach", sv.MaSach));
            cmd.Parameters.Add(new SqlParameter("@TenSach", sv.TenSach));
            cmd.Parameters.Add(new SqlParameter("@GiaBan", sv.GiaBan));
            cmd.Parameters.Add(new SqlParameter("@MoTa", sv.MoTa));
            cmd.Parameters.Add(new SqlParameter("@NgayCapNhat", sv.NgayCapNhat));
           
            cmd.Parameters.Add(new SqlParameter("@SoLuongTon", sv.SoLuongTon));
            cmd.Parameters.Add(new SqlParameter("@TenChuDe", sv.TenChuDe));
            cmd.Parameters.Add(new SqlParameter("@TenNXB", sv.TenNXB));
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Sach_Delete(String MaSach)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblSach_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaSach", MaSach));

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable Sach_GetByAll()
        {
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand("tblSach_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable Sach_Search(String Key)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblSach_Search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Key", Key));
            cmd.ExecuteNonQuery();
            con.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
       public DataTable TopSach()
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("TopSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       public DataTable NewSach()
       {
           SqlConnection con = GetConnection();
           con.Open();
           SqlCommand cmd = new SqlCommand("NewSach", con);
           cmd.CommandType = CommandType.StoredProcedure;
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataTable dt = new DataTable();
           da.Fill(dt);
           return dt;
       }
        //public DataTable SinhVien_GetByID(String MaSV)
        //{
        //    SqlConnection con = GetConnection();

        //    SqlCommand cmd = new SqlCommand("Sach_GetByID", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@MaSV", MaSV));
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        //}
    }
}

