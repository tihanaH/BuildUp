namespace BuildUp_teretana
{
    partial class FrmClanarine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNovaClanarina = new System.Windows.Forms.Button();
            this.btnObrisiClanarinu = new System.Windows.Forms.Button();
            this.btnPromijeniClanarinu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNovaClanarina
            // 
            this.btnNovaClanarina.Location = new System.Drawing.Point(75, 273);
            this.btnNovaClanarina.Name = "btnNovaClanarina";
            this.btnNovaClanarina.Size = new System.Drawing.Size(100, 39);
            this.btnNovaClanarina.TabIndex = 1;
            this.btnNovaClanarina.Text = "Nova članarina";
            this.btnNovaClanarina.UseVisualStyleBackColor = true;
            // 
            // btnObrisiClanarinu
            // 
            this.btnObrisiClanarinu.Location = new System.Drawing.Point(363, 273);
            this.btnObrisiClanarinu.Name = "btnObrisiClanarinu";
            this.btnObrisiClanarinu.Size = new System.Drawing.Size(100, 39);
            this.btnObrisiClanarinu.TabIndex = 2;
            this.btnObrisiClanarinu.Text = "Obriši";
            this.btnObrisiClanarinu.UseVisualStyleBackColor = true;
            // 
            // btnPromijeniClanarinu
            // 
            this.btnPromijeniClanarinu.Location = new System.Drawing.Point(228, 273);
            this.btnPromijeniClanarinu.Name = "btnPromijeniClanarinu";
            this.btnPromijeniClanarinu.Size = new System.Drawing.Size(100, 39);
            this.btnPromijeniClanarinu.TabIndex = 3;
            this.btnPromijeniClanarinu.Text = "Promijeni";
            this.btnPromijeniClanarinu.UseVisualStyleBackColor = true;
            // 
            // FrmClanarine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 350);
            this.Controls.Add(this.btnPromijeniClanarinu);
            this.Controls.Add(this.btnObrisiClanarinu);
            this.Controls.Add(this.btnNovaClanarina);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmClanarine";
            this.Text = "Članarine";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovaClanarina;
        private System.Windows.Forms.Button btnObrisiClanarinu;
        private System.Windows.Forms.Button btnPromijeniClanarinu;
    }
}