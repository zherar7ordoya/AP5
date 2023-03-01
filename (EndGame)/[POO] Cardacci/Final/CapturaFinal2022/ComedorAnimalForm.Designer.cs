namespace CapturaFinal2022
{
    partial class ComedorAnimalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ListaAnimalesDgv = new System.Windows.Forms.DataGridView();
            this.ListaAlimentosDgv = new System.Windows.Forms.DataGridView();
            this.AlimentarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.HistorialAlimentosDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAnimalesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlimentosDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialAlimentosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alimentos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(262, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Historial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListaAnimalesDgv
            // 
            this.ListaAnimalesDgv.AllowUserToAddRows = false;
            this.ListaAnimalesDgv.AllowUserToDeleteRows = false;
            this.ListaAnimalesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAnimalesDgv.Location = new System.Drawing.Point(16, 37);
            this.ListaAnimalesDgv.Name = "ListaAnimalesDgv";
            this.ListaAnimalesDgv.ReadOnly = true;
            this.ListaAnimalesDgv.Size = new System.Drawing.Size(240, 150);
            this.ListaAnimalesDgv.TabIndex = 3;
            // 
            // ListaAlimentosDgv
            // 
            this.ListaAlimentosDgv.AllowUserToAddRows = false;
            this.ListaAlimentosDgv.AllowUserToDeleteRows = false;
            this.ListaAlimentosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAlimentosDgv.Location = new System.Drawing.Point(368, 37);
            this.ListaAlimentosDgv.Name = "ListaAlimentosDgv";
            this.ListaAlimentosDgv.ReadOnly = true;
            this.ListaAlimentosDgv.Size = new System.Drawing.Size(240, 150);
            this.ListaAlimentosDgv.TabIndex = 4;
            // 
            // AlimentarBtn
            // 
            this.AlimentarBtn.Location = new System.Drawing.Point(262, 37);
            this.AlimentarBtn.Name = "AlimentarBtn";
            this.AlimentarBtn.Size = new System.Drawing.Size(100, 30);
            this.AlimentarBtn.TabIndex = 5;
            this.AlimentarBtn.Text = "<Alimentar";
            this.AlimentarBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(156, 193);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(100, 30);
            this.AgregarBtn.TabIndex = 6;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // HistorialAlimentosDgv
            // 
            this.HistorialAlimentosDgv.AllowUserToAddRows = false;
            this.HistorialAlimentosDgv.AllowUserToDeleteRows = false;
            this.HistorialAlimentosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistorialAlimentosDgv.Location = new System.Drawing.Point(16, 253);
            this.HistorialAlimentosDgv.Name = "HistorialAlimentosDgv";
            this.HistorialAlimentosDgv.ReadOnly = true;
            this.HistorialAlimentosDgv.Size = new System.Drawing.Size(240, 150);
            this.HistorialAlimentosDgv.TabIndex = 7;
            // 
            // ComedorAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 423);
            this.Controls.Add(this.HistorialAlimentosDgv);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.AlimentarBtn);
            this.Controls.Add(this.ListaAlimentosDgv);
            this.Controls.Add(this.ListaAnimalesDgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ComedorAnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comedor Animal";
            this.Load += new System.EventHandler(this.ComedorAnimalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaAnimalesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlimentosDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialAlimentosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ListaAnimalesDgv;
        private System.Windows.Forms.DataGridView ListaAlimentosDgv;
        private System.Windows.Forms.Button AlimentarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView HistorialAlimentosDgv;
    }
}

