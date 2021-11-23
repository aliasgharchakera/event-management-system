namespace CSSamples2005
{
    partial class ReportViewer
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
            this.custOrdersDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet1 = new CSSamples2005.NorthwindDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.northwindDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custOrdersDetailTableAdapter = new CSSamples2005.NorthwindDataSetTableAdapters.CustOrdersDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // custOrdersDetailBindingSource
            // 
            this.custOrdersDetailBindingSource.DataMember = "CustOrdersDetail";
            this.custOrdersDetailBindingSource.DataSource = this.northwindDataSet1;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "NorthwindDataSet_CustOrdersDetail";
            reportDataSource1.Value = this.custOrdersDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CSSamples2005.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(792, 719);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // northwindDataSet1BindingSource
            // 
            this.northwindDataSet1BindingSource.DataSource = this.northwindDataSet1;
            this.northwindDataSet1BindingSource.Position = 0;
            // 
            // custOrdersDetailTableAdapter
            // 
            this.custOrdersDetailTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 576);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.Load += new System.EventHandler(this.ReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custOrdersDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource northwindDataSet1BindingSource;
        private NorthwindDataSet northwindDataSet1;
        private System.Windows.Forms.BindingSource custOrdersDetailBindingSource;
        private CSSamples2005.NorthwindDataSetTableAdapters.CustOrdersDetailTableAdapter custOrdersDetailTableAdapter;
    }
}