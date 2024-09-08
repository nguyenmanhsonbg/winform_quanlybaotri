namespace HS_QuanLyBaoTri
{
    partial class frmSchedule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.txtDept = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.dataGetDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dept = new HS_QuanLyBaoTri.DataSet.DataSet_Dept();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewAll = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.data_Get_DeptTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._HS_QuanLyBaoTriDataSet = new HS_QuanLyBaoTri._HS_QuanLyBaoTriDataSet();
            this.resourcesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUniqueID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLabel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResourceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResourceIDs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReminderInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecurrenceInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTimeZoneId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomField1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHuman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.appointmentsTableAdapter = new HS_QuanLyBaoTri._HS_QuanLyBaoTriDataSetTableAdapters.AppointmentsTableAdapter();
            this.resourcesTableAdapter = new HS_QuanLyBaoTri._HS_QuanLyBaoTriDataSetTableAdapters.ResourcesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._HS_QuanLyBaoTriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtDept,
            this.btnFresh,
            this.btnReport,
            this.btnViewAll,
            this.btnXuatExcel});
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.repositoryItemSearchLookUpEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.txtDept, "", false, true, true, 186),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnViewAll, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXuatExcel, true)});
            this.bar1.Text = "Tools";
            // 
            // txtDept
            // 
            this.txtDept.Caption = "barEditItem1";
            this.txtDept.Edit = this.repositoryItemSearchLookUpEdit1;
            this.txtDept.Id = 1;
            this.txtDept.Name = "txtDept";
            this.txtDept.EditValueChanged += new System.EventHandler(this.txtDept_EditValueChanged);
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.dataGetDeptBindingSource;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "Department";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.NullText = "";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "IDDepartment";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
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
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDepartment,
            this.colDepartment,
            this.colShortName});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIDDepartment
            // 
            this.colIDDepartment.FieldName = "IDDepartment";
            this.colIDDepartment.Name = "colIDDepartment";
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 0;
            // 
            // colShortName
            // 
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 1;
            // 
            // btnFresh
            // 
            this.btnFresh.Caption = "Làm Mới";
            this.btnFresh.Id = 2;
            this.btnFresh.ImageIndex = 0;
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFresh_ItemClick);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Caption = "Xem Tất Cả";
            this.btnViewAll.Id = 4;
            this.btnViewAll.ImageIndex = 6;
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewAll_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Báo Cáo";
            this.btnReport.Id = 3;
            this.btnReport.ImageIndex = 5;
            this.btnReport.Name = "btnReport";
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Caption = "Export Data";
            this.btnXuatExcel.Id = 5;
            this.btnXuatExcel.Name = "btnXuatExcel";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1465, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 815);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1465, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 783);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1465, 32);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 783);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Refresh_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "Add_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "Apply_16x16.png");
            this.imageCollection1.Images.SetKeyName(3, "Cancel_16x16.png");
            this.imageCollection1.Images.SetKeyName(4, "Clear_16x16.png");
            this.imageCollection1.Images.SetKeyName(5, "ExportToXLSX_16x16.png");
            this.imageCollection1.Images.SetKeyName(6, "Show_16x16.png");
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // data_Get_DeptTableAdapter
            // 
            this.data_Get_DeptTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 32);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1465, 783);
            this.splitContainerControl1.SplitterPosition = 396;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl2.Panel1.Controls.Add(this.schedulerControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.dateNavigator1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1465, 396);
            this.splitContainerControl2.SplitterPosition = 1112;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1112, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.schedulerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.schedulerControl1.MenuManager = this.barManager1;
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(1112, 396);
            this.schedulerControl1.Start = new System.DateTime(2017, 8, 30, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl1.Views.GanttView.CellsAutoHeightOptions.Enabled = true;
            this.schedulerControl1.Views.GanttView.ResourcesPerPage = 9;
            this.schedulerControl1.Views.GanttView.ShowResourceHeaders = false;
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            this.schedulerControl1.Click += new System.EventHandler(this.schedulerControl1_Click);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Priority", "Priority"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("IDEquipments", "CustomField1"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("IDDept", "IDDept"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("UniqueID", "UniqueID"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("IDAppointments", "IDAppointments"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PerformanceHuman", "Performance_Human"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PerformancePerson", "Performance_Person"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("SoNgayBaoTri", "So_Ngay_Bao_Tri"));
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("TinhTrangThietBi", "Tinh_Trang_Thiet_Bi"));
            this.schedulerStorage1.Appointments.DataSource = this.appointmentsBindingSource;
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "EndDate";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID";
            this.schedulerStorage1.Appointments.Mappings.Start = "StartDate";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId";
            this.schedulerStorage1.Appointments.Mappings.Type = "Type";
            this.schedulerStorage1.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("CustomField1", "CustomField1"));
            this.schedulerStorage1.Resources.CustomFieldMappings.Add(new DevExpress.XtraScheduler.ResourceCustomFieldMapping("UniqueID", "UniqueID"));
            this.schedulerStorage1.Resources.DataSource = this.resourcesBindingSource;
            this.schedulerStorage1.Resources.Mappings.Caption = "ResourceName";
            this.schedulerStorage1.Resources.Mappings.Color = "Color";
            this.schedulerStorage1.Resources.Mappings.Id = "ResourceID";
            this.schedulerStorage1.Resources.Mappings.Image = "Image";
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this._HS_QuanLyBaoTriDataSet;
            // 
            // _HS_QuanLyBaoTriDataSet
            // 
            this._HS_QuanLyBaoTriDataSet.DataSetName = "_HS_QuanLyBaoTriDataSet";
            this._HS_QuanLyBaoTriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resourcesBindingSource
            // 
            this.resourcesBindingSource.DataMember = "Resources";
            this.resourcesBindingSource.DataSource = this._HS_QuanLyBaoTriDataSet;
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.AllowAnimatedContentChange = true;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dateNavigator1.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNavigator1.DateTime = new System.DateTime(2024, 8, 2, 0, 0, 0, 0);
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNavigator1.EditValue = new System.DateTime(2024, 8, 2, 0, 0, 0, 0);
            this.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(343, 396);
            this.dateNavigator1.TabIndex = 0;
            this.dateNavigator1.EditValueChanged += new System.EventHandler(this.dateNavigator1_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.appointmentsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1465, 377);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUniqueID,
            this.colType,
            this.colStartDate,
            this.colEndDate,
            this.colAllDay,
            this.colSubject,
            this.colLocation,
            this.colDescription,
            this.colStatus,
            this.colLabel,
            this.colResourceID,
            this.colResourceIDs,
            this.colReminderInfo,
            this.colRecurrenceInfo,
            this.colTimeZoneId,
            this.colCustomField1,
            this.colIDDept,
            this.colPriority,
            this.colHuman});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSubject, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colUniqueID
            // 
            this.colUniqueID.FieldName = "UniqueID";
            this.colUniqueID.Name = "colUniqueID";
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            // 
            // colStartDate
            // 
            this.colStartDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            this.colStartDate.Width = 154;
            // 
            // colEndDate
            // 
            this.colEndDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 3;
            this.colEndDate.Width = 169;
            // 
            // colAllDay
            // 
            this.colAllDay.FieldName = "AllDay";
            this.colAllDay.Name = "colAllDay";
            this.colAllDay.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSubject
            // 
            this.colSubject.AppearanceCell.Options.UseTextOptions = true;
            this.colSubject.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSubject.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSubject.Caption = "Công Việc";
            this.colSubject.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 0;
            this.colSubject.Width = 91;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colLocation
            // 
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Mô Tả Chi Tiết Công Việc";
            this.colDescription.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 495;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colLabel
            // 
            this.colLabel.FieldName = "Label";
            this.colLabel.Name = "colLabel";
            this.colLabel.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colResourceID
            // 
            this.colResourceID.FieldName = "ResourceID";
            this.colResourceID.Name = "colResourceID";
            this.colResourceID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colResourceIDs
            // 
            this.colResourceIDs.FieldName = "ResourceIDs";
            this.colResourceIDs.Name = "colResourceIDs";
            this.colResourceIDs.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colReminderInfo
            // 
            this.colReminderInfo.FieldName = "ReminderInfo";
            this.colReminderInfo.Name = "colReminderInfo";
            // 
            // colRecurrenceInfo
            // 
            this.colRecurrenceInfo.FieldName = "RecurrenceInfo";
            this.colRecurrenceInfo.Name = "colRecurrenceInfo";
            // 
            // colTimeZoneId
            // 
            this.colTimeZoneId.FieldName = "TimeZoneId";
            this.colTimeZoneId.Name = "colTimeZoneId";
            // 
            // colCustomField1
            // 
            this.colCustomField1.FieldName = "CustomField1";
            this.colCustomField1.Name = "colCustomField1";
            // 
            // colIDDept
            // 
            this.colIDDept.Caption = "Dây Chuyền";
            this.colIDDept.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIDDept.FieldName = "IDDept";
            this.colIDDept.Name = "colIDDept";
            this.colIDDept.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIDDept.Visible = true;
            this.colIDDept.VisibleIndex = 4;
            this.colIDDept.Width = 135;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.dataGetDeptBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Department";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "IDDepartment";
            // 
            // colPriority
            // 
            this.colPriority.Caption = "Ưu Tiên";
            this.colPriority.FieldName = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPriority.Visible = true;
            this.colPriority.VisibleIndex = 5;
            this.colPriority.Width = 100;
            // 
            // colHuman
            // 
            this.colHuman.Caption = "Nhóm/ Người Thực hiện";
            this.colHuman.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colHuman.FieldName = "Performance_Human";
            this.colHuman.Name = "colHuman";
            this.colHuman.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colHuman.Visible = true;
            this.colHuman.VisibleIndex = 6;
            this.colHuman.Width = 138;
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // resourcesTableAdapter
            // 
            this.resourcesTableAdapter.ClearBeforeFill = true;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 815);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "iMaginary";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSchedule";
            this.Text = "Kế Hoạch Bảo Trì";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._HS_QuanLyBaoTriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem txtDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraBars.BarButtonItem btnFresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private System.Windows.Forms.BindingSource dataGetDeptBindingSource;
        private DataSet.DataSet_Dept dataSet_Dept;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter data_Get_DeptTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private _HS_QuanLyBaoTriDataSet _HS_QuanLyBaoTriDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private _HS_QuanLyBaoTriDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.BindingSource resourcesBindingSource;
        private _HS_QuanLyBaoTriDataSetTableAdapters.ResourcesTableAdapter resourcesTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueID;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAllDay;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colResourceID;
        private DevExpress.XtraGrid.Columns.GridColumn colResourceIDs;
        private DevExpress.XtraGrid.Columns.GridColumn colReminderInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colRecurrenceInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colTimeZoneId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomField1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDept;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        private DevExpress.XtraGrid.Columns.GridColumn colHuman;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarButtonItem btnReport;
        private DevExpress.XtraBars.BarButtonItem btnViewAll;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraBars.BarButtonItem btnXuatExcel;

    }
}

