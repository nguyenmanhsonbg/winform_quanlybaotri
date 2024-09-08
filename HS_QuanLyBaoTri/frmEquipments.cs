using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri
{
    public partial class frmEquipments : DevExpress.XtraEditors.XtraForm
    {
        public frmEquipments()
        {
            InitializeComponent();
        }
        frmChild.frmGroupEQ F_gEQ = null;
        frmChild.frmLoaiThietBi f_loaiTB = null;
        frmChild.frmDetailEquipments f_Detail = null;
        bool _addnew = false; 
        void Load_init()
        {           
            // TODO: This line of code loads data into the 'dataSet_Get_Goods.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet_Get_Goods.DataTable1);
            // TODO: This line of code loads data into the 'dataSet_Get_GroupEquiments.tblGroupEquipments' table. You can move, or remove it, as needed.
            this.tblGroupEquipmentsTableAdapter.Fill(this.dataSet_Get_GroupEquiments.tblGroupEquipments);
            // TODO: This line of code loads data into the 'dataSet_Get_AllEquipment.View_TonKho' table. You can move, or remove it, as needed.
            this.view_TonKhoTableAdapter.Fill(this.dataSet_Get_AllEquipment.View_TonKho);
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            bandedGridView1.IndicatorWidth = 40;
            bandedGridView1.OptionsBehavior.ReadOnly = true;
            bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            colIDGroupEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            _addnew = false;
            colCheckEdit.OptionsColumn.ReadOnly = true;       

        }
        private void frmEquipments_Load(object sender, EventArgs e)
        {
            txtDept.EditValue = clsCommon.Common._idDept;
            this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 1, txtDept.EditValue.ToString());
            Load_init();
            colCheckEdit.OptionsColumn.ReadOnly = true;

        }

        private void bandedGridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.Green;
                e.Appearance.ForeColor = Color.White;
            }
        }

        private void bandedGridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void txtDept_EditValueChanged(object sender, EventArgs e)
        {
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 0, "");
            }
            else
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 1, txtDept.EditValue.ToString());
            }
            Load_init();
        }

        private void btnFresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// Nút làm mới
        {
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 0, "");
            }
            else
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 1, txtDept.EditValue.ToString());
            }
            Load_init();
        }

        private void repositoryItemGridLookUpEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit editor = (ButtonEdit)sender;
            EditorButton Button = e.Button;
            if (Button.Caption == "2")
            {
                F_gEQ = new frmChild.frmGroupEQ();
                if (F_gEQ.ShowDialog() == DialogResult.OK)
                {
                    this.tblGroupEquipmentsTableAdapter.Fill(this.dataSet_Get_GroupEquiments.tblGroupEquipments);
                    bandedGridView1.SetFocusedValue(F_gEQ._flID);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                colIDGroupEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
             if (Common._suUser || ((Common._idDept == "_0002"||Common._idDept == "_0005") && (Common._adminLocal || Common._editer)))
            {
                colCheckEdit.OptionsColumn.ReadOnly = false;
            }
        }

        private void repositoryItemSearchLookUpEdit4_Click(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }

        private void repositoryItemGridLookUpEdit2_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
         
            ButtonEdit editor = (ButtonEdit)sender;
            EditorButton Button = e.Button;
            if (Button.Caption == "2")
            {
                f_loaiTB = new frmChild.frmLoaiThietBi();
                if (f_loaiTB.ShowDialog() == DialogResult.OK)
                {
                    this.dataTable1TableAdapter.Fill(this.dataSet_Get_Goods.DataTable1);
                    bandedGridView1.SetFocusedValue(f_loaiTB._flID);
                }
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// Nút thêm mới
        {
            if (Common._suUser||(Common._idDept==txtDept.EditValue.ToString()&&(Common._adminLocal||Common._editer)))
            {
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                colIDGroupEQ.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 1, "");
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                _addnew = true;
            }
        }

        private void bandedGridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            DateTime _ngaysd, _ngayhuy;
            bool _highvalue;
            try
            {
                _ngaysd = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(colNgayDuaVaoSuDung));
                if (_ngaysd.Year == 0001)
                {
                    _ngaysd = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd")));
                }
            }
            catch { _ngaysd = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd"))); }
            try
            {
                _ngayhuy = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(colNgayHuy));
                if (_ngayhuy.Year == 0001)
                {
                    _ngayhuy = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd")));
                }
            }
            catch { _ngayhuy = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd"))); }
            try
            {
                _highvalue = (bool)bandedGridView1.GetFocusedRowCellValue(colHigh_Value);
            }
            catch { _highvalue = false; }
            if (!_addnew && !_EditCheck)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = ccon;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Message_Save_Update_Equipments";

                    // Add other parameters
                    cmd.Parameters.AddWithValue("@IDEquipments", bandedGridView1.GetFocusedRowCellDisplayText(colIDEquipments));
                    cmd.Parameters.AddWithValue("@IDDept", bandedGridView1.GetFocusedRowCellValue(colIDDept).ToString());
                    cmd.Parameters.AddWithValue("@Staff", Common._username);

                    // Handle potential null values in colIDGroupEQ
                    var idGroupEQValue = bandedGridView1.GetFocusedRowCellValue(colIDGroupEQ);
                    Console.WriteLine(idGroupEQValue);

                    if (idGroupEQValue != null)
                    {
                        cmd.Parameters.AddWithValue("@IDGroupEQ", idGroupEQValue.ToString());
                    }
                    else
                    {
                        // Use a default value instead of showing an error
                        cmd.Parameters.AddWithValue("@IDGroupEQ", DBNull.Value); // or "" if string is expected
                    }



                    cmd.Parameters.AddWithValue("@Equipments", bandedGridView1.GetFocusedRowCellDisplayText(colEquipments));
                    cmd.Parameters.AddWithValue("@IDGoods", bandedGridView1.GetFocusedRowCellValue(colIDGoods).ToString());
                    cmd.Parameters.AddWithValue("@ERPCode", bandedGridView1.GetFocusedRowCellDisplayText(colERPCode));
                    cmd.Parameters.AddWithValue("@Describes", bandedGridView1.GetFocusedRowCellDisplayText(colDescribes));
                    cmd.Parameters.AddWithValue("@Units", bandedGridView1.GetFocusedRowCellDisplayText(colUnits));
                    cmd.Parameters.AddWithValue("@SLDC", bandedGridView1.GetFocusedRowCellValue(colSLDC).ToString());
                    cmd.Parameters.AddWithValue("@SLDP", bandedGridView1.GetFocusedRowCellValue(colSLDP).ToString());
                    cmd.Parameters.AddWithValue("@Supplier", bandedGridView1.GetFocusedRowCellDisplayText(colSupplier));
                    cmd.Parameters.AddWithValue("@Remarks", bandedGridView1.GetFocusedRowCellDisplayText(colRemarks));

                    cmd.Parameters.AddWithValue("@ngaysudung", _ngaysd);
                    cmd.Parameters.AddWithValue("@ngayhuy", _ngayhuy);
                    cmd.Parameters.AddWithValue("@highvalue", _highvalue);

                    ccon.Open();
                    cmd.ExecuteNonQuery();
                    ccon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ccon.Close();
                }

                string _iddept = txtDept.EditValue.ToString();
                if (_iddept == "_0000")
                {
                    this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 0, "");
                }
                else
                {
                    this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 1, txtDept.EditValue.ToString());
                }
                Load_init();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string _dept = bandedGridView1.GetFocusedRowCellDisplayText(colIDDept);
            if (Common._suUser||(Common._idDept==txtDept.EditValue.ToString()&&(Common._adminLocal||Common._editer)))
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
                        cmd.CommandText = "Message_Save_Delete_Equipments";
                        cmd.Parameters.AddWithValue("@IDEquipments", bandedGridView1.GetFocusedRowCellDisplayText(colIDEquipments));
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
                MessageBox.Show("Không phải Thiết bị thuộc dây chuyền của bạn!!! KHÔNG ĐƯỢC XÓA");

            }
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 0, "");
            }
            else
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 1, txtDept.EditValue.ToString());
            }
            Load_init();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            bandedGridView1.UpdateCurrentRow();
            bandedGridView1.CloseEditor();
            DateTime _ngaysd, _ngayhuy;
            bool _highvalue;
            if (_addnew)
            {
                for (int i = 0; i < bandedGridView1.RowCount; i++)
                {
                    try
                    {
                        try
                        {
                            _ngaysd = Convert.ToDateTime(bandedGridView1.GetRowCellValue(i, colNgayDuaVaoSuDung));
                            if (_ngaysd.Year == 0001)
                            {
                                _ngaysd = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd"));
                            }
                        }
                        catch { _ngaysd = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd")); }
                        try
                        {
                            _ngayhuy = Convert.ToDateTime(bandedGridView1.GetRowCellValue(i, colNgayHuy));
                            if (_ngayhuy.Year == 0001)
                            {
                                _ngayhuy = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd"));
                            }
                        }
                        catch { _ngayhuy = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd")); }
                        try
                        {
                            _highvalue = (bool)bandedGridView1.GetRowCellValue(i, colHigh_Value);
                        }
                        catch { _highvalue = false; }
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = ccon;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Message_Save_Update_Equipments";
                        cmd.Parameters.AddWithValue("@IDEquipments", bandedGridView1.GetRowCellDisplayText(i,colIDEquipments));
                        cmd.Parameters.AddWithValue("@IDDept", txtDept.EditValue.ToString());
                        cmd.Parameters.AddWithValue("@Staff", Common._username);
                        cmd.Parameters.AddWithValue("@IDGroupEQ", bandedGridView1.GetRowCellValue(i,colIDGroupEQ).ToString());
                        cmd.Parameters.AddWithValue("@Equipments", bandedGridView1.GetRowCellDisplayText(i,colEquipments));
                        cmd.Parameters.AddWithValue("@IDGoods", bandedGridView1.GetRowCellValue(i,colIDGoods).ToString());
                        cmd.Parameters.AddWithValue("@ERPCode", bandedGridView1.GetRowCellDisplayText(i,colERPCode));
                        cmd.Parameters.AddWithValue("@Describes", bandedGridView1.GetRowCellDisplayText(i,colDescribes));
                        cmd.Parameters.AddWithValue("@Units", bandedGridView1.GetRowCellDisplayText(i,colUnits));
                        cmd.Parameters.AddWithValue("@SLDC", bandedGridView1.GetRowCellValue(i,colSLDC).ToString());
                        cmd.Parameters.AddWithValue("@SLDP", bandedGridView1.GetRowCellValue(i,colSLDP).ToString());
                        cmd.Parameters.AddWithValue("@Supplier", bandedGridView1.GetRowCellDisplayText(i,colSupplier));
                        cmd.Parameters.AddWithValue("@Remarks", bandedGridView1.GetRowCellDisplayText(i,colRemarks));
                        cmd.Parameters.AddWithValue("@ngaysudung", _ngaysd);
                        cmd.Parameters.AddWithValue("@ngayhuy", _ngayhuy);
                        cmd.Parameters.AddWithValue("@highvalue", _highvalue);
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                    }
                    catch { ccon.Close(); }
                }
            }
            string _iddept = txtDept.EditValue.ToString();
            if (_iddept == "_0000")
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 0, "");
            }
            else
            {
                this.data_Get_AllEquipmentTableAdapter.Fill(dataSet_Get_AllEquipment.Data_Get_AllEquipment, 1, txtDept.EditValue.ToString());
            }
            Load_init();
        }

        private void bandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            f_Detail = new frmChild.frmDetailEquipments();
            f_Detail._IDEquipments = bandedGridView1.GetFocusedRowCellValue(colIDEquipments).ToString();
            f_Detail._IDDept = txtDept.EditValue.ToString();
            if (f_Detail.ShowDialog() == DialogResult.OK)
            {
                ;
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                bandedGridView1.BestFitColumns();
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {

                    GridControl[] grids = new GridControl[] { gridControl1 };

                    PrintingSystem ps = new PrintingSystem();

                    DevExpress.XtraPrintingLinks.CompositeLink compositeLink = new DevExpress.XtraPrintingLinks.CompositeLink();

                    compositeLink.PrintingSystem = ps;

                    foreach (GridControl grid in grids)
                    {

                        PrintableComponentLink link = new PrintableComponentLink();

                        link.Component = grid;
                        //link.PaperName = grid.AccessibleName;
                        compositeLink.Links.Add(link);
                        compositeLink.CreatePageForEachLink();


                    }
                    //compositeLink.ShowPreview();

                    compositeLink.ExportToXlsx(saveDialog.FileName,
                                                 new DevExpress.XtraPrinting.XlsxExportOptions()
                                                 {
                                                     ExportMode = DevExpress.XtraPrinting.XlsxExportMode.SingleFilePageByPage,
                                                     SheetName = "Thông số thiết bị dây chuyền "
                                                 }
                                                );

                }
            }            


            //using (SaveFileDialog saveDialog = new SaveFileDialog())
            //{
            //    saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            //    if (saveDialog.ShowDialog() != DialogResult.Cancel)
            //    {
            //        string exportFilePath = saveDialog.FileName;
            //        string fileExtenstion = new FileInfo(exportFilePath).Extension;

            //        switch (fileExtenstion)
            //        {
            //            case ".xls":
            //                gridControl1.ExportToXls(exportFilePath);
            //                break;
            //            case ".xlsx":
            //                gridControl1.ExportToXlsx(exportFilePath);
            //                break;
            //            case ".rtf":
            //                gridControl1.ExportToRtf(exportFilePath);
            //                break;
            //            case ".pdf":
            //                gridControl1.ExportToPdf(exportFilePath);
            //                break;
            //            case ".html":
            //                gridControl1.ExportToHtml(exportFilePath);
            //                break;
            //            case ".mht":
            //                gridControl1.ExportToMht(exportFilePath);
            //                break;
            //            default:
            //                break;
            //        }

            //        if (File.Exists(exportFilePath))
            //        {
            //            try
            //            {
            //                //Try to open the file and let windows decide how to open it.
            //                System.Diagnostics.Process.Start(exportFilePath);
            //            }
            //            catch
            //            {
            //                String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
            //                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        else
            //        {
            //            String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
            //            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }

        private void bandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool _Checkedit;
                try
                { _Checkedit = (bool)View.GetRowCellValue(e.RowHandle, View.Columns["CheckEdit"]); }
                catch { _Checkedit = true; }
                if (!_Checkedit)
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    e.HighPriority = true;
                }
            }
        }
        bool _EditCheck;
        private void repositoryItemCheckEdit2_EditValueChanged(object sender, EventArgs e)
        {
             if (Common._suUser || ((Common._idDept == "_0002"||Common._idDept == "_0005") && (Common._adminLocal || Common._editer)))
            {
                 bool _check = (bool)bandedGridView1.ActiveEditor.EditValue;
                 if (_check)
                 {
                     _EditCheck = true;
                     bandedGridView1.SetFocusedRowCellValue(colCheckEdit, true);
                     string _query = "Update [HS-QuanLyBaoTri].[dbo].[tblEquipments] set [CheckEdit]=1,[StaffCheck]=N'" + clsCommon.Common._username + "' WHERE IDEquipments='" + bandedGridView1.GetFocusedRowCellValue(colIDEquipments).ToString() + "'";
                     try
                     {
                         clsCommon.Common.ExcuteQuery(_query);
                     }
                     catch
                     {}

                 }
                 else
                 {
                     _EditCheck = false;
                 }
            }
        }

        private void ghiNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChild.frmProblem f_pr = new frmChild.frmProblem();
            f_pr._dept = txtDept.EditValue.ToString();
            f_pr._ghinhansuco = true;
            f_pr._equipments = bandedGridView1.GetFocusedRowCellValue(colIDEquipments).ToString();
            f_pr.Show();
        }


        
    }
}