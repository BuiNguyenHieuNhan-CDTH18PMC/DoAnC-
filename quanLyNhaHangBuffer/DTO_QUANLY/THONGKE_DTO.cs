using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class THONGKE_DTO
    {
        private string chuoi;
        public string Chuoi
        {
            get { return chuoi; }
            set { chuoi = value; }
        }
        public THONGKE_DTO(string chu)
        {
            this.chuoi = chu;
        }
    }
}
