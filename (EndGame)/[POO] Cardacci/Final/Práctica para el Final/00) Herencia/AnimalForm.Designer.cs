namespace Captura
{
    partial class AnimalForm
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
            this.AnimalesDgv = new System.Windows.Forms.DataGridView();
            this.AlimentosDgv = new System.Windows.Forms.DataGridView();
            this.AlimentarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.HistorialDgv = new System.Windows.Forms.DataGridView();
            this.CategoriaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlimentosDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialDgv)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(549, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alimentos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Historial";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnimalesDgv
            // 
            this.AnimalesDgv.AllowUserToAddRows = false;
            this.AnimalesDgv.AllowUserToDeleteRows = false;
            this.AnimalesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AnimalesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnimalesDgv.Location = new System.Drawing.Point(16, 37);
            this.AnimalesDgv.MultiSelect = false;
            this.AnimalesDgv.Name = "AnimalesDgv";
            this.AnimalesDgv.ReadOnly = true;
            this.AnimalesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AnimalesDgv.Size = new System.Drawing.Size(425, 150);
            this.AnimalesDgv.TabIndex = 3;
            this.AnimalesDgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnimalesDgv_RowEnter);
            // 
            // AlimentosDgv
            // 
            this.AlimentosDgv.AllowUserToAddRows = false;
            this.AlimentosDgv.AllowUserToDeleteRows = false;
            this.AlimentosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AlimentosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlimentosDgv.Location = new System.Drawing.Point(553, 37);
            this.AlimentosDgv.MultiSelect = false;
            this.AlimentosDgv.Name = "AlimentosDgv";
            this.AlimentosDgv.ReadOnly = true;
            this.AlimentosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AlimentosDgv.Size = new System.Drawing.Size(425, 150);
            this.AlimentosDgv.TabIndex = 4;
            // 
            // AlimentarBtn
            // 
            this.AlimentarBtn.Location = new System.Drawing.Point(447, 37);
            this.AlimentarBtn.Name = "AlimentarBtn";
            this.AlimentarBtn.Size = new System.Drawing.Size(100, 30);
            this.AlimentarBtn.TabIndex = 5;
            this.AlimentarBtn.Text = "<Alimentar";
            this.AlimentarBtn.UseVisualStyleBackColor = true;
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(341, 193);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(100, 30);
            this.AgregarBtn.TabIndex = 6;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            // 
            // HistorialDgv
            // 
            this.HistorialDgv.AllowUserToAddRows = false;
            this.HistorialDgv.AllowUserToDeleteRows = false;
            this.HistorialDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.HistorialDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistorialDgv.Location = new System.Drawing.Point(16, 254);
            this.HistorialDgv.MultiSelect = false;
            this.HistorialDgv.Name = "HistorialDgv";
            this.HistorialDgv.ReadOnly = true;
            this.HistorialDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HistorialDgv.Size = new System.Drawing.Size(425, 150);
            this.HistorialDgv.TabIndex = 7;
            // 
            // CategoriaTxt
            // 
            this.CategoriaTxt.Location = new System.Drawing.Point(553, 254);
            this.CategoriaTxt.Name = "CategoriaTxt";
            this.CategoriaTxt.Size = new System.Drawing.Size(425, 27);
            this.CategoriaTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(549, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoría";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 423);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategoriaTxt);
            this.Controls.Add(this.HistorialDgv);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.AlimentarBtn);
            this.Controls.Add(this.AlimentosDgv);
            this.Controls.Add(this.AnimalesDgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comedor Animal";
            this.Load += new System.EventHandler(this.ComedorAnimalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnimalesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlimentosDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView AnimalesDgv;
        private System.Windows.Forms.DataGridView AlimentosDgv;
        private System.Windows.Forms.Button AlimentarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.DataGridView HistorialDgv;
        private System.Windows.Forms.TextBox CategoriaTxt;
        private System.Windows.Forms.Label label4;
    }
}

