using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class DTO_HangHoa
    {
        private int mahh;
        private int mancc;
        private string tenhh;
        private int dongia;

        public int Mahh
        {
            get { return mahh; }
            set { mahh = value; }
        }
        public int Mancc
        {
            get { return mancc; }
            set { mancc = value; }
        }
        public string Tenhh
        {
            get { return tenhh; }
            set { tenhh = value; }
        }

        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        public DTO_HangHoa() { }

        public DTO_HangHoa(int idhh, int idncc, string ten, int gia)
        {
            this.mahh = idhh;
            this.mancc = idncc;
            this.tenhh = ten;
            this.dongia = gia;
        }
        public DTO_HangHoa(int idncc, string ten, int gia)
        {
            this.mancc = idncc;
            this.tenhh = ten;
            this.dongia = gia;
        }
        public DTO_HangHoa(int idhh)
        {
            this.mahh = idhh;          
        }
    }
}
