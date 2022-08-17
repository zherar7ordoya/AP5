
namespace UI
{
    partial class TaTeTi1JugadorForm
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
            this.IniciarJuegoButton = new System.Windows.Forms.Button();
            this.OLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.XCombobox = new System.Windows.Forms.ComboBox();
            this.OCombobox = new System.Windows.Forms.ComboBox();
            this.JugarButton = new System.Windows.Forms.Button();
            this.JugadorLabel = new System.Windows.Forms.Label();
            this.TableroPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // IniciarJuegoButton
            // 
            this.IniciarJuegoButton.Enabled = false;
            this.IniciarJuegoButton.Location = new System.Drawing.Point(118, 439);
            this.IniciarJuegoButton.Name = "IniciarJuegoButton";
            this.IniciarJuegoButton.Size = new System.Drawing.Size(90, 23);
            this.IniciarJuegoButton.TabIndex = 38;
            this.IniciarJuegoButton.Text = "Iniciar Juego";
            this.IniciarJuegoButton.UseVisualStyleBackColor = true;
            // 
            // OLabel
            // 
            this.OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OLabel.Location = new System.Drawing.Point(224, 215);
            this.OLabel.Name = "OLabel";
            this.OLabel.Size = new System.Drawing.Size(100, 31);
            this.OLabel.TabIndex = 37;
            this.OLabel.Text = "O";
            this.OLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XLabel
            // 
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(12, 215);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(100, 31);
            this.XLabel.TabIndex = 36;
            this.XLabel.Text = "X";
            this.XLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XCombobox
            // 
            this.XCombobox.Enabled = false;
            this.XCombobox.FormattingEnabled = true;
            this.XCombobox.Location = new System.Drawing.Point(12, 249);
            this.XCombobox.Name = "XCombobox";
            this.XCombobox.Size = new System.Drawing.Size(100, 21);
            this.XCombobox.TabIndex = 35;
            // 
            // OCombobox
            // 
            this.OCombobox.Enabled = false;
            this.OCombobox.FormattingEnabled = true;
            this.OCombobox.Location = new System.Drawing.Point(224, 249);
            this.OCombobox.Name = "OCombobox";
            this.OCombobox.Size = new System.Drawing.Size(100, 21);
            this.OCombobox.TabIndex = 34;
            // 
            // JugarButton
            // 
            this.JugarButton.Enabled = false;
            this.JugarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugarButton.Location = new System.Drawing.Point(118, 184);
            this.JugarButton.Name = "JugarButton";
            this.JugarButton.Size = new System.Drawing.Size(100, 100);
            this.JugarButton.TabIndex = 31;
            this.JugarButton.Text = "X";
            this.JugarButton.UseVisualStyleBackColor = true;
            // 
            // JugadorLabel
            // 
            this.JugadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugadorLabel.Location = new System.Drawing.Point(118, 150);
            this.JugadorLabel.Name = "JugadorLabel";
            this.JugadorLabel.Size = new System.Drawing.Size(100, 31);
            this.JugadorLabel.TabIndex = 33;
            this.JugadorLabel.Text = "Jugador";
            this.JugadorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableroPanel
            // 
            this.TableroPanel.Location = new System.Drawing.Point(330, 12);
            this.TableroPanel.Name = "TableroPanel";
            this.TableroPanel.Size = new System.Drawing.Size(450, 450);
            this.TableroPanel.TabIndex = 32;
            // 
            // TaTeTi1JugadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.IniciarJuegoButton);
            this.Controls.Add(this.OLabel);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.XCombobox);
            this.Controls.Add(this.OCombobox);
            this.Controls.Add(this.JugarButton);
            this.Controls.Add(this.JugadorLabel);
            this.Controls.Add(this.TableroPanel);
            this.Name = "TaTeTi1JugadorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ta-Te-Tí para 1 jugador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniciarJuegoButton;
        private System.Windows.Forms.Label OLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.ComboBox XCombobox;
        private System.Windows.Forms.ComboBox OCombobox;
        private System.Windows.Forms.Button JugarButton;
        private System.Windows.Forms.Label JugadorLabel;
        private System.Windows.Forms.Panel TableroPanel;
    }
}