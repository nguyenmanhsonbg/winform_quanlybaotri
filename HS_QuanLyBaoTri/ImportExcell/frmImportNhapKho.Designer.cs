namespace HS_QuanLyBaoTri.ImportExcell
{
    partial class frmImportNhapKho
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
            this.Options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVatTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViYC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhieuNhap,
            this.NgayNhap,
            this.Kho,
            this.MaVatTu,
            this.TenVatTu,
            this.colDonViTinh,
            this.colSoLuong,
            this.NhaCungCap,
            this.DonViYC});
            this.dataGridView1.ContextMenuStrip = this.Options;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 15;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 619);
            this.dataGridView1.TabIndex = 1;
            // 
            // PhieuNhap
            // 
            this.PhieuNhap.HeaderText = "Phiếu Nhập";
            this.PhieuNhap.Name = "PhieuNhap";
            this.PhieuNhap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // Kho
            // 
            this.Kho.HeaderText = "Kho";
            this.Kho.Name = "Kho";
            this.Kho.ReadOnly = true;
            // 
            // MaVatTu
            // 
            this.MaVatTu.HeaderText = "Mã vật tư";
            this.MaVatTu.Name = "MaVatTu";
            this.MaVatTu.ReadOnly = true;
            // 
            // TenVatTu
            // 
            this.TenVatTu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVatTu.HeaderText = "Quy cách";
            this.TenVatTu.Name = "TenVatTu";
            this.TenVatTu.ReadOnly = true;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.HeaderText = "Đơn vị tính";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.HeaderText = "Nhà Cung Cấp";
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.ReadOnly = true;
            this.NhaCungCap.Width = 200;
            // 
            // DonViYC
            // 
            this.DonViYC.HeaderText = "đơn vị yêu cầu";
            this.DonViYC.Name = "DonViYC";
            this.DonViYC.ReadOnly = true;
            this.DonViYC.Width = 200;
            // 
            // frmImportNhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 619);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmImportNhapKho";
            this.Text = "Cập nhật Nhập kho";
            this.Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Options;
        private System.Windows.Forms.ToolStripMenuItem btnDan;
        private System.Windows.Forms.ToolStripMenuItem btnLuu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViYC;
    }
}