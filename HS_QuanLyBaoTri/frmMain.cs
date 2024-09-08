using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using BALayer;
//using BELayer;

namespace HS_QuanLyBaoTri
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmSchedule f_schedule = null;
        frmSchedule_Big f_schedule_big = null;
        frmEquipments f_EQ = null;
        frmChild.frmPurchaseEQ f_pur = null;
        frmChild.frmPurchaseEQ_1 f_pur1 = null;
        frmChild.frmProblem f_Problem = null;
        frmChild.frmTonKho f_tk = null;
        frmCheckingListEquipments f_check = null;
        frmChild.frmStaff f_staff = null;
        frmChild.frmTaiKhoan f_user = null;
        frmChangePass f_changepass = null;
        frmCheckingDetails_Alltime f_all = null;

        frmChild.frmThietBiXeNang f_xenang = null;
        frmChild.frmBaoTri_ISO f_iso = null;
        frmChild.frmNhapKho f_nhap = null;
        frmChild.frmXuatKho f_xuat = null;

        frmGroupEquipments f_cumTB = null;

        public frmMain()
        {
            InitializeComponent();
        }



        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_user == null || f_user.IsDisposed)
            {
                f_user = new frmChild.frmTaiKhoan();
                f_user.MdiParent = frmMain.ActiveForm;
                f_user.Dock = DockStyle.Fill;
                f_user.Show();
            }
            else
            {
                f_user.Activate();
            }
        }

        private void btnChange_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_changepass = new frmChangePass();
            if (f_changepass.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Restart();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }


        private void btnSchedule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_schedule == null || f_schedule.IsDisposed) // kiểm tra xem Form Schedule chưa được khởi tạo hay đã bị đóng hay ko
            {
                f_schedule = new frmSchedule();
                f_schedule.MdiParent = frmMain.ActiveForm;
                f_schedule.Dock = DockStyle.Fill;
                f_schedule.Show();
            }
            else // nếu chưa đóng hay đã được khởi tạo rồi thì chỉ cần kích hoạt cho nó chạy lại
            {
                f_schedule.Activate();
            }
        }

        private void btnThietBi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_EQ == null || f_EQ.IsDisposed)
            {
                f_EQ = new frmEquipments();
                f_EQ.MdiParent = frmMain.ActiveForm;
                f_EQ.Dock = DockStyle.Fill;
                f_EQ.Show();
            }
            else
            {
                f_EQ.Activate();
            }
        }

        private void btnNewPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_pur1 == null || f_pur1.IsDisposed)
            {
                f_pur1 = new frmChild.frmPurchaseEQ_1();
                f_pur1.MdiParent = frmMain.ActiveForm;
                f_pur1.Dock = DockStyle.Fill;
                f_pur1.Show();
            }
            else
            {
                f_pur1.Activate();
            }
            
        }

        private void btnTheoDoiSuCo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_Problem == null || f_Problem.IsDisposed)
            {
                f_Problem = new frmChild.frmProblem();
                f_Problem.MdiParent = frmMain.ActiveForm;
                f_Problem.Dock = DockStyle.Fill;
                f_Problem.Show();
            }
            else
            {
                f_Problem.Activate();
            }
            
        }

        private void btnTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (f_tk == null || f_tk.IsDisposed)
            {
                f_tk = new frmChild.frmTonKho();
                f_tk.MdiParent = frmMain.ActiveForm;
                f_tk.Dock = DockStyle.Fill;
                f_tk.Show();
            }
            else
            {
                f_tk.Activate();
            }
        }

        private void btnCheckingList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            
        }

        private void btnStaff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_staff == null || f_staff.IsDisposed)
            {
                f_staff = new frmChild.frmStaff();
                f_staff.MdiParent = frmMain.ActiveForm;
                f_staff.Dock = DockStyle.Fill;
                f_staff.Show();
            }
            else
            {
                f_staff.Activate();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (f_schedule_big == null || f_schedule_big.IsDisposed)
                {
                    f_schedule_big = new frmSchedule_Big();
                    f_schedule_big.MdiParent = frmMain.ActiveForm;
                    f_schedule_big.Dock = DockStyle.Fill;
                    f_schedule_big.Show();
                }
                else
                {
                    f_schedule_big.Activate();
                }
            }
            catch { return; }
        }

        private void btnDailyCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_check == null || f_check.IsDisposed)
            {
                f_check = new frmCheckingListEquipments();
                f_check.MdiParent = frmMain.ActiveForm;
                f_check.Dock = DockStyle.Fill;
                f_check.Show();
            }
            else
            {
                f_check.Activate();
            }
        }

        private void btnAllCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_all == null || f_all.IsDisposed)
            {
                f_all = new frmCheckingDetails_Alltime();
                f_all.MdiParent = frmMain.ActiveForm;
                f_all.Dock = DockStyle.Fill;
                f_all.Show();
            }
            else
            {
                f_all.Activate();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (clsCommon.Common._suUser || clsCommon.Common._idDept == "_0002")
            {
                btnPhuTungXeNang.Enabled = true;
            }
        }

        private void btnPhuTungXeNang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (f_xenang == null || f_xenang.IsDisposed)
            {
                f_xenang = new frmChild.frmThietBiXeNang();
                f_xenang.MdiParent = frmMain.ActiveForm;
                f_xenang.Dock = DockStyle.Fill;
                f_xenang.Show();
            }
            else
            {
                f_xenang.Activate();
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_EQ == null || f_EQ.IsDisposed)
            {
                f_EQ = new frmEquipments();
                f_EQ.MdiParent = frmMain.ActiveForm;
                f_EQ.Dock = DockStyle.Fill;
                f_EQ.Show();
            }
            else
            {
                f_EQ.Activate();
            }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_Problem == null || f_Problem.IsDisposed)
            {
                f_Problem = new frmChild.frmProblem();
                f_Problem.MdiParent = frmMain.ActiveForm;
                f_Problem.Dock = DockStyle.Fill;
                f_Problem.Show();
            }
            else
            {
                f_Problem.Activate();
            }

            
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_all == null || f_all.IsDisposed)
            {
                f_all = new frmCheckingDetails_Alltime();
                f_all.MdiParent = frmMain.ActiveForm;
                f_all.Dock = DockStyle.Fill;
                f_all.Show();
            }
            else
            {
                f_all.Activate();
            }
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_check == null || f_check.IsDisposed)
            {
                f_check = new frmCheckingListEquipments();
                f_check.MdiParent = frmMain.ActiveForm;
                f_check.Dock = DockStyle.Fill;
                f_check.Show();
            }
            else
            {
                f_check.Activate();
            }

            //if (f_xenang == null || f_xenang.IsDisposed)
            //{
            //    f_xenang = new frmChild.frmThietBiXeNang();
            //    f_xenang.MdiParent = frmMain.ActiveForm;
            //    f_xenang.Dock = DockStyle.Fill;
            //    f_xenang.Show();
            //}
            //else
            //{
            //    f_xenang.Activate();
            //}
        }


        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (f_schedule_big == null || f_schedule_big.IsDisposed)
                {
                    f_schedule_big = new frmSchedule_Big();
                    f_schedule_big.MdiParent = frmMain.ActiveForm;
                    f_schedule_big.Dock = DockStyle.Fill;
                    f_schedule_big.Show();
                }
                else
                {
                    f_schedule_big.Activate();
                }
            }
            catch { return; }
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_user == null || f_user.IsDisposed)
            {
                f_user = new frmChild.frmTaiKhoan();
                f_user.MdiParent = frmMain.ActiveForm;
                f_user.Dock = DockStyle.Fill;
                f_user.Show();
            }
            else
            {
                f_user.Activate();
            }
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_staff == null || f_staff.IsDisposed)
            {
                f_staff = new frmChild.frmStaff();
                f_staff.MdiParent = frmMain.ActiveForm;
                f_staff.Dock = DockStyle.Fill;
                f_staff.Show();
            }
            else
            {
                f_staff.Activate();
            }
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_tk == null || f_tk.IsDisposed)
            {
                f_tk = new frmChild.frmTonKho();
                f_tk.MdiParent = frmMain.ActiveForm;
                f_tk.Dock = DockStyle.Fill;
                f_tk.Show();
            }
            else
            {
                f_tk.Activate();
            }
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_pur1 == null || f_pur1.IsDisposed)
            {
                f_pur1 = new frmChild.frmPurchaseEQ_1();
                f_pur1.MdiParent = frmMain.ActiveForm;
                f_pur1.Dock = DockStyle.Fill;
                f_pur1.Show();
            }
            else
            {
                f_pur1.Activate();
            }
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_schedule == null || f_schedule.IsDisposed)
            {
                f_schedule = new frmSchedule();
                f_schedule.MdiParent = frmMain.ActiveForm;
                f_schedule.Dock = DockStyle.Fill;
                f_schedule.Show();
            }
            else
            {
                f_schedule.Activate();
            }
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_iso == null || f_iso.IsDisposed)
            {
                f_iso = new frmChild.frmBaoTri_ISO();
                f_iso.MdiParent = frmMain.ActiveForm;
                f_iso.Dock = DockStyle.Fill;
                f_iso.Show();
            }
            else
            {
                f_iso.Activate();
            }
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_nhap == null || f_nhap.IsDisposed)
            {
                f_nhap = new frmChild.frmNhapKho();
                f_nhap.MdiParent = frmMain.ActiveForm;
                f_nhap.Dock = DockStyle.Fill;
                f_nhap.Show();
            }
            else
            {
                f_nhap.Activate();
            }
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_xuat == null || f_xuat.IsDisposed)
            {
                f_xuat = new frmChild.frmXuatKho();
                f_xuat.MdiParent = frmMain.ActiveForm;
                f_xuat.Dock = DockStyle.Fill;
                f_xuat.Show();
            }
            else
            {
                f_xuat.Activate();
            }
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f_cumTB == null || f_cumTB.IsDisposed)
            {
                f_cumTB = new frmGroupEquipments();
                f_cumTB.MdiParent = frmMain.ActiveForm;
                f_cumTB.Dock = DockStyle.Fill;
                f_cumTB.Show();
            }
            else
            {
                f_cumTB.Activate();
            }
        }
    }
}
