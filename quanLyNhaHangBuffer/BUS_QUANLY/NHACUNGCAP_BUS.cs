using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_QUANLY;
using System.Data;

namespace BUS_QUANLY
{
    public class NHACUNGCAP_BUS
    {
        NHACUNGCAP_DAO dao = new NHACUNGCAP_DAO();
        public void addNCC(NHACUNGCAP_DTO dto)
        {
            dao.themNCC(dto);
        }
        public DataTable showNCC()
        {
            return dao.hienThiNCC();
        }
        public void deleteNCC(NHACUNGCAP_DTO dto)
        {
            dao.xoaNCC(dto);
        }
        public void updateNCC(NHACUNGCAP_DTO dto)
        {
            dao.capnhatNCC(dto);
        }       
        public bool checkTenNcc(NHACUNGCAP_DTO dto)
        {
            return dao.checkTenNCC(dto);
        }
        public bool checkSdtNcc(NHACUNGCAP_DTO dto)
        {
            return dao.checkSDTNCC(dto);
        }
    }
}
