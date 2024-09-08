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

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }
        void Load_Init()
        {
            // TODO: This line of code loads data into the 'dataSet_Get_Duty.Data_Get_Duty' table. You can move, or remove it, as needed.
            this.data_Get_DutyTableAdapter.Fill(this.dataSet_Get_Duty.Data_Get_Duty);
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            gridView1.OptionsBehavior.ReadOnly = false;
            if (Common._suUser)
            {
                this.data_Get_UserTableAdapter.Fill(this.dataSet_Get_User.Data_Get_User, 0, "0000");
            }
            else if (Common._adminLocal)
            {
                this.data_Get_UserTableAdapter.Fill(this.dataSet_Get_User.Data_Get_User, 1, Common._idDept);
                colSuAdmin.Visible = false;
                colAdminLocal.Visible = false;
            }
            else
            {
                
            }

        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_Init();
        }

        private void btnChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {   
            if (Common._suUser)
            {
                gridView1.OptionsBehavior.ReadOnly = false;
            }
            else if (Common._adminLocal)
            {
                colSuAdmin.Visible = false;
                colAdminLocal.Visible = false;
                gridView1.OptionsBehavior.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("BẠN KHÔNG ĐƯỢC CẤP QUYỀN!!!");
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            bool _addlocal,_edit, _view;
            try
            {
                _addlocal = (bool) gridView1.GetFocusedRowCellValue(colAdminLocal);
            }
            catch { _addlocal=false; }
            try
            {
                _edit = (bool)gridView1.GetFocusedRowCellValue(colEditer);   
            }
            catch { _edit = false; }
            try
            {
                _view = (bool)gridView1.GetFocusedRowCellValue(colViewer);
            }
            catch { _view = false; }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Update_User";
                cmd.Parameters.AddWithValue("@idstaff", gridView1.GetFocusedRowCellDisplayText(colIDStaff));
                cmd.Parameters.AddWithValue("@AdminLocal", _addlocal);
                cmd.Parameters.AddWithValue("@Editer", _edit);
                cmd.Parameters.AddWithValue("@Viewer", _view);
                cmd.Parameters.AddWithValue("@IDDept", gridView1.GetFocusedRowCellValue(colIDDepartment).ToString());
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ccon.Close(); }
            
            Load_Init();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           // if (Common._suUser)
            {
                DialogResult dialogResult = MessageBox.Show("Chắc chắn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = ccon;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Message_Save_Delete_User";
                        cmd.Parameters.AddWithValue("@IDStaff", gridView1.GetFocusedRowCellDisplayText(colIDStaff));
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                        XtraMessageBox.Show("Đã xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { ccon.Close(); }
                }
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Init();
        }
    }
}