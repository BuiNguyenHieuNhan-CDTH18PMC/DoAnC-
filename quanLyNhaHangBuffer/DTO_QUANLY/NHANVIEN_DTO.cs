using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLY
{
    public class NHANVIEN_DTO
    {
        public int manv { get; set; }
        public string hoten { get; set; }
        public string ngaysinh { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public string cccd { get; set; }
        public int luong { get; set; }
        public NHANVIEN_DTO() { }
        public NHANVIEN_DTO(string Hoten, string Ngay, string DiaChi, string SDT, string CCCD, int Luong)
        {
            this.hoten = Hoten;
            this.ngaysinh = Ngay;
            this.diachi = DiaChi;
            this.sdt = SDT;
            this.cccd = CCCD;
            this.luong = Luong;
        }
        public NHANVIEN_DTO(int Manv, string Hoten, string Ngay, string DiaChi, string SDT, string CCCD, int Luong)
        {
            this.manv = Manv;
            this.hoten = Hoten;
            this.ngaysinh = Ngay;
            this.diachi = DiaChi;
            this.sdt = SDT;
            this.cccd = CCCD;
            this.luong = Luong;
        }
        public NHANVIEN_DTO(int Manv)
        {
            this.manv = Manv;            
        }
        public NHANVIEN_DTO(string sdt)
        {
            this.sdt = sdt;
        }
    }
}
