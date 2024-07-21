namespace NguyenCaoThang
{
    partial class RentalReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLNV_THUEHANGHOADataSet = new NguyenCaoThang.QLNV_THUEHANGHOADataSet();
            this.tHUEHANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHUEHANGHOATableAdapter = new NguyenCaoThang.QLNV_THUEHANGHOADataSetTableAdapters.THUEHANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_THUEHANGHOADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUEHANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "rental";
            reportDataSource1.Value = this.tHUEHANGHOABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NguyenCaoThang.Reportrental.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // qLNV_THUEHANGHOADataSet
            // 
            this.qLNV_THUEHANGHOADataSet.DataSetName = "QLNV_THUEHANGHOADataSet";
            this.qLNV_THUEHANGHOADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHUEHANGHOABindingSource
            // 
            this.tHUEHANGHOABindingSource.DataMember = "THUEHANGHOA";
            this.tHUEHANGHOABindingSource.DataSource = this.qLNV_THUEHANGHOADataSet;
            // 
            // tHUEHANGHOATableAdapter
            // 
            this.tHUEHANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // RentalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RentalReport";
            this.Text = "RentalReport";
            this.Load += new System.EventHandler(this.RentalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_THUEHANGHOADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUEHANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLNV_THUEHANGHOADataSet qLNV_THUEHANGHOADataSet;
        private System.Windows.Forms.BindingSource tHUEHANGHOABindingSource;
        private QLNV_THUEHANGHOADataSetTableAdapters.THUEHANGHOATableAdapter tHUEHANGHOATableAdapter;
    }
}