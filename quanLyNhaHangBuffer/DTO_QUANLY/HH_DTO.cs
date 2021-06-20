using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class HH_DTO
    {
        private int mahh;
        private int mancc;
        private string tenhh;
        private int dongia;
        public string tenncc;
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

        public HH_DTO() { }

        public HH_DTO(int idhh, int idncc, string ten, int gia)
        {
            this.mahh = idhh;
            this.mancc = idncc;
            this.tenhh = ten;
            this.dongia = gia;
        }
        public HH_DTO(int idncc, string ten, int gia)
        {
            this.mancc = idncc;
            this.tenhh = ten;
            this.dongia = gia;
        }
        public HH_DTO(int idhh)
        {
            this.mahh = idhh;
        }
        public HH_DTO(string ten)
        {
            this.tenhh = ten;
        }
    }
}
