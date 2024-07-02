
namespace VeritabaniProje2B
{
    partial class KullaniciRaporForm
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
            this.KullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KullanicilarTableAdapter = new VeritabaniProje2B.vt2BDataSetTableAdapters.KullanicilarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vt2BDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullanicilarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KullanicilarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VeritabaniProje2B.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(845, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // vt2BDataSet
            // 
            this.vt2BDataSet.DataSetName = "vt2BDataSet";
            this.vt2BDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KullanicilarBindingSource
            // 
            this.KullanicilarBindingSource.DataMember = "Kullanicilar";
            this.KullanicilarBindingSource.DataSource = this.vt2BDataSet;
            // 
            // KullanicilarTableAdapter
            // 
            this.KullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // KullaniciRaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "KullaniciRaporForm";
            this.Text = "KullaniciRaporForm";
            this.Load += new System.EventHandler(this.KullaniciRaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vt2BDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullanicilarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KullanicilarBindingSource;
        private vt2BDataSet vt2BDataSet;
        private vt2BDataSetTableAdapters.KullanicilarTableAdapter KullanicilarTableAdapter;
    }
}