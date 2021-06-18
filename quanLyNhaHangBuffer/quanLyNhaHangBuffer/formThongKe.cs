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
using System.Windows.Forms.DataVisualization.Charting;

namespace quanLyNhaHangBuffer
{
    public partial class formThongKe : Form
    {
        BUS_THONGKE bus = new BUS_THONGKE();
        DTO_THONGKE dto;       
        string thongKeNgay = "select NGAY, SUM(TONGTIEN) AS TONGDOANHTHU FROM HD GROUP BY NGAY";
        string thongKeThang = "select THANG, SUM(TONGTIEN) AS TONGDOANHTHU FROM HD GROUP BY THANG";
        string thongKeSanPham = "select TENMON, SUM(THANHTIEN) AS TONGDOANHTHU FROM MENU, CTHD WHERE MENU.MAMON = CTHD.MAMON GROUP BY TENMON";
        public formThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKeNgay_Click(object sender, EventArgs e)
        {
            dto = new DTO_THONGKE(thongKeNgay);
            chart1.DataSource = bus.thongKe(dto);
            chart1.Series["Series1"].XValueMember = "NGAY";
            chart1.Series["Series1"].YValueMembers = "TONGDOANHTHU";
            chart1.Titles.Add("Thống kê ngày");
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Titles.RemoveAt(0);
        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            dto = new DTO_THONGKE(thongKeThang);
            chart1.DataSource = bus.thongKe(dto);
            chart1.Series["Series1"].XValueMember = "THANG";
            chart1.Series["Series1"].YValueMembers = "TONGDOANHTHU";
            chart1.Titles.Add("Thống kê tháng");
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Titles.RemoveAt(0);
        }

        private void btnThongKeHH_Click(object sender, EventArgs e)
        {
            dto = new DTO_THONGKE(thongKeSanPham);
            chart1.DataSource = bus.thongKe(dto);
            chart1.Series["Series1"].XValueMember = "TENMON";
            chart1.Series["Series1"].YValueMembers = "TONGDOANHTHU";
            chart1.Titles.Add("Thống kê hàng hóa");
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Titles.RemoveAt(0);
            chart1.Update();
        }
    }
}
