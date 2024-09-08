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
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri
{
    public partial class frmCheckingDetails_Alltime : DevExpress.XtraEditors.XtraForm
    {
        public frmCheckingDetails_Alltime()
        {
            InitializeComponent();            
        }

        private void frmCheckingDetails_Alltime_Load(object sender, EventArgs e)
        {
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 0, "");
            gridBand3.Visible = true;
            gridBand4.Visible = true;
            gridBand5.Visible = true;
            gridBand6.Visible = true;
            Check_all.EditValue = true;
            Check_yearly.EditValue = false;
            Check_montly.EditValue = false;
            Check_Weekly.EditValue = false;
            Check_daily.EditValue = false;
            txtDept.EditValue = clsCommon.Common._idDept;           
           
        }

        private void txtDept_EditValueChanged(object sender, EventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
            {
                if (Check_all.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = true;
                    gridBand5.Visible = true;
                    gridBand6.Visible = true;
                   data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 0, "");                 
                }
                if (Check_yearly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = true;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 2, "");
                }
                if (Check_montly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = true;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 4, "");
                }
                if (Check_Weekly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = true;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 6, "");
                }
                if (Check_daily.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 8, "");
                }   
            }
            else
            {
                if (Check_all.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = true;
                    gridBand5.Visible = true;
                    gridBand6.Visible = true;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 1, txtDept.EditValue.ToString());
                }
                if (Check_yearly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = true;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 3, txtDept.EditValue.ToString());
                }
                if (Check_montly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = true;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 5, txtDept.EditValue.ToString());
                }
                if (Check_Weekly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = true;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 7, txtDept.EditValue.ToString());
                }
                if (Check_daily.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 9, txtDept.EditValue.ToString());
                }   
            }
                
                
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // Nút làm mới
        {
            string _iddept;
            try
            {
                _iddept = txtDept.EditValue.ToString();           
            }
            catch
            {
                _iddept = "_0000";
            }
            if (_iddept == "_0000")
            {
                if (Check_all.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = true;
                    gridBand5.Visible = true;
                    gridBand6.Visible = true;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 0, "");
                }
                if (Check_yearly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = true;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 2, "");
                }
                if (Check_montly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = true;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 4, "");
                }
                if (Check_Weekly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = true;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 6, "");
                }
                if (Check_daily.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 8, "");
                }
            }
            else
            {
                if (Check_all.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = true;
                    gridBand5.Visible = true;
                    gridBand6.Visible = true;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 1, txtDept.EditValue.ToString());
                }
                if (Check_yearly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = true;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 3, txtDept.EditValue.ToString());
                }
                if (Check_montly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = false;
                    gridBand5.Visible = true;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 5, txtDept.EditValue.ToString());
                }
                if (Check_Weekly.EditValue.Equals(true))
                {
                    gridBand3.Visible = false;
                    gridBand4.Visible = true;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 7, txtDept.EditValue.ToString());
                }
                if (Check_daily.EditValue.Equals(true))
                {
                    gridBand3.Visible = true;
                    gridBand4.Visible = false;
                    gridBand5.Visible = false;
                    gridBand6.Visible = false;
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 9, txtDept.EditValue.ToString());
                }
            }
        }

        private void Check_all_EditValueChanged(object sender, EventArgs e)
        {
           
            if (Check_all.EditValue.Equals(true))
            {
                Check_all.EditValue = true;
                Check_yearly.EditValue = false;
                Check_montly.EditValue = false;
                Check_Weekly.EditValue = false;
                Check_daily.EditValue = false;
                gridBand3.Visible = true;
                gridBand4.Visible = true;
                gridBand5.Visible = true;
                gridBand6.Visible = true;
                string _iddept;
                try
                {
                    if (txtDept != null && txtDept.EditValue != null)
                    {
                        _iddept = txtDept.EditValue.ToString();
                    }
                    else
                    {
                        _iddept = "_0000";
                    }
                }
                catch
                {
                    _iddept = "_0000";
                }

                _iddept = txtDept.EditValue.ToString();
                if (_iddept == "_0000")
                {                   
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 0, "");
                }
                else
                {                  
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 1, txtDept.EditValue.ToString());                    
                }
            }
        }

        private void Check_yearly_EditValueChanged(object sender, EventArgs e)
        {
            if (Check_yearly.EditValue.Equals(true))
            {
                Check_all.EditValue = false;
                Check_yearly.EditValue = true;
                Check_montly.EditValue = false;
                Check_Weekly.EditValue = false;
                Check_daily.EditValue = false;
                gridBand3.Visible = false;
                gridBand4.Visible = false;
                gridBand5.Visible = false;
                gridBand6.Visible = true;
                string _iddept = txtDept.EditValue.ToString();
                if (_iddept == "_0000")
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 2, "");
                }
                else
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 3, txtDept.EditValue.ToString());
                }
            }
        }

        private void Check_montly_EditValueChanged(object sender, EventArgs e)
        {
            if (Check_montly.EditValue.Equals(true))
            {
                Check_all.EditValue = false;
                Check_yearly.EditValue = false;
                Check_montly.EditValue = true;
                Check_Weekly.EditValue = false;
                Check_daily.EditValue = false;
                gridBand3.Visible = false;
                gridBand4.Visible = false;
                gridBand5.Visible = true;
                gridBand6.Visible = false;
                string _iddept = txtDept.EditValue.ToString();
                if (_iddept == "_0000")
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 4, "");
                }
                else
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 5, txtDept.EditValue.ToString());
                }
            }
        }

        private void Check_Weekly_EditValueChanged(object sender, EventArgs e)
        {
            if (Check_Weekly.EditValue.Equals(true))
            {
                Check_all.EditValue = false;
                Check_yearly.EditValue = false;
                Check_montly.EditValue = false;
                Check_Weekly.EditValue = true;
                Check_daily.EditValue = false;
                gridBand3.Visible = false;
                gridBand4.Visible = true;
                gridBand5.Visible = false;
                gridBand6.Visible = false;
                string _iddept = txtDept.EditValue.ToString();
                if (_iddept == "_0000")
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 6, "");
                }
                else
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 7, txtDept.EditValue.ToString());
                }
            }
        }

        private void Check_daily_EditValueChanged(object sender, EventArgs e)
        {
            if (Check_daily.EditValue.Equals(true))
            {
                Check_all.EditValue = false;
                Check_yearly.EditValue = false;
                Check_montly.EditValue = false;
                Check_Weekly.EditValue =false ;
                Check_daily.EditValue = true;
                gridBand3.Visible = true;
                gridBand4.Visible = false;
                gridBand5.Visible = false;
                gridBand6.Visible = false;
                string _iddept = txtDept.EditValue.ToString();
                if (_iddept == "_0000")
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 8, "");
                }
                else
                {
                    data_Get_CheckEquipmentTableAdapter.Fill(dataSet_GetCheck_AllEQ.Data_Get_CheckEquipment, 9, txtDept.EditValue.ToString());
                }
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

        private void bandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void hiseqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChild.frmHistory_Check_ByEQ f_h = new frmChild.frmHistory_Check_ByEQ();
                f_h._idEQ = bandedGridView1.GetFocusedRowCellValue(colIDEquipments).ToString();
                f_h._idGroupEQ = "";
                f_h._byEQ = true;
                f_h.Show();
            }
            catch
            {
                MessageBox.Show("Chọn Sai Dòng, Chọn lại!!!");
            }
        }

        private void hisgroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChild.frmHistory_Check_ByEQ f_h = new frmChild.frmHistory_Check_ByEQ();
                f_h._idEQ = "";
                f_h._idGroupEQ = bandedGridView1.GetFocusedRowCellValue(colIDGroupEQ).ToString();
                f_h._iddept = bandedGridView1.GetFocusedRowCellValue(colIDDept).ToString();
                f_h._byEQ = false;
                f_h.Show();
            }
            catch
            {
                MessageBox.Show("Chọn Sai Dòng, Chọn lại!!!");
            }
        }
        bool _editcheck;

        private void repositoryItemCheckEdit6_EditValueChanged(object sender, EventArgs e)
        {
            if (Common._suUser || ((Common._idDept == "_0002" || Common._idDept == "_0005") && (Common._adminLocal || Common._editer)))
            {
                bool _check = (bool)bandedGridView1.ActiveEditor.EditValue;
                if (_check)
                {
                    _editcheck = true;
                    bandedGridView1.SetFocusedRowCellValue(colYearly, true);
                    string _query = "Update [HS-QuanLyBaoTri].[dbo].[tblDetailsEquipments] set [Yearly]=1";
                    try
                    {
                        clsCommon.Common.ExcuteQuery(_query);
                    }
                    catch
                    { }

                }
                else
                {
                    _editcheck = false;
                }
            }
        }

        private void btnEdit13_Click(object sender, EventArgs e)
        {
            if (Common._suUser || ((Common._idDept == "_0002" || Common._idDept == "_0005") && (Common._adminLocal || Common._editer)))
            {
                colYearly.OptionsColumn.ReadOnly = false;
            }
        }
    }
}