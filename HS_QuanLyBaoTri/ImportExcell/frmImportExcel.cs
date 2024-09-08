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

namespace HS_QuanLyBaoTri.ImportExcell
{
    public partial class frmImportExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmImportExcel()
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
                    while (jCol < 5)
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
            string _stock = string.Empty;
            frmSelectSTOCK f_selectS = new frmSelectSTOCK();
            if(f_selectS.ShowDialog()==DialogResult.OK)
            {
                _stock = f_selectS._stock;
            }
            if (dataGridView1.RowCount == 0 || _stock=="") { return; }

            try
            {
                string query = "update [appStock_TPM].[dbo].[LIST_EQUIPMENT] set QUANTITY=0 where [STOCK_TPM]='" + _stock + "'";
                clsCommon.Common.ExcuteQuery(query);
            }
            catch { ;}

            int _countrow = dataGridView1.RowCount;
            for (int i = 0; i < _countrow; i++)
            {
                try
                {
                    string _maidkho = _stock;
                    string _mavattu = (string)dataGridView1.Rows[i].Cells["MaVatTu"].Value;
                    string _tenvattu = (string)dataGridView1.Rows[i].Cells["TenVatTu"].Value;
                    string _madonvitinh = (string)dataGridView1.Rows[i].Cells["colDonViTinh"].Value;
                    double _soluong = Convert.ToDouble(dataGridView1.Rows[i].Cells["colSoLuong"].Value);
                    LuuDMVT_CSDL(_maidkho, _mavattu, _tenvattu, _madonvitinh, _soluong);
                }
                catch
                {

                }
            }
        }

        void LuuDMVT_CSDL(string _maidkho, string _mavattu, string _tenvattu, string _madonvitinh, double _soluong)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand();
                cmd.Connection =clsCommon.Common._con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maidkho", _maidkho);
                cmd.Parameters.AddWithValue("@mavattu", _mavattu);
                cmd.Parameters.AddWithValue("@tenvattu", _tenvattu);
                cmd.Parameters.AddWithValue("@madonvitinh", _madonvitinh);
                cmd.Parameters.AddWithValue("@soluong", _soluong);
                cmd.CommandText = "Message_Save_LoadExCel_DMVT";
               clsCommon.Common.ExcuteCMD(cmd);
            }
            catch
            {
                XtraMessageBox.Show(_mavattu,"Thông báo");
            }
        }
    }
}