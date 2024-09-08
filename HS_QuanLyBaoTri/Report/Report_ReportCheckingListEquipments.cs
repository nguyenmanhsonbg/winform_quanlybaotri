using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HS_QuanLyBaoTri.Report
{
    public partial class Report_ReportCheckingListEquipments : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_ReportCheckingListEquipments(int split, DateTime today, string iddept)
        {
            InitializeComponent();
            this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(this.dataSet_GetCheckListEquipments_Daily1.Data_Get_DailyCheckEquipments_Real, split, today, iddept);
        }

    }
}
