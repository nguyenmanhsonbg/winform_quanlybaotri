using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HS_QuanLyBaoTri.clsCommon;
using System.Data.SqlClient;

namespace HS_QuanLyBaoTri
{
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtmatkhau.Text== Common._pass)
            {
                if(txtMatkhaumoi.Text.Replace(" ","").Length>=6)
                {
                    if(txtMatkhaumoi.Text==txtNhapLaiMatKhau.Text)
                    {
                        SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = ccon;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@manhanvien", Common._idstaff);
                            cmd.Parameters.AddWithValue("@matkhau", txtMatkhaumoi.Text);
                            cmd.CommandText = "Message_ChangePassWord";
                            ccon.Open();
                            cmd.ExecuteNonQuery();
                            ccon.Close();
                            XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                        }
                        catch
                        {
                            ccon.Close();
                        }                       
                    }
                    else
                    {
                        XtraMessageBox.Show("Mật khẩu cũ không khớp nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Mật khẩu mới không hợp lệ!Phải hơn 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Không khớp vs mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}