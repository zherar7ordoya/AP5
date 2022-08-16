namespace CANCELOS_POO_2P
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
            this.Grilla1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Grilla2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModCliente = new System.Windows.Forms.Button();
            this.btnBajaCliente = new System.Windows.Forms.Button();
            this.btnAltaCliente = new System.Windows.Forms.Button();
            this.btnModPrestamo = new System.Windows.Forms.Button();
            this.btnBajaPrestamo = new System.Windows.Forms.Button();
            this.btnAltaPrestamo = new System.Windows.Forms.Button();
            this.Grilla3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Grilla4 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Grilla6 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Grilla5 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.Grilla7 = new System.Windows.Forms.DataGridView();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModFecha = new System.Windows.Forms.Button();
            this.btnPagarPrestamo = new System.Windows.Forms.Button();
            this.btnAsignarPrestamo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSumarAños = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSumarDias = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSumarMeses = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRestarMeses = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnRestarDias = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRestarAños = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDeshacerPago = new System.Windows.Forms.Button();
            this.btnDesasignarPrestamo = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla7)).BeginInit();
            this.SuspendLayout();
            // 
            // Grilla1
            // 
            this.Grilla1.AllowUserToAddRows = false;
            this.Grilla1.AllowUserToDeleteRows = false;
            this.Grilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla1.Location = new System.Drawing.Point(12, 94);
            this.Grilla1.Name = "Grilla1";
            this.Grilla1.ReadOnly = true;
            this.Grilla1.Size = new System.Drawing.Size(319, 150);
            this.Grilla1.TabIndex = 0;
            this.Grilla1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grilla1_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grilla 1 : Todos los Clientes";
            // 
            // Grilla2
            // 
            this.Grilla2.AllowUserToAddRows = false;
            this.Grilla2.AllowUserToDeleteRows = false;
            this.Grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla2.Location = new System.Drawing.Point(418, 94);
            this.Grilla2.Name = "Grilla2";
            this.Grilla2.ReadOnly = true;
            this.Grilla2.Size = new System.Drawing.Size(724, 150);
            this.Grilla2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grilla 2 : Todos los Préstamos";
            // 
            // btnModCliente
            // 
            this.btnModCliente.Location = new System.Drawing.Point(176, 249);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(75, 23);
            this.btnModCliente.TabIndex = 23;
            this.btnModCliente.Text = "Modificación";
            this.btnModCliente.UseVisualStyleBackColor = true;
            this.btnModCliente.Click += new System.EventHandler(this.btnModCliente_Click);
            // 
            // btnBajaCliente
            // 
            this.btnBajaCliente.Location = new System.Drawing.Point(94, 250);
            this.btnBajaCliente.Name = "btnBajaCliente";
            this.btnBajaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBajaCliente.TabIndex = 22;
            this.btnBajaCliente.Text = "Baja";
            this.btnBajaCliente.UseVisualStyleBackColor = true;
            this.btnBajaCliente.Click += new System.EventHandler(this.btnBajaCliente_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Location = new System.Drawing.Point(12, 250);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAltaCliente.TabIndex = 21;
            this.btnAltaCliente.Text = "Alta";
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnModPrestamo
            // 
            this.btnModPrestamo.Location = new System.Drawing.Point(582, 249);
            this.btnModPrestamo.Name = "btnModPrestamo";
            this.btnModPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnModPrestamo.TabIndex = 26;
            this.btnModPrestamo.Text = "Modificación";
            this.btnModPrestamo.UseVisualStyleBackColor = true;
            this.btnModPrestamo.Click += new System.EventHandler(this.btnModPrestamo_Click);
            // 
            // btnBajaPrestamo
            // 
            this.btnBajaPrestamo.Location = new System.Drawing.Point(500, 250);
            this.btnBajaPrestamo.Name = "btnBajaPrestamo";
            this.btnBajaPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnBajaPrestamo.TabIndex = 25;
            this.btnBajaPrestamo.Text = "Baja";
            this.btnBajaPrestamo.UseVisualStyleBackColor = true;
            this.btnBajaPrestamo.Click += new System.EventHandler(this.btnBajaPrestamo_Click);
            // 
            // btnAltaPrestamo
            // 
            this.btnAltaPrestamo.Location = new System.Drawing.Point(418, 250);
            this.btnAltaPrestamo.Name = "btnAltaPrestamo";
            this.btnAltaPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnAltaPrestamo.TabIndex = 24;
            this.btnAltaPrestamo.Text = "Alta";
            this.btnAltaPrestamo.UseVisualStyleBackColor = true;
            this.btnAltaPrestamo.Click += new System.EventHandler(this.btnAltaPrestamo_Click);
            // 
            // Grilla3
            // 
            this.Grilla3.AllowUserToAddRows = false;
            this.Grilla3.AllowUserToDeleteRows = false;
            this.Grilla3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla3.Location = new System.Drawing.Point(455, 301);
            this.Grilla3.Name = "Grilla3";
            this.Grilla3.ReadOnly = true;
            this.Grilla3.Size = new System.Drawing.Size(437, 140);
            this.Grilla3.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Grilla 3 : Todos los préstamos emitidos NO pagados. ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(895, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Grilla 4 : Todos los préstamos emitidos pagados.";
            // 
            // Grilla4
            // 
            this.Grilla4.AllowUserToAddRows = false;
            this.Grilla4.AllowUserToDeleteRows = false;
            this.Grilla4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla4.Location = new System.Drawing.Point(898, 301);
            this.Grilla4.Name = "Grilla4";
            this.Grilla4.ReadOnly = true;
            this.Grilla4.Size = new System.Drawing.Size(437, 140);
            this.Grilla4.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Grilla 6 : Préstamos emitidos pagados Cliente Seleccionado.";
            // 
            // Grilla6
            // 
            this.Grilla6.AllowUserToAddRows = false;
            this.Grilla6.AllowUserToDeleteRows = false;
            this.Grilla6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla6.Location = new System.Drawing.Point(12, 523);
            this.Grilla6.Name = "Grilla6";
            this.Grilla6.ReadOnly = true;
            this.Grilla6.Size = new System.Drawing.Size(469, 140);
            this.Grilla6.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Grilla 5 : Préstamos emitidos NO pagados Cliente seleccionado.";
            // 
            // Grilla5
            // 
            this.Grilla5.AllowUserToAddRows = false;
            this.Grilla5.AllowUserToDeleteRows = false;
            this.Grilla5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla5.Location = new System.Drawing.Point(12, 301);
            this.Grilla5.Name = "Grilla5";
            this.Grilla5.ReadOnly = true;
            this.Grilla5.Size = new System.Drawing.Size(437, 140);
            this.Grilla5.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(497, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Grilla 7 : Préstamos vencidos Cliente seleccionado ";
            // 
            // Grilla7
            // 
            this.Grilla7.AllowUserToAddRows = false;
            this.Grilla7.AllowUserToDeleteRows = false;
            this.Grilla7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla7.Location = new System.Drawing.Point(500, 523);
            this.Grilla7.Name = "Grilla7";
            this.Grilla7.ReadOnly = true;
            this.Grilla7.Size = new System.Drawing.Size(642, 140);
            this.Grilla7.TabIndex = 35;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Maroon;
            this.txtFecha.Location = new System.Drawing.Point(1185, 97);
            this.txtFecha.MaxLength = 10;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(121, 29);
            this.txtFecha.TabIndex = 37;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFecha_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1182, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Fecha Actual: ";
            // 
            // btnModFecha
            // 
            this.btnModFecha.BackColor = System.Drawing.Color.Tan;
            this.btnModFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnModFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnModFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModFecha.Location = new System.Drawing.Point(1195, 180);
            this.btnModFecha.Name = "btnModFecha";
            this.btnModFecha.Size = new System.Drawing.Size(98, 34);
            this.btnModFecha.TabIndex = 39;
            this.btnModFecha.Text = "Modificar Fecha";
            this.btnModFecha.UseVisualStyleBackColor = false;
            this.btnModFecha.Click += new System.EventHandler(this.btnModFecha_Click);
            // 
            // btnPagarPrestamo
            // 
            this.btnPagarPrestamo.BackColor = System.Drawing.Color.Tan;
            this.btnPagarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnPagarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnPagarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarPrestamo.Location = new System.Drawing.Point(12, 447);
            this.btnPagarPrestamo.Name = "btnPagarPrestamo";
            this.btnPagarPrestamo.Size = new System.Drawing.Size(102, 23);
            this.btnPagarPrestamo.TabIndex = 40;
            this.btnPagarPrestamo.Text = "Pagar Préstamo";
            this.btnPagarPrestamo.UseVisualStyleBackColor = false;
            this.btnPagarPrestamo.Click += new System.EventHandler(this.btnPagarPrestamo_Click);
            // 
            // btnAsignarPrestamo
            // 
            this.btnAsignarPrestamo.BackColor = System.Drawing.Color.Tan;
            this.btnAsignarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnAsignarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnAsignarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPrestamo.Location = new System.Drawing.Point(337, 146);
            this.btnAsignarPrestamo.Name = "btnAsignarPrestamo";
            this.btnAsignarPrestamo.Size = new System.Drawing.Size(75, 37);
            this.btnAsignarPrestamo.TabIndex = 41;
            this.btnAsignarPrestamo.Text = "Asignar Préstamo";
            this.btnAsignarPrestamo.UseVisualStyleBackColor = false;
            this.btnAsignarPrestamo.Click += new System.EventHandler(this.btnAsignarPrestamo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Se pagará o desasignará el Préstamo seleccionado en la Grilla 5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bodoni MT Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(485, 47);
            this.label10.TabIndex = 43;
            this.label10.Text = "Empresa de Préstamos";
            // 
            // btnSumarAños
            // 
            this.btnSumarAños.Location = new System.Drawing.Point(1285, 71);
            this.btnSumarAños.Name = "btnSumarAños";
            this.btnSumarAños.Size = new System.Drawing.Size(21, 20);
            this.btnSumarAños.TabIndex = 44;
            this.btnSumarAños.Text = "+";
            this.btnSumarAños.UseVisualStyleBackColor = true;
            this.btnSumarAños.Click += new System.EventHandler(this.btnSumarAños_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1289, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1192, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "D";
            // 
            // btnSumarDias
            // 
            this.btnSumarDias.Location = new System.Drawing.Point(1188, 71);
            this.btnSumarDias.Name = "btnSumarDias";
            this.btnSumarDias.Size = new System.Drawing.Size(21, 20);
            this.btnSumarDias.TabIndex = 46;
            this.btnSumarDias.Text = "+";
            this.btnSumarDias.UseVisualStyleBackColor = true;
            this.btnSumarDias.Click += new System.EventHandler(this.btnSumarDias_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1239, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "M";
            // 
            // btnSumarMeses
            // 
            this.btnSumarMeses.Location = new System.Drawing.Point(1235, 71);
            this.btnSumarMeses.Name = "btnSumarMeses";
            this.btnSumarMeses.Size = new System.Drawing.Size(21, 20);
            this.btnSumarMeses.TabIndex = 48;
            this.btnSumarMeses.Text = "+";
            this.btnSumarMeses.UseVisualStyleBackColor = true;
            this.btnSumarMeses.Click += new System.EventHandler(this.btnSumarMeses_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1238, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "M";
            // 
            // btnRestarMeses
            // 
            this.btnRestarMeses.Location = new System.Drawing.Point(1234, 132);
            this.btnRestarMeses.Name = "btnRestarMeses";
            this.btnRestarMeses.Size = new System.Drawing.Size(21, 20);
            this.btnRestarMeses.TabIndex = 54;
            this.btnRestarMeses.Text = "-";
            this.btnRestarMeses.UseVisualStyleBackColor = true;
            this.btnRestarMeses.Click += new System.EventHandler(this.btnRestarMeses_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1190, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "D";
            // 
            // btnRestarDias
            // 
            this.btnRestarDias.Location = new System.Drawing.Point(1187, 132);
            this.btnRestarDias.Name = "btnRestarDias";
            this.btnRestarDias.Size = new System.Drawing.Size(21, 20);
            this.btnRestarDias.TabIndex = 52;
            this.btnRestarDias.Text = "-";
            this.btnRestarDias.UseVisualStyleBackColor = true;
            this.btnRestarDias.Click += new System.EventHandler(this.btnRestarDias_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1289, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "A";
            // 
            // btnRestarAños
            // 
            this.btnRestarAños.Location = new System.Drawing.Point(1284, 132);
            this.btnRestarAños.Name = "btnRestarAños";
            this.btnRestarAños.Size = new System.Drawing.Size(21, 20);
            this.btnRestarAños.TabIndex = 50;
            this.btnRestarAños.Text = "-";
            this.btnRestarAños.UseVisualStyleBackColor = true;
            this.btnRestarAños.Click += new System.EventHandler(this.btnRestarAños_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Maroon;
            this.lblFecha.Location = new System.Drawing.Point(1265, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 13);
            this.lblFecha.TabIndex = 56;
            this.lblFecha.Text = "label17";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(951, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 65);
            this.label17.TabIndex = 57;
            this.label17.Text = "La fecha se modifica con la ayuda de los\r\nbotones, o manualmente presionando\r\nent" +
    "er en la caja de texto o presionando\r\nel botón modificar para validar el cambio " +
    "\r\nrealizado de forma manual.\r\n";
            // 
            // btnDeshacerPago
            // 
            this.btnDeshacerPago.BackColor = System.Drawing.Color.Tan;
            this.btnDeshacerPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnDeshacerPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnDeshacerPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacerPago.Location = new System.Drawing.Point(12, 669);
            this.btnDeshacerPago.Name = "btnDeshacerPago";
            this.btnDeshacerPago.Size = new System.Drawing.Size(102, 23);
            this.btnDeshacerPago.TabIndex = 58;
            this.btnDeshacerPago.Text = "Deshacer Pago";
            this.btnDeshacerPago.UseVisualStyleBackColor = false;
            this.btnDeshacerPago.Click += new System.EventHandler(this.btnDeshacerPago_Click);
            // 
            // btnDesasignarPrestamo
            // 
            this.btnDesasignarPrestamo.BackColor = System.Drawing.Color.Tan;
            this.btnDesasignarPrestamo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnDesasignarPrestamo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.btnDesasignarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasignarPrestamo.Location = new System.Drawing.Point(121, 446);
            this.btnDesasignarPrestamo.Name = "btnDesasignarPrestamo";
            this.btnDesasignarPrestamo.Size = new System.Drawing.Size(120, 23);
            this.btnDesasignarPrestamo.TabIndex = 59;
            this.btnDesasignarPrestamo.Text = "Desasignar Préstamo";
            this.btnDesasignarPrestamo.UseVisualStyleBackColor = false;
            this.btnDesasignarPrestamo.Click += new System.EventHandler(this.btnDesasignarPrestamo_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(120, 674);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(292, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "Se deshace el pago del préstamo seleccionado en la Grilla 6";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(504, 22);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 38);
            this.btnInfo.TabIndex = 61;
            this.btnInfo.Text = "Información";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 703);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnDesasignarPrestamo);
            this.Controls.Add(this.btnDeshacerPago);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnRestarMeses);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnRestarDias);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnRestarAños);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSumarMeses);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSumarDias);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSumarAños);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAsignarPrestamo);
            this.Controls.Add(this.btnPagarPrestamo);
            this.Controls.Add(this.btnModFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Grilla7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Grilla6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Grilla5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grilla4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Grilla3);
            this.Controls.Add(this.btnModPrestamo);
            this.Controls.Add(this.btnBajaPrestamo);
            this.Controls.Add(this.btnAltaPrestamo);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.btnBajaCliente);
            this.Controls.Add(this.btnAltaCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grilla2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grilla1);
            this.Name = "Form1";
            this.Text = "Parcial 2 - POO - Cancelos Alejandro Martín";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grilla1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grilla1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grilla2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModCliente;
        private System.Windows.Forms.Button btnBajaCliente;
        private System.Windows.Forms.Button btnAltaCliente;
        private System.Windows.Forms.Button btnModPrestamo;
        private System.Windows.Forms.Button btnBajaPrestamo;
        private System.Windows.Forms.Button btnAltaPrestamo;
        private System.Windows.Forms.DataGridView Grilla3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Grilla4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Grilla6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Grilla5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Grilla7;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModFecha;
        private System.Windows.Forms.Button btnPagarPrestamo;
        private System.Windows.Forms.Button btnAsignarPrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSumarAños;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSumarDias;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSumarMeses;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRestarMeses;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRestarDias;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnRestarAños;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDeshacerPago;
        private System.Windows.Forms.Button btnDesasignarPrestamo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnInfo;
    }
}

