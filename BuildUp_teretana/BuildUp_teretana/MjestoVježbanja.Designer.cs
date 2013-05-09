namespace BuildUp_teretana
{
    partial class FrmMjestoVježbanja
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
            this.dgvMjestaVjezbanja = new System.Windows.Forms.DataGridView();
            this.btnDodajMjestoVjezbanja = new System.Windows.Forms.Button();
            this.btnBrisiMjestoVjezbanja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjestaVjezbanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMjestaVjezbanja
            // 
            this.dgvMjestaVjezbanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjestaVjezbanja.Location = new System.Drawing.Point(12, 12);
            this.dgvMjestaVjezbanja.Name = "dgvMjestaVjezbanja";
            this.dgvMjestaVjezbanja.Size = new System.Drawing.Size(500, 225);
            this.dgvMjestaVjezbanja.TabIndex = 0;
            // 
            // btnDodajMjestoVjezbanja
            // 
            this.btnDodajMjestoVjezbanja.Location = new System.Drawing.Point(111, 276);
            this.btnDodajMjestoVjezbanja.Name = "btnDodajMjestoVjezbanja";
            this.btnDodajMjestoVjezbanja.Size = new System.Drawing.Size(102, 38);
            this.btnDodajMjestoVjezbanja.TabIndex = 1;
            this.btnDodajMjestoVjezbanja.Text = "Dodaj";
            this.btnDodajMjestoVjezbanja.UseVisualStyleBackColor = true;
            // 
            // btnBrisiMjestoVjezbanja
            // 
            this.btnBrisiMjestoVjezbanja.Location = new System.Drawing.Point(281, 276);
            this.btnBrisiMjestoVjezbanja.Name = "btnBrisiMjestoVjezbanja";
            this.btnBrisiMjestoVjezbanja.Size = new System.Drawing.Size(102, 38);
            this.btnBrisiMjestoVjezbanja.TabIndex = 2;
            this.btnBrisiMjestoVjezbanja.Text = "Obriši";
            this.btnBrisiMjestoVjezbanja.UseVisualStyleBackColor = true;
            // 
            // FrmMjestoVježbanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 347);
            this.Controls.Add(this.btnBrisiMjestoVjezbanja);
            this.Controls.Add(this.btnDodajMjestoVjezbanja);
            this.Controls.Add(this.dgvMjestaVjezbanja);
            this.Name = "FrmMjestoVježbanja";
            this.Text = "Mjesto Vježbanja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjestaVjezbanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMjestaVjezbanja;
        private System.Windows.Forms.Button btnDodajMjestoVjezbanja;
        private System.Windows.Forms.Button btnBrisiMjestoVjezbanja;
    }
}