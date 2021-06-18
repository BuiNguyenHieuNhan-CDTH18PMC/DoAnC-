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
    public class BUS_HangHoa
    {
        DAO_HangHoa dao = new DAO_HangHoa();
        public DataTable hienThi()
        {
            return dao.showHH();
        }
        public void add(DTO_HangHoa hh)
        {
            dao.themHH(hh);
        }
        public void delete(DTO_HangHoa hh)
        {
            dao.xoaHH(hh);
        }
        public void update(DTO_HangHoa hh)
        {
            dao.capnhatHH(hh);
        }
    }
}
