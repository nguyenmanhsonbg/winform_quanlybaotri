namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmView_VatTuBaoTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView_VatTuBaoTri));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnExcell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGetVatTuCanBaoTriByVocherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_VatTuBaoTri_ByVocher = new HS_QuanLyBaoTri.DataSet.DataSet_Get_VatTuBaoTri_ByVocher();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMACHINE_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colERP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLTonKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVocher_Maintenance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSysDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFather = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_VatTuCanBaoTri_ByVocherTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_VatTuBaoTri_ByVocherTableAdapters.Data_Get_VatTuCanBaoTri_ByVocherTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetVatTuCanBaoTriByVocherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_VatTuBaoTri_ByVocher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnExcell);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(885, 392);
            this.splitContainerControl1.SplitterPosition = 31;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnExcell
            // 
            this.btnExcell.Image = ((System.Drawing.Image)(resources.GetObject("btnExcell.Image")));
            this.btnExcell.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExcell.Location = new System.Drawing.Point(765, 3);
            this.btnExcell.Name = "btnExcell";
            this.btnExcell.Size = new System.Drawing.Size(99, 23);
            this.btnExcell.TabIndex = 2;
            this.btnExcell.Text = "Xuất Excell";
            this.btnExcell.UseVisualStyleBackColor = true;
            this.btnExcell.Click += new System.EventHandler(this.btnExcell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataGetVatTuCanBaoTriByVocherBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(885, 356);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataGetVatTuCanBaoTriByVocherBindingSource
            // 
            this.dataGetVatTuCanBaoTriByVocherBindingSource.DataMember = "Data_Get_VatTuCanBaoTri_ByVocher";
            this.dataGetVatTuCanBaoTriByVocherBindingSource.DataSource = this.dataSet_Get_VatTuBaoTri_ByVocher;
            // 
            // dataSet_Get_VatTuBaoTri_ByVocher
            // 
            this.dataSet_Get_VatTuBaoTri_ByVocher.DataSetName = "DataSet_Get_VatTuBaoTri_ByVocher";
            this.dataSet_Get_VatTuBaoTri_ByVocher.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACHINE_CODE,
            this.colERP_NAME,
            this.colSLTonKho,
            this.colSLXuat,
            this.colSLTra,
            this.colVocher_Maintenance,
            this.colDescription,
            this.colSysDateTime,
            this.colFather});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFather, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDescription, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // colMACHINE_CODE
            // 
            this.colMACHINE_CODE.Caption = "Mã ERP";
            this.colMACHINE_CODE.FieldName = "MACHINE_CODE";
            this.colMACHINE_CODE.Name = "colMACHINE_CODE";
            this.colMACHINE_CODE.Visible = true;
            this.colMACHINE_CODE.VisibleIndex = 0;
            this.colMACHINE_CODE.Width = 118;
            // 
            // colERP_NAME
            // 
            this.colERP_NAME.Caption = "Tên Thiết Bị";
            this.colERP_NAME.FieldName = "ERP_NAME";
            this.colERP_NAME.Name = "colERP_NAME";
            this.colERP_NAME.Visible = true;
            this.colERP_NAME.VisibleIndex = 1;
            this.colERP_NAME.Width = 316;
            // 
            // colSLTonKho
            // 
            this.colSLTonKho.Caption = "SL Tồn Tại Thời Điểm Xuất";
            this.colSLTonKho.FieldName = "SLTonKho";
            this.colSLTonKho.Name = "colSLTonKho";
            this.colSLTonKho.Visible = true;
            this.colSLTonKho.VisibleIndex = 2;
            this.colSLTonKho.Width = 92;
            // 
            // colSLXuat
            // 
            this.colSLXuat.Caption = "SL Xuất";
            this.colSLXuat.FieldName = "SLXuat";
            this.colSLXuat.Name = "colSLXuat";
            this.colSLXuat.Visible = true;
            this.colSLXuat.VisibleIndex = 3;
            // 
            // colSLTra
            // 
            this.colSLTra.Caption = "SL Trả lại Kho";
            this.colSLTra.FieldName = "SLTra";
            this.colSLTra.Name = "colSLTra";
            this.colSLTra.Visible = true;
            this.colSLTra.VisibleIndex = 4;
            // 
            // colVocher_Maintenance
            // 
            this.colVocher_Maintenance.FieldName = "Vocher_Maintenance";
            this.colVocher_Maintenance.Name = "colVocher_Maintenance";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colSysDateTime
            // 
            this.colSysDateTime.Caption = "Ngày giờ";
            this.colSysDateTime.FieldName = "SysDateTime";
            this.colSysDateTime.Name = "colSysDateTime";
            this.colSysDateTime.Visible = true;
            this.colSysDateTime.VisibleIndex = 5;
            this.colSysDateTime.Width = 184;
            // 
            // colFather
            // 
            this.colFather.FieldName = "Father";
            this.colFather.Name = "colFather";
            this.colFather.Visible = true;
            this.colFather.VisibleIndex = 7;
            // 
            // data_Get_VatTuCanBaoTri_ByVocherTableAdapter
            // 
            this.data_Get_VatTuCanBaoTri_ByVocherTableAdapter.ClearBeforeFill = true;
            // 
            // frmView_VatTuBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 392);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmView_VatTuBaoTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vật Tư Bảo Trì Theo Phiếu";
            this.Load += new System.EventHandler(this.frmView_VatTuBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetVatTuCanBaoTriByVocherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_VatTuBaoTri_ByVocher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dataGetVatTuCanBaoTriByVocherBindingSource;
        private DataSet.DataSet_Get_VatTuBaoTri_ByVocher dataSet_Get_VatTuBaoTri_ByVocher;
        private DataSet.DataSet_Get_VatTuBaoTri_ByVocherTableAdapters.Data_Get_VatTuCanBaoTri_ByVocherTableAdapter data_Get_VatTuCanBaoTri_ByVocherTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMACHINE_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colERP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn colSLXuat;
        private DevExpress.XtraGrid.Columns.GridColumn colSLTra;
        private DevExpress.XtraGrid.Columns.GridColumn colVocher_Maintenance;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSysDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colFather;
        private System.Windows.Forms.Button btnExcell;
    }
}