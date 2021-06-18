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
    public class DAO_HH:DBConnect
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
        public void themHH(DTO_HH hh)
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
        public void xoaHH(DTO_HH hh)
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
        public void capnhatHH(DTO_HH hh)
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
        public List<DTO_HH> autoComplete(DTO_HH hh)
        {
            List<DTO_HH> list = new List<DTO_HH>();
            conn.Open();
            sql = "SELECT TENNCC, MANCC FROM NCC";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hh.Tenhh = dr[0].ToString();
                hh.Mahh = int.Parse(dr[1].ToString());
                list.Add(hh);
            }
            conn.Close();
            return list;
        }
    }
}
