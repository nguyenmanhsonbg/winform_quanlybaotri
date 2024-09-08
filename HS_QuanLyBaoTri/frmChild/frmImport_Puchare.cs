using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Threading;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmImport_Puchare : DevExpress.XtraEditors.XtraForm
    {
        public frmImport_Puchare()
        {
            InitializeComponent();
        }
        public static int t;
        private void btnDan_Click(object sender, EventArgs e)
        {
            t = 0;
            dataGridView1.Rows.Clear();
            char[] rowSplitter = { '\n', '\r' };  // Cr and Lf.
            char columnSplitter = '\t';         // Tab.
            try
            {

                IDataObject dataInClipboard = Clipboard.GetDataObject();

                string stringInClipboard =
                    dataInClipboard.GetData(DataFormats.UnicodeText).ToString();

                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter,
                    StringSplitOptions.RemoveEmptyEntries);

                int r = 0;// myDataGridView.SelectedCells[0].RowIndex;
                int c = 0;// myDataGridView.SelectedCells[0].ColumnIndex;

                if (dataGridView1.Rows.Count < (r + rowsInClipboard.Length))
                    dataGridView1.Rows.Add(r + rowsInClipboard.Length - dataGridView1.Rows.Count);

                // Loop through lines:

                int iRow = 0;
                while (iRow < rowsInClipboard.Length)
                {
                    // Split up rows to get individual cells:

                    string[] valuesInRow =
                        rowsInClipboard[iRow].Split(columnSplitter);

                    // Cycle through cells.
                    // Assign cell value only if within columns of grid:

                    int jCol = 0;
                    while (jCol < 10)
                    {
                        if ((dataGridView1.ColumnCount - 1) >= (c + jCol))
                            dataGridView1.Rows[r + iRow].Cells[c + jCol].Value =
                            valuesInRow[jCol].ToString();
                        jCol += 1;
                    } // end while

                    iRow += 1;
                } // end while
            }
            catch
            {

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          
            try
            {
                string query = "DELETE [appStock_TPM].[dbo].[tbl_Purchase_EQ]";
                clsCommon.Common.ExcuteQuery(query);
            }
            catch { ;}

            int _countrow = dataGridView1.RowCount;
            for (int i = 0; i < _countrow; i++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand();
                    cmd.Connection = clsCommon.Common._con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SoDeNghiMua", (string)dataGridView1.Rows[i].Cells["DeNghiCap"].Value);
                    cmd.Parameters.AddWithValue("@PR_CODE", (string)dataGridView1.Rows[i].Cells["REQUISITION"].Value);
                    cmd.Parameters.AddWithValue("@DATE_ORDER", Convert.ToDateTime((string)dataGridView1.Rows[i].Cells["NgayPR"].Value));
                    cmd.Parameters.AddWithValue("@DEPT_ORDER", (string)dataGridView1.Rows[i].Cells["DonViYC"].Value);
                    cmd.Parameters.AddWithValue("@ERPCODE", (string)dataGridView1.Rows[i].Cells["MaERP"].Value);
                    cmd.Parameters.AddWithValue("@EQUIP_NAME", (string)dataGridView1.Rows[i].Cells["TenVatTu"].Value);
                    cmd.Parameters.AddWithValue("@UNIT_MEASURE", (string)dataGridView1.Rows[i].Cells["DVT"].Value);
                    cmd.Parameters.AddWithValue("@QUANTITY", (string)dataGridView1.Rows[i].Cells["SL"].Value);
                    cmd.Parameters.AddWithValue("@PO_NUMBER", (string)dataGridView1.Rows[i].Cells["SoPO"].Value);
                    cmd.CommandText = "Message_Save_LoadExCel_Purchase";
                    clsCommon.Common.ExcuteCMD(cmd);
                    t = t + 1;
                }
                catch
                {
                    XtraMessageBox.Show((string)dataGridView1.Rows[i].Cells["MaERP"].Value,"Thông báo LỖI");
                }
            }
            XtraMessageBox.Show("LƯU THÀNH CÔNG !!!" + t.ToString() + " dòng");

        }

        
    }
}