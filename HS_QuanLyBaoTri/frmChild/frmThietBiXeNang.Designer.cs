namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmThietBiXeNang
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThietBiXeNang));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACHINE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_SPECIFICATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_MEASURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_MEASURE_END = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANTITY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANTITY_BAK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACTIVE_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOCK_TPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_LIMIT_MIN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_LIMIT_MAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUMALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGetEquipmentsForkliftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_EqForklifts = new HS_QuanLyBaoTri.DataSet.DataSet_Get_EqForklifts();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colIDEquipments_Forklifts = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGroupEQForklifts1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.tblGroupEquipForkliftsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_GroupForklifts = new HS_QuanLyBaoTri.DataSet.DataSet_Get_GroupForklifts();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKind_Forfilts = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLocation = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colERPCODE = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEquipments_Forfilts = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colDescribes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colQUANTITY = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEQUIP_LIMIT_MIN = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colDescribes_Change = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSupplier_Change = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colRemarks = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.txtGroupFL = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.tblGroupEquipForkliftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDGroupFL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupEQForklifts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaste = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.tblGroupEquip_ForkliftsTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_GroupForkliftsTableAdapters.tblGroupEquip_ForkliftsTableAdapter();
            this.data_Get_Equipments_ForkliftsTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_EqForkliftsTableAdapters.Data_Get_Equipments_ForkliftsTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_EqForkliftsTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetEquipmentsForkliftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_EqForklifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipForkliftsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_GroupForklifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipForkliftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACHINE_CODE,
            this.colEQUIP_CODE,
            this.colEQUIP_SPECIFICATION,
            this.colUNIT_MEASURE,
            this.colUNIT_MEASURE_END,
            this.colQUANTITY1,
            this.colQUANTITY_BAK,
            this.colACTIVE_STATUS,
            this.colSTOCK_TPM,
            this.colEQUIP_LIMIT_MIN1,
            this.colEQUIP_LIMIT_MAX,
            this.colSUMALL});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMACHINE_CODE
            // 
            this.colMACHINE_CODE.Caption = "Mã ERP";
            this.colMACHINE_CODE.FieldName = "MACHINE_CODE";
            this.colMACHINE_CODE.Name = "colMACHINE_CODE";
            this.colMACHINE_CODE.Visible = true;
            this.colMACHINE_CODE.VisibleIndex = 0;
            this.colMACHINE_CODE.Width = 97;
            // 
            // colEQUIP_CODE
            // 
            this.colEQUIP_CODE.FieldName = "EQUIP_CODE";
            this.colEQUIP_CODE.Name = "colEQUIP_CODE";
            // 
            // colEQUIP_SPECIFICATION
            // 
            this.colEQUIP_SPECIFICATION.Caption = "TÊN THIẾT BỊ TRONG KHO";
            this.colEQUIP_SPECIFICATION.FieldName = "EQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Name = "colEQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Visible = true;
            this.colEQUIP_SPECIFICATION.VisibleIndex = 1;
            this.colEQUIP_SPECIFICATION.Width = 309;
            // 
            // colUNIT_MEASURE
            // 
            this.colUNIT_MEASURE.Caption = "ĐVT";
            this.colUNIT_MEASURE.FieldName = "UNIT_MEASURE";
            this.colUNIT_MEASURE.Name = "colUNIT_MEASURE";
            this.colUNIT_MEASURE.Visible = true;
            this.colUNIT_MEASURE.VisibleIndex = 2;
            this.colUNIT_MEASURE.Width = 56;
            // 
            // colUNIT_MEASURE_END
            // 
            this.colUNIT_MEASURE_END.FieldName = "UNIT_MEASURE_END";
            this.colUNIT_MEASURE_END.Name = "colUNIT_MEASURE_END";
            this.colUNIT_MEASURE_END.Width = 91;
            // 
            // colQUANTITY1
            // 
            this.colQUANTITY1.Caption = "SỐ LƯỢNG TỒN";
            this.colQUANTITY1.FieldName = "QUANTITY";
            this.colQUANTITY1.Name = "colQUANTITY1";
            this.colQUANTITY1.Visible = true;
            this.colQUANTITY1.VisibleIndex = 3;
            this.colQUANTITY1.Width = 71;
            // 
            // colQUANTITY_BAK
            // 
            this.colQUANTITY_BAK.FieldName = "QUANTITY_BAK";
            this.colQUANTITY_BAK.Name = "colQUANTITY_BAK";
            this.colQUANTITY_BAK.Width = 91;
            // 
            // colACTIVE_STATUS
            // 
            this.colACTIVE_STATUS.FieldName = "ACTIVE_STATUS";
            this.colACTIVE_STATUS.Name = "colACTIVE_STATUS";
            this.colACTIVE_STATUS.Width = 91;
            // 
            // colSTOCK_TPM
            // 
            this.colSTOCK_TPM.Caption = " TÊN KHO";
            this.colSTOCK_TPM.FieldName = "STOCK_TPM";
            this.colSTOCK_TPM.Name = "colSTOCK_TPM";
            this.colSTOCK_TPM.Visible = true;
            this.colSTOCK_TPM.VisibleIndex = 4;
            this.colSTOCK_TPM.Width = 95;
            // 
            // colEQUIP_LIMIT_MIN1
            // 
            this.colEQUIP_LIMIT_MIN1.Caption = "ĐỊNH MỨC";
            this.colEQUIP_LIMIT_MIN1.FieldName = "EQUIP_LIMIT_MIN";
            this.colEQUIP_LIMIT_MIN1.Name = "colEQUIP_LIMIT_MIN1";
            this.colEQUIP_LIMIT_MIN1.Visible = true;
            this.colEQUIP_LIMIT_MIN1.VisibleIndex = 5;
            this.colEQUIP_LIMIT_MIN1.Width = 91;
            // 
            // colEQUIP_LIMIT_MAX
            // 
            this.colEQUIP_LIMIT_MAX.FieldName = "EQUIP_LIMIT_MAX";
            this.colEQUIP_LIMIT_MAX.Name = "colEQUIP_LIMIT_MAX";
            this.colEQUIP_LIMIT_MAX.Width = 91;
            // 
            // colSUMALL
            // 
            this.colSUMALL.Caption = "SỐ LƯỢNG ĐANG MUA VỀ";
            this.colSUMALL.FieldName = "SUMALL";
            this.colSUMALL.Name = "colSUMALL";
            this.colSUMALL.Visible = true;
            this.colSUMALL.VisibleIndex = 6;
            this.colSUMALL.Width = 103;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.dataGetEquipmentsForkliftsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Data_Get_Equipments_Forklifts_DataTable1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemSearchLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(997, 352);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1,
            this.gridView2});
            // 
            // dataGetEquipmentsForkliftsBindingSource
            // 
            this.dataGetEquipmentsForkliftsBindingSource.DataMember = "Data_Get_Equipments_Forklifts";
            this.dataGetEquipmentsForkliftsBindingSource.DataSource = this.dataSet_Get_EqForklifts;
            // 
            // dataSet_Get_EqForklifts
            // 
            this.dataSet_Get_EqForklifts.DataSetName = "DataSet_Get_EqForklifts";
            this.dataSet_Get_EqForklifts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand4,
            this.gridBand2,
            this.gridBand3});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colIDEquipments_Forklifts,
            this.colGroupEQForklifts1,
            this.colKind_Forfilts,
            this.colLocation,
            this.colERPCODE,
            this.colEquipments_Forfilts,
            this.colDescribes,
            this.colSupplier,
            this.colDescribes_Change,
            this.colSupplier_Change,
            this.colQUANTITY,
            this.colEQUIP_LIMIT_MIN,
            this.colRemarks});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.AllowCellMerge = true;
            this.bandedGridView1.OptionsView.ColumnAutoWidth = false;
            this.bandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.bandedGridView1.OptionsView.RowAutoHeight = true;
            this.bandedGridView1.OptionsView.ShowFooter = true;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.bandedGridView1_CustomDrawRowIndicator);
            this.bandedGridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bandedGridView1_RowCellStyle);
            this.bandedGridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.bandedGridView1_ValidateRow);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand1.Caption = "Thông Tin Thiết Bị";
            this.gridBand1.Columns.Add(this.colIDEquipments_Forklifts);
            this.gridBand1.Columns.Add(this.colGroupEQForklifts1);
            this.gridBand1.Columns.Add(this.colKind_Forfilts);
            this.gridBand1.Columns.Add(this.colLocation);
            this.gridBand1.Columns.Add(this.colERPCODE);
            this.gridBand1.Columns.Add(this.colEquipments_Forfilts);
            this.gridBand1.Columns.Add(this.colDescribes);
            this.gridBand1.Columns.Add(this.colSupplier);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 845;
            // 
            // colIDEquipments_Forklifts
            // 
            this.colIDEquipments_Forklifts.FieldName = "IDEquipments_Forklifts";
            this.colIDEquipments_Forklifts.Name = "colIDEquipments_Forklifts";
            this.colIDEquipments_Forklifts.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colIDEquipments_Forklifts.Width = 82;
            // 
            // colGroupEQForklifts1
            // 
            this.colGroupEQForklifts1.Caption = "Nhóm Phụ Tùng";
            this.colGroupEQForklifts1.ColumnEdit = this.repositoryItemSearchLookUpEdit2;
            this.colGroupEQForklifts1.FieldName = "IDGroupFL";
            this.colGroupEQForklifts1.Name = "colGroupEQForklifts1";
            this.colGroupEQForklifts1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colGroupEQForklifts1.OptionsColumn.ReadOnly = true;
            this.colGroupEQForklifts1.Visible = true;
            this.colGroupEQForklifts1.Width = 101;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.DataSource = this.tblGroupEquipForkliftsBindingSource1;
            this.repositoryItemSearchLookUpEdit2.DisplayMember = "GroupEQForklifts";
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.ValueMember = "IDGroupFL";
            this.repositoryItemSearchLookUpEdit2.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // tblGroupEquipForkliftsBindingSource1
            // 
            this.tblGroupEquipForkliftsBindingSource1.DataMember = "tblGroupEquip_Forklifts";
            this.tblGroupEquipForkliftsBindingSource1.DataSource = this.dataSet_Get_GroupForklifts;
            // 
            // dataSet_Get_GroupForklifts
            // 
            this.dataSet_Get_GroupForklifts.DataSetName = "DataSet_Get_GroupForklifts";
            this.dataSet_Get_GroupForklifts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colKind_Forfilts
            // 
            this.colKind_Forfilts.Caption = "Chủng Loại Xe";
            this.colKind_Forfilts.FieldName = "Kind_Forfilts";
            this.colKind_Forfilts.Name = "colKind_Forfilts";
            this.colKind_Forfilts.Visible = true;
            this.colKind_Forfilts.Width = 139;
            // 
            // colLocation
            // 
            this.colLocation.Caption = "Vị Trí Lắp Đặt";
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colLocation.Visible = true;
            this.colLocation.Width = 105;
            // 
            // colERPCODE
            // 
            this.colERPCODE.Caption = "Mã ERP";
            this.colERPCODE.FieldName = "ERPCODE";
            this.colERPCODE.Name = "colERPCODE";
            this.colERPCODE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colERPCODE.Visible = true;
            this.colERPCODE.Width = 96;
            // 
            // colEquipments_Forfilts
            // 
            this.colEquipments_Forfilts.Caption = "Tên Thiết bị - Phụ Tùng";
            this.colEquipments_Forfilts.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colEquipments_Forfilts.FieldName = "Equipments_Forfilts";
            this.colEquipments_Forfilts.Name = "colEquipments_Forfilts";
            this.colEquipments_Forfilts.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEquipments_Forfilts.Visible = true;
            this.colEquipments_Forfilts.Width = 145;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colDescribes
            // 
            this.colDescribes.Caption = "Quy Cách Theo Xe";
            this.colDescribes.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescribes.FieldName = "Describes";
            this.colDescribes.Name = "colDescribes";
            this.colDescribes.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDescribes.Visible = true;
            this.colDescribes.Width = 168;
            // 
            // colSupplier
            // 
            this.colSupplier.Caption = "Hãng Sản Xuất - Xuất Xứ";
            this.colSupplier.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSupplier.Visible = true;
            this.colSupplier.Width = 91;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand4.Caption = "Tồn - Định Mức";
            this.gridBand4.Columns.Add(this.colQUANTITY);
            this.gridBand4.Columns.Add(this.colEQUIP_LIMIT_MIN);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 1;
            this.gridBand4.Width = 143;
            // 
            // colQUANTITY
            // 
            this.colQUANTITY.Caption = "Số lượng Tồn";
            this.colQUANTITY.FieldName = "QUANTITY";
            this.colQUANTITY.Name = "colQUANTITY";
            this.colQUANTITY.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colQUANTITY.OptionsColumn.ReadOnly = true;
            this.colQUANTITY.Visible = true;
            this.colQUANTITY.Width = 70;
            // 
            // colEQUIP_LIMIT_MIN
            // 
            this.colEQUIP_LIMIT_MIN.Caption = "Định mức";
            this.colEQUIP_LIMIT_MIN.FieldName = "EQUIP_LIMIT_MIN";
            this.colEQUIP_LIMIT_MIN.Name = "colEQUIP_LIMIT_MIN";
            this.colEQUIP_LIMIT_MIN.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colEQUIP_LIMIT_MIN.OptionsColumn.ReadOnly = true;
            this.colEQUIP_LIMIT_MIN.Visible = true;
            this.colEQUIP_LIMIT_MIN.Width = 73;
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridBand2.Caption = "Thông Tin Thay Thế";
            this.gridBand2.Columns.Add(this.colDescribes_Change);
            this.gridBand2.Columns.Add(this.colSupplier_Change);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 2;
            this.gridBand2.Width = 265;
            // 
            // colDescribes_Change
            // 
            this.colDescribes_Change.Caption = "Quy Cách Thay Thế";
            this.colDescribes_Change.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colDescribes_Change.FieldName = "Describes_Change";
            this.colDescribes_Change.Name = "colDescribes_Change";
            this.colDescribes_Change.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDescribes_Change.Visible = true;
            this.colDescribes_Change.Width = 164;
            // 
            // colSupplier_Change
            // 
            this.colSupplier_Change.Caption = "Hãng SX- XXứ Thay thế";
            this.colSupplier_Change.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colSupplier_Change.FieldName = "Supplier_Change";
            this.colSupplier_Change.Name = "colSupplier_Change";
            this.colSupplier_Change.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSupplier_Change.Visible = true;
            this.colSupplier_Change.Width = 101;
            // 
            // gridBand3
            // 
            this.gridBand3.Columns.Add(this.colRemarks);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 3;
            this.gridBand3.Width = 192;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "Ghi Chú";
            this.colRemarks.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRemarks.Visible = true;
            this.colRemarks.Width = 192;
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
            this.txtGroupFL,
            this.btnFresh,
            this.btnAdd,
            this.btnSave,
            this.btnPaste,
            this.btnExcel});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.txtGroupFL, "", false, true, true, 153),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnFresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPaste, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // txtGroupFL
            // 
            this.txtGroupFL.Caption = "barEditItem1";
            this.txtGroupFL.Edit = this.repositoryItemSearchLookUpEdit1;
            this.txtGroupFL.Id = 0;
            this.txtGroupFL.Name = "txtGroupFL";
            this.txtGroupFL.EditValueChanged += new System.EventHandler(this.txtGroupFL_EditValueChanged);
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "2", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Thêm Nhóm Phụ Tùng", null, null, true)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.tblGroupEquipForkliftsBindingSource;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "GroupEQForklifts";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.NullText = "";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "IDGroupFL";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView1;
            this.repositoryItemSearchLookUpEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemSearchLookUpEdit1_ButtonClick);
            // 
            // tblGroupEquipForkliftsBindingSource
            // 
            this.tblGroupEquipForkliftsBindingSource.DataMember = "tblGroupEquip_Forklifts";
            this.tblGroupEquipForkliftsBindingSource.DataSource = this.dataSet_Get_GroupForklifts;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDGroupFL,
            this.colGroupEQForklifts,
            this.colUserCreate});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIDGroupFL
            // 
            this.colIDGroupFL.FieldName = "IDGroupFL";
            this.colIDGroupFL.Name = "colIDGroupFL";
            // 
            // colGroupEQForklifts
            // 
            this.colGroupEQForklifts.Caption = "Nhóm Thiết Bị";
            this.colGroupEQForklifts.FieldName = "GroupEQForklifts";
            this.colGroupEQForklifts.Name = "colGroupEQForklifts";
            this.colGroupEQForklifts.Visible = true;
            this.colGroupEQForklifts.VisibleIndex = 0;
            this.colGroupEQForklifts.Width = 459;
            // 
            // colUserCreate
            // 
            this.colUserCreate.FieldName = "UserCreate";
            this.colUserCreate.Name = "colUserCreate";
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
            this.btnAdd.Caption = "Thêm (Ctrl+N)";
            this.btnAdd.Id = 2;
            this.btnAdd.ImageIndex = 1;
            this.btnAdd.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnPaste
            // 
            this.btnPaste.Caption = "Dán (Ctrl+V)";
            this.btnPaste.Id = 4;
            this.btnPaste.ImageIndex = 6;
            this.btnPaste.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPaste_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu (Ctrl+S)";
            this.btnSave.Id = 3;
            this.btnSave.ImageIndex = 2;
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Xuất Excel";
            this.btnExcel.Id = 5;
            this.btnExcel.ImageIndex = 5;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(997, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 383);
            this.barDockControlBottom.Size = new System.Drawing.Size(997, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 352);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(997, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 352);
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
            this.imageCollection1.Images.SetKeyName(6, "Paste_16x16.png");
            // 
            // tblGroupEquip_ForkliftsTableAdapter
            // 
            this.tblGroupEquip_ForkliftsTableAdapter.ClearBeforeFill = true;
            // 
            // data_Get_Equipments_ForkliftsTableAdapter
            // 
            this.data_Get_Equipments_ForkliftsTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editToolStripMenuItem.Text = "Chỉnh Sửa";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteToolStripMenuItem.Text = "Xóa ";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet_Get_EqForklifts;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // frmThietBiXeNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 383);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmThietBiXeNang";
            this.Text = "Theo Dõi Thiết Bị Xe Nâng";
            this.Load += new System.EventHandler(this.frmThietBiXeNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetEquipmentsForkliftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_EqForklifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipForkliftsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_GroupForklifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipForkliftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem txtGroupFL;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnFresh;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnPaste;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DataSet.DataSet_Get_GroupForklifts dataSet_Get_GroupForklifts;
        private System.Windows.Forms.BindingSource tblGroupEquipForkliftsBindingSource;
        private DataSet.DataSet_Get_GroupForkliftsTableAdapters.tblGroupEquip_ForkliftsTableAdapter tblGroupEquip_ForkliftsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDGroupFL;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupEQForklifts;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private System.Windows.Forms.BindingSource dataGetEquipmentsForkliftsBindingSource;
        private DataSet.DataSet_Get_EqForklifts dataSet_Get_EqForklifts;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colIDEquipments_Forklifts;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGroupEQForklifts1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKind_Forfilts;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLocation;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colERPCODE;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEquipments_Forfilts;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescribes;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSupplier;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDescribes_Change;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSupplier_Change;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colQUANTITY;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEQUIP_LIMIT_MIN;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRemarks;
        private DataSet.DataSet_Get_EqForkliftsTableAdapters.Data_Get_Equipments_ForkliftsTableAdapter data_Get_Equipments_ForkliftsTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMACHINE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_SPECIFICATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_MEASURE;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_MEASURE_END;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANTITY1;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANTITY_BAK;
        private DevExpress.XtraGrid.Columns.GridColumn colACTIVE_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_TPM;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_LIMIT_MIN1;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_LIMIT_MAX;
        private DevExpress.XtraGrid.Columns.GridColumn colSUMALL;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet.DataSet_Get_EqForkliftsTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private System.Windows.Forms.BindingSource tblGroupEquipForkliftsBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
    }
}