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

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmGroupFL : DevExpress.XtraEditors.XtraForm
    {
        public frmGroupFL()
        {
            InitializeComponent();
        }

        string _idgroupEQ = string.Empty;
        public string _flID = string.Empty;
        int _split = 1;

        public void LamMoiData()
        {
            this.tblGroupEquip_ForkliftsTableAdapter.Fill(this.dataSet_Get_GroupForklifts.tblGroupEquip_Forklifts);
        }

        private void frmStandard_Load(object sender, EventArgs e)
        {           
            LamMoiData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GetFinalIDGROUPEQ();
            this.DialogResult = DialogResult.OK;
        }

        string GetFinalIDGROUPEQ()
        {            
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_GroupEquipments_Forklifts";
                cmd.Parameters.AddWithValue("@idgroupEQ", _idgroupEQ);
                cmd.Parameters.AddWithValue("@groupEQ", txtGroupEQ.Text);
                cmd.Parameters.AddWithValue("@idstaff", clsCommon.Common._idstaff);
                cmd.Parameters.AddWithValue("@split", _split);
                SqlParameter pam = new SqlParameter();
                pam.ParameterName = "returntext";
                pam.Direction = ParameterDirection.Output;
                pam.SqlDbType = SqlDbType.VarChar;
                pam.Size = 10;
                cmd.Parameters.Add(pam);
                ccon.Open();
                cmd.ExecuteNonQuery();
                _flID = cmd.Parameters["returntext"].Value.ToString();
                ccon.Close();
            }
            catch
            {

            }
            return _flID;
        }

        private void btnChinhsua_Click(object sender, EventArgs e)
        {
            txtGroupEQ.Text = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, colGroupEquipments);
            _idgroupEQ = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, colIDGroupEQ);
            btnLuu.Text = "Cập nhật";
            _split = 2;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtGroupEQ.Text = string.Empty;
            _idgroupEQ = "00000";
            btnLuu.Text = "Lưu";
            _split = 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _flID = gridView1.GetFocusedRowCellValue(colIDGroupEQ).ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}