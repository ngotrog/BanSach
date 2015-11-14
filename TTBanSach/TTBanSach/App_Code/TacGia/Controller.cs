using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.TacGia
{
    class Controller : Data
    {
        public void TacGia_Insert(Info sv)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblTacGia_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@TenTacGia",sv.TenTacGia ));
            cmd.Parameters.Add(new SqlParameter("@DiaChi",sv.DiaChi ));      
            cmd.Parameters.Add(new SqlParameter("@DienThoai", sv.DienThoai));
            
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void TacGia_Delete(String MaTacGia)
        {
            SqlConnection con = GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("tblTacGia_Delete", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaTacGia", MaTacGia));

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable TacGia_GetByAll()
        {
            SqlConnection con = GetConnection();

            SqlCommand cmd = new SqlCommand("tblTacGia_Select", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //public DataTable SinhVien_GetByID(String MaSV)
        //{
        //    SqlConnection con = GetConnection();

        //    SqlCommand cmd = new SqlCommand("TacGia_GetByID", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add(new SqlParameter("@MaSV", MaSV));
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;

        //}
    }
}

