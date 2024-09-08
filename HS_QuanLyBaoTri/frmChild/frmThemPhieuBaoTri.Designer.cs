namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmThemPhieuBaoTri
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtVocher = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataGetResourcesschedulebigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_Resource_big = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Resource_big();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVocher_Maintenance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_Get_Resources_schedulebigTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Resource_bigTableAdapters.Data_Get_Resources_schedulebigTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVocher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetResourcesschedulebigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Resource_big)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.txtVocher);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(721, 285);
            this.splitContainerControl1.SplitterPosition = 30;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txtVocher
            // 
            this.txtVocher.Location = new System.Drawing.Point(94, 6);
            this.txtVocher.Name = "txtVocher";
            this.txtVocher.Properties.ReadOnly = true;
            this.txtVocher.Size = new System.Drawing.Size(162, 20);
            this.txtVocher.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu mới số : ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataGetResourcesschedulebigBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(721, 251);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataGetResourcesschedulebigBindingSource
            // 
            this.dataGetResourcesschedulebigBindingSource.DataMember = "Data_Get_Resources_schedulebig";
            this.dataGetResourcesschedulebigBindingSource.DataSource = this.dataSet_Get_Resource_big;
            // 
            // dataSet_Get_Resource_big
            // 
            this.dataSet_Get_Resource_big.DataSetName = "DataSet_Get_Resource_big";
            this.dataSet_Get_Resource_big.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colParentId,
            this.colDescription,
            this.colVocher_Maintenance,
            this.colIDDept});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colId
            // 
            this.colId.Caption = "ID";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 115;
            // 
            // colParentId
            // 
            this.colParentId.Caption = "ID Parent";
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 1;
            this.colParentId.Width = 160;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "CÔNG VIỆC CẦN BẢO TRÌ";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 519;
            // 
            // colVocher_Maintenance
            // 
            this.colVocher_Maintenance.FieldName = "Vocher_Maintenance";
            this.colVocher_Maintenance.Name = "colVocher_Maintenance";
            // 
            // colIDDept
            // 
            this.colIDDept.FieldName = "IDDept";
            this.colIDDept.Name = "colIDDept";
            // 
            // data_Get_Resources_schedulebigTableAdapter
            // 
            this.data_Get_Resources_schedulebigTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemPhieuBaoTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 285);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmThemPhieuBaoTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu Bảo Trì nhiều ngày";
            this.Load += new System.EventHandler(this.frmThemPhieuBaoTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtVocher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetResourcesschedulebigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Resource_big)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txtVocher;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dataGetResourcesschedulebigBindingSource;
        private DataSet.DataSet_Get_Resource_big dataSet_Get_Resource_big;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colParentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colVocher_Maintenance;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDept;
        private DataSet.DataSet_Get_Resource_bigTableAdapters.Data_Get_Resources_schedulebigTableAdapter data_Get_Resources_schedulebigTableAdapter;
    }
}