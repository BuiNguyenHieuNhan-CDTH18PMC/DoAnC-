using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QUANLY;
using DTO_QUANLY;
namespace BUS_QUANLY
{
    public class THONGKE_BUS
    {
        THONGKE_DAO dao = new THONGKE_DAO();
        public DataSet thongKe(THONGKE_DTO str)
        {
            return dao.thongke(str);
        }
    }
}
