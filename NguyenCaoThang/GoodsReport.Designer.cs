namespace NguyenCaoThang
{
    partial class GoodsReport
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
            this.hANGHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGHOATableAdapter = new NguyenCaoThang.QLNV_THUEHANGHOADataSetTableAdapters.HANGHOATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_THUEHANGHOADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "goods";
            reportDataSource1.Value = this.hANGHOABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NguyenCaoThang.ReportGoods.rdlc";
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
            // hANGHOABindingSource
            // 
            this.hANGHOABindingSource.DataMember = "HANGHOA";
            this.hANGHOABindingSource.DataSource = this.qLNV_THUEHANGHOADataSet;
            // 
            // hANGHOATableAdapter
            // 
            this.hANGHOATableAdapter.ClearBeforeFill = true;
            // 
            // GoodsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GoodsReport";
            this.Text = "GoodsReport";
            this.Load += new System.EventHandler(this.GoodsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNV_THUEHANGHOADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGHOABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QLNV_THUEHANGHOADataSet qLNV_THUEHANGHOADataSet;
        private System.Windows.Forms.BindingSource hANGHOABindingSource;
        private QLNV_THUEHANGHOADataSetTableAdapters.HANGHOATableAdapter hANGHOATableAdapter;
    }
}