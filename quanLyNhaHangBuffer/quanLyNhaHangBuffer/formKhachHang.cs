using BUS_QUANLY;
using DTO_QUANLY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyNhaHangBuffer
{
    public partial class formKhachHang : Form
    {
        KHACHHANG_BUS bus = new KHACHHANG_BUS();
        KHACHHANG_DTO dto;
        public formKhachHang()
        {
            InitializeComponent();
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            cbHang.DisplayMember = "TENHANG";
            cbHang.ValueMember = "MAHANG";
            cbHang.DataSource = bus.showCBB();
            dtgvKH.DataSource = bus.show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && txtSDT.Text != "" && cbHang.Text != "" && txtDTL.Text != "")
            {
                string ngay = DateTime.Now.Day.ToString();
                string thang = DateTime.Now.Month.ToString();
                string nam = DateTime.Now.Year.ToString();
                string gio = DateTime.Now.Hour.ToString();
                string phut = DateTime.Now.Minute.ToString();
                string giay = DateTime.Now.Second.ToString();
                txtMaKH.Text = "KH" + ngay + thang + nam + gio + phut + giay;
                dto = new KHACHHANG_DTO(txtMaKH.Text, txtTen.Text, int.Parse(cbHang.SelectedValue.ToString()), txtSDT.Text, txtDTL.Text);
                bus.addKH(dto);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            dtgvKH.DataSource = bus.show();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && cbHang.Text != "" && txtSDT.Text != "" && txtDTL.Text != "")
            {
                dto = new KHACHHANG_DTO(txtMaKH.Text, txtTen.Text, int.Parse(cbHang.SelectedValue.ToString()), txtSDT.Text, txtDTL.Text);
                bus.updateKH(dto);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            dtgvKH.DataSource = bus.show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa", "Lưu ý") == DialogResult.OK)
                {
                    dto = new KHACHHANG_DTO(txtMaKH.Text);
                    bus.deleteKH(dto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa được hệ thống xử lí\n   Vui lòng thao tác lại");
            }
            dtgvKH.DataSource = bus.show();
        }

        private void dtgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgvKH[0, dtgvKH.CurrentRow.Index].Value.ToString();
            txtTen.Text = dtgvKH[1, dtgvKH.CurrentRow.Index].Value.ToString();
            cbHang.Text = dtgvKH[2, dtgvKH.CurrentRow.Index].Value.ToString();
            txtSDT.Text = dtgvKH[3, dtgvKH.CurrentRow.Index].Value.ToString();
            txtDTL.Text = dtgvKH[4, dtgvKH.CurrentRow.Index].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTen.Text = string.Empty;
            txtDTL.Text = string.Empty;            
            txtSDT.Text = string.Empty;
            txtMaKH.Text = string.Empty;
        }
    }
}
