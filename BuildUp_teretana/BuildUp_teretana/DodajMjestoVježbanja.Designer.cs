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
            this.lblKalorijeRazina.Location = new System.Drawing.Point(22, 166);
            this.lblKalorijeRazina.Name = "lblKalorijeRazina";
            this.lblKalorijeRazina.Size = new System.Drawing.Size(155, 13);
            this.lblKalorijeRazina.TabIndex = 3;
            this.lblKalorijeRazina.Text = "Potrošnja kalorija za 1. razinu/h";
            // 
            // FrmDodajMjestoVjezbanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 349);
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
    }
}