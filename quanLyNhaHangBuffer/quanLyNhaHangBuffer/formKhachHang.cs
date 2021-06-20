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
        public formKhachHang()
        {
            InitializeComponent();
        }

        private void formKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kH.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.kH.KHACHHANG);

        }
    }
}
