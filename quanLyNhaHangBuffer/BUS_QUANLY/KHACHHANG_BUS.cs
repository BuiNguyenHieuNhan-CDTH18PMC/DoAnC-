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
    public class KHACHHANG_BUS
    {
        KHACHHANG_DAO dao = new KHACHHANG_DAO();
        public void addKH(KHACHHANG_DTO dto)
        {
            dao.themKH(dto);
        }
        public void deleteKH(KHACHHANG_DTO dto)
        {
            dao.xoaKH(dto);
        }
        public void updateKH(KHACHHANG_DTO dto)
        {
            dao.capnhatKH(dto);
        }
        public DataTable show()
        {
            return dao.hienthi();
        }
        public DataTable showCBB()
        {
            return dao.hienthiCBB();
        }
    }
}
