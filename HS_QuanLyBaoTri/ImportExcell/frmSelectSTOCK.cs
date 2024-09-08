using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HS_QuanLyBaoTri.ImportExcell
{
    public partial class frmSelectSTOCK : DevExpress.XtraEditors.XtraForm
    {
        public string _stock = string.Empty;
        public frmSelectSTOCK()
        {
            InitializeComponent();
        }

        private void frmSelectSTOCK_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                _stock = comboBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}