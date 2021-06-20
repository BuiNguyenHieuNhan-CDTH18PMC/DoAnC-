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
    public class HDNH_BUS
    {
        HDNH_DAO dao = new HDNH_DAO();
        public void luuHD(HDNH_DTO hd)
        {
            dao.luuHD(hd);
        }
        public void luuCTHD(HDNH_DTO hd)
        {
            dao.luuCTHD(hd);
        }
        public List<HDNH_DTO> timGiaVaMa(HDNH_DTO hd)
        {
            return dao.timGiaVaMa(hd);
        }
        public List<HDNH_DTO> auto(HDNH_DTO hd)
        {
            return dao.autoComplete(hd);
        }
    }
}
