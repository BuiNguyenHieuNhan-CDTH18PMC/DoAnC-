using BUS_QUANLY;
using DTO_QUANLY;
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
    public partial class formHangHoa : Form
    {
        BUS_HH busHH = new BUS_HH();
        DTO_HH dtoHH;
        string ma;
        public formHangHoa()
        {
            InitializeComponent();
        }

        private void formHangHoa_Load(object sender, EventArgs e)
        {
            List<DTO_HH> list = new List<DTO_HH>();
            dtgvHH.DataSource = busHH.hienThi();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            try
            {
                dtoHH = new DTO_HH();
                list = busHH.auto(dtoHH);
                foreach(var giatri in list)
                {
                    auto.Add(giatri.Tenhh);
                    ma = giatri.Mahh.ToString();
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
                DTO_HH dto = new DTO_HH(int.Parse(dtgvHH[0, dtgvHH.CurrentRow.Index].Value.ToString()), int.Parse(ma), txtTenHH.Text, int.Parse(txtDonGia.Text));
                busHH.update(dto);
                txtTenHH.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtDonGia.Text = string.Empty;               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtgvHH.DataSource = busHH.hienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa!") == DialogResult.OK)
            {
                DTO_HH dtohh = new DTO_HH(int.Parse(dtgvHH[0, dtgvHH.CurrentRow.Index].Value.ToString()));
                busHH.delete(dtohh);
                txtTenHH.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtDonGia.Text = string.Empty;
            }
            dtgvHH.DataSource = busHH.hienThi();
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
                DTO_HH dtohh = new DTO_HH(int.Parse(ma), txtTenHH.Text, int.Parse(txtDonGia.Text));
                busHH.add(dtohh);
                txtTenHH.Text = string.Empty;
                txtTenNCC.Text = string.Empty;
                txtDonGia.Text = string.Empty;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtgvHH.DataSource = busHH.hienThi();
        }
    }
}
