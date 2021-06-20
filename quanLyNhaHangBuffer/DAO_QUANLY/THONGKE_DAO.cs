using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QUANLY
{
    public class THONGKE_DAO:DBConnect
    {
        SqlCommand cmd;
        public DataSet thongke(THONGKE_DTO str)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(str.Chuoi, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }
    }
}
