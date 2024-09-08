using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HS_QuanLyBaoTri.Report
{
    public partial class Report_ReportScheadule : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_ReportScheadule(int split, string iddept, string datefrom, string dateto)
        {
            InitializeComponent();
           
           // this.data_Get_ReportScheaduleTableAdapter.Fill(this.SQL_ReportScheadule.Data_Get_ReportScheadule, split, iddept, datefrom, dateto);

            this.data_Get_ReportScheaduleTableAdapter.Fill(this.SQL_ReportScheadule.Data_Get_ReportScheadule, iddept, DateTime.Parse(datefrom), DateTime.Parse(dateto));
            if (this.SQL_ReportScheadule.Data_Get_ReportScheadule.Rows.Count <= 0)
                return; 
            //this.data_Get_ReportScheaduleTableAdapter.Fill(this.sqlDataSource1.Get_, iddept, datefrom, dateto);
            this.DataSource = this.SQL_ReportScheadule.Data_Get_ReportScheadule;
            //this.DataSource = this.sqlDataSource1.Get_ThongTinChoReport;
        }

    }
}
