using DAO_QUANLY;
using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QUANLY
{
    public class HH_BUS
    {
        HH_DAO dao = new HH_DAO();
        public DataTable hienThi()
        {
            return dao.showHH();
        }
        public void add(HH_DTO hh)
        {
            dao.themHH(hh);
        }
        public void delete(HH_DTO hh)
        {
            dao.xoaHH(hh);
        }
        public void update(HH_DTO hh)
        {
            dao.capnhatHH(hh);
        }
        public List<HH_DTO> auto(HH_DTO hh)
        {
            return dao.autoComplete(hh);
        }
        public bool checkHangHoa(HH_DTO hh)
        {
            return dao.checkHH(hh);
        }
    }
}
