using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QUANLY;
using DTO_QUANLY;
namespace quanLyNhaHangBuffer
{
    public partial class formNhanVien : Form
    {
        NHANVIEN_BUS bus = new NHANVIEN_BUS();
        NHANVIEN_DTO dto;
        public formNhanVien()
        {
            InitializeComponent();
        }

        private void formNhanVien_Load(object sender, EventArgs e)
        {
            dtgvNV.DataSource = bus.showNV();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dto = new NHANVIEN_DTO(txtSDT.Text);
            if (bus.checkSdtNV(dto) == false)
            {
                dto = new NHANVIEN_DTO(txtCCCD.Text);
                if (bus.checkCccdNV(dto) == false)
                {
                    dto = new NHANVIEN_DTO(txtTenNV.Text, dtNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtCCCD.Text, int.Parse(txtLuong.Text));
                    bus.addNV(dto);
                    txtTenNV.Text = string.Empty;
                    txtSDT.Text = string.Empty;
                    txtDiaChi.Text = string.Empty;
                    txtCCCD.Text = string.Empty;
                    txtLuong.Text = string.Empty;
                    dtgvNV.DataSource = bus.showNV();
                }
                else
                    MessageBox.Show("CCCD đã tồn tại");
            }
            else
                MessageBox.Show("Số điện thoại này đã tồn tại");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dto = new NHANVIEN_DTO(txtSDT.Text);
            if (bus.checkSdtNV(dto) == false)
            {
                dto = new NHANVIEN_DTO(txtCCCD.Text);
                if (bus.checkCccdNV(dto) == false)
                {
                    dto = new NHANVIEN_DTO(int.Parse(dtgvNV[0, dtgvNV.CurrentRow.Index].Value.ToString()), txtTenNV.Text, dtNgaySinh.Text, txtDiaChi.Text, txtSDT.Text, txtCCCD.Text, int.Parse(txtLuong.Text));
                    bus.updateNV(dto);
                    dtgvNV.DataSource = bus.showNV();
                }
                else
                    MessageBox.Show("CCCD đã tồn tại");
            }
            else
                MessageBox.Show("Số điện thoại này đã tồn tại");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa", "Lưu ý") == DialogResult.OK)
            {
                dto = new NHANVIEN_DTO(int.Parse(dtgvNV[0, dtgvNV.CurrentRow.Index].Value.ToString()));
                bus.deleteNV(dto);
                txtTenNV.Text = string.Empty;
                txtSDT.Text = string.Empty;
                txtDiaChi.Text = string.Empty;
                txtCCCD.Text = string.Empty;
                txtLuong.Text = string.Empty;
            }
            dtgvNV.DataSource = bus.showNV();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTenNV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtLuong.Text = string.Empty;
        }

        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenNV.Text = dtgvNV[1, dtgvNV.CurrentRow.Index].Value.ToString();
            dtNgaySinh.Text = dtgvNV[2, dtgvNV.CurrentRow.Index].Value.ToString();
            txtDiaChi.Text = dtgvNV[3, dtgvNV.CurrentRow.Index].Value.ToString();
            txtSDT.Text = dtgvNV[4, dtgvNV.CurrentRow.Index].Value.ToString();
            txtCCCD.Text = dtgvNV[5, dtgvNV.CurrentRow.Index].Value.ToString();
            txtLuong.Text = dtgvNV[6, dtgvNV.CurrentRow.Index].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
