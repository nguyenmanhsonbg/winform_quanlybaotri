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
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmStaff : DevExpress.XtraEditors.XtraForm
    {
        public frmStaff()
        {
            InitializeComponent();
        }
        public bool _choise = false;
        private void frmStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Get_Position.Data_Get_PositionStaff' table. You can move, or remove it, as needed.
            this.data_Get_PositionStaffTableAdapter.Fill(this.dataSet_Get_Position.Data_Get_PositionStaff);
            // TODO: This line of code loads data into the 'dataSet_Get_Duty.Data_Get_Duty' table. You can move, or remove it, as needed.
            this.data_Get_DutyTableAdapter.Fill(this.dataSet_Get_Duty.Data_Get_Duty);
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            this.data_Get_StaffOfDeptTableAdapter.Fill(this.dataSet_Get_Staff.Data_Get_StaffOfDept, 0, "0000");
            
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            string _iddep = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, colIDDepartment);
            if (_iddep == "_0000")
            {
                this.data_Get_StaffOfDeptTableAdapter.Fill(this.dataSet_Get_Staff.Data_Get_StaffOfDept, 0, "0000");
            }
            else
            {
                this.data_Get_StaffOfDeptTableAdapter.Fill(this.dataSet_Get_Staff.Data_Get_StaffOfDept, 1, _iddep);
            }
        }

        private void btnPQ_Click(object sender, EventArgs e)
        {
            if (Common._suUser || Common._adminLocal)
            {
                SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ccon;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@manhanvien", gridView2.GetRowCellDisplayText(gridView2.FocusedRowHandle, colIDStaff));
                    cmd.Parameters.AddWithValue("@iddept", gridView2.GetRowCellValue(gridView2.FocusedRowHandle, colIDDepartment1));
                    cmd.CommandText = "Message_Add_User";
                    ccon.Open();
                    cmd.ExecuteNonQuery();
                    ccon.Close();
                }
                catch
                {
                    ccon.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn KHÔNG ĐƯỢC CẤP QUYỀN!!!");
            }
        }
    }
}