﻿namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmNhapKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapKho));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnView1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.fromDate = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGetNhapKhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_NhapKho = new HS_QuanLyBaoTri.DataSet.DataSet_Get_NhapKho();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVOUCHER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colDATE_IMPORT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colERP_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEQUIP_SPECIFICATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNIT_MEASURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQUANTITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.colSTOCK_TPM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUPPLIER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPT_ORDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_NhapKhoTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_NhapKhoTableAdapters.Data_Get_NhapKhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetNhapKhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_NhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.LightCyan;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Left;
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnView1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.toDate);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.fromDate);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1358, 28);
            this.groupControl1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(506, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập Nhật Nhập Kho";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView1
            // 
            this.btnView1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnView1.Image = ((System.Drawing.Image)(resources.GetObject("btnView1.Image")));
            this.btnView1.Location = new System.Drawing.Point(425, 2);
            this.btnView1.Name = "btnView1";
            this.btnView1.Size = new System.Drawing.Size(75, 23);
            this.btnView1.TabIndex = 6;
            this.btnView1.Text = "XEM";
            this.btnView1.Click += new System.EventHandler(this.btnView1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(217, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Đến ngày:";
            // 
            // toDate
            // 
            this.toDate.EditValue = null;
            this.toDate.Location = new System.Drawing.Point(274, 4);
            this.toDate.Name = "toDate";
            this.toDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.toDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.toDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "dd-MM-yyyy";
            this.toDate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.toDate.Size = new System.Drawing.Size(145, 22);
            this.toDate.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Từ ngày:";
            // 
            // fromDate
            // 
            this.fromDate.EditValue = null;
            this.fromDate.Location = new System.Drawing.Point(79, 3);
            this.fromDate.Name = "fromDate";
            this.fromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDate.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.fromDate.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fromDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "dd-MM-yyyy";
            this.fromDate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fromDate.Size = new System.Drawing.Size(132, 22);
            this.fromDate.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataGetNhapKhoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemCalcEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1358, 607);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataGetNhapKhoBindingSource
            // 
            this.dataGetNhapKhoBindingSource.DataMember = "Data_Get_NhapKho";
            this.dataGetNhapKhoBindingSource.DataSource = this.dataSet_Get_NhapKho;
            // 
            // dataSet_Get_NhapKho
            // 
            this.dataSet_Get_NhapKho.DataSetName = "DataSet_Get_NhapKho";
            this.dataSet_Get_NhapKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colVOUCHER,
            this.colDATE_IMPORT,
            this.colERP_CODE,
            this.colEQUIP_SPECIFICATION,
            this.colUNIT_MEASURE,
            this.colQUANTITY,
            this.colSTOCK_TPM,
            this.colSUPPLIER,
            this.colDEPT_ORDER});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colVOUCHER
            // 
            this.colVOUCHER.Caption = "Phiếu Nhập Kho";
            this.colVOUCHER.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colVOUCHER.FieldName = "VOUCHER";
            this.colVOUCHER.Name = "colVOUCHER";
            this.colVOUCHER.Visible = true;
            this.colVOUCHER.VisibleIndex = 0;
            this.colVOUCHER.Width = 99;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colDATE_IMPORT
            // 
            this.colDATE_IMPORT.Caption = "Ngày Nhập Kho";
            this.colDATE_IMPORT.ColumnEdit = this.repositoryItemDateEdit1;
            this.colDATE_IMPORT.FieldName = "DATE_IMPORT";
            this.colDATE_IMPORT.Name = "colDATE_IMPORT";
            this.colDATE_IMPORT.Visible = true;
            this.colDATE_IMPORT.VisibleIndex = 1;
            this.colDATE_IMPORT.Width = 111;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd-MM-yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd-MM-yyyy";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colERP_CODE
            // 
            this.colERP_CODE.Caption = "Mã ERP";
            this.colERP_CODE.FieldName = "ERP_CODE";
            this.colERP_CODE.Name = "colERP_CODE";
            this.colERP_CODE.Visible = true;
            this.colERP_CODE.VisibleIndex = 2;
            this.colERP_CODE.Width = 83;
            // 
            // colEQUIP_SPECIFICATION
            // 
            this.colEQUIP_SPECIFICATION.Caption = "Thông số Thiết Bị";
            this.colEQUIP_SPECIFICATION.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colEQUIP_SPECIFICATION.FieldName = "EQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Name = "colEQUIP_SPECIFICATION";
            this.colEQUIP_SPECIFICATION.Visible = true;
            this.colEQUIP_SPECIFICATION.VisibleIndex = 3;
            this.colEQUIP_SPECIFICATION.Width = 362;
            // 
            // colUNIT_MEASURE
            // 
            this.colUNIT_MEASURE.Caption = "ĐVT";
            this.colUNIT_MEASURE.FieldName = "UNIT_MEASURE";
            this.colUNIT_MEASURE.Name = "colUNIT_MEASURE";
            this.colUNIT_MEASURE.Visible = true;
            this.colUNIT_MEASURE.VisibleIndex = 4;
            this.colUNIT_MEASURE.Width = 65;
            // 
            // colQUANTITY
            // 
            this.colQUANTITY.Caption = "Số lượng Nhập";
            this.colQUANTITY.ColumnEdit = this.repositoryItemCalcEdit1;
            this.colQUANTITY.FieldName = "QUANTITY";
            this.colQUANTITY.Name = "colQUANTITY";
            this.colQUANTITY.Visible = true;
            this.colQUANTITY.VisibleIndex = 5;
            this.colQUANTITY.Width = 66;
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // colSTOCK_TPM
            // 
            this.colSTOCK_TPM.Caption = "Kho";
            this.colSTOCK_TPM.FieldName = "STOCK_TPM";
            this.colSTOCK_TPM.Name = "colSTOCK_TPM";
            this.colSTOCK_TPM.Visible = true;
            this.colSTOCK_TPM.VisibleIndex = 6;
            this.colSTOCK_TPM.Width = 67;
            // 
            // colSUPPLIER
            // 
            this.colSUPPLIER.Caption = "Nhà Cung Cấp";
            this.colSUPPLIER.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colSUPPLIER.FieldName = "SUPPLIER";
            this.colSUPPLIER.Name = "colSUPPLIER";
            this.colSUPPLIER.Visible = true;
            this.colSUPPLIER.VisibleIndex = 7;
            this.colSUPPLIER.Width = 232;
            // 
            // colDEPT_ORDER
            // 
            this.colDEPT_ORDER.Caption = "Phòng Ban Yêu Cầu";
            this.colDEPT_ORDER.FieldName = "DEPT_ORDER";
            this.colDEPT_ORDER.Name = "colDEPT_ORDER";
            this.colDEPT_ORDER.Visible = true;
            this.colDEPT_ORDER.VisibleIndex = 8;
            this.colDEPT_ORDER.Width = 193;
            // 
            // data_Get_NhapKhoTableAdapter
            // 
            this.data_Get_NhapKhoTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 635);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmNhapKho";
            this.Text = " NHẬP KHO";
            this.Load += new System.EventHandler(this.frmNhapKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetNhapKhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_NhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit toDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit fromDate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.BindingSource dataGetNhapKhoBindingSource;
        private DataSet.DataSet_Get_NhapKho dataSet_Get_NhapKho;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colVOUCHER;
        private DevExpress.XtraGrid.Columns.GridColumn colDATE_IMPORT;
        private DevExpress.XtraGrid.Columns.GridColumn colERP_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colEQUIP_SPECIFICATION;
        private DevExpress.XtraGrid.Columns.GridColumn colUNIT_MEASURE;
        private DevExpress.XtraGrid.Columns.GridColumn colQUANTITY;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOCK_TPM;
        private DevExpress.XtraGrid.Columns.GridColumn colSUPPLIER;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPT_ORDER;
        private DataSet.DataSet_Get_NhapKhoTableAdapters.Data_Get_NhapKhoTableAdapter data_Get_NhapKhoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
    }
}