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
using System.Data.SqlClient;
using DevExpress.XtraScheduler.Reporting;

namespace HS_QuanLyBaoTri
{
    public partial class frmSchedule_Big : DevExpress.XtraEditors.XtraForm
    {
        public frmSchedule_Big()
        {
            InitializeComponent();
        }

        void Load_Init()
        {
            schedulerControl1.Start = DateTime.Today.AddDays(-3);
            this.taskDependencies_bigTableAdapter.Fill(this._Schedule_Maintenance_Big.TaskDependencies_big);
            schedulerControl1.TimelineView.TimelineScrollBarVisible = true;
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
        private void txtDept_EditValueChanged(object sender, EventArgs e)
        {
            this.data_Get_VocherbyDeptTableAdapter.Fill(dataSet_Get_VocherByDept.Data_Get_VocherbyDept, txtDept.EditValue.ToString());
        }

        private void frmSchedule_Big_Load(object sender, EventArgs e)
        {
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            try
            {
                #region #AppointmentEvents
                schedulerStorage1.AppointmentsInserted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsInserted);
                schedulerStorage1.AppointmentsChanged += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsChanged);
                schedulerStorage1.AppointmentsDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentsDeleted);
                #endregion #AppointmentEvents
                #region #AppointmentDependencyEvents
                schedulerStorage1.AppointmentDependenciesInserted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesInserted);
                schedulerStorage1.AppointmentDependenciesChanged += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesChanged);
                schedulerStorage1.AppointmentDependenciesDeleted += new PersistentObjectsEventHandler(schedulerStorage1_AppointmentDependenciesDeleted);
                #endregion #AppointmentDependencyEvents
            }
            catch { ;}
            txtDept.EditValue = clsCommon.Common._idDept;
            txtVocher_ByDept.EditValue = "";
            this.data_Get_VocherbyDeptTableAdapter.Fill(dataSet_Get_VocherByDept.Data_Get_VocherbyDept, txtDept.EditValue.ToString());
            Load_Init();
            this.schedule_bigTableAdapter.Fill(_Schedule_Maintenance_Big.Schedule_big, txtDept.EditValue.ToString(), txtVocher_ByDept.EditValue.ToString());
            this.resources_schedulebigTableAdapter.Fill(_Schedule_Maintenance_Big.Resources_schedulebig, txtVocher_ByDept.EditValue.ToString(), txtDept.EditValue.ToString());

        }
        private void CommitTask()
        {
            schedule_bigTableAdapter.Update(this._Schedule_Maintenance_Big);
            this._Schedule_Maintenance_Big.AcceptChanges();
        }
        private void btnAddVocher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChild.frmThemPhieuBaoTri f_phieubaotri = new frmChild.frmThemPhieuBaoTri();
            f_phieubaotri._IDDept=txtDept.EditValue.ToString();
            f_phieubaotri._Vocher = "";
            f_phieubaotri.edit = false;
            f_phieubaotri.Show();

        }

        private void btnFresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Init();
            this.schedule_bigTableAdapter.Fill(_Schedule_Maintenance_Big.Schedule_big, txtDept.EditValue.ToString(), txtVocher_ByDept.EditValue.ToString());
            this.resources_schedulebigTableAdapter.Fill(_Schedule_Maintenance_Big.Resources_schedulebig, txtVocher_ByDept.EditValue.ToString(), txtDept.EditValue.ToString());
        }

        private void btnEditVocher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChild.frmThemPhieuBaoTri f_phieubaotri = new frmChild.frmThemPhieuBaoTri();
            f_phieubaotri._IDDept = txtDept.EditValue.ToString();
            f_phieubaotri._Vocher = txtVocher_ByDept.EditValue.ToString();
            f_phieubaotri.edit = true;
            f_phieubaotri.Show();
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            HS_QuanLyBaoTri.CustomAppointmentForm1 form = new HS_QuanLyBaoTri.CustomAppointmentForm1(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                form._IDDept = txtDept.EditValue.ToString();
                form._Vocher_Maintenance = txtVocher_ByDept.EditValue.ToString();
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            try
            {
                DataTable dt = this._Schedule_Maintenance_Big.Schedule_big.GetChanges();
                if (dt.Rows.Count > 0)
                {
                    DateTime StartDate = Convert.ToDateTime(dt.Rows[0]["StartDate"]);
                    DateTime EndDate = Convert.ToDateTime(dt.Rows[0]["EndDate"]);
                    double day = (EndDate - StartDate).TotalDays;
                    String _query = "Update [HS-QuanLyBaoTri].[dbo].[Resources_schedulebig] set PlanDays=Round(" + day.ToString() + ",1) where Id=" + dt.Rows[0]["ResourceId"];
                    clsCommon.Common.ExcuteQuery(_query);
                }
                CommitTask();
                this.resources_schedulebigTableAdapter.Fill(_Schedule_Maintenance_Big.Resources_schedulebig, txtVocher_ByDept.EditValue.ToString(), txtDept.EditValue.ToString());
            }
            catch { }
           
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
        }

        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTask();
            schedulerStorage1.SetAppointmentId(((Appointment)e.Objects[0]), id);
        }
        void CommitTaskDependency()
        {
            taskDependencies_bigTableAdapter.Update(this._Schedule_Maintenance_Big);
            this._Schedule_Maintenance_Big.AcceptChanges();
        }

        private void schedulerStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesDeleted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }

        private void schedulerStorage1_AppointmentDependenciesInserted(object sender, PersistentObjectsEventArgs e)
        {
            CommitTaskDependency();
        }
        #region #RowUpdatedHandlers
        int id = 0;
        private void schedule_bigTableAdapter_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                id = 0;
                using (SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", schedule_bigTableAdapter.Connection))
                {
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                    e.Row["UniqueId"] = id;
                }
            }
        }
        #endregion #RowUpdatedHandlers

        private void btnViewVocher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(string.IsNullOrEmpty(txtVocher_ByDept.EditValue.ToString()))
            {
                MessageBox.Show("Chưa chọn Phiếu Bảo Trì !!!");
                return;
            }
            frmChild.frmView_VatTuBaoTri f_view = new frmChild.frmView_VatTuBaoTri();
            f_view.vocher = txtVocher_ByDept.EditValue.ToString();
            f_view.Tittle = "VẬT TƯ CẦN CHO BẢO TRÌ THEO PHIẾU : " + txtVocher_ByDept.EditValue.ToString();
            f_view.Show();
        }


    }
}