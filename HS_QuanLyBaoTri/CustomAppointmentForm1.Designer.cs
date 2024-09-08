using DevExpress.XtraScheduler.UI;
namespace HS_QuanLyBaoTri
{
    partial class CustomAppointmentForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAppointmentForm1));
            this.lblSubject = new DevExpress.XtraEditors.LabelControl();
            this.lblLocation = new DevExpress.XtraEditors.LabelControl();
            this.tbSubject = new DevExpress.XtraEditors.TextEdit();
            this.lblStartTime = new DevExpress.XtraEditors.LabelControl();
            this.lblEndTime = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.edtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.edtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.tbDescription = new DevExpress.XtraEditors.MemoEdit();
            this.lblResource = new DevExpress.XtraEditors.LabelControl();
            this.edtResource = new DevExpress.XtraScheduler.UI.AppointmentResourceEdit();
            this.edtResources = new DevExpress.XtraScheduler.UI.AppointmentResourcesEdit();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.tbProgress = new DevExpress.XtraEditors.TrackBarControl();
            this.lblPercentCompleteValue = new DevExpress.XtraEditors.LabelControl();
            this.lblPercentComplete = new DevExpress.XtraEditors.LabelControl();
            this.edtStartTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.edtEndTime = new DevExpress.XtraScheduler.UI.SchedulerTimeEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.tbLocation = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dataGetLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Location = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Location();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_LocationTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_LocationTableAdapters.Data_Get_LocationTableAdapter();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPriority = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dataGetPriorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Priority = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Priority();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_PriorityTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_PriorityTableAdapters.Data_Get_PriorityTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHuman = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtThietBi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.dataGetEquipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Equipments = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Equipments();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescribes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_EquipmentsTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_EquipmentsTableAdapters.Data_Get_EquipmentsTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGetVatTuCanBaoTriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_VatTuBaoTri = new HS_QuanLyBaoTri.DataSet.DataSet_Get_VatTuBaoTri();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.dataGetTonKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_TonKho = new HS_QuanLyBaoTri.DataSet.DataSet_Get_TonKho();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.data_Get_VatTuCanBaoTriTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_VatTuBaoTriTableAdapters.Data_Get_VatTuCanBaoTriTableAdapter();
            this.data_Get_TonKhoTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_TonKhoTableAdapters.Data_Get_TonKhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetLocationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Location)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPriorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Priority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHuman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThietBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetEquipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Equipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetVatTuCanBaoTriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_VatTuBaoTri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetTonKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_TonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            resources.ApplyResources(this.lblSubject, "lblSubject");
            this.lblSubject.Name = "lblSubject";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            // 
            // tbSubject
            // 
            resources.ApplyResources(this.tbSubject, "tbSubject");
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName");
            // 
            // lblStartTime
            // 
            resources.ApplyResources(this.lblStartTime, "lblStartTime");
            this.lblStartTime.Name = "lblStartTime";
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.lblEndTime.Name = "lblEndTime";
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
            // progressPanel
            // 
            resources.ApplyResources(this.progressPanel, "progressPanel");
            this.progressPanel.Controls.Add(this.tbProgress);
            this.progressPanel.Controls.Add(this.lblPercentCompleteValue);
            this.progressPanel.Controls.Add(this.lblPercentComplete);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.TabStop = true;
            // 
            // tbProgress
            // 
            resources.ApplyResources(this.tbProgress, "tbProgress");
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Properties.AutoSize = false;
            this.tbProgress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tbProgress.Properties.Maximum = 100;
            this.tbProgress.Properties.ShowValueToolTip = true;
            this.tbProgress.Properties.TickFrequency = 10;
            // 
            // lblPercentCompleteValue
            // 
            resources.ApplyResources(this.lblPercentCompleteValue, "lblPercentCompleteValue");
            this.lblPercentCompleteValue.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblPercentCompleteValue.Appearance.BackColor")));
            this.lblPercentCompleteValue.Name = "lblPercentCompleteValue";
            // 
            // lblPercentComplete
            // 
            resources.ApplyResources(this.lblPercentComplete, "lblPercentComplete");
            this.lblPercentComplete.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("lblPercentComplete.Appearance.BackColor")));
            this.lblPercentComplete.Name = "lblPercentComplete";
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
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.CausesValidation = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.OnBtnDeleteClick);
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
            this.tbLocation.Properties.View = this.searchLookUpEdit1View;
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
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colViTri});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            // data_Get_LocationTableAdapter
            // 
            this.data_Get_LocationTableAdapter.ClearBeforeFill = true;
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
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // txtHuman
            // 
            resources.ApplyResources(this.txtHuman, "txtHuman");
            this.txtHuman.Name = "txtHuman";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl4
            // 
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
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
            this.txtThietBi.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.txtThietBi.Properties.ValueMember = "IDEquipments";
            this.txtThietBi.Properties.View = this.gridView1;
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
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDEquipments,
            this.colGroupEquipments,
            this.colEquipments,
            this.colDescribes,
            this.colDepartment});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            // data_Get_EquipmentsTableAdapter
            // 
            this.data_Get_EquipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.dataGetVatTuCanBaoTriBindingSource;
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
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnXoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            resources.ApplyResources(this.btnXoa, "btnXoa");
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.colSLTra});
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
            this.repositoryItemSearchLookUpEdit1.ValueMember = "ID";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView2;
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
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // data_Get_VatTuCanBaoTriTableAdapter
            // 
            this.data_Get_VatTuCanBaoTriTableAdapter.ClearBeforeFill = true;
            // 
            // data_Get_TonKhoTableAdapter
            // 
            this.data_Get_TonKhoTableAdapter.ClearBeforeFill = true;
            // 
            // CustomAppointmentForm1
            // 
            this.AcceptButton = this.btnOk;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtThietBi);
            this.Controls.Add(this.txtHuman);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.edtResources);
            this.Controls.Add(this.edtResource);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblResource);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.edtStartTime);
            this.Controls.Add(this.edtStartDate);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.edtEndDate);
            this.Controls.Add(this.edtEndTime);
            this.Controls.Add(this.tbLocation);
            this.Name = "CustomAppointmentForm1";
            this.ShowInTaskbar = false;
            this.Activated += new System.EventHandler(this.OnAppointmentFormActivated);
            this.Load += new System.EventHandler(this.CustomAppointmentForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetLocationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Location)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPriorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Priority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHuman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThietBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetEquipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Equipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGetVatTuCanBaoTriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_VatTuBaoTri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetTonKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_TonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        protected DevExpress.XtraEditors.LabelControl lblSubject;
        protected DevExpress.XtraEditors.LabelControl lblLocation;
        protected DevExpress.XtraEditors.LabelControl lblStartTime;
        protected DevExpress.XtraEditors.LabelControl lblEndTime;
        protected DevExpress.XtraEditors.SimpleButton btnOk;
        protected DevExpress.XtraEditors.SimpleButton btnCancel;
        protected DevExpress.XtraEditors.DateEdit edtStartDate;
        protected DevExpress.XtraEditors.DateEdit edtEndDate;
        protected DevExpress.XtraScheduler.UI.SchedulerTimeEdit edtStartTime;
        protected DevExpress.XtraScheduler.UI.SchedulerTimeEdit edtEndTime;
        protected DevExpress.XtraEditors.TextEdit tbSubject;
        protected DevExpress.XtraScheduler.UI.AppointmentResourceEdit edtResource;
        protected DevExpress.XtraEditors.LabelControl lblResource;
        protected DevExpress.XtraScheduler.UI.AppointmentResourcesEdit edtResources;
        protected DevExpress.XtraEditors.MemoEdit tbDescription;
        private System.ComponentModel.IContainer components = null;
        protected System.Windows.Forms.Panel progressPanel;
        protected DevExpress.XtraEditors.TrackBarControl tbProgress;
        protected DevExpress.XtraEditors.LabelControl lblPercentComplete;
        protected DevExpress.XtraEditors.LabelControl lblPercentCompleteValue;
        protected DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SearchLookUpEdit tbLocation;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DataSet.DataSet_Get_Location dataSet_Get_Location;
        private System.Windows.Forms.BindingSource dataGetLocationBindingSource;
        private DataSet.DataSet_Get_LocationTableAdapters.Data_Get_LocationTableAdapter data_Get_LocationTableAdapter;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit txtPriority;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPriority;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        private DataSet.DataSet_Get_Priority dataSet_Get_Priority;
        private System.Windows.Forms.BindingSource dataGetPriorityBindingSource;
        private DataSet.DataSet_Get_PriorityTableAdapters.Data_Get_PriorityTableAdapter data_Get_PriorityTableAdapter;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtHuman;
        protected DevExpress.XtraEditors.LabelControl labelControl3;
        protected DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit txtThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDEquipments;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupEquipments;
        private DevExpress.XtraGrid.Columns.GridColumn colEquipments;
        private DevExpress.XtraGrid.Columns.GridColumn colDescribes;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DataSet.DataSet_Get_Equipments dataSet_Get_Equipments;
        private System.Windows.Forms.BindingSource dataGetEquipmentsBindingSource;
        private DataSet.DataSet_Get_EquipmentsTableAdapters.Data_Get_EquipmentsTableAdapter data_Get_EquipmentsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colViTri;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colIDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
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
        private DevExpress.XtraGrid.Columns.GridColumn colERP_NAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTonKho;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colSLXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTra;
        private System.Windows.Forms.BindingSource dataGetVatTuCanBaoTriBindingSource;
        private DataSet.DataSet_Get_VatTuBaoTri dataSet_Get_VatTuBaoTri;
        private DataSet.DataSet_Get_VatTuBaoTriTableAdapters.Data_Get_VatTuCanBaoTriTableAdapter data_Get_VatTuCanBaoTriTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private DataSet.DataSet_Get_TonKho dataSet_Get_TonKho;
        private System.Windows.Forms.BindingSource dataGetTonKhoBindingSource;
        private DataSet.DataSet_Get_TonKhoTableAdapters.Data_Get_TonKhoTableAdapter data_Get_TonKhoTableAdapter;

    }
}
