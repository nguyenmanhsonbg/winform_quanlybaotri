using DevExpress.XtraScheduler.UI;
namespace HS_QuanLyBaoTri
{
    partial class CustomAppointmentForm
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAppointmentForm));
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.lblLabel = new DevExpress.XtraEditors.LabelControl();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.chkAllDay = new DevExpress.XtraEditors.CheckEdit();
            this.lblShowTimeAs = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRecurrence = new DevExpress.XtraEditors.SimpleButton();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.chkReminder = new DevExpress.XtraEditors.CheckEdit();
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblResource = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.edtResource = new DevExpress.XtraScheduler.UI.AppointmentResourceEdit();
            this.edtResources = new DevExpress.XtraScheduler.UI.AppointmentResourcesEdit();
            this.cbReminder = new DevExpress.XtraScheduler.UI.DurationEdit();
            this.edtLabel = new DevExpress.XtraScheduler.UI.AppointmentLabelEdit();
            this.edtStartTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.edtEndTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.edtShowTimeAs = new DevExpress.XtraScheduler.UI.AppointmentStatusEdit();
            this.txtThietBi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dataGetEquipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Equipments = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Equipments();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescribes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.data_Get_EquipmentsTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_EquipmentsTableAdapters.Data_Get_EquipmentsTableAdapter();
            this.dataGetLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Location = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Location();
            this.data_Get_LocationTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_LocationTableAdapters.Data_Get_LocationTableAdapter();
            this.txtDept = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dataGetDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dept = new HS_QuanLyBaoTri.DataSet.DataSet_Dept();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_DeptTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGetVatTuCanBaoTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_VatTuBaoTri = new HS_QuanLyBaoTri.DataSet.DataSet_Get_VatTuBaoTri();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.dataGetTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_TonKho = new HS_QuanLyBaoTri.DataSet.DataSet_Get_TonKho();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colERPCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVatTu_Old = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuyCachVatTu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVE_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_IMPORT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_UPDATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSYS_DATETIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colERP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colSLXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhtrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPriority = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dataGetPriorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Priority = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Priority();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_PriorityTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_PriorityTableAdapters.Data_Get_PriorityTableAdapter();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHuman = new DevExpress.XtraEditors.MemoEdit();
            this.data_Get_VatTuCanBaoTriTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_VatTuBaoTriTableAdapters.Data_Get_VatTuCanBaoTriTableAdapter();
            this.data_Get_TonKhoTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_TonKhoTableAdapters.Data_Get_TonKhoTableAdapter();
            this.tbSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtPerson = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Soluong = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTinhTrangTB = new DevExpress.XtraEditors.MemoEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbLocation = new DevExpress.XtraEditors.SearchLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThietBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetEquipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Equipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetVatTuCanBaoTriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_VatTuBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetTonKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_TonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPriorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHuman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Soluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrangTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // lblSubject
            // 
            resources.ApplyResources(this.lblSubject, "lblSubject");
            this.lblSubject.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblSubject.Appearance.Font")));
            this.lblSubject.Name = "lblSubject";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblLocation.Appearance.Font")));
            this.lblLocation.Name = "lblLocation";
            // 
            // lblLabel
            // 
            resources.ApplyResources(this.lblLabel, "lblLabel");
            this.lblLabel.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblLabel.Appearance.BackColor")));
            this.lblLabel.Name = "lblLabel";
            // 
            // lblStartTime
            // 
            resources.ApplyResources(this.lblStartTime, "lblStartTime");
            this.lblStartTime.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblStartTime.Appearance.Font")));
            this.lblStartTime.Name = "lblStartTime";
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.lblEndTime.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblEndTime.Appearance.Font")));
            this.lblEndTime.Name = "lblEndTime";
            // 
            // chkAllDay
            // 
            resources.ApplyResources(this.chkAllDay, "chkAllDay");
            this.chkAllDay.Name = "chkAllDay";
            this.chkAllDay.Properties.AccessibleName = resources.GetString("chkAllDay.Properties.AccessibleName");
            this.chkAllDay.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkAllDay.Properties.AutoWidth = true;
            this.chkAllDay.Properties.Caption = resources.GetString("chkAllDay.Properties.Caption");
            // 
            // lblShowTimeAs
            // 
            resources.ApplyResources(this.lblShowTimeAs, "lblShowTimeAs");
            this.lblShowTimeAs.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblShowTimeAs.Appearance.Font")));
            this.lblShowTimeAs.Name = "lblShowTimeAs";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.Click += new System.EventHandler(this.OnBtnOkClick);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Name = "btnCancel";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.CausesValidation = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.OnBtnDeleteClick);
            // 
            // btnRecurrence
            // 
            resources.ApplyResources(this.btnRecurrence, "btnRecurrence");
            this.btnRecurrence.Name = "btnRecurrence";
            this.btnRecurrence.Click += new System.EventHandler(this.OnBtnRecurrenceClick);
            // 
            // edtStartDate
            // 
            resources.ApplyResources(this.edtStartDate, "edtStartDate");
            this.edtStartDate.Name = "edtStartDate";
            this.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName");
            this.edtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtStartDate.Properties.Buttons"))))});
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // edtEndDate
            // 
            resources.ApplyResources(this.edtEndDate, "edtEndDate");
            this.edtEndDate.Name = "edtEndDate";
            this.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName");
            this.edtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtEndDate.Properties.Buttons"))))});
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Properties.MaxValue = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            // 
            // chkReminder
            // 
            resources.ApplyResources(this.chkReminder, "chkReminder");
            this.chkReminder.Name = "chkReminder";
            this.chkReminder.Properties.AutoWidth = true;
            this.chkReminder.Properties.Caption = resources.GetString("chkReminder.Properties.Caption");
            // 
            // tbDescription
            // 
            resources.ApplyResources(this.tbDescription, "tbDescription");
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName");
            this.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            // 
            // lblResource
            // 
            resources.ApplyResources(this.lblResource, "lblResource");
            this.lblResource.Name = "lblResource";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panel1.Controls.Add(this.edtResource);
            this.panel1.Controls.Add(this.lblLabel);
            this.panel1.Controls.Add(this.lblResource);
            this.panel1.Controls.Add(this.edtResources);
            this.panel1.Controls.Add(this.cbReminder);
            this.panel1.Controls.Add(this.chkAllDay);
            this.panel1.Controls.Add(this.edtLabel);
            this.panel1.Controls.Add(this.chkReminder);
            this.panel1.Name = "panel1";
            // 
            // edtResource
            // 
            resources.ApplyResources(this.edtResource, "edtResource");
            this.edtResource.Name = "edtResource";
            this.edtResource.Properties.AccessibleName = resources.GetString("edtResource.Properties.AccessibleName");
            this.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtResource.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtResource.Properties.Buttons"))))});
            // 
            // edtResources
            // 
            resources.ApplyResources(this.edtResources, "edtResources");
            this.edtResources.Name = "edtResources";
            this.edtResources.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtResources.Properties.Buttons"))))});
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.Location = ((System.Drawing.Point)(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Location")));
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = ((int)(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.TabIndex")));
            // 
            // cbReminder
            // 
            resources.ApplyResources(this.cbReminder, "cbReminder");
            this.cbReminder.Name = "cbReminder";
            this.cbReminder.Properties.AccessibleName = resources.GetString("cbReminder.Properties.AccessibleName");
            this.cbReminder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbReminder.Properties.Buttons"))))});
            this.cbReminder.Properties.DisabledStateText = "";
            this.cbReminder.Properties.ShowEmptyItem = false;
            // 
            // edtLabel
            // 
            resources.ApplyResources(this.edtLabel, "edtLabel");
            this.edtLabel.Name = "edtLabel";
            this.edtLabel.Properties.AccessibleName = resources.GetString("edtLabel.Properties.AccessibleName");
            this.edtLabel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtLabel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtLabel.Properties.Buttons"))))});
            // 
            // edtStartTime
            // 
            resources.ApplyResources(this.edtStartTime, "edtStartTime");
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName");
            this.edtStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // edtEndTime
            // 
            resources.ApplyResources(this.edtEndTime, "edtEndTime");
            this.edtEndTime.Name = "edtEndTime";
            this.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName");
            this.edtEndTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // edtShowTimeAs
            // 
            resources.ApplyResources(this.edtShowTimeAs, "edtShowTimeAs");
            this.edtShowTimeAs.Name = "edtShowTimeAs";
            this.edtShowTimeAs.Properties.AccessibleName = resources.GetString("edtShowTimeAs.Properties.AccessibleName");
            this.edtShowTimeAs.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.edtShowTimeAs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("edtShowTimeAs.Properties.Buttons"))))});
            // 
            // txtThietBi
            // 
            resources.ApplyResources(this.txtThietBi, "txtThietBi");
            this.txtThietBi.Name = "txtThietBi";
            this.txtThietBi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtThietBi.Properties.Buttons"))))});
            this.txtThietBi.Properties.DataSource = this.dataGetEquipmentsBindingSource;
            this.txtThietBi.Properties.DisplayMember = "Equipments";
            this.txtThietBi.Properties.NullText = resources.GetString("txtThietBi.Properties.NullText");
            this.txtThietBi.Properties.ValueMember = "IDEquipments";
            this.txtThietBi.Properties.View = this.searchLookUpEdit1View;
            // 
            // dataGetEquipmentsBindingSource
            // 
            this.dataGetEquipmentsBindingSource.DataMember = "Data_Get_Equipments";
            this.dataGetEquipmentsBindingSource.DataSource = this.dataSet_Get_Equipments;
            // 
            // dataSet_Get_Equipments
            // 
            this.dataSet_Get_Equipments.DataSetName = "DataSet_Get_Equipments";
            this.dataSet_Get_Equipments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDEquipments,
            this.colGroupEquipments,
            this.colEquipments,
            this.colDescribes,
            this.colDepartment});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.searchLookUpEdit1View.OptionsView.RowAutoHeight = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIDEquipments
            // 
            this.colIDEquipments.FieldName = "IDEquipments";
            this.colIDEquipments.Name = "colIDEquipments";
            // 
            // colGroupEquipments
            // 
            this.colGroupEquipments.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colGroupEquipments.FieldName = "GroupEquipments";
            this.colGroupEquipments.Name = "colGroupEquipments";
            resources.ApplyResources(this.colGroupEquipments, "colGroupEquipments");
            // 
            // colEquipments
            // 
            this.colEquipments.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colEquipments.FieldName = "Equipments";
            this.colEquipments.Name = "colEquipments";
            resources.ApplyResources(this.colEquipments, "colEquipments");
            // 
            // colDescribes
            // 
            this.colDescribes.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescribes.FieldName = "Describes";
            this.colDescribes.Name = "colDescribes";
            resources.ApplyResources(this.colDescribes, "colDescribes");
            // 
            // colDepartment
            // 
            this.colDepartment.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            resources.ApplyResources(this.colDepartment, "colDepartment");
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Name = "labelControl1";
            // 
            // data_Get_EquipmentsTableAdapter
            // 
            this.data_Get_EquipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGetLocationBindingSource
            // 
            this.dataGetLocationBindingSource.DataMember = "Data_Get_Location";
            this.dataGetLocationBindingSource.DataSource = this.dataSet_Get_Location;
            // 
            // dataSet_Get_Location
            // 
            this.dataSet_Get_Location.DataSetName = "DataSet_Get_Location";
            this.dataSet_Get_Location.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_Get_LocationTableAdapter
            // 
            this.data_Get_LocationTableAdapter.ClearBeforeFill = true;
            // 
            // txtDept
            // 
            resources.ApplyResources(this.txtDept, "txtDept");
            this.txtDept.Name = "txtDept";
            this.txtDept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtDept.Properties.Buttons"))))});
            this.txtDept.Properties.DataSource = this.dataGetDeptBindingSource;
            this.txtDept.Properties.DisplayMember = "Department";
            this.txtDept.Properties.NullText = resources.GetString("txtDept.Properties.NullText");
            this.txtDept.Properties.ValueMember = "IDDepartment";
            this.txtDept.Properties.View = this.gridView2;
            this.txtDept.EditValueChanged += new System.EventHandler(this.txtDept_EditValueChanged);
            // 
            // dataGetDeptBindingSource
            // 
            this.dataGetDeptBindingSource.DataMember = "Data_Get_Dept";
            this.dataGetDeptBindingSource.DataSource = this.dataSet_Dept;
            // 
            // dataSet_Dept
            // 
            this.dataSet_Dept.DataSetName = "DataSet_Dept";
            this.dataSet_Dept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDepartment,
            this.gridColumn3,
            this.colShortName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIDDepartment
            // 
            this.colIDDepartment.FieldName = "IDDepartment";
            this.colIDDepartment.Name = "colIDDepartment";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Department";
            this.gridColumn3.Name = "gridColumn3";
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            // 
            // colShortName
            // 
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            resources.ApplyResources(this.colShortName, "colShortName");
            // 
            // data_Get_DeptTableAdapter
            // 
            this.data_Get_DeptTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.dataGetVatTuCanBaoTriBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("gridControl1.EmbeddedNavigator.Margin")));
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView3;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit2,
            this.repositoryItemCalcEdit1,
            this.repositoryItemSearchLookUpEdit1});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            resources.ApplyResources(this.btnDel, "btnDel");
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dataGetVatTuCanBaoTriBindingSource
            // 
            this.dataGetVatTuCanBaoTriBindingSource.DataMember = "Data_Get_VatTuCanBaoTri";
            this.dataGetVatTuCanBaoTriBindingSource.DataSource = this.dataSet_Get_VatTuBaoTri;
            // 
            // dataSet_Get_VatTuBaoTri
            // 
            this.dataSet_Get_VatTuBaoTri.DataSetName = "DataSet_Get_VatTuBaoTri";
            this.dataSet_Get_VatTuBaoTri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDVT,
            this.colID,
            this.colERP_NAME,
            this.colTenKho,
            this.colSLTonKho,
            this.colSLXuat,
            this.colSLTra,
            this.colTinhtrang});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ColumnAutoWidth = false;
            this.gridView3.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView3.OptionsView.RowAutoHeight = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView3_ValidateRow);
            // 
            // colIDVT
            // 
            this.colIDVT.FieldName = "IDVT";
            this.colIDVT.Name = "colIDVT";
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            this.colID.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            resources.ApplyResources(this.repositoryItemSearchLookUpEdit1, "repositoryItemSearchLookUpEdit1");
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemSearchLookUpEdit1.Buttons"))))});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.dataGetTonKhoBindingSource;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "ERPCODE";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit3});
            this.repositoryItemSearchLookUpEdit1.ValueMember = "ID";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            this.repositoryItemSearchLookUpEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemSearchLookUpEdit1_EditValueChanged);
            // 
            // dataGetTonKhoBindingSource
            // 
            this.dataGetTonKhoBindingSource.DataMember = "Data_Get_TonKho";
            this.dataGetTonKhoBindingSource.DataSource = this.dataSet_Get_TonKho;
            // 
            // dataSet_Get_TonKho
            // 
            this.dataSet_Get_TonKho.DataSetName = "DataSet_Get_TonKho";
            this.dataSet_Get_TonKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.colERPCODE,
            this.colMaVatTu_Old,
            this.colQuyCachVatTu,
            this.colDonViTinh,
            this.colTonKho,
            this.colACTIVE_STATUS,
            this.gridColumn5,
            this.colDATE_IMPORT,
            this.colDATE_UPDATE,
            this.colSYS_DATETIME,
            this.gridColumn6});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.RowAutoHeight = true;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // colERPCODE
            // 
            this.colERPCODE.FieldName = "ERPCODE";
            this.colERPCODE.Name = "colERPCODE";
            resources.ApplyResources(this.colERPCODE, "colERPCODE");
            // 
            // colMaVatTu_Old
            // 
            this.colMaVatTu_Old.FieldName = "MaVatTu_Old";
            this.colMaVatTu_Old.Name = "colMaVatTu_Old";
            // 
            // colQuyCachVatTu
            // 
            this.colQuyCachVatTu.FieldName = "QuyCachVatTu";
            this.colQuyCachVatTu.Name = "colQuyCachVatTu";
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            resources.ApplyResources(this.colDonViTinh, "colDonViTinh");
            // 
            // colTonKho
            // 
            this.colTonKho.FieldName = "TonKho";
            this.colTonKho.Name = "colTonKho";
            resources.ApplyResources(this.colTonKho, "colTonKho");
            // 
            // colACTIVE_STATUS
            // 
            this.colACTIVE_STATUS.FieldName = "ACTIVE_STATUS";
            this.colACTIVE_STATUS.Name = "colACTIVE_STATUS";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "TenKho";
            this.gridColumn5.Name = "gridColumn5";
            resources.ApplyResources(this.gridColumn5, "gridColumn5");
            // 
            // colDATE_IMPORT
            // 
            this.colDATE_IMPORT.FieldName = "DATE_IMPORT";
            this.colDATE_IMPORT.Name = "colDATE_IMPORT";
            // 
            // colDATE_UPDATE
            // 
            this.colDATE_UPDATE.FieldName = "DATE_UPDATE";
            this.colDATE_UPDATE.Name = "colDATE_UPDATE";
            // 
            // colSYS_DATETIME
            // 
            this.colSYS_DATETIME.FieldName = "SYS_DATETIME";
            this.colSYS_DATETIME.Name = "colSYS_DATETIME";
            // 
            // gridColumn6
            // 
            this.gridColumn6.ColumnEdit = this.repositoryItemMemoEdit3;
            this.gridColumn6.FieldName = "ERP_NAME";
            this.gridColumn6.Name = "gridColumn6";
            resources.ApplyResources(this.gridColumn6, "gridColumn6");
            // 
            // colERP_NAME
            // 
            resources.ApplyResources(this.colERP_NAME, "colERP_NAME");
            this.colERP_NAME.ColumnEdit = this.repositoryItemMemoEdit2;
            this.colERP_NAME.FieldName = "ERP_NAME";
            this.colERP_NAME.Name = "colERP_NAME";
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // colTenKho
            // 
            resources.ApplyResources(this.colTenKho, "colTenKho");
            this.colTenKho.FieldName = "TenKho";
            this.colTenKho.Name = "colTenKho";
            // 
            // colSLTonKho
            // 
            resources.ApplyResources(this.colSLTonKho, "colSLTonKho");
            this.colSLTonKho.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colSLTonKho.FieldName = "SLTonKho";
            this.colSLTonKho.Name = "colSLTonKho";
            // 
            // repositoryItemCalcEdit1
            // 
            resources.ApplyResources(this.repositoryItemCalcEdit1, "repositoryItemCalcEdit1");
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemCalcEdit1.Buttons"))))});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colSLXuat
            // 
            resources.ApplyResources(this.colSLXuat, "colSLXuat");
            this.colSLXuat.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colSLXuat.FieldName = "SLXuat";
            this.colSLXuat.Name = "colSLXuat";
            // 
            // colSLTra
            // 
            resources.ApplyResources(this.colSLTra, "colSLTra");
            this.colSLTra.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colSLTra.FieldName = "SLTra";
            this.colSLTra.Name = "colSLTra";
            // 
            // colTinhtrang
            // 
            this.colTinhtrang.Name = "colTinhtrang";
            resources.ApplyResources(this.colTinhtrang, "colTinhtrang");
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // txtPriority
            // 
            resources.ApplyResources(this.txtPriority, "txtPriority");
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("txtPriority.Properties.Buttons"))))});
            this.txtPriority.Properties.DataSource = this.dataGetPriorityBindingSource;
            this.txtPriority.Properties.DisplayMember = "Priority";
            this.txtPriority.Properties.NullText = resources.GetString("txtPriority.Properties.NullText");
            this.txtPriority.Properties.ValueMember = "Priority";
            this.txtPriority.Properties.View = this.gridView4;
            // 
            // dataGetPriorityBindingSource
            // 
            this.dataGetPriorityBindingSource.DataMember = "Data_Get_Priority";
            this.dataGetPriorityBindingSource.DataSource = this.dataSet_Get_Priority;
            // 
            // dataSet_Get_Priority
            // 
            this.dataSet_Get_Priority.DataSetName = "DataSet_Get_Priority";
            this.dataSet_Get_Priority.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDPriority,
            this.colPriority});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView4.OptionsView.RowAutoHeight = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colIDPriority
            // 
            this.colIDPriority.FieldName = "IDPriority";
            this.colIDPriority.Name = "colIDPriority";
            // 
            // colPriority
            // 
            this.colPriority.FieldName = "Priority";
            this.colPriority.Name = "colPriority";
            resources.ApplyResources(this.colPriority, "colPriority");
            // 
            // data_Get_PriorityTableAdapter
            // 
            this.data_Get_PriorityTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Name = "labelControl3";
            // 
            // txtHuman
            // 
            resources.ApplyResources(this.txtHuman, "txtHuman");
            this.txtHuman.Name = "txtHuman";
            // 
            // data_Get_VatTuCanBaoTriTableAdapter
            // 
            this.data_Get_VatTuCanBaoTriTableAdapter.ClearBeforeFill = true;
            // 
            // data_Get_TonKhoTableAdapter
            // 
            this.data_Get_TonKhoTableAdapter.ClearBeforeFill = true;
            // 
            // tbSubject
            // 
            resources.ApplyResources(this.tbSubject, "tbSubject");
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName");
            this.tbSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("tbSubject.Properties.Buttons"))))});
            this.tbSubject.Properties.Items.AddRange(new object[] {
            resources.GetString("tbSubject.Properties.Items"),
            resources.GetString("tbSubject.Properties.Items1"),
            resources.GetString("tbSubject.Properties.Items2")});
            // 
            // txtPerson
            // 
            resources.ApplyResources(this.txtPerson, "txtPerson");
            this.txtPerson.Name = "txtPerson";
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            this.labelControl4.Name = "labelControl4";
            // 
            // txt_Soluong
            // 
            resources.ApplyResources(this.txt_Soluong, "txt_Soluong");
            this.txt_Soluong.Name = "txt_Soluong";
            // 
            // labelControl5
            // 
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl5.Appearance.Font")));
            this.labelControl5.Name = "labelControl5";
            // 
            // labelControl7
            // 
            resources.ApplyResources(this.labelControl7, "labelControl7");
            this.labelControl7.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl7.Appearance.Font")));
            this.labelControl7.Name = "labelControl7";
            // 
            // labelControl8
            // 
            resources.ApplyResources(this.labelControl8, "labelControl8");
            this.labelControl8.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl8.Appearance.Font")));
            this.labelControl8.Name = "labelControl8";
            // 
            // txtTinhTrangTB
            // 
            resources.ApplyResources(this.txtTinhTrangTB, "txtTinhTrangTB");
            this.txtTinhTrangTB.Name = "txtTinhTrangTB";
            this.txtTinhTrangTB.Properties.AccessibleName = resources.GetString("txtTinhTrangTB.Properties.AccessibleName");
            this.txtTinhTrangTB.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colViTri});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Department";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "GroupEquipments";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colViTri
            // 
            this.colViTri.FieldName = "ViTri";
            this.colViTri.Name = "colViTri";
            resources.ApplyResources(this.colViTri, "colViTri");
            // 
            // tbLocation
            // 
            resources.ApplyResources(this.tbLocation, "tbLocation");
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName");
            this.tbLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("tbLocation.Properties.Buttons"))))});
            this.tbLocation.Properties.DataSource = this.dataGetLocationBindingSource;
            this.tbLocation.Properties.DisplayMember = "ViTri";
            this.tbLocation.Properties.NullText = resources.GetString("tbLocation.Properties.NullText");
            this.tbLocation.Properties.ValueMember = "ViTri";
            this.tbLocation.Properties.View = this.gridView1;
            this.tbLocation.EditValueChanged += new System.EventHandler(this.tbLocation_EditValueChanged);
            // 
            // CustomAppointmentForm
            // 
            this.AcceptButton = this.btnOk;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtTinhTrangTB);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_Soluong);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtHuman);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtThietBi);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblShowTimeAs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRecurrence);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.edtShowTimeAs);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbSubject);
            this.Name = "CustomAppointmentForm";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.OnAppointmentFormActivated);
            this.Load += new System.EventHandler(this.CustomAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThietBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetEquipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Equipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGetVatTuCanBaoTriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_VatTuBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetTonKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_TonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPriorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHuman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Soluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTinhTrangTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected DevExpress.XtraEditors.LabelControl lblSubject;
        protected DevExpress.XtraEditors.LabelControl lblLocation;
        protected DevExpress.XtraEditors.LabelControl lblLabel;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.LabelControl lblShowTimeAs;
        protected DevExpress.XtraEditors.CheckEdit chkAllDay;
        protected DevExpress.XtraEditors.SimpleButton btnOk;
        protected DevExpress.XtraEditors.SimpleButton btnCancel;
        protected DevExpress.XtraEditors.SimpleButton btnDelete;
        protected DevExpress.XtraEditors.SimpleButton btnRecurrence;
        protected DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraEditors.DateEdit edtEndDate;
        protected DevExpress.XtraScheduler.UI.SchedulerTimeEdit edtStartTime;
        protected DevExpress.XtraScheduler.UI.SchedulerTimeEdit edtEndTime;
        protected DevExpress.XtraScheduler.UI.AppointmentLabelEdit edtLabel;
        protected DevExpress.XtraScheduler.UI.AppointmentStatusEdit edtShowTimeAs;
        protected DevExpress.XtraScheduler.UI.AppointmentResourceEdit edtResource;
        protected DevExpress.XtraEditors.LabelControl lblResource;
        protected DevExpress.XtraScheduler.UI.AppointmentResourcesEdit edtResources;
        protected DevExpress.XtraEditors.CheckEdit chkReminder;
        protected DevExpress.XtraEditors.MemoEdit tbDescription;
        protected DevExpress.XtraScheduler.UI.DurationEdit cbReminder;
        private System.ComponentModel.IContainer components = null;
        protected DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.SearchLookUpEdit txtThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        private DataSet.DataSet_Get_Equipments dataSet_Get_Equipments;
        private System.Windows.Forms.BindingSource dataGetEquipmentsBindingSource;
        private DataSet.DataSet_Get_EquipmentsTableAdapters.Data_Get_EquipmentsTableAdapter data_Get_EquipmentsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEquipments;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupEquipments;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipments;
        private DevExpress.XtraGrid.Columns.GridColumn colDescribes;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DataSet.DataSet_Get_Location dataSet_Get_Location;
        private System.Windows.Forms.BindingSource dataGetLocationBindingSource;
        private DataSet.DataSet_Get_LocationTableAdapters.Data_Get_LocationTableAdapter data_Get_LocationTableAdapter;
        private DevExpress.XtraEditors.SearchLookUpEdit txtDept;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource dataGetDeptBindingSource;
        private DataSet.DataSet_Dept dataSet_Dept;
        private DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter data_Get_DeptTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit txtPriority;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DataSet.DataSet_Get_Priority dataSet_Get_Priority;
        private System.Windows.Forms.BindingSource dataGetPriorityBindingSource;
        private DataSet.DataSet_Get_PriorityTableAdapters.Data_Get_PriorityTableAdapter data_Get_PriorityTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPriority;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        protected DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit txtHuman;
        private System.Windows.Forms.BindingSource dataGetVatTuCanBaoTriBindingSource;
        private DataSet.DataSet_Get_VatTuBaoTri dataSet_Get_VatTuBaoTri;
        private DevExpress.XtraGrid.Columns.GridColumn colIDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colERP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colSLXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTra;
        private DataSet.DataSet_Get_VatTuBaoTriTableAdapters.Data_Get_VatTuCanBaoTriTableAdapter data_Get_VatTuCanBaoTriTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DataSet.DataSet_Get_TonKho dataSet_Get_TonKho;
        private System.Windows.Forms.BindingSource dataGetTonKhoBindingSource;
        private DataSet.DataSet_Get_TonKhoTableAdapters.Data_Get_TonKhoTableAdapter data_Get_TonKhoTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colERPCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVatTu_Old;
        private DevExpress.XtraGrid.Columns.GridColumn colQuyCachVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVE_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_IMPORT;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_UPDATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSYS_DATETIME;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress.XtraEditors.ComboBoxEdit tbSubject;
        private DevExpress.XtraEditors.MemoEdit txtPerson;
        protected DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhtrang;
        private DevExpress.XtraEditors.MemoEdit txt_Soluong;
        protected DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        protected DevExpress.XtraEditors.LabelControl labelControl7;
        protected DevExpress.XtraEditors.LabelControl labelControl8;
        protected DevExpress.XtraEditors.MemoEdit txtTinhTrangTB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colViTri;
        private DevExpress.XtraEditors.SearchLookUpEdit tbLocation;

    }
}
