
namespace UI
{
    partial class HistorialJugadoresTTTForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.EstadoCombobox = new System.Windows.Forms.ComboBox();
            this.BarrasChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BarrasChart)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadoCombobox
            // 
            this.EstadoCombobox.FormattingEnabled = true;
            this.EstadoCombobox.Items.AddRange(new object[] {
            "GANADOS",
            "EMPATADOS",
            "PERDIDOS"});
            this.EstadoCombobox.Location = new System.Drawing.Point(451, 290);
            this.EstadoCombobox.Name = "EstadoCombobox";
            this.EstadoCombobox.Size = new System.Drawing.Size(121, 21);
            this.EstadoCombobox.TabIndex = 3;
            this.EstadoCombobox.SelectedIndexChanged += new System.EventHandler(this.EstadoCombobox_SelectedIndexChanged);
            // 
            // BarrasChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BarrasChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarrasChart.Legends.Add(legend1);
            this.BarrasChart.Location = new System.Drawing.Point(12, 12);
            this.BarrasChart.Name = "BarrasChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BarrasChart.Series.Add(series1);
            this.BarrasChart.Size = new System.Drawing.Size(560, 337);
            this.BarrasChart.TabIndex = 2;
            this.BarrasChart.Text = "chart1";
            // 
            // HistorialJugadoresTTTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.EstadoCombobox);
            this.Controls.Add(this.BarrasChart);
            this.Name = "HistorialJugadoresTTTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ta-Te-Ti: Historial Jugadores";
            this.Load += new System.EventHandler(this.HistorialJugadoresTTTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarrasChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox EstadoCombobox;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarrasChart;
    }
}