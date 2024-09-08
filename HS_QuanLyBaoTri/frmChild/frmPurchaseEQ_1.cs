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
using System.IO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmPurchaseEQ_1 : DevExpress.XtraEditors.XtraForm
    {
        public frmPurchaseEQ_1()
        {
            InitializeComponent();
        }

        private void frmPurchaseEQ_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Purchase_EQ_NoneTK.Data_Get_Purchase_Equipment_NoneTK' table. You can move, or remove it, as needed.
            query = "";
            ID_Print = "";
            this.data_Get_Purchase_Equipment_NoneTKTableAdapter.Fill(this.dataSet_Purchase_EQ_NoneTK.Data_Get_Purchase_Equipment_NoneTK);
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            print_all = false;
            select_print = false;

        }

        private void btnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            query = "";
            ID_Print = "";
            this.data_Get_Purchase_Equipment_NoneTKTableAdapter.Fill(this.dataSet_Purchase_EQ_NoneTK.Data_Get_Purchase_Equipment_NoneTK);
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            print_all = false;
            select_print = false;
        }
        string query;
        private void btnExcell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                                " LEFT JOIN [appStock_TPM].[dbo].LIST_EQUIPMENT as L ON L.MACHINE_CODE = P.ERPCODE " +
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
                this.data_Get_Purchase_Equipment_NoneTKTableAdapter.Fill(this.dataSet_Purchase_EQ_NoneTK.Data_Get_Purchase_Equipment_NoneTK);
                gridView1.OptionsBehavior.ReadOnly = true;
                gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                print_all = false;
                select_print = false;

            }
        }
        bool select_print, print_all;
        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsBehavior.ReadOnly = false;
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            select_print = true;
        }
        string ID_Print;
        private void CHECK_PRINT_EditValueChanged(object sender, EventArgs e)
        {
            bool _check = (bool)gridView1.ActiveEditor.EditValue;
            if (_check)
            {
                gridView1.SetFocusedRowCellValue(colPRINT_CHECK, true);
                ID_Print = ID_Print + ">" + gridView1.GetFocusedRowCellValue(colERPCODE).ToString();
            }
        }

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

        private void btn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              if(clsCommon.Common._suUser||clsCommon.Common._idDept=="_0008")
            {
            frmImport_Puchare f_pur = new frmImport_Puchare();
            f_pur.Show();
            }
        }
    }
}