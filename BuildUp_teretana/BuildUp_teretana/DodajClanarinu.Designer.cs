namespace BuildUp_teretana
{
    partial class DodajClanarinu
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
            this.btnPotvrdi = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBrojDolazaka = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtBrojDolazaka = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.btnPotvrdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Controls.Add(this.button1);
            this.btnPotvrdi.Controls.Add(this.lblBrojDolazaka);
            this.btnPotvrdi.Controls.Add(this.lblTip);
            this.btnPotvrdi.Controls.Add(this.txtBrojDolazaka);
            this.btnPotvrdi.Controls.Add(this.cmbTip);
            this.btnPotvrdi.Location = new System.Drawing.Point(9, 10);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Padding = new System.Windows.Forms.Padding(2);
            this.btnPotvrdi.Size = new System.Drawing.Size(200, 219);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.TabStop = false;
            this.btnPotvrdi.Text = "Dodavanje nove članarine";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBrojDolazaka
            // 
            this.lblBrojDolazaka.AutoSize = true;
            this.lblBrojDolazaka.Location = new System.Drawing.Point(22, 103);
            this.lblBrojDolazaka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojDolazaka.Name = "lblBrojDolazaka";
            this.lblBrojDolazaka.Size = new System.Drawing.Size(71, 13);
            this.lblBrojDolazaka.TabIndex = 3;
            this.lblBrojDolazaka.Text = "Broj dolazaka";
            this.lblBrojDolazaka.Visible = false;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(22, 46);
            this.lblTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(68, 13);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip članarine";
            // 
            // txtBrojDolazaka
            // 
            this.txtBrojDolazaka.Location = new System.Drawing.Point(99, 101);
            this.txtBrojDolazaka.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrojDolazaka.Name = "txtBrojDolazaka";
            this.txtBrojDolazaka.Size = new System.Drawing.Size(42, 20);
            this.txtBrojDolazaka.TabIndex = 1;
            this.txtBrojDolazaka.Visible = false;
            // 
            // cmbTip
            // 
            this.cmbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Items.AddRange(new object[] {
            "M",
            "G"});
            this.cmbTip.Location = new System.Drawing.Point(99, 43);
            this.cmbTip.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(42, 21);
            this.cmbTip.TabIndex = 0;
            this.cmbTip.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DodajClanarinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 248);
            this.Controls.Add(this.btnPotvrdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DodajClanarinu";
            this.ShowIcon = false;
            this.Text = "DodajClanarinu";
            this.Load += new System.EventHandler(this.DodajClanarinu_Load);
            this.btnPotvrdi.ResumeLayout(false);
            this.btnPotvrdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox btnPotvrdi;
        private System.Windows.Forms.Label lblBrojDolazaka;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtBrojDolazaka;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Button button1;
    }
}