namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmStaff
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataSet_Dept = new HS_QuanLyBaoTri.DataSet.DataSet_Dept();
            this.dataGetDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Get_DeptTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter();
            this.colIDDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstNameStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastNameStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDepartment1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDDuty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataSet_Get_Staff = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Staff();
            this.dataGetStaffOfDeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Get_StaffOfDeptTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_StaffTableAdapters.Data_Get_StaffOfDeptTableAdapter();
            this.dataSet_Get_Duty = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Duty();
            this.dataGetDutyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Get_DutyTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_DutyTableAdapters.Data_Get_DutyTableAdapter();
            this.dataSet_Get_Position = new HS_QuanLyBaoTri.DataSet.DataSet_Get_Position();
            this.dataGetPositionStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Get_PositionStaffTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_PositionTableAdapters.Data_Get_PositionStaffTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPQ = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetStaffOfDeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Duty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDutyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPositionStaffBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1115, 459);
            this.splitContainerControl1.SplitterPosition = 296;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataGetDeptBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(296, 459);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDepartment,
            this.colDepartment,
            this.colShortName});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // dataSet_Dept
            // 
            this.dataSet_Dept.DataSetName = "DataSet_Dept";
            this.dataSet_Dept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGetDeptBindingSource
            // 
            this.dataGetDeptBindingSource.DataMember = "Data_Get_Dept";
            this.dataGetDeptBindingSource.DataSource = this.dataSet_Dept;
            // 
            // data_Get_DeptTableAdapter
            // 
            this.data_Get_DeptTableAdapter.ClearBeforeFill = true;
            // 
            // colIDDepartment
            // 
            this.colIDDepartment.FieldName = "IDDepartment";
            this.colIDDepartment.Name = "colIDDepartment";
            // 
            // colDepartment
            // 
            this.colDepartment.Caption = "Phòng Ban";
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 0;
            this.colDepartment.Width = 183;
            // 
            // colShortName
            // 
            this.colShortName.Caption = "Tên Viết Tắt";
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 1;
            this.colShortName.Width = 94;
            // 
            // gridControl2
            // 
            this.gridControl2.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl2.DataSource = this.dataGetStaffOfDeptBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4});
            this.gridControl2.Size = new System.Drawing.Size(815, 459);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDStaff,
            this.colFirstNameStaff,
            this.colLastNameStaff,
            this.colIDDepartment1,
            this.colIDDuty,
            this.colIDPosition,
            this.colContact});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.ShowCloseButton = false;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIDStaff
            // 
            this.colIDStaff.Caption = "Mã nhân viên";
            this.colIDStaff.FieldName = "IDStaff";
            this.colIDStaff.Name = "colIDStaff";
            this.colIDStaff.Visible = true;
            this.colIDStaff.VisibleIndex = 0;
            this.colIDStaff.Width = 76;
            // 
            // colFirstNameStaff
            // 
            this.colFirstNameStaff.Caption = "Họ vs tên đệm";
            this.colFirstNameStaff.FieldName = "FirstNameStaff";
            this.colFirstNameStaff.Name = "colFirstNameStaff";
            this.colFirstNameStaff.Visible = true;
            this.colFirstNameStaff.VisibleIndex = 1;
            this.colFirstNameStaff.Width = 133;
            // 
            // colLastNameStaff
            // 
            this.colLastNameStaff.Caption = "Tên";
            this.colLastNameStaff.FieldName = "LastNameStaff";
            this.colLastNameStaff.Name = "colLastNameStaff";
            this.colLastNameStaff.Visible = true;
            this.colLastNameStaff.VisibleIndex = 2;
            this.colLastNameStaff.Width = 61;
            // 
            // colIDDepartment1
            // 
            this.colIDDepartment1.Caption = "Phòng ban";
            this.colIDDepartment1.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIDDepartment1.FieldName = "IDDepartment";
            this.colIDDepartment1.Name = "colIDDepartment1";
            this.colIDDepartment1.Visible = true;
            this.colIDDepartment1.VisibleIndex = 3;
            this.colIDDepartment1.Width = 81;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.dataGetDeptBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "ShortName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "IDDepartment";
            // 
            // colIDDuty
            // 
            this.colIDDuty.Caption = "Chức danh";
            this.colIDDuty.ColumnEdit = this.repositoryItemLookUpEdit3;
            this.colIDDuty.FieldName = "IDDuty";
            this.colIDDuty.Name = "colIDDuty";
            this.colIDDuty.Visible = true;
            this.colIDDuty.VisibleIndex = 4;
            this.colIDDuty.Width = 82;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.dataGetDutyBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "NameDuty";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.NullText = "";
            this.repositoryItemLookUpEdit3.ValueMember = "IDDuty";
            // 
            // colIDPosition
            // 
            this.colIDPosition.Caption = "Chức vụ";
            this.colIDPosition.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colIDPosition.FieldName = "IDPosition";
            this.colIDPosition.Name = "colIDPosition";
            this.colIDPosition.Visible = true;
            this.colIDPosition.VisibleIndex = 5;
            this.colIDPosition.Width = 235;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.DataSource = this.dataGetPositionStaffBindingSource;
            this.repositoryItemLookUpEdit4.DisplayMember = "Position";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.NullText = "";
            this.repositoryItemLookUpEdit4.ValueMember = "IDPosition";
            // 
            // colContact
            // 
            this.colContact.Caption = "Liên hệ";
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 6;
            this.colContact.Width = 111;
            // 
            // dataSet_Get_Staff
            // 
            this.dataSet_Get_Staff.DataSetName = "DataSet_Get_Staff";
            this.dataSet_Get_Staff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGetStaffOfDeptBindingSource
            // 
            this.dataGetStaffOfDeptBindingSource.DataMember = "Data_Get_StaffOfDept";
            this.dataGetStaffOfDeptBindingSource.DataSource = this.dataSet_Get_Staff;
            // 
            // data_Get_StaffOfDeptTableAdapter
            // 
            this.data_Get_StaffOfDeptTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet_Get_Duty
            // 
            this.dataSet_Get_Duty.DataSetName = "DataSet_Get_Duty";
            this.dataSet_Get_Duty.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGetDutyBindingSource
            // 
            this.dataGetDutyBindingSource.DataMember = "Data_Get_Duty";
            this.dataGetDutyBindingSource.DataSource = this.dataSet_Get_Duty;
            // 
            // data_Get_DutyTableAdapter
            // 
            this.data_Get_DutyTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet_Get_Position
            // 
            this.dataSet_Get_Position.DataSetName = "DataSet_Get_Position";
            this.dataSet_Get_Position.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGetPositionStaffBindingSource
            // 
            this.dataGetPositionStaffBindingSource.DataMember = "Data_Get_PositionStaff";
            this.dataGetPositionStaffBindingSource.DataSource = this.dataSet_Get_Position;
            // 
            // data_Get_PositionStaffTableAdapter
            // 
            this.data_Get_PositionStaffTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPQ});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // btnPQ
            // 
            this.btnPQ.Name = "btnPQ";
            this.btnPQ.Size = new System.Drawing.Size(152, 22);
            this.btnPQ.Text = "Phân Quyền";
            this.btnPQ.Click += new System.EventHandler(this.btnPQ_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 459);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmStaff";
            this.Text = "Nhân Sự Các Phòng Ban";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Dept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetStaffOfDeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Duty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetDutyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_Position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetPositionStaffBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource dataGetDeptBindingSource;
        private DataSet.DataSet_Dept dataSet_Dept;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DataSet.DataSet_DeptTableAdapters.Data_Get_DeptTableAdapter data_Get_DeptTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIDStaff;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstNameStaff;
        private DevExpress.XtraGrid.Columns.GridColumn colLastNameStaff;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDepartment1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDuty;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private System.Windows.Forms.BindingSource dataGetStaffOfDeptBindingSource;
        private DataSet.DataSet_Get_Staff dataSet_Get_Staff;
        private DataSet.DataSet_Get_StaffTableAdapters.Data_Get_StaffOfDeptTableAdapter data_Get_StaffOfDeptTableAdapter;
        private DataSet.DataSet_Get_Duty dataSet_Get_Duty;
        private System.Windows.Forms.BindingSource dataGetDutyBindingSource;
        private DataSet.DataSet_Get_DutyTableAdapters.Data_Get_DutyTableAdapter data_Get_DutyTableAdapter;
        private DataSet.DataSet_Get_Position dataSet_Get_Position;
        private System.Windows.Forms.BindingSource dataGetPositionStaffBindingSource;
        private DataSet.DataSet_Get_PositionTableAdapters.Data_Get_PositionStaffTableAdapter data_Get_PositionStaffTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnPQ;
    }
}