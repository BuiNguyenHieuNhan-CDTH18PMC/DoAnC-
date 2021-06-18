using DAO_QUANLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLY;
namespace BUS_QUANLY
{
    public class BUS_CALAMVIEC
    {
        DAO_CALAMVIEC dao = new DAO_CALAMVIEC();
        public DataTable hienthi()
        {
            return dao.show();
        }
        public void addCa(DTO_CALAMVIEC dto)
        {
            dao.themCa(dto);
        }
        public void updateCa(DTO_CALAMVIEC dto)
        {
            dao.capnhatCa(dto);
        }
        public void deleteCa(DTO_CALAMVIEC dto)
        {
            dao.xoaCa(dto);
        }
    }
}
