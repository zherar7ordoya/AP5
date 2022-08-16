
namespace PrimerPracticoOrientador
{
    partial class Principal
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
            this.dgvAuto = new System.Windows.Forms.DataGridView();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarPersona = new System.Windows.Forms.Button();
            this.btnBorrarPersona = new System.Windows.Forms.Button();
            this.btnModificarPersona = new System.Windows.Forms.Button();
            this.btnCargharAuto = new System.Windows.Forms.Button();
            this.btnBorrarAuto = new System.Windows.Forms.Button();
            this.btnModificarAuto = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnVistaPropietario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuto
            // 
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.Location = new System.Drawing.Point(350, 38);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.Size = new System.Drawing.Size(542, 309);
            this.dgvAuto.TabIndex = 0;
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Location = new System.Drawing.Point(5, 38);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(339, 309);
            this.dgvPersona.TabIndex = 2;
            this.dgvPersona.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersona_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Auto";
            // 
            // btnCargarPersona
            // 
            this.btnCargarPersona.Location = new System.Drawing.Point(5, 353);
            this.btnCargarPersona.Name = "btnCargarPersona";
            this.btnCargarPersona.Size = new System.Drawing.Size(109, 37);
            this.btnCargarPersona.TabIndex = 5;
            this.btnCargarPersona.Text = "Cargar";
            this.btnCargarPersona.UseVisualStyleBackColor = true;
            this.btnCargarPersona.Click += new System.EventHandler(this.btnCargarPersona_Click);
            // 
            // btnBorrarPersona
            // 
            this.btnBorrarPersona.Location = new System.Drawing.Point(120, 353);
            this.btnBorrarPersona.Name = "btnBorrarPersona";
            this.btnBorrarPersona.Size = new System.Drawing.Size(109, 37);
            this.btnBorrarPersona.TabIndex = 6;
            this.btnBorrarPersona.Text = "Borrar";
            this.btnBorrarPersona.UseVisualStyleBackColor = true;
            this.btnBorrarPersona.Click += new System.EventHandler(this.btnBorrarPersona_Click);
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Location = new System.Drawing.Point(235, 353);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(109, 37);
            this.btnModificarPersona.TabIndex = 7;
            this.btnModificarPersona.Text = "Modificar";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            this.btnModificarPersona.Click += new System.EventHandler(this.btnModificarPersona_Click);
            // 
            // btnCargharAuto
            // 
            this.btnCargharAuto.Location = new System.Drawing.Point(438, 353);
            this.btnCargharAuto.Name = "btnCargharAuto";
            this.btnCargharAuto.Size = new System.Drawing.Size(109, 37);
            this.btnCargharAuto.TabIndex = 8;
            this.btnCargharAuto.Text = "Cargar";
            this.btnCargharAuto.UseVisualStyleBackColor = true;
            this.btnCargharAuto.Click += new System.EventHandler(this.btnCargharAuto_Click);
            // 
            // btnBorrarAuto
            // 
            this.btnBorrarAuto.Location = new System.Drawing.Point(575, 353);
            this.btnBorrarAuto.Name = "btnBorrarAuto";
            this.btnBorrarAuto.Size = new System.Drawing.Size(109, 37);
            this.btnBorrarAuto.TabIndex = 9;
            this.btnBorrarAuto.Text = "Borrar";
            this.btnBorrarAuto.UseVisualStyleBackColor = true;
            this.btnBorrarAuto.Click += new System.EventHandler(this.btnBorrarAuto_Click);
            // 
            // btnModificarAuto
            // 
            this.btnModificarAuto.Location = new System.Drawing.Point(707, 353);
            this.btnModificarAuto.Name = "btnModificarAuto";
            this.btnModificarAuto.Size = new System.Drawing.Size(109, 37);
            this.btnModificarAuto.TabIndex = 10;
            this.btnModificarAuto.Text = "Modificar";
            this.btnModificarAuto.UseVisualStyleBackColor = true;
            this.btnModificarAuto.Click += new System.EventHandler(this.btnModificarAuto_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(171, 421);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(236, 34);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar auto a persona";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnVistaPropietario
            // 
            this.btnVistaPropietario.Location = new System.Drawing.Point(494, 421);
            this.btnVistaPropietario.Name = "btnVistaPropietario";
            this.btnVistaPropietario.Size = new System.Drawing.Size(236, 34);
            this.btnVistaPropietario.TabIndex = 12;
            this.btnVistaPropietario.Text = "Ver lista de autos con propietario";
            this.btnVistaPropietario.UseVisualStyleBackColor = true;
            this.btnVistaPropietario.Click += new System.EventHandler(this.btnVistaPropietario_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 467);
            this.Controls.Add(this.btnVistaPropietario);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnModificarAuto);
            this.Controls.Add(this.btnBorrarAuto);
            this.Controls.Add(this.btnCargharAuto);
            this.Controls.Add(this.btnModificarPersona);
            this.Controls.Add(this.btnBorrarPersona);
            this.Controls.Add(this.btnCargarPersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersona);
            this.Controls.Add(this.dgvAuto);
            this.Name = "Principal";
            this.Text = "Pantalla principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarPersona;
        private System.Windows.Forms.Button btnBorrarPersona;
        private System.Windows.Forms.Button btnModificarPersona;
        private System.Windows.Forms.Button btnCargharAuto;
        private System.Windows.Forms.Button btnBorrarAuto;
        private System.Windows.Forms.Button btnModificarAuto;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnVistaPropietario;
        public System.Windows.Forms.DataGridView dgvAuto;
        public System.Windows.Forms.DataGridView dgvPersona;
    }
}

