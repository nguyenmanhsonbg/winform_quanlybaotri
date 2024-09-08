using System;
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

namespace HS_QuanLyBaoTri.frmChild
{
    public partial class frmXuatKho : DevExpress.XtraEditors.XtraForm
    {
        public frmXuatKho()
        {
            InitializeComponent();
        }

        private void frmXuatKho_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            fromDate.EditValue = new DateTime(date.Year, date.Month, 1);
            toDate.EditValue = DateTime.Now;
            gridView1.IndicatorWidth = 50;
            gridView1.OptionsBehavior.ReadOnly = true;
            DateTime _dateFrom = Convert.ToDateTime(fromDate.EditValue.ToString());
            DateTime _dateTo = Convert.ToDateTime(toDate.EditValue.ToString());
            this.data_GetXuatKhoTableAdapter.Fill(dataSet_Get_XuatKho.Data_GetXuatKho, _dateFrom, _dateTo);
        }

        private void btnView1_Click(object sender, System.EventArgs e)
        {
            DateTime _dateFrom = Convert.ToDateTime(fromDate.EditValue.ToString());
            DateTime _dateTo = Convert.ToDateTime(toDate.EditValue.ToString());
            this.data_GetXuatKhoTableAdapter.Fill(dataSet_Get_XuatKho.Data_GetXuatKho, _dateFrom, _dateTo);
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            if (clsCommon.Common._suUser || clsCommon.Common._idDept == "_0008")
            {
                ImportExcell.frmImportXuatKho f_export = new ImportExcell.frmImportXuatKho();
                f_export.Show();
            }
        }  
    }
}