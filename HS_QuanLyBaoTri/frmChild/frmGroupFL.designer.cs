namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmGroupFL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroupFL));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnChinhsua = new System.Windows.Forms.ToolStripMenuItem();
            this.tblGroupEquipForkliftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_GroupForklifts = new HS_QuanLyBaoTri.DataSet.DataSet_Get_GroupForklifts();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDGroupEQ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupEquipments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtGroupEQ = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblTieuchuan = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tblGroupEquip_ForkliftsTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_GroupForkliftsTableAdapters.tblGroupEquip_ForkliftsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipForkliftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_GroupForklifts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupEQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTieuchuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnHuy);
            this.layoutControl1.Controls.Add(this.btnLammoi);
            this.layoutControl1.Controls.Add(this.btnLuu);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.txtGroupEQ);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(339, 97, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(355, 489);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(265, 36);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 22);
            this.btnHuy.StyleController = this.layoutControl1;
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.Image")));
            this.btnLammoi.Location = new System.Drawing.Point(12, 36);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(78, 22);
            this.btnLammoi.StyleController = this.layoutControl1;
            this.btnLammoi.TabIndex = 7;
            this.btnLammoi.Text = "Tạo mới";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(94, 36);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(167, 22);
            this.btnLuu.StyleController = this.layoutControl1;
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.tblGroupEquipForkliftsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 62);
            this.gridControl1.LookAndFeel.SkinName = "London Liquid Sky";
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(331, 415);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChinhsua});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // btnChinhsua
            // 
            this.btnChinhsua.Name = "btnChinhsua";
            this.btnChinhsua.Size = new System.Drawing.Size(127, 22);
            this.btnChinhsua.Text = "Chỉnh sửa";
            this.btnChinhsua.Click += new System.EventHandler(this.btnChinhsua_Click);
            // 
            // tblGroupEquipForkliftsBindingSource
            // 
            this.tblGroupEquipForkliftsBindingSource.DataMember = "tblGroupEquip_Forklifts";
            this.tblGroupEquipForkliftsBindingSource.DataSource = this.dataSet_Get_GroupForklifts;
            // 
            // dataSet_Get_GroupForklifts
            // 
            this.dataSet_Get_GroupForklifts.DataSetName = "DataSet_Get_GroupForklifts";
            this.dataSet_Get_GroupForklifts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDGroupEQ,
            this.colGroupEquipments,
            this.colUserCreate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIDGroupEQ
            // 
            this.colIDGroupEQ.FieldName = "IDGroupFL";
            this.colIDGroupEQ.Name = "colIDGroupEQ";
            // 
            // colGroupEquipments
            // 
            this.colGroupEquipments.Caption = "Nhóm Thiết Bị";
            this.colGroupEquipments.FieldName = "GroupEQForklifts";
            this.colGroupEquipments.Name = "colGroupEquipments";
            this.colGroupEquipments.Visible = true;
            this.colGroupEquipments.VisibleIndex = 0;
            // 
            // colUserCreate
            // 
            this.colUserCreate.Caption = "Người Tạo";
            this.colUserCreate.FieldName = "UserCreate";
            this.colUserCreate.Name = "colUserCreate";
            this.colUserCreate.Visible = true;
            this.colUserCreate.VisibleIndex = 1;
            // 
            // txtGroupEQ
            // 
            this.txtGroupEQ.Location = new System.Drawing.Point(84, 12);
            this.txtGroupEQ.Name = "txtGroupEQ";
            this.txtGroupEQ.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGroupEQ.Size = new System.Drawing.Size(259, 20);
            this.txtGroupEQ.StyleController = this.layoutControl1;
            this.txtGroupEQ.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblTieuchuan,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(355, 489);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lblTieuchuan
            // 
            this.lblTieuchuan.Control = this.txtGroupEQ;
            this.lblTieuchuan.Location = new System.Drawing.Point(0, 0);
            this.lblTieuchuan.Name = "lblTieuchuan";
            this.lblTieuchuan.Size = new System.Drawing.Size(335, 24);
            this.lblTieuchuan.Text = "Nhóm Thiết Bị:";
            this.lblTieuchuan.TextLocation = DevExpress.Utils.Locations.Left;
            this.lblTieuchuan.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(335, 419);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnLuu;
            this.layoutControlItem2.Location = new System.Drawing.Point(82, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(171, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnLammoi;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnHuy;
            this.layoutControlItem4.Location = new System.Drawing.Point(253, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(82, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // tblGroupEquip_ForkliftsTableAdapter
            // 
            this.tblGroupEquip_ForkliftsTableAdapter.ClearBeforeFill = true;
            // 
            // frmGroupFL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 493);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Money Twins";
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGroupFL";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Bảng Nhóm Thiết Bị Xe Nâng";
            this.Load += new System.EventHandler(this.frmStandard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupEquipForkliftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_GroupForklifts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupEQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTieuchuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtGroupEQ;
        private DevExpress.XtraLayout.LayoutControlItem lblTieuchuan;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLammoi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnChinhsua;
        private DevExpress.XtraGrid.Columns.GridColumn colIDGroupEQ;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupEquipments;
        private DevExpress.XtraGrid.Columns.GridColumn colUserCreate;
        private DataSet.DataSet_Get_GroupForklifts dataSet_Get_GroupForklifts;
        private System.Windows.Forms.BindingSource tblGroupEquipForkliftsBindingSource;
        private DataSet.DataSet_Get_GroupForkliftsTableAdapters.tblGroupEquip_ForkliftsTableAdapter tblGroupEquip_ForkliftsTableAdapter;
    }
}