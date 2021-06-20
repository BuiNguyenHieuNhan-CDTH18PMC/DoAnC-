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
    public class NHACUNGCAP_DAO:DBConnect
    {
        SqlCommand cmd;        
        string sql;
        SqlDataAdapter da;
        DataTable dt;
        public void themNCC(NHACUNGCAP_DTO ncc)
        {
            conn.Open();
            sql = "INSERT INTO NCC VALUES (@TENNCC, @DIACHI, @SDT, @MOTA)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TENNCC", ncc.tenncc);
            cmd.Parameters.AddWithValue("@DIACHI", ncc.diachi);
            cmd.Parameters.AddWithValue("@SDT", ncc.sdt);
            cmd.Parameters.AddWithValue("@MOTA", ncc.mota);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable hienThiNCC()
        {
            conn.Open();
            sql = "SELECT * FROM NCC";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public void xoaNCC(NHACUNGCAP_DTO ncc)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM NCC WHERE MANCC = '" + ncc.mancc + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void capnhatNCC(NHACUNGCAP_DTO ncc)
        {
            conn.Open();
            sql = "UPDATE NCC SET TENNCC = N'" + ncc.tenncc + "',DIACHI= N'" + ncc.diachi + "',SDT= N'" + ncc.sdt + "',MOTA= N'" + ncc.mota + "'WHERE MANCC='" + ncc.mancc + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();          
        }      
        public bool checkTenNCC(NHACUNGCAP_DTO dto)
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM NCC WHERE TENNCC = N'" + dto.tenncc + "'";
                cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool checkSDTNCC(NHACUNGCAP_DTO dto)
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM NCC WHERE SDT = N'" + dto.sdt + "'";
                cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    return true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
