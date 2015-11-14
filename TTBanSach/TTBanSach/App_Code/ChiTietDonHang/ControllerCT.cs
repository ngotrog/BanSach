using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.ChiTietDonHang
{
    class ControllerCT : DataCT
    {
        public void ChiTietDonHang_Insert(InfoCT sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblChiTietDonHang_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDonHang",sv.MaDonHang));
            cmd.Parameters.Add(new SqlParameter("@MaSach",sv.MaSach));      
            cmd.Parameters.Add(new SqlParameter("@SoLuong", sv.SoLuong));
          
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ChiTietDonHang_Update(InfoCT sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblChiTietDonHang_Update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDonHang", sv.MaDonHang));
            cmd.Parameters.Add(new SqlParameter("@MaSach", sv.MaSach));
            cmd.Parameters.Add(new SqlParameter("@SoLuong", sv.SoLuong));
          

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ChiTietDonHang_Delete(String MaDonHang,String MaSach)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblChiTietDonHang_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDonHang", MaDonHang));
            cmd.Parameters.Add(new SqlParameter("@MaSach", MaSach));

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ChiTietDonHang_GetByAll()
        {
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand("tblChiTietDonHang_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable ListByMaDH(string MaHD)
        {
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand("ListByMaDH", con);
              cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaDonHang", MaHD));
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
                //cmd.ExecuteReader();
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;

        }
        //public DataTable SinhVien_GetByID(String MaSV)
        //{
        //    SqlConnection con = GetConnection();

        //    SqlCommand cmd = new SqlCommand("ChiTietDonHang_GetByID", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@MaSV", MaSV));
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        //}
    }
}

