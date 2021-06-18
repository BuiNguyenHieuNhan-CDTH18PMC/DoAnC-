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
    public partial class formHoaDonNhapHang : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        classKetNoi ketNoi = new classKetNoi();
        string sql, ma;
        int tong = 0;
        string date = DateTime.Now.Date.ToShortDateString();
        public formHoaDonNhapHang()
        {
            InitializeComponent();
        }

        private void btnTaoMa_Click(object sender, EventArgs e)
        {          
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hh = DateTime.Now.Hour.ToString();
            string mm = DateTime.Now.Minute.ToString();
            string ss = DateTime.Now.Second.ToString();
            txtMaHD.Text = "HDNH" + day + month + year + hh + mm + ss;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenHH.Text) && txtSL.Text != "0")
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ma;
                row.Cells[1].Value = txtTenHH.Text;
                row.Cells[2].Value = txtSL.Text;
                row.Cells[3].Value = txtDonGia.Text;
                row.Cells[4].Value = txtThanhTien.Text;
                dataGridView1.Rows.Add(row);
                tong += int.Parse(txtThanhTien.Text);
                txtMaHD.Text = string.Empty;
                txtTenHH.Text = String.Empty;
                txtTong.Text = tong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên hàng hoặc số lượng");
            }
        }

        private void formHoaDonNhapHang_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            conn = new SqlConnection(ketNoi.connect);
            sql = "SELECT TENHH FROM HANGHOA";
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                auto.Add(dr[0].ToString());
            }
            txtTenHH.AutoCompleteCustomSource = auto;
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtSL.Text != "0")
            {
                int tt;
                tt = int.Parse(txtSL.Text) * int.Parse(txtDonGia.Text);
                txtThanhTien.Text = tt.ToString();
            }
            else
            {
                txtThanhTien.Text = "0";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaHD.Text) && !string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                if (txtSL.Text != "0")
                {
                    conn = new SqlConnection(ketNoi.connect);
                    sql = "INSERT INTO HDNHAPHH VALUES(@mahd, @ngay, @manv ,@tongtien)";
                    conn.Open();
                    try
                    {
                        cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text);
                        cmd.Parameters.AddWithValue("@ngay", date);
                        cmd.Parameters.AddWithValue("@manv", "1");
                        cmd.Parameters.AddWithValue("@tongtien", txtTong.Text);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        try
                        {
                            sql = "INSERT INTO CTHDNHAP VALUES (@mahd, @mahh, @sl, @thanhtien)";
                            cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@mahd", txtMaHD.Text);
                            cmd.Parameters.AddWithValue("@mahh", dataGridView1.Rows[i].Cells[0].Value);
                            cmd.Parameters.AddWithValue("@sl", dataGridView1.Rows[i].Cells[2].Value);
                            cmd.Parameters.AddWithValue("@thanhtien", dataGridView1.Rows[i].Cells[4].Value);
                            cmd.ExecuteNonQuery();                           
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }                   
                    MessageBox.Show("Thêm thành công");
                    txtMaHD.Text = string.Empty;
                    txtTenHH.Text = String.Empty;
                }
                else
                    MessageBox.Show("Vui lòng nhập số lượng");
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin");
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if(txtDonGia.Text == "0")
            {
                txtSL.Text = "0";
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenHH.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            txtSL.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            txtDonGia.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            txtThanhTien.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                if (row.Cells[1].Value.ToString() == txtTenHH.Text)
                {
                    row.Cells[2].Value = txtSL.Text;
                    row.Cells[4].Value = txtThanhTien.Text;
                }
            }
        }

        private void txtTenHH_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenHH.Text))
            {
                conn = new SqlConnection(ketNoi.connect);
                sql = "SELECT DONGIA, MAHH FROM HANGHOA WHERE TENHH = N'" + txtTenHH.Text + "'";
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtDonGia.Text = dr[0].ToString();
                    ma = dr[1].ToString();
                }
            }
            else
            {
                txtDonGia.Text = "0";
            }
        }
    }
}
