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
    public class CALAMVIEC_DAO:DBConnect
    {
        SqlCommand cmd;
        string sql;
        public DataTable show()
        {
            sql = "SELECT * FROM CALAMVIEC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void themCa(CALAMVIEC_DTO dto)
        {
            try
            {
                sql = "INSERT INTO CALAMVIEC VALUES (@giobd, @giokt, @sogio)";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@giobd", dto.GioBD);
                cmd.Parameters.AddWithValue("@giokt", dto.GioKT);
                cmd.Parameters.AddWithValue("@sogio", dto.Sogio);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void capnhatCa(CALAMVIEC_DTO dto)
        {
            try
            {
                sql = "UPDATE CALAMVIEC SET GIOBD = @giobd, GIOKT = @giokt, SOGIO = @sogio WHERE MACALAM = @ma";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@giobd", dto.GioBD);
                cmd.Parameters.AddWithValue("@giokt", dto.GioKT);
                cmd.Parameters.AddWithValue("@sogio", dto.Sogio);
                cmd.Parameters.AddWithValue("@ma", dto.Sogio);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public void xoaCa(CALAMVIEC_DTO dto)
        {
            try
            {
                sql = "DELETE FROM CALAMVIEC WHERE MACALAM = @ma";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", dto.Macalam);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
