
namespace UI
{
    partial class Ordenes_ItemsForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportePeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UltimosSieteButton = new System.Windows.Forms.Button();
            this.EsteMesButton = new System.Windows.Forms.Button();
            this.HoyButton = new System.Windows.Forms.Button();
            this.EsteAñoButton = new System.Windows.Forms.Button();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.UltimosTreintaButton = new System.Windows.Forms.Button();
            this.HastaDTP = new System.Windows.Forms.DateTimePicker();
            this.DesdeDTP = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.HastaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePeriodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteBindingSource
            // 
            this.ReporteBindingSource.DataSource = typeof(MPP.Reporte);
            // 
            // ReporteListadoBindingSource
            // 
            this.ReporteListadoBindingSource.DataSource = typeof(BE.ReporteListado);
            // 
            // ReportePeriodoBindingSource
            // 
            this.ReportePeriodoBindingSource.DataSource = typeof(BE.ReportePeriodo);
            // 
            // ReportViewer
            // 
            reportDataSource1.Name = "Reporte";
            reportDataSource1.Value = this.ReporteBindingSource;
            reportDataSource2.Name = "Listado";
            reportDataSource2.Value = this.ReporteListadoBindingSource;
            reportDataSource3.Name = "Periodo";
            reportDataSource3.Value = this.ReportePeriodoBindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "UI.Ordenes_Items.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(12, 12);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(604, 437);
            this.ReportViewer.TabIndex = 9;
            // 
            // UltimosSieteButton
            // 
            this.UltimosSieteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimosSieteButton.Location = new System.Drawing.Point(622, 68);
            this.UltimosSieteButton.Name = "UltimosSieteButton";
            this.UltimosSieteButton.Size = new System.Drawing.Size(100, 50);
            this.UltimosSieteButton.TabIndex = 2;
            this.UltimosSieteButton.Text = "Los últimos 7 días";
            this.UltimosSieteButton.UseVisualStyleBackColor = true;
            this.UltimosSieteButton.Click += new System.EventHandler(this.UltimosSieteButton_Click);
            // 
            // EsteMesButton
            // 
            this.EsteMesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsteMesButton.Location = new System.Drawing.Point(622, 124);
            this.EsteMesButton.Name = "EsteMesButton";
            this.EsteMesButton.Size = new System.Drawing.Size(100, 50);
            this.EsteMesButton.TabIndex = 3;
            this.EsteMesButton.Text = "Este mes";
            this.EsteMesButton.UseVisualStyleBackColor = true;
            this.EsteMesButton.Click += new System.EventHandler(this.EsteMesButton_Click);
            // 
            // HoyButton
            // 
            this.HoyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoyButton.Location = new System.Drawing.Point(622, 12);
            this.HoyButton.Name = "HoyButton";
            this.HoyButton.Size = new System.Drawing.Size(100, 50);
            this.HoyButton.TabIndex = 1;
            this.HoyButton.Text = "Hoy";
            this.HoyButton.UseVisualStyleBackColor = true;
            this.HoyButton.Click += new System.EventHandler(this.HoyButton_Click);
            // 
            // EsteAñoButton
            // 
            this.EsteAñoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsteAñoButton.Location = new System.Drawing.Point(622, 236);
            this.EsteAñoButton.Name = "EsteAñoButton";
            this.EsteAñoButton.Size = new System.Drawing.Size(100, 50);
            this.EsteAñoButton.TabIndex = 5;
            this.EsteAñoButton.Text = "Este año";
            this.EsteAñoButton.UseVisualStyleBackColor = true;
            this.EsteAñoButton.Click += new System.EventHandler(this.EsteAñoButton_Click);
            // 
            // MostrarButton
            // 
            this.MostrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarButton.Location = new System.Drawing.Point(622, 399);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(100, 50);
            this.MostrarButton.TabIndex = 8;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // UltimosTreintaButton
            // 
            this.UltimosTreintaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimosTreintaButton.Location = new System.Drawing.Point(622, 180);
            this.UltimosTreintaButton.Name = "UltimosTreintaButton";
            this.UltimosTreintaButton.Size = new System.Drawing.Size(100, 50);
            this.UltimosTreintaButton.TabIndex = 4;
            this.UltimosTreintaButton.Text = "Los últimos 30 días";
            this.UltimosTreintaButton.UseVisualStyleBackColor = true;
            this.UltimosTreintaButton.Click += new System.EventHandler(this.UltimosTreintaButton_Click);
            // 
            // HastaDTP
            // 
            this.HastaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDTP.Location = new System.Drawing.Point(622, 373);
            this.HastaDTP.Name = "HastaDTP";
            this.HastaDTP.Size = new System.Drawing.Size(100, 20);
            this.HastaDTP.TabIndex = 7;
            // 
            // DesdeDTP
            // 
            this.DesdeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDTP.Location = new System.Drawing.Point(622, 327);
            this.DesdeDTP.Name = "DesdeDTP";
            this.DesdeDTP.Size = new System.Drawing.Size(100, 20);
            this.DesdeDTP.TabIndex = 6;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.Location = new System.Drawing.Point(619, 304);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(100, 20);
            this.DesdeLabel.TabIndex = 26;
            this.DesdeLabel.Text = "Desde";
            this.DesdeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // HastaLabel
            // 
            this.HastaLabel.Location = new System.Drawing.Point(619, 350);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(100, 20);
            this.HastaLabel.TabIndex = 27;
            this.HastaLabel.Text = "Hasta";
            this.HastaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Ordenes_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.DesdeDTP);
            this.Controls.Add(this.HastaDTP);
            this.Controls.Add(this.EsteAñoButton);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.UltimosTreintaButton);
            this.Controls.Add(this.UltimosSieteButton);
            this.Controls.Add(this.EsteMesButton);
            this.Controls.Add(this.HoyButton);
            this.Controls.Add(this.ReportViewer);
            this.Name = "Ordenes_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Ordenes_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePeriodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private System.Windows.Forms.BindingSource ReporteBindingSource;
        private System.Windows.Forms.BindingSource ReporteListadoBindingSource;
        private System.Windows.Forms.BindingSource ReportePeriodoBindingSource;
        private System.Windows.Forms.Button UltimosSieteButton;
        private System.Windows.Forms.Button EsteMesButton;
        private System.Windows.Forms.Button HoyButton;
        private System.Windows.Forms.Button EsteAñoButton;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.Button UltimosTreintaButton;
        private System.Windows.Forms.DateTimePicker HastaDTP;
        private System.Windows.Forms.DateTimePicker DesdeDTP;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Label HastaLabel;
    }
}