using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTBanSach.App_Code.TacGia
{
    class Data
    {
        public static SqlConnection GetConnection()
        {
            string cn = System.Configuration.ConfigurationManager.ConnectionStrings["QLBS"].ConnectionString;
            return new SqlConnection(cn);
        }
    }
}
