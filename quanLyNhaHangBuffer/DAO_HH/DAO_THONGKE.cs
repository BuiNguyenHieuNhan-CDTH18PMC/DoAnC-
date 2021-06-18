using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLY;
namespace DAO_QUANLY
{
    public class DAO_THONGKE:DBConnect
    {
        SqlCommand cmd;
        public DataSet thongke(DTO_THONGKE str)
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
