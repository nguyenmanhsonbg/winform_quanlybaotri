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
    public partial class ImageProblem : DevExpress.XtraEditors.XtraForm
    {
        public ImageProblem()
        {
            InitializeComponent();
        }

        public string Title;
        public string _IDProblem;
        public string _IDDept;
        public string Dept;

        bool chkimg1 = false;
        bool chkimg2 = false;
        bool chkimg3 = false;
        bool chkimg4 = false;
        bool chkimg5 = false;
        byte[] _bimage;

        private void ImageProblem_Load(object sender, EventArgs e)
        {
            label1.Text = Title;
            DataTable dt1 = Common.Execute_Get_Image_Problems(_IDProblem);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Common._suUser || (Common._idDept == _IDDept && (Common._adminLocal || Common._editer)))
            {
                if (_IDProblem != "")
                {
                    Save_Image(Dept+"_"+_IDProblem);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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
                    Common.Save_ImageProblem(1, _IDProblem, _bimage);
                }
            }
            if (pictureEdit2.Image != null)
            {
                if (chkimg2 == true)
                {
                    //pictureEdit2.Image.Save(@"D:\Share\" + _code + "_2.jpg");
                    Change_SizeImage_Save(_code, 2, pictureEdit2.Image);
                    _bimage = Common.convertImage(pictureEdit2.Image);
                    Common.Save_ImageProblem(2, _IDProblem, _bimage);
                }
            }
            if (pictureEdit3.Image != null)
            {
                if (chkimg3 == true)
                {
                    // pictureEdit3.Image.Save(@"D:\Share\" + _code + "_3.jpg");
                    Change_SizeImage_Save(_code, 3, pictureEdit3.Image);
                    _bimage = Common.convertImage(pictureEdit3.Image);
                    Common.Save_ImageProblem(3, _IDProblem, _bimage);
                }
            }
            if (pictureEdit4.Image != null)
            {
                if (chkimg4 == true)
                {
                    // pictureEdit4.Image.Save(@"D:\Share\" + _code + "_4.jpg");
                    Change_SizeImage_Save(_code, 4, pictureEdit4.Image);
                    _bimage = Common.convertImage(pictureEdit4.Image);
                    Common.Save_ImageProblem(4, _IDProblem, _bimage);
                }
            }
            if (pictureEdit5.Image != null)
            {
                if (chkimg5 == true)
                {
                    // pictureEdit5.Image.Save(@"D:\Share\" + _code + "_5.jpg");
                    Change_SizeImage_Save(_code, 5, pictureEdit5.Image);
                    _bimage = Common.convertImage(pictureEdit5.Image);
                    Common.Save_ImageProblem(5, _IDProblem, _bimage);
                }
            }
        }
        void Change_SizeImage_Save(string _code, int _i, Image _img)
        {
            Bitmap map = new Bitmap(_img, new Size(1024, 768));
            try
            {
                map.Save(Common._pathfileImageProblem + _code + "_" + _i + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch { }
        }
    }
}