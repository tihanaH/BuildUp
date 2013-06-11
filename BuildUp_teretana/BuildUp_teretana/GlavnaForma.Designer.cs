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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGlavnaForma));
            this.btnClanovi = new System.Windows.Forms.Button();
            this.btnMjestoVjezbanja = new System.Windows.Forms.Button();
            this.btnClanarine = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClanovi
            // 
            this.btnClanovi.Location = new System.Drawing.Point(12, 171);
            this.btnClanovi.Name = "btnClanovi";
            this.btnClanovi.Size = new System.Drawing.Size(117, 49);
            this.btnClanovi.TabIndex = 0;
            this.btnClanovi.Text = "Članovi";
            this.btnClanovi.UseVisualStyleBackColor = true;
            this.btnClanovi.Click += new System.EventHandler(this.btnClanovi_Click);
            // 
            // btnMjestoVjezbanja
            // 
            this.btnMjestoVjezbanja.Location = new System.Drawing.Point(170, 171);
            this.btnMjestoVjezbanja.Name = "btnMjestoVjezbanja";
            this.btnMjestoVjezbanja.Size = new System.Drawing.Size(117, 49);
            this.btnMjestoVjezbanja.TabIndex = 1;
            this.btnMjestoVjezbanja.Text = "Mjesto vježbanja";
            this.btnMjestoVjezbanja.UseVisualStyleBackColor = true;
            this.btnMjestoVjezbanja.Click += new System.EventHandler(this.btnMjestoVjezbanja_Click);
            // 
            // btnClanarine
            // 
            this.btnClanarine.Location = new System.Drawing.Point(90, 239);
            this.btnClanarine.Name = "btnClanarine";
            this.btnClanarine.Size = new System.Drawing.Size(117, 49);
            this.btnClanarine.TabIndex = 2;
            this.btnClanarine.Text = "Članarine";
            this.btnClanarine.UseVisualStyleBackColor = true;
            this.btnClanarine.Click += new System.EventHandler(this.btnClanarine_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(69, 311);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(155, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmGlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClanarine);
            this.Controls.Add(this.btnMjestoVjezbanja);
            this.Controls.Add(this.btnClanovi);
            this.Name = "frmGlavnaForma";
            this.Text = "GlavnaForma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClanovi;
        private System.Windows.Forms.Button btnMjestoVjezbanja;
        private System.Windows.Forms.Button btnClanarine;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}