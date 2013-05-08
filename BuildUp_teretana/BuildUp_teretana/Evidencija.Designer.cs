namespace BuildUp_teretana
{
    partial class FrmEvidencija
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
            this.lblTrenutniBrojDolazaka = new System.Windows.Forms.Label();
            this.lblMaxBrojDolazaka = new System.Windows.Forms.Label();
            this.btnDolazakOk = new System.Windows.Forms.Button();
            this.txtTrenutniBrojDolazaka = new System.Windows.Forms.TextBox();
            this.chkPotvrdiDolazak = new System.Windows.Forms.CheckBox();
            this.txtMaxBrojDolazaka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTrenutniBrojDolazaka
            // 
            this.lblTrenutniBrojDolazaka.AutoSize = true;
            this.lblTrenutniBrojDolazaka.Location = new System.Drawing.Point(20, 29);
            this.lblTrenutniBrojDolazaka.Name = "lblTrenutniBrojDolazaka";
            this.lblTrenutniBrojDolazaka.Size = new System.Drawing.Size(112, 13);
            this.lblTrenutniBrojDolazaka.TabIndex = 0;
            this.lblTrenutniBrojDolazaka.Text = "Trenutni broj dolazaka";
            // 
            // lblMaxBrojDolazaka
            // 
            this.lblMaxBrojDolazaka.AutoSize = true;
            this.lblMaxBrojDolazaka.Location = new System.Drawing.Point(166, 29);
            this.lblMaxBrojDolazaka.Name = "lblMaxBrojDolazaka";
            this.lblMaxBrojDolazaka.Size = new System.Drawing.Size(93, 13);
            this.lblMaxBrojDolazaka.TabIndex = 3;
            this.lblMaxBrojDolazaka.Text = "Max broj dolazaka";
            // 
            // btnDolazakOk
            // 
            this.btnDolazakOk.Location = new System.Drawing.Point(87, 129);
            this.btnDolazakOk.Name = "btnDolazakOk";
            this.btnDolazakOk.Size = new System.Drawing.Size(99, 39);
            this.btnDolazakOk.TabIndex = 4;
            this.btnDolazakOk.Text = "OK";
            this.btnDolazakOk.UseVisualStyleBackColor = true;
            // 
            // txtTrenutniBrojDolazaka
            // 
            this.txtTrenutniBrojDolazaka.Location = new System.Drawing.Point(44, 45);
            this.txtTrenutniBrojDolazaka.Name = "txtTrenutniBrojDolazaka";
            this.txtTrenutniBrojDolazaka.Size = new System.Drawing.Size(69, 20);
            this.txtTrenutniBrojDolazaka.TabIndex = 5;
            // 
            // chkPotvrdiDolazak
            // 
            this.chkPotvrdiDolazak.AutoSize = true;
            this.chkPotvrdiDolazak.Location = new System.Drawing.Point(87, 86);
            this.chkPotvrdiDolazak.Name = "chkPotvrdiDolazak";
            this.chkPotvrdiDolazak.Size = new System.Drawing.Size(99, 17);
            this.chkPotvrdiDolazak.TabIndex = 6;
            this.chkPotvrdiDolazak.Text = "Potvrdi dolazak";
            this.chkPotvrdiDolazak.UseVisualStyleBackColor = true;
            // 
            // txtMaxBrojDolazaka
            // 
            this.txtMaxBrojDolazaka.Location = new System.Drawing.Point(169, 45);
            this.txtMaxBrojDolazaka.Name = "txtMaxBrojDolazaka";
            this.txtMaxBrojDolazaka.Size = new System.Drawing.Size(69, 20);
            this.txtMaxBrojDolazaka.TabIndex = 7;
            // 
            // FrmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 209);
            this.Controls.Add(this.txtMaxBrojDolazaka);
            this.Controls.Add(this.chkPotvrdiDolazak);
            this.Controls.Add(this.txtTrenutniBrojDolazaka);
            this.Controls.Add(this.btnDolazakOk);
            this.Controls.Add(this.lblMaxBrojDolazaka);
            this.Controls.Add(this.lblTrenutniBrojDolazaka);
            this.Name = "FrmEvidencija";
            this.Text = "Evidencija";
            this.Load += new System.EventHandler(this.FrmEvidencija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrenutniBrojDolazaka;
        private System.Windows.Forms.Label lblMaxBrojDolazaka;
        private System.Windows.Forms.Button btnDolazakOk;
        private System.Windows.Forms.TextBox txtTrenutniBrojDolazaka;
        private System.Windows.Forms.CheckBox chkPotvrdiDolazak;
        private System.Windows.Forms.TextBox txtMaxBrojDolazaka;
    }
}