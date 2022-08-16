namespace RebootReportes
{
    partial class InformeDataSet
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
            this.PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.i12DataSet = new RebootReportes.i12DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonaTableAdapter = new RebootReportes.i12DataSetTableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.i12DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaBindingSource
            // 
            this.PersonaBindingSource.DataMember = "Persona";
            this.PersonaBindingSource.DataSource = this.i12DataSet;
            // 
            // i12DataSet
            // 
            this.i12DataSet.DataSetName = "i12DataSet";
            this.i12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RebootReportes.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(650, 250);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonaTableAdapter
            // 
            this.PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // InformeDataSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 269);
            this.Controls.Add(this.reportViewer1);
            this.Name = "InformeDataSet";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.InformeFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.i12DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonaBindingSource;
        private i12DataSet i12DataSet;
        private i12DataSetTableAdapters.PersonaTableAdapter PersonaTableAdapter;
    }
}

