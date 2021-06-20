using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class KHACHHANG_DTO
    {
        public string makh { get; set; }
        public string tenkh { get; set; }
        public int mahang { get; set; }
        public string tenhang { get; set; }
        public string sdt { get; set; }
        public string diemtichluy { get; set; }
        public KHACHHANG_DTO() { }
        public KHACHHANG_DTO(string Ma, string Ten, int Mahang, string SDT, string DTL)
        {
            this.makh = Ma;
            this.tenkh = Ten;
            this.mahang = Mahang;
            this.sdt = SDT;
            this.diemtichluy = DTL;
        }
        public KHACHHANG_DTO(string Ma)
        {
            this.makh = Ma;           
        }
    }
}
