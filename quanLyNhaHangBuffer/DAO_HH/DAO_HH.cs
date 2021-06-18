using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QUANLY;

namespace DAO_QUANLY
{
    public class DAO_HangHoa : DBConnect
    {
        SqlCommand cmd;
        string sql;
        public DataTable showHH()
        {
                string sql = "SELECT MAHH, TENNCC, TENHH,DONGIA FROM HANGHOA, NCC WHERE HANGHOA.MANCC = NCC.MANCC";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;    
        }
        public void themHH(DTO_HangHoa hh)
        {
            try
            {
                sql = "INSERT INTO HANGHOA VALUES (@mancc, @tenhh, @dongia)";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mancc", hh.Mancc);
                cmd.Parameters.AddWithValue("@tenhh", hh.Tenhh);
                cmd.Parameters.AddWithValue("@dongia", hh.Dongia);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void xoaHH(DTO_HangHoa hh)
        {
            try
            {
                sql = "DELETE FROM HANGHOA WHERE MAHH = '" + hh.Mahh + "'";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();               
            }
            catch (Exception ex)
            {

            }
        }
        public void capnhatHH(DTO_HangHoa hh)
        {
            try
            {
                sql = "UPDATE HANGHOA SET MANCC = @mancc, TENHH = @tenhh, DONGIA = @dongia WHERE MAHH = '" + hh.Mahh + "'";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mancc", hh.Mancc);
                cmd.Parameters.AddWithValue("@tenhh", hh.Tenhh);
                cmd.Parameters.AddWithValue("@dongia", hh.Dongia);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
