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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using System.Data.SqlClient;
using HS_QuanLyBaoTri.clsCommon;

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmDetailEquipments : DevExpress.XtraEditors.XtraForm
    {
        public string _IDDept = string.Empty;
        public string _IDEquipments = string.Empty;
        bool chkimg1 = false;
        bool chkimg2 = false;
        bool chkimg3 = false;
        bool chkimg4 = false;
        bool chkimg5 = false;
        byte[] _bimage;

        public frmDetailEquipments()
        {
            InitializeComponent();
        }

       
        private void btnLuuvsDong_Click(object sender, EventArgs e)
        {
            //clsCommon.Common.ExcuteQuery("Update [HS-QuanLyBaoTri].[dbo].[tblEquipments] set [WhoAdd]=N'" + clsCommon.Common._username + "' WHERE Equipments='" + txttenthietbi.Text + "'");

            if (Common._suUser || (Common._idDept == _IDDept && (Common._adminLocal || Common._editer)))
            {
                if (_IDEquipments != "")
                {
                    Save_Image(_IDEquipments);
                    gridView4.CloseEditor();
                    for (int i = 0; i < gridView4.RowCount; i++)
                    {
                        try
                        {
                            if (gridView4.GetRowCellDisplayText(i, colIDEquipments).ToString() == "0000")
                            {
                                save_documents(_IDEquipments, gridView4.GetRowCellDisplayText(i, colLinkMachine).ToString(), i);
                            }
                        }
                        catch
                        {
                            save_documents(_IDEquipments, gridView4.GetRowCellDisplayText(i, colLinkMachine).ToString(), i);
                        }
                    }
                    Save_CheckingList(_IDEquipments);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Bạn không được cấp quyền. ");
            }
        }
        
        void Save_Image(string _code)
        {
            if (pictureEdit1.Image != null)
            {
                if (chkimg1 == true)
                {
                    //pictureEdit1.Image.Save(@"D:\Share\" + _code + "_1.jpg");
                    Change_SizeImage_Save(_code, 1, pictureEdit1.Image);
                    _bimage = Common.convertImage(pictureEdit1.Image);
                    Common.Save_Image(1, _IDEquipments, _bimage);
                }
            }
            if (pictureEdit2.Image != null)
            {
                if (chkimg2 == true)
                {
                    //pictureEdit2.Image.Save(@"D:\Share\" + _code + "_2.jpg");
                    Change_SizeImage_Save(_code, 2, pictureEdit2.Image);
                    _bimage = Common.convertImage(pictureEdit2.Image);
                    Common.Save_Image(2, _IDEquipments, _bimage);
                }
            }
            if (pictureEdit3.Image != null)
            {
                if (chkimg3 == true)
                {
                    // pictureEdit3.Image.Save(@"D:\Share\" + _code + "_3.jpg");
                    Change_SizeImage_Save(_code, 3, pictureEdit3.Image);
                    _bimage = Common.convertImage(pictureEdit3.Image);
                    Common.Save_Image(3, _IDEquipments, _bimage);
                }
            }
            if (pictureEdit4.Image != null)
            {
                if (chkimg4 == true)
                {
                    // pictureEdit4.Image.Save(@"D:\Share\" + _code + "_4.jpg");
                    Change_SizeImage_Save(_code, 4, pictureEdit4.Image);
                    _bimage = Common.convertImage(pictureEdit4.Image);
                    Common.Save_Image(4, _IDEquipments, _bimage);
                }
            }
            if (pictureEdit5.Image != null)
            {
                if (chkimg5 == true)
                {
                    // pictureEdit5.Image.Save(@"D:\Share\" + _code + "_5.jpg");
                    Change_SizeImage_Save(_code, 5, pictureEdit5.Image);
                    _bimage = Common.convertImage(pictureEdit5.Image);
                    Common.Save_Image(5, _IDEquipments, _bimage);
                }
            }
        }
        void Save_CheckingList(string _code)
        {
            DateTime _datefrom, _dateto, _hanbaohanh;
            try
            {
                _datefrom = Convert.ToDateTime(startDate.EditValue.ToString());
                if (_datefrom.Year == 0001)
                {
                    MessageBox.Show("Chưa nhập thời gian bắt đầu !!!");
                    return;
                }
            }
            catch { _datefrom = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd"))); }
            try
            {
                _dateto = Convert.ToDateTime(endDate.EditValue.ToString());
                if (_dateto.Year == 0001)
                {
                    _dateto = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd")));
                }
            }
            catch { _dateto = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd"))); }
            try
            {
                _hanbaohanh = Convert.ToDateTime(txtHanbaohanh.EditValue.ToString());
                if (_hanbaohanh.Year == 0001)
                {
                    _hanbaohanh = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd")));
                }
            }
            catch { _hanbaohanh = Convert.ToDateTime("1993-" + (DateTime.Now.ToString("MM-dd"))); }
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Message_Save_Update_DetailsEquipments";
                cmd.Parameters.AddWithValue("@IDEquipments", _IDEquipments);
                cmd.Parameters.AddWithValue("@Daily", chkDaily.Checked);
                cmd.Parameters.AddWithValue("@SoNgay", txtDays.EditValue.ToString());
                cmd.Parameters.AddWithValue("@Weekly", chkWeekly.Checked);
                cmd.Parameters.AddWithValue("@SoTuan", txtWeek.EditValue.ToString());
                cmd.Parameters.AddWithValue("@T2", chkT2.Checked);
                cmd.Parameters.AddWithValue("@T3", chkT3.Checked);
                cmd.Parameters.AddWithValue("@T4", chkT4.Checked);
                cmd.Parameters.AddWithValue("@T5", chkT5.Checked);
                cmd.Parameters.AddWithValue("@T6", chkT6.Checked);
                cmd.Parameters.AddWithValue("@T7", chkT7.Checked);
                cmd.Parameters.AddWithValue("@CN", chkCN.Checked);
                cmd.Parameters.AddWithValue("@Monthly", chkMonthly.Checked);
                cmd.Parameters.AddWithValue("@NgayofThang", txtDayMonth.EditValue.ToString());
                cmd.Parameters.AddWithValue("@SoThang", txtMonth.EditValue.ToString());
                cmd.Parameters.AddWithValue("@Yearly", chkYearly.Checked);
                cmd.Parameters.AddWithValue("@NgayThangofNam", dateEdit1.Text);
                cmd.Parameters.AddWithValue("@SoNam", txtYear.EditValue.ToString());
                cmd.Parameters.AddWithValue("@StartDate", _datefrom);
                cmd.Parameters.AddWithValue("@EndDate", _dateto);
                cmd.Parameters.AddWithValue("@Donvibaohanh", txtDonvibaohanh.Text);
                cmd.Parameters.AddWithValue("@Hanbaohanh", _hanbaohanh);
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { }
        }
        void Change_SizeImage_Save(string _code, int _i, Image _img)
        {
            Bitmap map = new Bitmap(_img, new Size(1024, 768));
            try
            {
                map.Save(Common._pathfileImage + _code + "_" + _i + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch { }
        }

        string defineStypeFile(string _path)    
        {
            if (_path == "" || _path == "Không tài liệu")
            {
                return "Không tài liệu";
            }
            string _typefile = _path.Substring(_path.LastIndexOf('.')).ToLower();
            if (_typefile == ".dwg")
            {
                return ".Cad File";
            }
            else if(_typefile==".pdf")
            {
                return ".PDF File";
            }
            else
            {
                return ".Office File";
            }
        }

        void save_documents(string _code, string _path, int i)
        {
            string _pathTo = string.Empty;
            if (string.IsNullOrEmpty(_path)) return;
            if (File.Exists(_path) == false)
            {
                return;
            }
            string _typefile = _path.Substring(_path.LastIndexOf('.')).ToLower();
            if (_typefile == ".dwg")
            {
                try
                {
                    _pathTo = Common._pathfileDocument + _code + "_1_" + i + "_" + DateTime.Now.ToString("dd_MM") + ".dwg";
                    //_pathTo = @"\\172.17.25.76\Folder_VTDP_Share\Document\" + _code + "_1"+ DateTime.Now.ToString()+".dwg";
                    File.Copy(_path, _pathTo);
                }
                catch
                {

                }
            }
            else if (_typefile == ".pdf")
            {
                try
                {
                    _pathTo = Common._pathfileDocument + _code + "_2_" + i + "_" + DateTime.Now.ToString("dd_MM") + ".pdf";
                    File.Copy(_path, _pathTo);
                }
                catch
                {

                }
            }
            else
            {
                try
                {
                    _pathTo = Common._pathfileDocument + _code + "_3_" + i + "_" + DateTime.Now.ToString("dd_MM") + _typefile;
                    File.Copy(_path, _pathTo);
                }
                catch
                {

                }
            }
            SqlConnection ccon = new SqlConnection(clsCommon.Common._connection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ccon;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@linksever", _pathTo);
                cmd.Parameters.AddWithValue("@IDEquipments", _IDEquipments);
                cmd.Parameters.AddWithValue("@linkmachine", _path);
                cmd.Parameters.AddWithValue("@typefile", _typefile);
                cmd.CommandText = "Message_Save_Document";
                ccon.Open();
                cmd.ExecuteNonQuery();
                ccon.Close();
            }
            catch { ;}

        }
        void DeleteReadonly_File(string _path)
        {
            File.SetAttributes(_path, FileAttributes.Normal);
            File.Delete(_path);
        }

        private void txttailieukt_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog dlog = new OpenFileDialog();
            dlog.Title = "Open file";
            dlog.Filter = "(*.dwg, *.pdf, *.doc, *.docx, *.xls, *.xlsx)|*.dwg;*.pdf;*.doc;*.docx;*.xls;*.xlsx";
            dlog.Multiselect = true;
            dlog.InitialDirectory = @"Libraries\Pictures";
            if(dlog.ShowDialog()==DialogResult.OK)
            {
                foreach (String file in dlog.FileNames)
                {
                    try
                    {
                        gridView4.AddNewRow();
                        gridView4.SetFocusedRowCellValue(colLinkMachine, file);
                        gridView4.SetFocusedRowCellValue(colIDEquipments, "0000");
                    }
                    catch
                    {

                    }
                }
                txttailieukt.Text = dlog.FileName;
            }
        }


        private void txtidclass4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_ImageChanged(object sender, EventArgs e)
        {
            if (pictureEdit1.Image != null)
            {
                chkimg1 = true;
            }
        }

        private void pictureEdit2_ImageChanged(object sender, EventArgs e)
        {
            if (pictureEdit2.Image != null)
            {
                chkimg2 = true;
            }
        }

        private void pictureEdit3_ImageChanged(object sender, EventArgs e)
        {
            if (pictureEdit3.Image != null)
            {
                chkimg3 = true;
            }
        }

        private void pictureEdit4_ImageChanged(object sender, EventArgs e)
        {
            if (pictureEdit4.Image != null)
            {
                chkimg4 = true;
            }
        }

        private void pictureEdit5_ImageChanged(object sender, EventArgs e)
        {
            if (pictureEdit5.Image != null)
            {
                chkimg5 = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gridView4.GetFocusedRowCellDisplayText(colIDEquipments).ToString() == "0000")
            {
                gridView4.DeleteRow(gridView4.FocusedRowHandle);
            }
            else
            {
                XtraMessageBox.Show("Tài liệu này đã lưu vào server không được quyền xóa!!!");
                
            }
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
        }

        private void frmDetailEquipments_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmDetailEquipments_Shown(object sender, EventArgs e)
        {
            GridColumn hyperLinkColumn = gridView4.Columns["LinkMachine"];
            RepositoryItemHyperLinkEdit hyperLinkEdit = new RepositoryItemHyperLinkEdit();
            hyperLinkColumn.ColumnEdit = hyperLinkEdit; // this line associated hyperlink with column
            hyperLinkEdit.OpenLink += hyperLinkEdit_OpenLink;
        }
        public void hyperLinkEdit_OpenLink(object sender, OpenLinkEventArgs e)
        {
            MessageBox.Show("Mở file!");
        }
        private void frmDetailEquipments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Get_GroupEquiments.tblGroupEquipments' table. You can move, or remove it, as needed.
            this.tblGroupEquipmentsTableAdapter.Fill(this.dataSet_Get_GroupEquiments.tblGroupEquipments);
            this.data_Get_DocumentTableAdapter.Fill(this.dataSet_GetDocumentsEQ.Data_Get_Document, _IDEquipments);
            try
            {
                string _query = "select * from [HS-QuanLyBaoTri].[dbo].[tblEquipments] Where [IDEquipments]='" + _IDEquipments + "'";
                DataTable dt = clsCommon.Common.SQLReadDatabaseClient(_query);
                if (dt.Rows.Count > 0)
                {
                    txttenthietbi.Text = dt.Rows[0]["Equipments"].ToString();
                    txtGroupEQ.EditValue = dt.Rows[0]["IDGroupEQ"].ToString();
                    txtmota.Text = dt.Rows[0]["Describes"].ToString();
                    txtERP.Text = dt.Rows[0]["ERPCode"].ToString();
                    txtSLDC.Text = dt.Rows[0]["SLDC"].ToString();
                    txtDP.Text = dt.Rows[0]["SLDP"].ToString();
                    txthangsanxuat.Text = dt.Rows[0]["Supplier"].ToString();
                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
                }
            }
            catch { ;}
            DataTable dt1 = Common.Execute_Get_ImageEQ(_IDEquipments);
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    try
                    {
                        byte[] img = (byte[])dt1.Rows[i]["Image1"];
                        MemoryStream i_m = new MemoryStream(img);
                        if ((int)dt1.Rows[i]["numberimage"] == 1)
                        {
                            pictureEdit1.Image = (Image.FromStream(i_m));
                        }
                        else if ((int)dt1.Rows[i]["numberimage"] == 2)
                        {
                            pictureEdit2.Image = (Image.FromStream(i_m));
                        }
                        else if ((int)dt1.Rows[i]["numberimage"] == 3)
                        {
                            pictureEdit3.Image = (Image.FromStream(i_m));
                        }
                        else if ((int)dt1.Rows[i]["numberimage"] == 4)
                        {
                            pictureEdit4.Image = (Image.FromStream(i_m));
                        }
                        else if ((int)dt1.Rows[i]["numberimage"] == 5)
                        {
                            pictureEdit5.Image = (Image.FromStream(i_m));
                        }
                    }
                    catch
                    { }
                }
            }
            DataTable dt2 = Common.Execute_Get_DetailEQ(_IDEquipments);
            if (dt2.Rows.Count > 0)
            {
                chkDaily.Checked = string.IsNullOrEmpty(dt2.Rows[0]["Daily"].ToString()) ? false : (bool)dt2.Rows[0]["Daily"];
                txtDays.Text = dt2.Rows[0]["SoNgay"].ToString();
                chkWeekly.Checked = string.IsNullOrEmpty(dt2.Rows[0]["Weekly"].ToString()) ? false : (bool)dt2.Rows[0]["Weekly"];
                txtWeek.Text = dt2.Rows[0]["SoTuan"].ToString();
                chkT2.Checked = string.IsNullOrEmpty(dt2.Rows[0]["T2"].ToString()) ? false : (bool)dt2.Rows[0]["T2"];
                chkT3.Checked = string.IsNullOrEmpty(dt2.Rows[0]["T3"].ToString()) ? false : (bool)dt2.Rows[0]["T3"];
                chkT4.Checked = string.IsNullOrEmpty(dt2.Rows[0]["T4"].ToString()) ? false : (bool)dt2.Rows[0]["T4"];
                chkT5.Checked = string.IsNullOrEmpty(dt2.Rows[0]["T5"].ToString()) ? false : (bool)dt2.Rows[0]["T5"];
                chkT6.Checked = string.IsNullOrEmpty(dt2.Rows[0]["T6"].ToString()) ? false : (bool)dt2.Rows[0]["T6"];
                chkT7.Checked = string.IsNullOrEmpty(dt2.Rows[0]["T7"].ToString()) ? false : (bool)dt2.Rows[0]["T7"];
                chkCN.Checked = string.IsNullOrEmpty(dt2.Rows[0]["CN"].ToString()) ? false : (bool)dt2.Rows[0]["CN"];
                chkMonthly.Checked = string.IsNullOrEmpty(dt2.Rows[0]["Monthly"].ToString()) ? false : (bool)dt2.Rows[0]["Monthly"];
                txtDayMonth.Text = dt2.Rows[0]["NgayofThang"].ToString();
                txtMonth.Text = dt2.Rows[0]["SoThang"].ToString();
                chkYearly.Checked = string.IsNullOrEmpty(dt2.Rows[0]["Yearly"].ToString()) ? false : (bool)dt2.Rows[0]["Yearly"];
                txtYear.Text = dt2.Rows[0]["SoNam"].ToString();
                 try
                {
                startDate.EditValue = dt2.Rows[0]["StartDate"];
                }
                catch { }
                 try
                {
                endDate.EditValue = dt2.Rows[0]["EndDate"];
                }
                 catch { }
                txtDonvibaohanh.Text = dt2.Rows[0]["DonViBaoHanh"].ToString();
                try
                {
                    txtHanbaohanh.EditValue = dt2.Rows[0]["HanBaoHanh"];
                }
                catch {  }
                 try
                {
                dateEdit1.EditValue = Convert.ToDateTime(dt2.Rows[0]["NgayThangofNam"].ToString() + "-2017");
                }
                 catch { }
            }

        }

        private void chkDaily_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDaily.Checked)
            {
                chkDaily.Checked = true;
                chkWeekly.Checked = false;
                chkMonthly.Checked = false;
                chkYearly.Checked = false;
                panelDaily.Visible = true;
                panelMonth.Visible = false;
                panelWeek.Visible = false;
            }

        }

        private void chkWeekly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWeekly.Checked)
            {
                chkDaily.Checked = false;
                chkWeekly.Checked = true;
                chkMonthly.Checked = false;
                chkYearly.Checked = false;
                panelDaily.Visible = false;
                panelMonth.Visible = false;
                panelWeek.Visible = true;
            }
        }

        private void chkMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonthly.Checked)
            {
                chkDaily.Checked = false;
                chkWeekly.Checked = false;
                chkMonthly.Checked = true;
                chkYearly.Checked = false;
                panelDaily.Visible = false;
                panelMonth.Visible = true;
                panelWeek.Visible = false;
                label6.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                txtDayMonth.Visible = true;
                txtMonth.Visible = true;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                dateEdit1.Visible =false;
                txtYear.Visible = false;
            }
        }

        private void chkYearly_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYearly.Checked)
            {
                chkDaily.Checked = false;
                chkWeekly.Checked = false;
                chkMonthly.Checked = false;
                chkYearly.Checked = true;
                panelDaily.Visible = false;
                panelMonth.Visible = true;
                panelWeek.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                txtDayMonth.Visible = false;
                txtMonth.Visible = false;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                dateEdit1.Visible = true;
                txtYear.Visible = true;
            }
        }
    }
}