using BUS_QUANLY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QUANLY;
namespace quanLyNhaHangBuffer
{
    public partial class formNhaCungCap : Form
    {
        NHACUNGCAP_BUS bus = new NHACUNGCAP_BUS();
        NHACUNGCAP_DTO dto;
        public formNhaCungCap()
        {
            InitializeComponent();
        }

        private void formNhaCungCap_Load(object sender, EventArgs e)
        {
            dtgvNCC.DataSource = bus.showNCC();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dto = new NHACUNGCAP_DTO(txtTenNCC.Text);
            if (bus.checkTenNcc(dto) == false)
            {
                dto = new NHACUNGCAP_DTO(txtSDT.Text);
                if (bus.checkSdtNcc(dto) == false)
                {
                    dto = new NHACUNGCAP_DTO(txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtMota.Text);
                    bus.addNCC(dto);
                }
                else
                    MessageBox.Show("Số điện thoại bị trùng");
            }
            else
                MessageBox.Show("Tên nhà cung cấp đã tồn tại");
            dtgvNCC.DataSource = bus.showNCC();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtMota.Text = "";
            txtSDT.Text = "";
            txtTenNCC.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dto = new NHACUNGCAP_DTO(int.Parse(dtgvNCC[0,dtgvNCC.CurrentRow.Index].Value.ToString()));
            bus.deleteNCC(dto);
            dtgvNCC.DataSource = bus.showNCC();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dto = new NHACUNGCAP_DTO(txtSDT.Text);
            if (bus.checkSdtNcc(dto) == false)
            {
                dto = new NHACUNGCAP_DTO(int.Parse(dtgvNCC[0, dtgvNCC.CurrentRow.Index].Value.ToString()), txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtMota.Text);
                bus.updateNCC(dto);
            }
            else
                MessageBox.Show("Số điện thoại bị trùng");
            dtgvNCC.DataSource = bus.showNCC();
        }

        private void dtgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNCC.Text = dtgvNCC[1, dtgvNCC.CurrentRow.Index].Value.ToString();
            txtDiaChi.Text = dtgvNCC[2, dtgvNCC.CurrentRow.Index].Value.ToString();
            txtSDT.Text = dtgvNCC[3, dtgvNCC.CurrentRow.Index].Value.ToString();
            txtMota.Text = dtgvNCC[4, dtgvNCC.CurrentRow.Index].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
