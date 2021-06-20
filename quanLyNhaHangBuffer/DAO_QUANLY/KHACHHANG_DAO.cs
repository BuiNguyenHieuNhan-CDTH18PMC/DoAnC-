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
    public class KHACHHANG_DAO:DBConnect
    {
        SqlCommand cmd;
        string sql;
        SqlDataAdapter adt;
        DataTable tb;
        public void themKH(KHACHHANG_DTO dto)
        {
            conn.Open();
            sql = "INSERT INTO KHACHHANG VALUES (@MAKH, @TENKH,@MAHANG, @SDT, @DIEMTL)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MAKH", dto.makh);
            cmd.Parameters.AddWithValue("@TENKH", dto.tenkh);
            cmd.Parameters.AddWithValue("@MAHANG", dto.mahang);
            cmd.Parameters.AddWithValue("@SDT", dto.sdt);
            cmd.Parameters.AddWithValue("@DIEMTL", dto.diemtichluy);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaKH(KHACHHANG_DTO dto)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM KHACHHANG WHERE MAKH = '" + dto.makh + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void capnhatKH(KHACHHANG_DTO dto)
        {
            conn.Open();
            sql = "UPDATE KHACHHANG SET TENKH = N'" + dto.tenkh + "',MAHANG = '" + dto.mahang + "',SDT= '" + dto.sdt + "',DIEMTL= '" + dto.diemtichluy + "'WHERE MAKH='" + dto.makh + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable hienthi()
        {
            try
            {
                string select = "SELECT MAKH, KHACHHANG.MAHANG, TENKH, TENHANG, SDT, DIEMTL FROM KHACHHANG, HANGMUC WHERE KHACHHANG.MAHANG = HANGMUC.MAHANG";
                conn.Open();
                adt = new SqlDataAdapter(select, conn);
                tb = new DataTable();
                adt.Fill(tb);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return tb;
        }
        public DataTable hienthiCBB()
        {
            try
            {
                sql = "select * FROM HANGMUC";
                conn.Open();
                adt = new SqlDataAdapter(sql, conn);
                tb = new DataTable();
                adt.Fill(tb);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return tb;
        }
    }
}
