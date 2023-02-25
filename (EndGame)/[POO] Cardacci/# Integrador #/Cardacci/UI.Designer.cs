
namespace Integrador
{
    partial class UI
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
            this.PersonaListadoDgv = new System.Windows.Forms.DataGridView();
            this.PersonaAltaBtn = new System.Windows.Forms.Button();
            this.PersonaBorrarBtn = new System.Windows.Forms.Button();
            this.PersonaModificarBtn = new System.Windows.Forms.Button();
            this.AutoMoficarBtn = new System.Windows.Forms.Button();
            this.AutoBorrarBtn = new System.Windows.Forms.Button();
            this.AutoAgregarBtn = new System.Windows.Forms.Button();
            this.AutoAsignarBtn = new System.Windows.Forms.Button();
            this.PersonaAutosDgv = new System.Windows.Forms.DataGridView();
            this.AutoDetallesDgv = new System.Windows.Forms.DataGridView();
            this.AutoQuitarBtn = new System.Windows.Forms.Button();
            this.AutoTotalLbl = new System.Windows.Forms.Label();
            this.AutoListadoDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaListadoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaAutosDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoDetallesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoListadoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaListadoDgv
            // 
            this.PersonaListadoDgv.AllowUserToAddRows = false;
            this.PersonaListadoDgv.AllowUserToDeleteRows = false;
            this.PersonaListadoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PersonaListadoDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PersonaListadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonaListadoDgv.Location = new System.Drawing.Point(11, 11);
            this.PersonaListadoDgv.Margin = new System.Windows.Forms.Padding(2);
            this.PersonaListadoDgv.MultiSelect = false;
            this.PersonaListadoDgv.Name = "PersonaListadoDgv";
            this.PersonaListadoDgv.ReadOnly = true;
            this.PersonaListadoDgv.RowHeadersWidth = 82;
            this.PersonaListadoDgv.RowTemplate.Height = 33;
            this.PersonaListadoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonaListadoDgv.Size = new System.Drawing.Size(405, 200);
            this.PersonaListadoDgv.TabIndex = 0;
            this.PersonaListadoDgv.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonaListadoDgv_RowEnter);
            // 
            // PersonaAltaBtn
            // 
            this.PersonaAltaBtn.Location = new System.Drawing.Point(168, 216);
            this.PersonaAltaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PersonaAltaBtn.Name = "PersonaAltaBtn";
            this.PersonaAltaBtn.Size = new System.Drawing.Size(80, 21);
            this.PersonaAltaBtn.TabIndex = 1;
            this.PersonaAltaBtn.Text = "Agregar";
            this.PersonaAltaBtn.UseVisualStyleBackColor = true;
            this.PersonaAltaBtn.Click += new System.EventHandler(this.PersonaAgregarBtn_Click);
            // 
            // PersonaBorrarBtn
            // 
            this.PersonaBorrarBtn.Location = new System.Drawing.Point(252, 216);
            this.PersonaBorrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PersonaBorrarBtn.Name = "PersonaBorrarBtn";
            this.PersonaBorrarBtn.Size = new System.Drawing.Size(80, 21);
            this.PersonaBorrarBtn.TabIndex = 2;
            this.PersonaBorrarBtn.Text = "Borrar";
            this.PersonaBorrarBtn.UseVisualStyleBackColor = true;
            this.PersonaBorrarBtn.Click += new System.EventHandler(this.PersonaBorrarBtn_Click);
            // 
            // PersonaModificarBtn
            // 
            this.PersonaModificarBtn.Location = new System.Drawing.Point(336, 216);
            this.PersonaModificarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PersonaModificarBtn.Name = "PersonaModificarBtn";
            this.PersonaModificarBtn.Size = new System.Drawing.Size(80, 21);
            this.PersonaModificarBtn.TabIndex = 3;
            this.PersonaModificarBtn.Text = "Modificar";
            this.PersonaModificarBtn.UseVisualStyleBackColor = true;
            this.PersonaModificarBtn.Click += new System.EventHandler(this.PersonaModificarBtn_Click);
            // 
            // AutoMoficarBtn
            // 
            this.AutoMoficarBtn.Location = new System.Drawing.Point(784, 216);
            this.AutoMoficarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AutoMoficarBtn.Name = "AutoMoficarBtn";
            this.AutoMoficarBtn.Size = new System.Drawing.Size(89, 21);
            this.AutoMoficarBtn.TabIndex = 7;
            this.AutoMoficarBtn.Text = "Modificar";
            this.AutoMoficarBtn.UseVisualStyleBackColor = true;
            this.AutoMoficarBtn.Click += new System.EventHandler(this.AutoModificar_Click);
            // 
            // AutoBorrarBtn
            // 
            this.AutoBorrarBtn.Location = new System.Drawing.Point(691, 216);
            this.AutoBorrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AutoBorrarBtn.Name = "AutoBorrarBtn";
            this.AutoBorrarBtn.Size = new System.Drawing.Size(89, 21);
            this.AutoBorrarBtn.TabIndex = 6;
            this.AutoBorrarBtn.Text = "Borrar";
            this.AutoBorrarBtn.UseVisualStyleBackColor = true;
            this.AutoBorrarBtn.Click += new System.EventHandler(this.AutoBorrar_Click);
            // 
            // AutoAgregarBtn
            // 
            this.AutoAgregarBtn.Location = new System.Drawing.Point(598, 216);
            this.AutoAgregarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AutoAgregarBtn.Name = "AutoAgregarBtn";
            this.AutoAgregarBtn.Size = new System.Drawing.Size(89, 21);
            this.AutoAgregarBtn.TabIndex = 5;
            this.AutoAgregarBtn.Text = "Agregar";
            this.AutoAgregarBtn.UseVisualStyleBackColor = true;
            this.AutoAgregarBtn.Click += new System.EventHandler(this.AutoAgregarBtn_Click);
            // 
            // AutoAsignarBtn
            // 
            this.AutoAsignarBtn.Location = new System.Drawing.Point(420, 11);
            this.AutoAsignarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AutoAsignarBtn.Name = "AutoAsignarBtn";
            this.AutoAsignarBtn.Size = new System.Drawing.Size(89, 21);
            this.AutoAsignarBtn.TabIndex = 8;
            this.AutoAsignarBtn.Text = "<< Asignar";
            this.AutoAsignarBtn.UseVisualStyleBackColor = true;
            this.AutoAsignarBtn.Click += new System.EventHandler(this.AutoAsignar_Click);
            // 
            // PersonaAutosDgv
            // 
            this.PersonaAutosDgv.AllowUserToAddRows = false;
            this.PersonaAutosDgv.AllowUserToDeleteRows = false;
            this.PersonaAutosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PersonaAutosDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.PersonaAutosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonaAutosDgv.Location = new System.Drawing.Point(11, 299);
            this.PersonaAutosDgv.Margin = new System.Windows.Forms.Padding(2);
            this.PersonaAutosDgv.MultiSelect = false;
            this.PersonaAutosDgv.Name = "PersonaAutosDgv";
            this.PersonaAutosDgv.ReadOnly = true;
            this.PersonaAutosDgv.RowHeadersWidth = 82;
            this.PersonaAutosDgv.RowTemplate.Height = 33;
            this.PersonaAutosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonaAutosDgv.Size = new System.Drawing.Size(405, 200);
            this.PersonaAutosDgv.TabIndex = 9;
            this.PersonaAutosDgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PersonaAutosDgv_RowsAdded);
            // 
            // AutoDetallesDgv
            // 
            this.AutoDetallesDgv.AllowUserToAddRows = false;
            this.AutoDetallesDgv.AllowUserToDeleteRows = false;
            this.AutoDetallesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AutoDetallesDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AutoDetallesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoDetallesDgv.Location = new System.Drawing.Point(516, 300);
            this.AutoDetallesDgv.Margin = new System.Windows.Forms.Padding(2);
            this.AutoDetallesDgv.MultiSelect = false;
            this.AutoDetallesDgv.Name = "AutoDetallesDgv";
            this.AutoDetallesDgv.ReadOnly = true;
            this.AutoDetallesDgv.RowHeadersWidth = 82;
            this.AutoDetallesDgv.RowTemplate.Height = 33;
            this.AutoDetallesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AutoDetallesDgv.Size = new System.Drawing.Size(357, 200);
            this.AutoDetallesDgv.TabIndex = 10;
            // 
            // AutoQuitarBtn
            // 
            this.AutoQuitarBtn.Location = new System.Drawing.Point(420, 299);
            this.AutoQuitarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AutoQuitarBtn.Name = "AutoQuitarBtn";
            this.AutoQuitarBtn.Size = new System.Drawing.Size(89, 21);
            this.AutoQuitarBtn.TabIndex = 11;
            this.AutoQuitarBtn.Text = "<< Quitar";
            this.AutoQuitarBtn.UseVisualStyleBackColor = true;
            this.AutoQuitarBtn.Click += new System.EventHandler(this.AutoDesasignar_Click);
            // 
            // AutoTotalLbl
            // 
            this.AutoTotalLbl.Location = new System.Drawing.Point(421, 190);
            this.AutoTotalLbl.Name = "AutoTotalLbl";
            this.AutoTotalLbl.Size = new System.Drawing.Size(89, 21);
            this.AutoTotalLbl.TabIndex = 12;
            this.AutoTotalLbl.Text = "Total";
            this.AutoTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoListadoDgv
            // 
            this.AutoListadoDgv.AllowUserToAddRows = false;
            this.AutoListadoDgv.AllowUserToDeleteRows = false;
            this.AutoListadoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.AutoListadoDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AutoListadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoListadoDgv.Location = new System.Drawing.Point(516, 11);
            this.AutoListadoDgv.MultiSelect = false;
            this.AutoListadoDgv.Name = "AutoListadoDgv";
            this.AutoListadoDgv.ReadOnly = true;
            this.AutoListadoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AutoListadoDgv.Size = new System.Drawing.Size(357, 200);
            this.AutoListadoDgv.TabIndex = 13;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 511);
            this.Controls.Add(this.AutoListadoDgv);
            this.Controls.Add(this.AutoTotalLbl);
            this.Controls.Add(this.AutoQuitarBtn);
            this.Controls.Add(this.AutoDetallesDgv);
            this.Controls.Add(this.PersonaAutosDgv);
            this.Controls.Add(this.AutoAsignarBtn);
            this.Controls.Add(this.AutoMoficarBtn);
            this.Controls.Add(this.AutoBorrarBtn);
            this.Controls.Add(this.AutoAgregarBtn);
            this.Controls.Add(this.PersonaModificarBtn);
            this.Controls.Add(this.PersonaBorrarBtn);
            this.Controls.Add(this.PersonaAltaBtn);
            this.Controls.Add(this.PersonaListadoDgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI_FormClosing);
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaListadoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaAutosDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoDetallesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoListadoDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonaListadoDgv;
        private System.Windows.Forms.Button PersonaAltaBtn;
        private System.Windows.Forms.Button PersonaBorrarBtn;
        private System.Windows.Forms.Button PersonaModificarBtn;
        private System.Windows.Forms.Button AutoMoficarBtn;
        private System.Windows.Forms.Button AutoBorrarBtn;
        private System.Windows.Forms.Button AutoAgregarBtn;
        private System.Windows.Forms.Button AutoAsignarBtn;
        private System.Windows.Forms.DataGridView PersonaAutosDgv;
        private System.Windows.Forms.DataGridView AutoDetallesDgv;
        private System.Windows.Forms.Button AutoQuitarBtn;
        private System.Windows.Forms.Label AutoTotalLbl;
        private System.Windows.Forms.DataGridView AutoListadoDgv;
    }
}

