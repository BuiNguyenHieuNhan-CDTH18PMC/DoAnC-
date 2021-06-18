using BUS_QUANLY;
using DTO_QUANLY;
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
        BUS_TONGHOP bus = new BUS_TONGHOP();
        DTO_TONGHOP dto;
        string mahd;    
        public formInBill(string text)
        {
            mahd = text;
            InitializeComponent();
        }

        private void formInBill_Load(object sender, EventArgs e)
        {
            dto = new DTO_TONGHOP(mahd);
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1",bus.hienThiBill(dto));
            reportViewer1.LocalReport.ReportPath = @"C:\Users\HieuNhan\source\repos\quanLyNhaHangBuffer\quanLyNhaHangBuffer\bill.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
