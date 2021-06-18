using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class DTO_HDNH
    {
        private string mahd;
        private string ngaynhap;
        private int manv;
        private int tongtien;
        private string ten;

        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public string NgayNhap
        {
            get { return ngaynhap; }
            set { ngaynhap = value; }
        }
        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public int TongTien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public DTO_HDNH(string maHD, string ngay, int maNV, int tong)
        {
            this.mahd = maHD;
            this.ngaynhap = ngay;
            this.manv = maNV;
            this.tongtien = tong;
        }

        private int mahh;
        private int sl;
        private int thanhtien;
        private int dongia;
        public int Mahh
        {
            get { return mahh; }
            set { mahh = value; }
        }
        public int SL
        {
            get { return sl; }
            set { sl = value; }
        }
        public int Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public int DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public DTO_HDNH(string maHD, int maHH, int Sl, int tien)
        {
            this.mahd = maHD;
            this.mahh = maHH;
            this.sl = Sl;
            this.thanhtien = tien;
        }
        public DTO_HDNH(string Ten)
        {
            this.ten = Ten;
        }
        public DTO_HDNH()
        {
        }
    }
}
