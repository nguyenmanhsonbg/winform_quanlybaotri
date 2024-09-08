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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmBaoTri_ISO : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoTri_ISO()
        {
            InitializeComponent();
            SkinElement element = SkinManager.GetSkinElement(SkinProductId.Grid, DevExpress.LookAndFeel.UserLookAndFeel.Default, "Border");
            element.Border.All = Color.Black;
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        private void frmBaoTri_ISO_Load(object sender, EventArgs e)
        {
            txtDept.EditValue = clsCommon.Common._idDept;
            txtDept1.EditValue = clsCommon.Common._idDept;
            txtDept2.EditValue = clsCommon.Common._idDept;
            //this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            this.data_Get_Dept1TableAdapter.Fill(dataSet_GetDept_ISO.Data_Get_Dept1, 0);
            bandedGridView1.OptionsBehavior.ReadOnly = true;
            bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            bandedGridView2.OptionsBehavior.ReadOnly = true;
            bandedGridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            bandedGridView3.OptionsBehavior.ReadOnly = true;
            bandedGridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            fromDate.EditValue = DateTime.Now;
            fromDate1.EditValue = DateTime.Now;
            bandedGridView1.IndicatorWidth = 40;
            bandedGridView2.IndicatorWidth = 40;
            bandedGridView3.IndicatorWidth = 40;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                colTenCum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                bandedGridView1.OptionsBehavior.ReadOnly = true;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriISOTableAdapter.Fill(dataSet_Get_BaoTriISO.Data_Get_BaoTriISO, txtDept.EditValue.ToString());
                

            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }
            
        }

        private void txtDept_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                colTenCum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                bandedGridView1.OptionsBehavior.ReadOnly = true;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriISOTableAdapter.Fill(dataSet_Get_BaoTriISO.Data_Get_BaoTriISO, txtDept.EditValue.ToString());

            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }
        }

        private void btnExcell_Click(object sender, EventArgs e)
        {
            Report.frmReportISO f_report = new Report.frmReportISO();
            f_report._iddept = txtDept.EditValue.ToString();
            f_report._split = 1;
            f_report._daychuyen = txtDept.Text;
            f_report.Show();
        }

        private void bandedGridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LightSkyBlue;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                if(Common._suUser )
                {
                    colApprover.OptionsColumn.ReadOnly = false;
                }
                else
                {
                    colApprover.OptionsColumn.ReadOnly =true ;
                }
               
                colTenCum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void txtDept1_EditValueChanged(object sender, EventArgs e)
        {
            DateTime _day ;
                try { 
                    _day= Convert.ToDateTime(fromDate.EditValue.ToString());
                    }
            catch { _day =DateTime.Now; }
            DateTime _fromday= new DateTime(_day.Year,_day.Month,1);
            try
            {
                colTenCum1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                bandedGridView2.OptionsBehavior.ReadOnly = true;
                bandedGridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept1.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriThangISOTableAdapter.Fill(dataSet_Get_BaoTriThangISO.Data_Get_BaoTriThangISO, txtDept1.EditValue.ToString(), _fromday);
            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
             DateTime _day ;
                try { 
                    _day= Convert.ToDateTime(fromDate.EditValue.ToString());
                    }
            catch { _day =DateTime.Now; }
            DateTime _fromday= new DateTime(_day.Year,_day.Month,1);
            try
            {
                colTenCum1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                bandedGridView2.OptionsBehavior.ReadOnly = true;
                bandedGridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept1.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriThangISOTableAdapter.Fill(dataSet_Get_BaoTriThangISO.Data_Get_BaoTriThangISO, txtDept1.EditValue.ToString(), _fromday);
            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }
        }

        private void bandedGridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LightSkyBlue;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void txtDept2_EditValueChanged(object sender, EventArgs e)
        {
            DateTime _day;
            try
            {
                _day = Convert.ToDateTime(fromDate1.EditValue.ToString());
            }
            catch { _day = DateTime.Now; }
            try
            {
                 colTenCum2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                 bandedGridView3.OptionsBehavior.ReadOnly = true;
                 bandedGridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept2.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriNamISOTableAdapter.Fill(dataSet_Get_BaoTriNamISO.Data_Get_BaoTriNamISO, txtDept2.EditValue.ToString(), _day.Year);
            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }
        }

        private void btnView2_Click(object sender, EventArgs e)
        {
            DateTime _day;
            try
            {
                _day = Convert.ToDateTime(fromDate1.EditValue.ToString());
            }
            catch { _day = DateTime.Now; }
            try
            {
                 colTenCum2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                 bandedGridView3.OptionsBehavior.ReadOnly = true;
                 bandedGridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept2.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriNamISOTableAdapter.Fill(dataSet_Get_BaoTriNamISO.Data_Get_BaoTriNamISO, txtDept2.EditValue.ToString(), _day.Year);
            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }
        }

        private void bandedGridView3_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle == view.FocusedRowHandle)
            {
                e.Appearance.BackColor = Color.LightSkyBlue;
                e.Appearance.ForeColor = Color.Black;
            }
        }

        private void btnCreatNewMonth_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept1.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                DateTime _Day = Convert.ToDateTime(fromDate.EditValue.ToString());
                DateTime _monCreate = _Day.AddMonths(-1);
                string _dayfind = _monCreate.ToString("yyyy-MM-") + "01 01:00:00";
                DialogResult dialogResult = MessageBox.Show("Chắc chắn Tạo Dữ liệu cho Tháng " + _Day.Month.ToString() + " NĂM " + _Day.Year.ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if (dialogResult == DialogResult.Yes)
                   {
                      SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                      try
                      {
                          SqlCommand cmd = new SqlCommand();
                          cmd.Connection = ccon;
                          cmd.CommandType = CommandType.StoredProcedure;
                          cmd.CommandText = "Message_Save_BaoTriThangISO";
                          cmd.Parameters.AddWithValue("@date", _dayfind);
                          cmd.Parameters.AddWithValue("@IDDept", txtDept1.EditValue.ToString());                      
                          ccon.Open();
                          cmd.ExecuteNonQuery();
                          ccon.Close();
                          MessageBox.Show("Tạo Thành Công, Vui lòng Nhấn Nút 'XEM'");
                      }
                      catch { ;}
                   }

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void btnCreateNewYear_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept2.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                DateTime _Day = Convert.ToDateTime(fromDate1.EditValue.ToString());
                DateTime _monCreate = _Day.AddYears(-1);
                string _dayfind = _monCreate.ToString("yyyy-") + "01-01 01:00:00";
                DialogResult dialogResult = MessageBox.Show("Chắc chắn Tạo Dữ liệu cho NĂM " + _Day.Year.ToString() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = ccon;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "Message_Save_BaoTriNamISO";
                        cmd.Parameters.AddWithValue("@date", _dayfind);
                        cmd.Parameters.AddWithValue("@IDDept", txtDept2.EditValue.ToString());
                        ccon.Open();
                        cmd.ExecuteNonQuery();
                        ccon.Close();
                        MessageBox.Show("Tạo Thành Công, Vui lòng Nhấn Nút 'XEM'");
                    }
                    catch { ;}
                }

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept1.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {

                bandedGridView2.OptionsBehavior.ReadOnly = false;
                if (Common._suUser)
                {
                    colApprover1.OptionsColumn.ReadOnly = false;
                }
                else
                {
                    colApprover1.OptionsColumn.ReadOnly = true;
                }
                colTenCum1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept2.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                bandedGridView3.OptionsBehavior.ReadOnly = false;
                if (Common._suUser)
                {
                    colApprover2.OptionsColumn.ReadOnly = false;
                }
                else
                {
                    colApprover2.OptionsColumn.ReadOnly = true;
                }
                colTenCum2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void bandedGridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_BaoTriISO";
                cmd.Parameters.AddWithValue("@ID", bandedGridView1.GetFocusedRowCellValue(colID));
                cmd.Parameters.AddWithValue("@TenCum", bandedGridView1.GetFocusedRowCellValue(colTenCum).ToString());
                cmd.Parameters.AddWithValue("@NoiDung", bandedGridView1.GetFocusedRowCellValue(colNoiDung).ToString());
                cmd.Parameters.AddWithValue("@Tuan", bandedGridView1.GetFocusedRowCellValue(colTuan));
                cmd.Parameters.AddWithValue("@1thang", bandedGridView1.GetFocusedRowCellValue(col1thang));
                cmd.Parameters.AddWithValue("@3thang", bandedGridView1.GetFocusedRowCellValue(col3thang));
                cmd.Parameters.AddWithValue("@6thang", bandedGridView1.GetFocusedRowCellValue(col6thang));
                cmd.Parameters.AddWithValue("@1nam", bandedGridView1.GetFocusedRowCellValue(col1nam));
                cmd.Parameters.AddWithValue("@Donvi", bandedGridView1.GetFocusedRowCellDisplayText(colDonvi));
                /////////////////////////////////////////////////////////////////////////////////////////// add new
                cmd.Parameters.AddWithValue("@Done", bandedGridView1.GetFocusedRowCellValue(colDone));
                if ((bool)bandedGridView1.GetFocusedRowCellValue(colDone))
                {
                    cmd.Parameters.AddWithValue("@Approver", clsCommon.Common._username);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Approver", "");
                }              
                ///////////////////////////////////////////////////////////////////////////////////////////
                cmd.Parameters.AddWithValue("@GhiChu", bandedGridView1.GetFocusedRowCellDisplayText(colGhiChu));
                cmd.Parameters.AddWithValue("@IDDept", txtDept.EditValue.ToString());               
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ccon.Close(); }

        }

        private void bandedGridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            DateTime _ngay;
            try
            {
                _ngay = Convert.ToDateTime(bandedGridView2.GetFocusedRowCellValue(colThangNam));
                if (_ngay.Year == 0001)
                {
                    _ngay = Convert.ToDateTime(fromDate.EditValue.ToString());
                }
            }
            catch { _ngay = Convert.ToDateTime(fromDate.EditValue.ToString()); }
            string _daysave = _ngay.ToString("yyyy-MM-") + "01 01:00:00";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_BaoTriThangISO";
                cmd.Parameters.AddWithValue("@ID", bandedGridView2.GetFocusedRowCellValue(colID1));
                cmd.Parameters.AddWithValue("@TenCum", bandedGridView2.GetFocusedRowCellValue(colTenCum1).ToString());
                cmd.Parameters.AddWithValue("@NoiDung", bandedGridView2.GetFocusedRowCellValue(colNoiDung1).ToString());
                cmd.Parameters.AddWithValue("@ThangNam", _daysave);
                cmd.Parameters.AddWithValue("@day1", bandedGridView2.GetFocusedRowCellValue(colday1));
                cmd.Parameters.AddWithValue("@day2", bandedGridView2.GetFocusedRowCellValue(colday2));
                cmd.Parameters.AddWithValue("@day3", bandedGridView2.GetFocusedRowCellValue(colday3));
                cmd.Parameters.AddWithValue("@day4", bandedGridView2.GetFocusedRowCellValue(colday4));
                cmd.Parameters.AddWithValue("@day5", bandedGridView2.GetFocusedRowCellValue(colday5));
                cmd.Parameters.AddWithValue("@day6", bandedGridView2.GetFocusedRowCellValue(colday6));
                cmd.Parameters.AddWithValue("@day7", bandedGridView2.GetFocusedRowCellValue(colday7));
                cmd.Parameters.AddWithValue("@day8", bandedGridView2.GetFocusedRowCellValue(colday8));
                cmd.Parameters.AddWithValue("@day9", bandedGridView2.GetFocusedRowCellValue(colday9));
                cmd.Parameters.AddWithValue("@day10", bandedGridView2.GetFocusedRowCellValue(colday10));
                cmd.Parameters.AddWithValue("@day11", bandedGridView2.GetFocusedRowCellValue(colday11));
                cmd.Parameters.AddWithValue("@day12", bandedGridView2.GetFocusedRowCellValue(colday12));
                cmd.Parameters.AddWithValue("@day13", bandedGridView2.GetFocusedRowCellValue(colday13));
                cmd.Parameters.AddWithValue("@day14", bandedGridView2.GetFocusedRowCellValue(colday14));
                cmd.Parameters.AddWithValue("@day15", bandedGridView2.GetFocusedRowCellValue(colday15));
                cmd.Parameters.AddWithValue("@day16", bandedGridView2.GetFocusedRowCellValue(colday16));
                cmd.Parameters.AddWithValue("@day17", bandedGridView2.GetFocusedRowCellValue(colday17));
                cmd.Parameters.AddWithValue("@day18", bandedGridView2.GetFocusedRowCellValue(colday18));
                cmd.Parameters.AddWithValue("@day19", bandedGridView2.GetFocusedRowCellValue(colday19));
                cmd.Parameters.AddWithValue("@day20", bandedGridView2.GetFocusedRowCellValue(colday20));
                cmd.Parameters.AddWithValue("@day21", bandedGridView2.GetFocusedRowCellValue(colday21));
                cmd.Parameters.AddWithValue("@day22", bandedGridView2.GetFocusedRowCellValue(colday22));
                cmd.Parameters.AddWithValue("@day23", bandedGridView2.GetFocusedRowCellValue(colday23));
                cmd.Parameters.AddWithValue("@day24", bandedGridView2.GetFocusedRowCellValue(colday24));
                cmd.Parameters.AddWithValue("@day25", bandedGridView2.GetFocusedRowCellValue(colday25));
                cmd.Parameters.AddWithValue("@day26", bandedGridView2.GetFocusedRowCellValue(colday26));
                cmd.Parameters.AddWithValue("@day27", bandedGridView2.GetFocusedRowCellValue(colday27));
                cmd.Parameters.AddWithValue("@day28", bandedGridView2.GetFocusedRowCellValue(colday28));
                cmd.Parameters.AddWithValue("@day29", bandedGridView2.GetFocusedRowCellValue(colday29));
                cmd.Parameters.AddWithValue("@day30", bandedGridView2.GetFocusedRowCellValue(colday30));
                cmd.Parameters.AddWithValue("@day31", bandedGridView2.GetFocusedRowCellValue(colday31));
                cmd.Parameters.AddWithValue("@IDDept", txtDept1.EditValue.ToString());
                /////////////////////////////////////////////////////////////////////////////////////////// add new
                cmd.Parameters.AddWithValue("@Done", bandedGridView2.GetFocusedRowCellValue(colDone));
                if ((bool)bandedGridView2.GetFocusedRowCellValue(colDone))
                {
                    cmd.Parameters.AddWithValue("@Approver", clsCommon.Common._username);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Approver", "");
                }            
                
                cmd.Parameters.AddWithValue("@GhiChu", bandedGridView2.GetFocusedRowCellDisplayText(colGhiChu));
                ///////////////////////////////////////////////////////////////////////////////////////////
                
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ccon.Close(); }
        }

        private void bandedGridView3_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            DateTime _ngay;
            try
            {
                _ngay = Convert.ToDateTime(bandedGridView3.GetFocusedRowCellValue(colThangNam1));
                if (_ngay.Year == 0001)
                {
                    _ngay = Convert.ToDateTime(fromDate1.EditValue.ToString());
                }
            }
            catch { _ngay = Convert.ToDateTime(fromDate1.EditValue.ToString()); }
            string _daysave = _ngay.ToString("yyyy-") + "01-01 01:00:00";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_BaoTriNamISO";
                cmd.Parameters.AddWithValue("@ID", bandedGridView3.GetFocusedRowCellValue(colID2));
                cmd.Parameters.AddWithValue("@TenCum", bandedGridView3.GetFocusedRowCellValue(colTenCum2).ToString());
                cmd.Parameters.AddWithValue("@NoiDung", bandedGridView3.GetFocusedRowCellValue(colNoiDung2).ToString());
                cmd.Parameters.AddWithValue("@ThangNam", _daysave);
                cmd.Parameters.AddWithValue("@Thang1", bandedGridView3.GetFocusedRowCellValue(colThang1));
                cmd.Parameters.AddWithValue("@Thang2", bandedGridView3.GetFocusedRowCellValue(colThang2));
                cmd.Parameters.AddWithValue("@Thang3", bandedGridView3.GetFocusedRowCellValue(colThang3));
                cmd.Parameters.AddWithValue("@Thang4", bandedGridView3.GetFocusedRowCellValue(colThang4));
                cmd.Parameters.AddWithValue("@Thang5", bandedGridView3.GetFocusedRowCellValue(colThang5));
                cmd.Parameters.AddWithValue("@Thang6", bandedGridView3.GetFocusedRowCellValue(colThang6));
                cmd.Parameters.AddWithValue("@Thang7", bandedGridView3.GetFocusedRowCellValue(colThang7));
                cmd.Parameters.AddWithValue("@Thang8", bandedGridView3.GetFocusedRowCellValue(colThang8));
                cmd.Parameters.AddWithValue("@Thang9", bandedGridView3.GetFocusedRowCellValue(colThang9));
                cmd.Parameters.AddWithValue("@Thang10", bandedGridView3.GetFocusedRowCellValue(colThang10));
                cmd.Parameters.AddWithValue("@Thang11", bandedGridView3.GetFocusedRowCellValue(colThang11));
                cmd.Parameters.AddWithValue("@Thang12", bandedGridView3.GetFocusedRowCellValue(colThang12));              
                cmd.Parameters.AddWithValue("@IDDept", txtDept2.EditValue.ToString());
                /////////////////////////////////////////////////////////////////////////////////////////// add new
                cmd.Parameters.AddWithValue("@Done", bandedGridView3.GetFocusedRowCellValue(colDone));
                if ((bool)bandedGridView3.GetFocusedRowCellValue(colDone))
                {
                    cmd.Parameters.AddWithValue("@Approver", clsCommon.Common._username);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Approver", "");
                }            
                cmd.Parameters.AddWithValue("@GhiChu", bandedGridView3.GetFocusedRowCellDisplayText(colGhiChu));
                ///////////////////////////////////////////////////////////////////////////////////////////
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ccon.Close(); }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                bandedGridView1.OptionsBehavior.ReadOnly = false;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                colTenCum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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
                        cmd.CommandText = "Message_Save_Delete_BaoTriISO";
                        cmd.Parameters.AddWithValue("@ID", bandedGridView1.GetFocusedRowCellDisplayText(colID));
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
                 MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
             }

            try
            {
                colTenCum.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                bandedGridView1.OptionsBehavior.ReadOnly = true;
                bandedGridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriISOTableAdapter.Fill(dataSet_Get_BaoTriISO.Data_Get_BaoTriISO, txtDept.EditValue.ToString());


            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept1.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                bandedGridView2.OptionsBehavior.ReadOnly = false;
                bandedGridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                colTenCum1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept1.EditValue.ToString() && (Common._adminLocal || Common._editer)))
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
                        cmd.CommandText = "Message_Save_Delete_BaoTriThangISO";
                        cmd.Parameters.AddWithValue("@ID", bandedGridView2.GetFocusedRowCellDisplayText(colID1));
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
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }

            DateTime _day;
            try
            {
                _day = Convert.ToDateTime(fromDate.EditValue.ToString());
            }
            catch { _day = DateTime.Now; }
            DateTime _fromday = new DateTime(_day.Year, _day.Month, 1);
            try
            {
                colTenCum1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                bandedGridView2.OptionsBehavior.ReadOnly = true;
                bandedGridView2.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept1.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriThangISOTableAdapter.Fill(dataSet_Get_BaoTriThangISO.Data_Get_BaoTriThangISO, txtDept1.EditValue.ToString(), _fromday);
            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }

        }

        private void bandedGridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void bandedGridView2_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void bandedGridView3_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept2.EditValue.ToString() && (Common._adminLocal || Common._editer)))
            {
                bandedGridView3.OptionsBehavior.ReadOnly = false;
                bandedGridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                colTenCum2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;

            }
            else
            {
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }
        }

        private void delteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == txtDept2.EditValue.ToString() && (Common._adminLocal || Common._editer)))
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
                        cmd.CommandText = "Message_Save_Delete_BaoTriNamISO";
                        cmd.Parameters.AddWithValue("@ID", bandedGridView3.GetFocusedRowCellDisplayText(colID2));
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
                MessageBox.Show("Chưa Chọn đúng Dây chuyền Sản Xuất của mình!!!Hoặc Bạn không được cấp quyền. ");
            }

            DateTime _day;
            try
            {
                _day = Convert.ToDateTime(fromDate1.EditValue.ToString());
            }
            catch { _day = DateTime.Now; }
            try
            {
                colTenCum2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                bandedGridView3.OptionsBehavior.ReadOnly = true;
                bandedGridView3.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                if (txtDept2.EditValue.ToString() == "_0000")
                    MessageBox.Show("Chọn dây chuyền ...");
                else
                    this.data_Get_BaoTriNamISOTableAdapter.Fill(dataSet_Get_BaoTriNamISO.Data_Get_BaoTriNamISO, txtDept2.EditValue.ToString(), _day.Year);
            }
            catch
            {
                MessageBox.Show("Chọn dây chuyền ...");
            }

        }

        private void btnExcel1_Click(object sender, EventArgs e)
        {
            Report.frmReportISO f_report = new Report.frmReportISO();
            f_report._iddept = txtDept1.EditValue.ToString();
            f_report._split = 2;
            f_report._daychuyen = txtDept1.Text;
            DateTime _day1;
            try
            {
                _day1 = Convert.ToDateTime(fromDate.EditValue.ToString());
            }
            catch { _day1 = DateTime.Now; }
            f_report._day = new DateTime(_day1.Year, _day1.Month, 1);
            f_report.Show();
        }

        private void btnExcel2_Click(object sender, EventArgs e)
        {
            Report.frmReportISO f_report = new Report.frmReportISO();
            f_report._iddept = txtDept2.EditValue.ToString();
            f_report._split = 3;
            f_report._daychuyen = txtDept2.Text;
            DateTime _day1;
            try
            {
                _day1 = Convert.ToDateTime(fromDate1.EditValue.ToString());
            }
            catch { _day1 = DateTime.Now; }
            f_report._day = new DateTime(_day1.Year, 1, 1);
            f_report.Show();
        }
    }
}