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
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using System.IO;
using DevExpress.XtraEditors.Controls;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;
using DevExpress.Data;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmProblem : DevExpress.XtraEditors.XtraForm
    {
        ImageProblem f_im = null;
        public frmProblem()
        {
            InitializeComponent();
        }
        public bool _ghinhansuco;
        public string _dept;
        public string _equipments;

        void Load_Init1()
        {
            txtDept.ReadOnly = false;
            DateTime _dateFrom = Convert.ToDateTime(fromDate.EditValue.ToString());
            DateTime _dateTo = Convert.ToDateTime(toDate.EditValue.ToString());
            try
            {
                if (txtDept.EditValue.ToString() == "_0000")
                    this.data_Get_Problem_EquipmentTableAdapter.Fill(this.dataSet_Get_Problem_Equipment.Data_Get_Problem_Equipment, 0, _dateFrom, _dateTo, "_0000","");
                else
                    this.data_Get_Problem_EquipmentTableAdapter.Fill(this.dataSet_Get_Problem_Equipment.Data_Get_Problem_Equipment, 1, _dateFrom, _dateTo, txtDept.EditValue.ToString(),"");

            }
            catch
            {
                this.data_Get_Problem_EquipmentTableAdapter.Fill(this.dataSet_Get_Problem_Equipment.Data_Get_Problem_Equipment, 0, _dateFrom, _dateTo, "_0000","");
            }
            this.data_Get_HistoryPosition_EquipmentTableAdapter.Fill(this.dataSet_HistoryPosition_EQ.Data_Get_HistoryPosition_Equipment);
            bandedGridView1.OptionsBehavior.ReadOnly = true;
            bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            gridBand1.Visible = true;
            bandedGridView1.IndicatorWidth = 40;
            gridView1.IndicatorWidth = 40;

        }
        void Load_Init1_1()
        {

            DateTime _dateFrom = Convert.ToDateTime(fromDate.EditValue.ToString());
            DateTime _dateTo = Convert.ToDateTime(toDate.EditValue.ToString());
            this.data_Get_Problem_EquipmentTableAdapter.Fill(this.dataSet_Get_Problem_Equipment.Data_Get_Problem_Equipment, 10, DateTime.Now, DateTime.Now, "_0000","");
            this.data_Get_HistoryPosition_EquipmentTableAdapter.Fill(this.dataSet_HistoryPosition_EQ.Data_Get_HistoryPosition_Equipment);
            gridBand1.Visible = false;
            bandedGridView1.OptionsBehavior.ReadOnly = false;
           // bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            bandedGridView1.IndicatorWidth = 40;
            gridView1.IndicatorWidth = 40;            
            bandedGridView1.AddNewRow();
            bandedGridView1.SetFocusedRowCellValue(colIDEquipments, _equipments);
            txtDept.EditValue = _dept;
            txtDept.ReadOnly = true;
        }
        void Load_Init2()
        {
            this.data_Get_HistoryPosition_EquipmentTableAdapter.Fill(this.dataSet_HistoryPosition_EQ.Data_Get_HistoryPosition_Equipment);
            bandedGridView1.IndicatorWidth = 40;
            gridView1.IndicatorWidth = 40;
        }
        void Load_Init3()
        {
            try
            {
                if (txtDept1.EditValue.ToString() == "_0000")
                    this.data_Get_HieuChuan_EquipmentTableAdapter.Fill(dataSet_Get_HieuChuanThietBi.Data_Get_HieuChuan_Equipment, 0, "");
                else
                    this.data_Get_HieuChuan_EquipmentTableAdapter.Fill(dataSet_Get_HieuChuanThietBi.Data_Get_HieuChuan_Equipment, 1, txtDept1.EditValue.ToString());

            }
            catch
            {
                this.data_Get_HieuChuan_EquipmentTableAdapter.Fill(dataSet_Get_HieuChuanThietBi.Data_Get_HieuChuan_Equipment, 0, "");
            }
            this.data_Get_HistoryPosition_EquipmentTableAdapter.Fill(this.dataSet_HistoryPosition_EQ.Data_Get_HistoryPosition_Equipment);
            bandedGridView2.OptionsBehavior.ReadOnly = true;
            bandedGridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            bandedGridView2.IndicatorWidth = 40;
            gridBand4.Visible = true;

        }
        private void btnView1_Click(object sender, EventArgs e)
        {
            if (_ghinhansuco)
            {
                this.data_Get_EquipmentsTableAdapter.Fill(this.dataSet_Get_Equipments.Data_Get_Equipments);
                this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
                this.tblGroupEquipmentsTableAdapter.Fill(this.dataSet_Get_GroupEquiments.tblGroupEquipments);
                txtDept.ReadOnly = true;
                DateTime _dateFrom = Convert.ToDateTime(fromDate.EditValue.ToString());
                DateTime _dateTo = Convert.ToDateTime(toDate.EditValue.ToString());
                this.data_Get_Problem_EquipmentTableAdapter.Fill(this.dataSet_Get_Problem_Equipment.Data_Get_Problem_Equipment, 2, _dateFrom, _dateTo, txtDept.EditValue.ToString(), _equipments);
                this.data_Get_HistoryPosition_EquipmentTableAdapter.Fill(this.dataSet_HistoryPosition_EQ.Data_Get_HistoryPosition_Equipment);
                bandedGridView1.OptionsBehavior.ReadOnly = true;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gridBand1.Visible = true;
                bandedGridView1.IndicatorWidth = 40;
                gridView1.IndicatorWidth = 40;
            }
            else
            {
                this.data_Get_EquipmentsTableAdapter.Fill(this.dataSet_Get_Equipments.Data_Get_Equipments);
                this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
                this.tblGroupEquipmentsTableAdapter.Fill(this.dataSet_Get_GroupEquiments.tblGroupEquipments);
                Load_Init1();
            }
        }

        private void btnAddNew1_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                gridBand1.Visible = false;
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                this.data_Get_Problem_EquipmentTableAdapter.Fill(this.dataSet_Get_Problem_Equipment.Data_Get_Problem_Equipment, 10, DateTime.Now, DateTime.Now, "_0000","");
            }
            else
            {
                MessageBox.Show("chọn đúng Dây Chuyền Sản Xuất của mình trước khi thực hiện thao tác!!!");
            }
        }

        private void btnExcel1_Click(object sender, EventArgs e)
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
                                                     SheetName = "Lịch sử SỰ CỐ "
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
            //                bandedGridView1.ExportToXls(exportFilePath);
            //                break;
            //            case ".xlsx":
            //                bandedGridView1.ExportToXlsx(exportFilePath);
            //                break;
            //            case ".rtf":
            //                bandedGridView1.ExportToRtf(exportFilePath);
            //                break;
            //            case ".pdf":
            //                bandedGridView1.ExportToPdf(exportFilePath);
            //                break;
            //            case ".html":
            //                bandedGridView1.ExportToHtml(exportFilePath);
            //                break;
            //            case ".mht":
            //                bandedGridView1.ExportToMht(exportFilePath);
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

        private void frmProblem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ThoiGian.tblDinhKyThoiGian' table. You can move, or remove it, as needed.
            this.tblDinhKyThoiGianTableAdapter.Fill(this.dataSet_ThoiGian.tblDinhKyThoiGian);
            // TODO: This line of code loads data into the 'dataSet_Check_ThongSo.tblCheckParameter' table. You can move, or remove it, as needed.
            this.tblCheckParameterTableAdapter.Fill(this.dataSet_Check_ThongSo.tblCheckParameter);
            // TODO: This line of code loads data into the 'dataSet_Get_GroupEquiments.tblGroupEquipments' table. You can move, or remove it, as needed.
            this.tblGroupEquipmentsTableAdapter.Fill(this.dataSet_Get_GroupEquiments.tblGroupEquipments);
            // TODO: This line of code loads data into the 'dataSet_HistoryPosition_EQ.Data_Get_HistoryPosition_Equipment' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'dataSet_Get_Equipments.Data_Get_Equipments' table. You can move, or remove it, as needed.
            this.data_Get_EquipmentsTableAdapter.Fill(this.dataSet_Get_Equipments.Data_Get_Equipments);
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            DateTime date = DateTime.Now;
            fromDate.EditValue = new DateTime(date.Year, date.Month, 1);
            toDate.EditValue = DateTime.Now;
            if (!_ghinhansuco)
            {
                txtDept.EditValue = clsCommon.Common._idDept;
                Load_Init1();
            }
            else
            {
                txtDept.EditValue = _dept;
                Load_Init1_1();
            }
            Load_Init2();
            txtDept1.EditValue = clsCommon.Common._idDept;
            Load_Init3();

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
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                gridBand1.Visible = false;
            }
            else
            {
                MessageBox.Show("chọn đúng Dây Chuyền Sản Xuất của mình trước khi thực hiện thao tác!!!");
            }
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)))
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
                         cmd.CommandText = "Message_Save_Delete_Problem_Equipments";
                         cmd.Parameters.AddWithValue("@IDProblem", bandedGridView1.GetFocusedRowCellValue(colIDProblem).ToString());
                         ccon.Open();
                         cmd.ExecuteNonQuery();
                         ccon.Close();
                         XtraMessageBox.Show("Đã xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     catch { ; }
                     Load_Init1();
                 }
            }
            else
            {
                MessageBox.Show("chọn đúng Dây Chuyền Sản Xuất của mình trước khi thực hiện thao tác!!!");
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
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void btnView3_Click(object sender, EventArgs e)
        {
            this.data_Get_EquipmentsTableAdapter.Fill(this.dataSet_Get_Equipments.Data_Get_Equipments);
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            this.tblGroupEquipmentsTableAdapter.Fill(this.dataSet_Get_GroupEquiments.tblGroupEquipments);
            Load_Init3();
        }

        private void bandedGridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            
        }

        private void bandedGridView2_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                string _idHieuChuan = bandedGridView2.GetFocusedRowCellValue(colIDHieuChuan).ToString();
                this.data_Get_ChiTietHieuChuanTableAdapter.Fill(dataSet_ChiTietHieuChuan.Data_Get_ChiTietHieuChuan, 1, _idHieuChuan);
                gridView3.OptionsBehavior.ReadOnly = true;
                gridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                colLinkMachine.OptionsColumn.AllowEdit = false;
            }
            catch { ;}
        }

        private void repositoryItemHyperLinkEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ButtonEdit editor = (ButtonEdit)sender;
            EditorButton Button = e.Button;
            if (Button.Caption == "2")
            {
                OpenFileDialog dlog = new OpenFileDialog();
                dlog.Title = "Open file";
                dlog.Filter = "(*.dwg, *.pdf, *.doc, *.docx, *.xls, *.xlsx)|*.dwg;*.pdf;*.doc;*.docx;*.xls;*.xlsx";
                dlog.Multiselect = true;
                dlog.InitialDirectory = @"Libraries\Pictures";
                if (dlog.ShowDialog() == DialogResult.OK)
                {
                    gridView3.SetFocusedRowCellValue(colLinkMachine,dlog.FileName);
                }
            }
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            string _idHieuChuan = bandedGridView2.GetFocusedRowCellValue(colIDHieuChuan).ToString();
            this.data_Get_ChiTietHieuChuanTableAdapter.Fill(dataSet_ChiTietHieuChuan.Data_Get_ChiTietHieuChuan, 1, _idHieuChuan);
            gridView3.OptionsBehavior.ReadOnly = true;
            gridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            colLinkMachine.OptionsColumn.AllowEdit = false;
        }

        private void btnAddNew3_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)) || (Common._idDept == "_0002" || Common._idDept == "_0003"))
            {
                gridBand4.Visible = false;
                this.data_Get_HieuChuan_EquipmentTableAdapter.Fill(dataSet_Get_HieuChuanThietBi.Data_Get_HieuChuan_Equipment, 10, "");
                bandedGridView2.OptionsBehavior.ReadOnly = false;
                bandedGridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền!!!");
            }
        }

        private void btnExcell3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                bandedGridView1.BestFitColumns();
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {

                    GridControl[] grids = new GridControl[] { gridControl3 };

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
                                                     SheetName = "THEO DÕI HIỆU CHUẨN "
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
            //                bandedGridView2.ExportToXls(exportFilePath);
            //                break;
            //            case ".xlsx":
            //                bandedGridView2.ExportToXlsx(exportFilePath);
            //                break;
            //            case ".rtf":
            //                bandedGridView2.ExportToRtf(exportFilePath);
            //                break;
            //            case ".pdf":
            //                bandedGridView2.ExportToPdf(exportFilePath);
            //                break;
            //            case ".html":
            //                bandedGridView2.ExportToHtml(exportFilePath);
            //                break;
            //            case ".mht":
            //                bandedGridView2.ExportToMht(exportFilePath);
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

        private void btnExcel2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                bandedGridView1.BestFitColumns();
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {

                    GridControl[] grids = new GridControl[] { gridControl4 };

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
                                                     SheetName = "LỊCH SỬ HIỆU CHUẨN "
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
            //                gridView3.ExportToXls(exportFilePath);
            //                break;
            //            case ".xlsx":
            //                gridView3.ExportToXlsx(exportFilePath);
            //                break;
            //            case ".rtf":
            //                gridView3.ExportToRtf(exportFilePath);
            //                break;
            //            case ".pdf":
            //                gridView3.ExportToPdf(exportFilePath);
            //                break;
            //            case ".html":
            //                gridView3.ExportToHtml(exportFilePath);
            //                break;
            //            case ".mht":
            //                gridView3.ExportToMht(exportFilePath);
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

        private void bandedGridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string _ThoiGian = bandedGridView2.GetFocusedRowCellValue(colThoiGian).ToString();
            if (string.IsNullOrEmpty(_ThoiGian))
            {
                MessageBox.Show("Nhập 'Đơn Vị Thời Gian'", "Cảnh Báo");
                return;
            }
            string _DinhKy = bandedGridView2.GetFocusedRowCellValue(colDinhKy).ToString();
            if (string.IsNullOrEmpty(_DinhKy))
            {
                MessageBox.Show("Nhập 'Định Kỳ'", "Cảnh Báo");
                return;
            }
            DateTime _StartDate;
            try
            {
                _StartDate = Convert.ToDateTime(bandedGridView2.GetFocusedRowCellValue(colStartDate).ToString());
            }
            catch
            {
                _StartDate = DateTime.Now;
            }
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
             try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_HieuChuan";
                cmd.Parameters.AddWithValue("@IDEquipments", bandedGridView2.GetFocusedRowCellValue(colIDEquipments1).ToString());
                cmd.Parameters.AddWithValue("@ThongSo", bandedGridView2.GetFocusedRowCellValue(colThongSo).ToString());
                cmd.Parameters.AddWithValue("@IDHieuChuan", bandedGridView2.GetFocusedRowCellValue(colIDHieuChuan).ToString());
                cmd.Parameters.AddWithValue("@GioiHan", bandedGridView2.GetFocusedRowCellValue(colGioiHan).ToString());
                cmd.Parameters.AddWithValue("@DinhKy", _DinhKy);
                cmd.Parameters.AddWithValue("@StartDate", _StartDate);
                cmd.Parameters.AddWithValue("@IDCheckPar", bandedGridView2.GetFocusedRowCellValue(colIDCheckPar).ToString());
                cmd.Parameters.AddWithValue("@ThoiGian", _ThoiGian);
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
             catch { ;}
            Load_Init3();
        }

        private void btnAddNew2_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)) || (Common._idDept == "_0002" || Common._idDept == "_0003"))
            {
                this.data_Get_ChiTietHieuChuanTableAdapter.Fill(dataSet_ChiTietHieuChuan.Data_Get_ChiTietHieuChuan, 10, "");
                gridView3.OptionsBehavior.ReadOnly = false;
                gridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                colLinkMachine.OptionsColumn.AllowEdit = true;
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền!!!");
            }
        }

        private void gridView3_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            bool _Check;
            DateTime _NgayHieuChuan;
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            try
            {
                _Check = (bool)gridView3.GetFocusedRowCellValue(colCheck);
            }
            catch
            {
                _Check = false;
            }
            try
            {
                _NgayHieuChuan = Convert.ToDateTime(gridView3.GetFocusedRowCellValue(colNgayHieuChuan).ToString());
            }
            catch { _NgayHieuChuan = DateTime.Now; }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_ChiTietHieuChuan";
                cmd.Parameters.AddWithValue("@IDChiTietHieuChuan", gridView3.GetFocusedRowCellValue(colIDChiTietHieuChuan).ToString());
                cmd.Parameters.AddWithValue("@IDHieuChuan", bandedGridView2.GetFocusedRowCellValue(colIDHieuChuan).ToString());
                cmd.Parameters.AddWithValue("@KetQuaHieuChuan", gridView3.GetFocusedRowCellValue(colKetQuaHieuChuan).ToString());
                cmd.Parameters.AddWithValue("@NhanVien", gridView3.GetFocusedRowCellValue(colNhanVien).ToString());
                cmd.Parameters.AddWithValue("@Check", _Check);
                cmd.Parameters.AddWithValue("@NgayHieuChuan", _NgayHieuChuan);
                cmd.Parameters.AddWithValue("@LinkServer", gridView3.GetFocusedRowCellValue(colLinkServer).ToString());
                cmd.Parameters.AddWithValue("@LinkMachine", gridView3.GetFocusedRowCellValue(colLinkMachine).ToString());
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ;}
            btnView2.PerformClick();
        }

        private void bandedGridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            DateTime _problem, _solution, _planComplete;
            try
            {
                _problem = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(colDate_Problem).ToString());
                if (_problem.Year == 0001)
                {
                    _problem = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd"));
                }
            }
            catch { _problem = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd")); }
            try
            {
                _solution = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(colDate_Solutions).ToString());
                if (_solution.Year == 0001)
                {
                    _solution = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd"));
                }
            }
            catch { _solution = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd")); }
            try
            {
                _planComplete = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(colPlan_Date_Complete).ToString());
                if (_planComplete.Year == 0001)
                {
                    _planComplete = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd"));
                }
            }
            catch { _planComplete = Convert.ToDateTime("1993-" + DateTime.Now.ToString("MM-dd")); }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_Problem_Equipments";
                cmd.Parameters.AddWithValue("@IDEquipments", bandedGridView1.GetFocusedRowCellValue(colIDEquipments).ToString());
                cmd.Parameters.AddWithValue("@IDProblem", bandedGridView1.GetFocusedRowCellValue(colIDProblem).ToString());
                cmd.Parameters.AddWithValue("@Problem", bandedGridView1.GetFocusedRowCellValue(colProblem).ToString());
                cmd.Parameters.AddWithValue("@Result", bandedGridView1.GetFocusedRowCellValue(colResult).ToString());
                cmd.Parameters.AddWithValue("@Solutions", bandedGridView1.GetFocusedRowCellValue(colSolutions).ToString());
                cmd.Parameters.AddWithValue("@Date_Problem", _problem);
                cmd.Parameters.AddWithValue("@Staff", bandedGridView1.GetFocusedRowCellValue(colStaff).ToString());
                cmd.Parameters.AddWithValue("@Date_Solutions", _solution);
                cmd.Parameters.AddWithValue("@Plan_Date_Complete", _planComplete);
                cmd.Parameters.AddWithValue("@RealTime_Solution", bandedGridView1.GetFocusedRowCellValue(colRealTime_Solution).ToString());
                cmd.Parameters.AddWithValue("@Remarks", bandedGridView1.GetFocusedRowCellValue(colRemarks).ToString());
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ;}
            btnView1.PerformClick();
            if(!_ghinhansuco)
            { 
                _ghinhansuco = false;
                _dept = "";
                _equipments = "";
            }
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)) || (Common._idDept == "_0002" || Common._idDept == "_0003"))
            {
                gridBand4.Visible = false;
                bandedGridView2.OptionsBehavior.ReadOnly = false;
            }
            else
            {
                 MessageBox.Show("Bạn không được cấp quyền!!!");
            }
        }

        private void btnEdit3_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)) || (Common._idDept == "_0002" || Common._idDept == "_0003"))
            {
                gridView3.OptionsBehavior.ReadOnly = false;
                colLinkMachine.OptionsColumn.AllowEdit = true;
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền!!!");
            }
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)) || (Common._idDept == "_0002" || Common._idDept == "_0003"))
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
                        cmd.CommandText = "Message_Save_Delete_HieuChuan";
                        cmd.Parameters.AddWithValue("@IDHieuChuan", bandedGridView2.GetFocusedRowCellValue(colIDHieuChuan).ToString());
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                        XtraMessageBox.Show("Đã xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { ; }
                    Load_Init3();
                }
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền!!!");
            }
        }

        private void btnDel3_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)) || (Common._idDept == "_0002" || Common._idDept == "_0003"))
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
                        cmd.CommandText = "Message_Save_Delete_ChiTietHieuChuan";
                        cmd.Parameters.AddWithValue("@IDChiTietHieuChuan", gridView3.GetFocusedRowCellValue(colIDChiTietHieuChuan).ToString());
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                        XtraMessageBox.Show("Đã xóa dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch { ; }
                    btnView2.PerformClick();
                }
                else
                {
                    MessageBox.Show("Bạn không được cấp quyền!!!");
                    btnView2.PerformClick();
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            this.data_Get_HistoryPosition_EquipmentTableAdapter.Fill(this.dataSet_HistoryPosition_EQ.Data_Get_HistoryPosition_Equipment);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
             if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)) || (Common._idDept == "_0002" || Common._idDept == "_0003"))
             {
                 f_im = new ImageProblem();
                 f_im._IDProblem = bandedGridView1.GetFocusedRowCellValue(colIDProblem).ToString();
                 f_im.Title = "Hình ảnh sự cố của " + bandedGridView1.GetFocusedRowCellDisplayText(colIDEquipments).ToString() + " Trong ngày: " + bandedGridView1.GetFocusedRowCellDisplayText(colDate_Problem).ToString();
                 f_im._IDDept = txtDept.EditValue.ToString();
                 f_im.Dept = txtDept.Text;
                 f_im.Show();
             }
        }
    }
}