using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QUANLY
{
    public class DBConnect
    {     
        protected SqlConnection conn = new SqlConnection("Data Source=laptop-aokmt82l;Initial Catalog=qlBanNuocMangVe;Integrated Security=True");
    }
}
