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
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using HS_QuanLyBaoTri.clsCommon;
using System.IO;

namespace HS_QuanLyBaoTri
{
    public partial class frmCheckingListEquipments : DevExpress.XtraEditors.XtraForm
    {
        public frmCheckingListEquipments()
        {
            InitializeComponent();
        }

        private void frmCheckingListEquipments_Load(object sender, EventArgs e)
        {
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            txtDept.EditValue = clsCommon.Common._idDept;
            dateCheck.EditValue = DateTime.Now;
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
               this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(dataSet_GetCheckListEquipments_Daily.Data_Get_DailyCheckEquipments_Real,0,Convert.ToDateTime(dateCheck.EditValue.ToString()),"");
            else
            {
                this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(dataSet_GetCheckListEquipments_Daily.Data_Get_DailyCheckEquipments_Real, 1, Convert.ToDateTime(dateCheck.EditValue.ToString()), txtDept.EditValue.ToString());
            }
            gridView2.IndicatorWidth = 40;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
                this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(dataSet_GetCheckListEquipments_Daily.Data_Get_DailyCheckEquipments_Real, 0, Convert.ToDateTime(dateCheck.EditValue.ToString()), "");
            else
            {
                this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(dataSet_GetCheckListEquipments_Daily.Data_Get_DailyCheckEquipments_Real, 1, Convert.ToDateTime(dateCheck.EditValue.ToString()), txtDept.EditValue.ToString());
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void gridView2_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            bool _check;
            if ((Common._suUser && _iddept!="_0000") || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            { 
                try
                {
                    _check = (bool)gridView2.GetFocusedRowCellValue(colchk_daily);
                }
                catch { _check = false; }
                SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ccon;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Message_Update_DailyCheckEquipments";
                    cmd.Parameters.AddWithValue("@id", gridView2.GetFocusedRowCellValue(colID));
                    cmd.Parameters.AddWithValue("@check", _check);
                    cmd.Parameters.AddWithValue("@remark", gridView2.GetFocusedRowCellDisplayText(colRemarks));
                    ccon.Open();
                    cmd.ExecuteNonQuery();
                    ccon.Close();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Chọn đúng Dây chuyền của mình trước khi chỉnh sửa!");
                if (_iddept == "_0000")
                    this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(dataSet_GetCheckListEquipments_Daily.Data_Get_DailyCheckEquipments_Real, 0, Convert.ToDateTime(dateCheck.EditValue.ToString()), "");
                else
                {
                    this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(dataSet_GetCheckListEquipments_Daily.Data_Get_DailyCheckEquipments_Real, 1, Convert.ToDateTime(dateCheck.EditValue.ToString()), txtDept.EditValue.ToString());
                }
            }
            
        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            frmChild.frmProblem f_pr = new frmChild.frmProblem();
            f_pr._dept = txtDept.EditValue.ToString();
            f_pr._ghinhansuco = true;
            f_pr._equipments = gridView2.GetFocusedRowCellValue(colIDEquipments).ToString();
            f_pr.Show();
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            Report.Report_ReportCheckingListEquipments _reReportScheadule;
            if (_iddept == "_0000")
            {
                MessageBox.Show("Chọn lại Phòng ban / Dây chuyền của mình !!!!");
                return;
            }
            else
            {
                _reReportScheadule = new Report.Report_ReportCheckingListEquipments(1, Convert.ToDateTime(dateCheck.EditValue.ToString()), txtDept.EditValue.ToString());
            }
            new ReportPrintTool(_reReportScheadule).ShowPreview();
            _reReportScheadule.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, new object[] { true });
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

        private void hisGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChild.frmHistory_Check_ByEQ f_h = new frmChild.frmHistory_Check_ByEQ();
                f_h._idEQ = "";
                f_h._idGroupEQ = gridView2.GetFocusedRowCellValue(colIDGroupEQ).ToString();
                f_h._iddept = gridView2.GetFocusedRowCellValue(colIDDept1).ToString();
                f_h._byEQ = false;
                f_h.Show();
            }
            catch
            {
                MessageBox.Show("Chọn Sai Dòng, Chọn lại!!!");
            }
        }

        private void hisEqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmChild.frmHistory_Check_ByEQ f_h = new frmChild.frmHistory_Check_ByEQ();
                f_h._idEQ = gridView2.GetFocusedRowCellValue(colIDEquipments).ToString();
                f_h._idGroupEQ = "";
                f_h._byEQ = true;
                f_h.Show();
                
            }
            catch
            {
                MessageBox.Show("Chọn Sai Dòng, Chọn lại!!!");
            }
        }

        private void xemTrongThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime day = Convert.ToDateTime(dateCheck.EditValue.ToString());
            DateTime datefrom = new DateTime(day.Year, day.Month, 1);

            this.data_Get_DailyCheckEquipments_RealTableAdapter.Fill(dataSet_GetCheckListEquipments_Daily.Data_Get_DailyCheckEquipments_Real, 2, datefrom, txtDept.EditValue.ToString());
           
        }
    }
}