namespace HS_QuanLyBaoTri
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTaikhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatkhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.chkSave = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaikhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSave.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Location = new System.Drawing.Point(12, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mã nhân viên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Location = new System.Drawing.Point(12, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Location = new System.Drawing.Point(12, 29);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtTaikhoan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTaikhoan.Properties.NullText = "Nhập tên tài khoản";
            this.txtTaikhoan.Size = new System.Drawing.Size(369, 22);
            this.txtTaikhoan.TabIndex = 3;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(12, 91);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtMatkhau.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatkhau.Properties.NullText = "Nhập mật khẩu";
            this.txtMatkhau.Properties.UseSystemPasswordChar = true;
            this.txtMatkhau.Size = new System.Drawing.Size(369, 22);
            this.txtMatkhau.TabIndex = 4;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDangnhap.Appearance.Options.UseForeColor = true;
            this.btnDangnhap.Location = new System.Drawing.Point(12, 133);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(110, 33);
            this.btnDangnhap.TabIndex = 5;
            this.btnDangnhap.Text = "ĐĂNG NHẬP";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.Location = new System.Drawing.Point(128, 133);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(110, 33);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // chkSave
            // 
            this.chkSave.Location = new System.Drawing.Point(262, 135);
            this.chkSave.Name = "chkSave";
            this.chkSave.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.chkSave.Properties.Appearance.Options.UseForeColor = true;
            this.chkSave.Properties.Caption = "Nhớ tài khoản";
            this.chkSave.Size = new System.Drawing.Size(119, 21);
            this.chkSave.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelControl4.Location = new System.Drawing.Point(12, 172);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "2017.09.02";
            // 
            // frmLogIn
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 191);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.chkSave);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.Shown += new System.EventHandler(this.frmLogIn_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogIn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtTaikhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSave.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTaikhoan;
        private DevExpress.XtraEditors.TextEdit txtMatkhau;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.CheckEdit chkSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;

    }
}