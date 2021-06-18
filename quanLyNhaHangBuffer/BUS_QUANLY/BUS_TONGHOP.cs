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
    public class BUS_TONGHOP
    {
        DAO_TONGHOP dao = new DAO_TONGHOP();
        public DataTable hienThiBill(DTO_TONGHOP th)
        {
            return dao.showbill(th);
        }
    }
}
