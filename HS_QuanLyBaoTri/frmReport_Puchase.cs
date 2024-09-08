using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Data.OleDb;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;

namespace HS_QuanLyBaoTri
{
    public partial class frmReport_Puchase : DevExpress.XtraEditors.XtraForm
    {
        public frmReport_Puchase()
        {
            InitializeComponent();
        }
        public DataTable dt;
        public string Phongban;
        private void frmReport_Puchase_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            //this.dataGetReportLuanChuyenNEWBindingSource.DataSource = null;
            //this.reportViewer1.Reset();
            //this.reportViewer1.LocalReport.DataSources.Clear();
            var reportDataSource1 = new ReportDataSource("DataSetvt", dt);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HS_QuanLyBaoTri.Report.Report_Purcharse.rdlc";

            ReportParameter rp1 = new ReportParameter("ngay", DateTime.Now.ToString());
            reportViewer1.LocalReport.SetParameters(rp1);
            ReportParameter rp2 = new ReportParameter("phongban", Phongban);
            reportViewer1.LocalReport.SetParameters(rp2);

            this.reportViewer1.RefreshReport();
        }
    }
}