using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_QUANLY
{
    public class HDNH_DAO:DBConnect
    {
        SqlCommand cmd;
        string sql;
        public void luuHD(HDNH_DTO hd)
        {
            sql = "INSERT INTO HDNHAPHH VALUES(@mahd, @ngay, @manv, @tongtien)";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mahd", hd.Mahd);
            cmd.Parameters.AddWithValue("@ngay", hd.NgayNhap);
            cmd.Parameters.AddWithValue("@manv", hd.Manv);
            cmd.Parameters.AddWithValue("@tongtien", hd.TongTien);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void luuCTHD(HDNH_DTO hd)
        {
            sql = "INSERT INTO CTHDNHAP VALUES (@mahd, @mahh, @sl, @thanhtien)";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@mahd", hd.Mahd);
            cmd.Parameters.AddWithValue("@mahh", hd.Mahh);
            cmd.Parameters.AddWithValue("@sl", hd.SL);
            cmd.Parameters.AddWithValue("@thanhtien", hd.Thanhtien);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<HDNH_DTO> timGiaVaMa(HDNH_DTO hd)
        {
            List<HDNH_DTO> giatri = new List<HDNH_DTO>();
            sql = "SELECT DONGIA, MAHH FROM HANGHOA WHERE TENHH = N'" + hd.Ten + "'";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                hd.DonGia = int.Parse(dr[0].ToString());
                hd.Mahh = int.Parse(dr[1].ToString());
                giatri.Add(hd);
            }
            conn.Close();
            return giatri;
        }
        public List<HDNH_DTO> autoComplete(HDNH_DTO hd)
        {
            List<HDNH_DTO> giatri = new List<HDNH_DTO>();
            sql = "SELECT TENHH FROM HANGHOA";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var tensp = new HDNH_DTO();
                tensp.Ten = dr[0].ToString();
                giatri.Add(tensp);
            }
            conn.Close();
            return giatri;
        }      
    }
}
