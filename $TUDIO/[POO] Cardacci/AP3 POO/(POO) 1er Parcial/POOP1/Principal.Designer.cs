
namespace PrimerParcialPOO
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
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.dgvBeneficiarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnBorrarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarEmpleado = new System.Windows.Forms.Button();
            this.btnModificarAdelanto = new System.Windows.Forms.Button();
            this.btnBorrarAdelanto = new System.Windows.Forms.Button();
            this.btnAgregarAdelanto = new System.Windows.Forms.Button();
            this.rbDirectivo = new System.Windows.Forms.RadioButton();
            this.rbAdministrativo = new System.Windows.Forms.RadioButton();
            this.rbOperario = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnAsignarDeuda = new System.Windows.Forms.Button();
            this.btnPagoDeuda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeudaTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(184, 51);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.Size = new System.Drawing.Size(444, 111);
            this.dgvEmpleado.TabIndex = 0;
            this.dgvEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellClick);
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AllowUserToAddRows = false;
            this.dgvAdelantos.AllowUserToDeleteRows = false;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.Location = new System.Drawing.Point(4, 204);
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.Size = new System.Drawing.Size(748, 121);
            this.dgvAdelantos.TabIndex = 1;
            // 
            // dgvBeneficiarios
            // 
            this.dgvBeneficiarios.AllowUserToAddRows = false;
            this.dgvBeneficiarios.AllowUserToDeleteRows = false;
            this.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiarios.Location = new System.Drawing.Point(4, 390);
            this.dgvBeneficiarios.Name = "dgvBeneficiarios";
            this.dgvBeneficiarios.ReadOnly = true;
            this.dgvBeneficiarios.Size = new System.Drawing.Size(835, 117);
            this.dgvBeneficiarios.TabIndex = 2;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(758, 51);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarEmpleado.TabIndex = 3;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnBorrarEmpleado
            // 
            this.btnBorrarEmpleado.Location = new System.Drawing.Point(758, 95);
            this.btnBorrarEmpleado.Name = "btnBorrarEmpleado";
            this.btnBorrarEmpleado.Size = new System.Drawing.Size(91, 23);
            this.btnBorrarEmpleado.TabIndex = 4;
            this.btnBorrarEmpleado.Text = "Borrar";
            this.btnBorrarEmpleado.UseVisualStyleBackColor = true;
            this.btnBorrarEmpleado.Click += new System.EventHandler(this.btnBorrarEmpleado_Click);
            // 
            // btnModificarEmpleado
            // 
            this.btnModificarEmpleado.Location = new System.Drawing.Point(758, 139);
            this.btnModificarEmpleado.Name = "btnModificarEmpleado";
            this.btnModificarEmpleado.Size = new System.Drawing.Size(91, 23);
            this.btnModificarEmpleado.TabIndex = 5;
            this.btnModificarEmpleado.Text = "Modificar";
            this.btnModificarEmpleado.UseVisualStyleBackColor = true;
            this.btnModificarEmpleado.Click += new System.EventHandler(this.btnModificarEmpleado_Click);
            // 
            // btnModificarAdelanto
            // 
            this.btnModificarAdelanto.Location = new System.Drawing.Point(758, 302);
            this.btnModificarAdelanto.Name = "btnModificarAdelanto";
            this.btnModificarAdelanto.Size = new System.Drawing.Size(91, 23);
            this.btnModificarAdelanto.TabIndex = 8;
            this.btnModificarAdelanto.Text = "Modificar";
            this.btnModificarAdelanto.UseVisualStyleBackColor = true;
            this.btnModificarAdelanto.Click += new System.EventHandler(this.btnModificarAdelanto_Click);
            // 
            // btnBorrarAdelanto
            // 
            this.btnBorrarAdelanto.Location = new System.Drawing.Point(758, 252);
            this.btnBorrarAdelanto.Name = "btnBorrarAdelanto";
            this.btnBorrarAdelanto.Size = new System.Drawing.Size(91, 23);
            this.btnBorrarAdelanto.TabIndex = 7;
            this.btnBorrarAdelanto.Text = "Borrar";
            this.btnBorrarAdelanto.UseVisualStyleBackColor = true;
            this.btnBorrarAdelanto.Click += new System.EventHandler(this.btnBorrarAdelanto_Click);
            // 
            // btnAgregarAdelanto
            // 
            this.btnAgregarAdelanto.Location = new System.Drawing.Point(758, 204);
            this.btnAgregarAdelanto.Name = "btnAgregarAdelanto";
            this.btnAgregarAdelanto.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarAdelanto.TabIndex = 6;
            this.btnAgregarAdelanto.Text = "Agregar";
            this.btnAgregarAdelanto.UseVisualStyleBackColor = true;
            this.btnAgregarAdelanto.Click += new System.EventHandler(this.btnAgregarAdelanto_Click);
            // 
            // rbDirectivo
            // 
            this.rbDirectivo.AutoSize = true;
            this.rbDirectivo.Location = new System.Drawing.Point(54, 78);
            this.rbDirectivo.Name = "rbDirectivo";
            this.rbDirectivo.Size = new System.Drawing.Size(67, 17);
            this.rbDirectivo.TabIndex = 9;
            this.rbDirectivo.TabStop = true;
            this.rbDirectivo.Text = "Directivo";
            this.rbDirectivo.UseVisualStyleBackColor = true;
            this.rbDirectivo.CheckedChanged += new System.EventHandler(this.rbDirectivo_CheckedChanged);
            // 
            // rbAdministrativo
            // 
            this.rbAdministrativo.AutoSize = true;
            this.rbAdministrativo.Location = new System.Drawing.Point(54, 110);
            this.rbAdministrativo.Name = "rbAdministrativo";
            this.rbAdministrativo.Size = new System.Drawing.Size(90, 17);
            this.rbAdministrativo.TabIndex = 10;
            this.rbAdministrativo.TabStop = true;
            this.rbAdministrativo.Text = "Administrativo";
            this.rbAdministrativo.UseVisualStyleBackColor = true;
            this.rbAdministrativo.CheckedChanged += new System.EventHandler(this.rbAdministrativo_CheckedChanged);
            // 
            // rbOperario
            // 
            this.rbOperario.AutoSize = true;
            this.rbOperario.Location = new System.Drawing.Point(54, 142);
            this.rbOperario.Name = "rbOperario";
            this.rbOperario.Size = new System.Drawing.Size(65, 17);
            this.rbOperario.TabIndex = 11;
            this.rbOperario.TabStop = true;
            this.rbOperario.Text = "Operario";
            this.rbOperario.UseVisualStyleBackColor = true;
            this.rbOperario.CheckedChanged += new System.EventHandler(this.rbOperario_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(54, 51);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(125, 17);
            this.rbTodos.TabIndex = 12;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los empleados";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // btnAsignarDeuda
            // 
            this.btnAsignarDeuda.Location = new System.Drawing.Point(24, 346);
            this.btnAsignarDeuda.Name = "btnAsignarDeuda";
            this.btnAsignarDeuda.Size = new System.Drawing.Size(155, 38);
            this.btnAsignarDeuda.TabIndex = 13;
            this.btnAsignarDeuda.Text = "Asignar empleado a deuda";
            this.btnAsignarDeuda.UseVisualStyleBackColor = true;
            this.btnAsignarDeuda.Click += new System.EventHandler(this.btnAsignarDeuda_Click);
            // 
            // btnPagoDeuda
            // 
            this.btnPagoDeuda.Location = new System.Drawing.Point(220, 346);
            this.btnPagoDeuda.Name = "btnPagoDeuda";
            this.btnPagoDeuda.Size = new System.Drawing.Size(155, 38);
            this.btnPagoDeuda.TabIndex = 14;
            this.btnPagoDeuda.Text = "Pagar adelanto";
            this.btnPagoDeuda.UseVisualStyleBackColor = true;
            this.btnPagoDeuda.Click += new System.EventHandler(this.btnPagoDeuda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deuda total: ";
            // 
            // lblDeudaTotal
            // 
            this.lblDeudaTotal.AutoSize = true;
            this.lblDeudaTotal.Location = new System.Drawing.Point(86, 526);
            this.lblDeudaTotal.Name = "lblDeudaTotal";
            this.lblDeudaTotal.Size = new System.Drawing.Size(0, 13);
            this.lblDeudaTotal.TabIndex = 16;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 566);
            this.Controls.Add(this.lblDeudaTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagoDeuda);
            this.Controls.Add(this.btnAsignarDeuda);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbOperario);
            this.Controls.Add(this.rbAdministrativo);
            this.Controls.Add(this.rbDirectivo);
            this.Controls.Add(this.btnModificarAdelanto);
            this.Controls.Add(this.btnBorrarAdelanto);
            this.Controls.Add(this.btnAgregarAdelanto);
            this.Controls.Add(this.btnModificarEmpleado);
            this.Controls.Add(this.btnBorrarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.dgvBeneficiarios);
            this.Controls.Add(this.dgvAdelantos);
            this.Controls.Add(this.dgvEmpleado);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private System.Windows.Forms.DataGridView dgvBeneficiarios;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnBorrarEmpleado;
        private System.Windows.Forms.Button btnModificarEmpleado;
        private System.Windows.Forms.Button btnModificarAdelanto;
        private System.Windows.Forms.Button btnBorrarAdelanto;
        private System.Windows.Forms.Button btnAgregarAdelanto;
        private System.Windows.Forms.RadioButton rbDirectivo;
        private System.Windows.Forms.RadioButton rbAdministrativo;
        private System.Windows.Forms.RadioButton rbOperario;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button btnAsignarDeuda;
        private System.Windows.Forms.Button btnPagoDeuda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeudaTotal;
    }
}

