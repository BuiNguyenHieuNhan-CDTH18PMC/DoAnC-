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
    public class TONGHOP_BUS
    {
        TONGHOP_DAO dao = new TONGHOP_DAO();
        public DataTable hienThiBill(TONGHOP_DTO th)
        {
            return dao.showbill(th);
        }
    }
}
