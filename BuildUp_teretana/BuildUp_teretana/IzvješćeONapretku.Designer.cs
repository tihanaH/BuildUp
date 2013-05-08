namespace BuildUp_teretana
{
    partial class FrmIzvješćeONapretku
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
            this.btuPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btuPrint
            // 
            this.btuPrint.Location = new System.Drawing.Point(170, 483);
            this.btuPrint.Name = "btuPrint";
            this.btuPrint.Size = new System.Drawing.Size(123, 39);
            this.btuPrint.TabIndex = 0;
            this.btuPrint.Text = "Print";
            this.btuPrint.UseVisualStyleBackColor = true;
            // 
            // FrmIzvješćeONapretku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 534);
            this.Controls.Add(this.btuPrint);
            this.Name = "FrmIzvješćeONapretku";
            this.Text = "BuildUp Izvješće o napretku";
            this.Load += new System.EventHandler(this.IzvješćeONapretku_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btuPrint;
    }
}