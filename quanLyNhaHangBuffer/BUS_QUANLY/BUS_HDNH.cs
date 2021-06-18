using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QUANLY;
using DTO_QUANLY;
namespace BUS_QUANLY
{
    public class BUS_HDNH
    {
        DAO_HDNH dao = new DAO_HDNH();
        public void luuHD(DTO_HDNH hd)
        {
            dao.luuHD(hd);
        }
        public void luuCTHD(DTO_HDNH hd)
        {
            dao.luuCTHD(hd);
        }
        public List<DTO_HDNH> timGiaVaMa(DTO_HDNH hd)
        {
            return dao.timGiaVaMa(hd);
        }
        public List<DTO_HDNH> auto(DTO_HDNH hd)
        {
            return dao.autoComplete(hd);
        }
    }
}
