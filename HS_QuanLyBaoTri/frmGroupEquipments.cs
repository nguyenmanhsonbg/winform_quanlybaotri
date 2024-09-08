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

namespace HS_QuanLyBaoTri
{
    public partial class frmGroupEquipments : DevExpress.XtraEditors.XtraForm
    {
        public frmGroupEquipments()
        {
            InitializeComponent();
        }

        private void frmGroupEquipments_Load(object sender, EventArgs e)
        {
            txtDept.EditValue = clsCommon.Common._idDept;
            this.data_Get_DeptTableAdapter.Fill(dataSet_Dept.Data_Get_Dept, 0);
            this.data_Get_GroupEQDetailsTableAdapter.Fill(dataSet1.Data_Get_GroupEQDetails);
            //txtDept2.Properties.DataSource = dataSet_Dept.Data_Get_Dept;
            DataTable newDataTable = new DataTable();

            // Thêm các cột cần thiết vào DataTable mới
            newDataTable.Columns.Add("Column1", typeof(string)); // Thay đổi kiểu dữ liệu nếu cần
            newDataTable.Columns.Add("Column2", typeof(string)); // Thay đổi kiểu dữ liệu nếu cần

            // Sao chép dữ liệu từ DataTable gốc vào DataTable mới
            foreach (DataRow row in dataSet1.Data_Get_GroupEQDetails.Rows)
            {
                DataRow newRow = newDataTable.NewRow();
                newRow["Column1"] = row["IDGroupEQ"];
                newRow["Column2"] = row["KetQuaThucHien"];
                newDataTable.Rows.Add(newRow);
            }

            // Gán DataTable mới cho DataSource
            txtDept2.Properties.DataSource = newDataTable;
            //txtDept2.Properties.DataSource = dataSet1.Data_Get_GroupEQDetails;
            //txtDept2.Properties.DisplayMember = "IDGroupEQ";
            //txtDept2.Properties.DisplayMember = "KetQuaThucHien";

        }

     

        
    }
}