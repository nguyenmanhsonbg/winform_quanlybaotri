namespace HS_QuanLyBaoTri
{
    partial class frmChangePass
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.txtMatkhaumoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNhapLaiMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhaumoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mật khẩu cũ";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(14, 27);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmatkhau.Properties.UseSystemPasswordChar = true;
            this.txtmatkhau.Size = new System.Drawing.Size(430, 42);
            this.txtmatkhau.TabIndex = 1;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(15, 97);
            this.txtMatkhaumoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMatkhaumoi.Properties.UseSystemPasswordChar = true;
            this.txtMatkhaumoi.Size = new System.Drawing.Size(430, 42);
            this.txtMatkhaumoi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 74);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mật khẩu mới";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(14, 170);
            this.txtNhapLaiMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNhapLaiMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(430, 42);
            this.txtNhapLaiMatKhau.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 146);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(135, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Nhập lại mật khẩu mới";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(185, 222);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(164, 39);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu Thay Đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(358, 222);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 39);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 265);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtMatkhaumoi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtmatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhaumoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtmatkhau;
        private DevExpress.XtraEditors.TextEdit txtMatkhaumoi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNhapLaiMatKhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}