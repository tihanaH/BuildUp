namespace BuildUp_teretana
{
    partial class FrmDodajMjestoVjezbanja
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
            this.lblIDMjestaVjezbanja = new System.Windows.Forms.Label();
            this.lblNazivMjestaVjezbanja = new System.Windows.Forms.Label();
            this.lblMaxRazina = new System.Windows.Forms.Label();
            this.lblKalorijeRazina = new System.Windows.Forms.Label();
            this.txtIDMjestaVjezbanja = new System.Windows.Forms.TextBox();
            this.txtPotrosnjaKalorijaRazina = new System.Windows.Forms.TextBox();
            this.txtMaxRazina = new System.Windows.Forms.TextBox();
            this.txtNazivMjestaVjezbanja = new System.Windows.Forms.TextBox();
            this.btnDodajMjestoVjezbanjaOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIDMjestaVjezbanja
            // 
            this.lblIDMjestaVjezbanja.AutoSize = true;
            this.lblIDMjestaVjezbanja.Location = new System.Drawing.Point(22, 30);
            this.lblIDMjestaVjezbanja.Name = "lblIDMjestaVjezbanja";
            this.lblIDMjestaVjezbanja.Size = new System.Drawing.Size(99, 13);
            this.lblIDMjestaVjezbanja.TabIndex = 0;
            this.lblIDMjestaVjezbanja.Text = "ID mjesta vježbanja";
            // 
            // lblNazivMjestaVjezbanja
            // 
            this.lblNazivMjestaVjezbanja.AutoSize = true;
            this.lblNazivMjestaVjezbanja.Location = new System.Drawing.Point(22, 79);
            this.lblNazivMjestaVjezbanja.Name = "lblNazivMjestaVjezbanja";
            this.lblNazivMjestaVjezbanja.Size = new System.Drawing.Size(34, 13);
            this.lblNazivMjestaVjezbanja.TabIndex = 1;
            this.lblNazivMjestaVjezbanja.Text = "Naziv";
            // 
            // lblMaxRazina
            // 
            this.lblMaxRazina.AutoSize = true;
            this.lblMaxRazina.Location = new System.Drawing.Point(22, 126);
            this.lblMaxRazina.Name = "lblMaxRazina";
            this.lblMaxRazina.Size = new System.Drawing.Size(58, 13);
            this.lblMaxRazina.TabIndex = 2;
            this.lblMaxRazina.Text = "Max razina";
            // 
            // lblKalorijeRazina
            // 
            this.lblKalorijeRazina.AutoSize = true;
            this.lblKalorijeRazina.Location = new System.Drawing.Point(119, 126);
            this.lblKalorijeRazina.Name = "lblKalorijeRazina";
            this.lblKalorijeRazina.Size = new System.Drawing.Size(147, 13);
            this.lblKalorijeRazina.TabIndex = 3;
            this.lblKalorijeRazina.Text = "Potrošnja kalorija - 1. razina/h";
            // 
            // txtIDMjestaVjezbanja
            // 
            this.txtIDMjestaVjezbanja.Location = new System.Drawing.Point(136, 27);
            this.txtIDMjestaVjezbanja.Name = "txtIDMjestaVjezbanja";
            this.txtIDMjestaVjezbanja.Size = new System.Drawing.Size(62, 20);
            this.txtIDMjestaVjezbanja.TabIndex = 4;
            // 
            // txtPotrosnjaKalorijaRazina
            // 
            this.txtPotrosnjaKalorijaRazina.Location = new System.Drawing.Point(122, 143);
            this.txtPotrosnjaKalorijaRazina.Name = "txtPotrosnjaKalorijaRazina";
            this.txtPotrosnjaKalorijaRazina.Size = new System.Drawing.Size(78, 20);
            this.txtPotrosnjaKalorijaRazina.TabIndex = 5;
            // 
            // txtMaxRazina
            // 
            this.txtMaxRazina.Location = new System.Drawing.Point(25, 143);
            this.txtMaxRazina.Name = "txtMaxRazina";
            this.txtMaxRazina.Size = new System.Drawing.Size(62, 20);
            this.txtMaxRazina.TabIndex = 6;
            // 
            // txtNazivMjestaVjezbanja
            // 
            this.txtNazivMjestaVjezbanja.Location = new System.Drawing.Point(74, 76);
            this.txtNazivMjestaVjezbanja.Name = "txtNazivMjestaVjezbanja";
            this.txtNazivMjestaVjezbanja.Size = new System.Drawing.Size(187, 20);
            this.txtNazivMjestaVjezbanja.TabIndex = 7;
            // 
            // btnDodajMjestoVjezbanjaOK
            // 
            this.btnDodajMjestoVjezbanjaOK.Location = new System.Drawing.Point(95, 200);
            this.btnDodajMjestoVjezbanjaOK.Name = "btnDodajMjestoVjezbanjaOK";
            this.btnDodajMjestoVjezbanjaOK.Size = new System.Drawing.Size(85, 37);
            this.btnDodajMjestoVjezbanjaOK.TabIndex = 8;
            this.btnDodajMjestoVjezbanjaOK.Text = "OK";
            this.btnDodajMjestoVjezbanjaOK.UseVisualStyleBackColor = true;
            // 
            // FrmDodajMjestoVjezbanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 259);
            this.Controls.Add(this.btnDodajMjestoVjezbanjaOK);
            this.Controls.Add(this.txtNazivMjestaVjezbanja);
            this.Controls.Add(this.txtMaxRazina);
            this.Controls.Add(this.txtPotrosnjaKalorijaRazina);
            this.Controls.Add(this.txtIDMjestaVjezbanja);
            this.Controls.Add(this.lblKalorijeRazina);
            this.Controls.Add(this.lblMaxRazina);
            this.Controls.Add(this.lblNazivMjestaVjezbanja);
            this.Controls.Add(this.lblIDMjestaVjezbanja);
            this.Name = "FrmDodajMjestoVjezbanja";
            this.Text = "Dodaj mjesto vježbanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDMjestaVjezbanja;
        private System.Windows.Forms.Label lblNazivMjestaVjezbanja;
        private System.Windows.Forms.Label lblMaxRazina;
        private System.Windows.Forms.Label lblKalorijeRazina;
        private System.Windows.Forms.TextBox txtIDMjestaVjezbanja;
        private System.Windows.Forms.TextBox txtPotrosnjaKalorijaRazina;
        private System.Windows.Forms.TextBox txtMaxRazina;
        private System.Windows.Forms.TextBox txtNazivMjestaVjezbanja;
        private System.Windows.Forms.Button btnDodajMjestoVjezbanjaOK;
    }
}