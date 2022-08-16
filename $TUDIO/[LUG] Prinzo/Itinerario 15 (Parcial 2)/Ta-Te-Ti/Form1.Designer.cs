namespace Enunciado11 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.Portada = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.btnJugador = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Portada
      // 
      this.Portada.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Portada.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Portada.Location = new System.Drawing.Point(12, 12);
      this.Portada.Multiline = true;
      this.Portada.Name = "Portada";
      this.Portada.ReadOnly = true;
      this.Portada.Size = new System.Drawing.Size(237, 60);
      this.Portada.TabIndex = 1;
      this.Portada.Text = "Gerardo Tordoya\r\nTrabajo Práctico 3 (2021-05-06)\r\nProgramación I (Comisión 1-ON)\r" +
    "\nAnalista Programador (UAI)";
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(255, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(450, 450);
      this.panel1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(62, 150);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(112, 31);
      this.label1.TabIndex = 3;
      this.label1.Text = "Jugador";
      // 
      // btnJugador
      // 
      this.btnJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnJugador.Location = new System.Drawing.Point(68, 184);
      this.btnJugador.Name = "btnJugador";
      this.btnJugador.Size = new System.Drawing.Size(100, 100);
      this.btnJugador.TabIndex = 1;
      this.btnJugador.Text = "X";
      this.btnJugador.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(716, 474);
      this.Controls.Add(this.btnJugador);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.Portada);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox Portada;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnJugador;
  }
}

