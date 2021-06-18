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
    public class BUS_HH
    {
        DAO_HH dao = new DAO_HH();
        public DataTable hienThi()
        {
            return dao.showHH();
        }
        public void add(DTO_HH hh)
        {
            dao.themHH(hh);
        }
        public void delete(DTO_HH hh)
        {
            dao.xoaHH(hh);
        }
        public void update(DTO_HH hh)
        {
            dao.capnhatHH(hh);
        }
        public List<DTO_HH> auto(DTO_HH hh)
        {
            return dao.autoComplete(hh);
        }
    }
}
