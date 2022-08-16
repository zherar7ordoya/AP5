namespace Tonattto_POO_2P
{
    partial class Form1
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
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.grdPrestamos = new System.Windows.Forms.DataGridView();
            this.grdPrestamosNoPagados = new System.Windows.Forms.DataGridView();
            this.grdPrestamosPagados = new System.Windows.Forms.DataGridView();
            this.grdPrestamosVencidosCliente = new System.Windows.Forms.DataGridView();
            this.grdPrestamosNoPagadosCliente = new System.Windows.Forms.DataGridView();
            this.grdPrestamosPagadosCliente = new System.Windows.Forms.DataGridView();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosNoPagados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosPagados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosVencidosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosNoPagadosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosPagadosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.BackgroundColor = System.Drawing.Color.White;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(12, 21);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.Size = new System.Drawing.Size(240, 150);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellEnter);
            // 
            // grdPrestamos
            // 
            this.grdPrestamos.AllowUserToAddRows = false;
            this.grdPrestamos.AllowUserToDeleteRows = false;
            this.grdPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.grdPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamos.Location = new System.Drawing.Point(393, 21);
            this.grdPrestamos.Name = "grdPrestamos";
            this.grdPrestamos.ReadOnly = true;
            this.grdPrestamos.Size = new System.Drawing.Size(670, 150);
            this.grdPrestamos.TabIndex = 1;
            // 
            // grdPrestamosNoPagados
            // 
            this.grdPrestamosNoPagados.AllowUserToAddRows = false;
            this.grdPrestamosNoPagados.AllowUserToDeleteRows = false;
            this.grdPrestamosNoPagados.BackgroundColor = System.Drawing.Color.White;
            this.grdPrestamosNoPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosNoPagados.Location = new System.Drawing.Point(393, 230);
            this.grdPrestamosNoPagados.Name = "grdPrestamosNoPagados";
            this.grdPrestamosNoPagados.ReadOnly = true;
            this.grdPrestamosNoPagados.Size = new System.Drawing.Size(315, 150);
            this.grdPrestamosNoPagados.TabIndex = 2;
            // 
            // grdPrestamosPagados
            // 
            this.grdPrestamosPagados.AllowUserToAddRows = false;
            this.grdPrestamosPagados.AllowUserToDeleteRows = false;
            this.grdPrestamosPagados.BackgroundColor = System.Drawing.Color.White;
            this.grdPrestamosPagados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosPagados.Location = new System.Drawing.Point(748, 230);
            this.grdPrestamosPagados.Name = "grdPrestamosPagados";
            this.grdPrestamosPagados.ReadOnly = true;
            this.grdPrestamosPagados.Size = new System.Drawing.Size(315, 150);
            this.grdPrestamosPagados.TabIndex = 3;
            // 
            // grdPrestamosVencidosCliente
            // 
            this.grdPrestamosVencidosCliente.AllowUserToAddRows = false;
            this.grdPrestamosVencidosCliente.AllowUserToDeleteRows = false;
            this.grdPrestamosVencidosCliente.BackgroundColor = System.Drawing.Color.White;
            this.grdPrestamosVencidosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosVencidosCliente.Location = new System.Drawing.Point(393, 409);
            this.grdPrestamosVencidosCliente.Name = "grdPrestamosVencidosCliente";
            this.grdPrestamosVencidosCliente.ReadOnly = true;
            this.grdPrestamosVencidosCliente.Size = new System.Drawing.Size(670, 150);
            this.grdPrestamosVencidosCliente.TabIndex = 4;
            // 
            // grdPrestamosNoPagadosCliente
            // 
            this.grdPrestamosNoPagadosCliente.AllowUserToAddRows = false;
            this.grdPrestamosNoPagadosCliente.AllowUserToDeleteRows = false;
            this.grdPrestamosNoPagadosCliente.BackgroundColor = System.Drawing.Color.White;
            this.grdPrestamosNoPagadosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosNoPagadosCliente.Location = new System.Drawing.Point(12, 230);
            this.grdPrestamosNoPagadosCliente.Name = "grdPrestamosNoPagadosCliente";
            this.grdPrestamosNoPagadosCliente.ReadOnly = true;
            this.grdPrestamosNoPagadosCliente.Size = new System.Drawing.Size(315, 150);
            this.grdPrestamosNoPagadosCliente.TabIndex = 5;
            // 
            // grdPrestamosPagadosCliente
            // 
            this.grdPrestamosPagadosCliente.AllowUserToAddRows = false;
            this.grdPrestamosPagadosCliente.AllowUserToDeleteRows = false;
            this.grdPrestamosPagadosCliente.BackgroundColor = System.Drawing.Color.White;
            this.grdPrestamosPagadosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamosPagadosCliente.Location = new System.Drawing.Point(12, 409);
            this.grdPrestamosPagadosCliente.Name = "grdPrestamosPagadosCliente";
            this.grdPrestamosPagadosCliente.ReadOnly = true;
            this.grdPrestamosPagadosCliente.Size = new System.Drawing.Size(315, 150);
            this.grdPrestamosPagadosCliente.TabIndex = 6;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(292, 60);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 11;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(292, 89);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 10;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(177, 177);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCliente.TabIndex = 14;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(96, 177);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 13;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(12, 177);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 12;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.Location = new System.Drawing.Point(555, 177);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPrestamo.TabIndex = 17;
            this.btnModificarPrestamo.Text = "Modificar";
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(474, 177);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPrestamo.TabIndex = 16;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(393, 177);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPrestamo.TabIndex = 15;
            this.btnAgregarPrestamo.Text = "Agregar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(675, 179);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(122, 20);
            this.txtFecha.TabIndex = 18;
            this.txtFecha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFecha_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Prestamos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Prestamos no pagados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Prestamos pagados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Prestamos vencidos cliente seleccionado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Prestamos no pagados cliente seleccionado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Prestamos pagados cliente seleccionado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 571);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.grdPrestamosPagadosCliente);
            this.Controls.Add(this.grdPrestamosNoPagadosCliente);
            this.Controls.Add(this.grdPrestamosVencidosCliente);
            this.Controls.Add(this.grdPrestamosPagados);
            this.Controls.Add(this.grdPrestamosNoPagados);
            this.Controls.Add(this.grdPrestamos);
            this.Controls.Add(this.grdClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosNoPagados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosPagados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosVencidosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosNoPagadosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamosPagadosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.DataGridView grdPrestamos;
        private System.Windows.Forms.DataGridView grdPrestamosNoPagados;
        private System.Windows.Forms.DataGridView grdPrestamosPagados;
        private System.Windows.Forms.DataGridView grdPrestamosVencidosCliente;
        private System.Windows.Forms.DataGridView grdPrestamosNoPagadosCliente;
        private System.Windows.Forms.DataGridView grdPrestamosPagadosCliente;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

