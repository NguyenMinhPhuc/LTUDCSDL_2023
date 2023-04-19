using Microsoft.Reporting.WinForms;
using Pro_QuanLyBanHang2023.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_QuanLyBanHang2023.Reports
{
    public partial class Frm_HienThiReport : Form
    {
        public Frm_HienThiReport()
        {
            InitializeComponent();
        }
        DataTable dt_InPhieuNhap;
        BLL_PhieuNhap bd;
        string err = string.Empty;
        public string maPhieuNhap = string.Empty;
        private void Frm_HienThiReport_Load(object sender, EventArgs e)
        {
            bd = new BLL_PhieuNhap();
            //Lay dũ liệu
            dt_InPhieuNhap = new DataTable();
            dt_InPhieuNhap = bd.LayThongTinInPhieuNhap(ref err, maPhieuNhap);

            //reset report view
            reportViewer2.Reset();
            //Gan rdlc vao cho report view 

            //duong dan tuyet doi
            //reportViewer2.LocalReport.ReportPath = @"D:\Projects\HocTap\ProgrammingC#\pro2023\LTUDCSDL_2023\Pro_QuanLyBanHang2023\Pro_QuanLyBanHang2023\NhapHang\rpt_InPhieuNhap.rdlc";

            //duong dan tuong doi
            reportViewer2.LocalReport.ReportEmbeddedResource = "Pro_QuanLyBanHang2023.NhapHang.rpt_InPhieuNhap.rdlc";

            //lam sach khung report
            reportViewer2.LocalReport.DataSources.Clear();
            //gan resource moi cho report view
            ReportDataSource reportDataSource = new ReportDataSource("DS_InPhieuNhap", dt_InPhieuNhap);
            reportViewer2.LocalReport.DataSources.Add(reportDataSource);

        
            this.reportViewer2.RefreshReport();
        }
    }
}
