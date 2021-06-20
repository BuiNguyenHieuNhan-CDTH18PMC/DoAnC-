using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class TONGHOP_DTO
    {
        private string mahd;
        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public TONGHOP_DTO(string ma) 
        {
            this.mahd = ma;
        }
    }
}
