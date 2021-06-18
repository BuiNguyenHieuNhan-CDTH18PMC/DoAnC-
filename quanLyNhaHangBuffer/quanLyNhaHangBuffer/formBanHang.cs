using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyNhaHangBuffer
{
    public partial class formBanHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        int tt = 0;
        int thanhtien;
        string sql, ma, ten, gia;
        classKetNoi ketNoi = new classKetNoi();
        string day = DateTime.Now.Day.ToString();
        string month = DateTime.Now.Month.ToString();
        string year = DateTime.Now.Year.ToString();        

        private void btnTraSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ketNoi.connect);
            sql = "SELECT * FROM MENU WHERE MAMON = 2";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ma = dr[0].ToString();
                ten = dr[1].ToString();
                gia = dr[2].ToString();
            }
            thanhtien = int.Parse(txtSL.Text) * int.Parse(gia);
            conn.Close();
            DataGridViewRow row = (DataGridViewRow)dtgvOder.Rows[0].Clone();
            row.Cells[0].Value = ma;
            row.Cells[1].Value = ten;
            row.Cells[2].Value = txtSL.Text;
            row.Cells[3].Value = gia;
            row.Cells[4].Value = thanhtien;
            dtgvOder.Rows.Add(row);
            tt += thanhtien;
            txtTongTien.Text = tt.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(ketNoi.connect);
                sql = "INSERT INTO HD VALUES (@mahd,'1', '1', @timein, @ngay, @thang, @nam, @tongtien, '1', '0')";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text);
                cmd.Parameters.AddWithValue("@timein", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@ngay", lblNgay.Text);
                cmd.Parameters.AddWithValue("@thang", lblThang.Text);
                cmd.Parameters.AddWithValue("@nam", lblNam.Text);
                cmd.Parameters.AddWithValue("@tongtien", txtTongTien.Text);
                cmd.ExecuteNonQuery();
                for(int i = 0; i < dtgvOder.Rows.Count - 1; i++)
                {
                    sql = "INSERT INTO CTHD VALUES (@mahd, @mamon, @sl, @dongia, @thanhtien)";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text);
                    cmd.Parameters.AddWithValue("@mamon", dtgvOder.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@sl", dtgvOder.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@dongia", dtgvOder.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@thanhtien", dtgvOder.Rows[i].Cells[4].Value);
                    cmd.ExecuteNonQuery();                    
                }               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            formInBill bill = new formInBill(txtMaHD.Text);
            bill.Show();
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hh = DateTime.Now.Hour.ToString();
            string mm = DateTime.Now.Minute.ToString();
            string ss = DateTime.Now.Second.ToString();
            txtMaHD.Text = "HD" + day + month + year + hh + mm + ss;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dtgvOder.SelectedCells)
            {
                if (oneCell.Selected)
                    dtgvOder.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            tt = tt - int.Parse(dtgvOder[4, dtgvOder.CurrentRow.Index].Value.ToString());
            for (int i = 0; i < dtgvOder.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dtgvOder.Rows[i];
                if (row.Cells[1].Value.ToString() == dtgvOder[1,dtgvOder.CurrentRow.Index].Value.ToString())
                {
                    row.Cells[2].Value = txtSL.Text;
                    thanhtien = int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString());
                    row.Cells[4].Value = thanhtien.ToString();                   
                }
            }
            tt += thanhtien;
            txtTongTien.Text = tt.ToString();
        }

        public formBanHang()
        {
            InitializeComponent();
        }

        private void formBanHang_Load(object sender, EventArgs e)
        {
            lblNgay.Text = day;
            lblThang.Text = month;
            lblNam.Text = year;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnTraDao_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ketNoi.connect);
            sql = "SELECT * FROM MENU WHERE MAMON = 1";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ma = dr[0].ToString();
                ten = dr[1].ToString();
                gia = dr[2].ToString();
            }
            thanhtien = int.Parse(txtSL.Text) * int.Parse(gia);
            conn.Close();
            DataGridViewRow row = (DataGridViewRow)dtgvOder.Rows[0].Clone();
            row.Cells[0].Value = ma;
            row.Cells[1].Value = ten;
            row.Cells[2].Value = txtSL.Text;
            row.Cells[3].Value = gia;
            row.Cells[4].Value = thanhtien;
            dtgvOder.Rows.Add(row);
            tt += thanhtien;
            txtTongTien.Text = tt.ToString();
        }
    }
}
