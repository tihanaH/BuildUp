namespace BuildUp_teretana
{
    partial class FrmDodajČlanuMjestoVježbanja
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
            this.btnDodajMjestoVjezbanjaClanOK = new System.Windows.Forms.Button();
            this.lblIDMjestaVjezbanja = new System.Windows.Forms.Label();
            this.cmbRazina = new System.Windows.Forms.ComboBox();
            this.lblNazivMjestaVjezbanja = new System.Windows.Forms.Label();
            this.lblRazina = new System.Windows.Forms.Label();
            this.txtIDMjestaVjezbanjaClan = new System.Windows.Forms.TextBox();
            this.txtNazivMjestaVjezbanjaClan = new System.Windows.Forms.TextBox();
            this.lblKalorije = new System.Windows.Forms.Label();
            this.txtKalorije = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodajMjestoVjezbanjaClanOK
            // 
            this.btnDodajMjestoVjezbanjaClanOK.Location = new System.Drawing.Point(80, 157);
            this.btnDodajMjestoVjezbanjaClanOK.Name = "btnDodajMjestoVjezbanjaClanOK";
            this.btnDodajMjestoVjezbanjaClanOK.Size = new System.Drawing.Size(96, 32);
            this.btnDodajMjestoVjezbanjaClanOK.TabIndex = 0;
            this.btnDodajMjestoVjezbanjaClanOK.Text = "OK";
            this.btnDodajMjestoVjezbanjaClanOK.UseVisualStyleBackColor = true;
            // 
            // lblIDMjestaVjezbanja
            // 
            this.lblIDMjestaVjezbanja.AutoSize = true;
            this.lblIDMjestaVjezbanja.Location = new System.Drawing.Point(23, 29);
            this.lblIDMjestaVjezbanja.Name = "lblIDMjestaVjezbanja";
            this.lblIDMjestaVjezbanja.Size = new System.Drawing.Size(99, 13);
            this.lblIDMjestaVjezbanja.TabIndex = 1;
            this.lblIDMjestaVjezbanja.Text = "ID mjesta vježbanja";
            // 
            // cmbRazina
            // 
            this.cmbRazina.FormattingEnabled = true;
            this.cmbRazina.Location = new System.Drawing.Point(26, 104);
            this.cmbRazina.Name = "cmbRazina";
            this.cmbRazina.Size = new System.Drawing.Size(96, 21);
            this.cmbRazina.TabIndex = 2;
            // 
            // lblNazivMjestaVjezbanja
            // 
            this.lblNazivMjestaVjezbanja.AutoSize = true;
            this.lblNazivMjestaVjezbanja.Location = new System.Drawing.Point(153, 29);
            this.lblNazivMjestaVjezbanja.Name = "lblNazivMjestaVjezbanja";
            this.lblNazivMjestaVjezbanja.Size = new System.Drawing.Size(34, 13);
            this.lblNazivMjestaVjezbanja.TabIndex = 3;
            this.lblNazivMjestaVjezbanja.Text = "Naziv";
            this.lblNazivMjestaVjezbanja.Click += new System.EventHandler(this.lblNazivMjestaVjezbanja_Click);
            // 
            // lblRazina
            // 
            this.lblRazina.AutoSize = true;
            this.lblRazina.Location = new System.Drawing.Point(23, 88);
            this.lblRazina.Name = "lblRazina";
            this.lblRazina.Size = new System.Drawing.Size(40, 13);
            this.lblRazina.TabIndex = 4;
            this.lblRazina.Text = "Razina";
            // 
            // txtIDMjestaVjezbanjaClan
            // 
            this.txtIDMjestaVjezbanjaClan.Location = new System.Drawing.Point(26, 45);
            this.txtIDMjestaVjezbanjaClan.Name = "txtIDMjestaVjezbanjaClan";
            this.txtIDMjestaVjezbanjaClan.Size = new System.Drawing.Size(96, 20);
            this.txtIDMjestaVjezbanjaClan.TabIndex = 5;
            // 
            // txtNazivMjestaVjezbanjaClan
            // 
            this.txtNazivMjestaVjezbanjaClan.Location = new System.Drawing.Point(156, 45);
            this.txtNazivMjestaVjezbanjaClan.Name = "txtNazivMjestaVjezbanjaClan";
            this.txtNazivMjestaVjezbanjaClan.Size = new System.Drawing.Size(96, 20);
            this.txtNazivMjestaVjezbanjaClan.TabIndex = 6;
            // 
            // lblKalorije
            // 
            this.lblKalorije.AutoSize = true;
            this.lblKalorije.Location = new System.Drawing.Point(153, 88);
            this.lblKalorije.Name = "lblKalorije";
            this.lblKalorije.Size = new System.Drawing.Size(33, 13);
            this.lblKalorije.TabIndex = 7;
            this.lblKalorije.Text = "Cal/h";
            // 
            // txtKalorije
            // 
            this.txtKalorije.Location = new System.Drawing.Point(156, 105);
            this.txtKalorije.Name = "txtKalorije";
            this.txtKalorije.Size = new System.Drawing.Size(96, 20);
            this.txtKalorije.TabIndex = 8;
            // 
            // FrmDodajČlanuMjestoVježbanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 220);
            this.Controls.Add(this.txtKalorije);
            this.Controls.Add(this.lblKalorije);
            this.Controls.Add(this.txtNazivMjestaVjezbanjaClan);
            this.Controls.Add(this.txtIDMjestaVjezbanjaClan);
            this.Controls.Add(this.lblRazina);
            this.Controls.Add(this.lblNazivMjestaVjezbanja);
            this.Controls.Add(this.cmbRazina);
            this.Controls.Add(this.lblIDMjestaVjezbanja);
            this.Controls.Add(this.btnDodajMjestoVjezbanjaClanOK);
            this.Name = "FrmDodajČlanuMjestoVježbanja";
            this.Text = "Dodaj mjesto vježbanja - Član";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajMjestoVjezbanjaClanOK;
        private System.Windows.Forms.Label lblIDMjestaVjezbanja;
        private System.Windows.Forms.ComboBox cmbRazina;
        private System.Windows.Forms.Label lblNazivMjestaVjezbanja;
        private System.Windows.Forms.Label lblRazina;
        private System.Windows.Forms.TextBox txtIDMjestaVjezbanjaClan;
        private System.Windows.Forms.TextBox txtNazivMjestaVjezbanjaClan;
        private System.Windows.Forms.Label lblKalorije;
        private System.Windows.Forms.TextBox txtKalorije;
    }
}