using System;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Utils.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.UI;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Native;
using DevExpress.Utils.Internal;
using System.Collections.Generic;
using DevExpress.XtraScheduler.Internal;
using System.Data;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;
using HS_QuanLyBaoTri.Models;

namespace HS_QuanLyBaoTri
{
    public partial class CustomAppointmentForm : DevExpress.XtraEditors.XtraForm, IDXManagerPopupMenu
    {
        #region Fields
        bool openRecurrenceForm;
        readonly ISchedulerStorage storage;
        readonly SchedulerControl control;
        Icon recurringIcon;
        Icon normalIcon;
        readonly AppointmentFormController controller;
        IDXMenuManager menuManager;
        #endregion
        public bool _Edit;
        bool _iSuccess = false;
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CustomAppointmentForm()
        {
            InitializeComponent();
        }
        public CustomAppointmentForm(SchedulerControl control, Appointment apt)
            : this(control, apt, false)
        {
        }
        public CustomAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm)
        {
            Guard.ArgumentNotNull(control, "control");
            Guard.ArgumentNotNull(control.Storage, "control.Storage");
            Guard.ArgumentNotNull(apt, "apt");

            this.openRecurrenceForm = openRecurrenceForm;
            this.controller = CreateController(control, apt);
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            SetupPredefinedConstraints();

            LoadIcons();

            this.control = control;
            this.storage = control.Storage;

            this.edtShowTimeAs.Storage = this.storage;
            this.edtLabel.Storage = storage;
            this.edtResource.SchedulerControl = control;
            this.edtResource.Storage = storage;
            this.edtResources.SchedulerControl = control;

            SubscribeControllerEvents(Controller);
            SubscribeEditorsEvents();
            BindControllerToControls();

        }
        #region Properties
        protected override FormShowMode ShowMode { get { return DevExpress.XtraEditors.FormShowMode.AfterInitialization; } }
        public IDXMenuManager MenuManager { get { return menuManager; } private set { menuManager = value; } }
        protected internal AppointmentFormController Controller { get { return controller; } }
        protected internal SchedulerControl Control { get { return control; } }
        protected internal ISchedulerStorage Storage { get { return storage; } }
        protected internal bool IsNewAppointment { get { return controller != null ? controller.IsNewAppointment : true; } }
        protected internal Icon RecurringIcon { get { return recurringIcon; } }
        protected internal Icon NormalIcon { get { return normalIcon; } }
        protected internal bool OpenRecurrenceForm { get { return openRecurrenceForm; } }
        public bool ReadOnly
        {
            get { return Controller != null && Controller.ReadOnly; }
            set
            {
                if (Controller.ReadOnly == value)
                    return;
                Controller.ReadOnly = value;
            }
        }
        #endregion
        string _IDEquipment;
        string _IDDept;
        string _Priority;
        string _Human;
        string _Person;
        string _Songaybaotri;
        string _TinhtrangTB;
        public string _UniqueID;
        public virtual void LoadFormData(Appointment appointment)
        {
            var value = appointment.CustomFields["Performance_Person"];
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            if (_Edit)
            {
                btnOk.Enabled = true;
            }
            else { btnOk.Enabled = false; }
            if (appointment.CustomFields["IDEquipments"] == null)
                txtThietBi.Text = "";
            else
            {
                _IDEquipment = appointment.CustomFields["IDEquipments"].ToString();
                txtThietBi.EditValue = _IDEquipment;
            }
            if (appointment.CustomFields["IDDept"] == null)
                txtDept.EditValue = clsCommon.Common._idDept;
            else
            {
                _IDDept = appointment.CustomFields["IDDept"].ToString();
                txtDept.EditValue = _IDDept;
            }
            if (appointment.CustomFields["Priority"] == null)
                txtPriority.Text = "";
            else
            {
                _Priority = appointment.CustomFields["Priority"].ToString();
                txtPriority.EditValue = _Priority;
            }
            if (appointment.CustomFields["PerformanceHuman"] == null)
                txtHuman.Text = "";
            else
            {
                _Human = appointment.CustomFields["PerformanceHuman"].ToString();
                txtHuman.EditValue = _Human;
            }
            if (appointment.CustomFields["PerformancePerson"] == null)
            {
                txtPerson.EditValue = "";
                _Person = "";
            }
            else
            {
                _Person = appointment.CustomFields["PerformancePerson"].ToString();
                txtPerson.EditValue = _Person;
            }
            if (appointment.CustomFields["SoNgayBaoTri"] == null)
                txt_Soluong.Text = "";
            else
            {
                _Songaybaotri = appointment.CustomFields["SoNgayBaoTri"].ToString();
                txt_Soluong.EditValue = _Songaybaotri;
            }
            if (appointment.CustomFields["TinhTrangThietBi"] == null)
                txtTinhTrangTB.Text = "";
            else
            {
                _TinhtrangTB = appointment.CustomFields["TinhTrangThietBi"].ToString();
                txtTinhTrangTB.EditValue = _TinhtrangTB;
            }
            if (appointment.CustomFields["IDAppointments"] == null)
                _UniqueID = "";
            else
            {
                _UniqueID = appointment.CustomFields["IDAppointments"].ToString();
                this.data_Get_VatTuCanBaoTriTableAdapter.Fill(dataSet_Get_VatTuBaoTri.Data_Get_VatTuCanBaoTri, _UniqueID, false);
            }

        }
        public virtual bool SaveFormData(Appointment appointment)
        {
            appointment.CustomFields["IDEquipments"] = txtThietBi.EditValue.ToString();
            appointment.CustomFields["IDDept"] = txtDept.EditValue.ToString();
            appointment.CustomFields["Priority"] = txtPriority.EditValue.ToString();
            appointment.CustomFields["PerformanceHuman"] = txtHuman.EditValue.ToString();
            appointment.CustomFields["PerformancePerson"] = txtPerson.EditValue.ToString();
            appointment.CustomFields["SoNgayBaoTri"] = txt_Soluong.EditValue.ToString();
            appointment.CustomFields["TinhTrangThietBi"] = txtTinhTrangTB.EditValue.ToString();
            //MessageBox.Show(appointment.CustomFields["IDAppointments"].ToString());
            return true;
        }
        public virtual bool SaveFromERP(Appointment appointment)
        {
            _UniqueID = appointment.CustomFields["UniqueID"].ToString();
            MessageBox.Show(_UniqueID);
            return true;
        }
        public virtual bool IsAppointmentChanged(Appointment appointment)
        {
            if (_IDEquipment == appointment.CustomFields["IDEquipments"].ToString()
                && _IDDept == appointment.CustomFields["IDDept"].ToString()
                && _Priority == appointment.CustomFields["Priority"].ToString()
                && _Human == appointment.CustomFields["PerformanceHuman"].ToString()
                && _Songaybaotri == appointment.CustomFields["SoNgayBaoTri"].ToString()
                && _Person == appointment.CustomFields["PerformancePerson"].ToString()
                && _TinhtrangTB == appointment.CustomFields["TinhTrangThietBi"].ToString())

                return false;
            else
                return true;
        }
        public virtual void SetMenuManager(DevExpress.Utils.Menu.IDXMenuManager menuManager)
        {
            MenuManagerUtils.SetMenuManager(Controls, menuManager);
            this.menuManager = menuManager;
        }

        protected internal virtual void SetupPredefinedConstraints()
        {

            this.edtResources.Visible = true;
        }
        protected virtual void BindControllerToControls()
        {
            BindControllerToIcon();
            BindProperties(this.tbSubject, "Text", "Subject");
            BindProperties(this.tbLocation, "Text", "Location");
            BindProperties(this.tbDescription, "Text", "Description");
            BindProperties(this.edtShowTimeAs, "Status", "Status");
            BindProperties(this.edtStartDate, "EditValue", "DisplayStartDate");
            BindProperties(this.edtStartDate, "Enabled", "IsDateTimeEditable");
            BindProperties(this.edtStartTime, "EditValue", "DisplayStartTime");
            BindProperties(this.edtStartTime, "Visible", "IsTimeVisible");
            BindProperties(this.edtStartTime, "Enabled", "IsTimeVisible");
            BindProperties(this.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "Visible", "IsTimeVisible", DataSourceUpdateMode.Never);
            BindProperties(this.edtEndTime, "Enabled", "IsTimeVisible", DataSourceUpdateMode.Never);
            BindProperties(this.chkAllDay, "Checked", "AllDay");
            BindProperties(this.chkAllDay, "Enabled", "IsDateTimeEditable");

            BindProperties(this.edtResource, "ResourceId", "ResourceId");
            BindProperties(this.edtResource, "Enabled", "CanEditResource");
            BindToBoolPropertyAndInvert(this.edtResource, "Visible", "ResourceSharing");

            BindProperties(this.edtResources, "ResourceIds", "ResourceIds");
            BindProperties(this.edtResources, "Visible", "ResourceSharing");
            BindProperties(this.edtResources, "Enabled", "CanEditResource");
            BindProperties(this.lblResource, "Enabled", "CanEditResource");

            BindProperties(this.edtLabel, "Label", "Label");
            BindProperties(this.chkReminder, "Enabled", "ReminderVisible");
            BindProperties(this.chkReminder, "Visible", "ReminderVisible");
            BindProperties(this.chkReminder, "Checked", "HasReminder");
            BindProperties(this.cbReminder, "Enabled", "HasReminder");
            BindProperties(this.cbReminder, "Visible", "ReminderVisible");
            BindProperties(this.cbReminder, "Duration", "ReminderTimeBeforeStart");


            BindToBoolPropertyAndInvert(this.btnOk, "Enabled", "ReadOnly");
            BindToBoolPropertyAndInvert(this.btnRecurrence, "Enabled", "ReadOnly");
            BindProperties(this.btnDelete, "Enabled", "CanDeleteAppointment");
            BindProperties(this.btnRecurrence, "Visible", "ShouldShowRecurrenceButton");
        }
        protected virtual void BindControllerToIcon()
        {
            Binding binding = new Binding("Icon", Controller, "AppointmentType");
            binding.Format += AppointmentTypeToIconConverter;
            DataBindings.Add(binding);
        }
        protected virtual void ObjectToStringConverter(object o, ConvertEventArgs e)
        {
            e.Value = e.Value.ToString();
        }
        protected virtual void AppointmentTypeToIconConverter(object o, ConvertEventArgs e)
        {
            AppointmentType type = (AppointmentType)e.Value;
            if (type == AppointmentType.Pattern)
                e.Value = RecurringIcon;
            else
                e.Value = NormalIcon;
        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty)
        {
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged);
        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty, DataSourceUpdateMode updateMode)
        {
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, true, updateMode);
        }
        protected virtual void BindProperties(Control target, string targetProperty, string sourceProperty, ConvertEventHandler objectToStringConverter)
        {
            Binding binding = new Binding(targetProperty, Controller, sourceProperty, true);
            binding.Format += objectToStringConverter;
            target.DataBindings.Add(binding);
        }
        protected virtual void BindToBoolPropertyAndInvert(Control target, string targetProperty, string sourceProperty)
        {
            target.DataBindings.Add(new BoolInvertBinding(targetProperty, Controller, sourceProperty));
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Controller == null)
                return;
            this.DataBindings.Add("Text", Controller, "Caption");
            SubscribeControlsEvents();
            LoadFormData(Controller.EditedAppointmentCopy);
            RecalculateLayoutOfControlsAffectedByProgressPanel();
        }
        protected virtual AppointmentFormController CreateController(SchedulerControl control, Appointment apt)
        {
            return new AppointmentFormController(control, apt);
        }
        void SubscribeEditorsEvents()
        {
            this.cbReminder.EditValueChanging += OnCbReminderEditValueChanging;
        }
        void SubscribeControllerEvents(AppointmentFormController controller)
        {
            if (controller == null)
                return;
            controller.PropertyChanged += OnControllerPropertyChanged;
        }
        void OnControllerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadOnly")
                UpdateReadonly();
        }
        protected virtual void UpdateReadonly()
        {
            if (Controller == null)
                return;
            IList<Control> controls = GetAllControls(this);
            foreach (Control control in controls)
            {
                BaseEdit editor = control as BaseEdit;
                if (editor == null)
                    continue;
                editor.ReadOnly = Controller.ReadOnly;
            }
            this.btnOk.Enabled = !Controller.ReadOnly;
            this.btnRecurrence.Enabled = !Controller.ReadOnly;
        }

        List<Control> GetAllControls(Control rootControl)
        {
            List<Control> result = new List<Control>();
            foreach (Control control in rootControl.Controls)
            {
                result.Add(control);
                IList<Control> childControls = GetAllControls(control);
                result.AddRange(childControls);
            }
            return result;
        }
        protected internal virtual void LoadIcons()
        {
            Assembly asm = typeof(SchedulerControl).Assembly;
            recurringIcon = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.RecurringAppointment, asm);
            normalIcon = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.Appointment, asm);
        }
        protected internal virtual void SubscribeControlsEvents()
        {
            this.edtEndDate.Validating += new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating += new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.cbReminder.InvalidValue += new InvalidValueExceptionEventHandler(OnCbReminderInvalidValue);
            this.cbReminder.Validating += new CancelEventHandler(OnCbReminderValidating);
            this.edtStartDate.Validating += new CancelEventHandler(OnEdtStartDateValidating);
            this.edtStartDate.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartDateInvalidValue);
            this.edtStartTime.Validating += new CancelEventHandler(OnEdtStartTimeValidating);
            this.edtStartTime.InvalidValue += new InvalidValueExceptionEventHandler(OnEdtStartTimeInvalidValue);
        }
        protected internal virtual void UnsubscribeControlsEvents()
        {
            this.edtEndDate.Validating -= new CancelEventHandler(OnEdtEndDateValidating);
            this.edtEndDate.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndDateInvalidValue);
            this.edtEndTime.Validating -= new CancelEventHandler(OnEdtEndTimeValidating);
            this.edtEndTime.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtEndTimeInvalidValue);
            this.cbReminder.InvalidValue -= new InvalidValueExceptionEventHandler(OnCbReminderInvalidValue);
            this.cbReminder.Validating -= new CancelEventHandler(OnCbReminderValidating);
            this.edtStartDate.Validating -= new CancelEventHandler(OnEdtStartDateValidating);
            this.edtStartDate.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtStartDateInvalidValue);
            this.edtStartTime.Validating -= new CancelEventHandler(OnEdtStartTimeValidating);
            this.edtStartTime.InvalidValue -= new InvalidValueExceptionEventHandler(OnEdtStartTimeInvalidValue);
        }
        void OnBtnOkClick(object sender, System.EventArgs e)
        {
            OnOkButton();

        }
        protected internal virtual void OnEdtStartTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtStartTimeValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnEdtStartDateInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtStartDateValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnEdtEndDateValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndDate.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndDateInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            if (!AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay))
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual void OnEdtEndTimeValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = !IsValidInterval();
            if (!e.Cancel)
                this.edtEndTime.DataBindings["EditValue"].WriteValue();
        }
        protected internal virtual void OnEdtEndTimeInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            if (!AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay))
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate);
            else
                e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_DateOutsideLimitInterval);
        }
        protected internal virtual bool IsValidInterval()
        {
            return AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay) &&
                Controller.ValidateLimitInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay);
        }
        protected internal virtual void OnOkButton()
        {
            if (!ValidateDateAndTime())
                return;
            if (!SaveFormData(Controller.EditedAppointmentCopy))
                return;
            if (!Controller.IsConflictResolved())
            {
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Controller.GetMessageBoxCaption(SchedulerStringId.Msg_Conflict), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Controller.IsAppointmentChanged() || Controller.IsNewAppointment || IsAppointmentChanged(Controller.EditedAppointmentCopy))
            {
                Controller.ApplyChanges();
                gridControl1.Enabled = true;
            }
            this.DialogResult = DialogResult.OK;

        }
        private bool ValidateDateAndTime()
        {
            this.edtEndDate.DoValidate();
            this.edtEndTime.DoValidate();
            this.edtStartDate.DoValidate();
            this.edtStartTime.DoValidate();

            return String.IsNullOrEmpty(this.edtEndTime.ErrorText) && String.IsNullOrEmpty(this.edtEndDate.ErrorText) && String.IsNullOrEmpty(this.edtStartDate.ErrorText) && String.IsNullOrEmpty(this.edtStartTime.ErrorText);
        }
        protected internal virtual DialogResult ShowMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return XtraMessageBox.Show(this, text, caption, buttons, icon);
        }
        void OnBtnDeleteClick(object sender, System.EventArgs e)
        {
            OnDeleteButton();
        }
        protected internal virtual void OnDeleteButton()
        {
            if (IsNewAppointment)
                return;

            Controller.DeleteAppointment();
            DialogResult = DialogResult.Abort;
            Close();
        }
        void OnBtnRecurrenceClick(object sender, System.EventArgs e)
        {
            OnRecurrenceButton();
        }
        protected internal virtual void OnRecurrenceButton()
        {
            if (!Controller.ShouldShowRecurrenceButton)
                return;

            Appointment patternCopy = Controller.PrepareToRecurrenceEdit();

            DialogResult result;
            using (Form form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek))
            {
                result = ShowRecurrenceForm(form);
            }

            if (result == DialogResult.Abort)
            {
                Controller.RemoveRecurrence();
            }
            else if (result == DialogResult.OK)
            {
                Controller.ApplyRecurrence(patternCopy);
            }
        }
        protected virtual DialogResult ShowRecurrenceForm(Form form)
        {
            return FormTouchUIAdapter.ShowDialog(form, this);
        }
        protected internal virtual Form CreateAppointmentRecurrenceForm(Appointment patternCopy, FirstDayOfWeek firstDayOfWeek)
        {
            AppointmentRecurrenceForm form = new AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller);
            form.SetMenuManager(MenuManager);
            form.LookAndFeel.ParentLookAndFeel = LookAndFeel;
            form.ShowExceptionsRemoveMsgBox = controller.AreExceptionsPresent();
            return form;
        }
        internal void OnAppointmentFormActivated(object sender, EventArgs e)
        {
            if (openRecurrenceForm)
            {
                openRecurrenceForm = false;
                OnRecurrenceButton();
            }
        }
        protected internal virtual void OnCbReminderValidating(object sender, CancelEventArgs e)
        {
            TimeSpan span = cbReminder.Duration;
            e.Cancel = (span == TimeSpan.MinValue) || (span.Ticks < 0);
            if (!e.Cancel)
                this.cbReminder.DataBindings["Duration"].WriteValue();
        }
        protected internal virtual void OnCbReminderInvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidReminderTimeBeforeStart);
        }
        protected internal virtual void RecalculateLayoutOfControlsAffectedByProgressPanel()
        {

        }
        void OnCbReminderEditValueChanging(object sender, ChangingEventArgs e)
        {
            if (e.NewValue is TimeSpan)
                return;
            string stringValue = e.NewValue as String;
            TimeSpan duration = HumanReadableTimeSpanHelper.Parse(stringValue);
            if (duration.Ticks < 0)
                e.NewValue = TimeSpan.FromTicks(0);
        }

        private void CustomAppointmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Get_TonKho.Data_Get_TonKho' table. You can move, or remove it, as needed.
            this.data_Get_TonKhoTableAdapter.Fill(this.dataSet_Get_TonKho.Data_Get_TonKho);
            // TODO: This line of code loads data into the 'dataSet_Get_Priority.Data_Get_Priority' table. You can move, or remove it, as needed.
            this.data_Get_PriorityTableAdapter.Fill(this.dataSet_Get_Priority.Data_Get_Priority);
            // TODO: This line of code loads data into the 'dataSet_Get_Location.Data_Get_Location' table. You can move, or remove it, as needed.
            this.data_Get_LocationTableAdapter.Fill(this.dataSet_Get_Location.Data_Get_Location);
            // TODO: This line of code loads data into the 'dataSet_Get_Equipments.Data_Get_Equipments' table. You can move, or remove it, as needed.
            this.data_Get_EquipmentsTableAdapter.Fill(this.dataSet_Get_Equipments.Data_Get_Equipments);
            txtDept.EditValue = clsCommon.Common._idDept;
            if (Controller.IsNewAppointment)
                gridControl1.Enabled = false;
            else
                gridControl1.Enabled = true;
        }

        private void repositoryItemSearchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            string _query = "Select [ERP_NAME],[QUANTITY],[STOCK_TPM] FROM [appStock_TPM].[dbo].[LIST_EQUIPMENT] where ID='" + gridView3.ActiveEditor.EditValue.ToString() + "'";
            DataTable dt = Common.SQLReadDatabaseClient(_query);
            if (dt.Rows.Count > 0)
            {
                gridView3.SetFocusedRowCellValue(colID, gridView3.ActiveEditor.EditValue.ToString());
                gridView3.SetFocusedRowCellValue(colERP_NAME, dt.Rows[0]["ERP_NAME"]);
                gridView3.SetFocusedRowCellValue(colTenKho, dt.Rows[0]["STOCK_TPM"]);
                colSLTonKho.OptionsColumn.ReadOnly = false;
                gridView3.SetFocusedRowCellValue(colSLTonKho, dt.Rows[0]["QUANTITY"]);
                colSLTonKho.OptionsColumn.ReadOnly = true;
            }
        }

        private void gridView3_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            gridView3.CloseEditor();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_VatTuCanBaoTri";
                cmd.Parameters.AddWithValue("@IDVT", gridView3.GetFocusedRowCellValue(colIDVT));
                cmd.Parameters.AddWithValue("@IDAppointments", _UniqueID);
                cmd.Parameters.AddWithValue("@ID", gridView3.GetFocusedRowCellValue(colID));
                cmd.Parameters.AddWithValue("@SLTonKho", gridView3.GetFocusedRowCellValue(colSLTonKho));
                cmd.Parameters.AddWithValue("@SLXuat", gridView3.GetFocusedRowCellValue(colSLXuat));
                cmd.Parameters.AddWithValue("@SLTra", gridView3.GetFocusedRowCellValue(colSLTra));
                cmd.Parameters.AddWithValue("@Status", 0);
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ccon;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Message_Save_Delete_VatTuBaoTri";
                    cmd.Parameters.AddWithValue("@ID", gridView3.GetFocusedRowCellDisplayText(colIDVT));
                    ccon.Open();
                    cmd.ExecuteNonQuery();
                    ccon.Close();
                    XtraMessageBox.Show("Đã xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView3.DeleteRow(gridView3.FocusedRowHandle);
                }
                catch { }
            }
        }

        private void txtDept_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Lấy ra danh sách tất cả các location
                List<LocationModel> lst = LocationModel.ConvertBindingSourceToLocationList(dataGetLocationBindingSource);
                //Lọc dữ liệu
                List<LocationModel> locationGroup = lst.FindAll(item => item.Department == txtDept.Text.Trim());
                tbLocation.Properties.DataSource = locationGroup;

                //Lấy ra danh sách tất cả các location
                List<EquipmentModel> lstEquipment = EquipmentModel.ConvertBindingSourceToEquipmentList(dataGetEquipmentsBindingSource);
                //Lọc dữ liệu
                List<EquipmentModel> equipmentGroup = lstEquipment.FindAll(item => item.Department == txtDept.Text.Trim());
                txtThietBi.Properties.DataSource = equipmentGroup;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void tbLocation_EditValueChanged(object sender, EventArgs e)
        {
            string[] cutLocation = tbLocation.Text.Split('_');
            //Lấy ra danh sách tất cả các location
            List<EquipmentModel> lstEquipment = EquipmentModel.ConvertBindingSourceToEquipmentList(dataGetEquipmentsBindingSource);
            //Lọc dữ liệu
            List<EquipmentModel> equipmentGroup = lstEquipment.FindAll(item => item.GroupEquipments.Trim() == cutLocation[0].Trim() && item.Department == txtDept.Text.Trim()); //&& item.GroupEquipments == 
            txtThietBi.Properties.DataSource = equipmentGroup;
        }








    }
}