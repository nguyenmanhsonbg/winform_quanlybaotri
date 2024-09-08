namespace HS_QuanLyBaoTri
{
    partial class frmEquipments
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipments));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACHINE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_SPECIFICATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colUNIT_MEASURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_MEASURE_END = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANTITY_BAK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVE_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK_TPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_LIMIT_MIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_LIMIT_MAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUMALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiNhanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGetAllEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_AllEquipment = new HS_QuanLyBaoTri.DataSet.DataSet_Get_AllEquipment();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colERPCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIDEquipments = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIDGroupEQ = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.tblGroupEquipmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_GroupEquiments = new HS_QuanLyBaoTri.DataSet.DataSet_Get_GroupEquiments();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquipments = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIDGoods = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Goods = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Goods();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnits = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDescribes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSLDC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSLDP = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colQUANTITY1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEQUIP_LIMIT_MIN1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSupplier = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colIDDept = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.dataGetDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Dept = new HS_QuanLyBaoTri.DataSet.DataSet_Dept();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHigh_Value = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgayDuaVaoSuDung = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colDAHUY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNgayHuy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCheckEdit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.txtDept = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemSearchLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGoods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.data_Get_DeptTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter();
            this.data_Get_AllEquipmentTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_AllEquipmentTableAdapters.Data_Get_AllEquipmentTableAdapter();
            this.view_TonKhoTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_AllEquipmentTableAdapters.View_TonKhoTableAdapter();
            this.tblGroupEquipmentsTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_GroupEquimentsTableAdapters.tblGroupEquipmentsTableAdapter();
            this.dataTable1TableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_GoodsTableAdapters.DataTable1TableAdapter();
            this._HS_QuanLyBaoTriDataSet1 = new HS_QuanLyBaoTri._HS_QuanLyBaoTriDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetAllEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_AllEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_GroupEquiments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Goods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._HS_QuanLyBaoTriDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACHINE_CODE,
            this.colEQUIP_CODE,
            this.colEQUIP_SPECIFICATION,
            this.colUNIT_MEASURE,
            this.colUNIT_MEASURE_END,
            this.colQUANTITY,
            this.colQUANTITY_BAK,
            this.colACTIVE_STATUS,
            this.colSTOCK_TPM,
            this.colEQUIP_LIMIT_MIN,
            this.colEQUIP_LIMIT_MAX,
            this.colSUMALL});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMACHINE_CODE
            // 
            this.colMACHINE_CODE.Caption = "Mã ERP";
            this.colMACHINE_CODE.FieldName = "MACHINE_CODE";
            this.colMACHINE_CODE.Name = "colMACHINE_CODE";
            this.colMACHINE_CODE.Visible = true;
            this.colMACHINE_CODE.VisibleIndex = 0;
            this.colMACHINE_CODE.Width = 163;
            // 
            // colEQUIP_CODE
            // 
            this.colEQUIP_CODE.Caption = "Mã Cũ";
            this.colEQUIP_CODE.FieldName = "EQUIP_CODE";
            this.colEQUIP_CODE.Name = "colEQUIP_CODE";
            this.colEQUIP_CODE.Width = 163;
            // 
            // colEQUIP_SPECIFICATION
            // 
            this.colEQUIP_SPECIFICATION.Caption = "Đặc điểm Thiết Bị - Thông Số Kỹ Thuật";
            this.colEQUIP_SPECIFICATION.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colEQUIP_SPECIFICATION.FieldName = "EQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Name = "colEQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Visible = true;
            this.colEQUIP_SPECIFICATION.VisibleIndex = 1;
            this.colEQUIP_SPECIFICATION.Width = 440;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colUNIT_MEASURE
            // 
            this.colUNIT_MEASURE.Caption = "Đơn Vị Tính";
            this.colUNIT_MEASURE.FieldName = "UNIT_MEASURE";
            this.colUNIT_MEASURE.Name = "colUNIT_MEASURE";
            this.colUNIT_MEASURE.Visible = true;
            this.colUNIT_MEASURE.VisibleIndex = 2;
            this.colUNIT_MEASURE.Width = 65;
            // 
            // colUNIT_MEASURE_END
            // 
            this.colUNIT_MEASURE_END.FieldName = "UNIT_MEASURE_END";
            this.colUNIT_MEASURE_END.Name = "colUNIT_MEASURE_END";
            this.colUNIT_MEASURE_END.Width = 106;
            // 
            // colQUANTITY
            // 
            this.colQUANTITY.AppearanceCell.Options.UseTextOptions = true;
            this.colQUANTITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQUANTITY.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQUANTITY.Caption = " Số lượng Tồn Kho";
            this.colQUANTITY.FieldName = "QUANTITY";
            this.colQUANTITY.Name = "colQUANTITY";
            this.colQUANTITY.Visible = true;
            this.colQUANTITY.VisibleIndex = 3;
            this.colQUANTITY.Width = 58;
            // 
            // colQUANTITY_BAK
            // 
            this.colQUANTITY_BAK.FieldName = "QUANTITY_BAK";
            this.colQUANTITY_BAK.Name = "colQUANTITY_BAK";
            this.colQUANTITY_BAK.Width = 106;
            // 
            // colACTIVE_STATUS
            // 
            this.colACTIVE_STATUS.FieldName = "ACTIVE_STATUS";
            this.colACTIVE_STATUS.Name = "colACTIVE_STATUS";
            this.colACTIVE_STATUS.Width = 106;
            // 
            // colSTOCK_TPM
            // 
            this.colSTOCK_TPM.Caption = "Vị Trí Kho";
            this.colSTOCK_TPM.FieldName = "STOCK_TPM";
            this.colSTOCK_TPM.Name = "colSTOCK_TPM";
            this.colSTOCK_TPM.Visible = true;
            this.colSTOCK_TPM.VisibleIndex = 5;
            this.colSTOCK_TPM.Width = 119;
            // 
            // colEQUIP_LIMIT_MIN
            // 
            this.colEQUIP_LIMIT_MIN.Caption = "Định mức";
            this.colEQUIP_LIMIT_MIN.FieldName = "EQUIP_LIMIT_MIN";
            this.colEQUIP_LIMIT_MIN.Name = "colEQUIP_LIMIT_MIN";
            this.colEQUIP_LIMIT_MIN.Visible = true;
            this.colEQUIP_LIMIT_MIN.VisibleIndex = 4;
            // 
            // colEQUIP_LIMIT_MAX
            // 
            this.colEQUIP_LIMIT_MAX.Caption = "Định Mức Max";
            this.colEQUIP_LIMIT_MAX.FieldName = "EQUIP_LIMIT_MAX";
            this.colEQUIP_LIMIT_MAX.Name = "colEQUIP_LIMIT_MAX";
            // 
            // colSUMALL
            // 
            this.colSUMALL.Caption = "TỔNG ĐANG MUA";
            this.colSUMALL.FieldName = "SUMALL";
            this.colSUMALL.Name = "colSUMALL";
            this.colSUMALL.Visible = true;
            this.colSUMALL.VisibleIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.dataGetAllEquipmentBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "Data_Get_AllEquipment_View_TonKho";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 32);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemSearchLookUpEdit3,
            this.repositoryItemSearchLookUpEdit4,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemMemoEdit1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(1233, 503);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1,
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnDelete,
            this.ghiNhanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 76);
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.btnEdit.Size = new System.Drawing.Size(192, 24);
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.btnDelete.Size = new System.Drawing.Size(192, 24);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ghiNhanToolStripMenuItem
            // 
            this.ghiNhanToolStripMenuItem.Name = "ghiNhanToolStripMenuItem";
            this.ghiNhanToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.ghiNhanToolStripMenuItem.Text = "Ghi Nhận Sự Cố";
            this.ghiNhanToolStripMenuItem.Click += new System.EventHandler(this.ghiNhanToolStripMenuItem_Click);
            // 
            // dataGetAllEquipmentBindingSource
            // 
            this.dataGetAllEquipmentBindingSource.DataMember = "Data_Get_AllEquipment";
            this.dataGetAllEquipmentBindingSource.DataSource = this.dataSet_Get_AllEquipment;
            // 
            // dataSet_Get_AllEquipment
            // 
            this.dataSet_Get_AllEquipment.DataSetName = "DataSet_Get_AllEquipment";
            this.dataSet_Get_AllEquipment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.LightCyan;
            this.bandedGridView1.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.bandedGridView1.AppearancePrint.OddRow.BackColor = System.Drawing.Color.GhostWhite;
            this.bandedGridView1.AppearancePrint.OddRow.Options.UseBackColor = true;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colIDEquipments,
            this.colIDDept,
            this.colIDGroupEQ,
            this.colEquipments,
            this.colIDGoods,
            this.colERPCode,
            this.colDescribes,
            this.colUnits,
            this.colSLDC,
            this.colSLDP,
            this.colSupplier,
            this.colRemarks,
            this.colNgayDuaVaoSuDung,
            this.colDAHUY,
            this.colNgayHuy,
            this.colHigh_Value,
            this.colEQUIP_LIMIT_MIN1,
            this.colQUANTITY1,
            this.colCheckEdit,
            this.bandedGridColumn1,
            this.bandedGridColumn2});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsCustomization.AllowSort = false;
            this.bandedGridView1.OptionsFind.AlwaysVisible = true;
            this.bandedGridView1.OptionsPrint.AutoWidth = false;
            this.bandedGridView1.OptionsPrint.EnableAppearanceEvenRow = true;
            this.bandedGridView1.OptionsPrint.EnableAppearanceOddRow = true;
            this.bandedGridView1.OptionsView.AllowCellMerge = true;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView1.OptionsView.RowAutoHeight = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.bandedGridView1_CustomDrawRowIndicator);
            this.bandedGridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bandedGridView1_RowCellStyle);
            this.bandedGridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.bandedGridView1_RowStyle);
            this.bandedGridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.bandedGridView1_ValidateRow);
            this.bandedGridView1.DoubleClick += new System.EventHandler(this.bandedGridView1_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colERPCode);
            this.gridBand1.Columns.Add(this.colIDEquipments);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 125;
            // 
            // colERPCode
            // 
            this.colERPCode.FieldName = "ERPCode";
            this.colERPCode.Name = "colERPCode";
            this.colERPCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colERPCode.Visible = true;
            this.colERPCode.Width = 125;
            // 
            // colIDEquipments
            // 
            this.colIDEquipments.FieldName = "IDEquipments";
            this.colIDEquipments.Name = "colIDEquipments";
            this.colIDEquipments.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.colIDGroupEQ);
            this.gridBand2.Columns.Add(this.colEquipments);
            this.gridBand2.Columns.Add(this.colIDGoods);
            this.gridBand2.Columns.Add(this.colUnits);
            this.gridBand2.Columns.Add(this.colDescribes);
            this.gridBand2.Columns.Add(this.colSLDC);
            this.gridBand2.Columns.Add(this.colSLDP);
            this.gridBand2.Columns.Add(this.colQUANTITY1);
            this.gridBand2.Columns.Add(this.colEQUIP_LIMIT_MIN1);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1176;
            // 
            // colIDGroupEQ
            // 
            this.colIDGroupEQ.Caption = "Cụm Thiết Bị";
            this.colIDGroupEQ.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colIDGroupEQ.FieldName = "Data_Get_AllEquipment_View_TonKho";
            this.colIDGroupEQ.Name = "colIDGroupEQ";
            this.colIDGroupEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIDGroupEQ.Visible = true;
            this.colIDGroupEQ.Width = 259;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemGridLookUpEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "2", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemGridLookUpEdit1.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Thêm cụm thiết bị", null, null, true)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.tblGroupEquipmentsBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "GroupEquipments";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "";
            this.repositoryItemGridLookUpEdit1.ValueMember = "IDGroupEQ";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemGridLookUpEdit1_ButtonClick);
            // 
            // tblGroupEquipmentsBindingSource
            // 
            this.tblGroupEquipmentsBindingSource.DataMember = "tblGroupEquipments";
            this.tblGroupEquipmentsBindingSource.DataSource = this.dataSet_Get_GroupEquiments;
            // 
            // dataSet_Get_GroupEquiments
            // 
            this.dataSet_Get_GroupEquiments.DataSetName = "DataSet_Get_GroupEquiments";
            this.dataSet_Get_GroupEquiments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "IDGroupEQ";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "GroupEquipments";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // colEquipments
            // 
            this.colEquipments.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colEquipments.AppearanceCell.Options.UseBorderColor = true;
            this.colEquipments.Caption = "Thiết Bị";
            this.colEquipments.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colEquipments.FieldName = "Equipments";
            this.colEquipments.Name = "colEquipments";
            this.colEquipments.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEquipments.Visible = true;
            this.colEquipments.Width = 237;
            // 
            // colIDGoods
            // 
            this.colIDGoods.Caption = "Nhóm Thiết Bị";
            this.colIDGoods.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colIDGoods.FieldName = "IDGoods";
            this.colIDGoods.Name = "colIDGoods";
            this.colIDGoods.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIDGoods.Visible = true;
            this.colIDGoods.Width = 72;
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemGridLookUpEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "2", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Thêm Loại Thiết Bị", null, null, true)});
            this.repositoryItemGridLookUpEdit2.DataSource = this.dataTable1BindingSource;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "Goods";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.NullText = "";
            this.repositoryItemGridLookUpEdit2.ValueMember = "IDGoods";
            this.repositoryItemGridLookUpEdit2.View = this.repositoryItemGridLookUpEdit2View;
            this.repositoryItemGridLookUpEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemGridLookUpEdit2_ButtonClick);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet_Get_Goods;
            // 
            // dataSet_Get_Goods
            // 
            this.dataSet_Get_Goods.DataSetName = "DataSet_Get_Goods";
            this.dataSet_Get_Goods.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "IDGoods";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Loại Thiết Bị";
            this.gridColumn9.FieldName = "Goods";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // colUnits
            // 
            this.colUnits.Caption = "Đơn Vị Tính";
            this.colUnits.FieldName = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnits.Visible = true;
            this.colUnits.Width = 62;
            // 
            // colDescribes
            // 
            this.colDescribes.Caption = "Thông số Kỹ Thuật";
            this.colDescribes.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescribes.FieldName = "Describes";
            this.colDescribes.Name = "colDescribes";
            this.colDescribes.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDescribes.Visible = true;
            this.colDescribes.Width = 251;
            // 
            // colSLDC
            // 
            this.colSLDC.AppearanceCell.Options.UseTextOptions = true;
            this.colSLDC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSLDC.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSLDC.Caption = "Số Lượng Dây Chuyền";
            this.colSLDC.FieldName = "SLDC";
            this.colSLDC.Name = "colSLDC";
            this.colSLDC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSLDC.Visible = true;
            this.colSLDC.Width = 77;
            // 
            // colSLDP
            // 
            this.colSLDP.AppearanceCell.Options.UseTextOptions = true;
            this.colSLDP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSLDP.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSLDP.Caption = "Dự phòng";
            this.colSLDP.FieldName = "SLDP";
            this.colSLDP.Name = "colSLDP";
            this.colSLDP.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSLDP.Visible = true;
            this.colSLDP.Width = 68;
            // 
            // colQUANTITY1
            // 
            this.colQUANTITY1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colQUANTITY1.AppearanceCell.Options.UseForeColor = true;
            this.colQUANTITY1.AppearanceCell.Options.UseTextOptions = true;
            this.colQUANTITY1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colQUANTITY1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colQUANTITY1.Caption = "Số Lượng Tồn";
            this.colQUANTITY1.FieldName = "QUANTITY";
            this.colQUANTITY1.Name = "colQUANTITY1";
            this.colQUANTITY1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQUANTITY1.Visible = true;
            // 
            // colEQUIP_LIMIT_MIN1
            // 
            this.colEQUIP_LIMIT_MIN1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colEQUIP_LIMIT_MIN1.AppearanceCell.Options.UseForeColor = true;
            this.colEQUIP_LIMIT_MIN1.AppearanceCell.Options.UseTextOptions = true;
            this.colEQUIP_LIMIT_MIN1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEQUIP_LIMIT_MIN1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colEQUIP_LIMIT_MIN1.Caption = "Định Mức";
            this.colEQUIP_LIMIT_MIN1.FieldName = "EQUIP_LIMIT_MIN";
            this.colEQUIP_LIMIT_MIN1.Name = "colEQUIP_LIMIT_MIN1";
            this.colEQUIP_LIMIT_MIN1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEQUIP_LIMIT_MIN1.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Columns.Add(this.colSupplier);
            this.gridBand3.Columns.Add(this.colRemarks);
            this.gridBand3.Columns.Add(this.colIDDept);
            this.gridBand3.Columns.Add(this.colHigh_Value);
            this.gridBand3.Columns.Add(this.colNgayDuaVaoSuDung);
            this.gridBand3.Columns.Add(this.colDAHUY);
            this.gridBand3.Columns.Add(this.colNgayHuy);
            this.gridBand3.Columns.Add(this.colCheckEdit);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 958;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Xuất Xứ";
            this.colSupplier.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSupplier.Visible = true;
            this.colSupplier.Width = 144;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "Ghi Chú";
            this.colRemarks.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRemarks.Visible = true;
            this.colRemarks.Width = 210;
            // 
            // colIDDept
            // 
            this.colIDDept.Caption = "Dây Chuyền";
            this.colIDDept.ColumnEdit = this.repositoryItemSearchLookUpEdit2;
            this.colIDDept.FieldName = "IDDept";
            this.colIDDept.Name = "colIDDept";
            this.colIDDept.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIDDept.Visible = true;
            this.colIDDept.Width = 139;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.DataSource = this.dataGetDeptBindingSource;
            this.repositoryItemSearchLookUpEdit2.DisplayMember = "Department";
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.NullText = "";
            this.repositoryItemSearchLookUpEdit2.ValueMember = "IDDepartment";
            this.repositoryItemSearchLookUpEdit2.View = this.repositoryItemSearchLookUpEdit2View;
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
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IDDepartment";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Department";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "ShortName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // colHigh_Value
            // 
            this.colHigh_Value.Caption = "Gía trị cao";
            this.colHigh_Value.FieldName = "High_Value";
            this.colHigh_Value.Name = "colHigh_Value";
            this.colHigh_Value.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colHigh_Value.Visible = true;
            this.colHigh_Value.Width = 62;
            // 
            // colNgayDuaVaoSuDung
            // 
            this.colNgayDuaVaoSuDung.Caption = "Ngày Đưa Vào sử dụng";
            this.colNgayDuaVaoSuDung.FieldName = "NgayDuaVaoSuDung";
            this.colNgayDuaVaoSuDung.Name = "colNgayDuaVaoSuDung";
            this.colNgayDuaVaoSuDung.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayDuaVaoSuDung.Visible = true;
            this.colNgayDuaVaoSuDung.Width = 129;
            // 
            // colDAHUY
            // 
            this.colDAHUY.Caption = "Đã Hủy";
            this.colDAHUY.FieldName = "DAHUY";
            this.colDAHUY.Name = "colDAHUY";
            this.colDAHUY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDAHUY.Visible = true;
            this.colDAHUY.Width = 52;
            // 
            // colNgayHuy
            // 
            this.colNgayHuy.Caption = "Ngày Hủy";
            this.colNgayHuy.FieldName = "NgayHuy";
            this.colNgayHuy.Name = "colNgayHuy";
            this.colNgayHuy.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayHuy.Visible = true;
            this.colNgayHuy.Width = 147;
            // 
            // colCheckEdit
            // 
            this.colCheckEdit.Caption = "Kiểm Tra Chỉnh Sửa";
            this.colCheckEdit.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colCheckEdit.FieldName = "CheckEdit";
            this.colCheckEdit.Name = "colCheckEdit";
            this.colCheckEdit.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colCheckEdit.Visible = true;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.EditValueChanged += new System.EventHandler(this.repositoryItemCheckEdit2_EditValueChanged);
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
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
            this.btnAdd,
            this.btnSave,
            this.btnExcel});
            this.barManager1.MaxItemId = 5;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.txtDept, "", false, true, true, 153),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // txtDept
            // 
            this.txtDept.Caption = "barEditItem1";
            this.txtDept.Edit = this.repositoryItemSearchLookUpEdit1;
            this.txtDept.Id = 0;
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
            this.btnFresh.Caption = "Làm mới";
            this.btnFresh.Id = 1;
            this.btnFresh.ImageIndex = 0;
            this.btnFresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFresh_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 2;
            this.btnAdd.ImageIndex = 1;
            this.btnAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 3;
            this.btnSave.ImageIndex = 2;
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Xuất Excel";
            this.btnExcel.Id = 4;
            this.btnExcel.ImageIndex = 5;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1233, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 535);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1233, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 503);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1233, 32);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 503);
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
            // 
            // repositoryItemSearchLookUpEdit3
            // 
            this.repositoryItemSearchLookUpEdit3.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit3.DataSource = this.tblGroupEquipmentsBindingSource;
            this.repositoryItemSearchLookUpEdit3.DisplayMember = "GroupEquipments";
            this.repositoryItemSearchLookUpEdit3.Name = "repositoryItemSearchLookUpEdit3";
            this.repositoryItemSearchLookUpEdit3.NullText = "";
            this.repositoryItemSearchLookUpEdit3.ValueMember = "IDGroupEQ";
            this.repositoryItemSearchLookUpEdit3.View = this.repositoryItemSearchLookUpEdit3View;
            // 
            // repositoryItemSearchLookUpEdit3View
            // 
            this.repositoryItemSearchLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.colGroupEquipments});
            this.repositoryItemSearchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit3View.Name = "repositoryItemSearchLookUpEdit3View";
            this.repositoryItemSearchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "IDGroupEQ";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // colGroupEquipments
            // 
            this.colGroupEquipments.FieldName = "GroupEquipments";
            this.colGroupEquipments.Name = "colGroupEquipments";
            this.colGroupEquipments.Visible = true;
            this.colGroupEquipments.VisibleIndex = 0;
            // 
            // repositoryItemSearchLookUpEdit4
            // 
            this.repositoryItemSearchLookUpEdit4.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit4.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.repositoryItemSearchLookUpEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.repositoryItemSearchLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "2", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "Thêm Nhóm Thiết Bị", null, null, true)});
            this.repositoryItemSearchLookUpEdit4.DataSource = this.dataTable1BindingSource;
            this.repositoryItemSearchLookUpEdit4.DisplayMember = "Goods";
            this.repositoryItemSearchLookUpEdit4.Name = "repositoryItemSearchLookUpEdit4";
            this.repositoryItemSearchLookUpEdit4.NullText = "";
            this.repositoryItemSearchLookUpEdit4.ValueMember = "IDGoods";
            this.repositoryItemSearchLookUpEdit4.View = this.repositoryItemSearchLookUpEdit4View;
            // 
            // repositoryItemSearchLookUpEdit4View
            // 
            this.repositoryItemSearchLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.colGoods});
            this.repositoryItemSearchLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit4View.Name = "repositoryItemSearchLookUpEdit4View";
            this.repositoryItemSearchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IDGoods";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // colGoods
            // 
            this.colGoods.FieldName = "Goods";
            this.colGoods.Name = "colGoods";
            this.colGoods.Visible = true;
            this.colGoods.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // data_Get_DeptTableAdapter
            // 
            this.data_Get_DeptTableAdapter.ClearBeforeFill = true;
            // 
            // data_Get_AllEquipmentTableAdapter
            // 
            this.data_Get_AllEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // view_TonKhoTableAdapter
            // 
            this.view_TonKhoTableAdapter.ClearBeforeFill = true;
            // 
            // tblGroupEquipmentsTableAdapter
            // 
            this.tblGroupEquipmentsTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // _HS_QuanLyBaoTriDataSet1
            // 
            this._HS_QuanLyBaoTriDataSet1.DataSetName = "_HS_QuanLyBaoTriDataSet";
            this._HS_QuanLyBaoTriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 535);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEquipments";
            this.Text = " Thiết Bị Trên Các Dây Chuyền";
            this.Load += new System.EventHandler(this.frmEquipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGetAllEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_AllEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_GroupEquiments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Goods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._HS_QuanLyBaoTriDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraBars.BarEditItem txtDept;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private System.Windows.Forms.BindingSource dataGetDeptBindingSource;
        private DataSet.DataSet_Dept dataSet_Dept;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter data_Get_DeptTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnFresh;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIDEquipments;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIDDept;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIDGroupEQ;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEquipments;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIDGoods;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colERPCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescribes;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnits;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSLDC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSLDP;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSupplier;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRemarks;
        private System.Windows.Forms.BindingSource dataGetAllEquipmentBindingSource;
        private DataSet.DataSet_Get_AllEquipment dataSet_Get_AllEquipment;
        private DevExpress.XtraGrid.Columns.GridColumn colMACHINE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_SPECIFICATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_MEASURE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_MEASURE_END;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANTITY_BAK;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVE_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_TPM;
        private DataSet.DataSet_Get_AllEquipmentTableAdapters.Data_Get_AllEquipmentTableAdapter data_Get_AllEquipmentTableAdapter;
        private DataSet.DataSet_Get_AllEquipmentTableAdapters.View_TonKhoTableAdapter view_TonKhoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit3;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit3View;
        private DataSet.DataSet_Get_GroupEquiments dataSet_Get_GroupEquiments;
        private System.Windows.Forms.BindingSource tblGroupEquipmentsBindingSource;
        private DataSet.DataSet_Get_GroupEquimentsTableAdapters.tblGroupEquipmentsTableAdapter tblGroupEquipmentsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupEquipments;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit4;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit4View;
        private DataSet.DataSet_Get_Goods dataSet_Get_Goods;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet.DataSet_Get_GoodsTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colGoods;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayDuaVaoSuDung;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDAHUY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNgayHuy;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHigh_Value;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_LIMIT_MIN;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_LIMIT_MAX;
        private DevExpress.XtraGrid.Columns.GridColumn colSUMALL;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQUANTITY1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEQUIP_LIMIT_MIN1;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCheckEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.ToolStripMenuItem ghiNhanToolStripMenuItem;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private _HS_QuanLyBaoTriDataSet _HS_QuanLyBaoTriDataSet1;
    }
}