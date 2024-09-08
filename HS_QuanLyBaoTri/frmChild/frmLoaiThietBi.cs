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
    public partial class frmLoaiThietBi : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiThietBi()
        {
            InitializeComponent();
        }

        string _idloaiEQ = string.Empty;
        public string _flID = string.Empty;
        int _split = 1;

        public void LamMoiData()
        {
            this.dataTable1TableAdapter.Fill(this.dataSet_Get_Goods.DataTable1);
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
                cmd.CommandText = "Message_Save_Update_LoaiThietBi";
                cmd.Parameters.AddWithValue("@idgoods", _idloaiEQ);
                cmd.Parameters.AddWithValue("@goods", txtLoaiEQ.Text);
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
            txtLoaiEQ.Text = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, colGoods);
            _idloaiEQ = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, colIDGoods);
            btnLuu.Text = "Cập nhật";
            _split = 2;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtLoaiEQ.Text = string.Empty;
            _idloaiEQ = "00000";
            btnLuu.Text = "Lưu";
            _split = 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            _flID = gridView1.GetFocusedRowCellValue(colIDGoods).ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}