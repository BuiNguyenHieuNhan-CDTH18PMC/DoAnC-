using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class NHACUNGCAP_DTO
    {
        public int mancc { get; set; }
        public string tenncc { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string mota { get; set; }
        public NHACUNGCAP_DTO() { }
        public NHACUNGCAP_DTO(string ten, string dc, string Sdt, string Mota)
        {
            this.tenncc = ten;
            this.diachi = dc;
            this.sdt = Sdt;
            this.mota = Mota;
        }
        public NHACUNGCAP_DTO(int ma, string ten, string dc, string Sdt, string Mota) 
        {
            this.mancc = ma;
            this.tenncc = ten;
            this.diachi = dc;
            this.sdt = Sdt;
            this.mota = Mota;
        }
        public NHACUNGCAP_DTO(int ma)
        {
            this.mancc = ma;            
        }
        public NHACUNGCAP_DTO(string ten)
        {
            this.tenncc = ten;
        }
    }
}
