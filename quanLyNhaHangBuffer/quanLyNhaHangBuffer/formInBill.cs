using Microsoft.Reporting.WinForms;
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
    public partial class formInBill : Form
    {
        string ketnoi = "Data Source=laptop-aokmt82l;Initial Catalog=qlBanNuocMangVe;Integrated Security=True";
        string mahd;    
        public formInBill(string text)
        {
            mahd = text;
            InitializeComponent();
        }

        private void formInBill_Load(object sender, EventArgs e)
        {           
            SqlConnection conn = new SqlConnection(ketnoi);
            string sql = "SELECT HD.MAHD, TENNHAHANG, TENKH,HOTEN, TIMEIN, NGAY,THANG,NAM,TONGTIEN, DIACHI.DIACHI, GIAMGIA, TENMON, SL, DONGIA  FROM CTHD, HD, KHACHHANG, NHANVIEN, DIACHI, MENU WHERE HD.MAHD = CTHD.MAHD AND HD.MAHD = '"+mahd+"' AND CTHD.MAMON = MENU.MAMON AND HD.MADC = DIACHI.MADC AND HD.MAKH = KHACHHANG.MAHANG AND HD.MANV = NHANVIEN.MANV";           
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\HieuNhan\source\repos\quanLyNhaHangBuffer\quanLyNhaHangBuffer\bill.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
