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
        HH_BUS busHH = new HH_BUS();
        HH_DTO dtoHH;
        List<HH_DTO> list = new List<HH_DTO>();
        string ma;
        public formHangHoa()
        {
            InitializeComponent();
        }

        private void formHangHoa_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            dtoHH = new HH_DTO();           
            list = busHH.auto(dtoHH);
            foreach (var giatri in list)
            {
                auto.Add(giatri.tenncc);
                ma = giatri.Mahh.ToString();
            }
            txtTenNCC.AutoCompleteCustomSource = auto;
            dtgvHH.DataSource = busHH.hienThi();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                HH_DTO dto = new HH_DTO(int.Parse(dtgvHH[0, dtgvHH.CurrentRow.Index].Value.ToString()), int.Parse(ma), txtTenHH.Text, int.Parse(txtDonGia.Text));
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
                HH_DTO dtohh = new HH_DTO(int.Parse(dtgvHH[0, dtgvHH.CurrentRow.Index].Value.ToString()));
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
                dtoHH = new HH_DTO(txtTenHH.Text);
                if (busHH.checkHangHoa(dtoHH) == false)
                {
                    dtoHH = new HH_DTO(int.Parse(ma), txtTenHH.Text, int.Parse(txtDonGia.Text));
                    busHH.add(dtoHH);
                    txtTenHH.Text = string.Empty;
                    txtTenNCC.Text = string.Empty;
                    txtDonGia.Text = string.Empty;
                }
                else
                    MessageBox.Show("Sản phẩm bị trùng");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dtgvHH.DataSource = busHH.hienThi();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
