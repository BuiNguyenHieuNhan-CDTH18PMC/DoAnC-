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
using BUS_QUANLY;
using DTO_QUANLY;

namespace quanLyNhaHangBuffer
{
    public partial class formHangHoa : Form
    {
        BUS_HangHoa busHH = new BUS_HangHoa();
        classKetNoi ketNoi = new classKetNoi();
        SqlConnection conn;
        SqlCommand cmd;
        string sql, ma;
        public formHangHoa()
        {
            InitializeComponent();
        }

        private void formHangHoa_Load(object sender, EventArgs e)
        {
            dtgvHH.DataSource = busHH.hienThi();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            try
            {
                conn = new SqlConnection(ketNoi.connect);
                conn.Open();
                sql = "SELECT TENNCC, MANCC FROM NCC";
                cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.Add(dr[0].ToString());
                    ma = dr[1].ToString();
                }                               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtTenNCC.AutoCompleteCustomSource = auto;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HangHoa dto = new DTO_HangHoa(int.Parse(dtgvHH[0, dtgvHH.CurrentRow.Index].Value.ToString()), int.Parse(ma), txtTenHH.Text, int.Parse(txtDonGia.Text));
                busHH.update(dto);
                txtTenHH.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtDonGia.Text = string.Empty;
                dtgvHH.DataSource = busHH.hienThi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa!") == DialogResult.OK)
            {
                DTO_HangHoa dtohh = new DTO_HangHoa(int.Parse(dtgvHH[0,dtgvHH.CurrentRow.Index].Value.ToString()));
                busHH.delete(dtohh);
                txtTenHH.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtDonGia.Text = string.Empty;
                dtgvHH.DataSource = busHH.hienThi();          
            }          
        }

        private void dtgvHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenHH.Text = dtgvHH[1, dtgvHH.CurrentRow.Index].Value.ToString();
            txtTenNCC.Text = dtgvHH[2, dtgvHH.CurrentRow.Index].Value.ToString();
            txtDonGia.Text = dtgvHH[3, dtgvHH.CurrentRow.Index].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenHH.Text = string.Empty;
            txtDonGia.Text = string.Empty;
            txtTenNCC.Text = string.Empty;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HangHoa dtohh = new DTO_HangHoa(int.Parse(ma),txtTenHH.Text, int.Parse(txtDonGia.Text));
                busHH.add(dtohh);
                dtgvHH.DataSource = busHH.hienThi();
                txtTenHH.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtDonGia.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
