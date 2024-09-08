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
using System.Threading;

namespace HS_QuanLyBaoTri.ImportExcell
{
    public partial class frmImportXuatKho : DevExpress.XtraEditors.XtraForm
    {
        public frmImportXuatKho()
        {
            InitializeComponent();
        }

        private void btnDan_Click(object sender, EventArgs e)
        {
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
            if (dataGridView1.RowCount == 0) { return; }
            int _countrow = dataGridView1.RowCount;
            for (int i = 0; i < _countrow; i++)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd = new SqlCommand();
                    cmd.Connection = clsCommon.Common._con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VOUCHER", (string)dataGridView1.Rows[i].Cells["PhieuNhap"].Value);
                    cmd.Parameters.AddWithValue("@DATE_EXPORT", Convert.ToDateTime(dataGridView1.Rows[i].Cells["NgayNhap"].Value));
                    cmd.Parameters.AddWithValue("@ERP_CODE", (string)dataGridView1.Rows[i].Cells["MaVatTu"].Value);
                    cmd.Parameters.AddWithValue("@EQUIP_SPECIFICATION", (string)dataGridView1.Rows[i].Cells["TenVatTu"].Value);
                    cmd.Parameters.AddWithValue("@UNIT_MEASURE", (string)dataGridView1.Rows[i].Cells["colDonViTinh"].Value);
                    cmd.Parameters.AddWithValue("@QUANTITY", Convert.ToDouble(dataGridView1.Rows[i].Cells["colSoLuong"].Value));
                    cmd.Parameters.AddWithValue("@STOCK_TPM", (string)dataGridView1.Rows[i].Cells["Kho"].Value);
                    cmd.Parameters.AddWithValue("@PURPOSE", (string)dataGridView1.Rows[i].Cells["NhaCungCap"].Value);
                    cmd.Parameters.AddWithValue("@DEPT_ORDER", (string)dataGridView1.Rows[i].Cells["DonViYC"].Value);
                    cmd.CommandText = "Message_Save_Update_Xuat";
                    clsCommon.Common.ExcuteCMD(cmd);
                }
                catch
                {
                    XtraMessageBox.Show((string)dataGridView1.Rows[i].Cells["PhieuNhap"].Value, "Thông báo");
                }

            }
        }
    }
}