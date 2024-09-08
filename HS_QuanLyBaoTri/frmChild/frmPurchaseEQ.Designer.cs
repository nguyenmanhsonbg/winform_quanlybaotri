namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmPurchaseEQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseEQ));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.dateFrom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.dateTo = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.txtphongban = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dataGetDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dept = new HS_QuanLyBaoTri.DataSet.DataSet_Dept();
            this.btnXem = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaste = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcell = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.cmbSheet = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.txtPath = new DevExpress.XtraBars.BarHeaderItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cmb_Sheet = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.data_Get_DeptTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btndelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGetPurchaseEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Purchase_Equipments = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Purchase_Equipments();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Purchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colERPCODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOUCHER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colEQUIP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_SPECIFICATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colUNIT_MEASURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPT_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPURPOSE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDATE_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHECK_RETURN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDATE_RETURN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREMARK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_Purchase_EquipmentTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Purchase_EquipmentsTableAdapters.Data_Get_Purchase_EquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPurchaseEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Purchase_Equipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1,
            this.dateFrom,
            this.dateTo,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.txtphongban,
            this.btnXem,
            this.btnExcell,
            this.btnAdd,
            this.btnSave,
            this.btnPaste,
            this.cmbSheet,
            this.txtPath,
            this.barEditItem1,
            this.cmb_Sheet});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 25;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemDateEdit2,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit3,
            this.repositoryItemComboBox2});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.dateFrom),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.dateTo),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtphongban),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPaste, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcell, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Từ ngày:";
            this.barStaticItem1.Id = 12;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dateFrom
            // 
            this.dateFrom.Caption = "barEditItem1";
            this.dateFrom.Edit = this.repositoryItemDateEdit1;
            this.dateFrom.Id = 8;
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(100, 0);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "đến ngày:";
            this.barStaticItem2.Id = 13;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dateTo
            // 
            this.dateTo.Caption = "barEditItem2";
            this.dateTo.Edit = this.repositoryItemDateEdit2;
            this.dateTo.Id = 11;
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(100, 0);
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Chọn phòng ban:";
            this.barStaticItem3.Id = 14;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // txtphongban
            // 
            this.txtphongban.Caption = "barEditItem3";
            this.txtphongban.Edit = this.repositoryItemLookUpEdit1;
            this.txtphongban.Id = 15;
            this.txtphongban.Name = "txtphongban";
            this.txtphongban.Size = new System.Drawing.Size(200, 0);
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldID", "Old ID", 53, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDDepartment", "ID Department", 81, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Department", "Department", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShortName", "Short Name", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KindOfDepartment", "Kind Of Department", 105, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDKindLine", "ID Kind Line", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.dataGetDeptBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "ShortName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "[Chọn phòng ban]";
            this.repositoryItemLookUpEdit1.ValueMember = "IDDepartment";
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
            // btnXem
            // 
            this.btnXem.Caption = "XEM";
            this.btnXem.Id = 16;
            this.btnXem.ImageIndex = 0;
            this.btnXem.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnXem.Name = "btnXem";
            this.btnXem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXem_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 18;
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnPaste
            // 
            this.btnPaste.Caption = "Dán";
            this.btnPaste.Id = 20;
            this.btnPaste.ImageIndex = 4;
            this.btnPaste.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPaste_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 19;
            this.btnSave.ImageIndex = 3;
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnExcell
            // 
            this.btnExcell.Caption = "Excel";
            this.btnExcell.Id = 17;
            this.btnExcell.ImageIndex = 1;
            this.btnExcell.Name = "btnExcell";
            this.btnExcell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "THEO DÕI PHIẾU YÊU CẦU VẬT TƯ";
            this.barHeaderItem1.Id = 4;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(949, 52);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 389);
            this.barDockControlBottom.Size = new System.Drawing.Size(949, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 52);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(949, 52);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Find_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "ExportToXLSX_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "Add_16x16.png");
            this.imageCollection1.Images.SetKeyName(3, "Apply_16x16.png");
            this.imageCollection1.Images.SetKeyName(4, "Paste_16x16.png");
            // 
            // cmbSheet
            // 
            this.cmbSheet.Caption = "barEditItem1";
            this.cmbSheet.Edit = this.repositoryItemComboBox1;
            this.cmbSheet.Id = 21;
            this.cmbSheet.Name = "cmbSheet";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // txtPath
            // 
            this.txtPath.Id = 22;
            this.txtPath.Name = "txtPath";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemTextEdit3;
            this.barEditItem1.Id = 23;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // cmb_Sheet
            // 
            this.cmb_Sheet.Caption = "barEditItem2";
            this.cmb_Sheet.Edit = this.repositoryItemComboBox2;
            this.cmb_Sheet.Id = 24;
            this.cmb_Sheet.Name = "cmb_Sheet";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // data_Get_DeptTableAdapter
            // 
            this.data_Get_DeptTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.option;
            this.gridControl1.DataSource = this.dataGetPurchaseEquipmentBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 52);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemCalcEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemSearchLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(949, 337);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // option
            // 
            this.option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btndelete});
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(132, 26);
            // 
            // btndelete
            // 
            this.btndelete.Name = "btndelete";
            this.btndelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.btndelete.Size = new System.Drawing.Size(131, 22);
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // dataGetPurchaseEquipmentBindingSource
            // 
            this.dataGetPurchaseEquipmentBindingSource.DataMember = "Data_Get_Purchase_Equipment";
            this.dataGetPurchaseEquipmentBindingSource.DataSource = this.dataSet_Get_Purchase_Equipments;
            // 
            // dataSet_Get_Purchase_Equipments
            // 
            this.dataSet_Get_Purchase_Equipments.DataSetName = "DataSet_Get_Purchase_Equipments";
            this.dataSet_Get_Purchase_Equipments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Purchase,
            this.colERPCODE,
            this.colVOUCHER,
            this.colEQUIP_CODE,
            this.colEQUIP_NAME,
            this.colEQUIP_SPECIFICATION,
            this.colQUANTITY,
            this.colUNIT_MEASURE,
            this.colDEPT_ORDER,
            this.colPURPOSE,
            this.colDATE_ORDER,
            this.colCHECK_RETURN,
            this.colDATE_RETURN,
            this.colREMARK});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDATE_ORDER, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colID_Purchase
            // 
            this.colID_Purchase.FieldName = "ID_Purchase";
            this.colID_Purchase.Name = "colID_Purchase";
            // 
            // colERPCODE
            // 
            this.colERPCODE.Caption = "Mã ERP";
            this.colERPCODE.FieldName = "ERPCODE";
            this.colERPCODE.Name = "colERPCODE";
            this.colERPCODE.Visible = true;
            this.colERPCODE.VisibleIndex = 0;
            this.colERPCODE.Width = 116;
            // 
            // colVOUCHER
            // 
            this.colVOUCHER.Caption = "Phiếu Yêu Cầu";
            this.colVOUCHER.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colVOUCHER.FieldName = "VOUCHER";
            this.colVOUCHER.Name = "colVOUCHER";
            this.colVOUCHER.Visible = true;
            this.colVOUCHER.VisibleIndex = 7;
            this.colVOUCHER.Width = 105;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colEQUIP_CODE
            // 
            this.colEQUIP_CODE.Caption = "Mã Cũ Thiết bị ";
            this.colEQUIP_CODE.FieldName = "EQUIP_CODE";
            this.colEQUIP_CODE.Name = "colEQUIP_CODE";
            this.colEQUIP_CODE.Visible = true;
            this.colEQUIP_CODE.VisibleIndex = 1;
            this.colEQUIP_CODE.Width = 99;
            // 
            // colEQUIP_NAME
            // 
            this.colEQUIP_NAME.Caption = "Tên Thiết Bị";
            this.colEQUIP_NAME.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colEQUIP_NAME.FieldName = "EQUIP_NAME";
            this.colEQUIP_NAME.Name = "colEQUIP_NAME";
            this.colEQUIP_NAME.Visible = true;
            this.colEQUIP_NAME.VisibleIndex = 2;
            this.colEQUIP_NAME.Width = 179;
            // 
            // colEQUIP_SPECIFICATION
            // 
            this.colEQUIP_SPECIFICATION.Caption = "Thông số Kỹ Thuật";
            this.colEQUIP_SPECIFICATION.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colEQUIP_SPECIFICATION.FieldName = "EQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Name = "colEQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Visible = true;
            this.colEQUIP_SPECIFICATION.VisibleIndex = 3;
            this.colEQUIP_SPECIFICATION.Width = 274;
            // 
            // colQUANTITY
            // 
            this.colQUANTITY.Caption = "Số lượng";
            this.colQUANTITY.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colQUANTITY.FieldName = "QUANTITY";
            this.colQUANTITY.Name = "colQUANTITY";
            this.colQUANTITY.Visible = true;
            this.colQUANTITY.VisibleIndex = 4;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colUNIT_MEASURE
            // 
            this.colUNIT_MEASURE.Caption = "ĐVT";
            this.colUNIT_MEASURE.FieldName = "UNIT_MEASURE";
            this.colUNIT_MEASURE.Name = "colUNIT_MEASURE";
            this.colUNIT_MEASURE.Visible = true;
            this.colUNIT_MEASURE.VisibleIndex = 5;
            this.colUNIT_MEASURE.Width = 65;
            // 
            // colDEPT_ORDER
            // 
            this.colDEPT_ORDER.Caption = "Phòng Yêu Cầu";
            this.colDEPT_ORDER.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.colDEPT_ORDER.FieldName = "DEPT_ORDER";
            this.colDEPT_ORDER.Name = "colDEPT_ORDER";
            this.colDEPT_ORDER.Visible = true;
            this.colDEPT_ORDER.VisibleIndex = 6;
            this.colDEPT_ORDER.Width = 96;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.dataGetDeptBindingSource;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "ShortName";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.NullText = "";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "IDDepartment";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
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
            // colPURPOSE
            // 
            this.colPURPOSE.Caption = "Mục đích";
            this.colPURPOSE.FieldName = "PURPOSE";
            this.colPURPOSE.Name = "colPURPOSE";
            this.colPURPOSE.Visible = true;
            this.colPURPOSE.VisibleIndex = 8;
            this.colPURPOSE.Width = 141;
            // 
            // colDATE_ORDER
            // 
            this.colDATE_ORDER.Caption = "Ngày Yêu Cầu";
            this.colDATE_ORDER.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colDATE_ORDER.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDATE_ORDER.FieldName = "DATE_ORDER";
            this.colDATE_ORDER.Name = "colDATE_ORDER";
            this.colDATE_ORDER.Visible = true;
            this.colDATE_ORDER.VisibleIndex = 9;
            this.colDATE_ORDER.Width = 102;
            // 
            // colCHECK_RETURN
            // 
            this.colCHECK_RETURN.Caption = "Đã Về";
            this.colCHECK_RETURN.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCHECK_RETURN.FieldName = "CHECK_RETURN";
            this.colCHECK_RETURN.Name = "colCHECK_RETURN";
            this.colCHECK_RETURN.Visible = true;
            this.colCHECK_RETURN.VisibleIndex = 10;
            this.colCHECK_RETURN.Width = 49;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit1_EditValueChanged);
            // 
            // colDATE_RETURN
            // 
            this.colDATE_RETURN.Caption = "Ngày về";
            this.colDATE_RETURN.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colDATE_RETURN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDATE_RETURN.FieldName = "DATE_RETURN";
            this.colDATE_RETURN.Name = "colDATE_RETURN";
            this.colDATE_RETURN.Visible = true;
            this.colDATE_RETURN.VisibleIndex = 11;
            this.colDATE_RETURN.Width = 122;
            // 
            // colREMARK
            // 
            this.colREMARK.Caption = "Ghi Chú";
            this.colREMARK.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colREMARK.FieldName = "REMARK";
            this.colREMARK.Name = "colREMARK";
            this.colREMARK.Visible = true;
            this.colREMARK.VisibleIndex = 12;
            this.colREMARK.Width = 100;
            // 
            // data_Get_Purchase_EquipmentTableAdapter
            // 
            this.data_Get_Purchase_EquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // frmPurchaseEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 389);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseEQ";
            this.Text = "Theo Dõi Yêu cầu Vật Tư";
            this.Load += new System.EventHandler(this.frmPurchaseEQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPurchaseEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Purchase_Equipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem dateFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarEditItem dateTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarEditItem txtphongban;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraBars.BarButtonItem btnXem;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnPaste;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnExcell;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarEditItem cmbSheet;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarHeaderItem txtPath;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarEditItem cmb_Sheet;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private System.Windows.Forms.BindingSource dataGetDeptBindingSource;
        private DataSet.DataSet_Dept dataSet_Dept;
        private DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter data_Get_DeptTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dataGetPurchaseEquipmentBindingSource;
        private DataSet.DataSet_Get_Purchase_Equipments dataSet_Get_Purchase_Equipments;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Purchase;
        private DevExpress.XtraGrid.Columns.GridColumn colERPCODE;
        private DevExpress.XtraGrid.Columns.GridColumn colVOUCHER;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_SPECIFICATION;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_MEASURE;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPT_ORDER;
        private DevExpress.XtraGrid.Columns.GridColumn colPURPOSE;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_ORDER;
        private DevExpress.XtraGrid.Columns.GridColumn colCHECK_RETURN;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_RETURN;
        private DevExpress.XtraGrid.Columns.GridColumn colREMARK;
        private DataSet.DataSet_Get_Purchase_EquipmentsTableAdapters.Data_Get_Purchase_EquipmentTableAdapter data_Get_Purchase_EquipmentTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ContextMenuStrip option;
        private System.Windows.Forms.ToolStripMenuItem btndelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
    }
}