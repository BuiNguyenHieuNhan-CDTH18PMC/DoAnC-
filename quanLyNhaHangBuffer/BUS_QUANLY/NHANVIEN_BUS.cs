using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLY;
using DAO_QUANLY;
using System.Data;

namespace BUS_QUANLY
{
    public class NHANVIEN_BUS
    {
        NHANVIEN_DAO dao = new NHANVIEN_DAO();

        public void addNV(NHANVIEN_DTO nv)
        {
            dao.themNV(nv);
        }
        public DataTable showNV()
        {
            return dao.hienThi();
        }
        public void updateNV(NHANVIEN_DTO nv)
        {
            dao.capNhatNV(nv);
        }
        public void deleteNV(NHANVIEN_DTO nv)
        {
            dao.xoaNV(nv);
        }
        public bool checkSdtNV(NHANVIEN_DTO nv)
        {
            return dao.checkSDTNV(nv);
        }
        public bool checkCccdNV(NHANVIEN_DTO nv)
        {
            return dao.checkCCCDNV(nv);
        }
    }
}
