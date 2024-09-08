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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmThemPhieuBaoTri : DevExpress.XtraEditors.XtraForm
    {
        public frmThemPhieuBaoTri()
        {
            InitializeComponent();
        }
        public string _IDDept;
        public string _Vocher;
        public bool edit;
        private void frmThemPhieuBaoTri_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                this.Text = "Chỉnh sửa Phiếu Bảo Trì " + _Vocher;
                txtVocher.Text = _Vocher;
                this.data_Get_Resources_schedulebigTableAdapter.Fill(dataSet_Get_Resource_big.Data_Get_Resources_schedulebig, 0, _IDDept, txtVocher.Text);
            }
            else
            {
                try
                {
                    string _query = "SELECT TOP 1 [Vocher_Maintenance],[ShortName] FROM [HS-QuanLyBaoTri].[dbo].[Resources_schedulebig] as R"
                                    + " inner join CommonData.dbo.tblDepartment As D on D.IDDepartment=R.IDDept"
                                    + " where IDDept='" + _IDDept + "' ORDER BY R.Id desc";
                    DataTable dt = clsCommon.Common.SQLReadDatabaseClient(_query);
                    if (dt.Rows.Count > 0)
                    {
                        string Thangnam = DateTime.Now.ToString("yyyyMMdd");
                        string _vocher = dt.Rows[0]["Vocher_Maintenance"].ToString();
                        if (_vocher.Contains(Thangnam))
                        {
                            int STT = Convert.ToInt32(_vocher.Substring(_vocher.Length - 4, 4));
                            STT++;
                            if (STT < 10)
                            {
                                txtVocher.Text = dt.Rows[0]["ShortName"].ToString() + "." + Thangnam + ".000" + STT;
                            }
                            else if (STT >= 10 && STT < 100)
                            {
                                txtVocher.Text = dt.Rows[0]["ShortName"].ToString() + "." + Thangnam + ".00" + STT;
                            }
                            else
                            {
                                txtVocher.Text = dt.Rows[0]["ShortName"].ToString() + "." + Thangnam + ".0" + STT;
                            }
                        }
                        else
                        {
                            txtVocher.Text = dt.Rows[0]["ShortName"].ToString() + "." + DateTime.Now.ToString("yyyyMMdd") + ".0001";
                        }
                        this.Text = "Thêm Phiếu Bảo Trì " + txtVocher.Text;
                        this.data_Get_Resources_schedulebigTableAdapter.Fill(dataSet_Get_Resource_big.Data_Get_Resources_schedulebig, 0, _IDDept, txtVocher.Text);
                    }
                }
                catch { ;}
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Resources_schedulebig";
                cmd.Parameters.AddWithValue("@Id", gridView1.GetFocusedRowCellDisplayText(colId));
                cmd.Parameters.AddWithValue("@ParentId", gridView1.GetFocusedRowCellValue(colParentId).ToString());
                cmd.Parameters.AddWithValue("@Description", gridView1.GetFocusedRowCellValue(colDescription).ToString());
                cmd.Parameters.AddWithValue("@Vocher_Maintenance", txtVocher.Text);
                cmd.Parameters.AddWithValue("@IDDept", _IDDept);
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ccon.Close(); }
            this.data_Get_Resources_schedulebigTableAdapter.Fill(dataSet_Get_Resource_big.Data_Get_Resources_schedulebig, 0, _IDDept, txtVocher.Text);
        }
    }
}