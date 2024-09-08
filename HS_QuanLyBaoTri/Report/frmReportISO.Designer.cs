namespace HS_QuanLyBaoTri.Report
{
    partial class frmReportISO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Data_Get_BaoTriThangISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_BaoTriThangISO = new HS_QuanLyBaoTri.DataSet.DataSet_Get_BaoTriThangISO();
            this.dataGetBaoTriISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_BaoTriISO = new HS_QuanLyBaoTri.DataSet.DataSet_Get_BaoTriISO();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.data_Get_BaoTriISOTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_BaoTriISOTableAdapters.Data_Get_BaoTriISOTableAdapter();
            this.dataGetBaoTriThangISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Get_BaoTriThangISOTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_BaoTriThangISOTableAdapters.Data_Get_BaoTriThangISOTableAdapter();
            this.Data_Get_BaoTriISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Get_BaoTriNamISO = new HS_QuanLyBaoTri.DataSet.DataSet_Get_BaoTriNamISO();
            this.dataGetBaoTriNamISOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_Get_BaoTriNamISOTableAdapter = new HS_QuanLyBaoTri.DataSet.DataSet_Get_BaoTriNamISOTableAdapters.Data_Get_BaoTriNamISOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Get_BaoTriThangISOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_BaoTriThangISO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetBaoTriISOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_BaoTriISO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetBaoTriThangISOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Get_BaoTriISOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_BaoTriNamISO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetBaoTriNamISOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Get_BaoTriThangISOBindingSource
            // 
            this.Data_Get_BaoTriThangISOBindingSource.DataMember = "Data_Get_BaoTriThangISO";
            this.Data_Get_BaoTriThangISOBindingSource.DataSource = this.dataSet_Get_BaoTriThangISO;
            // 
            // dataSet_Get_BaoTriThangISO
            // 
            this.dataSet_Get_BaoTriThangISO.DataSetName = "DataSet_Get_BaoTriThangISO";
            this.dataSet_Get_BaoTriThangISO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGetBaoTriISOBindingSource
            // 
            this.dataGetBaoTriISOBindingSource.DataMember = "Data_Get_BaoTriISO";
            this.dataGetBaoTriISOBindingSource.DataSource = this.dataSet_Get_BaoTriISO;
            // 
            // dataSet_Get_BaoTriISO
            // 
            this.dataSet_Get_BaoTriISO.DataSetName = "DataSet_Get_BaoTriISO";
            this.dataSet_Get_BaoTriISO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetReportISO";
            reportDataSource1.Value = this.dataGetBaoTriNamISOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HS_QuanLyBaoTri.Report.Report_Nam.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1217, 633);
            this.reportViewer1.TabIndex = 0;
            // 
            // data_Get_BaoTriISOTableAdapter
            // 
            this.data_Get_BaoTriISOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGetBaoTriThangISOBindingSource
            // 
            this.dataGetBaoTriThangISOBindingSource.DataMember = "Data_Get_BaoTriThangISO";
            this.dataGetBaoTriThangISOBindingSource.DataSource = this.dataSet_Get_BaoTriThangISO;
            // 
            // data_Get_BaoTriThangISOTableAdapter
            // 
            this.data_Get_BaoTriThangISOTableAdapter.ClearBeforeFill = true;
            // 
            // Data_Get_BaoTriISOBindingSource
            // 
            this.Data_Get_BaoTriISOBindingSource.DataMember = "Data_Get_BaoTriISO";
            this.Data_Get_BaoTriISOBindingSource.DataSource = this.dataSet_Get_BaoTriISO;
            // 
            // dataSet_Get_BaoTriNamISO
            // 
            this.dataSet_Get_BaoTriNamISO.DataSetName = "DataSet_Get_BaoTriNamISO";
            this.dataSet_Get_BaoTriNamISO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGetBaoTriNamISOBindingSource
            // 
            this.dataGetBaoTriNamISOBindingSource.DataMember = "Data_Get_BaoTriNamISO";
            this.dataGetBaoTriNamISOBindingSource.DataSource = this.dataSet_Get_BaoTriNamISO;
            // 
            // data_Get_BaoTriNamISOTableAdapter
            // 
            this.data_Get_BaoTriNamISOTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportISO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 633);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportISO";
            this.Text = "KẾ HOẠCH BẢO TRÌ ĐỊNH KỲ THIẾT BỊ";
            this.Load += new System.EventHandler(this.frmReportISO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Get_BaoTriThangISOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_BaoTriThangISO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetBaoTriISOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_BaoTriISO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetBaoTriThangISOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Get_BaoTriISOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Get_BaoTriNamISO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetBaoTriNamISOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataGetBaoTriISOBindingSource;
        private DataSet.DataSet_Get_BaoTriISO dataSet_Get_BaoTriISO;
        private DataSet.DataSet_Get_BaoTriISOTableAdapters.Data_Get_BaoTriISOTableAdapter data_Get_BaoTriISOTableAdapter;
        private System.Windows.Forms.BindingSource dataGetBaoTriThangISOBindingSource;
        private DataSet.DataSet_Get_BaoTriThangISO dataSet_Get_BaoTriThangISO;
        private DataSet.DataSet_Get_BaoTriThangISOTableAdapters.Data_Get_BaoTriThangISOTableAdapter data_Get_BaoTriThangISOTableAdapter;
        private System.Windows.Forms.BindingSource Data_Get_BaoTriISOBindingSource;
        private System.Windows.Forms.BindingSource Data_Get_BaoTriThangISOBindingSource;
        private System.Windows.Forms.BindingSource dataGetBaoTriNamISOBindingSource;
        private DataSet.DataSet_Get_BaoTriNamISO dataSet_Get_BaoTriNamISO;
        private DataSet.DataSet_Get_BaoTriNamISOTableAdapters.Data_Get_BaoTriNamISOTableAdapter data_Get_BaoTriNamISOTableAdapter;
    }
}