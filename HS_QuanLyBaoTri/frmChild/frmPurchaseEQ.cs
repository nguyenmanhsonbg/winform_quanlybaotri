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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmPurchaseEQ : DevExpress.XtraEditors.XtraForm
    {
        public frmPurchaseEQ()
        {
            InitializeComponent();
        }
        public bool add_new;
        public bool paste_new;
        void Load_Init()
        {
            DateTime _dateFrom = Convert.ToDateTime(dateFrom.EditValue.ToString());
            DateTime _dateTo = Convert.ToDateTime(dateTo.EditValue.ToString());
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            try
            {
                if (txtphongban.EditValue.ToString() == "_0000")
                    this.data_Get_Purchase_EquipmentTableAdapter.Fill(this.dataSet_Get_Purchase_Equipments.Data_Get_Purchase_Equipment, 0, _dateFrom, _dateTo, "_0000", "0");
                else
                    this.data_Get_Purchase_EquipmentTableAdapter.Fill(this.dataSet_Get_Purchase_Equipments.Data_Get_Purchase_Equipment, 1, _dateFrom, _dateTo, txtphongban.EditValue.ToString(), "0");

            }
            catch
            {
                this.data_Get_Purchase_EquipmentTableAdapter.Fill(this.dataSet_Get_Purchase_Equipments.Data_Get_Purchase_Equipment, 0, _dateFrom, _dateTo, "_0000", "0");
            }
            gridView1.OptionsBehavior.ReadOnly = false;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            gridView1.IndicatorWidth = 40;
            add_new = false;
            paste_new = false;
        }

        private void frmPurchaseEQ_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateFrom.EditValue = new DateTime(date.Year, date.Month, 1);
            dateTo.EditValue = DateTime.Now;
            txtphongban.EditValue = "_0000";
            Load_Init();
        }

        private void btnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Init();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtphongban.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                gridView1.OptionsBehavior.ReadOnly = false;
                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                this.data_Get_Purchase_EquipmentTableAdapter.Fill(this.dataSet_Get_Purchase_Equipments.Data_Get_Purchase_Equipment, 5, DateTime.Now, DateTime.Now, "_0000", "0");
                add_new = true;
                paste_new = false;
            }
            else
            {
                MessageBox.Show("Chọn đúng Dây chuyền của bạn!!!");

            }
        }

        private void btnPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = false;
            add_new = false;
            paste_new = true;
            if (paste_new)
            {
                    this.data_Get_Purchase_EquipmentTableAdapter.Fill(this.dataSet_Get_Purchase_Equipments.Data_Get_Purchase_Equipment, 5, DateTime.Now, DateTime.Now, "_0000", "0");
                    if (gridView1.OptionsView.ShowAutoFilterRow == true) { gridView1.OptionsView.ShowAutoFilterRow = false; }
                    char[] rowSplitter = {'\r'};  // Cr and Lf.
                    char columnSplitter = '\t';         // Tab.
                    try
                    {

                        IDataObject dataInClipboard = Clipboard.GetDataObject();

                        string stringInClipboard = dataInClipboard.GetData(DataFormats.UnicodeText).ToString();

                        string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

                        int iRow = 0;

                        if (rowsInClipboard.Length > 0)
                        {
                            iRow = gridView1.RowCount;
                            while (iRow < rowsInClipboard.Length)
                            {
                                // Split up rows to get individual cells:

                                string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);
                                //int t = valuesInRow.Count();
                                if (valuesInRow.Count() == 9)
                                {
                                    gridView1.AddNewRow();
                                    int rowHandle = gridView1.GetRowHandle(gridView1.DataRowCount);
                                    // Cycle through cells.
                                    // Assign cell value only if within columns of grid:
                                    gridView1.SetRowCellValue(rowHandle, colERPCODE, valuesInRow[0].ToString());
                                    gridView1.SetRowCellValue(rowHandle, colEQUIP_NAME, valuesInRow[1].ToString());              
                                    gridView1.SetRowCellValue(rowHandle, colEQUIP_SPECIFICATION, valuesInRow[2].ToString());
                                    gridView1.SetRowCellValue(rowHandle, colUNIT_MEASURE, valuesInRow[3].ToString());
                                    gridView1.SetRowCellValue(rowHandle, colQUANTITY, valuesInRow[4].ToString());
                                    gridView1.SetRowCellValue(rowHandle, colVOUCHER, valuesInRow[5].ToString());
                                    gridView1.SetRowCellValue(rowHandle, colPURPOSE, valuesInRow[6].ToString());
                                    try
                                    {
                                        gridView1.SetRowCellValue(rowHandle, colDATE_ORDER, valuesInRow[7].ToString());
                                    }
                                    catch
                                    {
                                        ;
                                    }
                                    try
                                    {
                                        gridView1.SetRowCellValue(rowHandle, colDATE_RETURN, valuesInRow[8].ToString());
                                    }
                                    catch
                                    {
                                        ;
                                    }
                                    gridView1.SetRowCellValue(rowHandle, colREMARK, valuesInRow[9].ToString());
                                    iRow = gridView1.RowCount;
                                }
                                else
                                {
                                    MessageBox.Show(" copy Không đúng định dạng 10 cột!!! kiểm tra lại");
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
                    gridView1.UpdateCurrentRow();

        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtphongban.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                gridView1.UpdateCurrentRow();
                gridView1.CloseEditor();
                DateTime date_order, date_return;
                bool _chk;
                if (add_new || paste_new)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        try
                        {
                            try
                            {
                                date_order = Convert.ToDateTime(gridView1.GetRowCellValue(i, colDATE_ORDER));
                                if (date_order.Year == 0001)
                                {
                                    date_order = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                                }
                            }
                            catch { date_order = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")); }
                            try
                            {
                                date_return = Convert.ToDateTime(gridView1.GetRowCellValue(i, colDATE_RETURN));
                                if (date_return.Year == 0001)
                                {
                                    date_return = Convert.ToDateTime("1993" + DateTime.Now.ToString("MM-dd"));
                                }
                                else { _chk = true; }
                            }
                            catch { date_return = Convert.ToDateTime("1993" + DateTime.Now.ToString("MM-dd")); }
                            try
                            {
                                _chk = (bool)gridView1.GetRowCellValue(i, colCHECK_RETURN);
                            }
                            catch { _chk = false; }
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = ccon;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "Message_Save_Update_Purchase_Equipment";
                            cmd.Parameters.AddWithValue("@ID_Purchase", gridView1.GetRowCellDisplayText(i, colID_Purchase));
                            cmd.Parameters.AddWithValue("@ERPCODE", gridView1.GetRowCellValue(i, colERPCODE).ToString());
                            cmd.Parameters.AddWithValue("@VOUCHER", gridView1.GetRowCellValue(i, colVOUCHER).ToString());
                            cmd.Parameters.AddWithValue("@EQUIP_CODE", gridView1.GetRowCellValue(i, colEQUIP_CODE).ToString());
                            cmd.Parameters.AddWithValue("@EQUIP_NAME", gridView1.GetRowCellDisplayText(i, colEQUIP_NAME));
                            cmd.Parameters.AddWithValue("@EQUIP_SPECIFICATION", gridView1.GetRowCellValue(i, colEQUIP_SPECIFICATION).ToString());
                            cmd.Parameters.AddWithValue("@QUANTITY", gridView1.GetRowCellDisplayText(i, colQUANTITY));
                            cmd.Parameters.AddWithValue("@UNIT_MEASURE", gridView1.GetRowCellDisplayText(i, colUNIT_MEASURE));
                            cmd.Parameters.AddWithValue("@DEPT_ORDER", txtphongban.EditValue.ToString());
                            cmd.Parameters.AddWithValue("@PURPOSE", gridView1.GetRowCellValue(i, colPURPOSE).ToString());
                            cmd.Parameters.AddWithValue("@DATE_ORDER", date_order);
                            cmd.Parameters.AddWithValue("@CHECK_RETURN", _chk);
                            cmd.Parameters.AddWithValue("@DATE_RETURN", date_return);
                            cmd.Parameters.AddWithValue("@REMARK", gridView1.GetRowCellValue(i, colREMARK).ToString());
                            ccon.Open();
                            cmd.ExecuteNonQuery();
                            ccon.Close();
                        }
                        catch { }
                    }
                    add_new = false;
                    paste_new = false;
                }

                Load_Init();
            }
            else
            {
                MessageBox.Show("Chọn đúng Dây chuyền của bạn!!!");

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                            gridView1.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            gridView1.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            gridView1.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            gridView1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridView1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridView1.ExportToMht(exportFilePath);
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

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtphongban.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                DateTime date_order, date_return;
                bool _chk;
                if (!add_new && !paste_new)
                {
                    try
                    {
                        try
                        {
                            date_order = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colDATE_ORDER));
                            if (date_order.Year == 0001)
                            {
                                date_order = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                            }
                        }
                        catch { date_order = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")); }
                        try
                        {
                            _chk = (bool)gridView1.GetFocusedRowCellValue(colCHECK_RETURN);
                        }
                        catch { _chk = false; }
                        try
                        {
                            date_return = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(colDATE_RETURN));
                            if (date_return.Year == 0001)
                            {
                                date_return = Convert.ToDateTime("1993" + DateTime.Now.ToString("MM-dd"));
                            }
                            else { _chk = true; }
                        }
                        catch { date_return = Convert.ToDateTime("1993" + DateTime.Now.ToString("MM-dd")); }

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = ccon;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Message_Save_Update_Purchase_Equipment";
                        cmd.Parameters.AddWithValue("@ID_Purchase", gridView1.GetFocusedRowCellDisplayText(colID_Purchase));
                        cmd.Parameters.AddWithValue("@ERPCODE", gridView1.GetFocusedRowCellValue(colERPCODE).ToString());
                        cmd.Parameters.AddWithValue("@VOUCHER", gridView1.GetFocusedRowCellValue(colVOUCHER).ToString());
                        cmd.Parameters.AddWithValue("@EQUIP_CODE", gridView1.GetFocusedRowCellValue(colEQUIP_CODE).ToString());
                        cmd.Parameters.AddWithValue("@EQUIP_NAME", gridView1.GetFocusedRowCellValue(colEQUIP_NAME));
                        cmd.Parameters.AddWithValue("@EQUIP_SPECIFICATION", gridView1.GetFocusedRowCellValue(colEQUIP_SPECIFICATION).ToString());
                        cmd.Parameters.AddWithValue("@QUANTITY", gridView1.GetFocusedRowCellDisplayText(colQUANTITY));
                        cmd.Parameters.AddWithValue("@UNIT_MEASURE", gridView1.GetFocusedRowCellDisplayText(colUNIT_MEASURE));
                        cmd.Parameters.AddWithValue("@DEPT_ORDER", txtphongban.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@PURPOSE", gridView1.GetFocusedRowCellValue(colPURPOSE).ToString());
                        cmd.Parameters.AddWithValue("@DATE_ORDER", date_order);
                        cmd.Parameters.AddWithValue("@CHECK_RETURN", _chk);
                        cmd.Parameters.AddWithValue("@DATE_RETURN", date_return);
                        cmd.Parameters.AddWithValue("@REMARK", gridView1.GetFocusedRowCellValue(colREMARK).ToString());
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                    }
                    catch { }
                }

                Load_Init();
            }
            else
            {
                MessageBox.Show("Chọn đúng Dây chuyền của bạn!!!");

            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void repositoryItemCheckEdit1_EditValueChanged(object sender, EventArgs e)
        {
            bool _check = (bool)gridView1.ActiveEditor.EditValue;
            if (_check)
            {
                gridView1.SetFocusedRowCellValue(colDATE_RETURN, DateTime.Now);
                gridView1.SetFocusedRowCellValue(colCHECK_RETURN, true);
            }
            else
            {
                gridView1.SetFocusedRowCellValue(colDATE_RETURN, null);
                gridView1.SetFocusedRowCellValue(colCHECK_RETURN, false);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtphongban.EditValue.ToString() && (Common._adminLocal || Common._editer)))
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
                        cmd.CommandText = "Message_Save_Delete_PurchaseEQ";
                        cmd.Parameters.AddWithValue("@IDPurchase", gridView1.GetFocusedRowCellValue(colID_Purchase).ToString());
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                        XtraMessageBox.Show("Đã xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { ; }
                    Load_Init();
                }
                else
                {
                    MessageBox.Show("Chọn đúng Dây chuyền của bạn!!!");

                }
            }
        }
    }
}