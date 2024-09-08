using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmThietBiXeNang : DevExpress.XtraEditors.XtraForm
    {
        public frmThietBiXeNang()
        {
            InitializeComponent();
        }
        bool _paste;
        frmChild.frmGroupFL F_gEQ = null;
        void Load_Init()
        {
            this.dataTable1TableAdapter.Fill(this.dataSet_Get_EqForklifts.DataTable1);
            this.tblGroupEquip_ForkliftsTableAdapter.Fill(this.dataSet_Get_GroupForklifts.tblGroupEquip_Forklifts);          
            bandedGridView1.OptionsBehavior.ReadOnly = true;
            bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            _paste = false;
            bandedGridView1.IndicatorWidth = 40;
            gridBand4.Visible = true;
        }
        private void frmThietBiXeNang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Get_EqForklifts.DataTable1' table. You can move, or remove it, as needed.
            Load_Init();
            txtGroupFL.EditValue = "_0001";
            this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 1, txtGroupFL.EditValue.ToString());
        }

        private void btnFresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Init();
            string _IDGroupFL = txtGroupFL.EditValue.ToString();
            if (_IDGroupFL == "_0000")
            {
                this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 0, "");
            }
            else
            {
                this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 1, txtGroupFL.EditValue.ToString());
            }
        }

        private void txtGroupFL_EditValueChanged(object sender, EventArgs e)
        {
            Load_Init();
            string _IDGroupFL = txtGroupFL.EditValue.ToString();
            if (_IDGroupFL == "_0000")
            {
                this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 0, "");
            }
            else
            {
                this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 1, txtGroupFL.EditValue.ToString());
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Common._suUser || (Common._idDept == "_0002" && (Common._adminLocal || Common._editer)))
            {
                string _IDGroupFL = txtGroupFL.EditValue.ToString();
                if (_IDGroupFL == "_0000")
                {
                    MessageBox.Show("Chưa Chọn Nhóm Phụ Tùng!!! Chọn Lại.");
                    return;
                }
                this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 10, "");
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                _paste = false;
                gridBand4.Visible = false;
            }
        }

        private void btnPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Common._suUser || (Common._idDept == "_0002" && (Common._adminLocal || Common._editer)))
            {
                string _IDGroupFL = txtGroupFL.EditValue.ToString();
                if (_IDGroupFL == "_0000")
                {
                    MessageBox.Show("Chưa Chọn Nhóm Phụ Tùng!!! Chọn Lại.");
                    return;
                }
                gridBand4.Visible = false;
                this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 10, "");
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                _paste = true;
                try
                {               
                    if (_paste)
                    {
                        char[] rowSplitter = { '\n', '\r' };  // Cr and Lf.
                        char columnSplitter = '\t';         // Tab.
                        try
                        {
                            
                            IDataObject dataInClipboard = Clipboard.GetDataObject();

                            string stringInClipboard = dataInClipboard.GetData(DataFormats.UnicodeText).ToString();

                            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

                            int iRow = 0;

                            if (rowsInClipboard.Length > 0)
                            {
                                iRow = bandedGridView1.RowCount;
                                while (iRow < rowsInClipboard.Length)
                                {
                                    // Split up rows to get individual cells:

                                    string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);
                                    if (valuesInRow.Count() == 9)
                                    {
                                        bandedGridView1.AddNewRow();
                                        int rowHandle = bandedGridView1.GetRowHandle(bandedGridView1.DataRowCount);
                                        // Cycle through cells.
                                        // Assign cell value only if within columns of grid:
                                        bandedGridView1.SetRowCellValue(rowHandle, colKind_Forfilts, valuesInRow[0].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colLocation, valuesInRow[1].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colERPCODE, valuesInRow[2].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colEquipments_Forfilts, valuesInRow[3].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colDescribes, valuesInRow[4].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colSupplier, valuesInRow[5].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colDescribes_Change, valuesInRow[6].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colSupplier_Change, valuesInRow[7].ToString());
                                        bandedGridView1.SetRowCellValue(rowHandle, colRemarks, valuesInRow[8].ToString());
                                        iRow = bandedGridView1.RowCount;
                                    }
                                    else
                                    {
                                        MessageBox.Show(" copy Không đúng định dạng 9 cột!!! kiểm tra lại");
                                        break;
                                    }
                                } // end while
                            }

                        }
                        catch
                        {
                            ;
                        }

                    }
                    bandedGridView1.UpdateCurrentRow();

                }
                catch
                {
                    ;
                }
            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Common._suUser || (Common._idDept == "_0002" && (Common._adminLocal || Common._editer)))
            {
                if (_paste)
                {
                    bandedGridView1.CloseEditor();
                    for (int i = 0; i < bandedGridView1.RowCount; i++)
                    {
                        SqlConnection ccon = new SqlConnection(Common._connection);
                        try
                        {
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = ccon;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Message_Save_Update_Equipments_Forklifts";
                            cmd.Parameters.AddWithValue("@IDEquipments_Forklifts", "");
                            cmd.Parameters.AddWithValue("@IDGroupFL", txtGroupFL.EditValue.ToString());
                            cmd.Parameters.AddWithValue("@Kind_Forfilts", bandedGridView1.GetRowCellValue(i, colKind_Forfilts).ToString());
                            cmd.Parameters.AddWithValue("@Location", bandedGridView1.GetRowCellValue(i, colLocation).ToString());
                            cmd.Parameters.AddWithValue("@ERPCODE", bandedGridView1.GetRowCellValue(i, colERPCODE).ToString());
                            cmd.Parameters.AddWithValue("@Equipments_Forfilts", bandedGridView1.GetRowCellValue(i, colEquipments_Forfilts).ToString());
                            cmd.Parameters.AddWithValue("@Describes", bandedGridView1.GetRowCellValue(i, colDescribes).ToString());
                            cmd.Parameters.AddWithValue("@Supplier", bandedGridView1.GetRowCellValue(i, colSupplier).ToString());
                            cmd.Parameters.AddWithValue("@Describes_Change", bandedGridView1.GetRowCellValue(i, colDescribes_Change).ToString());
                            cmd.Parameters.AddWithValue("@Supplier_Change", bandedGridView1.GetRowCellValue(i, colSupplier_Change).ToString());
                            cmd.Parameters.AddWithValue("@Remarks", bandedGridView1.GetRowCellValue(i, colRemarks).ToString());
                            ccon.Open();
                            cmd.ExecuteNonQuery();
                            ccon.Close();
                        }
                        catch
                        {
                            ccon.Close();
                        }
                    }
                    Load_Init();
                    string _IDGroupFL = txtGroupFL.EditValue.ToString();
                    if (_IDGroupFL == "_0000")
                    {
                        this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 0, "");
                    }
                    else
                    {
                        this.data_Get_Equipments_ForkliftsTableAdapter.Fill(dataSet_Get_EqForklifts.Data_Get_Equipments_Forklifts, 1, txtGroupFL.EditValue.ToString());
                    }
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == "_0002" && (Common._adminLocal || Common._editer)))
            {
                string _IDGroupFL = txtGroupFL.EditValue.ToString();
                if (_IDGroupFL == "_0000")
                {
                    MessageBox.Show("Chưa Chọn Nhóm Phụ Tùng!!! Chọn Lại.");
                    return;
                }
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                _paste = false;
            }
        }

        private void repositoryItemSearchLookUpEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (Common._suUser || (Common._idDept == "_0002" && (Common._adminLocal || Common._editer)))
            {
                ButtonEdit editor = (ButtonEdit)sender;
                EditorButton Button = e.Button;
                if (Button.Caption == "2")
                {
                    F_gEQ = new frmChild.frmGroupFL();
                    if (F_gEQ.ShowDialog() == DialogResult.OK)
                    {
                        this.tblGroupEquip_ForkliftsTableAdapter.Fill(this.dataSet_Get_GroupForklifts.tblGroupEquip_Forklifts);
                        txtGroupFL.EditValue= F_gEQ._flID;
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == "_0002" && (Common._adminLocal || Common._editer)))
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
                        cmd.CommandText = "Message_Save_Delete_Equipments_Forklifts";
                        cmd.Parameters.AddWithValue("@IDEquipments", bandedGridView1.GetFocusedRowCellDisplayText(colIDEquipments_Forklifts));
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                        XtraMessageBox.Show("Đã xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { ccon.Close(); }
                }
            }
            else
            {
                MessageBox.Show(" KHÔNG ĐƯỢC PHÂN QUYỀN XÓA");

            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            gridControl1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bandedGridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (Common._suUser || (Common._idDept == "_0002" && (Common._adminLocal || Common._editer)))
            {
                SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                if (!_paste)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = ccon;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Message_Save_Update_Equipments_Forklifts";
                        cmd.Parameters.AddWithValue("@IDEquipments_Forklifts", bandedGridView1.GetFocusedRowCellDisplayText(colIDEquipments_Forklifts).ToString());
                        cmd.Parameters.AddWithValue("@IDGroupFL", txtGroupFL.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@Kind_Forfilts", bandedGridView1.GetFocusedRowCellDisplayText(colKind_Forfilts).ToString());
                        cmd.Parameters.AddWithValue("@Location", bandedGridView1.GetFocusedRowCellDisplayText(colLocation).ToString());
                        cmd.Parameters.AddWithValue("@ERPCODE", bandedGridView1.GetFocusedRowCellDisplayText(colERPCODE).ToString());
                        cmd.Parameters.AddWithValue("@Equipments_Forfilts", bandedGridView1.GetFocusedRowCellDisplayText(colEquipments_Forfilts).ToString());
                        cmd.Parameters.AddWithValue("@Describes", bandedGridView1.GetFocusedRowCellDisplayText(colDescribes).ToString());
                        cmd.Parameters.AddWithValue("@Supplier", bandedGridView1.GetFocusedRowCellDisplayText(colSupplier).ToString());
                        cmd.Parameters.AddWithValue("@Describes_Change", bandedGridView1.GetFocusedRowCellDisplayText(colDescribes_Change).ToString());
                        cmd.Parameters.AddWithValue("@Supplier_Change", bandedGridView1.GetFocusedRowCellDisplayText(colSupplier_Change).ToString());
                        cmd.Parameters.AddWithValue("@Remarks", bandedGridView1.GetFocusedRowCellDisplayText(colRemarks).ToString());
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                    }
                    catch
                    {
                        ccon.Close();
                    }
                }
            }
        }

        private void bandedGridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void bandedGridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.ForeColor = Color.White;
            }
        }
    }
}