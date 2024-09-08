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
    public partial class frmLogIn : DevExpress.XtraEditors.XtraForm
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

            //DataTable dt = baobj.Execute_Get_Version(beobj);
            //beobj._version = dt.Rows[0]["Version"].ToString();
            //beobj._path = dt.Rows[0]["PathVersion"].ToString();
            //if (beobj._version != labelControl4.Text)
            //{
            //    if (XtraMessageBox.Show("Có phiên bản mới\n Bạn có muốn truy cập để tải về không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //    {
            //        System.Diagnostics.Process.Start("explorer.exe", beobj._path);
            //    }
            //    else
            //    {
            //        this.Close();
            //    }
            //}            
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //if (beobj._version == labelControl4.Text)
            {
                if (txtTaikhoan.Text != "" && txtMatkhau.Text != "")
                {
                    ;
                }
                else
                {
                    XtraMessageBox.Show("Tài khoản HOẶC mật khẩu chưa nhập!", "Thông báo");
                    return;
                }
                string _user = txtTaikhoan.Text;
                DataTable dt = Common.Get_UserLogIn(_user, 1);
                if (dt.Rows.Count > 0)
                {
                    if (txtMatkhau.Text == dt.Rows[0]["QPassWord"].ToString().ToUpper())
                    {
                        // MessageBox.Show("OK");
                        Common._idstaff = txtTaikhoan.Text;
                        Common._username = dt.Rows[0]["NAMEUSER"].ToString();
                        Common._pass = txtMatkhau.Text;
                        Common._suUser = string.IsNullOrEmpty(dt.Rows[0]["SuAdmin"].ToString()) ? false : (bool)dt.Rows[0]["SuAdmin"];
                        Common._adminLocal = string.IsNullOrEmpty(dt.Rows[0]["AdminLocal"].ToString()) ? false : (bool)dt.Rows[0]["AdminLocal"];
                        Common._editer = string.IsNullOrEmpty(dt.Rows[0]["Editer"].ToString()) ? false : (bool)dt.Rows[0]["Editer"];
                        Common._viewer = string.IsNullOrEmpty(dt.Rows[0]["Viewer"].ToString()) ? false : (bool)dt.Rows[0]["Viewer"];
                        Common._idDept = dt.Rows[0]["IDDept"].ToString();
                        Common._Dept = dt.Rows[0]["Department"].ToString();
                        Common._namepc = System.Environment.MachineName;

                        bool _chk = chkSave.Checked;
                        SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = ccon;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@namepc", Common._namepc);
                            cmd.Parameters.AddWithValue("@chk",_chk);
                            cmd.CommandText = "Message_Save_SaveAccount";
                            ccon.Open();
                            cmd.ExecuteNonQuery();
                            ccon.Close();
                        }
                        catch
                        {
                            ccon.Close();
                        }


                        if (chkSave.Checked)
                        {
                            
                        }
                        else
                        {
                            Common._idstaff = txtTaikhoan.Text;
                            Common._pass = "";
                        }
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = ccon;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@namepc", Common._namepc);
                            cmd.Parameters.AddWithValue("@user", Common._idstaff);
                            cmd.Parameters.AddWithValue("@pass", Common._pass);
                            cmd.CommandText = "Message_Save_AccountRemember";
                            ccon.Open();
                            cmd.ExecuteNonQuery();
                            ccon.Close();
                        }
                        catch
                        {
                            ccon.Close();
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show("Tài khoản đăng nhập chưa đúng!", "Thông báo");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không tồn tại tài khoản này!", "Thông báo");
                }
            }
            //else
            //{
            //    XtraMessageBox.Show("Phiên bản đã cũ!\n Mời bạn  nhấn YES để lấy chương trình mới về", "Thông báo");
            //    System.Diagnostics.Process.Start("explorer.exe", beobj._path);
            //}
        }

        private void frmLogIn_Shown(object sender, EventArgs e)
        {
            Common._namepc = System.Environment.MachineName;
            try
            {
                DataTable dt = Common.Get_SaveAccount(Common._namepc);
                if (dt.Rows.Count != 0)
                {
                    chkSave.Checked = (bool)dt.Rows[0]["CheckSave"];
                }
                if (chkSave.Checked)
                {
                    txtTaikhoan.Text = dt.Rows[0]["UserName"].ToString();
                    txtMatkhau.Text = dt.Rows[0]["PassWord"].ToString();
                }
            }
            catch { ;}
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmLogIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangnhap.PerformClick();
            }
        }

    }
}