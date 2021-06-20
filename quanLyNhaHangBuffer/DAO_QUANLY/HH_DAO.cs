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
    public class HH_DAO:DBConnect
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
        public void themHH(HH_DTO hh)
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
        public void xoaHH(HH_DTO hh)
        {

            sql = "DELETE FROM HANGHOA WHERE MAHH = '" + hh.Mahh + "'";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void capnhatHH(HH_DTO hh)
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
        public List<HH_DTO> autoComplete(HH_DTO hh)
        {
            List<HH_DTO> list = new List<HH_DTO>();
            sql = "SELECT TENNCC, MANCC FROM NCC";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var tencc = new HH_DTO();
                tencc.tenncc = dr[0].ToString();
                tencc.Mancc = int.Parse(dr[1].ToString());
                list.Add(tencc);
            }
            conn.Close();
            return list;
        }
        public bool checkHH(HH_DTO hh)
        {
            conn.Open();
            sql = "SELECT TENHH FROM HANGHOA WHERE TENHH = N'" + hh.Tenhh + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            conn.Close();
            return false;
        }
    }
}
