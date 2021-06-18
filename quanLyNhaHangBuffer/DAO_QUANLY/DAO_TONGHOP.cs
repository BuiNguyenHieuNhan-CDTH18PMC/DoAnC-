using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QUANLY
{
    public class DAO_TONGHOP:DBConnect
    {
        public DataTable showbill(DTO_TONGHOP th)
        {
            string sql = "SELECT HD.MAHD, TENNHAHANG, TENKH,HOTEN, TIMEIN, NGAY,THANG,NAM,TONGTIEN, DIACHI.DIACHI, GIAMGIA, TENMON, SL, DONGIA  FROM CTHD, HD, KHACHHANG, NHANVIEN, DIACHI, MENU WHERE HD.MAHD = CTHD.MAHD AND HD.MAHD = '" + th.Mahd + "' AND CTHD.MAMON = MENU.MAMON AND HD.MADC = DIACHI.MADC AND HD.MAKH = KHACHHANG.MAHANG AND HD.MANV = NHANVIEN.MANV";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
