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
    public class CALAMVIEC_BUS
    {
        CALAMVIEC_DAO dao = new CALAMVIEC_DAO();
        public DataTable hienthi()
        {
            return dao.show();
        }
        public void addCa(CALAMVIEC_DTO dto)
        {
            dao.themCa(dto);
        }
        public void updateCa(CALAMVIEC_DTO dto)
        {
            dao.capnhatCa(dto);
        }
        public void deleteCa(CALAMVIEC_DTO dto)
        {
            dao.xoaCa(dto);
        }
    }
}
