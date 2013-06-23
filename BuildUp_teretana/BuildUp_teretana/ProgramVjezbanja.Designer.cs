namespace BuildUp_teretana
{
    partial class frmProgramVjezbanja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodajSpravu = new System.Windows.Forms.Button();
            this.btnObrisiSpravu = new System.Windows.Forms.Button();
            this.lblVrijemeNaSpravi = new System.Windows.Forms.Label();
            this.txtVrijemeNaSpravi = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.grpNovoVrijeme = new System.Windows.Forms.GroupBox();
            this.grpOvotjedno = new System.Windows.Forms.GroupBox();
            this.lblOvotjedno = new System.Windows.Forms.Label();
            this.btnOvotjedno = new System.Windows.Forms.Button();
            this.txtOvotjedno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpNovoVrijeme.SuspendLayout();
            this.grpOvotjedno.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(688, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnDodajSpravu
            // 
            this.btnDodajSpravu.Location = new System.Drawing.Point(12, 28);
            this.btnDodajSpravu.Name = "btnDodajSpravu";
            this.btnDodajSpravu.Size = new System.Drawing.Size(82, 36);
            this.btnDodajSpravu.TabIndex = 1;
            this.btnDodajSpravu.Text = "Dodaj spravu u program";
            this.btnDodajSpravu.UseVisualStyleBackColor = true;
            this.btnDodajSpravu.Click += new System.EventHandler(this.btnDodajSpravu_Click);
            // 
            // btnObrisiSpravu
            // 
            this.btnObrisiSpravu.Location = new System.Drawing.Point(113, 28);
            this.btnObrisiSpravu.Name = "btnObrisiSpravu";
            this.btnObrisiSpravu.Size = new System.Drawing.Size(82, 36);
            this.btnObrisiSpravu.TabIndex = 2;
            this.btnObrisiSpravu.Text = "Obriši spravu iz programa";
            this.btnObrisiSpravu.UseVisualStyleBackColor = true;
            this.btnObrisiSpravu.Click += new System.EventHandler(this.btnObrisiSpravu_Click);
            // 
            // lblVrijemeNaSpravi
            // 
            this.lblVrijemeNaSpravi.AutoSize = true;
            this.lblVrijemeNaSpravi.Location = new System.Drawing.Point(13, 33);
            this.lblVrijemeNaSpravi.Name = "lblVrijemeNaSpravi";
            this.lblVrijemeNaSpravi.Size = new System.Drawing.Size(87, 13);
            this.lblVrijemeNaSpravi.TabIndex = 4;
            this.lblVrijemeNaSpravi.Text = "Vrijeme na spravi";
            // 
            // txtVrijemeNaSpravi
            // 
            this.txtVrijemeNaSpravi.Location = new System.Drawing.Point(106, 30);
            this.txtVrijemeNaSpravi.Name = "txtVrijemeNaSpravi";
            this.txtVrijemeNaSpravi.Size = new System.Drawing.Size(100, 20);
            this.txtVrijemeNaSpravi.TabIndex = 5;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(65, 56);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 6;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // grpNovoVrijeme
            // 
            this.grpNovoVrijeme.Controls.Add(this.lblVrijemeNaSpravi);
            this.grpNovoVrijeme.Controls.Add(this.btnPotvrdi);
            this.grpNovoVrijeme.Controls.Add(this.txtVrijemeNaSpravi);
            this.grpNovoVrijeme.Location = new System.Drawing.Point(469, 12);
            this.grpNovoVrijeme.Name = "grpNovoVrijeme";
            this.grpNovoVrijeme.Size = new System.Drawing.Size(212, 90);
            this.grpNovoVrijeme.TabIndex = 7;
            this.grpNovoVrijeme.TabStop = false;
            this.grpNovoVrijeme.Text = "Izmijeni vrijeme na spravi";
            // 
            // grpOvotjedno
            // 
            this.grpOvotjedno.Controls.Add(this.lblOvotjedno);
            this.grpOvotjedno.Controls.Add(this.btnOvotjedno);
            this.grpOvotjedno.Controls.Add(this.txtOvotjedno);
            this.grpOvotjedno.Location = new System.Drawing.Point(201, 2);
            this.grpOvotjedno.Name = "grpOvotjedno";
            this.grpOvotjedno.Size = new System.Drawing.Size(262, 100);
            this.grpOvotjedno.TabIndex = 8;
            this.grpOvotjedno.TabStop = false;
            this.grpOvotjedno.Text = "Ažuriraj vrijeme na spravi";
            this.grpOvotjedno.Visible = false;
            // 
            // lblOvotjedno
            // 
            this.lblOvotjedno.AutoSize = true;
            this.lblOvotjedno.Location = new System.Drawing.Point(4, 29);
            this.lblOvotjedno.Name = "lblOvotjedno";
            this.lblOvotjedno.Size = new System.Drawing.Size(138, 13);
            this.lblOvotjedno.TabIndex = 7;
            this.lblOvotjedno.Text = "Ovotjedno vrijeme na spravi";
            // 
            // btnOvotjedno
            // 
            this.btnOvotjedno.Location = new System.Drawing.Point(88, 52);
            this.btnOvotjedno.Name = "btnOvotjedno";
            this.btnOvotjedno.Size = new System.Drawing.Size(75, 23);
            this.btnOvotjedno.TabIndex = 9;
            this.btnOvotjedno.Text = "Potvrdi";
            this.btnOvotjedno.UseVisualStyleBackColor = true;
            this.btnOvotjedno.Click += new System.EventHandler(this.btnOvotjedno_Click);
            // 
            // txtOvotjedno
            // 
            this.txtOvotjedno.Location = new System.Drawing.Point(148, 26);
            this.txtOvotjedno.Name = "txtOvotjedno";
            this.txtOvotjedno.Size = new System.Drawing.Size(100, 20);
            this.txtOvotjedno.TabIndex = 8;
            // 
            // frmProgramVjezbanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 428);
            this.Controls.Add(this.grpOvotjedno);
            this.Controls.Add(this.grpNovoVrijeme);
            this.Controls.Add(this.btnObrisiSpravu);
            this.Controls.Add(this.btnDodajSpravu);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProgramVjezbanja";
            this.ShowIcon = false;
            this.Text = "ProgramVjezbanja";
            this.Load += new System.EventHandler(this.frmProgramVjezbanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpNovoVrijeme.ResumeLayout(false);
            this.grpNovoVrijeme.PerformLayout();
            this.grpOvotjedno.ResumeLayout(false);
            this.grpOvotjedno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodajSpravu;
        private System.Windows.Forms.Button btnObrisiSpravu;
        private System.Windows.Forms.Label lblVrijemeNaSpravi;
        private System.Windows.Forms.TextBox txtVrijemeNaSpravi;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.GroupBox grpNovoVrijeme;
        private System.Windows.Forms.GroupBox grpOvotjedno;
        private System.Windows.Forms.Label lblOvotjedno;
        private System.Windows.Forms.Button btnOvotjedno;
        private System.Windows.Forms.TextBox txtOvotjedno;
    }
}