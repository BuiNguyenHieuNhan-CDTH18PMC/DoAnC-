using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QUANLY;
namespace DAO_QUANLY
{
    public class NHANVIEN_DAO:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        string sql;
        public void themNV(NHANVIEN_DTO nv)
        {
            sql = "INSERT INTO NHANVIEN VALUES (@HOTEN, @NGAYSINH, @DIACHI, @SDT, @CCCD, @LUONG)";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@HOTEN", nv.hoten);
            cmd.Parameters.AddWithValue("@NGAYSINH", nv.ngaysinh);
            cmd.Parameters.AddWithValue("@DIACHI", nv.diachi);
            cmd.Parameters.AddWithValue("@SDT", nv.sdt);
            cmd.Parameters.AddWithValue("@CCCD", nv.cccd);
            cmd.Parameters.AddWithValue("@LUONG", nv.luong);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable hienThi()
        {
            string select = "SELECT * FROM NHANVIEN";
            da = new SqlDataAdapter(select, conn);
            dt = new DataTable();
            da.Fill(dt);            
            return dt;
        }
        public void capNhatNV(NHANVIEN_DTO nv)
        {
            conn.Open();
            sql = "UPDATE NHANVIEN SET HOTEN=N'" + nv.hoten + "',SINHNHAT= '" + nv.ngaysinh + "',DIACHI=N'" + nv.diachi + "',SDT= '" + nv.sdt + "',CCCD= '" + nv.cccd + "', LUONG = '"+ nv.luong +"' WHERE MANV='" + nv.manv + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaNV(NHANVIEN_DTO nv)
        {
            conn.Open();
            sql = "DELETE FROM NHANVIEN WHERE MANV = '" + nv.manv + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public bool checkSDTNV(NHANVIEN_DTO nv)
        {
            sql = "select SDT from NHANVIEN where SDT= N'" + nv.sdt + "'";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
                return true;
            conn.Close();
            return false;
        }
        public bool checkCCCDNV(NHANVIEN_DTO nv)
        {
            sql = "select CCCD from NHANVIEN where CCCD= N'" + nv.cccd + "'";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dar = cmd.ExecuteReader();
            if (dar.Read())
                return true;           
            conn.Close();
            return false;
        }
    }
}
