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
    public class BUS_THONGKE
    {
        DAO_THONGKE dao = new DAO_THONGKE();
        public DataSet thongKe(DTO_THONGKE str)
        {
            return dao.thongke(str);
        }
    }
}
