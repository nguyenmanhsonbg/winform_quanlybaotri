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

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmHistory_Check_ByEQ : DevExpress.XtraEditors.XtraForm
    {
        public frmHistory_Check_ByEQ()
        {
            InitializeComponent();
        }
        public string _idEQ;
        public string _idGroupEQ;
        public string _iddept;
        public bool _byEQ;
        private void frmHistory_Check_ByEQ_Load(object sender, EventArgs e)
        {
            if(_byEQ)
            {
                data_Get_DailyCheckEquipments_byEQTableAdapter.Fill(dataSet_GetChecking_ByEQ.Data_Get_DailyCheckEquipments_byEQ, _idEQ,"",0,"");
            }
            else
            {
                data_Get_DailyCheckEquipments_byEQTableAdapter.Fill(dataSet_GetChecking_ByEQ.Data_Get_DailyCheckEquipments_byEQ, "", _idGroupEQ, 1,_iddept);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_byEQ)
            {
                data_Get_DailyCheckEquipments_byEQTableAdapter.Fill(dataSet_GetChecking_ByEQ.Data_Get_DailyCheckEquipments_byEQ, _idEQ, "", 0,"");
            }
            else
            {
                data_Get_DailyCheckEquipments_byEQTableAdapter.Fill(dataSet_GetChecking_ByEQ.Data_Get_DailyCheckEquipments_byEQ, "", _idGroupEQ, 1,_iddept);
            }
        }

        private void btnExcell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}