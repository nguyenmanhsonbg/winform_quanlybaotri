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
using System.IO;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using OpenNETCF.Desktop.Communication;
using System.Globalization;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmTonKho : DevExpress.XtraEditors.XtraForm
    {
        public frmTonKho()
        {
            InitializeComponent();
        }

        void Load_Init()
        {
          // TODO: This line of code loads data into the 'dataSet_Get_TonKho.Data_Purchase_EQ' table. You can move, or remove it, as needed.
            this.data_Purchase_EQTableAdapter.Fill(this.dataSet_Get_TonKho.Data_Purchase_EQ);
            // TODO: This line of code loads data into the 'dataSet_Get_TonKho.Data_Get_TonKho' table. You can move, or remove it, as needed.
            this.data_Get_TonKhoTableAdapter.Fill(this.dataSet_Get_TonKho.Data_Get_TonKho);
            // TODO: This line of code loads data into the 'dataSet_Get_Equipments_New.Data_Get_Equipments_new' table. You can move, or remove it, as needed.
            gridView1.IndicatorWidth = 50;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            print_all = false;
            select_print = false;
        }
        private void frmEquipments_Load(object sender, EventArgs e)
        {
            Load_Init();
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

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.Column.FieldName == "TonKho")
            {
               int _tonkho = Convert.ToInt32(View.GetRowCellValue(e.RowHandle, View.Columns["TonKho"]));
               if (_tonkho == 0)
                    {
                        e.Appearance.BackColor = Color.Salmon;
                    }
            }
        }

        private void gridView1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btnFresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Load_Init();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = false;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            select_print = true;
        }
        bool select_print, print_all;
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (select_print)
            {
               gridView1.CloseEditor();
               for (int i = 0; i < gridView1.RowCount; i++)
                {
                    gridView1.SetRowCellValue(i, colPRINT_CHECK, true);
                }
                print_all = true;
            }
        }
        string query;
        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (select_print)
            {
                if (print_all)
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        ID_Print = ID_Print + ">" + gridView1.GetRowCellValue(i, colERPCODE);
                    }
                }

                string[] list_id = ID_Print.Split('>');
                for (int j = 1; j < list_id.Length; j++)
                {
                    query = query + " OR ERPCODE='" + list_id[j].ToString() + "'";
                }
                string Query1 = "SELECT [DATE_ORDER],P.[DEPT_ORDER],[ERPCODE],[EQUIP_NAME],P.[UNIT_MEASURE],P.[QUANTITY],[PO_NUMBER],EQUIP_LIMIT_MIN,EQUIP_LIMIT_MAX,SoDeNghiMua,PR_CODE FROM [appStock_TPM].[dbo].[tbl_Purchase_EQ] as P " +
                                " LEFT JOIN [appStock_TPM].[dbo].LIST_EQUIPMENT as L ON L.MACHINE_CODE = P.ERPCODE "+
                                 " where (" + query.Substring(3) + ") order by [ERPCODE]";

                try
                {
                    DataTable dt1 = clsCommon.Common.SQLReadDatabaseClient(Query1);
                    frmReport_Puchase f_re = new frmReport_Puchase();
                    f_re.dt = dt1;
                    f_re.Phongban = clsCommon.Common._Dept;
                    f_re.Show();
                }
                catch { ;}

                query = "";
                ID_Print = "";
                Load_Init();
               
            }
        }
        string ID_Print;
        private void Check_Print_EditValueChanged(object sender, EventArgs e)
        {
            bool _check = (bool)gridView1.ActiveEditor.EditValue;
            if (_check)
            {
                gridView1.SetFocusedRowCellValue(colPRINT_CHECK, true);
                ID_Print = ID_Print + ">" + gridView1.GetFocusedRowCellValue(colERPCODE).ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (clsCommon.Common._suUser || ((clsCommon.Common._adminLocal||clsCommon.Common._editer) && (Common._idDept == "_0002" || Common._idDept == "_0003" || Common._idDept == "_0011")))
            {
                gridView1.OptionsBehavior.ReadOnly = false;
                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            else
            {
                MessageBox.Show("User Không có quyền Chỉnh Sửa.");
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (!select_print)
            {
                SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ccon;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Message_Save_Limit_EQ";
                    cmd.Parameters.AddWithValue("@ERPCODE", gridView1.GetFocusedRowCellDisplayText(colERPCODE));
                    cmd.Parameters.AddWithValue("@LIMIT_MAX", gridView1.GetFocusedRowCellValue(colEQUIP_LIMIT_MAX).ToString());
                    cmd.Parameters.AddWithValue("@LIMIT_MIN", gridView1.GetFocusedRowCellValue(colEQUIP_LIMIT_MIN).ToString());
                    ccon.Open();
                    cmd.ExecuteNonQuery();
                    ccon.Close();
                }
                catch { ccon.Close(); }
                Load_Init();
            }
        }

        //them khuc copy data to DH
        //check connect DH
        //RAPI m_RAPI = new RAPI();
        //bool CheckConnectDH()
        //{
        //    try
        //    {
        //        m_RAPI = new RAPI();
        //        if (!m_RAPI.DevicePresent)
        //        {
        //            return false;
        //        }
        //        if (!m_RAPI.Connected)
        //        {
        //            m_RAPI.Connect();
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Vui lòng cắm lại cable");
        //        return false;
        //    }
        //}
        private void btnExporttxt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //try
            //{
            //    string _pathPC = Application.StartupPath + @"\importFile.txt";
            //    if (File.Exists(_pathPC))
            //    {
            //        try
            //        {
            //            File.Delete(_pathPC);
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Vui Lòng Đóng File importFile.txt");
            //            return;
            //        }
            //    }
            //    StreamWriter writer = new StreamWriter(_pathPC, true, Encoding.UTF8);
            //    for (int i = 0; i < gridView1.RowCount; i++)
            //    {
            //        string str = gridView1.GetRowCellDisplayText(i, colERPCODE).Replace("\n", "").Replace("\r", "")
            //                        + "\t" + gridView1.GetRowCellDisplayText(i, colQuyCachVatTu)
            //                        + "\t" + gridView1.GetRowCellDisplayText(i, colDonViTinh)
            //                        + "\t" + gridView1.GetRowCellDisplayText(i, colTonKho)
            //                        + "\t" + gridView1.GetRowCellDisplayText(i, colTenKho);
            //        writer.WriteLine(str);
            //    }
            //    writer.Close();
            //    writer = null;

            //    string _pathDH = @"\FlashDisk\KhoVT\ToPC\importFile.txt";
            //    if (!CheckConnectDH())
            //    {
            //        MessageBox.Show("Chưa kết nối máy quét!");
            //        return;
            //    }
            //    m_RAPI.CopyFileToDevice(_pathPC, _pathDH, true);
            //    try
            //    {
            //        File.Delete(_pathPC);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Vui Lòng Đóng File importFile.txt");
            //    }
            //    MessageBox.Show("Đã Copy file vào máy quét");
            //}
            //catch
            //{
            //    MessageBox.Show("Không Truyền được Dữ liệu đến máy quét.\n Vui lòng thử lại");
            //}
        }

        private void btnImportFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(clsCommon.Common._suUser||clsCommon.Common._idDept=="_0008")
            {
                ImportExcell.frmImportExcel f_import = new ImportExcell.frmImportExcel();
                f_import.Show();
            }
        }

        private void btnImportTXT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        //    if (!CheckConnectDH())
        //    {
        //        MessageBox.Show("Chưa kết nối máy quét!");
        //        return;
        //    }
        //    string _pathDH = @"\FlashDisk\KhoVT\ToPC\exportFile.txt";
        //    string _pathPC = Application.StartupPath + @"\exportFile.txt";
        //    if (File.Exists(_pathPC))
        //    {
        //        try
        //        {
        //            File.Delete(_pathPC);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Vui Lòng Đóng File exportFile.txt");
        //            return;
        //        }
        //    }
        //    try
        //    {
        //        try
        //        {
        //            m_RAPI.CopyFileFromDevice(_pathPC, _pathDH, true);
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Chưa Export File trong máy quét hoặc Đang mở File exportFile.txt trong máy quét");
        //            return;
        //        }

        //        if (!File.Exists(_pathPC))
        //        {
        //            OpenFileDialog fileDialog = new OpenFileDialog();
        //            fileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
        //            fileDialog.FileName = _pathDH;
        //            if (fileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                _pathPC = fileDialog.FileName;
        //            }
        //        }

        //        Stream stream = null;
        //        int count = 0;
        //        using (stream)
        //        {
        //            using (var reader = File.OpenText(_pathPC))
        //            {
        //                StreamReader streamReader = File.OpenText(_pathPC);
        //                while (!streamReader.EndOfStream)
        //                {
        //                    string row = reader.ReadLine();
        //                    if (row != null)
        //                    {
        //                        if (!String.IsNullOrEmpty(row))
        //                        {
        //                            string[] column = row.Replace("\n", "").Replace("\r", "").Split('\t');
        //                            double quantity = 0; DateTime dateImport = DateTime.Now; int split = 0;
        //                            try
        //                            {
        //                                quantity = Convert.ToDouble(column[2].Trim());
        //                            }
        //                            catch
        //                            {

        //                                split = 1;
        //                            }
        //                            try
        //                            {
        //                                dateImport = Convert.ToDateTime(column[3].Trim(), CultureInfo.InvariantCulture);
        //                            }
        //                            catch
        //                            {
        //                                dateImport = DateTime.Now;
        //                            }
        //                            string tenkho = column[1].Trim().ToString();
        //                            string ghichu;

        //                            try
        //                            {
        //                                ghichu = column[4].Trim().ToString();
        //                            }
        //                            catch
        //                            {
        //                                ghichu = "";
        //                            }

        //                            if (split == 0)
        //                            {
        //                                if (clsCommon.Common.Execute_Update_Scaned(split, column[0].Trim(), quantity, dateImport, tenkho, ghichu)) count++;
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        break;
        //                    }
        //                }
        //                streamReader.Dispose();
        //            }
        //        }
        //        MessageBox.Show(String.Format("Đã Lưu {0} Dòng", count));
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Không thể lưu được.Vui lòng kiểm tra lại");
        //    }

        }
    }
}