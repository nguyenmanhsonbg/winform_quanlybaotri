using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Microsoft.Reporting.WinForms;

namespace HS_QuanLyBaoTri.Report
{
    public partial class frmReportISO : DevExpress.XtraEditors.XtraForm
    {
        public frmReportISO()
        {
            InitializeComponent();
        }
        public int _split;
        public string _daychuyen;
        public string _iddept;
        public DateTime _day;
        private void frmReportISO_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Reset();
            this.reportViewer1.LocalReport.DataSources.Clear();

            if(_split==1)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "HS_QuanLyBaoTri.Report.Report1.rdlc";

                this.data_Get_BaoTriISOTableAdapter.Fill(dataSet_Get_BaoTriISO.Data_Get_BaoTriISO, _iddept);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetReportISO", this.dataGetBaoTriISOBindingSource);
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            if (_split == 2)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "HS_QuanLyBaoTri.Report.Report_Thang.rdlc";
                this.data_Get_BaoTriThangISOTableAdapter.Fill(dataSet_Get_BaoTriThangISO.Data_Get_BaoTriThangISO, _iddept,_day);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetReportISO", this.dataGetBaoTriThangISOBindingSource);
                reportViewer1.LocalReport.DataSources.Add(rds);
                ReportParameter rp2 = new ReportParameter("Thangnam", _day.ToString("MM/yyyy"));
                reportViewer1.LocalReport.SetParameters(rp2);
            }
            if (_split == 3)
            {
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "HS_QuanLyBaoTri.Report.Report_Nam.rdlc";
                this.data_Get_BaoTriNamISOTableAdapter.Fill(dataSet_Get_BaoTriNamISO.Data_Get_BaoTriNamISO, _iddept,_day.Year);
                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetReportISO", this.dataGetBaoTriNamISOBindingSource);
                reportViewer1.LocalReport.DataSources.Add(rds);
                ReportParameter rp2 = new ReportParameter("Nam", _day.ToString("yyyy"));
                reportViewer1.LocalReport.SetParameters(rp2);
            }
            ReportParameter rp1 = new ReportParameter("daychuyen", _daychuyen);
            reportViewer1.LocalReport.SetParameters(rp1);
            this.reportViewer1.RefreshReport();

        }
    }
}