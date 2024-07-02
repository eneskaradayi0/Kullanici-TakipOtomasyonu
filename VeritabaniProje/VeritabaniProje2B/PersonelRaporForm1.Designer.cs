
namespace VeritabaniProje2B
{
    partial class PersonelRaporForm1
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
            this.vt2BDataSet = new VeritabaniProje2B.vt2BDataSet();
            this.PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonelTableAdapter = new VeritabaniProje2B.vt2BDataSetTableAdapters.PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vt2BDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VeritabaniProje2B.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(878, 592);
            this.reportViewer1.TabIndex = 0;
            // 
            // vt2BDataSet
            // 
            this.vt2BDataSet.DataSetName = "vt2BDataSet";
            this.vt2BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonelBindingSource
            // 
            this.PersonelBindingSource.DataMember = "Personel";
            this.PersonelBindingSource.DataSource = this.vt2BDataSet;
            // 
            // PersonelTableAdapter
            // 
            this.PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // PersonelRaporForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 616);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PersonelRaporForm1";
            this.Text = "PersonelRaporForm1";
            this.Load += new System.EventHandler(this.PersonelRaporForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vt2BDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonelBindingSource;
        private vt2BDataSet vt2BDataSet;
        private vt2BDataSetTableAdapters.PersonelTableAdapter PersonelTableAdapter;
    }
}