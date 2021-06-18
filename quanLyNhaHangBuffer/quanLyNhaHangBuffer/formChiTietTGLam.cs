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
    public partial class formChiTietTGLam : Form
    {
        BUS_CALAMVIEC bus = new BUS_CALAMVIEC();
        DTO_CALAMVIEC dto;
        public formChiTietTGLam()
        {
            InitializeComponent();
        }

        private void formChiTietTGLam_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.hienthi();
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dto = new DTO_CALAMVIEC(dateBD.Value, dateKT.Value, int.Parse(txtSoGio.Text));
                bus.addCa(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Thành công");
                dataGridView1.DataSource = bus.hienthi();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dateBD.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            dateKT.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            txtSoGio.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                dto = new DTO_CALAMVIEC(int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()), dateBD.Value, dateKT.Value, int.Parse(txtSoGio.Text));
                bus.updateCa(dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataGridView1.DataSource = bus.hienthi();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa!") == DialogResult.OK)
            {
                dto = new DTO_CALAMVIEC(int.Parse(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString()));
                bus.deleteCa(dto);
            }
            dateBD.Text = DateTime.Now.TimeOfDay.ToString();
            dateKT.Text = DateTime.Now.TimeOfDay.ToString();
            txtSoGio.Text = "0";
            dataGridView1.DataSource = bus.hienthi();
        }
    }
}
