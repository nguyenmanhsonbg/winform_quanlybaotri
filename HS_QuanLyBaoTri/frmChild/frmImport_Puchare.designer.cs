namespace HS_QuanLyBaoTri.frmChild
{
    partial class frmImport_Puchare
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeNghiCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REQUISITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViYC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaERP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeNghiCap,
            this.REQUISITION,
            this.NgayPR,
            this.DonViYC,
            this.MaERP,
            this.TenVatTu,
            this.DVT,
            this.SL,
            this.SoPO});
            this.dataGridView1.ContextMenuStrip = this.Options;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(1351, 547);
            this.dataGridView1.TabIndex = 0;
            // 
            // Options
            // 
            this.Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDan,
            this.btnLuu});
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(137, 48);
            // 
            // btnDan
            // 
            this.btnDan.Name = "btnDan";
            this.btnDan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.btnDan.Size = new System.Drawing.Size(136, 22);
            this.btnDan.Text = "Dán";
            this.btnDan.Click += new System.EventHandler(this.btnDan_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnLuu.Size = new System.Drawing.Size(136, 22);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // DeNghiCap
            // 
            this.DeNghiCap.HeaderText = "đề NGHị Cấp Vật Tư";
            this.DeNghiCap.Name = "DeNghiCap";
            this.DeNghiCap.ReadOnly = true;
            this.DeNghiCap.Width = 150;
            // 
            // REQUISITION
            // 
            this.REQUISITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REQUISITION.HeaderText = "SỐ REQUISITION";
            this.REQUISITION.Name = "REQUISITION";
            this.REQUISITION.ReadOnly = true;
            // 
            // NgayPR
            // 
            this.NgayPR.HeaderText = "NgayPR";
            this.NgayPR.Name = "NgayPR";
            this.NgayPR.ReadOnly = true;
            this.NgayPR.Width = 150;
            // 
            // DonViYC
            // 
            this.DonViYC.HeaderText = "BỘ PHÂN YC";
            this.DonViYC.Name = "DonViYC";
            this.DonViYC.ReadOnly = true;
            this.DonViYC.Width = 150;
            // 
            // MaERP
            // 
            this.MaERP.HeaderText = "MÃ ERP";
            this.MaERP.Name = "MaERP";
            this.MaERP.ReadOnly = true;
            // 
            // TenVatTu
            // 
            this.TenVatTu.HeaderText = "TÊN VẬT TƯ";
            this.TenVatTu.Name = "TenVatTu";
            this.TenVatTu.ReadOnly = true;
            this.TenVatTu.Width = 400;
            // 
            // DVT
            // 
            this.DVT.HeaderText = "ĐVT";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 50;
            // 
            // SL
            // 
            this.SL.HeaderText = "SỐ LƯỢNG";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            this.SL.Width = 50;
            // 
            // SoPO
            // 
            this.SoPO.HeaderText = "SỐ PO";
            this.SoPO.Name = "SoPO";
            this.SoPO.ReadOnly = true;
            this.SoPO.Width = 150;
            // 
            // frmImportExcel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 567);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmImportExcel1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip Options;
        private System.Windows.Forms.ToolStripMenuItem btnDan;
        private System.Windows.Forms.ToolStripMenuItem btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeNghiCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn REQUISITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViYC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaERP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPO;
    }
}