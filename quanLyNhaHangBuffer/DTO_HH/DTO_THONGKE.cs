using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class DTO_THONGKE
    {
        private string chuoi;
        public string Chuoi
        {
            get { return chuoi; }
            set { chuoi = value; }
        }
        public DTO_THONGKE(string chu) 
        {
            this.chuoi = chu;
        }
    }
}
