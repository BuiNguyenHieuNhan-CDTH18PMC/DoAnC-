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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelDM.Visible = false;
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            if (panelDM.Visible == false)
                panelDM.Visible = true;
            else
                panelDM.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form activeForm = null;

        private void openFormChild(Form child)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelChild.Controls.Add(child);
            panelChild.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openFormChild(new formNhanVien());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            openFormChild(new formNhaCungCap());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            openFormChild(new formBanHang());
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            openFormChild(new formHangHoa());
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            openFormChild(new formHoaDonNhapHang());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openFormChild(new formThongKe());
        }

        private void btnChiTietLich_Click(object sender, EventArgs e)
        {
            openFormChild(new formChiTietTGLam());
        }
    }
}
