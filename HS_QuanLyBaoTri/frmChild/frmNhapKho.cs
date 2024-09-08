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
    public partial class frmNhapKho : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            fromDate.EditValue = new DateTime(date.Year, date.Month, 1);
            toDate.EditValue = DateTime.Now;
            gridView1.IndicatorWidth = 50;
            gridView1.OptionsBehavior.ReadOnly = true;
            DateTime _dateFrom = Convert.ToDateTime(fromDate.EditValue.ToString());
            DateTime _dateTo = Convert.ToDateTime(toDate.EditValue.ToString());
            this.data_Get_NhapKhoTableAdapter.Fill(dataSet_Get_NhapKho.Data_Get_NhapKho, _dateFrom, _dateTo);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clsCommon.Common._suUser || clsCommon.Common._idDept == "_0008")
            {
                ImportExcell.frmImportNhapKho f_import = new ImportExcell.frmImportNhapKho();
                f_import.Show();
            }
        }

        private void btnView1_Click(object sender, EventArgs e)
        {
            DateTime _dateFrom = Convert.ToDateTime(fromDate.EditValue.ToString());
            DateTime _dateTo = Convert.ToDateTime(toDate.EditValue.ToString());
            this.data_Get_NhapKhoTableAdapter.Fill(dataSet_Get_NhapKho.Data_Get_NhapKho, _dateFrom, _dateTo);
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}