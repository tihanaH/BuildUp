namespace BuildUp_teretana
{
    partial class frmGlavnaForma
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
            this.btnClanovi = new System.Windows.Forms.Button();
            this.btnMjestoVjezbanja = new System.Windows.Forms.Button();
            this.btnClanarine = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClanovi
            // 
            this.btnClanovi.Location = new System.Drawing.Point(62, 138);
            this.btnClanovi.Name = "btnClanovi";
            this.btnClanovi.Size = new System.Drawing.Size(117, 49);
            this.btnClanovi.TabIndex = 0;
            this.btnClanovi.Text = "Članovi";
            this.btnClanovi.UseVisualStyleBackColor = true;
            // 
            // btnMjestoVjezbanja
            // 
            this.btnMjestoVjezbanja.Location = new System.Drawing.Point(198, 138);
            this.btnMjestoVjezbanja.Name = "btnMjestoVjezbanja";
            this.btnMjestoVjezbanja.Size = new System.Drawing.Size(117, 49);
            this.btnMjestoVjezbanja.TabIndex = 1;
            this.btnMjestoVjezbanja.Text = "Mjesto vježbanja";
            this.btnMjestoVjezbanja.UseVisualStyleBackColor = true;
            // 
            // btnClanarine
            // 
            this.btnClanarine.Location = new System.Drawing.Point(129, 193);
            this.btnClanarine.Name = "btnClanarine";
            this.btnClanarine.Size = new System.Drawing.Size(117, 49);
            this.btnClanarine.TabIndex = 2;
            this.btnClanarine.Text = "Članarine";
            this.btnClanarine.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(109, 274);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 322);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClanarine);
            this.Controls.Add(this.btnMjestoVjezbanja);
            this.Controls.Add(this.btnClanovi);
            this.Name = "frmGlavnaForma";
            this.Text = "GlavnaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClanovi;
        private System.Windows.Forms.Button btnMjestoVjezbanja;
        private System.Windows.Forms.Button btnClanarine;
        private System.Windows.Forms.Button btnLogout;

    }
}