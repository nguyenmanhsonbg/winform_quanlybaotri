using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using Tulpep.NotificationWindow;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Reporting;

namespace HS_QuanLyBaoTri
{
    public partial class frmSchedule : DevExpress.XtraEditors.XtraForm
    {
        public frmSchedule()
        {
            InitializeComponent();
            schedulerControl1.GanttView.CellsAutoHeightOptions.Enabled = true;
        }
        bool _color = false;

        public void Load_Init()
        {
            this.resourcesTableAdapter.Fill(this._HS_QuanLyBaoTriDataSet.Resources);
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            schedulerControl1.Start = DateTime.Today.AddDays(-3);
            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            schedulerControl1.TimelineView.TimelineScrollBarVisible = true;
            //schedulerControl1.GanttView.DateTimeScrollbarVisible = true;
            schedulerControl1.DayView.TopRowTime = new TimeSpan(10, 0, 0);
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            schedulerControl1.DayView.ResourcesPerPage = 9;
            schedulerControl1.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;
            gridView1.IndicatorWidth = 40;
            _color = false;
            if (clsCommon.Common._suUser || clsCommon.Common._idDept == txtDept.EditValue.ToString())
            {
                this.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.All;
                this.schedulerControl1.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.All;
                this.schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.All;
                this.schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.All;
            }
            else
            {
                this.schedulerControl1.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
                this.schedulerControl1.OptionsCustomization.AllowAppointmentCopy = DevExpress.XtraScheduler.UsedAppointmentType.None;
                this.schedulerControl1.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None;
                this.schedulerControl1.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None;
            }
        }
        private void frmSchedule_Load(object sender, EventArgs e)
        {
            txtDept.EditValue = clsCommon.Common._idDept;
            dateNavigator1.EditValue = DateTime.Now;

            string _iddept = txtDept.EditValue.ToString();
            DateTime _Date = Convert.ToDateTime(dateNavigator1.EditValue.ToString());
            string datefrom = _Date.ToString("yyyy-MM-dd");
            string dateto = _Date.AddDays(1).ToString("yyyy-MM-dd");
            if (_iddept == "_0000")
            {
                this.appointmentsTableAdapter.Fill(this._HS_QuanLyBaoTriDataSet.Appointments);
            }
            else
            {
                //this.appointmentsTableAdapter.FillBy(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString());

                this.appointmentsTableAdapter.FillBy1(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString(), Convert.ToDateTime(datefrom), Convert.ToDateTime(dateto));
            }

            //this.appointmentsTableAdapter.Fill(this._HS_QuanLyBaoTriDataSet.Appointments);
            Load_Init();

            this.schedulerStorage1.AppointmentsChanged += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsInserted += OnAppointmentChangedInsertedDeleted;
            this.schedulerStorage1.AppointmentsDeleted += OnAppointmentChangedInsertedDeleted;

        }

        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(this._HS_QuanLyBaoTriDataSet);
            this._HS_QuanLyBaoTriDataSet.AcceptChanges();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            HS_QuanLyBaoTri.CustomAppointmentForm form = new HS_QuanLyBaoTri.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                form._Edit = true;
                e.DialogResult = form.ShowDialog();
                e.Handled = true;

            }
            finally
            {
                form.Dispose();
            }
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
            {
                this.appointmentsTableAdapter.Fill(this._HS_QuanLyBaoTriDataSet.Appointments);
            }
            else
            {
                this.appointmentsTableAdapter.FillBy(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString());
            }
            Load_Init();
        }

        private void txtDept_EditValueChanged(object sender, EventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            DateTime _Date = Convert.ToDateTime(dateNavigator1.EditValue.ToString());
            string datefrom = _Date.ToString("yyyy-MM-dd");
            string dateto = _Date.AddDays(1).ToString("yyyy-MM-dd");
            if (_iddept == "_0000")
            {
                this.appointmentsTableAdapter.Fill(this._HS_QuanLyBaoTriDataSet.Appointments);
            }
            else
            {
                //this.appointmentsTableAdapter.FillBy(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString());

                this.appointmentsTableAdapter.FillBy1(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString(), Convert.ToDateTime(datefrom), Convert.ToDateTime(dateto));
            }
            // Load_Init();
        }

        private void dateNavigator1_EditValueChanged(object sender, EventArgs e)
        {
            DateTime _Date = Convert.ToDateTime(dateNavigator1.EditValue.ToString());
            string _t = "[StartDate]>='" + _Date.ToString("dd/MM/yyyy HH:mm:ss") + "' AND [StartDate]<'" + _Date.AddDays(1).ToString("dd/MM/yyyy HH:mm:ss") + "'";
            gridView1.Columns["StartDate"].FilterInfo = new ColumnFilterInfo(_t);
            _color = false;
        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {
            SchedulerHitInfo hitInfo = schedulerControl1.ActiveView.ViewInfo.CalcHitInfo(schedulerControl1.PointToClient(Form.MousePosition), false);
            if (hitInfo.HitTest == SchedulerHitTest.AppointmentContent)
            {
                foreach (Appointment myAppt in schedulerControl1.SelectedAppointments)
                {
                    int rowHandle = gridView1.LocateByValue("IDAppointments", myAppt.CustomFields["IDAppointments"].ToString());
                    if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
                    {
                        _color = true;
                        gridView1.FocusedRowHandle = rowHandle;

                    }
                    else { _color = false; }
                }
            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (_color)
            {
                GridView view = sender as GridView;
                if (e.RowHandle == view.FocusedRowHandle)
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.ForeColor = Color.White;
                }
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnFresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            DateTime _Date = Convert.ToDateTime(dateNavigator1.EditValue.ToString());
            string datefrom = _Date.ToString("yyyy-MM-dd");
            string dateto = _Date.AddDays(1).ToString("yyyy-MM-dd");
            if (_iddept == "_0000")
            {
                this.appointmentsTableAdapter.Fill(this._HS_QuanLyBaoTriDataSet.Appointments);
            }
            else
            {
                //this.appointmentsTableAdapter.FillBy(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString());

                this.appointmentsTableAdapter.FillBy1(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString(), Convert.ToDateTime(datefrom), Convert.ToDateTime(dateto));
            }
            // Load_Init();
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int split = 0;
            DateTime _Date = Convert.ToDateTime(dateNavigator1.EditValue.ToString());
            string datefrom = _Date.AddDays(0).ToString("yyyy-MM-dd");
            string dateto = _Date.AddDays(0).ToString("yyyy-MM-dd");
            Report.Report_ReportScheadule _reReportScheadule = new Report.Report_ReportScheadule(split, txtDept.EditValue.ToString(), datefrom, dateto);
            new ReportPrintTool(_reReportScheadule).ShowPreview();
            _reReportScheadule.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, new object[] { true });
        }

        private void btnViewAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
            {
                this.appointmentsTableAdapter.Fill(this._HS_QuanLyBaoTriDataSet.Appointments);
            }
            else
            {
                this.appointmentsTableAdapter.FillBy(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString());

                //this.appointmentsTableAdapter.FillBy1(_HS_QuanLyBaoTriDataSet.Appointments, txtDept.EditValue.ToString(), Convert.ToDateTime(datefrom), Convert.ToDateTime(dateto));
            }
            Load_Init();
        }


    }
}
